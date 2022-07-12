#Region "About"
' / --------------------------------------------------------------------------------
' / Developer : Mr.Surapon Yodsanga (Thongkorn Tubtimkrob)
' / eMail : thongkorn@hotmail.com
' / URL: http://www.g2gnet.com (Khon Kaen - Thailand)
' / Facebook: https://www.facebook.com/g2gnet (For Thailand)
' / Facebook: https://www.facebook.com/commonindy (Worldwide)
' / More Info: http://www.g2gnet.com/webboard
' /
' / Purpose: Sample code for sfGridControl of Syncfusion Community.
' / Microsoft Visual Basic .NET (2010) & MS Access 2010.
' /
' / This is open source code under @CopyLeft by Thongkorn Tubtimkrob.
' / You can modify and/or distribute without to inform the developer.
' / --------------------------------------------------------------------------------
#End Region

Imports System.Data.OleDb
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools
Imports Syncfusion.WinForms.DataGrid
Imports Syncfusion.WinForms.DataGrid.Enums
Imports Syncfusion.WinForms.DataGridConverter
'/
Imports Syncfusion.Pdf
Imports Syncfusion.Pdf.Grid
Imports Syncfusion.Pdf.Graphics
Imports Syncfusion.Windows.PdfViewer
Imports Syncfusion.WinForms.DataGridConverter.Events
Imports Syncfusion.WinForms.DataGrid.Styles

'// Getting Started with Syncfusion WinForms DataGrid.
'// https://help.syncfusion.com/windowsforms/datagrid/gettingstarted
'// https://youtu.be/ShhjvfqfrxM

'// Export to PDF in WinForms DataGrid (SfDataGrid).
'// https://help.syncfusion.com/windowsforms/datagrid/exporttopdf

Public Class frmPrintSfGrid

    Private strPathPDF As String = MyPath(Application.StartupPath)

    ' / --------------------------------------------------------------------------------
    Private Sub frmPrintSfGrid_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call ConnectDataBase()  '/ Connect MS Access DataBase.
        Call GridSetting()  '/ Setting sfGrid
        Call RetrieveData() '/ Show Products data.
        '/ TabControlAdv.
        With TabControlAdv1
            .TabStyle = GetType(Syncfusion.Windows.Forms.Tools.TabRendererOffice2016Black)
            .FocusOnTabClick = False
            .Alignment = TabAlignment.Left
            .RotateTextWhenVertical = True
            .ImageAlignmentR = RelativeImageAlignment.AboveText
        End With
    End Sub

    ' / --------------------------------------------------------------------------------
    Private Sub RetrieveData()
        strSQL = _
            " SELECT Products.ProductID, Products.ProductName, Products.CategoryID, Products.QuantityPerUnit, " & _
            " Products.UnitPrice, Products.UnitsInStock " & _
            " FROM Products " & _
            " ORDER BY ProductID "
        '//
        If Conn.State = ConnectionState.Closed Then Conn.Open()
        '// Data Adapter. 
        DA = New OleDbDataAdapter(strSQL, Conn)
        '/ Fill Data Set. 
        DS = New DataSet
        DA.Fill(DS)
        Me.SfDataGrid1.DataSource = DS.Tables(0)
        DA.Dispose()
        DS.Dispose()
        Conn.Close()
    End Sub

    ' / --------------------------------------------------------------------------------
    Sub GridSetting()
        Me.SfDataGrid1.Columns.Add(New GridNumericColumn() With { _
                                   .MappingName = "ProductID", _
                                   .HeaderText = "Product ID", _
                                    .NumberFormatInfo = New System.Globalization.NumberFormatInfo() With { _
                                    .NumberDecimalDigits = 0, _
                                    .NumberGroupSeparator = "" _
                                   }})
        Me.SfDataGrid1.Columns.Add(New GridTextColumn() With {.MappingName = "ProductName", .HeaderText = "Product Name"})
        Me.SfDataGrid1.Columns.Add(New GridTextColumn() With {.MappingName = "QuantityPerUnit", .HeaderText = "Quantity Per Unit"})
        '/ UnitPrice
        Me.SfDataGrid1.Columns.Add(New GridNumericColumn() With { _
                                   .MappingName = "UnitPrice", _
                                   .HeaderText = "Unit Price ", _
                                   .FormatMode = Syncfusion.WinForms.Input.Enums.FormatMode.Currency _
                                   })
        '/ UnitsInStock
        Me.SfDataGrid1.Columns.Add(New GridNumericColumn() With { _
                                   .MappingName = "UnitsInStock", _
                                   .HeaderText = "Units In Stock", _
                                    .NumberFormatInfo = New System.Globalization.NumberFormatInfo() With { _
                                    .NegativeSign = "-", _
                                    .NumberDecimalDigits = 0, _
                                    .NumberGroupSeparator = "" _
                                   }})
        '// Formatting sfDataGrid
        With Me.SfDataGrid1
            .SelectionMode = GridSelectionMode.Extended
            .AutoExpandGroups = True
            .AutoGenerateColumns = False
            .AutoSizeColumnsMode = AutoSizeColumnsMode.Fill
            .ShowGroupDropArea = False
            .Style.HeaderStyle.Font = New GridFontInfo(New Font("Tahoma", 11, FontStyle.Bold))
            .Style.CellStyle.Font = New GridFontInfo(New Font("Tahoma", 10))
        End With
    End Sub

    ' / --------------------------------------------------------------------------------
    ' / sfButton Syncfusion.
    Private Sub btnPreview1_Click(sender As System.Object, e As System.EventArgs) Handles btnPreview.Click
        '/ Create a folder "PDF", if it doesn't exist.
        If Not System.IO.Directory.Exists(strPathPDF) Then System.IO.Directory.CreateDirectory(strPathPDF & "PDF")
        Dim options As New PdfExportingOptions()
        With options
            .AutoColumnWidth = True
            '.ExcludeColumns.Add("ProductID")
        End With
        '/ Event Handler for change color option.
        AddHandler options.Exporting, AddressOf Options_Exporting
        '/
        Dim document = SfDataGrid1.ExportToPdf(options)
        '/ Save PDF document.
        document.Save(strPathPDF + "PDF\Sample.pdf")
        '/ Show PDF on PDFViewerControl of Syncfusion.
        Me.PdfViewerControl1.Load(strPathPDF + "PDF\Sample.pdf", "")
        document.Close()
        document.Dispose()
        '//
        Me.TabControlAdv1.SelectedIndex = 1
    End Sub

    ' / Event Handler.
    Private Sub Options_Exporting(ByVal sender As Object, ByVal e As DataGridPdfExportingEventArgs)
        If e.CellType = ExportCellType.HeaderCell Then
            e.CellStyle.BackgroundBrush = PdfBrushes.Orange
            e.CellStyle.TextBrush = PdfBrushes.White

        ElseIf e.CellType = ExportCellType.GroupCaptionCell Then
            e.CellStyle.BackgroundBrush = PdfBrushes.LightGray

        ElseIf e.CellType = ExportCellType.RecordCell Then
            e.CellStyle.BackgroundBrush = PdfBrushes.LightYellow '.Wheat
        End If
    End Sub

    Private Sub frmPrintSfGrid_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Me.Dispose()
        GC.SuppressFinalize(Me)
        Application.Exit()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
