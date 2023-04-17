<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewMenu
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(ViewMenu))
        PictureBox1 = New PictureBox()
        btnTransView = New Button()
        btnProfSub = New Button()
        btnSchedView = New Button()
        btnBack = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1334, 770)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' btnTransView
        ' 
        btnTransView.FlatAppearance.BorderSize = 2
        btnTransView.FlatStyle = FlatStyle.Flat
        btnTransView.Font = New Font("Palatino Linotype", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnTransView.Location = New Point(181, 531)
        btnTransView.Name = "btnTransView"
        btnTransView.Size = New Size(252, 67)
        btnTransView.TabIndex = 1
        btnTransView.Text = "Transaction 's View"
        btnTransView.UseVisualStyleBackColor = True
        ' 
        ' btnProfSub
        ' 
        btnProfSub.FlatAppearance.BorderSize = 2
        btnProfSub.FlatStyle = FlatStyle.Flat
        btnProfSub.Font = New Font("Palatino Linotype", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnProfSub.Location = New Point(556, 531)
        btnProfSub.Name = "btnProfSub"
        btnProfSub.Size = New Size(252, 67)
        btnProfSub.TabIndex = 2
        btnProfSub.Text = "Professor's Subject"
        btnProfSub.UseVisualStyleBackColor = True
        ' 
        ' btnSchedView
        ' 
        btnSchedView.FlatAppearance.BorderSize = 2
        btnSchedView.FlatStyle = FlatStyle.Flat
        btnSchedView.Font = New Font("Palatino Linotype", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnSchedView.Location = New Point(936, 531)
        btnSchedView.Name = "btnSchedView"
        btnSchedView.Size = New Size(252, 67)
        btnSchedView.TabIndex = 3
        btnSchedView.Text = "Schedule's View"
        btnSchedView.UseVisualStyleBackColor = True
        ' 
        ' btnBack
        ' 
        btnBack.FlatAppearance.BorderSize = 2
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.Font = New Font("Palatino Linotype", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnBack.Location = New Point(1055, 158)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(137, 36)
        btnBack.TabIndex = 4
        btnBack.Text = "BACK"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' ViewMenu
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1331, 770)
        Controls.Add(btnBack)
        Controls.Add(btnSchedView)
        Controls.Add(btnProfSub)
        Controls.Add(btnTransView)
        Controls.Add(PictureBox1)
        Name = "ViewMenu"
        StartPosition = FormStartPosition.CenterScreen
        Tag = "ViewMenu"
        Text = "Menu2"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnTransView As Button
    Friend WithEvents btnProfSub As Button
    Friend WithEvents btnSchedView As Button
    Friend WithEvents btnBack As Button
End Class
