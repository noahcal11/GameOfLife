' Program Name: Conway's Game of Life
' Developer:    Noah Calisti
' Date:         November 27, 2018
' Purpose:      A zero player simulation of cells in a grid (also my final!)

Public Class frmMainMenu
    Private Sub btnRules_Click(sender As Object, e As EventArgs) Handles btnRules.Click
        ' Displays rules form, closes main menu form
        Me.Hide()
        frmRules.Show()

    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        ' Displays about form, closes main menu form
        Me.Hide()
        frmAbout.Show()

    End Sub

    Private Sub btnBegin_Click(sender As Object, e As EventArgs) Handles btnBegin.Click
        ' Displays game form, closes main menu form
        Me.Hide()
        frmGame.Show()

    End Sub
End Class
