'Name: Mohd Hadif Bin Roslan Matrices No : 20DDT21F1050
'Name:  Matrices No :  20DDT21
'Name:  Matrices No :  20DDT21
Public Class Form1
    Private Sub btNext_Click(sender As Object, e As EventArgs) Handles btNext.Click
        Form2.Show()
    End Sub

    Private Sub MedicalHistoryFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MedicalHistoryFormToolStripMenuItem.Click
        Form2.Show()
    End Sub

    Private Sub TravelHistoryFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TravelHistoryFormToolStripMenuItem.Click
        Form3.Show()
    End Sub

    Private Sub RiskLevelFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RiskLevelFormToolStripMenuItem.Click
        Form4.Show()
    End Sub

    Private Sub HelpAndGuidanceFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpAndGuidanceFormToolStripMenuItem.Click
        Form5.Show()
    End Sub

    Public Property StringPass As String

End Class
