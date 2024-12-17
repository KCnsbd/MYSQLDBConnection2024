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
        InFN = New TextBox()
        InLN = New TextBox()
        InUN = New TextBox()
        InPW = New TextBox()
        SignUp_button = New Button()
        Update = New Button()
        InSN = New TextBox()
        Label5 = New Label()
        Delete = New Button()
        ComboBox1 = New ComboBox()
        ListBox1 = New ListBox()
        DataGridView1 = New DataGridView()
        LoadData = New Button()
        Search = New TextBox()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        DateTimePicker1 = New DateTimePicker()
        Label1 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' InFN
        ' 
        InFN.BackColor = Color.FromArgb(CByte(254), CByte(220), CByte(219))
        InFN.Cursor = Cursors.IBeam
        InFN.Font = New Font("Franklin Gothic Book", 10F)
        InFN.ForeColor = Color.FromArgb(CByte(254), CByte(102), CByte(148))
        InFN.Location = New Point(17, 134)
        InFN.Margin = New Padding(2)
        InFN.Name = "InFN"
        InFN.PlaceholderText = "First Name"
        InFN.Size = New Size(292, 30)
        InFN.TabIndex = 4
        InFN.TextAlign = HorizontalAlignment.Center
        ' 
        ' InLN
        ' 
        InLN.BackColor = Color.FromArgb(CByte(254), CByte(220), CByte(219))
        InLN.Cursor = Cursors.IBeam
        InLN.Font = New Font("Franklin Gothic Book", 10F)
        InLN.ForeColor = Color.FromArgb(CByte(254), CByte(102), CByte(148))
        InLN.Location = New Point(16, 178)
        InLN.Margin = New Padding(2)
        InLN.Name = "InLN"
        InLN.PlaceholderText = "Last Name"
        InLN.Size = New Size(292, 30)
        InLN.TabIndex = 5
        InLN.TextAlign = HorizontalAlignment.Center
        ' 
        ' InUN
        ' 
        InUN.BackColor = Color.FromArgb(CByte(254), CByte(220), CByte(219))
        InUN.Cursor = Cursors.IBeam
        InUN.Font = New Font("Franklin Gothic Book", 10F)
        InUN.ForeColor = Color.FromArgb(CByte(254), CByte(102), CByte(148))
        InUN.Location = New Point(16, 219)
        InUN.Margin = New Padding(2)
        InUN.Name = "InUN"
        InUN.PlaceholderText = "Username"
        InUN.Size = New Size(292, 30)
        InUN.TabIndex = 6
        InUN.TextAlign = HorizontalAlignment.Center
        ' 
        ' InPW
        ' 
        InPW.BackColor = Color.FromArgb(CByte(254), CByte(220), CByte(219))
        InPW.Cursor = Cursors.IBeam
        InPW.Font = New Font("Franklin Gothic Book", 10F)
        InPW.ForeColor = Color.FromArgb(CByte(254), CByte(102), CByte(148))
        InPW.Location = New Point(16, 259)
        InPW.Margin = New Padding(2)
        InPW.Name = "InPW"
        InPW.PlaceholderText = "Password"
        InPW.Size = New Size(292, 30)
        InPW.TabIndex = 7
        InPW.TextAlign = HorizontalAlignment.Center
        ' 
        ' SignUp_button
        ' 
        SignUp_button.BackColor = Color.White
        SignUp_button.FlatAppearance.MouseDownBackColor = Color.LavenderBlush
        SignUp_button.FlatAppearance.MouseOverBackColor = Color.DeepPink
        SignUp_button.Font = New Font("Franklin Gothic Demi Cond", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        SignUp_button.ForeColor = Color.FromArgb(CByte(254), CByte(102), CByte(148))
        SignUp_button.Location = New Point(16, 387)
        SignUp_button.Margin = New Padding(2)
        SignUp_button.Name = "SignUp_button"
        SignUp_button.Size = New Size(290, 48)
        SignUp_button.TabIndex = 8
        SignUp_button.Text = "SIGN UP"
        SignUp_button.UseVisualStyleBackColor = False
        ' 
        ' Update
        ' 
        Update.BackColor = Color.White
        Update.FlatAppearance.MouseDownBackColor = Color.LavenderBlush
        Update.FlatAppearance.MouseOverBackColor = Color.DeepPink
        Update.Font = New Font("Franklin Gothic Demi Cond", 10F)
        Update.ForeColor = Color.FromArgb(CByte(254), CByte(102), CByte(148))
        Update.Location = New Point(162, 440)
        Update.Margin = New Padding(2)
        Update.Name = "Update"
        Update.Size = New Size(144, 48)
        Update.TabIndex = 9
        Update.Text = "UPDATE"
        Update.UseVisualStyleBackColor = False
        ' 
        ' InSN
        ' 
        InSN.BackColor = Color.FromArgb(CByte(254), CByte(220), CByte(219))
        InSN.Cursor = Cursors.IBeam
        InSN.Font = New Font("Franklin Gothic Book", 10F)
        InSN.ForeColor = Color.FromArgb(CByte(254), CByte(102), CByte(148))
        InSN.Location = New Point(17, 87)
        InSN.Margin = New Padding(2)
        InSN.Name = "InSN"
        InSN.PlaceholderText = "Student Number"
        InSN.Size = New Size(292, 30)
        InSN.TabIndex = 11
        InSN.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Leelawadee", 12F)
        Label5.Location = New Point(16, 17)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(0, 29)
        Label5.TabIndex = 10
        ' 
        ' Delete
        ' 
        Delete.BackColor = Color.White
        Delete.Font = New Font("Franklin Gothic Demi Cond", 10F)
        Delete.ForeColor = Color.FromArgb(CByte(254), CByte(102), CByte(148))
        Delete.Location = New Point(16, 440)
        Delete.Margin = New Padding(2)
        Delete.Name = "Delete"
        Delete.Size = New Size(144, 48)
        Delete.TabIndex = 12
        Delete.Text = "DELETE"
        Delete.UseVisualStyleBackColor = False
        ' 
        ' ComboBox1
        ' 
        ComboBox1.BackColor = Color.FromArgb(CByte(254), CByte(220), CByte(219))
        ComboBox1.ForeColor = Color.FromArgb(CByte(254), CByte(102), CByte(148))
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(20, 38)
        ComboBox1.Margin = New Padding(2)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(292, 33)
        ComboBox1.TabIndex = 13
        ' 
        ' ListBox1
        ' 
        ListBox1.BackColor = Color.FromArgb(CByte(254), CByte(220), CByte(219))
        ListBox1.BorderStyle = BorderStyle.None
        ListBox1.Font = New Font("Franklin Gothic Book", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 25
        ListBox1.Location = New Point(374, 41)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(349, 25)
        ListBox1.TabIndex = 14
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(374, 110)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(360, 265)
        DataGridView1.TabIndex = 15
        ' 
        ' LoadData
        ' 
        LoadData.BackColor = Color.White
        LoadData.Location = New Point(374, 387)
        LoadData.Name = "LoadData"
        LoadData.Size = New Size(118, 34)
        LoadData.TabIndex = 16
        LoadData.Text = "Load Data"
        LoadData.UseVisualStyleBackColor = False
        ' 
        ' Search
        ' 
        Search.BackColor = Color.FromArgb(CByte(254), CByte(220), CByte(219))
        Search.Location = New Point(498, 389)
        Search.Name = "Search"
        Search.PlaceholderText = "Search"
        Search.Size = New Size(236, 30)
        Search.TabIndex = 17
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.ForeColor = Color.MediumVioletRed
        RadioButton1.Location = New Point(21, 293)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(73, 29)
        RadioButton1.TabIndex = 18
        RadioButton1.TabStop = True
        RadioButton1.Text = "Male"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.ForeColor = Color.MediumVioletRed
        RadioButton2.Location = New Point(162, 293)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(91, 29)
        RadioButton2.TabIndex = 19
        RadioButton2.TabStop = True
        RadioButton2.Text = "Female"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(16, 349)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(290, 30)
        DateTimePicker1.TabIndex = 20
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.MediumVioletRed
        Label1.Location = New Point(21, 325)
        Label1.Name = "Label1"
        Label1.Size = New Size(102, 25)
        Label1.TabIndex = 21
        Label1.Text = "Date of Birth"
        ' 
        ' SignUp_Form
        ' 
        AutoScaleDimensions = New SizeF(9F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(254), CByte(177), CByte(183))
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(752, 501)
        Controls.Add(Label1)
        Controls.Add(DateTimePicker1)
        Controls.Add(RadioButton2)
        Controls.Add(RadioButton1)
        Controls.Add(Search)
        Controls.Add(LoadData)
        Controls.Add(DataGridView1)
        Controls.Add(ListBox1)
        Controls.Add(ComboBox1)
        Controls.Add(Delete)
        Controls.Add(InSN)
        Controls.Add(Label5)
        Controls.Add(Update)
        Controls.Add(SignUp_button)
        Controls.Add(InPW)
        Controls.Add(InUN)
        Controls.Add(InLN)
        Controls.Add(InFN)
        Font = New Font("Franklin Gothic Medium Cond", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ForeColor = Color.FromArgb(CByte(254), CByte(102), CByte(148))
        Margin = New Padding(2)
        Name = "SignUp_Form"
        Text = "Sign Up"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents InFN As TextBox
    Friend WithEvents InLN As TextBox
    Friend WithEvents InUN As TextBox
    Friend WithEvents InPW As TextBox
    Friend WithEvents SignUp_button As Button
    Friend WithEvents Update As Button
    Friend WithEvents InSN As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Delete As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents LoadData As Button
    Friend WithEvents Search As TextBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label1 As Label
End Class
