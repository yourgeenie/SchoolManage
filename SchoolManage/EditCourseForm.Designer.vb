<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditCourseForm
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
        btnAddCourse = New Button()
        txtCourseName = New TextBox()
        txtCategory = New TextBox()
        txtCourseID = New TextBox()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnAddCourse
        ' 
        btnAddCourse.BackColor = SystemColors.ButtonHighlight
        btnAddCourse.FlatStyle = FlatStyle.Flat
        btnAddCourse.Font = New Font("Perpetua Titling MT", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnAddCourse.Location = New Point(172, 448)
        btnAddCourse.Name = "btnAddCourse"
        btnAddCourse.Size = New Size(232, 29)
        btnAddCourse.TabIndex = 9
        btnAddCourse.Text = "EDIT COURSE INFO"
        btnAddCourse.TextImageRelation = TextImageRelation.TextBeforeImage
        btnAddCourse.UseVisualStyleBackColor = False
        ' 
        ' txtCourseName
        ' 
        txtCourseName.Location = New Point(68, 340)
        txtCourseName.Name = "txtCourseName"
        txtCourseName.Size = New Size(444, 27)
        txtCourseName.TabIndex = 8
        ' 
        ' txtCategory
        ' 
        txtCategory.Location = New Point(68, 260)
        txtCategory.Name = "txtCategory"
        txtCategory.Size = New Size(444, 27)
        txtCategory.TabIndex = 7
        ' 
        ' txtCourseID
        ' 
        txtCourseID.Location = New Point(68, 180)
        txtCourseID.Name = "txtCourseID"
        txtCourseID.Size = New Size(202, 27)
        txtCourseID.TabIndex = 6
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.EditCourse
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(582, 553)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' EditCourseForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(582, 553)
        Controls.Add(btnAddCourse)
        Controls.Add(txtCourseName)
        Controls.Add(txtCategory)
        Controls.Add(txtCourseID)
        Controls.Add(PictureBox1)
        Name = "EditCourseForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "EditCourseForm"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnAddCourse As Button
    Friend WithEvents txtCourseName As TextBox
    Friend WithEvents txtCategory As TextBox
    Friend WithEvents txtCourseID As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
