<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Schedules
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Schedules))
        PictureBox1 = New PictureBox()
        btnRefreshSched = New Button()
        btnMainMenu = New Button()
        btnEditSched = New Button()
        btnAddSched = New Button()
        btnDelSched = New Button()
        DataGridView1 = New DataGridView()
        schedID = New DataGridViewTextBoxColumn()
        courseID = New DataGridViewTextBoxColumn()
        profID = New DataGridViewTextBoxColumn()
        subID = New DataGridViewTextBoxColumn()
        studID = New DataGridViewTextBoxColumn()
        schedDay = New DataGridViewTextBoxColumn()
        timeStart = New DataGridViewTextBoxColumn()
        timeEnd = New DataGridViewTextBoxColumn()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1331, 770)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' btnRefreshSched
        ' 
        btnRefreshSched.FlatStyle = FlatStyle.Flat
        btnRefreshSched.Font = New Font("Palatino Linotype", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnRefreshSched.Location = New Point(91, 88)
        btnRefreshSched.Name = "btnRefreshSched"
        btnRefreshSched.Size = New Size(146, 37)
        btnRefreshSched.TabIndex = 1
        btnRefreshSched.Text = "REFRESH"
        btnRefreshSched.UseVisualStyleBackColor = True
        ' 
        ' btnMainMenu
        ' 
        btnMainMenu.FlatStyle = FlatStyle.Flat
        btnMainMenu.Font = New Font("Palatino Linotype", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnMainMenu.Location = New Point(1094, 90)
        btnMainMenu.Name = "btnMainMenu"
        btnMainMenu.Size = New Size(146, 35)
        btnMainMenu.TabIndex = 2
        btnMainMenu.Text = " MAIN"
        btnMainMenu.UseVisualStyleBackColor = True
        ' 
        ' btnEditSched
        ' 
        btnEditSched.FlatStyle = FlatStyle.Flat
        btnEditSched.Font = New Font("Palatino Linotype", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnEditSched.Location = New Point(91, 645)
        btnEditSched.Margin = New Padding(0, 3, 3, 3)
        btnEditSched.Name = "btnEditSched"
        btnEditSched.Size = New Size(339, 34)
        btnEditSched.TabIndex = 3
        btnEditSched.Text = "EDIT SCHEDULES"
        btnEditSched.UseVisualStyleBackColor = True
        ' 
        ' btnAddSched
        ' 
        btnAddSched.FlatStyle = FlatStyle.Flat
        btnAddSched.Font = New Font("Palatino Linotype", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnAddSched.Location = New Point(497, 645)
        btnAddSched.Margin = New Padding(0, 3, 3, 3)
        btnAddSched.Name = "btnAddSched"
        btnAddSched.Size = New Size(339, 34)
        btnAddSched.TabIndex = 4
        btnAddSched.Text = "ADD SCHEDULES"
        btnAddSched.UseVisualStyleBackColor = True
        ' 
        ' btnDelSched
        ' 
        btnDelSched.FlatStyle = FlatStyle.Flat
        btnDelSched.Font = New Font("Palatino Linotype", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnDelSched.Location = New Point(901, 645)
        btnDelSched.Margin = New Padding(0, 3, 3, 3)
        btnDelSched.Name = "btnDelSched"
        btnDelSched.Size = New Size(339, 34)
        btnDelSched.TabIndex = 5
        btnDelSched.Text = "DELETE SCHEDULES"
        btnDelSched.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.ButtonHighlight
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {schedID, courseID, profID, subID, studID, schedDay, timeStart, timeEnd})
        DataGridView1.Location = New Point(79, 161)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(1174, 448)
        DataGridView1.TabIndex = 6
        ' 
        ' schedID
        ' 
        schedID.HeaderText = "Schedule ID"
        schedID.MinimumWidth = 6
        schedID.Name = "schedID"
        schedID.Width = 125
        ' 
        ' courseID
        ' 
        courseID.HeaderText = "Course ID"
        courseID.MinimumWidth = 6
        courseID.Name = "courseID"
        courseID.Width = 125
        ' 
        ' profID
        ' 
        profID.HeaderText = "Professor ID"
        profID.MinimumWidth = 6
        profID.Name = "profID"
        profID.Width = 125
        ' 
        ' subID
        ' 
        subID.HeaderText = "Subject ID"
        subID.MinimumWidth = 6
        subID.Name = "subID"
        subID.Width = 125
        ' 
        ' studID
        ' 
        studID.HeaderText = "Student ID"
        studID.MinimumWidth = 6
        studID.Name = "studID"
        studID.Width = 125
        ' 
        ' schedDay
        ' 
        schedDay.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        schedDay.HeaderText = "Sched Day"
        schedDay.MinimumWidth = 6
        schedDay.Name = "schedDay"' 
        ' timeStart
        ' 
        timeStart.HeaderText = "Time Start"
        timeStart.MinimumWidth = 6
        timeStart.Name = "timeStart"
        timeStart.Width = 150
        ' 
        ' timeEnd
        ' 
        timeEnd.HeaderText = "Time End"
        timeEnd.MinimumWidth = 6
        timeEnd.Name = "timeEnd"
        timeEnd.Width = 150
        ' 
        ' Schedules
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1331, 770)
        Controls.Add(DataGridView1)
        Controls.Add(btnDelSched)
        Controls.Add(btnAddSched)
        Controls.Add(btnEditSched)
        Controls.Add(btnMainMenu)
        Controls.Add(btnRefreshSched)
        Controls.Add(PictureBox1)
        Name = "Schedules"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Schedules"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnRefreshSched As Button
    Friend WithEvents btnMainMenu As Button
    Friend WithEvents btnEditSched As Button
    Friend WithEvents btnAddSched As Button
    Friend WithEvents btnDelSched As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents schedID As DataGridViewTextBoxColumn
    Friend WithEvents courseID As DataGridViewTextBoxColumn
    Friend WithEvents profID As DataGridViewTextBoxColumn
    Friend WithEvents subID As DataGridViewTextBoxColumn
    Friend WithEvents studID As DataGridViewTextBoxColumn
    Friend WithEvents schedDay As DataGridViewTextBoxColumn
    Friend WithEvents timeStart As DataGridViewTextBoxColumn
    Friend WithEvents timeEnd As DataGridViewTextBoxColumn
End Class
