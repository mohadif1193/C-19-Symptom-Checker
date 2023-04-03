Public Class Form2
    Private Sub btNextMH_Click(sender As Object, e As EventArgs) Handles btNextMH.Click
        Form3.Show()
    End Sub

    Private Sub MedicalHistoryFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SymptomsInputFormToolStripMenuItem.Click
        Form1.Show()
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

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class