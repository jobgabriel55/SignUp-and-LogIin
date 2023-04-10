
Imports System.Data.OleDb
Public Class Player_registration
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hp\source\repos\SignUp and LogIin\SignUp and LogIin\Registration as a player.accdb")

    Sub save()
        Try
            conn.Open()
            Dim cmd As New OleDb.OleDbCommand("Insert INTO players('firstname,lastname, phonenumber, gender, dob, age, emailaddress, position, foot, height, weight') Values(@firstname,@lastname,@phonenumber,@gender,@dob,@age,@emailaddress,@position,@foot,@height,@weight)", conn)
            Dim i As Integer
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@firstname", txt_firstname.Text)
            cmd.Parameters.AddWithValue("@lastname", txt_lastname.Text)
            cmd.Parameters.AddWithValue("@phonenumber", txt_phonenumber.Text)
            cmd.Parameters.AddWithValue("@gender", combo_gender.Text)
            cmd.Parameters.AddWithValue("@dob", CDate(dob_picker.Value))
            cmd.Parameters.AddWithValue("@age", txt_age.Text)
            cmd.Parameters.AddWithValue("@emailaddress", txt_emailaddress.Text)
            cmd.Parameters.AddWithValue("@position", combo_position.Text)
            cmd.Parameters.AddWithValue("@foot", combo_foot.Text)
            cmd.Parameters.AddWithValue("@height", txt_height.Text)
            cmd.Parameters.AddWithValue("@weight", txt_weight.Text)

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("Registration Success! We'll contact you for further information", vbInformation)
            Else
                MsgBox("Registration failed!", vbCritical)
            End If

            txt_firstname.Clear()
            txt_lastname.Clear()
            txt_phonenumber.Clear()
            combo_gender.Text = ""
            dob_picker.Value = " "
            txt_emailaddress.Clear()
            txt_age.Clear()
            combo_position.Text = ""
            combo_foot.Text = ""
            txt_height.Clear()
            txt_weight.Clear()
            Me.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()


    End Sub

    Private Sub Button_Register_Click(sender As Object, e As EventArgs) Handles Button_Register.Click
        save()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Me.Close()
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class