Imports System.IO
Imports MySql.Data.MySqlClient
Public Class Courses
    Public DBConnection As New MySqlConnection 'NEED TO ADD "MYSQL.DATA.DLL" AS PROJECT REFERENCE'

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        MainMenu.Show()
        Me.Hide()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Call Connect_to_Db()
        'on Courses
        Dim table As New DataTable()
        'Dim adapter As New MySqlDataAdapter("SELECT * FROM schoolms.courses", conn)
        Dim command As New MySqlCommand

        command.Connection = conn
        command.CommandText = "SELECT * FROM schoolms.courses"

        Dim reader As MySqlDataReader = command.ExecuteReader()

        DataGridView1.Rows.Clear() 'clear existing rows before adding new rows

        While reader.Read()
            Dim courseID = reader.GetString(0)
            Dim courseCategory = reader.GetString(1)
            Dim courseName = reader.GetString(2)
            DataGridView1.Rows.Add(courseID, courseCategory, courseName)

        End While

        Call Disconnect_to_Db()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub btnAddCourse_Click(sender As Object, e As EventArgs) Handles btnAddCourse.Click
        AddCourseForm.ShowDialog()
    End Sub

    Private Sub btnEditCourse_Click(sender As Object, e As EventArgs) Handles btnEditCourse.Click
        EditCourseForm.ShowDialog()
    End Sub

    Private Sub btnDeleteCourse_Click(sender As Object, e As EventArgs) Handles btnDeleteCourse.Click
        DeleteCourse.ShowDialog()
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Dim openFileDialog1 As New OpenFileDialog With {
            .Filter = "Text Files (*.csv)|*.csv|All Files (*.*)|*.*",
            .FilterIndex = 1,
            .RestoreDirectory = True
        }

        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = openFileDialog1.FileName
            Dim path As String = filePath.Replace("\", "/")

            Call Connect_to_Db()
            Dim mycmd As New MySqlCommand

            Try
                strSQL = "Load DATA INFILE '" & path & "' INTO TABLE courses " &
                         "FIELDS TERMINATED BY ',' " &
                         "LINES TERMINATED BY '\r\n' " &
                         "IGNORE 1 LINES"

                mycmd.CommandText = strSQL
                mycmd.Connection = conn
                mycmd.ExecuteNonQuery()
                MessageBox.Show("Data uploaded successfully")

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            Disconnect_to_Db()
        End If
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Export_Function("courses")
    End Sub

    Private Sub btnBackUp_Click(sender As Object, e As EventArgs) Handles btnBackUp.Click
        If DataGridView1 IsNot Nothing Then
            If DataGridView1.Rows.Count > 0 Then ' Check if there is at least one row in the DataGridView
                Dim saveFileDialog As New SaveFileDialog()
                saveFileDialog.Filter = "Backup files (*.bat)|*.bat|All files (*.*)|*.*"
                saveFileDialog.Title = "Backup data to file"

                If saveFileDialog.ShowDialog() = DialogResult.OK Then
                    Dim filePath As String = saveFileDialog.FileName

                    Using writer As New StreamWriter(filePath)
                        For Each row As DataGridViewRow In DataGridView1.Rows
                            Dim line As String = ""
                            For Each cell As DataGridViewCell In row.Cells
                                If cell.Value IsNot Nothing Then ' Check if cell value is not null
                                    line += cell.Value.ToString() + ","
                                Else
                                    line += ","
                                End If
                            Next
                            writer.WriteLine(line.TrimEnd(","))
                        Next
                    End Using

                    MessageBox.Show("Backup completed successfully.")
                End If
            Else
                MessageBox.Show("DataGridView does not have any data to back up.")
            End If
        Else
            MessageBox.Show("Data grid view is not initialized.")
        End If
    End Sub
End Class