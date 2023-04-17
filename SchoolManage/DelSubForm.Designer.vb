<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DelSubForm
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
        btnDelSub = New Button()
        txtSubID = New TextBox()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnDelSub
        ' 
        btnDelSub.FlatStyle = FlatStyle.Flat
        btnDelSub.Font = New Font("Palatino Linotype", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnDelSub.Location = New Point(173, 447)
        btnDelSub.Name = "btnDelSub"
        btnDelSub.Size = New Size(237, 29)
        btnDelSub.TabIndex = 5
        btnDelSub.Text = "DELETE SUBJECT"
        btnDelSub.UseVisualStyleBackColor = True
        ' 
        ' txtSubID
        ' 
        txtSubID.Location = New Point(100, 270)
        txtSubID.Name = "txtSubID"
        txtSubID.Size = New Size(370, 27)
        txtSubID.TabIndex = 4
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.DelForSub
        PictureBox1.Location = New Point(0, -1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(582, 554)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' DelSubForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(582, 553)
        Controls.Add(btnDelSub)
        Controls.Add(txtSubID)
        Controls.Add(PictureBox1)
        Name = "DelSubForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "DelSubForm"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnDelSub As Button
    Friend WithEvents txtSubID As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
