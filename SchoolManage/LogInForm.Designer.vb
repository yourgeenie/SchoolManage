<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogInForm
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
        btnLogIn = New Button()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.LogIn
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(802, 452)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' btnLogIn
        ' 
        btnLogIn.BackColor = Color.FromArgb(CByte(252), CByte(228), CByte(121))
        btnLogIn.FlatAppearance.BorderSize = 2
        btnLogIn.FlatStyle = FlatStyle.Flat
        btnLogIn.Font = New Font("Palatino Linotype", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnLogIn.Location = New Point(487, 302)
        btnLogIn.Name = "btnLogIn"
        btnLogIn.Size = New Size(179, 36)
        btnLogIn.TabIndex = 1
        btnLogIn.Text = "LOG IN"
        btnLogIn.UseVisualStyleBackColor = False
        ' 
        ' txtUsername
        ' 
        txtUsername.BackColor = Color.White
        txtUsername.BorderStyle = BorderStyle.FixedSingle
        txtUsername.Font = New Font("Palatino Linotype", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtUsername.Location = New Point(446, 177)
        txtUsername.Multiline = True
        txtUsername.Name = "txtUsername"
        txtUsername.PlaceholderText = " admin"
        txtUsername.Size = New Size(260, 23)
        txtUsername.TabIndex = 2
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = Color.White
        txtPassword.BorderStyle = BorderStyle.None
        txtPassword.Font = New Font("Palatino Linotype", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtPassword.Location = New Point(446, 243)
        txtPassword.Multiline = True
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.PlaceholderText = " password"
        txtPassword.Size = New Size(260, 23)
        txtPassword.TabIndex = 4
        ' 
        ' LogInForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(btnLogIn)
        Controls.Add(PictureBox1)
        Name = "LogInForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "LogInForm"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnLogIn As Button
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
End Class
