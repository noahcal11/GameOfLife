<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAbout))
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblRules = New System.Windows.Forms.Label()
        Me.picJohnHortonConway = New System.Windows.Forms.PictureBox()
        Me.lblAbout = New System.Windows.Forms.Label()
        Me.lblGoL = New System.Windows.Forms.Label()
        Me.lblGoL2 = New System.Windows.Forms.Label()
        Me.lblTuringComplete = New System.Windows.Forms.Label()
        CType(Me.picJohnHortonConway, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.DimGray
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.Font = New System.Drawing.Font("Sitka Text", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnBack.ForeColor = System.Drawing.Color.LightGray
        Me.btnBack.Location = New System.Drawing.Point(507, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnBack.Size = New System.Drawing.Size(57, 31)
        Me.btnBack.TabIndex = 7
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'lblRules
        '
        Me.lblRules.AutoSize = True
        Me.lblRules.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 21.0!)
        Me.lblRules.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.lblRules.Location = New System.Drawing.Point(68, 12)
        Me.lblRules.Name = "lblRules"
        Me.lblRules.Size = New System.Drawing.Size(431, 42)
        Me.lblRules.TabIndex = 8
        Me.lblRules.Text = "JOHN HORTON CONWAY"
        '
        'picJohnHortonConway
        '
        Me.picJohnHortonConway.Image = Global.GameOfLife.My.Resources.Resources.JohnHortonConway
        Me.picJohnHortonConway.Location = New System.Drawing.Point(378, 57)
        Me.picJohnHortonConway.Name = "picJohnHortonConway"
        Me.picJohnHortonConway.Size = New System.Drawing.Size(174, 176)
        Me.picJohnHortonConway.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picJohnHortonConway.TabIndex = 9
        Me.picJohnHortonConway.TabStop = False
        '
        'lblAbout
        '
        Me.lblAbout.AutoSize = True
        Me.lblAbout.Font = New System.Drawing.Font("Prestige Elite Std", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblAbout.Location = New System.Drawing.Point(12, 70)
        Me.lblAbout.Name = "lblAbout"
        Me.lblAbout.Size = New System.Drawing.Size(350, 119)
        Me.lblAbout.TabIndex = 10
        Me.lblAbout.Text = resources.GetString("lblAbout.Text")
        '
        'lblGoL
        '
        Me.lblGoL.AutoSize = True
        Me.lblGoL.BackColor = System.Drawing.Color.Transparent
        Me.lblGoL.Font = New System.Drawing.Font("Prestige Elite Std", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblGoL.Location = New System.Drawing.Point(12, 208)
        Me.lblGoL.Name = "lblGoL"
        Me.lblGoL.Size = New System.Drawing.Size(350, 34)
        Me.lblGoL.TabIndex = 11
        Me.lblGoL.Text = "Conway is especially known for the " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "invention of the Game of Life, one of "
        '
        'lblGoL2
        '
        Me.lblGoL2.AutoSize = True
        Me.lblGoL2.Font = New System.Drawing.Font("Prestige Elite Std", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblGoL2.Location = New System.Drawing.Point(12, 242)
        Me.lblGoL2.Name = "lblGoL2"
        Me.lblGoL2.Size = New System.Drawing.Size(512, 51)
        Me.lblGoL2.TabIndex = 12
        Me.lblGoL2.Text = "the early examples of a cellular automaton. His initial " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "experiments in that fie" &
    "ld were done with pen and paper, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "long before personal computers existed."
        '
        'lblTuringComplete
        '
        Me.lblTuringComplete.AutoSize = True
        Me.lblTuringComplete.Font = New System.Drawing.Font("Prestige Elite Std", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblTuringComplete.Location = New System.Drawing.Point(3, 334)
        Me.lblTuringComplete.Name = "lblTuringComplete"
        Me.lblTuringComplete.Size = New System.Drawing.Size(570, 20)
        Me.lblTuringComplete.TabIndex = 13
        Me.lblTuringComplete.Text = "The Game of Life is now known to be Turing Complete"
        '
        'frmAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(576, 381)
        Me.Controls.Add(Me.lblTuringComplete)
        Me.Controls.Add(Me.lblGoL2)
        Me.Controls.Add(Me.lblGoL)
        Me.Controls.Add(Me.lblAbout)
        Me.Controls.Add(Me.picJohnHortonConway)
        Me.Controls.Add(Me.lblRules)
        Me.Controls.Add(Me.btnBack)
        Me.Name = "frmAbout"
        Me.Text = "About"
        CType(Me.picJohnHortonConway, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents lblRules As Label
    Friend WithEvents picJohnHortonConway As PictureBox
    Friend WithEvents lblAbout As Label
    Friend WithEvents lblGoL As Label
    Friend WithEvents lblGoL2 As Label
    Friend WithEvents lblTuringComplete As Label
End Class
