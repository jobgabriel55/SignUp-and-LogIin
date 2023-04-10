Public Class Homepage
    Private Sub Button_Register_Click(sender As Object, e As EventArgs) Handles Button_Register.Click
        Me.Hide()
        Scholar_Registration.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Player_registration.Show()

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Me.Close()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class