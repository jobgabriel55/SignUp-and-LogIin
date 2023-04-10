<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LogIn
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(LogIn))
        Label1 = New Label()
        profile_picture = New PictureBox()
        Combo_username = New ComboBox()
        CheckBox_Showpassword = New CheckBox()
        Button_LogIn = New Button()
        Label2 = New Label()
        Label3 = New Label()
        txt_password = New TextBox()
        CType(profile_picture, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Tomato
        Label1.Location = New Point(71, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(148, 32)
        Label1.TabIndex = 0
        Label1.Text = "LogIn Here!"
        ' 
        ' profile_picture
        ' 
        profile_picture.Image = CType(resources.GetObject("profile_picture.Image"), Image)
        profile_picture.Location = New Point(206, 81)
        profile_picture.Name = "profile_picture"
        profile_picture.Size = New Size(150, 134)
        profile_picture.SizeMode = PictureBoxSizeMode.StretchImage
        profile_picture.TabIndex = 1
        profile_picture.TabStop = False
        ' 
        ' Combo_username
        ' 
        Combo_username.BackColor = SystemColors.Menu
        Combo_username.FormattingEnabled = True
        Combo_username.Location = New Point(172, 310)
        Combo_username.Name = "Combo_username"
        Combo_username.Size = New Size(247, 33)
        Combo_username.TabIndex = 2
        ' 
        ' CheckBox_Showpassword
        ' 
        CheckBox_Showpassword.AutoSize = True
        CheckBox_Showpassword.Location = New Point(388, 394)
        CheckBox_Showpassword.Name = "CheckBox_Showpassword"
        CheckBox_Showpassword.Size = New Size(22, 21)
        CheckBox_Showpassword.TabIndex = 4
        CheckBox_Showpassword.UseVisualStyleBackColor = True
        ' 
        ' Button_LogIn
        ' 
        Button_LogIn.BackColor = Color.Tomato
        Button_LogIn.Location = New Point(206, 467)
        Button_LogIn.Name = "Button_LogIn"
        Button_LogIn.Size = New Size(150, 58)
        Button_LogIn.TabIndex = 5
        Button_LogIn.Text = "LogIn"
        Button_LogIn.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.DimGray
        Label2.Location = New Point(172, 268)
        Label2.Name = "Label2"
        Label2.Size = New Size(99, 28)
        Label2.TabIndex = 6
        Label2.Text = "Username"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = Color.DimGray
        Label3.Location = New Point(172, 357)
        Label3.Name = "Label3"
        Label3.Size = New Size(93, 28)
        Label3.TabIndex = 7
        Label3.Text = "Password"
        ' 
        ' txt_password
        ' 
        txt_password.BackColor = SystemColors.Menu
        txt_password.ForeColor = Color.Black
        txt_password.Location = New Point(172, 388)
        txt_password.Multiline = True
        txt_password.Name = "txt_password"
        txt_password.PasswordChar = "*"c
        txt_password.Size = New Size(247, 36)
        txt_password.TabIndex = 3
        txt_password.UseSystemPasswordChar = True
        ' 
        ' LogIn
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(570, 648)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Button_LogIn)
        Controls.Add(CheckBox_Showpassword)
        Controls.Add(txt_password)
        Controls.Add(Combo_username)
        Controls.Add(profile_picture)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "LogIn"
        Text = "LogIn"
        CType(profile_picture, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents profile_picture As PictureBox
    Friend WithEvents Combo_username As ComboBox
    Friend WithEvents CheckBox_Showpassword As CheckBox
    Friend WithEvents Button_LogIn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_password As TextBox
End Class
