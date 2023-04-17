<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DelProfForm
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
        txtProfID = New TextBox()
        btnDelProf = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.DelFormProf
        PictureBox1.Location = New Point(1, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(582, 554)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' txtProfID
        ' 
        txtProfID.Location = New Point(101, 271)
        txtProfID.Name = "txtProfID"
        txtProfID.Size = New Size(370, 27)
        txtProfID.TabIndex = 1
        ' 
        ' btnDelProf
        ' 
        btnDelProf.FlatStyle = FlatStyle.Flat
        btnDelProf.Font = New Font("Palatino Linotype", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnDelProf.Location = New Point(174, 448)
        btnDelProf.Name = "btnDelProf"
        btnDelProf.Size = New Size(237, 29)
        btnDelProf.TabIndex = 2
        btnDelProf.Text = "DELETE"
        btnDelProf.UseVisualStyleBackColor = True
        ' 
        ' DelProfForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(582, 553)
        Controls.Add(btnDelProf)
        Controls.Add(txtProfID)
        Controls.Add(PictureBox1)
        Name = "DelProfForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "DelProfForm"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtProfID As TextBox
    Friend WithEvents btnDelProf As Button
End Class
