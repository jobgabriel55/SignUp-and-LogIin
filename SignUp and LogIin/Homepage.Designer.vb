<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Homepage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Homepage))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Button_Register = New Button()
        Button1 = New Button()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Tomato
        Label1.Font = New Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(260, -1)
        Label1.Name = "Label1"
        Label1.Size = New Size(601, 54)
        Label1.TabIndex = 2
        Label1.Text = " ELEVATE FOOTBALL ACADEMY"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(12, 80)
        Label2.Name = "Label2"
        Label2.Size = New Size(1216, 175)
        Label2.TabIndex = 3
        Label2.Text = resources.GetString("Label2.Text")
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.Tomato
        Label3.Location = New Point(454, 307)
        Label3.Name = "Label3"
        Label3.Size = New Size(218, 32)
        Label3.TabIndex = 25
        Label3.Text = "Register With Us !"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(383, 371)
        Label4.Name = "Label4"
        Label4.Size = New Size(342, 25)
        Label4.TabIndex = 26
        Label4.Text = "Choose your choice of registration below:"
        ' 
        ' Button_Register
        ' 
        Button_Register.BackColor = Color.Tomato
        Button_Register.Location = New Point(202, 448)
        Button_Register.Name = "Button_Register"
        Button_Register.Size = New Size(351, 58)
        Button_Register.TabIndex = 31
        Button_Register.Text = "Register as a scholar"
        Button_Register.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Tomato
        Button1.Location = New Point(673, 448)
        Button1.Name = "Button1"
        Button1.Size = New Size(351, 58)
        Button1.TabIndex = 32
        Button1.Text = "Register as a player"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Cursor = Cursors.Hand
        Label5.Font = New Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(1144, -1)
        Label5.Name = "Label5"
        Label5.Size = New Size(30, 41)
        Label5.TabIndex = 33
        Label5.Text = "-"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Cursor = Cursors.Hand
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(1198, 6)
        Label6.Name = "Label6"
        Label6.Size = New Size(30, 32)
        Label6.TabIndex = 34
        Label6.Text = "X"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.ForeColor = Color.Black
        Label7.Location = New Point(454, 539)
        Label7.Name = "Label7"
        Label7.Size = New Size(238, 25)
        Label7.TabIndex = 35
        Label7.Text = "Have any issues? Contact us:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.ForeColor = Color.Black
        Label8.Location = New Point(419, 590)
        Label8.Name = "Label8"
        Label8.Size = New Size(383, 100)
        Label8.TabIndex = 36
        Label8.Text = "Have any issues?" & vbCrLf & "Contact us: 0795726757" & vbCrLf & "Email: elevatefootballacademy.org@gmail.com" & vbCrLf & vbCrLf
        ' 
        ' Homepage
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1264, 734)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Button1)
        Controls.Add(Button_Register)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Homepage"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button_Register As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
