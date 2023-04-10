
Imports System.Data.OleDb

Public Class Scholar_Registration
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hp\source\repos\SignUp and LogIin\SignUp and LogIin\Registration as a scholar.accdb")
    Dim dr As OleDbDataReader
    Private Sub Scholar_Registration_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Sub save()
        Try
            conn.Open()
            Dim cmd As New OleDb.OleDbCommand("Insert INTO scholars ('firstname,lastname,phonenumber,gender,dob,emailaddress,age,course,mode') Values(@firstname,@lastname,@phonenumber,@gender,@dob,@emailaddress,@age,@course,@mode)", conn)
            Dim i As Integer
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@firstname", txt_firstname.Text)
            cmd.Parameters.AddWithValue("@lastname", txt_lastname.Text)
            cmd.Parameters.AddWithValue("@phonenumber", txt_phonenumber.Text)
            cmd.Parameters.AddWithValue("@gender", combo_gender.Text)
            cmd.Parameters.AddWithValue("@dob", CDate(dob_picker.Value))
            cmd.Parameters.AddWithValue("@emailaddress", txt_firstname.Text)
            cmd.Parameters.AddWithValue("@age", txt_age.Text)
            cmd.Parameters.AddWithValue("@course", combo_course.Text)
            cmd.Parameters.AddWithValue("@mode", combo_mode.Text)

            cmd.ExecuteNonQuery()
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
            combo_course.Text = ""
            combo_mode.Text = ""
            Me.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()


    End Sub

    Private Sub Button_Register_Click(sender As Object, e As EventArgs) Handles Button_Register.Click
        save()
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Me.Close()

    End Sub
End Class