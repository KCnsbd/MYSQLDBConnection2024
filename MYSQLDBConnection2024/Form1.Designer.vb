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
        input_password = New TextBox()
        Login = New Button()
        input_username = New TextBox()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(254), CByte(220), CByte(219))
        Button1.FlatAppearance.BorderColor = Color.White
        Button1.FlatAppearance.MouseDownBackColor = Color.DeepPink
        Button1.Font = New Font("Franklin Gothic Demi Cond", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.FromArgb(CByte(254), CByte(102), CByte(148))
        Button1.Location = New Point(23, 26)
        Button1.Margin = New Padding(1, 3, 1, 3)
        Button1.Name = "Button1"
        Button1.Size = New Size(216, 37)
        Button1.TabIndex = 0
        Button1.Text = "Check Connection"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' input_password
        ' 
        input_password.BackColor = Color.FromArgb(CByte(254), CByte(220), CByte(219))
        input_password.Font = New Font("Franklin Gothic Book", 10F)
        input_password.ForeColor = Color.DarkMagenta
        input_password.Location = New Point(62, 232)
        input_password.Margin = New Padding(2, 3, 2, 3)
        input_password.Name = "input_password"
        input_password.PasswordChar = "*"c
        input_password.PlaceholderText = "Password"
        input_password.Size = New Size(347, 30)
        input_password.TabIndex = 4
        input_password.TextAlign = HorizontalAlignment.Center
        ' 
        ' Login
        ' 
        Login.BackColor = Color.FromArgb(CByte(254), CByte(220), CByte(219))
        Login.FlatAppearance.MouseDownBackColor = Color.LavenderBlush
        Login.FlatAppearance.MouseOverBackColor = Color.DeepPink
        Login.Font = New Font("Franklin Gothic Demi Cond", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Login.Location = New Point(62, 300)
        Login.Margin = New Padding(2, 3, 2, 3)
        Login.Name = "Login"
        Login.Size = New Size(346, 37)
        Login.TabIndex = 5
        Login.Text = "LOGIN"
        Login.UseVisualStyleBackColor = False
        ' 
        ' input_username
        ' 
        input_username.BackColor = Color.FromArgb(CByte(254), CByte(220), CByte(219))
        input_username.Font = New Font("Franklin Gothic Book", 10F)
        input_username.ForeColor = Color.DarkMagenta
        input_username.Location = New Point(62, 149)
        input_username.Margin = New Padding(2, 3, 2, 3)
        input_username.Name = "input_username"
        input_username.PlaceholderText = "Username"
        input_username.Size = New Size(347, 30)
        input_username.TabIndex = 3
        input_username.TextAlign = HorizontalAlignment.Center
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(9F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(254), CByte(177), CByte(183))
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(479, 450)
        Controls.Add(Login)
        Controls.Add(input_password)
        Controls.Add(input_username)
        Controls.Add(Button1)
        Font = New Font("Franklin Gothic Medium Cond", 10F)
        ForeColor = Color.FromArgb(CByte(254), CByte(102), CByte(148))
        Name = "Form1"
        Text = "MYSQL DATABASE CONNECTION"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents input_password As TextBox
    Friend WithEvents Login As Button
    Friend WithEvents input_username As TextBox

End Class
