<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainMenu))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnBegin = New System.Windows.Forms.Button()
        Me.btnRules = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Prestige Elite Std", 21.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.Location = New System.Drawing.Point(36, 32)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(372, 32)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Conway's Game of Life"
        '
        'btnBegin
        '
        Me.btnBegin.BackColor = System.Drawing.Color.Yellow
        Me.btnBegin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBegin.Font = New System.Drawing.Font("Perpetua Titling MT", 22.0!, System.Drawing.FontStyle.Bold)
        Me.btnBegin.ForeColor = System.Drawing.Color.DimGray
        Me.btnBegin.Location = New System.Drawing.Point(155, 112)
        Me.btnBegin.Name = "btnBegin"
        Me.btnBegin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnBegin.Size = New System.Drawing.Size(134, 64)
        Me.btnBegin.TabIndex = 1
        Me.btnBegin.Text = "Begin!"
        Me.btnBegin.UseVisualStyleBackColor = False
        '
        'btnRules
        '
        Me.btnRules.BackColor = System.Drawing.Color.DimGray
        Me.btnRules.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRules.Font = New System.Drawing.Font("Sitka Text", 16.0!, System.Drawing.FontStyle.Bold)
        Me.btnRules.ForeColor = System.Drawing.Color.LightGray
        Me.btnRules.Location = New System.Drawing.Point(155, 194)
        Me.btnRules.Name = "btnRules"
        Me.btnRules.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnRules.Size = New System.Drawing.Size(134, 43)
        Me.btnRules.TabIndex = 2
        Me.btnRules.Text = "Rules"
        Me.btnRules.UseVisualStyleBackColor = False
        '
        'btnAbout
        '
        Me.btnAbout.BackColor = System.Drawing.Color.DimGray
        Me.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAbout.Font = New System.Drawing.Font("Sitka Text", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnAbout.ForeColor = System.Drawing.Color.LightGray
        Me.btnAbout.Location = New System.Drawing.Point(145, 255)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnAbout.Size = New System.Drawing.Size(155, 62)
        Me.btnAbout.TabIndex = 3
        Me.btnAbout.Text = "About John" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Horton Conway"
        Me.btnAbout.UseVisualStyleBackColor = False
        '
        'frmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(445, 368)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.btnRules)
        Me.Controls.Add(Me.btnBegin)
        Me.Controls.Add(Me.lblTitle)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMainMenu"
        Me.Text = "Game Of Life"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents btnBegin As Button
    Friend WithEvents btnRules As Button
    Friend WithEvents btnAbout As Button
End Class
