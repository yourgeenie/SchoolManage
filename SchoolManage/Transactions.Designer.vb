<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transactions
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Transactions))
        DataGridView1 = New DataGridView()
        transID = New DataGridViewTextBoxColumn()
        subCode = New DataGridViewTextBoxColumn()
        studID = New DataGridViewTextBoxColumn()
        amount = New DataGridViewTextBoxColumn()
        transDate = New DataGridViewTextBoxColumn()
        transMethod = New DataGridViewTextBoxColumn()
        btnAddTrans = New Button()
        btnBack = New Button()
        btnRefresh = New Button()
        PictureBox1 = New PictureBox()
        txtTransID = New TextBox()
        txtTransName = New TextBox()
        txtStudID = New TextBox()
        txtTransDate = New TextBox()
        txtTransMethod = New TextBox()
        txtAmount = New TextBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.ButtonHighlight
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {transID, subCode, studID, amount, transDate, transMethod})
        DataGridView1.Location = New Point(89, 173)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(785, 505)
        DataGridView1.TabIndex = 31
        ' 
        ' transID
        ' 
        transID.HeaderText = "ID No."
        transID.MinimumWidth = 6
        transID.Name = "transID"
        transID.Width = 50
        ' 
        ' subCode
        ' 
        subCode.HeaderText = "Transaction Name"
        subCode.MinimumWidth = 6
        subCode.Name = "subCode"
        subCode.Width = 200
        ' 
        ' studID
        ' 
        studID.HeaderText = "Student ID"
        studID.MinimumWidth = 6
        studID.Name = "studID"
        studID.Width = 70
        ' 
        ' amount
        ' 
        amount.HeaderText = "Amount"
        amount.MinimumWidth = 6
        amount.Name = "amount"
        amount.Width = 80
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
        ' btnAddTrans
        ' 
        btnAddTrans.BackColor = SystemColors.ButtonHighlight
        btnAddTrans.FlatStyle = FlatStyle.Flat
        btnAddTrans.Font = New Font("Palatino Linotype", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnAddTrans.Location = New Point(927, 638)
        btnAddTrans.Name = "btnAddTrans"
        btnAddTrans.Size = New Size(313, 33)
        btnAddTrans.TabIndex = 30
        btnAddTrans.Text = "ADD TRANSACTION"
        btnAddTrans.UseVisualStyleBackColor = False
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = SystemColors.ButtonHighlight
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.Font = New Font("Palatino Linotype", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnBack.Location = New Point(1111, 90)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(129, 33)
        btnBack.TabIndex = 29
        btnBack.Text = "MAIN MENU"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = SystemColors.ButtonHighlight
        btnRefresh.FlatStyle = FlatStyle.Flat
        btnRefresh.Font = New Font("Palatino Linotype", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnRefresh.Location = New Point(94, 91)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(127, 33)
        btnRefresh.TabIndex = 28
        btnRefresh.Text = "REFRESH"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(1, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1329, 771)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 27
        PictureBox1.TabStop = False
        ' 
        ' txtTransID
        ' 
        txtTransID.Location = New Point(921, 193)
        txtTransID.Name = "txtTransID"
        txtTransID.PlaceholderText = " 1"
        txtTransID.Size = New Size(322, 27)
        txtTransID.TabIndex = 32
        ' 
        ' txtTransName
        ' 
        txtTransName.Location = New Point(921, 275)
        txtTransName.Name = "txtTransName"
        txtTransName.PlaceholderText = " Miscellaneous Fee"
        txtTransName.Size = New Size(322, 27)
        txtTransName.TabIndex = 33
        ' 
        ' txtStudID
        ' 
        txtStudID.Location = New Point(921, 356)
        txtStudID.Name = "txtStudID"
        txtStudID.PlaceholderText = " 119432"
        txtStudID.Size = New Size(145, 27)
        txtStudID.TabIndex = 34
        ' 
        ' txtTransDate
        ' 
        txtTransDate.Location = New Point(921, 439)
        txtTransDate.Name = "txtTransDate"
        txtTransDate.PlaceholderText = " 10-15-23"
        txtTransDate.Size = New Size(322, 27)
        txtTransDate.TabIndex = 35
        ' 
        ' txtTransMethod
        ' 
        txtTransMethod.Location = New Point(921, 523)
        txtTransMethod.Name = "txtTransMethod"
        txtTransMethod.PlaceholderText = " Online Payment"
        txtTransMethod.Size = New Size(322, 27)
        txtTransMethod.TabIndex = 36
        ' 
        ' txtAmount
        ' 
        txtAmount.Location = New Point(1102, 356)
        txtAmount.Name = "txtAmount"
        txtAmount.PlaceholderText = "200.00"
        txtAmount.Size = New Size(141, 27)
        txtAmount.TabIndex = 37
        ' 
        ' Transactions
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1331, 770)
        Controls.Add(txtAmount)
        Controls.Add(txtTransMethod)
        Controls.Add(txtTransDate)
        Controls.Add(txtStudID)
        Controls.Add(txtTransName)
        Controls.Add(txtTransID)
        Controls.Add(DataGridView1)
        Controls.Add(btnAddTrans)
        Controls.Add(btnBack)
        Controls.Add(btnRefresh)
        Controls.Add(PictureBox1)
        Name = "Transactions"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Transactions"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnAddTrans As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtTransID As TextBox
    Friend WithEvents txtTransName As TextBox
    Friend WithEvents txtStudID As TextBox
    Friend WithEvents txtTransDate As TextBox
    Friend WithEvents txtTransMethod As TextBox
    Friend WithEvents transID As DataGridViewTextBoxColumn
    Friend WithEvents subCode As DataGridViewTextBoxColumn
    Friend WithEvents studID As DataGridViewTextBoxColumn
    Friend WithEvents amount As DataGridViewTextBoxColumn
    Friend WithEvents transDate As DataGridViewTextBoxColumn
    Friend WithEvents transMethod As DataGridViewTextBoxColumn
    Friend WithEvents txtAmount As TextBox
End Class
