<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Professors
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
        PictureBox1 = New PictureBox()
        DataGridView1 = New DataGridView()
        profID = New DataGridViewTextBoxColumn()
        firstName = New DataGridViewTextBoxColumn()
        lastName = New DataGridViewTextBoxColumn()
        gender = New DataGridViewTextBoxColumn()
        email = New DataGridViewTextBoxColumn()
        contactNumber = New DataGridViewTextBoxColumn()
        btnDeleteProf = New Button()
        btnEditProf = New Button()
        btnAddProf = New Button()
        btnBack = New Button()
        btnRefresh = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.ListProf
        PictureBox1.Location = New Point(1, 1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1329, 769)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.ButtonHighlight
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {profID, firstName, lastName, gender, email, contactNumber})
        DataGridView1.Location = New Point(90, 174)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(1150, 424)
        DataGridView1.TabIndex = 12
        ' 
        ' profID
        ' 
        profID.HeaderText = "ID No."
        profID.MinimumWidth = 6
        profID.Name = "profID"
        profID.Width = 80
        ' 
        ' firstName
        ' 
        firstName.HeaderText = "First Name"
        firstName.MinimumWidth = 6
        firstName.Name = "firstName"
        firstName.Width = 200
        ' 
        ' lastName
        ' 
        lastName.HeaderText = "Last Name"
        lastName.MinimumWidth = 6
        lastName.Name = "lastName"
        lastName.Width = 200
        ' 
        ' gender
        ' 
        gender.HeaderText = "Gender"
        gender.MinimumWidth = 6
        gender.Name = "gender"
        gender.Width = 60
        ' 
        ' email
        ' 
        email.HeaderText = "Email"
        email.MinimumWidth = 6
        email.Name = "email"
        email.Width = 300
        ' 
        ' contactNumber
        ' 
        contactNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        contactNumber.HeaderText = "Contact Number"
        contactNumber.MinimumWidth = 6
        contactNumber.Name = "contactNumber"' 
        ' btnDeleteProf
        ' 
        btnDeleteProf.BackColor = SystemColors.ButtonHighlight
        btnDeleteProf.FlatStyle = FlatStyle.Flat
        btnDeleteProf.Font = New Font("Palatino Linotype", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnDeleteProf.Location = New Point(902, 646)
        btnDeleteProf.Name = "btnDeleteProf"
        btnDeleteProf.Size = New Size(338, 33)
        btnDeleteProf.TabIndex = 11
        btnDeleteProf.Text = "DELETE"
        btnDeleteProf.UseVisualStyleBackColor = False
        ' 
        ' btnEditProf
        ' 
        btnEditProf.BackColor = SystemColors.ButtonHighlight
        btnEditProf.FlatStyle = FlatStyle.Flat
        btnEditProf.Font = New Font("Palatino Linotype", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnEditProf.Location = New Point(94, 646)
        btnEditProf.Name = "btnEditProf"
        btnEditProf.Size = New Size(338, 33)
        btnEditProf.TabIndex = 10
        btnEditProf.Text = "EDIT INFORMATION"
        btnEditProf.UseVisualStyleBackColor = False
        ' 
        ' btnAddProf
        ' 
        btnAddProf.BackColor = SystemColors.ButtonHighlight
        btnAddProf.FlatStyle = FlatStyle.Flat
        btnAddProf.Font = New Font("Palatino Linotype", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnAddProf.Location = New Point(497, 646)
        btnAddProf.Name = "btnAddProf"
        btnAddProf.Size = New Size(338, 33)
        btnAddProf.TabIndex = 9
        btnAddProf.Text = "ADD A PROFESSOR"
        btnAddProf.UseVisualStyleBackColor = False
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = SystemColors.ButtonHighlight
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.Font = New Font("Palatino Linotype", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnBack.Location = New Point(1092, 91)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(145, 33)
        btnBack.TabIndex = 8
        btnBack.Text = "MAIN MENU"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = SystemColors.ButtonHighlight
        btnRefresh.FlatStyle = FlatStyle.Flat
        btnRefresh.Font = New Font("Palatino Linotype", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnRefresh.Location = New Point(94, 91)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(145, 33)
        btnRefresh.TabIndex = 7
        btnRefresh.Text = "REFRESH"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' Professors
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1331, 770)
        Controls.Add(DataGridView1)
        Controls.Add(btnDeleteProf)
        Controls.Add(btnEditProf)
        Controls.Add(btnAddProf)
        Controls.Add(btnBack)
        Controls.Add(btnRefresh)
        Controls.Add(PictureBox1)
        Name = "Professors"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Professors"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnDeleteProf As Button
    Friend WithEvents btnEditProf As Button
    Friend WithEvents btnAddProf As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents profID As DataGridViewTextBoxColumn
    Friend WithEvents firstName As DataGridViewTextBoxColumn
    Friend WithEvents lastName As DataGridViewTextBoxColumn
    Friend WithEvents gender As DataGridViewTextBoxColumn
    Friend WithEvents email As DataGridViewTextBoxColumn
    Friend WithEvents contactNumber As DataGridViewTextBoxColumn
End Class
