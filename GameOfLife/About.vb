Public Class frmAbout
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ' Hides about form, shows main menu form
        Me.Hide()
        frmMainMenu.Show()

    End Sub
End Class