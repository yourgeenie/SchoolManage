<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Courses
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
        courseID = New DataGridViewTextBoxColumn()
        courseCategory = New DataGridViewTextBoxColumn()
        courseName = New DataGridViewTextBoxColumn()
        btnDeleteCourse = New Button()
        btnEditCourse = New Button()
        btnAddCourse = New Button()
        btnBack = New Button()
        btnRefresh = New Button()
        PictureBox1 = New PictureBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.ButtonHighlight
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {courseID, courseCategory, courseName})
        DataGridView1.Location = New Point(87, 190)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(785, 482)
        DataGridView1.TabIndex = 19
        ' 
        ' courseID
        ' 
        courseID.HeaderText = "ID No."
        courseID.MinimumWidth = 6
        courseID.Name = "courseID"
        courseID.Width = 80
        ' 
        ' courseCategory
        ' 
        courseCategory.HeaderText = "Course Category"
        courseCategory.MinimumWidth = 6
        courseCategory.Name = "courseCategory"
        courseCategory.Width = 250
        ' 
        ' courseName
        ' 
        courseName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        courseName.HeaderText = "Course Name"
        courseName.MinimumWidth = 6
        courseName.Name = "courseName"' 
        ' btnDeleteCourse
        ' 
        btnDeleteCourse.BackColor = SystemColors.ButtonHighlight
        btnDeleteCourse.FlatStyle = FlatStyle.Flat
        btnDeleteCourse.Font = New Font("Palatino Linotype", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnDeleteCourse.Location = New Point(924, 639)
        btnDeleteCourse.Name = "btnDeleteCourse"
        btnDeleteCourse.Size = New Size(313, 33)
        btnDeleteCourse.TabIndex = 18
        btnDeleteCourse.Text = "DELETE"
        btnDeleteCourse.UseVisualStyleBackColor = False
        ' 
        ' btnEditCourse
        ' 
        btnEditCourse.BackColor = SystemColors.ButtonHighlight
        btnEditCourse.FlatStyle = FlatStyle.Flat
        btnEditCourse.Font = New Font("Palatino Linotype", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnEditCourse.Location = New Point(927, 565)
        btnEditCourse.Name = "btnEditCourse"
        btnEditCourse.Size = New Size(313, 33)
        btnEditCourse.TabIndex = 17
        btnEditCourse.Text = "EDIT INFORMATION"
        btnEditCourse.UseVisualStyleBackColor = False
        ' 
        ' btnAddCourse
        ' 
        btnAddCourse.BackColor = SystemColors.ButtonHighlight
        btnAddCourse.FlatStyle = FlatStyle.Flat
        btnAddCourse.Font = New Font("Palatino Linotype", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnAddCourse.Location = New Point(927, 493)
        btnAddCourse.Name = "btnAddCourse"
        btnAddCourse.Size = New Size(313, 33)
        btnAddCourse.TabIndex = 16
        btnAddCourse.Text = "ADD A COURSE"
        btnAddCourse.UseVisualStyleBackColor = False
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = SystemColors.ButtonHighlight
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.Font = New Font("Palatino Linotype", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnBack.Location = New Point(1113, 191)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(127, 33)
        btnBack.TabIndex = 15
        btnBack.Text = "MAIN MENU"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = SystemColors.ButtonHighlight
        btnRefresh.FlatStyle = FlatStyle.Flat
        btnRefresh.Font = New Font("Palatino Linotype", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnRefresh.Location = New Point(928, 192)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(127, 33)
        btnRefresh.TabIndex = 14
        btnRefresh.Text = "REFRESH"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.ListCourse
        PictureBox1.Location = New Point(1, -1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1329, 771)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 13
        PictureBox1.TabStop = False
        ' 
        ' Courses
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1331, 770)
        Controls.Add(DataGridView1)
        Controls.Add(btnDeleteCourse)
        Controls.Add(btnEditCourse)
        Controls.Add(btnAddCourse)
        Controls.Add(btnBack)
        Controls.Add(btnRefresh)
        Controls.Add(PictureBox1)
        Name = "Courses"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Courses"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents courseID As DataGridViewTextBoxColumn
    Friend WithEvents courseCategory As DataGridViewTextBoxColumn
    Friend WithEvents courseName As DataGridViewTextBoxColumn
    Friend WithEvents btnDeleteCourse As Button
    Friend WithEvents btnEditCourse As Button
    Friend WithEvents btnAddCourse As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
