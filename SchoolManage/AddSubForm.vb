Imports MySql.Data.MySqlClient
Imports System.Diagnostics.Eventing
Public Class AddSubForm
    Private Sub InitializeComponent()
        btnAddSub = New Button()
        txtSubCode = New TextBox()
        txtSubName = New TextBox()
        txtCourseID = New TextBox()
        txtSubID = New TextBox()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnAddSub
        ' 
        btnAddSub.FlatStyle = FlatStyle.Flat
        btnAddSub.Font = New Font("Palatino Linotype", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        btnAddSub.Location = New Point(171, 448)
        btnAddSub.Name = "btnAddSub"
        btnAddSub.Size = New Size(237, 29)
        btnAddSub.TabIndex = 17
        btnAddSub.Text = "ADD A SUBJECT"
        btnAddSub.UseVisualStyleBackColor = True
        ' 
        ' txtSubCode
        ' 
        txtSubCode.Location = New Point(314, 260)
        txtSubCode.Name = "txtSubCode"
        txtSubCode.Size = New Size(199, 27)
        txtSubCode.TabIndex = 16
        ' 
        ' txtSubName
        ' 
        txtSubName.Location = New Point(67, 340)
        txtSubName.Name = "txtSubName"
        txtSubName.Size = New Size(446, 27)
        txtSubName.TabIndex = 15
        ' 
        ' txtCourseID
        ' 
        txtCourseID.Location = New Point(67, 259)
        txtCourseID.Name = "txtCourseID"
        txtCourseID.Size = New Size(204, 27)
        txtCourseID.TabIndex = 14
        ' 
        ' txtSubID
        ' 
        txtSubID.Location = New Point(67, 178)
        txtSubID.Name = "txtSubID"
        txtSubID.Size = New Size(204, 27)
        txtSubID.TabIndex = 13
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.AddSub
        PictureBox1.Location = New Point(0, -2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(582, 556)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 12
        PictureBox1.TabStop = False
        ' 
        ' AddSubForm
        ' 
        ClientSize = New Size(582, 553)
        Controls.Add(btnAddSub)
        Controls.Add(txtSubCode)
        Controls.Add(txtSubName)
        Controls.Add(txtCourseID)
        Controls.Add(txtSubID)
        Controls.Add(PictureBox1)
        Name = "AddSubForm"
        StartPosition = FormStartPosition.CenterScreen
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Private Sub btnAddSub_Click(sender As Object, e As EventArgs) Handles btnAddSub.Click
        With Me
            Call Connect_to_Db()
            Dim mycmd As New MySqlCommand
            Try
                strSQL = "Insert into subjects values('" _
                & .txtSubID.Text & "', '" _
                & .txtCourseID.Text & "', '" _
                & .txtSubCode.Text & "', '" _
                & .txtSubName.Text & "',)"
                mycmd.CommandText = strSQL
                mycmd.Connection = conn
                mycmd.ExecuteNonQuery()
                MsgBox("Record Successfully Added")

                Call Clear_Boxes()
            Catch ex As MySqlException
                MsgBox(ex.Number & " " & ex.Message)
            End Try
            Disconnect_to_Db()

            Me.Hide()
        End With
    End Sub

    Private Sub Clear_Boxes()
        With Me
            .txtSubID.Text = ""
            .txtCourseID.Text = ""
            .txtSubCode.Text = ""
            .txtSubName.Text = ""
        End With
    End Sub

End Class