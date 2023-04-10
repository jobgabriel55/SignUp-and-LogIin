<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SignUp
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(SignUp))
        Label1 = New Label()
        upload_picture = New PictureBox()
        Btn_browse = New Button()
        Btn_Back = New Button()
        Label2 = New Label()
        txt_firstname = New TextBox()
        txt_lastname = New TextBox()
        Label_lastname = New Label()
        Label3 = New Label()
        txt_username = New TextBox()
        Label4 = New Label()
        CheckBox_Showpassword = New CheckBox()
        Label5 = New Label()
        Label6 = New Label()
        dob_picker = New DateTimePicker()
        txt_phonenumber = New TextBox()
        Label7 = New Label()
        combo_gender = New ComboBox()
        Label8 = New Label()
        txt_emailaddress = New TextBox()
        Button_Signup = New Button()
        txt_password = New TextBox()
        CType(upload_picture, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Tomato
        Label1.Location = New Point(155, 13)
        Label1.Name = "Label1"
        Label1.Size = New Size(315, 32)
        Label1.TabIndex = 1
        Label1.Text = "Create Your New Account!"
        ' 
        ' upload_picture
        ' 
        upload_picture.Image = CType(resources.GetObject("upload_picture.Image"), Image)
        upload_picture.Location = New Point(220, 56)
        upload_picture.Name = "upload_picture"
        upload_picture.Size = New Size(128, 107)
        upload_picture.SizeMode = PictureBoxSizeMode.StretchImage
        upload_picture.TabIndex = 2
        upload_picture.TabStop = False
        ' 
        ' Btn_browse
        ' 
        Btn_browse.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Btn_browse.Location = New Point(316, 135)
        Btn_browse.Name = "Btn_browse"
        Btn_browse.Size = New Size(37, 37)
        Btn_browse.TabIndex = 3
        Btn_browse.Text = "+"
        Btn_browse.UseVisualStyleBackColor = True
        ' 
        ' Btn_Back
        ' 
        Btn_Back.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Btn_Back.Location = New Point(12, 9)
        Btn_Back.Name = "Btn_Back"
        Btn_Back.Size = New Size(46, 36)
        Btn_Back.TabIndex = 10
        Btn_Back.Text = "<"
        Btn_Back.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.DimGray
        Label2.Location = New Point(57, 185)
        Label2.Name = "Label2"
        Label2.Size = New Size(106, 28)
        Label2.TabIndex = 7
        Label2.Text = "First Name"
        ' 
        ' txt_firstname
        ' 
        txt_firstname.BackColor = SystemColors.Menu
        txt_firstname.Location = New Point(57, 216)
        txt_firstname.Name = "txt_firstname"
        txt_firstname.Size = New Size(218, 31)
        txt_firstname.TabIndex = 8
        ' 
        ' txt_lastname
        ' 
        txt_lastname.BackColor = SystemColors.Menu
        txt_lastname.Location = New Point(326, 216)
        txt_lastname.Name = "txt_lastname"
        txt_lastname.Size = New Size(218, 31)
        txt_lastname.TabIndex = 10
        ' 
        ' Label_lastname
        ' 
        Label_lastname.AutoSize = True
        Label_lastname.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label_lastname.ForeColor = Color.DimGray
        Label_lastname.Location = New Point(326, 185)
        Label_lastname.Name = "Label_lastname"
        Label_lastname.Size = New Size(103, 28)
        Label_lastname.TabIndex = 9
        Label_lastname.Text = "Last Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = Color.DimGray
        Label3.Location = New Point(326, 261)
        Label3.Name = "Label3"
        Label3.Size = New Size(93, 28)
        Label3.TabIndex = 13
        Label3.Text = "Password"
        ' 
        ' txt_username
        ' 
        txt_username.BackColor = SystemColors.Menu
        txt_username.Location = New Point(57, 292)
        txt_username.Name = "txt_username"
        txt_username.Size = New Size(218, 31)
        txt_username.TabIndex = 12
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = Color.DimGray
        Label4.Location = New Point(57, 261)
        Label4.Name = "Label4"
        Label4.Size = New Size(99, 28)
        Label4.TabIndex = 11
        Label4.Text = "Username"
        ' 
        ' CheckBox_Showpassword
        ' 
        CheckBox_Showpassword.AutoSize = True
        CheckBox_Showpassword.Location = New Point(510, 298)
        CheckBox_Showpassword.Name = "CheckBox_Showpassword"
        CheckBox_Showpassword.Size = New Size(22, 21)
        CheckBox_Showpassword.TabIndex = 15
        CheckBox_Showpassword.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = Color.DimGray
        Label5.Location = New Point(57, 346)
        Label5.Name = "Label5"
        Label5.Size = New Size(122, 28)
        Label5.TabIndex = 16
        Label5.Text = "Date of Birth"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.ForeColor = Color.DimGray
        Label6.Location = New Point(326, 346)
        Label6.Name = "Label6"
        Label6.Size = New Size(144, 28)
        Label6.TabIndex = 17
        Label6.Text = "Phone Number"
        ' 
        ' dob_picker
        ' 
        dob_picker.CalendarFont = New Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point)
        dob_picker.CalendarForeColor = Color.DimGray
        dob_picker.CalendarMonthBackground = SystemColors.Menu
        dob_picker.CalendarTrailingForeColor = SystemColors.Menu
        dob_picker.Location = New Point(57, 390)
        dob_picker.Name = "dob_picker"
        dob_picker.Size = New Size(218, 31)
        dob_picker.TabIndex = 18
        ' 
        ' txt_phonenumber
        ' 
        txt_phonenumber.BackColor = SystemColors.Menu
        txt_phonenumber.Location = New Point(326, 390)
        txt_phonenumber.Name = "txt_phonenumber"
        txt_phonenumber.Size = New Size(218, 31)
        txt_phonenumber.TabIndex = 19
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.ForeColor = Color.DimGray
        Label7.Location = New Point(326, 441)
        Label7.Name = "Label7"
        Label7.Size = New Size(76, 28)
        Label7.TabIndex = 20
        Label7.Text = "Gender"
        ' 
        ' combo_gender
        ' 
        combo_gender.BackColor = SystemColors.Menu
        combo_gender.FormattingEnabled = True
        combo_gender.Items.AddRange(New Object() {"Male", "Female"})
        combo_gender.Location = New Point(326, 481)
        combo_gender.Name = "combo_gender"
        combo_gender.Size = New Size(218, 33)
        combo_gender.TabIndex = 21
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.ForeColor = Color.DimGray
        Label8.Location = New Point(57, 441)
        Label8.Name = "Label8"
        Label8.Size = New Size(134, 28)
        Label8.TabIndex = 22
        Label8.Text = "Email Address"
        ' 
        ' txt_emailaddress
        ' 
        txt_emailaddress.BackColor = SystemColors.Menu
        txt_emailaddress.Location = New Point(57, 483)
        txt_emailaddress.Name = "txt_emailaddress"
        txt_emailaddress.Size = New Size(218, 31)
        txt_emailaddress.TabIndex = 23
        ' 
        ' Button_Signup
        ' 
        Button_Signup.BackColor = Color.Tomato
        Button_Signup.Location = New Point(144, 537)
        Button_Signup.Name = "Button_Signup"
        Button_Signup.Size = New Size(351, 58)
        Button_Signup.TabIndex = 9
        Button_Signup.Text = "SignUp"
        Button_Signup.UseVisualStyleBackColor = False
        ' 
        ' txt_password
        ' 
        txt_password.BackColor = SystemColors.Menu
        txt_password.BorderStyle = BorderStyle.FixedSingle
        txt_password.Location = New Point(326, 292)
        txt_password.Name = "txt_password"
        txt_password.Size = New Size(218, 31)
        txt_password.TabIndex = 14
        txt_password.UseSystemPasswordChar = True
        ' 
        ' SignUp
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(570, 648)
        Controls.Add(Button_Signup)
        Controls.Add(txt_emailaddress)
        Controls.Add(Label8)
        Controls.Add(combo_gender)
        Controls.Add(Label7)
        Controls.Add(txt_phonenumber)
        Controls.Add(dob_picker)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(CheckBox_Showpassword)
        Controls.Add(txt_password)
        Controls.Add(Label3)
        Controls.Add(txt_username)
        Controls.Add(Label4)
        Controls.Add(txt_lastname)
        Controls.Add(Label_lastname)
        Controls.Add(txt_firstname)
        Controls.Add(Label2)
        Controls.Add(Btn_Back)
        Controls.Add(Btn_browse)
        Controls.Add(upload_picture)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "SignUp"
        StartPosition = FormStartPosition.CenterScreen
        CType(upload_picture, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents upload_picture As PictureBox
    Friend WithEvents Btn_browse As Button
    Friend WithEvents Btn_Back As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_firstname As TextBox
    Friend WithEvents txt_lastname As TextBox
    Friend WithEvents Label_lastname As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_username As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CheckBox_Showpassword As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents dob_picker As DateTimePicker
    Friend WithEvents txt_phonenumber As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents combo_gender As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_emailaddress As TextBox
    Friend WithEvents Button_Signup As Button
    Friend WithEvents txt_password As TextBox
End Class
