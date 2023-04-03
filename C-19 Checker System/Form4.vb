Public Class Form4

    Private Sub btNextRL_Click(sender As Object, e As EventArgs) Handles btNextRL.Click
        Form5.Show()
    End Sub

    Private Sub MedicalHistoryFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SymptomsInputFormToolStripMenuItem.Click
        Form1.Show()
    End Sub

    Private Sub TravelHistoryFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MedicalHistoryFormToolStripMenuItem.Click
        Form2.Show()
    End Sub

    Private Sub RiskLevelFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TravelHistoryFormToolStripMenuItem.Click
        Form3.Show()
    End Sub

    Private Sub HelpAndGuidanceFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpAndGuidanceFormToolStripMenuItem.Click
        Form5.Show()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim count As Integer = 0
        For Each control As Control In Form1.Controls
            If TypeOf control Is CheckBox AndAlso DirectCast(control, CheckBox).Checked Then
                count += 1
            End If
        Next

        If count <= 3 Then
            'Do something if x is greater than 0
            lbOP.Text = lblLowRisk.Text
        ElseIf count >= 4 And count <= 6 Then
            'Do something if x is less than 0
            lbOP.Text = lblModerateRisk.Text
        ElseIf count >= 7 Then
            'Do something if x is less than 0
            lbOP.Text = lblHighRisk.Text
        Else
            'Do something if x is equal to 0
            lbOP.Text = "INVALID"
        End If
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class