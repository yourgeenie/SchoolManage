<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddProfForm
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
        btnAddProf = New Button()
        txtProfID = New TextBox()
        PictureBox1 = New PictureBox()
        txtProfFirstName = New TextBox()
        txtProfLastName = New TextBox()
        txtProfGender = New TextBox()
        txtProfEmail = New TextBox()
        txtProfContact = New TextBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnAddProf
        ' 
        btnAddProf.BackColor = SystemColors.ButtonHighlight
        btnAddProf.FlatStyle = FlatStyle.Flat
        btnAddProf.Font = New Font("Perpetua Titling MT", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnAddProf.Location = New Point(172, 448)
        btnAddProf.Name = "btnAddProf"
        btnAddProf.Size = New Size(238, 29)
        btnAddProf.TabIndex = 9
        btnAddProf.Text = "ADD PROFESSOR"
        btnAddProf.TextImageRelation = TextImageRelation.TextBeforeImage
        btnAddProf.UseVisualStyleBackColor = False
        ' 
        ' txtProfID
        ' 
        txtProfID.BorderStyle = BorderStyle.None
        txtProfID.Location = New Point(64, 163)
        txtProfID.Multiline = True
        txtProfID.Name = "txtProfID"
        txtProfID.PlaceholderText = " 0000"
        txtProfID.Size = New Size(210, 21)
        txtProfID.TabIndex = 6
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.AddProf
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(582, 553)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' txtProfFirstName
        ' 
        txtProfFirstName.BorderStyle = BorderStyle.None
        txtProfFirstName.Location = New Point(66, 227)
        txtProfFirstName.Multiline = True
        txtProfFirstName.Name = "txtProfFirstName"
        txtProfFirstName.PlaceholderText = " Juan"
        txtProfFirstName.Size = New Size(205, 22)
        txtProfFirstName.TabIndex = 10
        ' 
        ' txtProfLastName
        ' 
        txtProfLastName.BorderStyle = BorderStyle.None
        txtProfLastName.Location = New Point(310, 227)
        txtProfLastName.Multiline = True
        txtProfLastName.Name = "txtProfLastName"
        txtProfLastName.PlaceholderText = " Dela Cruz"
        txtProfLastName.Size = New Size(205, 22)
        txtProfLastName.TabIndex = 11
        ' 
        ' txtProfGender
        ' 
        txtProfGender.BorderStyle = BorderStyle.None
        txtProfGender.Location = New Point(66, 293)
        txtProfGender.Multiline = True
        txtProfGender.Name = "txtProfGender"
        txtProfGender.Size = New Size(205, 22)
        txtProfGender.TabIndex = 12
        ' 
        ' txtProfEmail
        ' 
        txtProfEmail.BorderStyle = BorderStyle.None
        txtProfEmail.Location = New Point(310, 293)
        txtProfEmail.Multiline = True
        txtProfEmail.Name = "txtProfEmail"
        txtProfEmail.Size = New Size(205, 22)
        txtProfEmail.TabIndex = 13
        ' 
        ' txtProfContact
        ' 
        txtProfContact.BorderStyle = BorderStyle.None
        txtProfContact.Location = New Point(64, 366)
        txtProfContact.Multiline = True
        txtProfContact.Name = "txtProfContact"
        txtProfContact.Size = New Size(451, 22)
        txtProfContact.TabIndex = 14
        ' 
        ' AddProfForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(582, 553)
        Controls.Add(txtProfContact)
        Controls.Add(txtProfEmail)
        Controls.Add(txtProfGender)
        Controls.Add(txtProfLastName)
        Controls.Add(txtProfFirstName)
        Controls.Add(btnAddProf)
        Controls.Add(txtProfID)
        Controls.Add(PictureBox1)
        Name = "AddProfForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "AddProfForm"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnAddProf As Button
    Friend WithEvents txtCourseName As TextBox
    Friend WithEvents txtCategory As TextBox
    Friend WithEvents txtProfID As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtProfFirstName As TextBox
    Friend WithEvents txtProfLastName As TextBox
    Friend WithEvents txtProfGender As TextBox
    Friend WithEvents txtProfEmail As TextBox
    Friend WithEvents txtProfContact As TextBox
End Class
