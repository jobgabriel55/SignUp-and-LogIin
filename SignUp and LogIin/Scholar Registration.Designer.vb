<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class scholar_registration
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
        Button_Register = New Button()
        txt_emailaddress = New TextBox()
        Label8 = New Label()
        combo_gender = New ComboBox()
        txt_phonenumber = New TextBox()
        dob_picker = New DateTimePicker()
        Label6 = New Label()
        Label5 = New Label()
        txt_lastname = New TextBox()
        Label_lastname = New Label()
        txt_firstname = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        Label3 = New Label()
        combo_mode = New ComboBox()
        Label4 = New Label()
        Label9 = New Label()
        Label11 = New Label()
        txt_age = New TextBox()
        combo_course = New ComboBox()
        Label7 = New Label()
        Label10 = New Label()
        SuspendLayout()
        ' 
        ' Button_Register
        ' 
        Button_Register.BackColor = Color.Tomato
        Button_Register.Location = New Point(509, 534)
        Button_Register.Name = "Button_Register"
        Button_Register.Size = New Size(351, 58)
        Button_Register.TabIndex = 30
        Button_Register.Text = "Register"
        Button_Register.UseVisualStyleBackColor = False
        ' 
        ' txt_emailaddress
        ' 
        txt_emailaddress.BackColor = SystemColors.Menu
        txt_emailaddress.Location = New Point(971, 255)
        txt_emailaddress.Name = "txt_emailaddress"
        txt_emailaddress.Size = New Size(218, 31)
        txt_emailaddress.TabIndex = 43
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.ForeColor = Color.DimGray
        Label8.Location = New Point(971, 224)
        Label8.Name = "Label8"
        Label8.Size = New Size(134, 28)
        Label8.TabIndex = 42
        Label8.Text = "Email Address"
        ' 
        ' combo_gender
        ' 
        combo_gender.BackColor = SystemColors.Menu
        combo_gender.FormattingEnabled = True
        combo_gender.Items.AddRange(New Object() {"Male", "Female"})
        combo_gender.Location = New Point(58, 255)
        combo_gender.Name = "combo_gender"
        combo_gender.Size = New Size(218, 33)
        combo_gender.TabIndex = 41
        ' 
        ' txt_phonenumber
        ' 
        txt_phonenumber.BackColor = SystemColors.Menu
        txt_phonenumber.Location = New Point(971, 127)
        txt_phonenumber.Name = "txt_phonenumber"
        txt_phonenumber.Size = New Size(218, 31)
        txt_phonenumber.TabIndex = 39
        ' 
        ' dob_picker
        ' 
        dob_picker.CalendarFont = New Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point)
        dob_picker.CalendarForeColor = Color.DimGray
        dob_picker.CalendarMonthBackground = SystemColors.Menu
        dob_picker.CalendarTitleBackColor = SystemColors.ControlText
        dob_picker.CalendarTitleForeColor = SystemColors.Menu
        dob_picker.CalendarTrailingForeColor = SystemColors.Menu
        dob_picker.Location = New Point(535, 257)
        dob_picker.Name = "dob_picker"
        dob_picker.Size = New Size(218, 31)
        dob_picker.TabIndex = 38
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.ForeColor = Color.DimGray
        Label6.Location = New Point(971, 96)
        Label6.Name = "Label6"
        Label6.Size = New Size(144, 28)
        Label6.TabIndex = 37
        Label6.Text = "Phone Number"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = Color.DimGray
        Label5.Location = New Point(535, 224)
        Label5.Name = "Label5"
        Label5.Size = New Size(122, 28)
        Label5.TabIndex = 36
        Label5.Text = "Date of Birth"
        ' 
        ' txt_lastname
        ' 
        txt_lastname.BackColor = SystemColors.Menu
        txt_lastname.Location = New Point(535, 127)
        txt_lastname.Name = "txt_lastname"
        txt_lastname.Size = New Size(218, 31)
        txt_lastname.TabIndex = 31
        ' 
        ' Label_lastname
        ' 
        Label_lastname.AutoSize = True
        Label_lastname.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label_lastname.ForeColor = Color.DimGray
        Label_lastname.Location = New Point(535, 96)
        Label_lastname.Name = "Label_lastname"
        Label_lastname.Size = New Size(103, 28)
        Label_lastname.TabIndex = 29
        Label_lastname.Text = "Last Name"
        ' 
        ' txt_firstname
        ' 
        txt_firstname.BackColor = SystemColors.Menu
        txt_firstname.Location = New Point(58, 127)
        txt_firstname.Name = "txt_firstname"
        txt_firstname.Size = New Size(218, 31)
        txt_firstname.TabIndex = 28
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.DimGray
        Label2.Location = New Point(58, 96)
        Label2.Name = "Label2"
        Label2.Size = New Size(106, 28)
        Label2.TabIndex = 27
        Label2.Text = "First Name"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Tomato
        Label1.Location = New Point(509, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(272, 32)
        Label1.TabIndex = 24
        Label1.Text = "Register As A Scholar !"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = Color.DimGray
        Label3.Location = New Point(58, 224)
        Label3.Name = "Label3"
        Label3.Size = New Size(76, 28)
        Label3.TabIndex = 44
        Label3.Text = "Gender"
        ' 
        ' combo_mode
        ' 
        combo_mode.BackColor = SystemColors.Menu
        combo_mode.FormattingEnabled = True
        combo_mode.Items.AddRange(New Object() {"Full-Time", "Part-Time"})
        combo_mode.Location = New Point(971, 393)
        combo_mode.Name = "combo_mode"
        combo_mode.Size = New Size(218, 33)
        combo_mode.TabIndex = 46
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = Color.DimGray
        Label4.Location = New Point(971, 362)
        Label4.Name = "Label4"
        Label4.Size = New Size(140, 28)
        Label4.TabIndex = 47
        Label4.Text = "Mode of study"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.ForeColor = Color.DimGray
        Label9.Location = New Point(526, 351)
        Label9.Name = "Label9"
        Label9.Size = New Size(250, 28)
        Label9.TabIndex = 48
        Label9.Text = "What do you want to study"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label11.ForeColor = Color.DimGray
        Label11.Location = New Point(67, 362)
        Label11.Name = "Label11"
        Label11.Size = New Size(47, 28)
        Label11.TabIndex = 50
        Label11.Text = "Age"
        ' 
        ' txt_age
        ' 
        txt_age.BackColor = SystemColors.Menu
        txt_age.Location = New Point(67, 393)
        txt_age.Name = "txt_age"
        txt_age.Size = New Size(218, 31)
        txt_age.TabIndex = 53
        ' 
        ' combo_course
        ' 
        combo_course.BackColor = SystemColors.Menu
        combo_course.FormattingEnabled = True
        combo_course.Items.AddRange(New Object() {"Introduction to Sports Management", "Sports Nutrition", "Sports Psychology", "Sports Medicine", "Sports Marketing", "Sports Broadcasting and Journalism", "Sports Law and Ethics", "Strength and Conditioning", "Exercise Science", "Coaching Principles and Methods", "Sports Event Management", "Sports Analytics and Data Science", "Sports Sociology", "Sports Business and Finance", "Sports Facility Management", "Sports Broadcasting and Media Production", "Sports and Exercise Physiology", "Sports Injury Prevention and Rehabilitation", "Sports Coaching and Leadership", "Sports Media and Communication", "Sports Psychology"})
        combo_course.Location = New Point(535, 393)
        combo_course.Name = "combo_course"
        combo_course.Size = New Size(218, 33)
        combo_course.TabIndex = 56
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Cursor = Cursors.Hand
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ForeColor = Color.Black
        Label7.Location = New Point(1272, 9)
        Label7.Name = "Label7"
        Label7.Size = New Size(30, 32)
        Label7.TabIndex = 58
        Label7.Text = "X"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Cursor = Cursors.Hand
        Label10.Font = New Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.ForeColor = Color.Black
        Label10.Location = New Point(1225, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(30, 41)
        Label10.TabIndex = 59
        Label10.Text = "-"
        ' 
        ' Scholar_Registration
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1314, 697)
        Controls.Add(Label10)
        Controls.Add(Label7)
        Controls.Add(combo_course)
        Controls.Add(txt_age)
        Controls.Add(Label11)
        Controls.Add(Label9)
        Controls.Add(Label4)
        Controls.Add(combo_mode)
        Controls.Add(Label3)
        Controls.Add(Button_Register)
        Controls.Add(txt_emailaddress)
        Controls.Add(Label8)
        Controls.Add(combo_gender)
        Controls.Add(txt_phonenumber)
        Controls.Add(dob_picker)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(txt_lastname)
        Controls.Add(Label_lastname)
        Controls.Add(txt_firstname)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Scholar_Registration"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button_Register As Button
    Friend WithEvents txt_emailaddress As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents combo_gender As ComboBox
    Friend WithEvents txt_phonenumber As TextBox
    Friend WithEvents dob_picker As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_lastname As TextBox
    Friend WithEvents Label_lastname As Label
    Friend WithEvents txt_firstname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents combo_mode As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_age As TextBox
    Friend WithEvents combo_course As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
End Class
