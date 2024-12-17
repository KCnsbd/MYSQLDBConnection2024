Imports System.Diagnostics.Eventing
Imports MySql.Data.MySqlClient

Public Class SignUp_Form
    Dim conn As MySqlConnection
    Dim command As MySqlCommand
    Private Sub SignUp_button_Click(sender As Object, e As EventArgs) Handles SignUp_button.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1; port= 3306; userid=root;password='';database=test"
        Dim reader As MySqlDataReader

        Try
            conn.Open()
            Dim query As String
            query = "INSERT INTO test.data (student_number, first_name, last_name, username, password) VALUES ( '" & InSN.Text & "' , '" & InFN.Text & "' , '" & InLN.Text & "', '" & InUN.Text & "', '" & InPW.Text & "')"
            command = New MySqlCommand(query, conn)
            reader = command.ExecuteReader

            MessageBox.Show("Sign up complete!!")
            Form1.Show()
            Hide()

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub Update_Click(sender As Object, e As EventArgs) Handles Update.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1; port= 3306; userid=root;password='';database=test"
        Dim reader As MySqlDataReader

        Try
            conn.Open()

            ' Define the SQL query with parameters
            Dim query As String = "UPDATE test.data SET username = @username, password = @password WHERE student_number = @student_number"

            ' Create the MySqlCommand object with the query and connection
            command = New MySqlCommand(query, conn)

            ' Add parameters to the command
            command.Parameters.AddWithValue("@username", InUN.Text)
            command.Parameters.AddWithValue("@password", InPW.Text)
            command.Parameters.AddWithValue("@student_number", InSN.Text)

            ' Execute the query
            command.ExecuteNonQuery()

            ' Inform the user that the data was saved
            MessageBox.Show("Data Saved!!")

            ' Show Form1 and hide the current form
            Form1.Show()
            Hide()

            ' Close the connection
            conn.Close()

        Catch ex As Exception
            ' Display error message if something goes wrong
            MsgBox(ex.Message)
            conn.Close()
        End Try

    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1; port= 3306; userid=root;password='';database=test"
        Dim reader As MySqlDataReader

        Try
            conn.Open()
            Dim query As String
            query = "DELETE FROM test.data WHERE student_number = " & InSN.Text & ""
            command = New MySqlCommand(query, conn)
            reader = command.ExecuteReader

            MessageBox.Show("Data Deleted")
            Form1.Show()
            Hide()

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub SignUp_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1; port= 3306; userid=root;password='';database=test"
        Dim reader As MySqlDataReader

        Try
            conn.Open()
            Dim query As String
            query = "SELECT * FROM test.data"
            command = New MySqlCommand(query, conn)
            reader = command.ExecuteReader
            While reader.Read
                Dim sName = reader.GetString("last_name")
                ComboBox1.Items.Add(sName)
                ListBox1.Items.Add(sName)
            End While

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1; port= 3306; userid=root;password='';database=test"
        Dim reader As MySqlDataReader

        Try
            conn.Open()
            Dim query As String
            query = "SELECT * FROM test.data WHERE last_name = '" & ComboBox1.Text & "'"
            command = New MySqlCommand(query, conn)
            reader = command.ExecuteReader
            While reader.Read
                Dim sName = reader.GetString("last_name")
                ComboBox1.Items.Add(sName)
            End While
            InSN.Text = reader.GetInt32("student_number")
            InLN.Text = reader.GetString("last_name")
            InFN.Text = reader.GetString("first_name")
            InUN.Text = reader.GetString("username")
            InPW.Text = reader.GetString("password")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1; port= 3306; userid=root;password='';database=test"
        Dim reader As MySqlDataReader

        Try
            conn.Open()
            Dim query As String
            query = "SELECT * FROM test.data WHERE last_name = '" & ListBox1.Text & "'"
            command = New MySqlCommand(query, conn)
            reader = command.ExecuteReader
            While reader.Read
                Dim sName = reader.GetString("last_name")
                ComboBox1.Items.Add(sName)
            End While
            InSN.Text = reader.GetInt32("student_number")
            InLN.Text = reader.GetString("last_name")
            InFN.Text = reader.GetString("first_name")
            InUN.Text = reader.GetString("username")
            InPW.Text = reader.GetString("password")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub LoadData_Click(sender As Object, e As EventArgs) Handles LoadData.Click
        Dim conn As New MySqlConnection("server=127.0.0.1; port= 3306; userid=root;password='';database=test")
        Dim SDA As New MySqlDataAdapter()
        Dim dbDataSet As New DataTable()
        Dim bSource As New BindingSource()

        Try
            conn.Open()
            Dim query As String = "SELECT student_number as 'Student No.', first_name as 'Name', last_name as 'Surname', username, password FROM test.data"
            Dim command As New MySqlCommand(query, conn)

            SDA.SelectCommand = command
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            DataGridView1.DataSource = bSource

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.DataGridView1.Rows(e.RowIndex)
            InSN.Text = row.Cells("student_number").Value.ToString
            InLN.Text = row.Cells("last_name").Value.ToString
            InFN.Text = row.Cells("first_name").Value.ToString
            InUN.Text = row.Cells("username").Value.ToString
            InPW.Text = row.Cells("password").Value.ToString
        End If
    End Sub

    Private Sub Search_TextChanged(sender As Object, e As EventArgs) Handles Search.TextChanged
        Dim connectionString As String = "server=127.0.0.1; port= 3306; userid=root;password='';database=test"
        Dim connection As New MySqlConnection(connectionString)

        Dim query As String = "SELECT student_number, first_name, last_name, username, password FROM data"
        Dim adapter As New MySqlDataAdapter(query, connection)

        Dim dataTable As New DataTable()

        adapter.Fill(dataTable)

        Dim DV As New DataView(dataTable)

        If String.IsNullOrEmpty(Search.Text) Then
            DV.RowFilter = String.Empty
        Else
            DV.RowFilter = String.Format("first_name LIKE '%{0}%'", Search.Text)
        End If

        DataGridView1.DataSource = DV
    End Sub

    Private Sub SignUp_Form_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim dialogue As DialogResult
        dialogue = MessageBox.Show("Do you really want to close the app?", "Exit", MessageBoxButtons.YesNo)
        If dialogue = DialogResult.No Then
            e.Cancel = True

        Else
            Application.ExitThread()
        End If
    End Sub
End Class