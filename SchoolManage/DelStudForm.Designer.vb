<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DelStudForm
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
        btnDeleteStud = New Button()
        txtStudID = New TextBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.DelForSub
        PictureBox1.Location = New Point(-1, -1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(583, 554)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' btnDeleteStud
        ' 
        btnDeleteStud.FlatStyle = FlatStyle.Flat
        btnDeleteStud.Font = New Font("Palatino Linotype", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnDeleteStud.Location = New Point(169, 446)
        btnDeleteStud.Name = "btnDeleteStud"
        btnDeleteStud.Size = New Size(243, 29)
        btnDeleteStud.TabIndex = 1
        btnDeleteStud.Text = "DELETE"
        btnDeleteStud.UseVisualStyleBackColor = True
        ' 
        ' txtStudID
        ' 
        txtStudID.Location = New Point(98, 269)
        txtStudID.Name = "txtStudID"
        txtStudID.Size = New Size(373, 27)
        txtStudID.TabIndex = 2
        ' 
        ' DelStudForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(582, 553)
        Controls.Add(txtStudID)
        Controls.Add(btnDeleteStud)
        Controls.Add(PictureBox1)
        Name = "DelStudForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "DelStudForm"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnDeleteStud As Button
    Friend WithEvents txtStudID As TextBox
End Class
