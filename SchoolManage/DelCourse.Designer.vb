<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteCourse
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
        btnDelCourse = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.DelFormCourses
        PictureBox1.Location = New Point(3, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(583, 554)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' txtCourseID
        ' 
        txtCourseID.Location = New Point(104, 270)
        txtCourseID.Name = "txtCourseID"
        txtCourseID.Size = New Size(371, 27)
        txtCourseID.TabIndex = 1
        ' 
        ' btnDelCourse
        ' 
        btnDelCourse.FlatStyle = FlatStyle.Flat
        btnDelCourse.Font = New Font("Palatino Linotype", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnDelCourse.Location = New Point(174, 447)
        btnDelCourse.Name = "btnDelCourse"
        btnDelCourse.Size = New Size(240, 29)
        btnDelCourse.TabIndex = 2
        btnDelCourse.Text = "DELETE COURSE"
        btnDelCourse.UseVisualStyleBackColor = True
        ' 
        ' DeleteCourse
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(582, 553)
        Controls.Add(btnDelCourse)
        Controls.Add(txtCourseID)
        Controls.Add(PictureBox1)
        Name = "DeleteCourse"
        StartPosition = FormStartPosition.CenterScreen
        Text = "DelCourse"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtCourseID As TextBox
    Friend WithEvents btnDelCourse As Button
End Class
