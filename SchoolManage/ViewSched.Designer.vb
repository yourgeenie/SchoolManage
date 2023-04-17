<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSched
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(ViewSched))
        DataGridView1 = New DataGridView()
        schedID = New DataGridViewTextBoxColumn()
        courseName = New DataGridViewTextBoxColumn()
        profFirstName = New DataGridViewTextBoxColumn()
        profLastName = New DataGridViewTextBoxColumn()
        subCode = New DataGridViewTextBoxColumn()
        subName = New DataGridViewTextBoxColumn()
        studName = New DataGridViewTextBoxColumn()
        schedDay = New DataGridViewTextBoxColumn()
        timeStart = New DataGridViewTextBoxColumn()
        timeEnd = New DataGridViewTextBoxColumn()
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
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {schedID, courseName, profFirstName, profLastName, subCode, subName, studName, schedDay, timeStart, timeEnd})
        DataGridView1.Location = New Point(78, 179)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(1175, 511)
        DataGridView1.TabIndex = 13
        ' 
        ' schedID
        ' 
        schedID.HeaderText = "Sched ID"
        schedID.MinimumWidth = 6
        schedID.Name = "schedID"
        schedID.Width = 70
        ' 
        ' courseName
        ' 
        courseName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        courseName.HeaderText = "Course Name"
        courseName.MinimumWidth = 6
        courseName.Name = "courseName"' 
        ' profFirstName
        ' 
        profFirstName.HeaderText = "Prof First Name"
        profFirstName.MinimumWidth = 6
        profFirstName.Name = "profFirstName"
        profFirstName.Width = 125
        ' 
        ' profLastName
        ' 
        profLastName.HeaderText = "Prof Last Name"
        profLastName.MinimumWidth = 6
        profLastName.Name = "profLastName"
        profLastName.Width = 125
        ' 
        ' subCode
        ' 
        subCode.HeaderText = "Subject Code"
        subCode.MinimumWidth = 6
        subCode.Name = "subCode"
        subCode.Width = 80
        ' 
        ' subName
        ' 
        subName.HeaderText = "Subject Name"
        subName.MinimumWidth = 6
        subName.Name = "subName"
        subName.Width = 125
        ' 
        ' studName
        ' 
        studName.HeaderText = "Student Name"
        studName.MinimumWidth = 6
        studName.Name = "studName"
        studName.Width = 125
        ' 
        ' schedDay
        ' 
        schedDay.HeaderText = "Schedule Day"
        schedDay.MinimumWidth = 6
        schedDay.Name = "schedDay"
        schedDay.Width = 80
        ' 
        ' timeStart
        ' 
        timeStart.HeaderText = "Time Start"
        timeStart.MinimumWidth = 6
        timeStart.Name = "timeStart"
        timeStart.Width = 80
        ' 
        ' timeEnd
        ' 
        timeEnd.HeaderText = "Time End"
        timeEnd.MinimumWidth = 6
        timeEnd.Name = "timeEnd"
        timeEnd.Width = 80
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = SystemColors.ButtonHighlight
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.Font = New Font("Palatino Linotype", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnBack.Location = New Point(1113, 89)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(127, 33)
        btnBack.TabIndex = 12
        btnBack.Text = "MAIN MENU"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = SystemColors.ButtonHighlight
        btnRefresh.FlatStyle = FlatStyle.Flat
        btnRefresh.Font = New Font("Palatino Linotype", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnRefresh.Location = New Point(93, 90)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(128, 33)
        btnRefresh.TabIndex = 11
        btnRefresh.Text = "REFRESH"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, -1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1331, 772)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 10
        PictureBox1.TabStop = False
        ' 
        ' ViewSched
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1331, 770)
        Controls.Add(DataGridView1)
        Controls.Add(btnBack)
        Controls.Add(btnRefresh)
        Controls.Add(PictureBox1)
        Name = "ViewSched"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ViewSched"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnBack As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents schedID As DataGridViewTextBoxColumn
    Friend WithEvents courseName As DataGridViewTextBoxColumn
    Friend WithEvents profFirstName As DataGridViewTextBoxColumn
    Friend WithEvents profLastName As DataGridViewTextBoxColumn
    Friend WithEvents subCode As DataGridViewTextBoxColumn
    Friend WithEvents subName As DataGridViewTextBoxColumn
    Friend WithEvents studName As DataGridViewTextBoxColumn
    Friend WithEvents schedDay As DataGridViewTextBoxColumn
    Friend WithEvents timeStart As DataGridViewTextBoxColumn
    Friend WithEvents timeEnd As DataGridViewTextBoxColumn
End Class
