<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGame
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGame))
        Me.btnBack = New System.Windows.Forms.Button()
        Me.tbrSpeed = New System.Windows.Forms.TrackBar()
        Me.lblAdjustSpeed = New System.Windows.Forms.Label()
        Me.cmbConfigs = New System.Windows.Forms.ComboBox()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.speed = New System.Windows.Forms.Timer(Me.components)
        Me.btnNextGen = New System.Windows.Forms.Button()
        Me.rlsGrid = New GameOfLife.Rules()
        Me.lblGenerations = New System.Windows.Forms.Label()
        Me.btnRestart = New System.Windows.Forms.Button()
        Me.lblSpeed = New System.Windows.Forms.Label()
        CType(Me.tbrSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None
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
        Me.tbrSpeed.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbrSpeed.Location = New System.Drawing.Point(82, 511)
        Me.tbrSpeed.Maximum = 20
        Me.tbrSpeed.Name = "tbrSpeed"
        Me.tbrSpeed.Size = New System.Drawing.Size(286, 45)
        Me.tbrSpeed.TabIndex = 10
        '
        'lblAdjustSpeed
        '
        Me.lblAdjustSpeed.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblAdjustSpeed.AutoSize = True
        Me.lblAdjustSpeed.Font = New System.Drawing.Font("Prestige Elite Std", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdjustSpeed.Location = New System.Drawing.Point(161, 548)
        Me.lblAdjustSpeed.Name = "lblAdjustSpeed"
        Me.lblAdjustSpeed.Size = New System.Drawing.Size(128, 18)
        Me.lblAdjustSpeed.TabIndex = 11
        Me.lblAdjustSpeed.Text = "Adjust Speed"
        '
        'cmbConfigs
        '
        Me.cmbConfigs.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmbConfigs.FormattingEnabled = True
        Me.cmbConfigs.Location = New System.Drawing.Point(567, 511)
        Me.cmbConfigs.Name = "cmbConfigs"
        Me.cmbConfigs.Size = New System.Drawing.Size(142, 21)
        Me.cmbConfigs.TabIndex = 12
        '
        'btnStart
        '
        Me.btnStart.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnStart.BackColor = System.Drawing.Color.Yellow
        Me.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnStart.Font = New System.Drawing.Font("Perpetua Titling MT", 18.0!, System.Drawing.FontStyle.Bold)
        Me.btnStart.ForeColor = System.Drawing.Color.DimGray
        Me.btnStart.Location = New System.Drawing.Point(100, 596)
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
        Me.btnStop.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnStop.BackColor = System.Drawing.Color.DarkSalmon
        Me.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnStop.Font = New System.Drawing.Font("Perpetua Titling MT", 18.0!, System.Drawing.FontStyle.Bold)
        Me.btnStop.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnStop.Location = New System.Drawing.Point(278, 596)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnStop.Size = New System.Drawing.Size(134, 37)
        Me.btnStop.TabIndex = 14
        Me.btnStop.Text = "Stop"
        Me.btnStop.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnStop.UseVisualStyleBackColor = False
        '
        'speed
        '
        Me.speed.Interval = 50
        '
        'btnNextGen
        '
        Me.btnNextGen.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnNextGen.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnNextGen.Font = New System.Drawing.Font("Sitka Text", 10.0!)
        Me.btnNextGen.Location = New System.Drawing.Point(460, 590)
        Me.btnNextGen.Name = "btnNextGen"
        Me.btnNextGen.Size = New System.Drawing.Size(94, 49)
        Me.btnNextGen.TabIndex = 15
        Me.btnNextGen.Text = "Next" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "generation"
        Me.btnNextGen.UseVisualStyleBackColor = False
        '
        'rlsGrid
        '
        Me.rlsGrid.aliveColor = System.Drawing.Color.Yellow
        Me.rlsGrid.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.rlsGrid.BackColor = System.Drawing.Color.Gainsboro
        Me.rlsGrid.cellSize = New System.Drawing.Size(12, 12)
        Me.rlsGrid.GridSize = New System.Drawing.Size(50, 40)
        Me.rlsGrid.Location = New System.Drawing.Point(99, 12)
        Me.rlsGrid.Name = "rlsGrid"
        Me.rlsGrid.Size = New System.Drawing.Size(601, 481)
        Me.rlsGrid.TabIndex = 16
        Me.rlsGrid.Text = "Rules1"
        '
        'lblGenerations
        '
        Me.lblGenerations.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblGenerations.AutoSize = True
        Me.lblGenerations.Font = New System.Drawing.Font("Sitka Text", 10.0!)
        Me.lblGenerations.Location = New System.Drawing.Point(395, 512)
        Me.lblGenerations.Name = "lblGenerations"
        Me.lblGenerations.Size = New System.Drawing.Size(106, 20)
        Me.lblGenerations.TabIndex = 17
        Me.lblGenerations.Text = "Generations: 0"
        '
        'btnRestart
        '
        Me.btnRestart.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnRestart.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnRestart.Font = New System.Drawing.Font("Sitka Text", 10.0!)
        Me.btnRestart.Location = New System.Drawing.Point(605, 596)
        Me.btnRestart.Name = "btnRestart"
        Me.btnRestart.Size = New System.Drawing.Size(79, 37)
        Me.btnRestart.TabIndex = 18
        Me.btnRestart.Text = "Restart"
        Me.btnRestart.UseVisualStyleBackColor = False
        '
        'lblSpeed
        '
        Me.lblSpeed.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblSpeed.AutoSize = True
        Me.lblSpeed.Font = New System.Drawing.Font("Prestige Elite Std", 12.0!)
        Me.lblSpeed.Location = New System.Drawing.Point(146, 566)
        Me.lblSpeed.Name = "lblSpeed"
        Me.lblSpeed.Size = New System.Drawing.Size(158, 18)
        Me.lblSpeed.TabIndex = 19
        Me.lblSpeed.Text = "Interval = 50ms"
        '
        'frmGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(798, 651)
        Me.Controls.Add(Me.lblSpeed)
        Me.Controls.Add(Me.btnRestart)
        Me.Controls.Add(Me.lblGenerations)
        Me.Controls.Add(Me.rlsGrid)
        Me.Controls.Add(Me.btnNextGen)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.cmbConfigs)
        Me.Controls.Add(Me.lblAdjustSpeed)
        Me.Controls.Add(Me.tbrSpeed)
        Me.Controls.Add(Me.btnBack)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmGame"
        Me.Text = "Game of Life"
        CType(Me.tbrSpeed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents tbrSpeed As TrackBar
    Friend WithEvents lblAdjustSpeed As Label
    Friend WithEvents cmbConfigs As ComboBox
    Friend WithEvents btnStart As Button
    Friend WithEvents btnStop As Button
    Friend WithEvents speed As Timer
    Friend WithEvents btnNextGen As Button
    Friend WithEvents rlsGrid As Rules
    Friend WithEvents lblGenerations As Label
    Friend WithEvents btnRestart As Button
    Friend WithEvents lblSpeed As Label
End Class
