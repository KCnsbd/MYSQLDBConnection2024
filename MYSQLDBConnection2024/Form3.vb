Imports MySql.Data.MySqlClient

Public Class SignUp_Form
    Dim conn As MySqlConnection
    Dim command As MySqlCommand
    Private Sub SignUp_button_Click(sender As Object, e As EventArgs) Handles SignUp_button.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1; port= 3306; userid=root;password='';database=test"
        Dim reader As MySqlDataReader

        Try
            conn.Open
            Dim query As String
            query = "INSERT INTO test.data (student_number, first_name, last_name, username, password) VALUES ( '" & InSN.Text & "' , '" & InFN.Text & "' , '" & InLN.Text & "', '" & InUN.Text & "', '" & InPW.Text & "')"
            command = New MySqlCommand(query, conn)
            reader = command.ExecuteReader

            MessageBox.Show("Sign up complete!!")
            Form1.Show
            Hide

            conn.Close
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close
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
End Class