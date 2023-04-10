Public Class SignUp
    Dim conn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hp\source\repos\SignUp and LogIin\SignUp and LogIin\signup.accdb")


    Private Sub SignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub CheckBox_Showpassword_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_Showpassword.CheckedChanged
        If CheckBox_Showpassword.Checked = True Then
            txt_password.UseSystemPasswordChar = False

        Else
            txt_password.UseSystemPasswordChar = True


        End If
    End Sub

    Private Sub Btn_browse_Click(sender As Object, e As EventArgs) Handles Btn_browse.Click
        Dim pop As OpenFileDialog = New OpenFileDialog
        If pop.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            upload_picture.Image = Image.FromFile(pop.FileName)
        End If
    End Sub

    Sub save()
        Try
            conn.Open()



            Dim cmd As New OleDb.OleDbCommand("insert into signup (firstname, lastname, username, password, dob, phonenumber, emailaddress, gender)  VALUES (@firstname, @lastname, @username, @password, @dob, @phonenumber, @emailaddress, @gender", conn)

            Dim i As New Integer
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@firstname", txt_firstname.Text)
            cmd.Parameters.AddWithValue("@lastname", txt_lastname.Text)
            cmd.Parameters.AddWithValue("@username", txt_username.Text)
            cmd.Parameters.AddWithValue("@password", txt_password.Text)
            cmd.Parameters.AddWithValue("@dob", CDate(dob_picker.Value))
            cmd.Parameters.AddWithValue("@phonenumber", txt_phonenumber.Text)
            cmd.Parameters.AddWithValue("@emailaddress", txt_emailaddress.Text)
            cmd.Parameters.AddWithValue("@gender", combo_gender.Text)

            cmd.ExecuteNonQuery()

            If i > 0 Then


                MsgBox("New User Register Success !", vbInformation)
            Else
                MsgBox("New User Register Failed !", vbCritical)
            End If
            txt_firstname.Clear()
            txt_lastname.Clear()
            txt_username.Clear()
            txt_password.Clear()
            dob_picker.Text = ""
            txt_phonenumber.Clear()
            txt_emailaddress.Clear()
            combo_gender.Text = ""
            Me.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        LogIn.usercomboload()

    End Sub

    Private Sub Button_Signup_Click(sender As Object, e As EventArgs) Handles Button_Signup.Click
        Me.Hide()
        Homepage.Show()
        save()



    End Sub

    Private Sub Btn_Back_Click(sender As Object, e As EventArgs) Handles Btn_Back.Click
        Me.Dispose()

    End Sub



End Class
