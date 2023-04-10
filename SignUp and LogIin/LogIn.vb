Imports System.Data.OleDb
Imports System.IO

Public Class LogIn
    Dim conn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\hp\source\repos\SignUp And LogIin\SignUp And LogIin\signup.accdb;Persist Security Info=True")

    Dim cmd As OleDbCommand

    Dim dt As DataTable
    Dim da As OleDbDataAdapter
    Dim dr As OleDbDataReader

    Private Sub LogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        usercomboload()


    End Sub

    Private Sub CheckBox_Showpassword_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_Showpassword.CheckedChanged
        If CheckBox_Showpassword.Checked = True Then
            txt_password.UseSystemPasswordChar = True
        Else
            txt_password.UseSystemPasswordChar = False


        End If
    End Sub

    Sub usercomboload()




        conn.Open()


        Combo_username.Items.Clear()
        Dim cmd As New OleDb.OleDbCommand("select * from signup", conn)
        dr = cmd.ExecuteReader
        While dr.Read
            Combo_username.Items.Add(dr.GetString(3))
        End While
        dr.Close()

        conn.Close()
        usercomboload()

    End Sub






    Private Sub Combo_username_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combo_username.SelectedIndexChanged
        Dim picture() As Byte
        profile_picture.Image = Nothing

        Try
            conn.Open()
            Dim cmd As New OleDb.OleDbCommand("select * from signup where username=@username", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@username", Combo_username.Text)
            da = New OleDbDataAdapter
            dt = New DataTable
            da.SelectCommand = cmd
            da.Fill(dt)
            'converting image to binary
            picture = dt.Rows(0).Item("pic")

            Dim mstream As New System.IO.MemoryStream(picture)
            profile_picture.Image = Image.FromStream(mstream)


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        conn.Close()
    End Sub

    Private Sub Button_LogIn_Click(sender As Object, e As EventArgs) Handles Button_LogIn.Click
        Try
            conn.Open()
            Dim cmd As New OleDbCommand("select * from signup where username=@username AND password=@password", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@username", Combo_username.Text)
            cmd.Parameters.AddWithValue("@password", txt_password.Text)
            Dim username As String = ""
            Dim password As String = ""
            dr = cmd.ExecuteReader
            If (dr.Read() = True) Then
                username = dr(username)
                password = dr(password)
                MsgBox("Succesful log in!", vbInformation)
            Else
                MsgBox("Wrong password!", vbCritical)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

End Class