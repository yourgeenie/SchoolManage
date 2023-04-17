<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddCourseForm
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
        txtCourseID = New TextBox()
        txtCategory = New TextBox()
        txtCourseName = New TextBox()
        btnAddCourse = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.AddCourse
        PictureBox1.Location = New Point(0, -1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(582, 553)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' txtCourseID
        ' 
        txtCourseID.Location = New Point(68, 179)
        txtCourseID.Name = "txtCourseID"
        txtCourseID.Size = New Size(202, 27)
        txtCourseID.TabIndex = 1
        ' 
        ' txtCategory
        ' 
        txtCategory.Location = New Point(68, 259)
        txtCategory.Name = "txtCategory"
        txtCategory.Size = New Size(444, 27)
        txtCategory.TabIndex = 2
        ' 
        ' txtCourseName
        ' 
        txtCourseName.Location = New Point(68, 339)
        txtCourseName.Name = "txtCourseName"
        txtCourseName.Size = New Size(444, 27)
        txtCourseName.TabIndex = 3
        ' 
        ' btnAddCourse
        ' 
        btnAddCourse.BackColor = SystemColors.ButtonHighlight
        btnAddCourse.FlatStyle = FlatStyle.Flat
        btnAddCourse.Font = New Font("Perpetua Titling MT", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnAddCourse.Location = New Point(172, 447)
        btnAddCourse.Name = "btnAddCourse"
        btnAddCourse.Size = New Size(232, 29)
        btnAddCourse.TabIndex = 4
        btnAddCourse.Text = "ADD COURSE"
        btnAddCourse.TextImageRelation = TextImageRelation.TextBeforeImage
        btnAddCourse.UseVisualStyleBackColor = False
        ' 
        ' AddCourseForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(582, 553)
        Controls.Add(btnAddCourse)
        Controls.Add(txtCourseName)
        Controls.Add(txtCategory)
        Controls.Add(txtCourseID)
        Controls.Add(PictureBox1)
        Name = "AddCourseForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "AddCourseForm"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtCourseID As TextBox
    Friend WithEvents txtCategory As TextBox
    Friend WithEvents txtCourseName As TextBox
    Friend WithEvents btnAddCourse As Button
End Class
