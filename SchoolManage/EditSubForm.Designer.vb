<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditSubForm
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
        btnEditSub = New Button()
        txtSubCode = New TextBox()
        txtSubName = New TextBox()
        txtCourseID = New TextBox()
        txtSubID = New TextBox()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnEditSub
        ' 
        btnEditSub.FlatStyle = FlatStyle.Flat
        btnEditSub.Font = New Font("Palatino Linotype", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnEditSub.Location = New Point(171, 448)
        btnEditSub.Name = "btnEditSub"
        btnEditSub.Size = New Size(237, 29)
        btnEditSub.TabIndex = 11
        btnEditSub.Text = "EDIT SUBJECT INFO"
        btnEditSub.UseVisualStyleBackColor = True
        ' 
        ' txtSubCode
        ' 
        txtSubCode.Location = New Point(314, 260)
        txtSubCode.Name = "txtSubCode"
        txtSubCode.Size = New Size(199, 27)
        txtSubCode.TabIndex = 10
        ' 
        ' txtSubName
        ' 
        txtSubName.Location = New Point(67, 340)
        txtSubName.Name = "txtSubName"
        txtSubName.Size = New Size(446, 27)
        txtSubName.TabIndex = 9
        ' 
        ' txtCourseID
        ' 
        txtCourseID.Location = New Point(67, 259)
        txtCourseID.Name = "txtCourseID"
        txtCourseID.Size = New Size(204, 27)
        txtCourseID.TabIndex = 8
        ' 
        ' txtSubID
        ' 
        txtSubID.Location = New Point(67, 178)
        txtSubID.Name = "txtSubID"
        txtSubID.Size = New Size(204, 27)
        txtSubID.TabIndex = 7
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.EditSub
        PictureBox1.Location = New Point(0, -2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(582, 556)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' EditSubForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(582, 553)
        Controls.Add(btnEditSub)
        Controls.Add(txtSubCode)
        Controls.Add(txtSubName)
        Controls.Add(txtCourseID)
        Controls.Add(txtSubID)
        Controls.Add(PictureBox1)
        Name = "EditSubForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "EditSubForm"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnEditSub As Button
    Friend WithEvents txtSubCode As TextBox
    Friend WithEvents txtSubName As TextBox
    Friend WithEvents txtCourseID As TextBox
    Friend WithEvents txtSubID As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
