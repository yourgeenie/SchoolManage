<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Students
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
        btnRefresh = New Button()
        btnBack = New Button()
        btnAddStud = New Button()
        btnEditStud = New Button()
        btnDeleteStud = New Button()
        DataGridView1 = New DataGridView()
        studID = New DataGridViewTextBoxColumn()
        firstName = New DataGridViewTextBoxColumn()
        lastName = New DataGridViewTextBoxColumn()
        gender = New DataGridViewTextBoxColumn()
        email = New DataGridViewTextBoxColumn()
        contactAdd = New DataGridViewTextBoxColumn()
        btnUpload = New Button()
        btnBackUp = New Button()
        btnLocate = New Button()
        txtLocate = New TextBox()
        btnExport = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.ListStud
        PictureBox1.Location = New Point(-1, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1331, 771)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = SystemColors.ButtonHighlight
        btnRefresh.FlatStyle = FlatStyle.Flat
        btnRefresh.Font = New Font("Palatino Linotype", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnRefresh.Location = New Point(93, 91)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(145, 33)
        btnRefresh.TabIndex = 1
        btnRefresh.Text = "REFRESH"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = SystemColors.ButtonHighlight
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.Font = New Font("Palatino Linotype", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnBack.Location = New Point(1094, 91)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(145, 33)
        btnBack.TabIndex = 2
        btnBack.Text = "MAIN MENU"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' btnAddStud
        ' 
        btnAddStud.BackColor = SystemColors.ButtonHighlight
        btnAddStud.FlatStyle = FlatStyle.Flat
        btnAddStud.Font = New Font("Palatino Linotype", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnAddStud.Location = New Point(496, 646)
        btnAddStud.Name = "btnAddStud"
        btnAddStud.Size = New Size(338, 33)
        btnAddStud.TabIndex = 3
        btnAddStud.Text = "ADD A STUDENT"
        btnAddStud.UseVisualStyleBackColor = False
        ' 
        ' btnEditStud
        ' 
        btnEditStud.BackColor = SystemColors.ButtonHighlight
        btnEditStud.FlatStyle = FlatStyle.Flat
        btnEditStud.Font = New Font("Palatino Linotype", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnEditStud.Location = New Point(93, 646)
        btnEditStud.Name = "btnEditStud"
        btnEditStud.Size = New Size(338, 33)
        btnEditStud.TabIndex = 4
        btnEditStud.Text = "EDIT INFORMATION"
        btnEditStud.UseVisualStyleBackColor = False
        ' 
        ' btnDeleteStud
        ' 
        btnDeleteStud.BackColor = SystemColors.ButtonHighlight
        btnDeleteStud.FlatStyle = FlatStyle.Flat
        btnDeleteStud.Font = New Font("Palatino Linotype", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnDeleteStud.Location = New Point(901, 646)
        btnDeleteStud.Name = "btnDeleteStud"
        btnDeleteStud.Size = New Size(338, 33)
        btnDeleteStud.TabIndex = 5
        btnDeleteStud.Text = "DELETE"
        btnDeleteStud.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.ButtonHighlight
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {studID, firstName, lastName, gender, email, contactAdd})
        DataGridView1.Location = New Point(89, 211)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(1150, 387)
        DataGridView1.TabIndex = 6
        ' 
        ' studID
        ' 
        studID.HeaderText = "ID No."
        studID.MinimumWidth = 6
        studID.Name = "studID"
        studID.Width = 80
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
        ' contactAdd
        ' 
        contactAdd.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        contactAdd.HeaderText = "Contact Address"
        contactAdd.MinimumWidth = 6
        contactAdd.Name = "contactAdd"' 
        ' btnUpload
        ' 
        btnUpload.FlatStyle = FlatStyle.Flat
        btnUpload.Location = New Point(89, 172)
        btnUpload.Name = "btnUpload"
        btnUpload.Size = New Size(168, 29)
        btnUpload.TabIndex = 7
        btnUpload.Text = "Import Data"
        btnUpload.UseVisualStyleBackColor = True
        ' 
        ' btnBackUp
        ' 
        btnBackUp.FlatStyle = FlatStyle.Flat
        btnBackUp.Location = New Point(438, 172)
        btnBackUp.Name = "btnBackUp"
        btnBackUp.Size = New Size(168, 29)
        btnBackUp.TabIndex = 8
        btnBackUp.Text = "Back Up Data"
        btnBackUp.UseVisualStyleBackColor = True
        ' 
        ' btnLocate
        ' 
        btnLocate.FlatStyle = FlatStyle.Flat
        btnLocate.Location = New Point(612, 172)
        btnLocate.Name = "btnLocate"
        btnLocate.Size = New Size(168, 29)
        btnLocate.TabIndex = 9
        btnLocate.Text = "Locate Data"
        btnLocate.UseVisualStyleBackColor = True
        ' 
        ' txtLocate
        ' 
        txtLocate.Location = New Point(786, 172)
        txtLocate.Name = "txtLocate"
        txtLocate.Size = New Size(453, 27)
        txtLocate.TabIndex = 10
        ' 
        ' btnExport
        ' 
        btnExport.FlatStyle = FlatStyle.Flat
        btnExport.Location = New Point(264, 172)
        btnExport.Name = "btnExport"
        btnExport.Size = New Size(168, 29)
        btnExport.TabIndex = 11
        btnExport.Text = "Export Data"
        btnExport.UseVisualStyleBackColor = True
        ' 
        ' Students
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1331, 770)
        Controls.Add(btnExport)
        Controls.Add(txtLocate)
        Controls.Add(btnLocate)
        Controls.Add(btnBackUp)
        Controls.Add(btnUpload)
        Controls.Add(DataGridView1)
        Controls.Add(btnDeleteStud)
        Controls.Add(btnEditStud)
        Controls.Add(btnAddStud)
        Controls.Add(btnBack)
        Controls.Add(btnRefresh)
        Controls.Add(PictureBox1)
        Name = "Students"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Students"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnAddStud As Button
    Friend WithEvents btnEditStud As Button
    Friend WithEvents btnDeleteStud As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents studID As DataGridViewTextBoxColumn
    Friend WithEvents firstName As DataGridViewTextBoxColumn
    Friend WithEvents lastName As DataGridViewTextBoxColumn
    Friend WithEvents gender As DataGridViewTextBoxColumn
    Friend WithEvents email As DataGridViewTextBoxColumn
    Friend WithEvents contactAdd As DataGridViewTextBoxColumn
    Friend WithEvents btnUpload As Button
    Friend WithEvents btnBackUp As Button
    Friend WithEvents btnLocate As Button
    Friend WithEvents txtLocate As TextBox
    Friend WithEvents btnExport As Button
End Class
