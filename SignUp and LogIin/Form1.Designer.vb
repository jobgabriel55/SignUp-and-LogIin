<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        Panel1 = New Panel()
        Label7 = New Label()
        Label4 = New Label()
        Button1 = New Button()
        Label2 = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        Label5 = New Label()
        Label6 = New Label()
        BackgroundWorker2 = New ComponentModel.BackgroundWorker()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Tomato
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1205, 635)
        Panel1.TabIndex = 0
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ForeColor = Color.Black
        Label7.Location = New Point(47, 162)
        Label7.Name = "Label7"
        Label7.Size = New Size(105, 25)
        Label7.TabIndex = 6
        Label7.Text = "Homepage"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(26, 490)
        Label4.Name = "Label4"
        Label4.Size = New Size(383, 100)
        Label4.TabIndex = 5
        Label4.Text = "Have any issues?" & vbCrLf & "Contact us: 0795726757" & vbCrLf & "Email: elevatefootballacademy.org@gmail.com" & vbCrLf & vbCrLf
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Tomato
        Button1.BackgroundImageLayout = ImageLayout.None
        Button1.Cursor = Cursors.Hand
        Button1.FlatAppearance.BorderColor = Color.White
        Button1.FlatAppearance.BorderSize = 20
        Button1.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(122, 374)
        Button1.Name = "Button1"
        Button1.Size = New Size(188, 58)
        Button1.TabIndex = 4
        Button1.Text = "SignUp"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(26, 271)
        Label2.Name = "Label2"
        Label2.Size = New Size(491, 25)
        Label2.TabIndex = 2
        Label2.Text = "You can create your account using the sign up button below:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(26, 86)
        Label1.Name = "Label1"
        Label1.Size = New Size(520, 32)
        Label1.TabIndex = 1
        Label1.Text = "WELCOME TO ELEVATE FOOTBALL ACADEMY"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Label6)
        Panel2.Location = New Point(552, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(653, 635)
        Panel2.TabIndex = 0
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Cursor = Cursors.Hand
        Label5.Font = New Font("Segoe UI", 15.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(572, 2)
        Label5.Name = "Label5"
        Label5.Size = New Size(30, 41)
        Label5.TabIndex = 6
        Label5.Text = "-"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Cursor = Cursors.Hand
        Label6.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(618, 9)
        Label6.Name = "Label6"
        Label6.Size = New Size(30, 32)
        Label6.TabIndex = 7
        Label6.Text = "X"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1205, 635)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class

