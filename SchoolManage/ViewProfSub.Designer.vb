<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewProfSub
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(ViewProfSub))
        DataGridView1 = New DataGridView()
        btnBack = New Button()
        btnRefresh = New Button()
        PictureBox1 = New PictureBox()
        firstName = New DataGridViewTextBoxColumn()
        lastName = New DataGridViewTextBoxColumn()
        subCode = New DataGridViewTextBoxColumn()
        subName = New DataGridViewTextBoxColumn()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.ButtonHighlight
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {firstName, lastName, subCode, subName})
        DataGridView1.Location = New Point(78, 179)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(1175, 511)
        DataGridView1.TabIndex = 9
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = SystemColors.ButtonHighlight
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.Font = New Font("Palatino Linotype", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnBack.Location = New Point(1113, 89)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(127, 33)
        btnBack.TabIndex = 8
        btnBack.Text = "MAIN MENU"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = SystemColors.ButtonHighlight
        btnRefresh.FlatStyle = FlatStyle.Flat
        btnRefresh.Font = New Font("Palatino Linotype", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnRefresh.Location = New Point(93, 90)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(128, 33)
        btnRefresh.TabIndex = 7
        btnRefresh.Text = "REFRESH"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, -1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1331, 772)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' firstName
        ' 
        firstName.HeaderText = "First Name"
        firstName.MinimumWidth = 6
        firstName.Name = "firstName"
        firstName.Width = 200
        ' 
        ' lastName
        ' 
        lastName.HeaderText = "Last Name"
        lastName.MinimumWidth = 6
        lastName.Name = "lastName"
        lastName.Width = 200
        ' 
        ' subCode
        ' 
        subCode.HeaderText = "Subject Code"
        subCode.MinimumWidth = 6
        subCode.Name = "subCode"
        subCode.Width = 150
        ' 
        ' subName
        ' 
        subName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        subName.HeaderText = "Subject Name"
        subName.MinimumWidth = 6
        subName.Name = "subName"' 
        ' ViewProfSub
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1331, 770)
        Controls.Add(DataGridView1)
        Controls.Add(btnBack)
        Controls.Add(btnRefresh)
        Controls.Add(PictureBox1)
        Name = "ViewProfSub"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ViewProfSub"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnBack As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents firstName As DataGridViewTextBoxColumn
    Friend WithEvents lastName As DataGridViewTextBoxColumn
    Friend WithEvents subCode As DataGridViewTextBoxColumn
    Friend WithEvents subName As DataGridViewTextBoxColumn
End Class
