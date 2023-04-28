<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Subjects
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
        DataGridView1 = New DataGridView()
        subID = New DataGridViewTextBoxColumn()
        subCode = New DataGridViewTextBoxColumn()
        subName = New DataGridViewTextBoxColumn()
        courseID = New DataGridViewTextBoxColumn()
        btnDeleteSub = New Button()
        btnEditSub = New Button()
        btnAddSub = New Button()
        btnBack = New Button()
        btnRefresh = New Button()
        PictureBox1 = New PictureBox()
        btnExport = New Button()
        btnBackUp = New Button()
        btnUpload = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.ButtonHighlight
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {subID, subCode, subName, courseID})
        DataGridView1.Location = New Point(87, 230)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(785, 443)
        DataGridView1.TabIndex = 26
        ' 
        ' subID
        ' 
        subID.HeaderText = "ID No."
        subID.MinimumWidth = 6
        subID.Name = "subID"
        subID.Width = 80
        ' 
        ' subCode
        ' 
        subCode.HeaderText = "Code"
        subCode.MinimumWidth = 6
        subCode.Name = "subCode"
        subCode.Width = 125
        ' 
        ' subName
        ' 
        subName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        subName.HeaderText = "Subject Name"
        subName.MinimumWidth = 6
        subName.Name = "subName"' 
        ' courseID
        ' 
        courseID.HeaderText = "Course ID"
        courseID.MinimumWidth = 6
        courseID.Name = "courseID"
        courseID.Width = 125
        ' 
        ' btnDeleteSub
        ' 
        btnDeleteSub.BackColor = SystemColors.ButtonHighlight
        btnDeleteSub.FlatStyle = FlatStyle.Flat
        btnDeleteSub.Font = New Font("Palatino Linotype", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnDeleteSub.Location = New Point(924, 640)
        btnDeleteSub.Name = "btnDeleteSub"
        btnDeleteSub.Size = New Size(313, 33)
        btnDeleteSub.TabIndex = 25
        btnDeleteSub.Text = "DELETE"
        btnDeleteSub.UseVisualStyleBackColor = False
        ' 
        ' btnEditSub
        ' 
        btnEditSub.BackColor = SystemColors.ButtonHighlight
        btnEditSub.FlatStyle = FlatStyle.Flat
        btnEditSub.Font = New Font("Palatino Linotype", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnEditSub.Location = New Point(927, 566)
        btnEditSub.Name = "btnEditSub"
        btnEditSub.Size = New Size(313, 33)
        btnEditSub.TabIndex = 24
        btnEditSub.Text = "EDIT INFORMATION"
        btnEditSub.UseVisualStyleBackColor = False
        ' 
        ' btnAddSub
        ' 
        btnAddSub.BackColor = SystemColors.ButtonHighlight
        btnAddSub.FlatStyle = FlatStyle.Flat
        btnAddSub.Font = New Font("Palatino Linotype", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnAddSub.Location = New Point(927, 494)
        btnAddSub.Name = "btnAddSub"
        btnAddSub.Size = New Size(313, 33)
        btnAddSub.TabIndex = 23
        btnAddSub.Text = "ADD A SUBJECT"
        btnAddSub.UseVisualStyleBackColor = False
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = SystemColors.ButtonHighlight
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.Font = New Font("Palatino Linotype", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnBack.Location = New Point(1113, 192)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(127, 33)
        btnBack.TabIndex = 22
        btnBack.Text = "MAIN MENU"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = SystemColors.ButtonHighlight
        btnRefresh.FlatStyle = FlatStyle.Flat
        btnRefresh.Font = New Font("Palatino Linotype", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnRefresh.Location = New Point(928, 193)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(127, 33)
        btnRefresh.TabIndex = 21
        btnRefresh.Text = "REFRESH"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.ListSubjects
        PictureBox1.Location = New Point(1, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1329, 771)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 20
        PictureBox1.TabStop = False
        ' 
        ' btnExport
        ' 
        btnExport.FlatStyle = FlatStyle.Flat
        btnExport.Location = New Point(349, 192)
        btnExport.Name = "btnExport"
        btnExport.Size = New Size(250, 29)
        btnExport.TabIndex = 29
        btnExport.Text = "Export Data"
        btnExport.UseVisualStyleBackColor = True
        ' 
        ' btnBackUp
        ' 
        btnBackUp.FlatStyle = FlatStyle.Flat
        btnBackUp.Location = New Point(605, 192)
        btnBackUp.Name = "btnBackUp"
        btnBackUp.Size = New Size(267, 29)
        btnBackUp.TabIndex = 28
        btnBackUp.Text = "Back Up Data"
        btnBackUp.UseVisualStyleBackColor = True
        ' 
        ' btnUpload
        ' 
        btnUpload.FlatStyle = FlatStyle.Flat
        btnUpload.Location = New Point(87, 192)
        btnUpload.Name = "btnUpload"
        btnUpload.Size = New Size(256, 29)
        btnUpload.TabIndex = 27
        btnUpload.Text = "Import Data"
        btnUpload.UseVisualStyleBackColor = True
        ' 
        ' Subjects
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1331, 770)
        Controls.Add(btnExport)
        Controls.Add(btnBackUp)
        Controls.Add(btnUpload)
        Controls.Add(DataGridView1)
        Controls.Add(btnDeleteSub)
        Controls.Add(btnEditSub)
        Controls.Add(btnAddSub)
        Controls.Add(btnBack)
        Controls.Add(btnRefresh)
        Controls.Add(PictureBox1)
        Name = "Subjects"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Subjects"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents subID As DataGridViewTextBoxColumn
    Friend WithEvents subCode As DataGridViewTextBoxColumn
    Friend WithEvents subName As DataGridViewTextBoxColumn
    Friend WithEvents courseID As DataGridViewTextBoxColumn
    Friend WithEvents btnDeleteSub As Button
    Friend WithEvents btnEditSub As Button
    Friend WithEvents btnAddSub As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnExport As Button
    Friend WithEvents btnBackUp As Button
    Friend WithEvents btnUpload As Button
End Class
