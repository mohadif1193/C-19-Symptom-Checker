Public Class Form5
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btSubmit_Click(sender As Object, e As EventArgs) Handles btSubmit.Click
        MsgBox("Your Form Have been Submitted. And Don't Forget to Take Care of Your Health.")
        End
    End Sub

    Private Sub MedicalHistoryFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SymptomsInputFormToolStripMenuItem.Click
        Form1.Show()
    End Sub

    Private Sub TravelHistoryFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MedicalHistoryFormToolStripMenuItem.Click
        Form2.Show()
    End Sub

    Private Sub HelpAndGuidanceFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TravelHistoryFormToolStripMenuItem.Click
        Form3.Show()
    End Sub

    Private Sub RiskLevelFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RiskLevelFormToolStripMenuItem.Click
        Form4.Show()
    End Sub
End Class