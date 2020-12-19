Public Class frmMain
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtGroupSize.Text = ""
        radCon.Checked = False
        radConAutographs.Checked = False
        radConSuperhero.Checked = True
        lblCost.Text = ""
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        If (String.IsNullOrEmpty(txtGroupSize.Text) Or Not IsNumeric(txtGroupSize.Text)) Then
            MsgBox("Invalid group size. Try again.")
        ElseIf (txtGroupSize.Text < 0 Or txtGroupSize.Text > 20) Then
            MsgBox("Group size must be between 1 and 20.")
        Else
            Dim intGroupSize As Integer = txtGroupSize.Text
            Dim decCostPerPerson As Decimal = 0.0
            If (radCon.Checked) Then
                decCostPerPerson = 209.0
            ElseIf (radConAutographs.Checked) Then
                decCostPerPerson = 275.0
            ElseIf (radConSuperhero.Checked) Then
                decCostPerPerson = 380.0
            End If
            Dim decTotalCost As Decimal = intGroupSize * decCostPerPerson
            lblCost.Text = decTotalCost.ToString("C2")
        End If
    End Sub
End Class
