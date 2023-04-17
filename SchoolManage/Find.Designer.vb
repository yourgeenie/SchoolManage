<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Find
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Find))
        PictureBox1 = New PictureBox()
        btnBack = New Button()
        btnStudTrans = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(-2, -2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1335, 775)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' btnBack
        ' 
        btnBack.FlatAppearance.BorderSize = 2
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.Font = New Font("Palatino Linotype", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnBack.Location = New Point(529, 216)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(276, 36)
        btnBack.TabIndex = 6
        btnBack.Text = "BACK TO MAIN MENU"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' btnStudTrans
        ' 
        btnStudTrans.FlatAppearance.BorderSize = 2
        btnStudTrans.FlatStyle = FlatStyle.Flat
        btnStudTrans.Font = New Font("Palatino Linotype", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnStudTrans.Location = New Point(546, 563)
        btnStudTrans.Name = "btnStudTrans"
        btnStudTrans.Size = New Size(244, 67)
        btnStudTrans.TabIndex = 5
        btnStudTrans.Text = "Student Transaction"
        btnStudTrans.UseVisualStyleBackColor = True
        ' 
        ' Find
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1331, 770)
        Controls.Add(btnBack)
        Controls.Add(btnStudTrans)
        Controls.Add(PictureBox1)
        Name = "Find"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Find"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnBack As Button
    Friend WithEvents btnStudTrans As Button
End Class
