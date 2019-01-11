Public Class frmGame
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ' Hides rules form, shows main menu form
        frmMainMenu.Show()
        Me.Hide()

    End Sub

    Private Sub btnNextGen_Click(sender As Object, e As EventArgs) Handles btnNextGen.Click
        ' Advances game by one generation
        speed.Stop()
        rlsGrid.nextGeneration()
        lblGenerations.Text = "Generations: " & rlsGrid.intGens.ToString
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        ' Starts timer
        speed.Start()
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        ' Stops timer
        speed.Stop()
    End Sub

    Private Sub speed_Tick(sender As Object, e As EventArgs) Handles speed.Tick
        ' Advances game by one generation per tick
        rlsGrid.nextGeneration()
        lblGenerations.Text = "Generations: " & rlsGrid.intGens.ToString
    End Sub

    Private Sub btnRestart_Click(sender As Object, e As EventArgs) Handles btnRestart.Click
        ' Resets grid
        rlsGrid.clearArrays()
        speed.Stop()
        lblGenerations.Text = "Generations: " & rlsGrid.intGens.ToString
    End Sub

    Private Sub tbrSpeed_Scroll(sender As Object, e As EventArgs) Handles tbrSpeed.Scroll
        ' Changes speed of timer when trackbar is changed
        Dim trkBar As TrackBar = CType(sender, TrackBar)
        speed.Interval = 50 + 25 * (trkBar.Value)
        lblSpeed.Text = "Interval = " & speed.Interval.ToString & "ms"
    End Sub

    Private Sub frmGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        speed.Interval = 50
        lblSpeed.Text = "Interval = " & speed.Interval.ToString & "ms"
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

    Public Property cellSize As New Size(12, 12)
    Public Property aliveColor As Color = Color.Yellow
    Public intGens As Integer = 0
    Private _GridSize As New Size(50, 40)
    Public Property GridSize As Size
        Get
            Return _GridSize
        End Get
        Set(value As Size)
            _GridSize = value
            ReDim Cells(_GridSize.Width - 1, _GridSize.Height - 1)
            Invalidate()
            clearArrays()
        End Set
    End Property
#End Region

    ' Defines grid of cells using cell class
    Private Cells(GridSize.Width - 1, GridSize.Height - 1) As Cell

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        ' Loads graphics and prepares to begin simulations
        MyBase.OnPaint(e)
        Dim g As Graphics = e.Graphics : e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighSpeed

        For Each cell As Cell In Cells
            'Updates the cells that should be dead or alive after last generation.
            If cell.shouldToggle Then
                cell.shouldToggle = False
                toggleCell(cell)
            End If
        Next

        For Each cell As Cell In Cells
            'Draw cells that are alive in selected colour.
            If cell.status = status.Alive Then
                g.FillRectangle(New SolidBrush(aliveColor), New Rectangle(cell.location.X * cellSize.Width, cell.location.Y * cellSize.Height, cellSize.Width, cellSize.Height))
            End If
        Next

        'Draw grid, dependent on universe size.
        For x As Integer = 0 To _GridSize.Width
            g.DrawLine(Pens.Gray, x * cellSize.Width, 0, x * cellSize.Width, Height)
        Next
        For y As Integer = 0 To _GridSize.Height
            g.DrawLine(Pens.Gray, 0, y * cellSize.Height, Width, y * cellSize.Height)
        Next

        'Draw border on entire control.
        g.DrawRectangle(Pens.Gray, 0, 0, Width - 1, Height - 1)
    End Sub

    Sub New()
        ' Double Buffers graphics: makes it not flicker
        DoubleBuffered = True
        clearArrays()
    End Sub

    Public Sub clearArrays()
        ' Resets the grid
        intGens = 0
        For x As Integer = 0 To GridSize.Width - 1
            For y As Integer = 0 To GridSize.Height - 1
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
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Try
                changeCell(Cells((Math.Floor(e.X / cellSize.Width)), (Math.Floor(e.Y / cellSize.Height))), status.Alive)
            Catch ex As Exception
                ' Cell does not exist
            End Try
        ElseIf e.Button = Windows.Forms.MouseButtons.Right Then
            Try
                changeCell(Cells((Math.Floor(e.X / cellSize.Width)), (Math.Floor(e.Y / cellSize.Height))), status.Dead)
            Catch ex As Exception
                ' Cell does not exist
            End Try
        End If
        Invalidate()
    End Sub

    Private Sub changeCell(sourceCell As Cell, toStatus As status)
        ' Change cell sub for mouse move sub
        sourceCell.status = toStatus
    End Sub

    Private Sub toggleCell(cell As Cell)
        cell.status = IIf(cell.status = status.Alive, status.Dead, status.Alive)
    End Sub

    Private Function gridArray(x As Integer, y As Integer) As Point
        ' I DON'T KNOW WHAT THIS DOES BUT IT MAKES IT WORK
        Dim outputX, outputY As Integer
        If x > -1 Then
            outputX = x Mod _GridSize.Width
        Else
            ' This makes it toroidal - loops around and grid has no edges:
            ' outputX = _GridSize.Width - Math.Abs(x)
            ' Because this line is commented out, the grid ends on the edges
        End If
        If y > -1 Then
            outputY = y Mod _GridSize.Height
        Else
            ' This makes it toroidal - loops around and grid has no edges:
            ' outputY = _GridSize.Height - Math.Abs(y)
            ' Because this line is commented out, the grid ends on the edges
        End If
        Return New Point(outputX, outputY)
    End Function

    Private Function getCellStatus(x As Integer, y As Integer) As status
        ' Gets status of cells (self explanatory)
        Return Cells(gridArray(x, y).X, gridArray(x, y).Y).status
    End Function

    Private Function neighborStatus(sourceCell As Cell) As Integer
        ' Returns status of neighbors of each cell
        Dim neighborCount As Integer = 0
        ' Up
        If getCellStatus(sourceCell.location.X, sourceCell.location.Y + 1) = status.Alive Then neighborCount += 1
        ' Down
        If getCellStatus(sourceCell.location.X, sourceCell.location.Y - 1) = status.Alive Then neighborCount += 1
        ' Left
        If getCellStatus(sourceCell.location.X - 1, sourceCell.location.Y) = status.Alive Then neighborCount += 1
        ' Right
        If getCellStatus(sourceCell.location.X + 1, sourceCell.location.Y) = status.Alive Then neighborCount += 1
        ' UpLeft
        If getCellStatus(sourceCell.location.X - 1, sourceCell.location.Y + 1) = status.Alive Then neighborCount += 1
        ' UpRight
        If getCellStatus(sourceCell.location.X + 1, sourceCell.location.Y + 1) = status.Alive Then neighborCount += 1
        ' DownLeft
        If getCellStatus(sourceCell.location.X - 1, sourceCell.location.Y - 1) = status.Alive Then neighborCount += 1
        ' DownRight
        If getCellStatus(sourceCell.location.X + 1, sourceCell.location.Y - 1) = status.Alive Then neighborCount += 1
        Return neighborCount
    End Function

    Private Sub updateCell(cell As Cell)
        ' Contains 4 rules of GoL. activates for each cell
        Dim aliveNeighbors As Integer = neighborStatus(cell)
        ' Rule 1
        If cell.status = status.Alive And aliveNeighbors < 2 Then
            Cells(cell.location.X, cell.location.Y).shouldToggle = True
            ' Rule 2
        ElseIf cell.status = status.Alive And (aliveNeighbors = 2 Or aliveNeighbors = 3) Then
            Cells(cell.location.X, cell.location.Y).shouldToggle = False
            ' Rule 3
        ElseIf cell.status = status.Alive And aliveNeighbors > 3 Then
            Cells(cell.location.X, cell.location.Y).shouldToggle = True
            ' Rule 4
        ElseIf cell.status = status.Dead And aliveNeighbors = 3 Then
            Cells(cell.location.X, cell.location.Y).shouldToggle = True
        End If
    End Sub

    Public Sub nextGeneration()
        ' Updates grid by one generation by updating each cell
        For y As Integer = 0 To _GridSize.Height - 1
            For x As Integer = 0 To _GridSize.Width - 1
                updateCell(Cells(x, y))
            Next
        Next
        intGens += 1
        Invalidate()
    End Sub
End Class