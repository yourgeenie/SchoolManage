Imports MySql.Data.MySqlClient
Imports System.IO

Module ExportFunction
    Sub Export_Function(tableName As String)
        Dim connectionString As String = "Server=localhost;Database=schoolms;Uid=root;Pwd=admin;"

        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            ' Retrieve the data from the database
            Dim query As String = "SELECT * FROM " + tableName
            Dim command As New MySqlCommand(query, connection)
            Dim reader As MySqlDataReader = command.ExecuteReader()

            ' Prompt the user to choose a save file location
            Dim saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "CSV files (*.csv)|*.csv"
            saveFileDialog.Title = "Export table as CSV"
            saveFileDialog.ShowDialog()

            If saveFileDialog.FileName <> "" Then
                ' Write the data to the CSV file
                Using writer As New StreamWriter(saveFileDialog.FileName)
                    ' Write the column headers
                    For i As Integer = 0 To reader.FieldCount - 1
                        writer.Write(reader.GetName(i))
                        If i < reader.FieldCount - 1 Then
                            writer.Write(",")
                        End If
                    Next
                    writer.WriteLine()

                    ' Write the data rows
                    While reader.Read()
                        For i As Integer = 0 To reader.FieldCount - 1
                            If Not reader.IsDBNull(i) Then
                                writer.Write(reader(i).ToString())
                            End If
                            If i < reader.FieldCount - 1 Then
                                writer.Write(",")
                            End If
                        Next
                        writer.WriteLine()
                    End While
                End Using

                MessageBox.Show("Export complete!")
            End If

            reader.Close()
            connection.Close()
        End Using
    End Sub

End Module
