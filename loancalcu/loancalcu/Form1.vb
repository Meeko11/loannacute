Public Class Form1
    Dim loanAmount As Double
    Dim annualInterestRate As Double
    Dim yearsToPay As Integer
    Dim monthlyPayment As Double
    Dim totalLoanPayment As Double
    Dim totalInterest As Double
    Dim totalAnnualPayment As Double
    Dim monthlyInterestRate As Double
    Dim numberOfPayments As Integer
    Dim mp2
    Private Sub Label12_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click

    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click

    End Sub

    Private Sub TextBox13_TextChanged(sender As Object, e As EventArgs) Handles YP2.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox8.Text = TextBox1.Text
        TextBox16.Text = TextBox3.Text
        TextBox10.Text = TextBox2.Text
        TextBox9.Text = TextBox7.Text
        AL2.Text = AL.Text
        IT2.Text = IR.Text & "%"
        mp2 = (IR.Text / (AL.Text * YP.Text))
        MP.Text = mp2

    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged

    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox16_TextChanged(sender As Object, e As EventArgs) Handles TextBox16.TextChanged

    End Sub

    Private Sub TextBox14_TextChanged(sender As Object, e As EventArgs) Handles TAP.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles AL.TextChanged
        loanAmount = AL.Text
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles IR.TextChanged

    End Sub

End Class
