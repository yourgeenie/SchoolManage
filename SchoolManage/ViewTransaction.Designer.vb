<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewTransaction
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(ViewTransaction))
        PictureBox1 = New PictureBox()
        btnBack = New Button()
        btnRefresh = New Button()
        DataGridView1 = New DataGridView()
        transID = New DataGridViewTextBoxColumn()
        transName = New DataGridViewTextBoxColumn()
        studID = New DataGridViewTextBoxColumn()
        firstName = New DataGridViewTextBoxColumn()
        lastName = New DataGridViewTextBoxColumn()
        amount = New DataGridViewTextBoxColumn()
        transDate = New DataGridViewTextBoxColumn()
        transMethod = New DataGridViewTextBoxColumn()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, -2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1331, 772)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = SystemColors.ButtonHighlight
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.Font = New Font("Palatino Linotype", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnBack.Location = New Point(1113, 88)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(127, 33)
        btnBack.TabIndex = 4
        btnBack.Text = "MAIN MENU"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = SystemColors.ButtonHighlight
        btnRefresh.FlatStyle = FlatStyle.Flat
        btnRefresh.Font = New Font("Palatino Linotype", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnRefresh.Location = New Point(93, 89)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(128, 33)
        btnRefresh.TabIndex = 3
        btnRefresh.Text = "REFRESH"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.ButtonHighlight
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {transID, transName, studID, firstName, lastName, amount, transDate, transMethod})
        DataGridView1.Location = New Point(78, 178)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(1175, 511)
        DataGridView1.TabIndex = 5
        ' 
        ' transID
        ' 
        transID.HeaderText = "Transact ID"
        transID.MinimumWidth = 6
        transID.Name = "transID"
        transID.Width = 70
        ' 
        ' transName
        ' 
        transName.HeaderText = "Transaction Name"
        transName.MinimumWidth = 6
        transName.Name = "transName"
        transName.Width = 250
        ' 
        ' studID
        ' 
        studID.HeaderText = "Student ID"
        studID.MinimumWidth = 6
        studID.Name = "studID"
        studID.Width = 70
        ' 
        ' firstName
        ' 
        firstName.HeaderText = "First Name"
        firstName.MinimumWidth = 6
        firstName.Name = "firstName"
        firstName.Width = 150
        ' 
        ' lastName
        ' 
        lastName.HeaderText = "Last Name"
        lastName.MinimumWidth = 6
        lastName.Name = "lastName"
        lastName.Width = 150
        ' 
        ' amount
        ' 
        amount.HeaderText = "Amount"
        amount.MinimumWidth = 6
        amount.Name = "amount"
        amount.Width = 125
        ' 
        ' transDate
        ' 
        transDate.HeaderText = "Transaction Date"
        transDate.MinimumWidth = 6
        transDate.Name = "transDate"
        transDate.Width = 125
        ' 
        ' transMethod
        ' 
        transMethod.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        transMethod.HeaderText = "Transaction Method"
        transMethod.MinimumWidth = 6
        transMethod.Name = "transMethod"' 
        ' ViewTransaction
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1331, 770)
        Controls.Add(DataGridView1)
        Controls.Add(btnBack)
        Controls.Add(btnRefresh)
        Controls.Add(PictureBox1)
        Name = "ViewTransaction"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ViewTransaction"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnBack As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents transID As DataGridViewTextBoxColumn
    Friend WithEvents transName As DataGridViewTextBoxColumn
    Friend WithEvents studID As DataGridViewTextBoxColumn
    Friend WithEvents firstName As DataGridViewTextBoxColumn
    Friend WithEvents lastName As DataGridViewTextBoxColumn
    Friend WithEvents amount As DataGridViewTextBoxColumn
    Friend WithEvents transDate As DataGridViewTextBoxColumn
    Friend WithEvents transMethod As DataGridViewTextBoxColumn
End Class
