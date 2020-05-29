<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Salesinfo_Form
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
        Me.Salestinfo_Data = New System.Windows.Forms.GroupBox()
        Me.Head_LB = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Paymenttype_CB = New System.Windows.Forms.ComboBox()
        Me.Date_Sales = New System.Windows.Forms.DateTimePicker()
        Me.Datesales_LB = New System.Windows.Forms.Label()
        Me.totalpurchaseprice_LB = New System.Windows.Forms.Label()
        Me.Totalpurchaseprice_TB = New System.Windows.Forms.TextBox()
        Me.Paymenttype_LB = New System.Windows.Forms.Label()
        Me.Clear_BT = New System.Windows.Forms.Button()
        Me.Delete_BT = New System.Windows.Forms.Button()
        Me.Update_BT = New System.Windows.Forms.Button()
        Me.GetData_BT = New System.Windows.Forms.Button()
        Me.Add_BT = New System.Windows.Forms.Button()
        Me.Amountpurchased_LB = New System.Windows.Forms.Label()
        Me.Amountpurchased_TB = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Note_LB = New System.Windows.Forms.Label()
        Me.salespriceperunit_LB = New System.Windows.Forms.Label()
        Me.Buyer_LB = New System.Windows.Forms.Label()
        Me.Productname_LB = New System.Windows.Forms.Label()
        Me.Productid_LB = New System.Windows.Forms.Label()
        Me.Seller_LB = New System.Windows.Forms.Label()
        Me.SalesID_LB = New System.Windows.Forms.Label()
        Me.Salepriceperunit_TB = New System.Windows.Forms.TextBox()
        Me.Buyer_TB = New System.Windows.Forms.TextBox()
        Me.Productname_TB = New System.Windows.Forms.TextBox()
        Me.Productid_TB = New System.Windows.Forms.TextBox()
        Me.Seller_TB = New System.Windows.Forms.TextBox()
        Me.Salesid_TB = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Search_TB = New System.Windows.Forms.TextBox()
        Me.Showall_BT = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Salestinfo_Data.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Salestinfo_Data
        '
        Me.Salestinfo_Data.Controls.Add(Me.Head_LB)
        Me.Salestinfo_Data.Controls.Add(Me.GroupBox1)
        Me.Salestinfo_Data.Controls.Add(Me.GroupBox2)
        Me.Salestinfo_Data.Location = New System.Drawing.Point(14, 13)
        Me.Salestinfo_Data.Name = "Salestinfo_Data"
        Me.Salestinfo_Data.Size = New System.Drawing.Size(1254, 676)
        Me.Salestinfo_Data.TabIndex = 37
        Me.Salestinfo_Data.TabStop = False
        Me.Salestinfo_Data.Text = "Sales info"
        '
        'Head_LB
        '
        Me.Head_LB.AutoSize = True
        Me.Head_LB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Head_LB.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Head_LB.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Head_LB.Location = New System.Drawing.Point(79, 25)
        Me.Head_LB.Name = "Head_LB"
        Me.Head_LB.Size = New System.Drawing.Size(497, 13)
        Me.Head_LB.TabIndex = 37
        Me.Head_LB.Text = "If you already have information and want to update Please fill Sales ID and Click" & _
    " GET."
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Paymenttype_CB)
        Me.GroupBox1.Controls.Add(Me.Date_Sales)
        Me.GroupBox1.Controls.Add(Me.Datesales_LB)
        Me.GroupBox1.Controls.Add(Me.totalpurchaseprice_LB)
        Me.GroupBox1.Controls.Add(Me.Totalpurchaseprice_TB)
        Me.GroupBox1.Controls.Add(Me.Paymenttype_LB)
        Me.GroupBox1.Controls.Add(Me.Clear_BT)
        Me.GroupBox1.Controls.Add(Me.Delete_BT)
        Me.GroupBox1.Controls.Add(Me.Update_BT)
        Me.GroupBox1.Controls.Add(Me.GetData_BT)
        Me.GroupBox1.Controls.Add(Me.Add_BT)
        Me.GroupBox1.Controls.Add(Me.Amountpurchased_LB)
        Me.GroupBox1.Controls.Add(Me.Amountpurchased_TB)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Note_LB)
        Me.GroupBox1.Controls.Add(Me.salespriceperunit_LB)
        Me.GroupBox1.Controls.Add(Me.Buyer_LB)
        Me.GroupBox1.Controls.Add(Me.Productname_LB)
        Me.GroupBox1.Controls.Add(Me.Productid_LB)
        Me.GroupBox1.Controls.Add(Me.Seller_LB)
        Me.GroupBox1.Controls.Add(Me.SalesID_LB)
        Me.GroupBox1.Controls.Add(Me.Salepriceperunit_TB)
        Me.GroupBox1.Controls.Add(Me.Buyer_TB)
        Me.GroupBox1.Controls.Add(Me.Productname_TB)
        Me.GroupBox1.Controls.Add(Me.Productid_TB)
        Me.GroupBox1.Controls.Add(Me.Seller_TB)
        Me.GroupBox1.Controls.Add(Me.Salesid_TB)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(40, 46)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(452, 601)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add or Update Sales"
        '
        'Paymenttype_CB
        '
        Me.Paymenttype_CB.FormattingEnabled = True
        Me.Paymenttype_CB.Location = New System.Drawing.Point(184, 327)
        Me.Paymenttype_CB.Name = "Paymenttype_CB"
        Me.Paymenttype_CB.Size = New System.Drawing.Size(102, 21)
        Me.Paymenttype_CB.TabIndex = 67
        '
        'Date_Sales
        '
        Me.Date_Sales.CustomFormat = "dd-MM-yyyy"
        Me.Date_Sales.Font = New System.Drawing.Font("Arial Narrow", 8.25!)
        Me.Date_Sales.Location = New System.Drawing.Point(184, 421)
        Me.Date_Sales.Name = "Date_Sales"
        Me.Date_Sales.Size = New System.Drawing.Size(175, 20)
        Me.Date_Sales.TabIndex = 66
        Me.Date_Sales.Value = New Date(2020, 4, 9, 15, 11, 3, 0)
        '
        'Datesales_LB
        '
        Me.Datesales_LB.AutoSize = True
        Me.Datesales_LB.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Datesales_LB.Location = New System.Drawing.Point(103, 427)
        Me.Datesales_LB.Name = "Datesales_LB"
        Me.Datesales_LB.Size = New System.Drawing.Size(69, 13)
        Me.Datesales_LB.TabIndex = 65
        Me.Datesales_LB.Text = "Date of sales"
        '
        'totalpurchaseprice_LB
        '
        Me.totalpurchaseprice_LB.AutoSize = True
        Me.totalpurchaseprice_LB.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.totalpurchaseprice_LB.Location = New System.Drawing.Point(70, 378)
        Me.totalpurchaseprice_LB.Name = "totalpurchaseprice_LB"
        Me.totalpurchaseprice_LB.Size = New System.Drawing.Size(104, 13)
        Me.totalpurchaseprice_LB.TabIndex = 64
        Me.totalpurchaseprice_LB.Text = "Total purchase price"
        '
        'Totalpurchaseprice_TB
        '
        Me.Totalpurchaseprice_TB.Location = New System.Drawing.Point(184, 375)
        Me.Totalpurchaseprice_TB.Name = "Totalpurchaseprice_TB"
        Me.Totalpurchaseprice_TB.Size = New System.Drawing.Size(102, 20)
        Me.Totalpurchaseprice_TB.TabIndex = 63
        '
        'Paymenttype_LB
        '
        Me.Paymenttype_LB.AutoSize = True
        Me.Paymenttype_LB.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Paymenttype_LB.Location = New System.Drawing.Point(103, 330)
        Me.Paymenttype_LB.Name = "Paymenttype_LB"
        Me.Paymenttype_LB.Size = New System.Drawing.Size(71, 13)
        Me.Paymenttype_LB.TabIndex = 62
        Me.Paymenttype_LB.Text = "Payment type"
        '
        'Clear_BT
        '
        Me.Clear_BT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Clear_BT.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Clear_BT.Location = New System.Drawing.Point(319, 542)
        Me.Clear_BT.Name = "Clear_BT"
        Me.Clear_BT.Size = New System.Drawing.Size(70, 29)
        Me.Clear_BT.TabIndex = 60
        Me.Clear_BT.Text = "CLEAR"
        Me.Clear_BT.UseVisualStyleBackColor = True
        '
        'Delete_BT
        '
        Me.Delete_BT.BackColor = System.Drawing.Color.DarkRed
        Me.Delete_BT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Delete_BT.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Delete_BT.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Delete_BT.Location = New System.Drawing.Point(227, 542)
        Me.Delete_BT.Name = "Delete_BT"
        Me.Delete_BT.Size = New System.Drawing.Size(70, 29)
        Me.Delete_BT.TabIndex = 59
        Me.Delete_BT.Text = "DELETE"
        Me.Delete_BT.UseVisualStyleBackColor = False
        '
        'Update_BT
        '
        Me.Update_BT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Update_BT.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Update_BT.Location = New System.Drawing.Point(49, 542)
        Me.Update_BT.Name = "Update_BT"
        Me.Update_BT.Size = New System.Drawing.Size(70, 29)
        Me.Update_BT.TabIndex = 57
        Me.Update_BT.Text = "UPDATE"
        Me.Update_BT.UseVisualStyleBackColor = True
        '
        'GetData_BT
        '
        Me.GetData_BT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GetData_BT.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.GetData_BT.Location = New System.Drawing.Point(334, 30)
        Me.GetData_BT.Name = "GetData_BT"
        Me.GetData_BT.Size = New System.Drawing.Size(70, 29)
        Me.GetData_BT.TabIndex = 56
        Me.GetData_BT.Text = "GET"
        Me.GetData_BT.UseVisualStyleBackColor = True
        '
        'Add_BT
        '
        Me.Add_BT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Add_BT.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Add_BT.Location = New System.Drawing.Point(139, 542)
        Me.Add_BT.Name = "Add_BT"
        Me.Add_BT.Size = New System.Drawing.Size(70, 29)
        Me.Add_BT.TabIndex = 58
        Me.Add_BT.Text = "ADD"
        Me.Add_BT.UseVisualStyleBackColor = True
        '
        'Amountpurchased_LB
        '
        Me.Amountpurchased_LB.AutoSize = True
        Me.Amountpurchased_LB.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Amountpurchased_LB.Location = New System.Drawing.Point(79, 242)
        Me.Amountpurchased_LB.Name = "Amountpurchased_LB"
        Me.Amountpurchased_LB.Size = New System.Drawing.Size(96, 13)
        Me.Amountpurchased_LB.TabIndex = 55
        Me.Amountpurchased_LB.Text = "Amount purchased"
        '
        'Amountpurchased_TB
        '
        Me.Amountpurchased_TB.Location = New System.Drawing.Point(184, 239)
        Me.Amountpurchased_TB.Name = "Amountpurchased_TB"
        Me.Amountpurchased_TB.Size = New System.Drawing.Size(102, 20)
        Me.Amountpurchased_TB.TabIndex = 54
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(110, 29)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(11, 13)
        Me.Label10.TabIndex = 53
        Me.Label10.Text = "*"
        '
        'Note_LB
        '
        Me.Note_LB.AutoSize = True
        Me.Note_LB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Note_LB.ForeColor = System.Drawing.Color.Red
        Me.Note_LB.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Note_LB.Location = New System.Drawing.Point(73, 576)
        Me.Note_LB.Name = "Note_LB"
        Me.Note_LB.Size = New System.Drawing.Size(293, 13)
        Me.Note_LB.TabIndex = 52
        Me.Note_LB.Text = "Note * Indicates that information must be filled out completely"
        '
        'salespriceperunit_LB
        '
        Me.salespriceperunit_LB.AutoSize = True
        Me.salespriceperunit_LB.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.salespriceperunit_LB.Location = New System.Drawing.Point(78, 286)
        Me.salespriceperunit_LB.Name = "salespriceperunit_LB"
        Me.salespriceperunit_LB.Size = New System.Drawing.Size(97, 13)
        Me.salespriceperunit_LB.TabIndex = 34
        Me.salespriceperunit_LB.Text = "Sales price per unit"
        '
        'Buyer_LB
        '
        Me.Buyer_LB.AutoSize = True
        Me.Buyer_LB.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Buyer_LB.Location = New System.Drawing.Point(141, 202)
        Me.Buyer_LB.Name = "Buyer_LB"
        Me.Buyer_LB.Size = New System.Drawing.Size(34, 13)
        Me.Buyer_LB.TabIndex = 33
        Me.Buyer_LB.Text = "Buyer"
        '
        'Productname_LB
        '
        Me.Productname_LB.AutoSize = True
        Me.Productname_LB.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Productname_LB.Location = New System.Drawing.Point(103, 157)
        Me.Productname_LB.Name = "Productname_LB"
        Me.Productname_LB.Size = New System.Drawing.Size(75, 13)
        Me.Productname_LB.TabIndex = 32
        Me.Productname_LB.Text = "Product Name"
        '
        'Productid_LB
        '
        Me.Productid_LB.AutoSize = True
        Me.Productid_LB.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Productid_LB.Location = New System.Drawing.Point(117, 112)
        Me.Productid_LB.Name = "Productid_LB"
        Me.Productid_LB.Size = New System.Drawing.Size(58, 13)
        Me.Productid_LB.TabIndex = 31
        Me.Productid_LB.Text = "Product ID"
        '
        'Seller_LB
        '
        Me.Seller_LB.AutoSize = True
        Me.Seller_LB.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Seller_LB.Location = New System.Drawing.Point(142, 71)
        Me.Seller_LB.Name = "Seller_LB"
        Me.Seller_LB.Size = New System.Drawing.Size(33, 13)
        Me.Seller_LB.TabIndex = 30
        Me.Seller_LB.Text = "Seller"
        '
        'SalesID_LB
        '
        Me.SalesID_LB.AutoSize = True
        Me.SalesID_LB.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.SalesID_LB.Location = New System.Drawing.Point(128, 30)
        Me.SalesID_LB.Name = "SalesID_LB"
        Me.SalesID_LB.Size = New System.Drawing.Size(47, 13)
        Me.SalesID_LB.TabIndex = 28
        Me.SalesID_LB.Text = "Sales ID"
        '
        'Salepriceperunit_TB
        '
        Me.Salepriceperunit_TB.Location = New System.Drawing.Point(184, 283)
        Me.Salepriceperunit_TB.Name = "Salepriceperunit_TB"
        Me.Salepriceperunit_TB.Size = New System.Drawing.Size(102, 20)
        Me.Salepriceperunit_TB.TabIndex = 27
        '
        'Buyer_TB
        '
        Me.Buyer_TB.Location = New System.Drawing.Point(184, 199)
        Me.Buyer_TB.Name = "Buyer_TB"
        Me.Buyer_TB.Size = New System.Drawing.Size(102, 20)
        Me.Buyer_TB.TabIndex = 26
        '
        'Productname_TB
        '
        Me.Productname_TB.Location = New System.Drawing.Point(184, 154)
        Me.Productname_TB.Name = "Productname_TB"
        Me.Productname_TB.Size = New System.Drawing.Size(102, 20)
        Me.Productname_TB.TabIndex = 25
        '
        'Productid_TB
        '
        Me.Productid_TB.Location = New System.Drawing.Point(184, 109)
        Me.Productid_TB.Name = "Productid_TB"
        Me.Productid_TB.Size = New System.Drawing.Size(102, 20)
        Me.Productid_TB.TabIndex = 24
        '
        'Seller_TB
        '
        Me.Seller_TB.Location = New System.Drawing.Point(184, 68)
        Me.Seller_TB.Name = "Seller_TB"
        Me.Seller_TB.Size = New System.Drawing.Size(102, 20)
        Me.Seller_TB.TabIndex = 23
        '
        'Salesid_TB
        '
        Me.Salesid_TB.Location = New System.Drawing.Point(184, 26)
        Me.Salesid_TB.Name = "Salesid_TB"
        Me.Salesid_TB.Size = New System.Drawing.Size(102, 20)
        Me.Salesid_TB.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(300, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 20
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Search_TB)
        Me.GroupBox2.Controls.Add(Me.Showall_BT)
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(529, 45)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(707, 601)
        Me.GroupBox2.TabIndex = 35
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search for Sales"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(354, 37)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 13)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Search :"
        '
        'Search_TB
        '
        Me.Search_TB.Font = New System.Drawing.Font("Arial Narrow", 9.75!)
        Me.Search_TB.Location = New System.Drawing.Point(407, 32)
        Me.Search_TB.Name = "Search_TB"
        Me.Search_TB.Size = New System.Drawing.Size(209, 22)
        Me.Search_TB.TabIndex = 21
        '
        'Showall_BT
        '
        Me.Showall_BT.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Showall_BT.Location = New System.Drawing.Point(622, 32)
        Me.Showall_BT.Name = "Showall_BT"
        Me.Showall_BT.Size = New System.Drawing.Size(58, 24)
        Me.Showall_BT.TabIndex = 22
        Me.Showall_BT.Text = "Show all"
        Me.Showall_BT.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(28, 59)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(652, 496)
        Me.DataGridView1.TabIndex = 23
        '
        'Salesinfo_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1282, 703)
        Me.Controls.Add(Me.Salestinfo_Data)
        Me.Name = "Salesinfo_Form"
        Me.Text = "Sales Information"
        Me.Salestinfo_Data.ResumeLayout(False)
        Me.Salestinfo_Data.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Salestinfo_Data As System.Windows.Forms.GroupBox
    Friend WithEvents Head_LB As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Amountpurchased_LB As System.Windows.Forms.Label
    Friend WithEvents Amountpurchased_TB As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Note_LB As System.Windows.Forms.Label
    Friend WithEvents salespriceperunit_LB As System.Windows.Forms.Label
    Friend WithEvents Buyer_LB As System.Windows.Forms.Label
    Friend WithEvents Productname_LB As System.Windows.Forms.Label
    Friend WithEvents Productid_LB As System.Windows.Forms.Label
    Friend WithEvents Seller_LB As System.Windows.Forms.Label
    Friend WithEvents SalesID_LB As System.Windows.Forms.Label
    Friend WithEvents Salepriceperunit_TB As System.Windows.Forms.TextBox
    Friend WithEvents Buyer_TB As System.Windows.Forms.TextBox
    Friend WithEvents Productname_TB As System.Windows.Forms.TextBox
    Friend WithEvents Productid_TB As System.Windows.Forms.TextBox
    Friend WithEvents Seller_TB As System.Windows.Forms.TextBox
    Friend WithEvents Salesid_TB As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Search_TB As System.Windows.Forms.TextBox
    Friend WithEvents Showall_BT As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Clear_BT As System.Windows.Forms.Button
    Friend WithEvents Delete_BT As System.Windows.Forms.Button
    Friend WithEvents Update_BT As System.Windows.Forms.Button
    Friend WithEvents GetData_BT As System.Windows.Forms.Button
    Friend WithEvents Add_BT As System.Windows.Forms.Button
    Friend WithEvents totalpurchaseprice_LB As System.Windows.Forms.Label
    Friend WithEvents Totalpurchaseprice_TB As System.Windows.Forms.TextBox
    Friend WithEvents Paymenttype_LB As System.Windows.Forms.Label
    Friend WithEvents Datesales_LB As System.Windows.Forms.Label
    Friend WithEvents Date_Sales As System.Windows.Forms.DateTimePicker
    Friend WithEvents Paymenttype_CB As System.Windows.Forms.ComboBox
End Class
