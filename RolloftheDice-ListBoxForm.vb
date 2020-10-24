Option Strict On
Option Explicit On
Option Compare Binary

'Justine Hoffa
'RCET0265
'Fall2020
'Roll of the Dice List Box Form
'https://github.com/justinehoffa/Roll-of-the-Dice-List-Box

Public Class RolloftheDice
    Sub RollDice()

        Dim randomNumber As Integer
        Dim data(10) As Integer
        Dim row1 As String
        Dim row2 As String
        Dim dashLines As String

        For i = 1 To 1000
            randomNumber = CInt(GetRandomNumber(1, 6))
            data(randomNumber - 2) += 1
        Next

        For i = 2 To 12
            row1 = row1 & String.Format("{0, 11}", i) & "|"
        Next

        For i = 0 To 10
            row2 = row2 & String.Format("{0, 10}", data(i)) & "|"
        Next

        dashLines = (StrDup(135, "-"))

        DiceListBox.Items.Add("")
        DiceListBox.Items.Add(dashLines)
        DiceListBox.Items.Add(" Numbers:" & vbTab & row1)
        DiceListBox.Items.Add(dashLines)
        DiceListBox.Items.Add(" Times Rolled:" & vbTab & row2)
        DiceListBox.Items.Add(dashLines)

        Erase data
        ReDim data(12)

    End Sub

    Function GetRandomNumber(ByVal min As Single, ByVal max As Single) As Single
        Dim diceOne, diceTwo As Double
        Dim sum As Integer

        Do
            diceOne = (max * Rnd()) + 0.5
            diceTwo = (max * Rnd()) + 0.5
        Loop While diceOne < min - 0.5 Or diceOne >= max + 0.5 Or
            diceTwo < min - 0.5 Or diceTwo >= max + 0.5

        sum = CInt(diceOne) + CInt(diceTwo)
        Return sum

    End Function
    Private Sub RollButton_Click(sender As Object, e As EventArgs) Handles RollButton.Click
        RollDice()
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        DiceListBox.Items.Clear()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        DiceListBox.Items.Clear()
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click

        Dim message As String
        Dim title As String

        title = "Help"
        message = "Use Roll button or letter 'r' to roll dice." & vbNewLine & "Use Clear button or letter 'c' to clear dice rolls."

        MessageBox.Show(message, title)


    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub RollToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RollToolStripMenuItem.Click
        RollDice()
    End Sub

End Class
