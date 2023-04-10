Public Class Form1
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panel1_Paint_1(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SignUp.TopLevel = False
        Panel2.Controls.Add(SignUp)
        SignUp.BringToFront()
        SignUp.Show()
    End Sub

    Private Sub Form1_load(sender As Object, e As EventArgs) Handles MyBase.Load
        LogIn.TopLevel = False
        Panel2.Controls.Add(LogIn)
        LogIn.BringToFront()
        LogIn.Show()


    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Me.Close()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Me.Hide()
        Homepage.Show()

    End Sub
End Class
