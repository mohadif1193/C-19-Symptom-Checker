Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btNextTH_Click(sender As Object, e As EventArgs) Handles btNextTH.Click
        Form4.Show()
    End Sub

    Private Sub MedicalHistoryFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SymptomsInputFormToolStripMenuItem.Click
        Form1.Show()
    End Sub

    Private Sub TravelHistoryFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MedicalHistoryFormToolStripMenuItem.Click
        Form2.Show()
    End Sub

    Private Sub RiskLevelFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RiskLevelFormToolStripMenuItem.Click
        Form4.Show()
    End Sub

    Private Sub HelpAndGuidanceFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpAndGuidanceFormToolStripMenuItem.Click
        Form5.Show()
    End Sub
End Class