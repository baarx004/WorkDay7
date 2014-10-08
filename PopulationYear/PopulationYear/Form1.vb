Option Strict On

Public Class Form1

    Private Sub btnPopulation_Click(sender As Object, e As EventArgs) Handles btnPopulation.Click
        Dim population As Double
        Dim year As Integer
        population = 7000.0
        year = 2014
        Do While (population > 6)
            population = population / 2
            year = year - 50
        Loop


        MessageBox.Show("The answer is " & year)

    End Sub

End Class
