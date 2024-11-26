<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignUp_Form
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        InFN = New TextBox()
        InLN = New TextBox()
        InUN = New TextBox()
        InPW = New TextBox()
        SignUp_button = New Button()
        Update = New Button()
        InSN = New TextBox()
        Label5 = New Label()
        Delete = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Leelawadee", 12F)
        Label1.Location = New Point(722, 47)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(128, 29)
        Label1.TabIndex = 0
        Label1.Text = "First Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Leelawadee", 12F)
        Label2.Location = New Point(237, 149)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(125, 29)
        Label2.TabIndex = 1
        Label2.Text = "Last Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Leelawadee", 12F)
        Label3.Location = New Point(732, 149)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(120, 29)
        Label3.TabIndex = 2
        Label3.Text = "Username"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Leelawadee", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(237, 252)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(111, 29)
        Label4.TabIndex = 3
        Label4.Text = "Password"
        ' 
        ' InFN
        ' 
        InFN.BackColor = Color.DeepPink
        InFN.Font = New Font("Leelawadee", 12F)
        InFN.ForeColor = Color.LavenderBlush
        InFN.Location = New Point(560, 85)
        InFN.Margin = New Padding(4, 3, 4, 3)
        InFN.Name = "InFN"
        InFN.Size = New Size(452, 36)
        InFN.TabIndex = 4
        InFN.TextAlign = HorizontalAlignment.Center
        ' 
        ' InLN
        ' 
        InLN.BackColor = Color.DeepPink
        InLN.Font = New Font("Leelawadee", 12F)
        InLN.ForeColor = Color.LavenderBlush
        InLN.Location = New Point(73, 181)
        InLN.Margin = New Padding(4, 3, 4, 3)
        InLN.Name = "InLN"
        InLN.Size = New Size(452, 36)
        InLN.TabIndex = 5
        InLN.TextAlign = HorizontalAlignment.Center
        ' 
        ' InUN
        ' 
        InUN.BackColor = Color.DeepPink
        InUN.Font = New Font("Leelawadee", 12F)
        InUN.ForeColor = Color.LavenderBlush
        InUN.Location = New Point(560, 181)
        InUN.Margin = New Padding(4, 3, 4, 3)
        InUN.Name = "InUN"
        InUN.Size = New Size(452, 36)
        InUN.TabIndex = 6
        InUN.TextAlign = HorizontalAlignment.Center
        ' 
        ' InPW
        ' 
        InPW.BackColor = Color.DeepPink
        InPW.Font = New Font("Leelawadee", 12F)
        InPW.ForeColor = Color.LavenderBlush
        InPW.Location = New Point(73, 284)
        InPW.Margin = New Padding(4, 3, 4, 3)
        InPW.Name = "InPW"
        InPW.Size = New Size(452, 36)
        InPW.TabIndex = 7
        InPW.TextAlign = HorizontalAlignment.Center
        ' 
        ' SignUp_button
        ' 
        SignUp_button.BackColor = Color.Black
        SignUp_button.FlatAppearance.MouseDownBackColor = Color.LavenderBlush
        SignUp_button.FlatAppearance.MouseOverBackColor = Color.DeepPink
        SignUp_button.Location = New Point(560, 273)
        SignUp_button.Margin = New Padding(4, 3, 4, 3)
        SignUp_button.Name = "SignUp_button"
        SignUp_button.Size = New Size(452, 56)
        SignUp_button.TabIndex = 8
        SignUp_button.Text = "Sign Up"
        SignUp_button.UseVisualStyleBackColor = False
        ' 
        ' Update
        ' 
        Update.BackColor = Color.Black
        Update.FlatAppearance.MouseDownBackColor = Color.LavenderBlush
        Update.FlatAppearance.MouseOverBackColor = Color.DeepPink
        Update.Location = New Point(788, 335)
        Update.Margin = New Padding(4, 3, 4, 3)
        Update.Name = "Update"
        Update.Size = New Size(224, 56)
        Update.TabIndex = 9
        Update.Text = "Update"
        Update.UseVisualStyleBackColor = False
        ' 
        ' InSN
        ' 
        InSN.BackColor = Color.DeepPink
        InSN.Font = New Font("Leelawadee", 12F)
        InSN.ForeColor = Color.LavenderBlush
        InSN.Location = New Point(73, 85)
        InSN.Margin = New Padding(4, 3, 4, 3)
        InSN.Name = "InSN"
        InSN.Size = New Size(452, 36)
        InSN.TabIndex = 11
        InSN.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Leelawadee", 12F)
        Label5.Location = New Point(210, 47)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(192, 29)
        Label5.TabIndex = 10
        Label5.Text = "Student Number"
        ' 
        ' Delete
        ' 
        Delete.BackColor = Color.Black
        Delete.Location = New Point(560, 335)
        Delete.Name = "Delete"
        Delete.Size = New Size(224, 56)
        Delete.TabIndex = 12
        Delete.Text = "Delete"
        Delete.UseVisualStyleBackColor = False
        ' 
        ' SignUp_Form
        ' 
        AutoScaleDimensions = New SizeF(14F, 29F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.ba59a6370d49904fef48e11e39010261
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1120, 522)
        Controls.Add(Delete)
        Controls.Add(InSN)
        Controls.Add(Label5)
        Controls.Add(Update)
        Controls.Add(SignUp_button)
        Controls.Add(InPW)
        Controls.Add(InUN)
        Controls.Add(InLN)
        Controls.Add(InFN)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Leelawadee", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ForeColor = Color.LavenderBlush
        Margin = New Padding(4, 3, 4, 3)
        Name = "SignUp_Form"
        Text = "Sign Up"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents InFN As TextBox
    Friend WithEvents InLN As TextBox
    Friend WithEvents InUN As TextBox
    Friend WithEvents InPW As TextBox
    Friend WithEvents SignUp_button As Button
    Friend WithEvents Update As Button
    Friend WithEvents InSN As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Delete As Button
End Class
