<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRules
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRules))
        Me.lblRules = New System.Windows.Forms.Label()
        Me.lblExplanation = New System.Windows.Forms.Label()
        Me.lblGeneraton = New System.Windows.Forms.Label()
        Me.lblListOfRules = New System.Windows.Forms.Label()
        Me.picExample = New System.Windows.Forms.PictureBox()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.picExample, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblRules
        '
        Me.lblRules.AutoSize = True
        Me.lblRules.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 25.0!)
        Me.lblRules.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.lblRules.Location = New System.Drawing.Point(174, 9)
        Me.lblRules.Name = "lblRules"
        Me.lblRules.Size = New System.Drawing.Size(152, 48)
        Me.lblRules.TabIndex = 1
        Me.lblRules.Text = "RULES"
        '
        'lblExplanation
        '
        Me.lblExplanation.AutoSize = True
        Me.lblExplanation.Font = New System.Drawing.Font("Prestige Elite Std", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblExplanation.Location = New System.Drawing.Point(30, 72)
        Me.lblExplanation.Name = "lblExplanation"
        Me.lblExplanation.Size = New System.Drawing.Size(440, 51)
        Me.lblExplanation.TabIndex = 2
        Me.lblExplanation.Text = "Conway's Game of Life is a zero-player game," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "meaning that its evolution is deter" &
    "mined by its " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "initial state, requiring no further input."
        Me.lblExplanation.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblGeneraton
        '
        Me.lblGeneraton.AutoSize = True
        Me.lblGeneraton.Font = New System.Drawing.Font("Prestige Elite Std", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblGeneraton.Location = New System.Drawing.Point(24, 221)
        Me.lblGeneraton.Name = "lblGeneraton"
        Me.lblGeneraton.Size = New System.Drawing.Size(450, 66)
        Me.lblGeneraton.TabIndex = 3
        Me.lblGeneraton.Text = "In a grid of square cells, ""generations""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "are simulated. Between each generation," &
    "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the following rules apply."
        Me.lblGeneraton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblListOfRules
        '
        Me.lblListOfRules.AutoSize = True
        Me.lblListOfRules.Font = New System.Drawing.Font("Prestige Elite Std", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblListOfRules.Location = New System.Drawing.Point(12, 301)
        Me.lblListOfRules.Name = "lblListOfRules"
        Me.lblListOfRules.Size = New System.Drawing.Size(476, 136)
        Me.lblListOfRules.TabIndex = 4
        Me.lblListOfRules.Text = resources.GetString("lblListOfRules.Text")
        Me.lblListOfRules.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'picExample
        '
        Me.picExample.Image = Global.GameOfLife.My.Resources.Resources.Diehard
        Me.picExample.Location = New System.Drawing.Point(156, 126)
        Me.picExample.Name = "picExample"
        Me.picExample.Size = New System.Drawing.Size(189, 92)
        Me.picExample.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picExample.TabIndex = 5
        Me.picExample.TabStop = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.DimGray
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.Font = New System.Drawing.Font("Sitka Text", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnBack.ForeColor = System.Drawing.Color.LightGray
        Me.btnBack.Location = New System.Drawing.Point(432, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnBack.Size = New System.Drawing.Size(57, 31)
        Me.btnBack.TabIndex = 6
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'frmRules
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(501, 446)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.picExample)
        Me.Controls.Add(Me.lblListOfRules)
        Me.Controls.Add(Me.lblGeneraton)
        Me.Controls.Add(Me.lblExplanation)
        Me.Controls.Add(Me.lblRules)
        Me.Name = "frmRules"
        Me.Text = "Rules"
        CType(Me.picExample, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblRules As Label
    Friend WithEvents lblExplanation As Label
    Friend WithEvents lblGeneraton As Label
    Friend WithEvents lblListOfRules As Label
    Friend WithEvents picExample As PictureBox
    Friend WithEvents btnBack As Button
End Class
