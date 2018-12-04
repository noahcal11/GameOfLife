<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGame
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGame))
        Me.btnBack = New System.Windows.Forms.Button()
        Me.tbrSpeed = New System.Windows.Forms.TrackBar()
        Me.lblAdjustSpeed = New System.Windows.Forms.Label()
        Me.cmbConfigs = New System.Windows.Forms.ComboBox()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.picGrid = New System.Windows.Forms.PictureBox()
        CType(Me.tbrSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.DimGray
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.Font = New System.Drawing.Font("Sitka Text", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnBack.ForeColor = System.Drawing.Color.LightGray
        Me.btnBack.Location = New System.Drawing.Point(729, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnBack.Size = New System.Drawing.Size(57, 31)
        Me.btnBack.TabIndex = 7
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'tbrSpeed
        '
        Me.tbrSpeed.Location = New System.Drawing.Point(142, 509)
        Me.tbrSpeed.Name = "tbrSpeed"
        Me.tbrSpeed.Size = New System.Drawing.Size(264, 45)
        Me.tbrSpeed.TabIndex = 10
        '
        'lblAdjustSpeed
        '
        Me.lblAdjustSpeed.AutoSize = True
        Me.lblAdjustSpeed.Font = New System.Drawing.Font("Prestige Elite Std", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdjustSpeed.Location = New System.Drawing.Point(210, 546)
        Me.lblAdjustSpeed.Name = "lblAdjustSpeed"
        Me.lblAdjustSpeed.Size = New System.Drawing.Size(128, 18)
        Me.lblAdjustSpeed.TabIndex = 11
        Me.lblAdjustSpeed.Text = "Adjust Speed"
        '
        'cmbConfigs
        '
        Me.cmbConfigs.FormattingEnabled = True
        Me.cmbConfigs.Location = New System.Drawing.Point(514, 509)
        Me.cmbConfigs.Name = "cmbConfigs"
        Me.cmbConfigs.Size = New System.Drawing.Size(142, 21)
        Me.cmbConfigs.TabIndex = 12
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.Yellow
        Me.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnStart.Font = New System.Drawing.Font("Perpetua Titling MT", 18.0!, System.Drawing.FontStyle.Bold)
        Me.btnStart.ForeColor = System.Drawing.Color.DimGray
        Me.btnStart.Location = New System.Drawing.Point(213, 587)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnStart.Size = New System.Drawing.Size(134, 37)
        Me.btnStart.TabIndex = 13
        Me.btnStart.Text = "Start"
        Me.btnStart.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'btnStop
        '
        Me.btnStop.BackColor = System.Drawing.Color.DarkSalmon
        Me.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnStop.Font = New System.Drawing.Font("Perpetua Titling MT", 18.0!, System.Drawing.FontStyle.Bold)
        Me.btnStop.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnStop.Location = New System.Drawing.Point(490, 587)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnStop.Size = New System.Drawing.Size(134, 37)
        Me.btnStop.TabIndex = 14
        Me.btnStop.Text = "Stop"
        Me.btnStop.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnStop.UseVisualStyleBackColor = False
        '
        'picGrid
        '
        Me.picGrid.BackColor = System.Drawing.Color.LightGray
        Me.picGrid.Location = New System.Drawing.Point(99, 3)
        Me.picGrid.Name = "picGrid"
        Me.picGrid.Size = New System.Drawing.Size(600, 480)
        Me.picGrid.TabIndex = 8
        Me.picGrid.TabStop = False
        '
        'frmGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(798, 651)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.cmbConfigs)
        Me.Controls.Add(Me.lblAdjustSpeed)
        Me.Controls.Add(Me.tbrSpeed)
        Me.Controls.Add(Me.picGrid)
        Me.Controls.Add(Me.btnBack)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmGame"
        Me.Text = "Game of Life"
        CType(Me.tbrSpeed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents picGrid As PictureBox
    Friend WithEvents tbrSpeed As TrackBar
    Friend WithEvents lblAdjustSpeed As Label
    Friend WithEvents cmbConfigs As ComboBox
    Friend WithEvents btnStart As Button
    Friend WithEvents btnStop As Button
End Class
