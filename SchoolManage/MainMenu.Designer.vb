<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(MainMenu))
        PictureBox1 = New PictureBox()
        btnStudents = New Button()
        btnCourses = New Button()
        btnProfs = New Button()
        btnSubjects = New Button()
        btnTransactions = New Button()
        btnView = New Button()
        btnFind = New Button()
        btnSched = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(-1, -1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1337, 772)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' btnStudents
        ' 
        btnStudents.BackColor = SystemColors.ButtonHighlight
        btnStudents.FlatStyle = FlatStyle.Flat
        btnStudents.Font = New Font("Palatino Linotype", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnStudents.Location = New Point(160, 275)
        btnStudents.Name = "btnStudents"
        btnStudents.Size = New Size(199, 47)
        btnStudents.TabIndex = 1
        btnStudents.Text = "STUDENTS"
        btnStudents.UseVisualStyleBackColor = False
        ' 
        ' btnCourses
        ' 
        btnCourses.BackColor = SystemColors.ButtonHighlight
        btnCourses.FlatStyle = FlatStyle.Flat
        btnCourses.Font = New Font("Palatino Linotype", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnCourses.Location = New Point(160, 367)
        btnCourses.Name = "btnCourses"
        btnCourses.Size = New Size(199, 47)
        btnCourses.TabIndex = 2
        btnCourses.Text = "COURSES"
        btnCourses.UseVisualStyleBackColor = False
        ' 
        ' btnProfs
        ' 
        btnProfs.BackColor = SystemColors.ButtonHighlight
        btnProfs.FlatStyle = FlatStyle.Flat
        btnProfs.Font = New Font("Palatino Linotype", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnProfs.Location = New Point(418, 275)
        btnProfs.Name = "btnProfs"
        btnProfs.Size = New Size(199, 47)
        btnProfs.TabIndex = 3
        btnProfs.Text = "PROFESSORS"
        btnProfs.UseVisualStyleBackColor = False
        ' 
        ' btnSubjects
        ' 
        btnSubjects.BackColor = SystemColors.ButtonHighlight
        btnSubjects.FlatStyle = FlatStyle.Flat
        btnSubjects.Font = New Font("Palatino Linotype", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnSubjects.Location = New Point(418, 367)
        btnSubjects.Name = "btnSubjects"
        btnSubjects.Size = New Size(201, 47)
        btnSubjects.TabIndex = 4
        btnSubjects.Text = "SUBJECTS"
        btnSubjects.UseVisualStyleBackColor = False
        ' 
        ' btnTransactions
        ' 
        btnTransactions.BackColor = SystemColors.ButtonHighlight
        btnTransactions.FlatStyle = FlatStyle.Flat
        btnTransactions.Font = New Font("Palatino Linotype", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnTransactions.Location = New Point(160, 461)
        btnTransactions.Name = "btnTransactions"
        btnTransactions.Size = New Size(199, 47)
        btnTransactions.TabIndex = 5
        btnTransactions.Text = "TRANSACTIONS"
        btnTransactions.UseVisualStyleBackColor = False
        ' 
        ' btnView
        ' 
        btnView.BackColor = SystemColors.ButtonHighlight
        btnView.FlatStyle = FlatStyle.Flat
        btnView.Font = New Font("Palatino Linotype", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnView.Location = New Point(160, 616)
        btnView.Name = "btnView"
        btnView.Size = New Size(199, 47)
        btnView.TabIndex = 6
        btnView.Text = "VIEW RECORDS"
        btnView.UseVisualStyleBackColor = False
        ' 
        ' btnFind
        ' 
        btnFind.BackColor = SystemColors.ButtonHighlight
        btnFind.FlatStyle = FlatStyle.Flat
        btnFind.Font = New Font("Palatino Linotype", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnFind.Location = New Point(418, 616)
        btnFind.Name = "btnFind"
        btnFind.Size = New Size(199, 47)
        btnFind.TabIndex = 7
        btnFind.Text = "FIND RECORDS"
        btnFind.UseVisualStyleBackColor = False
        ' 
        ' btnSched
        ' 
        btnSched.BackColor = SystemColors.ButtonHighlight
        btnSched.FlatStyle = FlatStyle.Flat
        btnSched.Font = New Font("Palatino Linotype", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnSched.Location = New Point(418, 461)
        btnSched.Name = "btnSched"
        btnSched.Size = New Size(201, 47)
        btnSched.TabIndex = 8
        btnSched.Text = "SCHEDULES"
        btnSched.UseVisualStyleBackColor = False
        ' 
        ' MainMenu
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1331, 770)
        Controls.Add(btnSched)
        Controls.Add(btnFind)
        Controls.Add(btnView)
        Controls.Add(btnTransactions)
        Controls.Add(btnSubjects)
        Controls.Add(btnProfs)
        Controls.Add(btnCourses)
        Controls.Add(btnStudents)
        Controls.Add(PictureBox1)
        Name = "MainMenu"
        StartPosition = FormStartPosition.CenterScreen
        Text = "MainMenu"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnStudents As Button
    Friend WithEvents btnCourses As Button
    Friend WithEvents btnProfs As Button
    Friend WithEvents btnSubjects As Button
    Friend WithEvents btnTransactions As Button
    Friend WithEvents btnView As Button
    Friend WithEvents btnFind As Button
    Friend WithEvents btnSched As Button
End Class
