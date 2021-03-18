Option Strict On
Public Class IntCalculatorAppFRM
    Private Sub addBTN_Click(sender As Object, e As EventArgs) Handles addBTN.Click
        Try
            outputLBL.Text = (CInt(aTBX.Text) + CInt(bTBX.Text)).ToString
        Catch ex As System.InvalidCastException
            MessageBox.Show("Invalid Input", "Invalid")
        End Try
    End Sub

    Private Sub minusBTN_Click(sender As Object, e As EventArgs) Handles minusBTN.Click
        Try
            outputLBL.Text = (CInt(aTBX.Text) - CInt(bTBX.Text)).ToString
        Catch ex As System.InvalidCastException
            MessageBox.Show("Invalid Input", "Invalid")
        End Try
    End Sub

    Private Sub multiplyBTH_Click(sender As Object, e As EventArgs) Handles multiplyBTH.Click
        Try
            outputLBL.Text = (CInt(aTBX.Text) * CInt(bTBX.Text)).ToString
        Catch ex As System.InvalidCastException
            MessageBox.Show("Invalid Input", "Invalid")
        End Try
    End Sub

    Private Sub divideBTN_Click(sender As Object, e As EventArgs) Handles divideBTN.Click
        Try
            outputLBL.Text = (CInt(aTBX.Text) \ CInt(bTBX.Text)).ToString

        Catch ex As System.InvalidCastException
            MessageBox.Show("Invalid Input", "Invalid")
        Catch ey As System.DivideByZeroException
            MessageBox.Show("B value cannot be 0 for \", "Invalid")
        End Try
    End Sub

    Private Sub aTBX_TextChanged(sender As Object, e As EventArgs) Handles aTBX.TextChanged
        outputLBL.Text = ""
    End Sub

    Private Sub bTBX_TextChanged(sender As Object, e As EventArgs) Handles bTBX.TextChanged
        outputLBL.Text = ""
    End Sub


End Class
