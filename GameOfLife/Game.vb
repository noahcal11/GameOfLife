Option Strict On
Imports GameOfLife

Public Class frmGame
    ' Declaring public variables
    Public bmp As Bitmap
    Public G As Graphics

    Private Sub picGrid_Paint(sender As Object, e As PaintEventArgs) Handles picGrid.Paint
        ' Loads bitmap, graphics, etc and prepares to begin simulation

        ' Creates graphics device
        bmp = New Bitmap(600, 480)
        picGrid.Image = bmp
        G = Graphics.FromImage(bmp)
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighSpeed

        ' Draws grid
        For x As Integer = 0 To 600
            G.DrawLine(Pens.DimGray, x * Rules.cellSize.Width, 0, x * Rules.cellSize.Width, Height)
        Next
        For y As Integer = 0 To 480
            G.DrawLine(Pens.DimGray, 0, y * Rules.cellSize.Height, Width, y * Rules.cellSize.Height)
        Next
        Invalidate()
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

Public Class Cell
    ' Creates cell class, defines cell
    Public status As status = status.Dead
    Public location As Point
    Public shouldToggle As Boolean = False
    Sub New(x As Point)
        Me.location = x
    End Sub

    Public Shared Widening Operator CType(v As Point) As Cell
        Throw New NotImplementedException()
    End Operator
End Class

Public Enum status
    ' Enumeration displays alive/dead status of cell
    Alive = 1
    Dead = 2
End Enum

Public Class Rules
    ' Defines rules of game, makes everything work
    Inherits Control

#Region "Properties"
    ' Defines important properties of the game

    Public Shared Property cellSize As New Size(12, 12)
    Public Property aliveColor As Color = Color.Yellow
    Public intGens As Integer = 0
    Public Property GridSize As New Size(50, 40)
#End Region

    ' Defines grid of cells using cell class
    Private Cells(GridSize.Width - 1, GridSize.Height - 1) As Cell

    Sub New()
        ' Double Buffers graphics: makes it not flicker
        DoubleBuffered = True
        clearArrays()
    End Sub

    Public Sub clearArrays()
        ' Resets the grid
        intGens = 0
        For y As Integer = 0 To GridSize.Width - 1
            For x As Integer = 0 To GridSize.Height - 1
                Cells(x, y) = New Point(x, y)
            Next
        Next
    End Sub
End Class