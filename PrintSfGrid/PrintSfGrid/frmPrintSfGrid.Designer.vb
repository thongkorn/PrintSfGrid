﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrintSfGrid
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrintSfGrid))
        Dim MessageBoxSettings1 As Syncfusion.Windows.Forms.PdfViewer.MessageBoxSettings = New Syncfusion.Windows.Forms.PdfViewer.MessageBoxSettings()
        Dim PdfViewerPrinterSettings1 As Syncfusion.Windows.PdfViewer.PdfViewerPrinterSettings = New Syncfusion.Windows.PdfViewer.PdfViewerPrinterSettings()
        Dim TextSearchSettings1 As Syncfusion.Windows.Forms.PdfViewer.TextSearchSettings = New Syncfusion.Windows.Forms.PdfViewer.TextSearchSettings()
        Me.btnPreview = New Syncfusion.WinForms.Controls.SfButton()
        Me.SfDataGrid1 = New Syncfusion.WinForms.DataGrid.SfDataGrid()
        Me.TabControlAdv1 = New Syncfusion.Windows.Forms.Tools.TabControlAdv()
        Me.TabPageAdv1 = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
        Me.TabPageAdv2 = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
        Me.PdfViewerControl1 = New Syncfusion.Windows.Forms.PdfViewer.PdfViewerControl()
        Me.btnExit = New Syncfusion.WinForms.Controls.SfButton()
        CType(Me.SfDataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabControlAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlAdv1.SuspendLayout()
        Me.TabPageAdv1.SuspendLayout()
        Me.TabPageAdv2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnPreview
        '
        Me.btnPreview.AccessibleName = "Button"
        Me.btnPreview.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPreview.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPreview.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnPreview.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.btnPreview.Location = New System.Drawing.Point(830, 4)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(113, 33)
        Me.btnPreview.TabIndex = 10
        Me.btnPreview.Text = "Print Preview"
        '
        'SfDataGrid1
        '
        Me.SfDataGrid1.AccessibleName = "Table"
        Me.SfDataGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SfDataGrid1.Location = New System.Drawing.Point(0, 0)
        Me.SfDataGrid1.Name = "SfDataGrid1"
        Me.SfDataGrid1.Size = New System.Drawing.Size(824, 597)
        Me.SfDataGrid1.TabIndex = 11
        Me.SfDataGrid1.Text = "SfDataGrid1"
        '
        'TabControlAdv1
        '
        Me.TabControlAdv1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControlAdv1.BeforeTouchSize = New System.Drawing.Size(827, 627)
        Me.TabControlAdv1.Controls.Add(Me.TabPageAdv1)
        Me.TabControlAdv1.Controls.Add(Me.TabPageAdv2)
        Me.TabControlAdv1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TabControlAdv1.FocusOnTabClick = False
        Me.TabControlAdv1.Location = New System.Drawing.Point(0, 0)
        Me.TabControlAdv1.Name = "TabControlAdv1"
        Me.TabControlAdv1.Size = New System.Drawing.Size(827, 627)
        Me.TabControlAdv1.TabIndex = 12
        Me.TabControlAdv1.ThemeName = "TabRenderer3D"
        '
        'TabPageAdv1
        '
        Me.TabPageAdv1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPageAdv1.Controls.Add(Me.SfDataGrid1)
        Me.TabPageAdv1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TabPageAdv1.Image = CType(resources.GetObject("TabPageAdv1.Image"), System.Drawing.Image)
        Me.TabPageAdv1.ImageSize = New System.Drawing.Size(16, 16)
        Me.TabPageAdv1.Location = New System.Drawing.Point(1, 28)
        Me.TabPageAdv1.Name = "TabPageAdv1"
        Me.TabPageAdv1.ShowCloseButton = True
        Me.TabPageAdv1.Size = New System.Drawing.Size(824, 597)
        Me.TabPageAdv1.TabIndex = 1
        Me.TabPageAdv1.Text = " DataGrid "
        Me.TabPageAdv1.ThemesEnabled = False
        '
        'TabPageAdv2
        '
        Me.TabPageAdv2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPageAdv2.Controls.Add(Me.PdfViewerControl1)
        Me.TabPageAdv2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TabPageAdv2.Image = CType(resources.GetObject("TabPageAdv2.Image"), System.Drawing.Image)
        Me.TabPageAdv2.ImageSize = New System.Drawing.Size(16, 16)
        Me.TabPageAdv2.Location = New System.Drawing.Point(1, 28)
        Me.TabPageAdv2.Name = "TabPageAdv2"
        Me.TabPageAdv2.ShowCloseButton = True
        Me.TabPageAdv2.Size = New System.Drawing.Size(824, 597)
        Me.TabPageAdv2.TabIndex = 2
        Me.TabPageAdv2.Text = " Print PDF "
        Me.TabPageAdv2.ThemesEnabled = False
        '
        'PdfViewerControl1
        '
        Me.PdfViewerControl1.CursorMode = Syncfusion.Windows.Forms.PdfViewer.PdfViewerCursorMode.SelectTool
        Me.PdfViewerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PdfViewerControl1.EnableContextMenu = True
        Me.PdfViewerControl1.EnableNotificationBar = True
        Me.PdfViewerControl1.HorizontalScrollOffset = 0
        Me.PdfViewerControl1.IsBookmarkEnabled = True
        Me.PdfViewerControl1.IsTextSearchEnabled = True
        Me.PdfViewerControl1.IsTextSelectionEnabled = True
        Me.PdfViewerControl1.Location = New System.Drawing.Point(0, 0)
        MessageBoxSettings1.EnableNotification = True
        Me.PdfViewerControl1.MessageBoxSettings = MessageBoxSettings1
        Me.PdfViewerControl1.MinimumZoomPercentage = 50
        Me.PdfViewerControl1.Name = "PdfViewerControl1"
        Me.PdfViewerControl1.PageBorderThickness = 1
        PdfViewerPrinterSettings1.Copies = 1
        PdfViewerPrinterSettings1.PageOrientation = Syncfusion.Windows.PdfViewer.PdfViewerPrintOrientation.[Auto]
        PdfViewerPrinterSettings1.PageSize = Syncfusion.Windows.PdfViewer.PdfViewerPrintSize.ActualSize
        PdfViewerPrinterSettings1.PrintLocation = CType(resources.GetObject("PdfViewerPrinterSettings1.PrintLocation"), System.Drawing.PointF)
        PdfViewerPrinterSettings1.ShowPrintStatusDialog = True
        Me.PdfViewerControl1.PrinterSettings = PdfViewerPrinterSettings1
        Me.PdfViewerControl1.ReferencePath = Nothing
        Me.PdfViewerControl1.ScrollDisplacementValue = 0
        Me.PdfViewerControl1.ShowHorizontalScrollBar = True
        Me.PdfViewerControl1.ShowToolBar = True
        Me.PdfViewerControl1.ShowVerticalScrollBar = True
        Me.PdfViewerControl1.Size = New System.Drawing.Size(824, 597)
        Me.PdfViewerControl1.SpaceBetweenPages = 8
        Me.PdfViewerControl1.TabIndex = 0
        Me.PdfViewerControl1.Text = "PdfViewerControl1"
        TextSearchSettings1.CurrentInstanceColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(64, Byte), Integer))
        TextSearchSettings1.HighlightAllInstance = True
        TextSearchSettings1.OtherInstanceColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PdfViewerControl1.TextSearchSettings = TextSearchSettings1
        Me.PdfViewerControl1.ThemeName = "Default"
        Me.PdfViewerControl1.VerticalScrollOffset = 0
        Me.PdfViewerControl1.VisualStyle = Syncfusion.Windows.Forms.PdfViewer.VisualStyle.[Default]
        Me.PdfViewerControl1.ZoomMode = Syncfusion.Windows.Forms.PdfViewer.ZoomMode.[Default]
        '
        'btnExit
        '
        Me.btnExit.AccessibleName = "Button"
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.btnExit.Location = New System.Drawing.Point(830, 43)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(113, 33)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "E&xit"
        '
        'frmPrintSfGrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(946, 628)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.TabControlAdv1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmPrintSfGrid"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Print SfDataGrid Control Syncfusion - coDe bY: Thongkorn Tubtimkrob"
        CType(Me.SfDataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabControlAdv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlAdv1.ResumeLayout(False)
        Me.TabPageAdv1.ResumeLayout(False)
        Me.TabPageAdv2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents btnPreview As Syncfusion.WinForms.Controls.SfButton
    Friend WithEvents SfDataGrid1 As Syncfusion.WinForms.DataGrid.SfDataGrid
    Friend WithEvents TabControlAdv1 As Syncfusion.Windows.Forms.Tools.TabControlAdv
    Friend WithEvents TabPageAdv1 As Syncfusion.Windows.Forms.Tools.TabPageAdv
    Friend WithEvents TabPageAdv2 As Syncfusion.Windows.Forms.Tools.TabPageAdv
    Friend WithEvents PdfViewerControl1 As Syncfusion.Windows.Forms.PdfViewer.PdfViewerControl
    Private WithEvents btnExit As Syncfusion.WinForms.Controls.SfButton

End Class
