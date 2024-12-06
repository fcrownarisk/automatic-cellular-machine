Imports System
Imports System.Windows.Forms
Imports System.Drawing

Public Class CellularAutomaton
    Inherits Form

    Private Const GridSize As Integer = 50
    Private Const CellSize As Integer = 10
    Private grid(GridSize - 1, GridSize - 1) As Boolean
    Private timer As Timer

    Public Sub New()
        InitializeComponent()
        InitializeGrid()
        SetupTimer()
    End Sub

    Private Sub InitializeComponent()
        Me.Size = New Size(GridSize * CellSize + 20, GridSize * CellSize + 40)
        Me.Text = "Cellular Automaton"
        Me.DoubleBuffered = True
    End Sub

    Private Sub InitializeGrid()
        Dim rand As New Random()
        For x As Integer = 0 To GridSize - 1
            For y As Integer = 0 To GridSize - 1
                grid(x, y) = rand.Next(2) = 1
            Next
        Next
    End Sub

    Private Sub SetupTimer()
        timer = New Timer()
        timer.Interval = 100 ' Update every 100 milliseconds
        AddHandler timer.Tick, AddressOf TimerTick
        timer.Start()
    End Sub

    Private Sub TimerTick(sender As Object, e As EventArgs)
        UpdateGrid()
        Me.Invalidate()
    End Sub

    Private Sub UpdateGrid()
        Dim newGrid(GridSize - 1, GridSize - 1) As Boolean

        For x As Integer = 0 To GridSize - 1
            For y As Integer = 0 To GridSize - 1
                Dim neighbors As Integer = CountNeighbors(x, y)
                If grid(x, y) Then
                    newGrid(x, y) = neighbors = 2 OrElse neighbors = 3
                Else
                    newGrid(x, y) = neighbors = 3
                End If
            Next
        Next

        grid = newGrid
    End Sub

    Private Function CountNeighbors(x As Integer, y As Integer) As Integer
        Dim count As Integer = 0
        For i As Integer = -1 To 1
            For j As Integer = -1 To 1
                If i = 0 AndAlso j = 0 Then Continue For
                Dim nx As Integer = (x + i + GridSize) Mod GridSize
                Dim ny As Integer = (y + j + GridSize) Mod GridSize
                If grid(nx, ny) Then count += 1
            Next
        Next
        Return count
    End Function

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        For x As Integer = 0 To GridSize - 1
            For y As Integer = 0 To GridSize - 1
                If grid(x, y) Then
                    e.Graphics.FillRectangle(Brushes.Black, x * CellSize, y * CellSize, CellSize - 1, CellSize - 1)
                End If
            Next
        Next
    End Sub
End Class

Module Program
    Sub Main()
        Application.Run(New CellularAutomaton())
    End Sub
End Module

