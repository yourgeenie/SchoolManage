<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditStudentForm
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
        txtStudContact = New TextBox()
        txtStudAge = New TextBox()
        txtStudGender = New TextBox()
        txtStudLastName = New TextBox()
        txtStudFirstName = New TextBox()
        btnEditStud = New Button()
        txtStudID = New TextBox()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtStudContact
        ' 
        txtStudContact.BorderStyle = BorderStyle.None
        txtStudContact.Location = New Point(64, 366)
        txtStudContact.Multiline = True
        txtStudContact.Name = "txtStudContact"
        txtStudContact.PlaceholderText = "Napao, Bacacay, Albay"
        txtStudContact.Size = New Size(451, 22)
        txtStudContact.TabIndex = 30
        ' 
        ' txtStudAge
        ' 
        txtStudAge.BorderStyle = BorderStyle.None
        txtStudAge.Location = New Point(310, 293)
        txtStudAge.Multiline = True
        txtStudAge.Name = "txtStudAge"
        txtStudAge.PlaceholderText = "juandlcrz@email.com"
        txtStudAge.Size = New Size(205, 22)
        txtStudAge.TabIndex = 29
        ' 
        ' txtStudGender
        ' 
        txtStudGender.BorderStyle = BorderStyle.None
        txtStudGender.Location = New Point(66, 293)
        txtStudGender.Multiline = True
        txtStudGender.Name = "txtStudGender"
        txtStudGender.PlaceholderText = "F/M"
        txtStudGender.Size = New Size(205, 22)
        txtStudGender.TabIndex = 28
        ' 
        ' txtStudLastName
        ' 
        txtStudLastName.BorderStyle = BorderStyle.None
        txtStudLastName.Location = New Point(310, 227)
        txtStudLastName.Multiline = True
        txtStudLastName.Name = "txtStudLastName"
        txtStudLastName.PlaceholderText = " Dela Cruz"
        txtStudLastName.Size = New Size(205, 22)
        txtStudLastName.TabIndex = 27
        ' 
        ' txtStudFirstName
        ' 
        txtStudFirstName.BorderStyle = BorderStyle.None
        txtStudFirstName.Location = New Point(66, 227)
        txtStudFirstName.Multiline = True
        txtStudFirstName.Name = "txtStudFirstName"
        txtStudFirstName.PlaceholderText = " Juan"
        txtStudFirstName.Size = New Size(205, 22)
        txtStudFirstName.TabIndex = 26
        ' 
        ' btnEditStud
        ' 
        btnEditStud.BackColor = SystemColors.ButtonHighlight
        btnEditStud.FlatStyle = FlatStyle.Flat
        btnEditStud.Font = New Font("Perpetua Titling MT", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnEditStud.Location = New Point(172, 448)
        btnEditStud.Name = "btnEditStud"
        btnEditStud.Size = New Size(238, 29)
        btnEditStud.TabIndex = 25
        btnEditStud.Text = "EDIT INFORMATION"
        btnEditStud.TextImageRelation = TextImageRelation.TextBeforeImage
        btnEditStud.UseVisualStyleBackColor = False
        ' 
        ' txtStudID
        ' 
        txtStudID.BorderStyle = BorderStyle.None
        txtStudID.Location = New Point(64, 163)
        txtStudID.Multiline = True
        txtStudID.Name = "txtStudID"
        txtStudID.PlaceholderText = " 0000"
        txtStudID.Size = New Size(210, 21)
        txtStudID.TabIndex = 24
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.EditStudInfo
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(582, 553)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 23
        PictureBox1.TabStop = False
        ' 
        ' EditStudentForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(582, 553)
        Controls.Add(txtStudContact)
        Controls.Add(txtStudAge)
        Controls.Add(txtStudGender)
        Controls.Add(txtStudLastName)
        Controls.Add(txtStudFirstName)
        Controls.Add(btnEditStud)
        Controls.Add(txtStudID)
        Controls.Add(PictureBox1)
        Name = "EditStudentForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "EditStudentForm"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtStudContact As TextBox
    Friend WithEvents txtStudAge As TextBox
    Friend WithEvents txtStudGender As TextBox
    Friend WithEvents txtStudLastName As TextBox
    Friend WithEvents txtStudFirstName As TextBox
    Friend WithEvents btnEditStud As Button
    Friend WithEvents txtStudID As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
