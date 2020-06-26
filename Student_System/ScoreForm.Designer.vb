<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScoreForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ScoreForm))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim BorderEdges1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim StateProperties1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim StateProperties2 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BunifuLabel1 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuDataGridView1 = New Bunifu.UI.WinForms.BunifuDataGridView()
        Me.studSubject = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.studMidSem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.studExams = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.studTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.studRemarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.scoreSave = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BunifuFormDock1 = New Bunifu.UI.WinForms.BunifuFormDock()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(180, 86)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'BunifuLabel1
        '
        Me.BunifuLabel1.AutoEllipsis = False
        Me.BunifuLabel1.CursorType = Nothing
        Me.BunifuLabel1.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.BunifuLabel1.Location = New System.Drawing.Point(314, 22)
        Me.BunifuLabel1.Name = "BunifuLabel1"
        Me.BunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel1.Size = New System.Drawing.Size(275, 42)
        Me.BunifuLabel1.TabIndex = 31
        Me.BunifuLabel1.Text = "Student Score Entry"
        Me.BunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopCenter
        Me.BunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuDataGridView1
        '
        Me.BunifuDataGridView1.AllowCustomTheming = False
        Me.BunifuDataGridView1.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(223, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.BunifuDataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.BunifuDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.BunifuDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BunifuDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.BunifuDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Navy
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BunifuDataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.BunifuDataGridView1.ColumnHeadersHeight = 40
        Me.BunifuDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.studSubject, Me.studMidSem, Me.studExams, Me.studTotal, Me.studRemarks})
        Me.BunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.BunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black
        Me.BunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.BunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White
        Me.BunifuDataGridView1.CurrentTheme.BackColor = System.Drawing.Color.Navy
        Me.BunifuDataGridView1.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.BunifuDataGridView1.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.Navy
        Me.BunifuDataGridView1.CurrentTheme.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        Me.BunifuDataGridView1.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.BunifuDataGridView1.CurrentTheme.Name = Nothing
        Me.BunifuDataGridView1.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.BunifuDataGridView1.CurrentTheme.RowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BunifuDataGridView1.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.BunifuDataGridView1.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.BunifuDataGridView1.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(229, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(178, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.BunifuDataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.BunifuDataGridView1.EnableHeadersVisualStyles = False
        Me.BunifuDataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.BunifuDataGridView1.HeaderBackColor = System.Drawing.Color.Navy
        Me.BunifuDataGridView1.HeaderBgColor = System.Drawing.Color.Empty
        Me.BunifuDataGridView1.HeaderForeColor = System.Drawing.Color.White
        Me.BunifuDataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.BunifuDataGridView1.Name = "BunifuDataGridView1"
        Me.BunifuDataGridView1.RowHeadersVisible = False
        Me.BunifuDataGridView1.RowTemplate.Height = 40
        Me.BunifuDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.BunifuDataGridView1.Size = New System.Drawing.Size(747, 120)
        Me.BunifuDataGridView1.TabIndex = 32
        Me.BunifuDataGridView1.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Navy
        '
        'studSubject
        '
        Me.studSubject.HeaderText = "Subject"
        Me.studSubject.Name = "studSubject"
        '
        'studMidSem
        '
        Me.studMidSem.HeaderText = "Assessment 30%"
        Me.studMidSem.Name = "studMidSem"
        '
        'studExams
        '
        Me.studExams.HeaderText = "Final Exams 70%"
        Me.studExams.Name = "studExams"
        '
        'studTotal
        '
        Me.studTotal.HeaderText = "Total Score 100%"
        Me.studTotal.Name = "studTotal"
        '
        'studRemarks
        '
        Me.studRemarks.HeaderText = "Remarks"
        Me.studRemarks.Name = "studRemarks"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel1.Controls.Add(Me.BunifuDataGridView1)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(21, 128)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(753, 126)
        Me.FlowLayoutPanel1.TabIndex = 33
        '
        'scoreSave
        '
        Me.scoreSave.AllowToggling = False
        Me.scoreSave.AnimationSpeed = 200
        Me.scoreSave.AutoGenerateColors = False
        Me.scoreSave.BackColor = System.Drawing.Color.Transparent
        Me.scoreSave.BackColor1 = System.Drawing.Color.White
        Me.scoreSave.BackgroundImage = CType(resources.GetObject("scoreSave.BackgroundImage"), System.Drawing.Image)
        Me.scoreSave.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.scoreSave.ButtonText = "Save"
        Me.scoreSave.ButtonTextMarginLeft = 0
        Me.scoreSave.ColorContrastOnClick = 45
        Me.scoreSave.ColorContrastOnHover = 45
        Me.scoreSave.Cursor = System.Windows.Forms.Cursors.Hand
        BorderEdges1.BottomLeft = True
        BorderEdges1.BottomRight = True
        BorderEdges1.TopLeft = True
        BorderEdges1.TopRight = True
        Me.scoreSave.CustomizableEdges = BorderEdges1
        Me.scoreSave.DialogResult = System.Windows.Forms.DialogResult.None
        Me.scoreSave.DisabledBorderColor = System.Drawing.Color.Empty
        Me.scoreSave.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.scoreSave.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.scoreSave.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.scoreSave.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!)
        Me.scoreSave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.scoreSave.IconLeftCursor = System.Windows.Forms.Cursors.Hand
        Me.scoreSave.IconMarginLeft = 11
        Me.scoreSave.IconPadding = 10
        Me.scoreSave.IconRightCursor = System.Windows.Forms.Cursors.Hand
        Me.scoreSave.IdleBorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.scoreSave.IdleBorderRadius = 10
        Me.scoreSave.IdleBorderThickness = 1
        Me.scoreSave.IdleFillColor = System.Drawing.Color.White
        Me.scoreSave.IdleIconLeftImage = Nothing
        Me.scoreSave.IdleIconRightImage = Nothing
        Me.scoreSave.IndicateFocus = False
        Me.scoreSave.Location = New System.Drawing.Point(314, 476)
        Me.scoreSave.Name = "scoreSave"
        StateProperties1.BorderColor = System.Drawing.Color.White
        StateProperties1.BorderRadius = 10
        StateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        StateProperties1.BorderThickness = 1
        StateProperties1.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(100, Byte), Integer))
        StateProperties1.ForeColor = System.Drawing.Color.White
        StateProperties1.IconLeftImage = Nothing
        StateProperties1.IconRightImage = Nothing
        Me.scoreSave.onHoverState = StateProperties1
        StateProperties2.BorderColor = System.Drawing.Color.White
        StateProperties2.BorderRadius = 10
        StateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        StateProperties2.BorderThickness = 1
        StateProperties2.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(100, Byte), Integer))
        StateProperties2.ForeColor = System.Drawing.Color.White
        StateProperties2.IconLeftImage = Nothing
        StateProperties2.IconRightImage = Nothing
        Me.scoreSave.OnPressedState = StateProperties2
        Me.scoreSave.Size = New System.Drawing.Size(128, 45)
        Me.scoreSave.TabIndex = 55
        Me.scoreSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.scoreSave.TextMarginLeft = 0
        Me.scoreSave.UseDefaultRadiusAndThickness = True
        '
        'BunifuFormDock1
        '
        Me.BunifuFormDock1.AllowFormDragging = True
        Me.BunifuFormDock1.AllowFormDropShadow = True
        Me.BunifuFormDock1.AllowFormResizing = True
        Me.BunifuFormDock1.AllowHidingBottomRegion = True
        Me.BunifuFormDock1.AllowOpacityChangesWhileDragging = False
        Me.BunifuFormDock1.BorderOptions.BottomBorder.BorderColor = System.Drawing.Color.Silver
        Me.BunifuFormDock1.BorderOptions.BottomBorder.BorderThickness = 1
        Me.BunifuFormDock1.BorderOptions.BottomBorder.ShowBorder = True
        Me.BunifuFormDock1.BorderOptions.LeftBorder.BorderColor = System.Drawing.Color.Silver
        Me.BunifuFormDock1.BorderOptions.LeftBorder.BorderThickness = 1
        Me.BunifuFormDock1.BorderOptions.LeftBorder.ShowBorder = True
        Me.BunifuFormDock1.BorderOptions.RightBorder.BorderColor = System.Drawing.Color.Silver
        Me.BunifuFormDock1.BorderOptions.RightBorder.BorderThickness = 1
        Me.BunifuFormDock1.BorderOptions.RightBorder.ShowBorder = True
        Me.BunifuFormDock1.BorderOptions.TopBorder.BorderColor = System.Drawing.Color.Silver
        Me.BunifuFormDock1.BorderOptions.TopBorder.BorderThickness = 1
        Me.BunifuFormDock1.BorderOptions.TopBorder.ShowBorder = True
        Me.BunifuFormDock1.ContainerControl = Me
        Me.BunifuFormDock1.DockingIndicatorsColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.BunifuFormDock1.DockingIndicatorsOpacity = 0.5R
        Me.BunifuFormDock1.DockingOptions.DockAll = True
        Me.BunifuFormDock1.DockingOptions.DockBottomLeft = True
        Me.BunifuFormDock1.DockingOptions.DockBottomRight = True
        Me.BunifuFormDock1.DockingOptions.DockFullScreen = True
        Me.BunifuFormDock1.DockingOptions.DockLeft = True
        Me.BunifuFormDock1.DockingOptions.DockRight = True
        Me.BunifuFormDock1.DockingOptions.DockTopLeft = True
        Me.BunifuFormDock1.DockingOptions.DockTopRight = True
        Me.BunifuFormDock1.FormDraggingOpacity = 0.9R
        Me.BunifuFormDock1.ParentForm = Me
        Me.BunifuFormDock1.ShowCursorChanges = True
        Me.BunifuFormDock1.ShowDockingIndicators = False
        Me.BunifuFormDock1.TitleBarOptions.AllowFormDragging = True
        Me.BunifuFormDock1.TitleBarOptions.BunifuFormDock = Me.BunifuFormDock1
        Me.BunifuFormDock1.TitleBarOptions.DoubleClickToExpandWindow = True
        Me.BunifuFormDock1.TitleBarOptions.TitleBarControl = Nothing
        Me.BunifuFormDock1.TitleBarOptions.UseBackColorOnDockingIndicators = False
        '
        'ScoreForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(809, 533)
        Me.Controls.Add(Me.scoreSave)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.BunifuLabel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ScoreForm"
        Me.Text = "ScoreForm"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BunifuLabel1 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuDataGridView1 As Bunifu.UI.WinForms.BunifuDataGridView
    Friend WithEvents studSubject As DataGridViewTextBoxColumn
    Friend WithEvents studMidSem As DataGridViewTextBoxColumn
    Friend WithEvents studExams As DataGridViewTextBoxColumn
    Friend WithEvents studTotal As DataGridViewTextBoxColumn
    Friend WithEvents studRemarks As DataGridViewTextBoxColumn
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents scoreSave As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BunifuFormDock1 As Bunifu.UI.WinForms.BunifuFormDock
End Class
