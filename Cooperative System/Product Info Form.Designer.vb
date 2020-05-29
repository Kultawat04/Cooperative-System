<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Productinfo_Form
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
        Me.Productinfo_Data = New System.Windows.Forms.GroupBox()
        Me.Head_LB = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Note_LB = New System.Windows.Forms.Label()
        Me.Clear_BT = New System.Windows.Forms.Button()
        Me.Delete_BT = New System.Windows.Forms.Button()
        Me.Update_BT = New System.Windows.Forms.Button()
        Me.GetData_BT = New System.Windows.Forms.Button()
        Me.Add_BT = New System.Windows.Forms.Button()
        Me.Balances_LB = New System.Windows.Forms.Label()
        Me.Sales_LB = New System.Windows.Forms.Label()
        Me.Cost_LB = New System.Windows.Forms.Label()
        Me.Unit_LB = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ProductID_LB = New System.Windows.Forms.Label()
        Me.Balances_TB = New System.Windows.Forms.TextBox()
        Me.Salesprice_TB = New System.Windows.Forms.TextBox()
        Me.Costprice_TB = New System.Windows.Forms.TextBox()
        Me.Unitcounting_TB = New System.Windows.Forms.TextBox()
        Me.Productname_TB = New System.Windows.Forms.TextBox()
        Me.Productid_TB = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Search_TB = New System.Windows.Forms.TextBox()
        Me.Showall_BT = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Total_TB = New System.Windows.Forms.TextBox()
        Me.Total_LB = New System.Windows.Forms.Label()
        Me.Productinfo_Data.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Productinfo_Data
        '
        Me.Productinfo_Data.Controls.Add(Me.Head_LB)
        Me.Productinfo_Data.Controls.Add(Me.GroupBox1)
        Me.Productinfo_Data.Controls.Add(Me.GroupBox2)
        Me.Productinfo_Data.Location = New System.Drawing.Point(15, 7)
        Me.Productinfo_Data.Name = "Productinfo_Data"
        Me.Productinfo_Data.Size = New System.Drawing.Size(1254, 676)
        Me.Productinfo_Data.TabIndex = 36
        Me.Productinfo_Data.TabStop = False
        Me.Productinfo_Data.Text = "Product info"
        '
        'Head_LB
        '
        Me.Head_LB.AutoSize = True
        Me.Head_LB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Head_LB.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Head_LB.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Head_LB.Location = New System.Drawing.Point(79, 25)
        Me.Head_LB.Name = "Head_LB"
        Me.Head_LB.Size = New System.Drawing.Size(510, 13)
        Me.Head_LB.TabIndex = 37
        Me.Head_LB.Text = "If you already have information and want to update Please fill Product ID and Cli" & _
    "ck GET."
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Total_LB)
        Me.GroupBox1.Controls.Add(Me.Total_TB)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Note_LB)
        Me.GroupBox1.Controls.Add(Me.Clear_BT)
        Me.GroupBox1.Controls.Add(Me.Delete_BT)
        Me.GroupBox1.Controls.Add(Me.Update_BT)
        Me.GroupBox1.Controls.Add(Me.GetData_BT)
        Me.GroupBox1.Controls.Add(Me.Add_BT)
        Me.GroupBox1.Controls.Add(Me.Balances_LB)
        Me.GroupBox1.Controls.Add(Me.Sales_LB)
        Me.GroupBox1.Controls.Add(Me.Cost_LB)
        Me.GroupBox1.Controls.Add(Me.Unit_LB)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ProductID_LB)
        Me.GroupBox1.Controls.Add(Me.Balances_TB)
        Me.GroupBox1.Controls.Add(Me.Salesprice_TB)
        Me.GroupBox1.Controls.Add(Me.Costprice_TB)
        Me.GroupBox1.Controls.Add(Me.Unitcounting_TB)
        Me.GroupBox1.Controls.Add(Me.Productname_TB)
        Me.GroupBox1.Controls.Add(Me.Productid_TB)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(40, 46)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(452, 601)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add or Update Product"
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
        Me.Note_LB.Location = New System.Drawing.Point(73, 572)
        Me.Note_LB.Name = "Note_LB"
        Me.Note_LB.Size = New System.Drawing.Size(293, 13)
        Me.Note_LB.TabIndex = 52
        Me.Note_LB.Text = "Note * Indicates that information must be filled out completely"
        '
        'Clear_BT
        '
        Me.Clear_BT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Clear_BT.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Clear_BT.Location = New System.Drawing.Point(319, 528)
        Me.Clear_BT.Name = "Clear_BT"
        Me.Clear_BT.Size = New System.Drawing.Size(70, 29)
        Me.Clear_BT.TabIndex = 51
        Me.Clear_BT.Text = "CLEAR"
        Me.Clear_BT.UseVisualStyleBackColor = True
        '
        'Delete_BT
        '
        Me.Delete_BT.BackColor = System.Drawing.Color.DarkRed
        Me.Delete_BT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Delete_BT.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Delete_BT.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Delete_BT.Location = New System.Drawing.Point(227, 528)
        Me.Delete_BT.Name = "Delete_BT"
        Me.Delete_BT.Size = New System.Drawing.Size(70, 29)
        Me.Delete_BT.TabIndex = 50
        Me.Delete_BT.Text = "DELETE"
        Me.Delete_BT.UseVisualStyleBackColor = False
        '
        'Update_BT
        '
        Me.Update_BT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Update_BT.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Update_BT.Location = New System.Drawing.Point(49, 528)
        Me.Update_BT.Name = "Update_BT"
        Me.Update_BT.Size = New System.Drawing.Size(70, 29)
        Me.Update_BT.TabIndex = 48
        Me.Update_BT.Text = "UPDATE"
        Me.Update_BT.UseVisualStyleBackColor = True
        '
        'GetData_BT
        '
        Me.GetData_BT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GetData_BT.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.GetData_BT.Location = New System.Drawing.Point(334, 16)
        Me.GetData_BT.Name = "GetData_BT"
        Me.GetData_BT.Size = New System.Drawing.Size(70, 29)
        Me.GetData_BT.TabIndex = 47
        Me.GetData_BT.Text = "GET"
        Me.GetData_BT.UseVisualStyleBackColor = True
        '
        'Add_BT
        '
        Me.Add_BT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Add_BT.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Add_BT.Location = New System.Drawing.Point(139, 528)
        Me.Add_BT.Name = "Add_BT"
        Me.Add_BT.Size = New System.Drawing.Size(70, 29)
        Me.Add_BT.TabIndex = 49
        Me.Add_BT.Text = "ADD"
        Me.Add_BT.UseVisualStyleBackColor = True
        '
        'Balances_LB
        '
        Me.Balances_LB.AutoSize = True
        Me.Balances_LB.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Balances_LB.Location = New System.Drawing.Point(124, 290)
        Me.Balances_LB.Name = "Balances_LB"
        Me.Balances_LB.Size = New System.Drawing.Size(51, 13)
        Me.Balances_LB.TabIndex = 34
        Me.Balances_LB.Text = "Balances"
        '
        'Sales_LB
        '
        Me.Sales_LB.AutoSize = True
        Me.Sales_LB.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Sales_LB.Location = New System.Drawing.Point(119, 206)
        Me.Sales_LB.Name = "Sales_LB"
        Me.Sales_LB.Size = New System.Drawing.Size(59, 13)
        Me.Sales_LB.TabIndex = 33
        Me.Sales_LB.Text = "Sales price"
        '
        'Cost_LB
        '
        Me.Cost_LB.AutoSize = True
        Me.Cost_LB.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Cost_LB.Location = New System.Drawing.Point(124, 161)
        Me.Cost_LB.Name = "Cost_LB"
        Me.Cost_LB.Size = New System.Drawing.Size(54, 13)
        Me.Cost_LB.TabIndex = 32
        Me.Cost_LB.Text = "Cost price"
        '
        'Unit_LB
        '
        Me.Unit_LB.AutoSize = True
        Me.Unit_LB.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Unit_LB.Location = New System.Drawing.Point(96, 116)
        Me.Unit_LB.Name = "Unit_LB"
        Me.Unit_LB.Size = New System.Drawing.Size(82, 13)
        Me.Unit_LB.TabIndex = 31
        Me.Unit_LB.Text = "Unit of counting"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(103, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Product Name"
        '
        'ProductID_LB
        '
        Me.ProductID_LB.AutoSize = True
        Me.ProductID_LB.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ProductID_LB.Location = New System.Drawing.Point(120, 33)
        Me.ProductID_LB.Name = "ProductID_LB"
        Me.ProductID_LB.Size = New System.Drawing.Size(58, 13)
        Me.ProductID_LB.TabIndex = 28
        Me.ProductID_LB.Text = "Product ID"
        '
        'Balances_TB
        '
        Me.Balances_TB.Location = New System.Drawing.Point(184, 283)
        Me.Balances_TB.Name = "Balances_TB"
        Me.Balances_TB.Size = New System.Drawing.Size(102, 20)
        Me.Balances_TB.TabIndex = 27
        '
        'Salesprice_TB
        '
        Me.Salesprice_TB.Location = New System.Drawing.Point(184, 199)
        Me.Salesprice_TB.Name = "Salesprice_TB"
        Me.Salesprice_TB.Size = New System.Drawing.Size(102, 20)
        Me.Salesprice_TB.TabIndex = 26
        '
        'Costprice_TB
        '
        Me.Costprice_TB.Location = New System.Drawing.Point(184, 154)
        Me.Costprice_TB.Name = "Costprice_TB"
        Me.Costprice_TB.Size = New System.Drawing.Size(102, 20)
        Me.Costprice_TB.TabIndex = 25
        '
        'Unitcounting_TB
        '
        Me.Unitcounting_TB.Location = New System.Drawing.Point(184, 109)
        Me.Unitcounting_TB.Name = "Unitcounting_TB"
        Me.Unitcounting_TB.Size = New System.Drawing.Size(102, 20)
        Me.Unitcounting_TB.TabIndex = 24
        '
        'Productname_TB
        '
        Me.Productname_TB.Location = New System.Drawing.Point(184, 68)
        Me.Productname_TB.Name = "Productname_TB"
        Me.Productname_TB.Size = New System.Drawing.Size(102, 20)
        Me.Productname_TB.TabIndex = 23
        '
        'Productid_TB
        '
        Me.Productid_TB.Location = New System.Drawing.Point(184, 26)
        Me.Productid_TB.Name = "Productid_TB"
        Me.Productid_TB.Size = New System.Drawing.Size(102, 20)
        Me.Productid_TB.TabIndex = 21
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
        Me.GroupBox2.Text = "Search for Product"
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
        'Total_TB
        '
        Me.Total_TB.Location = New System.Drawing.Point(184, 239)
        Me.Total_TB.Name = "Total_TB"
        Me.Total_TB.Size = New System.Drawing.Size(102, 20)
        Me.Total_TB.TabIndex = 54
        '
        'Total_LB
        '
        Me.Total_LB.AutoSize = True
        Me.Total_LB.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Total_LB.Location = New System.Drawing.Point(144, 246)
        Me.Total_LB.Name = "Total_LB"
        Me.Total_LB.Size = New System.Drawing.Size(31, 13)
        Me.Total_LB.TabIndex = 55
        Me.Total_LB.Text = "Total"
        '
        'Productinfo_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.ClientSize = New System.Drawing.Size(1282, 703)
        Me.Controls.Add(Me.Productinfo_Data)
        Me.Name = "Productinfo_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Product Infomation"
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Productinfo_Data.ResumeLayout(False)
        Me.Productinfo_Data.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Productinfo_Data As System.Windows.Forms.GroupBox
    Friend WithEvents Balances_LB As System.Windows.Forms.Label
    Friend WithEvents Sales_LB As System.Windows.Forms.Label
    Friend WithEvents Cost_LB As System.Windows.Forms.Label
    Friend WithEvents Unit_LB As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ProductID_LB As System.Windows.Forms.Label
    Friend WithEvents Balances_TB As System.Windows.Forms.TextBox
    Friend WithEvents Salesprice_TB As System.Windows.Forms.TextBox
    Friend WithEvents Costprice_TB As System.Windows.Forms.TextBox
    Friend WithEvents Unitcounting_TB As System.Windows.Forms.TextBox
    Friend WithEvents Productname_TB As System.Windows.Forms.TextBox
    Friend WithEvents Productid_TB As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Search_TB As System.Windows.Forms.TextBox
    Friend WithEvents Showall_BT As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Head_LB As System.Windows.Forms.Label
    Friend WithEvents Note_LB As System.Windows.Forms.Label
    Friend WithEvents Clear_BT As System.Windows.Forms.Button
    Friend WithEvents Delete_BT As System.Windows.Forms.Button
    Friend WithEvents Update_BT As System.Windows.Forms.Button
    Friend WithEvents GetData_BT As System.Windows.Forms.Button
    Friend WithEvents Add_BT As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Total_LB As System.Windows.Forms.Label
    Friend WithEvents Total_TB As System.Windows.Forms.TextBox
End Class
