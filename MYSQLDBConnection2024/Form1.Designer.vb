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
        Password = New Label()
        input_username = New TextBox()
        input_password = New TextBox()
        Login = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Leelawadee", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(52, 44)
        Button1.Margin = New Padding(2, 3, 2, 3)
        Button1.Name = "Button1"
        Button1.Size = New Size(250, 43)
        Button1.TabIndex = 0
        Button1.Text = "Check Connection"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Username
        ' 
        Username.AutoSize = True
        Username.Location = New Point(146, 193)
        Username.Margin = New Padding(2, 0, 2, 0)
        Username.Name = "Username"
        Username.Size = New Size(127, 29)
        Username.TabIndex = 1
        Username.Text = "Username"
        ' 
        ' Password
        ' 
        Password.AutoSize = True
        Password.Location = New Point(151, 256)
        Password.Name = "Password"
        Password.Size = New Size(122, 29)
        Password.TabIndex = 2
        Password.Text = "Password"
        ' 
        ' input_username
        ' 
        input_username.Location = New Point(306, 190)
        input_username.Name = "input_username"
        input_username.Size = New Size(243, 36)
        input_username.TabIndex = 3
        ' 
        ' input_password
        ' 
        input_password.Location = New Point(306, 253)
        input_password.Name = "input_password"
        input_password.PasswordChar = "*"c
        input_password.Size = New Size(243, 36)
        input_password.TabIndex = 4
        ' 
        ' Login
        ' 
        Login.Location = New Point(306, 343)
        Login.Name = "Login"
        Login.Size = New Size(128, 44)
        Login.TabIndex = 5
        Login.Text = "Login"
        Login.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(14F, 29F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(743, 522)
        Controls.Add(Login)
        Controls.Add(input_password)
        Controls.Add(input_username)
        Controls.Add(Password)
        Controls.Add(Username)
        Controls.Add(Button1)
        Font = New Font("Leelawadee", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4, 3, 4, 3)
        Name = "Form1"
        Text = "MYSQL DATABASE CONNECTION"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Username As Label
    Friend WithEvents Password As Label
    Friend WithEvents input_username As TextBox
    Friend WithEvents input_password As TextBox
    Friend WithEvents Login As Button

End Class
