﻿Public Class MainMenu

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnTicTacToe_Click(sender As Object, e As EventArgs) Handles btnTicTacToe.Click
        Dim box = New TicTacToe()
        box.Show()
    End Sub

    Private Sub btnInvaderz_Click(sender As Object, e As EventArgs) Handles btnInvaderz.Click
        Dim box = New AlienInvaderz()
        box.Show()
    End Sub

    Private Sub btnHorseRacing_Click(sender As Object, e As EventArgs) Handles btnHorseRacing.Click
        Dim box = New HorseRacing()
        box.Show()
    End Sub

    Private Sub btnTicTacToeVsComputer_Click(sender As Object, e As EventArgs) Handles btnTicTacToeVsComputer.Click
        Dim box = New TicTacToeVsComputer()
        box.Show()
    End Sub
End Class
