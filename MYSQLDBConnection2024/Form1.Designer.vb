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
        Button1 = New Button()
        Username = New Label()
        input_username = New TextBox()
        input_password = New TextBox()
        Login = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Black
        Button1.FlatAppearance.BorderColor = Color.White
        Button1.FlatAppearance.MouseDownBackColor = Color.DeepPink
        Button1.Font = New Font("Leelawadee", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(52, 43)
        Button1.Margin = New Padding(2, 4, 2, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(250, 43)
        Button1.TabIndex = 0
        Button1.Text = "Check Connection"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Username
        ' 
        Username.AutoSize = True
        Username.BackColor = Color.Transparent
        Username.Font = New Font("Leelawadee", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Username.ForeColor = Color.LavenderBlush
        Username.Location = New Point(298, 140)
        Username.Margin = New Padding(2, 0, 2, 0)
        Username.Name = "Username"
        Username.Size = New Size(120, 29)
        Username.TabIndex = 1
        Username.Text = "Username"
        ' 
        ' input_username
        ' 
        input_username.BackColor = Color.DeepPink
        input_username.Font = New Font("Leelawadee", 12F)
        input_username.ForeColor = Color.LavenderBlush
        input_username.Location = New Point(96, 173)
        input_username.Margin = New Padding(3, 4, 3, 4)
        input_username.Name = "input_username"
        input_username.Size = New Size(538, 36)
        input_username.TabIndex = 3
        input_username.TextAlign = HorizontalAlignment.Center
        ' 
        ' input_password
        ' 
        input_password.BackColor = Color.DeepPink
        input_password.Font = New Font("Leelawadee", 12F)
        input_password.ForeColor = Color.LavenderBlush
        input_password.Location = New Point(96, 269)
        input_password.Margin = New Padding(3, 4, 3, 4)
        input_password.Name = "input_password"
        input_password.PasswordChar = "*"c
        input_password.Size = New Size(538, 36)
        input_password.TabIndex = 4
        input_password.TextAlign = HorizontalAlignment.Center
        ' 
        ' Login
        ' 
        Login.BackColor = Color.Black
        Login.FlatAppearance.MouseDownBackColor = Color.LavenderBlush
        Login.FlatAppearance.MouseOverBackColor = Color.DeepPink
        Login.Location = New Point(96, 348)
        Login.Margin = New Padding(3, 4, 3, 4)
        Login.Name = "Login"
        Login.Size = New Size(538, 43)
        Login.TabIndex = 5
        Login.Text = "Login"
        Login.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Leelawadee", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.LavenderBlush
        Label1.Location = New Point(303, 236)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(111, 29)
        Label1.TabIndex = 7
        Label1.Text = "Password"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(14F, 29F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        BackgroundImage = My.Resources.Resources._96a9b5557cc0d96dbfc21808ce9fea5a
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(745, 522)
        Controls.Add(Label1)
        Controls.Add(Login)
        Controls.Add(input_password)
        Controls.Add(input_username)
        Controls.Add(Username)
        Controls.Add(Button1)
        Font = New Font("Leelawadee", 11.999999F, FontStyle.Bold)
        ForeColor = Color.LavenderBlush
        Margin = New Padding(4)
        Name = "Form1"
        Text = "MYSQL DATABASE CONNECTION"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Username As Label
    Friend WithEvents input_username As TextBox
    Friend WithEvents input_password As TextBox
    Friend WithEvents Login As Button
    Friend WithEvents Label1 As Label

End Class
