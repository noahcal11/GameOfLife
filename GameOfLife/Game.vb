Option Strict On
Imports GameOfLife

Public Class frmGame
    ' Declaring public variables
    Public bmp As Bitmap
    Public G As Graphics

    Private Sub picGrid_Paint(sender As Object, e As PaintEventArgs) Handles picGrid.Paint
        ' Loads bitmap, graphics, etc and prepares to begin simulations

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

        'Draw border on entire control.
        G.DrawRectangle(Pens.DimGray, 0, 0, Width - 1, Height - 1)

        ' Update cells status after each generation

        ' Draw alive cells in yellow
        For Each cell As Cell In Cells
            If cell.status = status.Alive Then
                G.FillRectangle(New SolidBrush(Yellow), New Rectangle(cell.location.X * cellSize.Width, cell.location.Y * cellSize.Height, cellSize.Width, cellSize.Height))
            End If
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

Public Class Cell
    ' Creates cell class, defines cell
    Public status As status = status.Dead
    Public location As Point
    Public shouldToggle As Boolean = False
    Sub New(x As Point)
        Me.location = x
    End Sub
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
                Cells(x, y) = New Cell(New Point(x, y))
            Next
        Next
    End Sub

    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        ' Creates e.X and e.Y for OnMouseMove sub
        MyBase.OnMouseDown(e)
        Select Case e.Button
            Case MouseButtons.Left
                OnMouseMove(New MouseEventArgs(MouseButtons.Left, 1, e.X, e.Y, e.Delta))
            Case MouseButtons.Right
                OnMouseMove(New MouseEventArgs(MouseButtons.Right, 1, e.X, e.Y, e.Delta))
        End Select
    End Sub

    Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
        ' Changes status of cell when clicked
        MyBase.OnMouseMove(e)
        If e.Button = MouseButtons.Left Then
            Try
                changeCell(Cells(CInt(Math.Floor(e.X / cellSize.Width)), CInt(Math.Floor(e.Y / cellSize.Height))), status.Alive)
            Catch ex As Exception
                ' Cell does not exist
            End Try
        ElseIf e.Button = MouseButtons.Right Then
            Try
                changeCell(Cells(CInt(Math.Floor(e.X / cellSize.Width)), CInt(Math.Floor(e.Y / cellSize.Height))), status.Dead)
            Catch ex As Exception
                ' Cell does not exist
            End Try
        End If
    End Sub

    Private Sub changeCell(sourceCell As Cell, toStatus As status)
        ' Change cell sub for mouse move sub
        sourceCell.status = toStatus
    End Sub

    Private Sub toggleCell(cell As Cell)
        cell.status = CType(IIf(cell.status = status.Alive, status.Dead, status.Alive), status)
    End Sub
End Class