Option Strict On

Public Class frmGame
    ' Declaring public variables
    Public bmp As Bitmap
    Public G As Graphics
    Public WithEvents speed As Timer
    Public grid(50, 40) As Boolean
    Public input(50, 40) As Boolean
    Public intGens As Integer = 0
    Public change As Boolean = False
    Public P As New Pen(Color.Black)

    Private Sub picGrid_Paint(sender As Object, e As PaintEventArgs) Handles picGrid.Paint
        ' Loads bitmap, graphics, etc and prepares to begin simulation

        ' Creates graphics device
        bmp = New Bitmap(600, 480)
        picGrid.Image = bmp
        G = Graphics.FromImage(bmp)

        ' Defining variables for grid
        Dim x As Integer = 0
        Dim y As Integer = 0

        ' Draws grid
        For y = 0 To 480
            For x = 0 To 600
                G.DrawRectangle(pen:=P, x:=x, y:=y, width:=12, height:=12)
                x += 12
            Next
            x = 0
            y += 12
        Next
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ' Hides rules form, shows main menu form
        frmMainMenu.Show()
        Me.Hide()

    End Sub

    Private Sub frmGame_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        ' Frees memory when form is closed
        G.Dispose()
        bmp.Dispose()
        speed.Dispose()

    End Sub
End Class