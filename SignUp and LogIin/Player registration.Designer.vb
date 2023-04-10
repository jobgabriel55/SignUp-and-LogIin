<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class player_registration
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
        combo_foot = New ComboBox()
        Label12 = New Label()
        txt_age = New TextBox()
        txt_height = New TextBox()
        txt_weight = New TextBox()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        Label4 = New Label()
        combo_position = New ComboBox()
        Label3 = New Label()
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
        Button_Register = New Button()
        Label7 = New Label()
        Label13 = New Label()
        SuspendLayout()
        ' 
        ' combo_foot
        ' 
        combo_foot.BackColor = SystemColors.Menu
        combo_foot.FormattingEnabled = True
        combo_foot.Items.AddRange(New Object() {"Left", "Right", "Both"})
        combo_foot.Location = New Point(986, 330)
        combo_foot.Name = "combo_foot"
        combo_foot.Size = New Size(218, 33)
        combo_foot.TabIndex = 81
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label12.ForeColor = Color.DimGray
        Label12.Location = New Point(550, 413)
        Label12.Name = "Label12"
        Label12.Size = New Size(123, 28)
        Label12.TabIndex = 80
        Label12.Text = "Weight in kg"
        ' 
        ' txt_age
        ' 
        txt_age.BackColor = SystemColors.Menu
        txt_age.Location = New Point(986, 230)
        txt_age.Name = "txt_age"
        txt_age.Size = New Size(218, 31)
        txt_age.TabIndex = 79
        ' 
        ' txt_height
        ' 
        txt_height.BackColor = SystemColors.Menu
        txt_height.Location = New Point(73, 455)
        txt_height.Name = "txt_height"
        txt_height.Size = New Size(218, 31)
        txt_height.TabIndex = 78
        ' 
        ' txt_weight
        ' 
        txt_weight.BackColor = SystemColors.Menu
        txt_weight.Location = New Point(550, 455)
        txt_weight.Name = "txt_weight"
        txt_weight.Size = New Size(218, 31)
        txt_weight.TabIndex = 77
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label11.ForeColor = Color.DimGray
        Label11.Location = New Point(986, 188)
        Label11.Name = "Label11"
        Label11.Size = New Size(47, 28)
        Label11.TabIndex = 76
        Label11.Text = "Age"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.ForeColor = Color.DimGray
        Label10.Location = New Point(73, 413)
        Label10.Name = "Label10"
        Label10.Size = New Size(123, 28)
        Label10.TabIndex = 75
        Label10.Text = "Height in cm"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.ForeColor = Color.DimGray
        Label9.Location = New Point(986, 288)
        Label9.Name = "Label9"
        Label9.Size = New Size(210, 28)
        Label9.TabIndex = 74
        Label9.Text = "Which foot do you use"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = Color.DimGray
        Label4.Location = New Point(550, 288)
        Label4.Name = "Label4"
        Label4.Size = New Size(183, 28)
        Label4.TabIndex = 73
        Label4.Text = "Position you play in"
        ' 
        ' combo_position
        ' 
        combo_position.BackColor = SystemColors.Menu
        combo_position.FormattingEnabled = True
        combo_position.Items.AddRange(New Object() {"GoalKeeper", "Defender", "Midfielder", "Striker"})
        combo_position.Location = New Point(550, 330)
        combo_position.Name = "combo_position"
        combo_position.Size = New Size(218, 33)
        combo_position.TabIndex = 72
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = Color.DimGray
        Label3.Location = New Point(73, 188)
        Label3.Name = "Label3"
        Label3.Size = New Size(76, 28)
        Label3.TabIndex = 70
        Label3.Text = "Gender"
        ' 
        ' txt_emailaddress
        ' 
        txt_emailaddress.BackColor = SystemColors.Menu
        txt_emailaddress.Location = New Point(73, 332)
        txt_emailaddress.Name = "txt_emailaddress"
        txt_emailaddress.Size = New Size(218, 31)
        txt_emailaddress.TabIndex = 69
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.ForeColor = Color.DimGray
        Label8.Location = New Point(64, 288)
        Label8.Name = "Label8"
        Label8.Size = New Size(134, 28)
        Label8.TabIndex = 68
        Label8.Text = "Email Address"
        ' 
        ' combo_gender
        ' 
        combo_gender.BackColor = SystemColors.Menu
        combo_gender.FormattingEnabled = True
        combo_gender.Items.AddRange(New Object() {"Male", "Female"})
        combo_gender.Location = New Point(73, 219)
        combo_gender.Name = "combo_gender"
        combo_gender.Size = New Size(218, 33)
        combo_gender.TabIndex = 67
        ' 
        ' txt_phonenumber
        ' 
        txt_phonenumber.BackColor = SystemColors.Menu
        txt_phonenumber.Location = New Point(986, 126)
        txt_phonenumber.Name = "txt_phonenumber"
        txt_phonenumber.Size = New Size(218, 31)
        txt_phonenumber.TabIndex = 65
        ' 
        ' dob_picker
        ' 
        dob_picker.CalendarFont = New Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point)
        dob_picker.CalendarForeColor = Color.DimGray
        dob_picker.CalendarMonthBackground = SystemColors.Menu
        dob_picker.CalendarTrailingForeColor = SystemColors.Menu
        dob_picker.Location = New Point(550, 221)
        dob_picker.Name = "dob_picker"
        dob_picker.Size = New Size(218, 31)
        dob_picker.TabIndex = 64
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.ForeColor = Color.DimGray
        Label6.Location = New Point(986, 95)
        Label6.Name = "Label6"
        Label6.Size = New Size(144, 28)
        Label6.TabIndex = 63
        Label6.Text = "Phone Number"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = Color.DimGray
        Label5.Location = New Point(550, 188)
        Label5.Name = "Label5"
        Label5.Size = New Size(122, 28)
        Label5.TabIndex = 62
        Label5.Text = "Date of Birth"
        ' 
        ' txt_lastname
        ' 
        txt_lastname.BackColor = SystemColors.Menu
        txt_lastname.Location = New Point(550, 126)
        txt_lastname.Name = "txt_lastname"
        txt_lastname.Size = New Size(218, 31)
        txt_lastname.TabIndex = 61
        ' 
        ' Label_lastname
        ' 
        Label_lastname.AutoSize = True
        Label_lastname.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label_lastname.ForeColor = Color.DimGray
        Label_lastname.Location = New Point(550, 95)
        Label_lastname.Name = "Label_lastname"
        Label_lastname.Size = New Size(103, 28)
        Label_lastname.TabIndex = 60
        Label_lastname.Text = "Last Name"
        ' 
        ' txt_firstname
        ' 
        txt_firstname.BackColor = SystemColors.Menu
        txt_firstname.Location = New Point(73, 126)
        txt_firstname.Name = "txt_firstname"
        txt_firstname.Size = New Size(218, 31)
        txt_firstname.TabIndex = 59
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.DimGray
        Label2.Location = New Point(73, 95)
        Label2.Name = "Label2"
        Label2.Size = New Size(106, 28)
        Label2.TabIndex = 58
        Label2.Text = "First Name"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Tomato
        Label1.Location = New Point(524, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(343, 32)
        Label1.TabIndex = 57
        Label1.Text = "Register As Our New Player !"
        ' 
        ' Button_Register
        ' 
        Button_Register.BackColor = Color.Tomato
        Button_Register.Location = New Point(475, 566)
        Button_Register.Name = "Button_Register"
        Button_Register.Size = New Size(351, 58)
        Button_Register.TabIndex = 82
        Button_Register.Text = "Register"
        Button_Register.UseVisualStyleBackColor = False
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
        Label7.TabIndex = 83
        Label7.Text = "X"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Cursor = Cursors.Hand
        Label13.Font = New Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point)
        Label13.ForeColor = Color.Black
        Label13.Location = New Point(1224, 2)
        Label13.Name = "Label13"
        Label13.Size = New Size(30, 41)
        Label13.TabIndex = 84
        Label13.Text = "-"
        ' 
        ' player_registration
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1314, 697)
        Controls.Add(Label13)
        Controls.Add(Label7)
        Controls.Add(Button_Register)
        Controls.Add(combo_foot)
        Controls.Add(Label12)
        Controls.Add(txt_age)
        Controls.Add(txt_height)
        Controls.Add(txt_weight)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label4)
        Controls.Add(combo_position)
        Controls.Add(Label3)
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
        Name = "player_registration"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents combo_foot As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txt_age As TextBox
    Friend WithEvents txt_height As TextBox
    Friend WithEvents txt_weight As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents combo_position As ComboBox
    Friend WithEvents Label3 As Label
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
    Friend WithEvents Button_Register As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label13 As Label
End Class
