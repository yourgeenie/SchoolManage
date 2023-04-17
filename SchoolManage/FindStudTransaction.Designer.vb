<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FindStudTransaction
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(FindStudTransaction))
        PictureBox1 = New PictureBox()
        DataGridView1 = New DataGridView()
        transID = New DataGridViewTextBoxColumn()
        transName = New DataGridViewTextBoxColumn()
        amount = New DataGridViewTextBoxColumn()
        transDate = New DataGridViewTextBoxColumn()
        transMethod = New DataGridViewTextBoxColumn()
        btnBack = New Button()
        txtSearchStudID = New TextBox()
        btnSearch = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1330, 771)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.ButtonHighlight
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {transID, transName, amount, transDate, transMethod})
        DataGridView1.Location = New Point(77, 180)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(812, 510)
        DataGridView1.TabIndex = 1
        ' 
        ' transID
        ' 
        transID.HeaderText = "Transcation ID"
        transID.MinimumWidth = 6
        transID.Name = "transID"
        transID.Width = 125
        ' 
        ' transName
        ' 
        transName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        transName.HeaderText = "Transaction Name"
        transName.MinimumWidth = 6
        transName.Name = "transName"' 
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
        transMethod.HeaderText = "Transaction Method"
        transMethod.MinimumWidth = 6
        transMethod.Name = "transMethod"
        transMethod.Width = 125
        ' 
        ' btnBack
        ' 
        btnBack.FlatAppearance.BorderSize = 2
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.Font = New Font("Palatino Linotype", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnBack.Location = New Point(1111, 95)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(129, 36)
        btnBack.TabIndex = 5
        btnBack.Text = "BACK"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' txtSearchStudID
        ' 
        txtSearchStudID.Location = New Point(936, 405)
        txtSearchStudID.Multiline = True
        txtSearchStudID.Name = "txtSearchStudID"
        txtSearchStudID.Size = New Size(304, 34)
        txtSearchStudID.TabIndex = 6
        ' 
        ' btnSearch
        ' 
        btnSearch.FlatAppearance.BorderSize = 2
        btnSearch.FlatStyle = FlatStyle.Flat
        btnSearch.Font = New Font("Palatino Linotype", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        btnSearch.Location = New Point(936, 645)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(304, 36)
        btnSearch.TabIndex = 7
        btnSearch.Text = "SEARCH"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' FindStudTransaction
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1331, 770)
        Controls.Add(btnSearch)
        Controls.Add(txtSearchStudID)
        Controls.Add(btnBack)
        Controls.Add(DataGridView1)
        Controls.Add(PictureBox1)
        Name = "FindStudTransaction"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FindStudTransaction"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnBack As Button
    Friend WithEvents txtSearchStudID As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents transID As DataGridViewTextBoxColumn
    Friend WithEvents transName As DataGridViewTextBoxColumn
    Friend WithEvents amount As DataGridViewTextBoxColumn
    Friend WithEvents transDate As DataGridViewTextBoxColumn
    Friend WithEvents transMethod As DataGridViewTextBoxColumn
End Class
