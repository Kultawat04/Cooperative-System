<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Member_Form
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
        Me.Member_Data = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Search_TB = New System.Windows.Forms.TextBox()
        Me.Showall_BT = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Personalinfo_LB = New System.Windows.Forms.GroupBox()
        Me.Zipcode_TB = New System.Windows.Forms.TextBox()
        Me.Province_CB = New System.Windows.Forms.ComboBox()
        Me.Subdistrict_CB = New System.Windows.Forms.ComboBox()
        Me.District_CB = New System.Windows.Forms.ComboBox()
        Me.Zipcode_LB = New System.Windows.Forms.Label()
        Me.Province_LB = New System.Windows.Forms.Label()
        Me.District_LB = New System.Windows.Forms.Label()
        Me.Subdistrict_LB = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Address_TB = New System.Windows.Forms.TextBox()
        Me.Tel_TB = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Address_LB = New System.Windows.Forms.Label()
        Me.MemberID_TB = New System.Windows.Forms.TextBox()
        Me.Member_LB = New System.Windows.Forms.Label()
        Me.Date_Birth = New System.Windows.Forms.DateTimePicker()
        Me.GetData_BT = New System.Windows.Forms.Button()
        Me.Age_TB = New System.Windows.Forms.TextBox()
        Me.LastN_TB = New System.Windows.Forms.TextBox()
        Me.FirstN_TB = New System.Windows.Forms.TextBox()
        Me.IDCard_TB = New System.Windows.Forms.TextBox()
        Me.Famale_RB = New System.Windows.Forms.RadioButton()
        Me.Male_RB = New System.Windows.Forms.RadioButton()
        Me.Datebirth_LB = New System.Windows.Forms.Label()
        Me.Depart_LB = New System.Windows.Forms.Label()
        Me.Gender_LB = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.IDCard_LB = New System.Windows.Forms.Label()
        Me.LastN_LB = New System.Windows.Forms.Label()
        Me.FirstN_LB = New System.Windows.Forms.Label()
        Me.Depart_CB = New System.Windows.Forms.ComboBox()
        Me.Data2 = New System.Windows.Forms.GroupBox()
        Me.Typeloan_LB = New System.Windows.Forms.Label()
        Me.Typeloan_TB = New System.Windows.Forms.TextBox()
        Me.Cooperativeloan_TB = New System.Windows.Forms.TextBox()
        Me.Cooperativeloan_LB = New System.Windows.Forms.Label()
        Me.Libilities_TB = New System.Windows.Forms.TextBox()
        Me.Liabilities_LB = New System.Windows.Forms.Label()
        Me.DailyMonthly_LB = New System.Windows.Forms.Label()
        Me.DailyMonthly_CB = New System.Windows.Forms.ComboBox()
        Me.Income_LB = New System.Windows.Forms.Label()
        Me.Income_TB = New System.Windows.Forms.TextBox()
        Me.Numbershare_TB = New System.Windows.Forms.TextBox()
        Me.Investment_TB = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Investment_LB = New System.Windows.Forms.Label()
        Me.Date_Member = New System.Windows.Forms.DateTimePicker()
        Me.DateMember_LB = New System.Windows.Forms.Label()
        Me.Note_LB = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Clear_BT = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Delete_BT = New System.Windows.Forms.Button()
        Me.Update_BT = New System.Windows.Forms.Button()
        Me.Add_BT = New System.Windows.Forms.Button()
        Me.Head_LB = New System.Windows.Forms.Label()
        Me.Member_Data.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Personalinfo_LB.SuspendLayout()
        Me.Data2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Member_Data
        '
        Me.Member_Data.Controls.Add(Me.GroupBox2)
        Me.Member_Data.Controls.Add(Me.GroupBox1)
        Me.Member_Data.Controls.Add(Me.Head_LB)
        Me.Member_Data.Location = New System.Drawing.Point(14, 15)
        Me.Member_Data.Name = "Member_Data"
        Me.Member_Data.Size = New System.Drawing.Size(1254, 676)
        Me.Member_Data.TabIndex = 34
        Me.Member_Data.TabStop = False
        Me.Member_Data.Text = "Member"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Search_TB)
        Me.GroupBox2.Controls.Add(Me.Showall_BT)
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(524, 50)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(707, 601)
        Me.GroupBox2.TabIndex = 33
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search for Member"
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Personalinfo_LB)
        Me.GroupBox1.Controls.Add(Me.Data2)
        Me.GroupBox1.Controls.Add(Me.Note_LB)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Clear_BT)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Delete_BT)
        Me.GroupBox1.Controls.Add(Me.Update_BT)
        Me.GroupBox1.Controls.Add(Me.Add_BT)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(480, 601)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add or Update Member"
        '
        'Personalinfo_LB
        '
        Me.Personalinfo_LB.Controls.Add(Me.Zipcode_TB)
        Me.Personalinfo_LB.Controls.Add(Me.Province_CB)
        Me.Personalinfo_LB.Controls.Add(Me.Subdistrict_CB)
        Me.Personalinfo_LB.Controls.Add(Me.District_CB)
        Me.Personalinfo_LB.Controls.Add(Me.Zipcode_LB)
        Me.Personalinfo_LB.Controls.Add(Me.Province_LB)
        Me.Personalinfo_LB.Controls.Add(Me.District_LB)
        Me.Personalinfo_LB.Controls.Add(Me.Subdistrict_LB)
        Me.Personalinfo_LB.Controls.Add(Me.Label10)
        Me.Personalinfo_LB.Controls.Add(Me.Label9)
        Me.Personalinfo_LB.Controls.Add(Me.Address_TB)
        Me.Personalinfo_LB.Controls.Add(Me.Tel_TB)
        Me.Personalinfo_LB.Controls.Add(Me.Label5)
        Me.Personalinfo_LB.Controls.Add(Me.Address_LB)
        Me.Personalinfo_LB.Controls.Add(Me.MemberID_TB)
        Me.Personalinfo_LB.Controls.Add(Me.Member_LB)
        Me.Personalinfo_LB.Controls.Add(Me.Date_Birth)
        Me.Personalinfo_LB.Controls.Add(Me.GetData_BT)
        Me.Personalinfo_LB.Controls.Add(Me.Age_TB)
        Me.Personalinfo_LB.Controls.Add(Me.LastN_TB)
        Me.Personalinfo_LB.Controls.Add(Me.FirstN_TB)
        Me.Personalinfo_LB.Controls.Add(Me.IDCard_TB)
        Me.Personalinfo_LB.Controls.Add(Me.Famale_RB)
        Me.Personalinfo_LB.Controls.Add(Me.Male_RB)
        Me.Personalinfo_LB.Controls.Add(Me.Datebirth_LB)
        Me.Personalinfo_LB.Controls.Add(Me.Depart_LB)
        Me.Personalinfo_LB.Controls.Add(Me.Gender_LB)
        Me.Personalinfo_LB.Controls.Add(Me.Label4)
        Me.Personalinfo_LB.Controls.Add(Me.IDCard_LB)
        Me.Personalinfo_LB.Controls.Add(Me.LastN_LB)
        Me.Personalinfo_LB.Controls.Add(Me.FirstN_LB)
        Me.Personalinfo_LB.Controls.Add(Me.Depart_CB)
        Me.Personalinfo_LB.Location = New System.Drawing.Point(6, 27)
        Me.Personalinfo_LB.Name = "Personalinfo_LB"
        Me.Personalinfo_LB.Size = New System.Drawing.Size(468, 312)
        Me.Personalinfo_LB.TabIndex = 73
        Me.Personalinfo_LB.TabStop = False
        Me.Personalinfo_LB.Text = "Personal Information"
        '
        'Zipcode_TB
        '
        Me.Zipcode_TB.Font = New System.Drawing.Font("Arial Narrow", 9.75!)
        Me.Zipcode_TB.Location = New System.Drawing.Point(141, 253)
        Me.Zipcode_TB.Name = "Zipcode_TB"
        Me.Zipcode_TB.Size = New System.Drawing.Size(47, 22)
        Me.Zipcode_TB.TabIndex = 65
        '
        'Province_CB
        '
        Me.Province_CB.FormattingEnabled = True
        Me.Province_CB.Location = New System.Drawing.Point(333, 200)
        Me.Province_CB.Name = "Province_CB"
        Me.Province_CB.Size = New System.Drawing.Size(126, 21)
        Me.Province_CB.TabIndex = 64
        '
        'Subdistrict_CB
        '
        Me.Subdistrict_CB.FormattingEnabled = True
        Me.Subdistrict_CB.Location = New System.Drawing.Point(140, 227)
        Me.Subdistrict_CB.Name = "Subdistrict_CB"
        Me.Subdistrict_CB.Size = New System.Drawing.Size(137, 21)
        Me.Subdistrict_CB.TabIndex = 63
        '
        'District_CB
        '
        Me.District_CB.FormattingEnabled = True
        Me.District_CB.Location = New System.Drawing.Point(333, 227)
        Me.District_CB.Name = "District_CB"
        Me.District_CB.Size = New System.Drawing.Size(126, 21)
        Me.District_CB.TabIndex = 61
        '
        'Zipcode_LB
        '
        Me.Zipcode_LB.AutoSize = True
        Me.Zipcode_LB.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Zipcode_LB.Location = New System.Drawing.Point(83, 262)
        Me.Zipcode_LB.Name = "Zipcode_LB"
        Me.Zipcode_LB.Size = New System.Drawing.Size(46, 13)
        Me.Zipcode_LB.TabIndex = 59
        Me.Zipcode_LB.Text = "Zipcode"
        '
        'Province_LB
        '
        Me.Province_LB.AutoSize = True
        Me.Province_LB.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Province_LB.Location = New System.Drawing.Point(283, 208)
        Me.Province_LB.Name = "Province_LB"
        Me.Province_LB.Size = New System.Drawing.Size(49, 13)
        Me.Province_LB.TabIndex = 57
        Me.Province_LB.Text = "Province"
        '
        'District_LB
        '
        Me.District_LB.AutoSize = True
        Me.District_LB.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.District_LB.Location = New System.Drawing.Point(293, 235)
        Me.District_LB.Name = "District_LB"
        Me.District_LB.Size = New System.Drawing.Size(39, 13)
        Me.District_LB.TabIndex = 56
        Me.District_LB.Text = "District"
        '
        'Subdistrict_LB
        '
        Me.Subdistrict_LB.AutoSize = True
        Me.Subdistrict_LB.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Subdistrict_LB.Location = New System.Drawing.Point(79, 235)
        Me.Subdistrict_LB.Name = "Subdistrict_LB"
        Me.Subdistrict_LB.Size = New System.Drawing.Size(56, 13)
        Me.Subdistrict_LB.TabIndex = 55
        Me.Subdistrict_LB.Text = "Subdistrict"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(65, 18)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(11, 13)
        Me.Label10.TabIndex = 48
        Me.Label10.Text = "*"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(83, 46)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(11, 13)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "*"
        '
        'Address_TB
        '
        Me.Address_TB.Font = New System.Drawing.Font("Arial Narrow", 9.75!)
        Me.Address_TB.Location = New System.Drawing.Point(140, 200)
        Me.Address_TB.Name = "Address_TB"
        Me.Address_TB.Size = New System.Drawing.Size(137, 22)
        Me.Address_TB.TabIndex = 9
        '
        'Tel_TB
        '
        Me.Tel_TB.Font = New System.Drawing.Font("Arial Narrow", 9.75!)
        Me.Tel_TB.Location = New System.Drawing.Point(140, 281)
        Me.Tel_TB.Name = "Tel_TB"
        Me.Tel_TB.Size = New System.Drawing.Size(102, 22)
        Me.Tel_TB.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(109, 290)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 13)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Tel."
        '
        'Address_LB
        '
        Me.Address_LB.AutoSize = True
        Me.Address_LB.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Address_LB.Location = New System.Drawing.Point(89, 209)
        Me.Address_LB.Name = "Address_LB"
        Me.Address_LB.Size = New System.Drawing.Size(45, 13)
        Me.Address_LB.TabIndex = 31
        Me.Address_LB.Text = "Address"
        '
        'MemberID_TB
        '
        Me.MemberID_TB.Font = New System.Drawing.Font("Arial Narrow", 9.75!)
        Me.MemberID_TB.Location = New System.Drawing.Point(140, 12)
        Me.MemberID_TB.Name = "MemberID_TB"
        Me.MemberID_TB.Size = New System.Drawing.Size(102, 22)
        Me.MemberID_TB.TabIndex = 1
        '
        'Member_LB
        '
        Me.Member_LB.AutoSize = True
        Me.Member_LB.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Member_LB.Location = New System.Drawing.Point(75, 21)
        Me.Member_LB.Name = "Member_LB"
        Me.Member_LB.Size = New System.Drawing.Size(59, 13)
        Me.Member_LB.TabIndex = 26
        Me.Member_LB.Text = "Member ID"
        '
        'Date_Birth
        '
        Me.Date_Birth.CustomFormat = "dd-MM-yyyy"
        Me.Date_Birth.Font = New System.Drawing.Font("Arial Narrow", 8.25!)
        Me.Date_Birth.Location = New System.Drawing.Point(140, 118)
        Me.Date_Birth.Name = "Date_Birth"
        Me.Date_Birth.Size = New System.Drawing.Size(175, 20)
        Me.Date_Birth.TabIndex = 14
        Me.Date_Birth.Value = New Date(2020, 4, 9, 15, 11, 3, 0)
        '
        'GetData_BT
        '
        Me.GetData_BT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GetData_BT.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.GetData_BT.Location = New System.Drawing.Point(248, 8)
        Me.GetData_BT.Name = "GetData_BT"
        Me.GetData_BT.Size = New System.Drawing.Size(49, 27)
        Me.GetData_BT.TabIndex = 16
        Me.GetData_BT.Text = "GET"
        Me.GetData_BT.UseVisualStyleBackColor = True
        '
        'Age_TB
        '
        Me.Age_TB.Enabled = False
        Me.Age_TB.Font = New System.Drawing.Font("Arial Narrow", 9.75!)
        Me.Age_TB.Location = New System.Drawing.Point(140, 145)
        Me.Age_TB.Name = "Age_TB"
        Me.Age_TB.Size = New System.Drawing.Size(48, 22)
        Me.Age_TB.TabIndex = 8
        '
        'LastN_TB
        '
        Me.LastN_TB.Font = New System.Drawing.Font("Arial Narrow", 9.75!)
        Me.LastN_TB.Location = New System.Drawing.Point(308, 65)
        Me.LastN_TB.Name = "LastN_TB"
        Me.LastN_TB.Size = New System.Drawing.Size(102, 22)
        Me.LastN_TB.TabIndex = 5
        '
        'FirstN_TB
        '
        Me.FirstN_TB.Font = New System.Drawing.Font("Arial Narrow", 9.75!)
        Me.FirstN_TB.Location = New System.Drawing.Point(140, 65)
        Me.FirstN_TB.Name = "FirstN_TB"
        Me.FirstN_TB.Size = New System.Drawing.Size(102, 22)
        Me.FirstN_TB.TabIndex = 4
        '
        'IDCard_TB
        '
        Me.IDCard_TB.Font = New System.Drawing.Font("Arial Narrow", 9.75!)
        Me.IDCard_TB.Location = New System.Drawing.Point(140, 38)
        Me.IDCard_TB.Name = "IDCard_TB"
        Me.IDCard_TB.Size = New System.Drawing.Size(157, 22)
        Me.IDCard_TB.TabIndex = 3
        '
        'Famale_RB
        '
        Me.Famale_RB.AutoSize = True
        Me.Famale_RB.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Famale_RB.Location = New System.Drawing.Point(194, 96)
        Me.Famale_RB.Name = "Famale_RB"
        Me.Famale_RB.Size = New System.Drawing.Size(59, 17)
        Me.Famale_RB.TabIndex = 7
        Me.Famale_RB.Text = "Famale"
        Me.Famale_RB.UseVisualStyleBackColor = True
        '
        'Male_RB
        '
        Me.Male_RB.AutoSize = True
        Me.Male_RB.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Male_RB.Location = New System.Drawing.Point(140, 96)
        Me.Male_RB.Name = "Male_RB"
        Me.Male_RB.Size = New System.Drawing.Size(48, 17)
        Me.Male_RB.TabIndex = 6
        Me.Male_RB.Text = "Male"
        Me.Male_RB.UseVisualStyleBackColor = True
        '
        'Datebirth_LB
        '
        Me.Datebirth_LB.AutoSize = True
        Me.Datebirth_LB.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Datebirth_LB.Location = New System.Drawing.Point(68, 124)
        Me.Datebirth_LB.Name = "Datebirth_LB"
        Me.Datebirth_LB.Size = New System.Drawing.Size(66, 13)
        Me.Datebirth_LB.TabIndex = 7
        Me.Datebirth_LB.Text = "Date of Birth"
        '
        'Depart_LB
        '
        Me.Depart_LB.AutoSize = True
        Me.Depart_LB.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Depart_LB.Location = New System.Drawing.Point(72, 182)
        Me.Depart_LB.Name = "Depart_LB"
        Me.Depart_LB.Size = New System.Drawing.Size(62, 13)
        Me.Depart_LB.TabIndex = 6
        Me.Depart_LB.Text = "Department"
        '
        'Gender_LB
        '
        Me.Gender_LB.AutoSize = True
        Me.Gender_LB.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Gender_LB.Location = New System.Drawing.Point(92, 98)
        Me.Gender_LB.Name = "Gender_LB"
        Me.Gender_LB.Size = New System.Drawing.Size(42, 13)
        Me.Gender_LB.TabIndex = 5
        Me.Gender_LB.Text = "Gender"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(78, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Age(years)"
        '
        'IDCard_LB
        '
        Me.IDCard_LB.AutoSize = True
        Me.IDCard_LB.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.IDCard_LB.Location = New System.Drawing.Point(92, 47)
        Me.IDCard_LB.Name = "IDCard_LB"
        Me.IDCard_LB.Size = New System.Drawing.Size(43, 13)
        Me.IDCard_LB.TabIndex = 3
        Me.IDCard_LB.Text = "ID Card"
        '
        'LastN_LB
        '
        Me.LastN_LB.AutoSize = True
        Me.LastN_LB.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LastN_LB.Location = New System.Drawing.Point(248, 74)
        Me.LastN_LB.Name = "LastN_LB"
        Me.LastN_LB.Size = New System.Drawing.Size(58, 13)
        Me.LastN_LB.TabIndex = 2
        Me.LastN_LB.Text = "Last Name"
        '
        'FirstN_LB
        '
        Me.FirstN_LB.AutoSize = True
        Me.FirstN_LB.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.FirstN_LB.Location = New System.Drawing.Point(77, 74)
        Me.FirstN_LB.Name = "FirstN_LB"
        Me.FirstN_LB.Size = New System.Drawing.Size(57, 13)
        Me.FirstN_LB.TabIndex = 1
        Me.FirstN_LB.Text = "First Name"
        '
        'Depart_CB
        '
        Me.Depart_CB.Font = New System.Drawing.Font("Arial Narrow", 9.75!)
        Me.Depart_CB.FormattingEnabled = True
        Me.Depart_CB.Items.AddRange(New Object() {"Accounting", "Bussiness-Deverlopment", "HR", "IT", "Management", "Maintenance", "Production-Technology", "Marketing", "Purchasing", "QC", "QMS", "RD", "Safety-Enviroment", "Store", "Logistic", "Production", "Planning", "Internal-Audit", "Factory-Management"})
        Me.Depart_CB.Location = New System.Drawing.Point(139, 171)
        Me.Depart_CB.Name = "Depart_CB"
        Me.Depart_CB.Size = New System.Drawing.Size(175, 24)
        Me.Depart_CB.TabIndex = 13
        Me.Depart_CB.Text = " "
        '
        'Data2
        '
        Me.Data2.Controls.Add(Me.Typeloan_LB)
        Me.Data2.Controls.Add(Me.Typeloan_TB)
        Me.Data2.Controls.Add(Me.Cooperativeloan_TB)
        Me.Data2.Controls.Add(Me.Cooperativeloan_LB)
        Me.Data2.Controls.Add(Me.Libilities_TB)
        Me.Data2.Controls.Add(Me.Liabilities_LB)
        Me.Data2.Controls.Add(Me.DailyMonthly_LB)
        Me.Data2.Controls.Add(Me.DailyMonthly_CB)
        Me.Data2.Controls.Add(Me.Income_LB)
        Me.Data2.Controls.Add(Me.Income_TB)
        Me.Data2.Controls.Add(Me.Numbershare_TB)
        Me.Data2.Controls.Add(Me.Investment_TB)
        Me.Data2.Controls.Add(Me.Label6)
        Me.Data2.Controls.Add(Me.Investment_LB)
        Me.Data2.Controls.Add(Me.Date_Member)
        Me.Data2.Controls.Add(Me.DateMember_LB)
        Me.Data2.Location = New System.Drawing.Point(6, 349)
        Me.Data2.Name = "Data2"
        Me.Data2.Size = New System.Drawing.Size(468, 172)
        Me.Data2.TabIndex = 72
        Me.Data2.TabStop = False
        Me.Data2.Text = "Cooperative Infomation"
        '
        'Typeloan_LB
        '
        Me.Typeloan_LB.AutoSize = True
        Me.Typeloan_LB.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Typeloan_LB.Location = New System.Drawing.Point(63, 100)
        Me.Typeloan_LB.Name = "Typeloan_LB"
        Me.Typeloan_LB.Size = New System.Drawing.Size(70, 13)
        Me.Typeloan_LB.TabIndex = 73
        Me.Typeloan_LB.Text = "Type of Loan"
        '
        'Typeloan_TB
        '
        Me.Typeloan_TB.Font = New System.Drawing.Font("Arial Narrow", 9.75!)
        Me.Typeloan_TB.Location = New System.Drawing.Point(140, 93)
        Me.Typeloan_TB.Name = "Typeloan_TB"
        Me.Typeloan_TB.Size = New System.Drawing.Size(102, 22)
        Me.Typeloan_TB.TabIndex = 72
        '
        'Cooperativeloan_TB
        '
        Me.Cooperativeloan_TB.Font = New System.Drawing.Font("Arial Narrow", 9.75!)
        Me.Cooperativeloan_TB.Location = New System.Drawing.Point(140, 118)
        Me.Cooperativeloan_TB.Name = "Cooperativeloan_TB"
        Me.Cooperativeloan_TB.Size = New System.Drawing.Size(102, 22)
        Me.Cooperativeloan_TB.TabIndex = 71
        '
        'Cooperativeloan_LB
        '
        Me.Cooperativeloan_LB.AutoSize = True
        Me.Cooperativeloan_LB.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Cooperativeloan_LB.Location = New System.Drawing.Point(20, 126)
        Me.Cooperativeloan_LB.Name = "Cooperativeloan_LB"
        Me.Cooperativeloan_LB.Size = New System.Drawing.Size(114, 13)
        Me.Cooperativeloan_LB.TabIndex = 70
        Me.Cooperativeloan_LB.Text = "Cooperative loan/THB"
        '
        'Libilities_TB
        '
        Me.Libilities_TB.Font = New System.Drawing.Font("Arial Narrow", 9.75!)
        Me.Libilities_TB.Location = New System.Drawing.Point(326, 38)
        Me.Libilities_TB.Multiline = True
        Me.Libilities_TB.Name = "Libilities_TB"
        Me.Libilities_TB.Size = New System.Drawing.Size(137, 77)
        Me.Libilities_TB.TabIndex = 69
        '
        'Liabilities_LB
        '
        Me.Liabilities_LB.AutoSize = True
        Me.Liabilities_LB.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Liabilities_LB.Location = New System.Drawing.Point(248, 48)
        Me.Liabilities_LB.Name = "Liabilities_LB"
        Me.Liabilities_LB.Size = New System.Drawing.Size(76, 13)
        Me.Liabilities_LB.TabIndex = 68
        Me.Liabilities_LB.Text = "List of liabilities"
        '
        'DailyMonthly_LB
        '
        Me.DailyMonthly_LB.AutoSize = True
        Me.DailyMonthly_LB.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DailyMonthly_LB.Location = New System.Drawing.Point(248, 18)
        Me.DailyMonthly_LB.Name = "DailyMonthly_LB"
        Me.DailyMonthly_LB.Size = New System.Drawing.Size(72, 13)
        Me.DailyMonthly_LB.TabIndex = 67
        Me.DailyMonthly_LB.Text = "Daily/Monthly"
        '
        'DailyMonthly_CB
        '
        Me.DailyMonthly_CB.FormattingEnabled = True
        Me.DailyMonthly_CB.Items.AddRange(New Object() {"Daily", "Monthly"})
        Me.DailyMonthly_CB.Location = New System.Drawing.Point(326, 10)
        Me.DailyMonthly_CB.Name = "DailyMonthly_CB"
        Me.DailyMonthly_CB.Size = New System.Drawing.Size(55, 21)
        Me.DailyMonthly_CB.TabIndex = 66
        '
        'Income_LB
        '
        Me.Income_LB.AutoSize = True
        Me.Income_LB.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Income_LB.Location = New System.Drawing.Point(65, 19)
        Me.Income_LB.Name = "Income_LB"
        Me.Income_LB.Size = New System.Drawing.Size(69, 13)
        Me.Income_LB.TabIndex = 51
        Me.Income_LB.Text = "Income/THB"
        '
        'Income_TB
        '
        Me.Income_TB.Font = New System.Drawing.Font("Arial Narrow", 9.75!)
        Me.Income_TB.Location = New System.Drawing.Point(140, 10)
        Me.Income_TB.Name = "Income_TB"
        Me.Income_TB.Size = New System.Drawing.Size(102, 22)
        Me.Income_TB.TabIndex = 50
        '
        'Numbershare_TB
        '
        Me.Numbershare_TB.Font = New System.Drawing.Font("Arial Narrow", 9.75!)
        Me.Numbershare_TB.Location = New System.Drawing.Point(140, 66)
        Me.Numbershare_TB.Name = "Numbershare_TB"
        Me.Numbershare_TB.Size = New System.Drawing.Size(102, 22)
        Me.Numbershare_TB.TabIndex = 12
        '
        'Investment_TB
        '
        Me.Investment_TB.Font = New System.Drawing.Font("Arial Narrow", 9.75!)
        Me.Investment_TB.Location = New System.Drawing.Point(140, 39)
        Me.Investment_TB.Name = "Investment_TB"
        Me.Investment_TB.Size = New System.Drawing.Size(102, 22)
        Me.Investment_TB.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(45, 75)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 13)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Number of shares"
        '
        'Investment_LB
        '
        Me.Investment_LB.AutoSize = True
        Me.Investment_LB.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Investment_LB.Location = New System.Drawing.Point(48, 48)
        Me.Investment_LB.Name = "Investment_LB"
        Me.Investment_LB.Size = New System.Drawing.Size(86, 13)
        Me.Investment_LB.TabIndex = 34
        Me.Investment_LB.Text = "Investment/THB"
        '
        'Date_Member
        '
        Me.Date_Member.CustomFormat = "dd-MM-yyyy"
        Me.Date_Member.Font = New System.Drawing.Font("Arial Narrow", 8.25!)
        Me.Date_Member.Location = New System.Drawing.Point(140, 146)
        Me.Date_Member.Name = "Date_Member"
        Me.Date_Member.Size = New System.Drawing.Size(175, 20)
        Me.Date_Member.TabIndex = 15
        Me.Date_Member.Value = New Date(2020, 4, 16, 0, 0, 0, 0)
        '
        'DateMember_LB
        '
        Me.DateMember_LB.AutoSize = True
        Me.DateMember_LB.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DateMember_LB.Location = New System.Drawing.Point(31, 151)
        Me.DateMember_LB.Name = "DateMember_LB"
        Me.DateMember_LB.Size = New System.Drawing.Size(102, 13)
        Me.DateMember_LB.TabIndex = 30
        Me.DateMember_LB.Text = "Date of Membership"
        '
        'Note_LB
        '
        Me.Note_LB.AutoSize = True
        Me.Note_LB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Note_LB.ForeColor = System.Drawing.Color.Red
        Me.Note_LB.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Note_LB.Location = New System.Drawing.Point(93, 570)
        Me.Note_LB.Name = "Note_LB"
        Me.Note_LB.Size = New System.Drawing.Size(293, 13)
        Me.Note_LB.TabIndex = 46
        Me.Note_LB.Text = "Note * Indicates that information must be filled out completely"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(46, 736)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 45
        '
        'Clear_BT
        '
        Me.Clear_BT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Clear_BT.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Clear_BT.Location = New System.Drawing.Point(339, 526)
        Me.Clear_BT.Name = "Clear_BT"
        Me.Clear_BT.Size = New System.Drawing.Size(70, 29)
        Me.Clear_BT.TabIndex = 20
        Me.Clear_BT.Text = "CLEAR"
        Me.Clear_BT.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(313, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 20
        '
        'Delete_BT
        '
        Me.Delete_BT.BackColor = System.Drawing.Color.DarkRed
        Me.Delete_BT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Delete_BT.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Delete_BT.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Delete_BT.Location = New System.Drawing.Point(247, 526)
        Me.Delete_BT.Name = "Delete_BT"
        Me.Delete_BT.Size = New System.Drawing.Size(70, 29)
        Me.Delete_BT.TabIndex = 19
        Me.Delete_BT.Text = "DELETE"
        Me.Delete_BT.UseVisualStyleBackColor = False
        '
        'Update_BT
        '
        Me.Update_BT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Update_BT.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Update_BT.Location = New System.Drawing.Point(69, 526)
        Me.Update_BT.Name = "Update_BT"
        Me.Update_BT.Size = New System.Drawing.Size(70, 29)
        Me.Update_BT.TabIndex = 17
        Me.Update_BT.Text = "UPDATE"
        Me.Update_BT.UseVisualStyleBackColor = True
        '
        'Add_BT
        '
        Me.Add_BT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Add_BT.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Add_BT.Location = New System.Drawing.Point(159, 526)
        Me.Add_BT.Name = "Add_BT"
        Me.Add_BT.Size = New System.Drawing.Size(70, 29)
        Me.Add_BT.TabIndex = 18
        Me.Add_BT.Text = "ADD"
        Me.Add_BT.UseVisualStyleBackColor = True
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
        Me.Head_LB.TabIndex = 21
        Me.Head_LB.Text = "If you already have information and want to update Please fill Member ID and Clic" & _
    "k GET."
        '
        'Member_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1282, 703)
        Me.Controls.Add(Me.Member_Data)
        Me.Name = "Member_Form"
        Me.Text = "Member"
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Member_Data.ResumeLayout(False)
        Me.Member_Data.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Personalinfo_LB.ResumeLayout(False)
        Me.Personalinfo_LB.PerformLayout()
        Me.Data2.ResumeLayout(False)
        Me.Data2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Member_Data As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Search_TB As System.Windows.Forms.TextBox
    Friend WithEvents Showall_BT As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Income_LB As System.Windows.Forms.Label
    Friend WithEvents Income_TB As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Address_TB As System.Windows.Forms.TextBox
    Friend WithEvents Note_LB As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Numbershare_TB As System.Windows.Forms.TextBox
    Friend WithEvents Investment_TB As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Investment_LB As System.Windows.Forms.Label
    Friend WithEvents Tel_TB As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Address_LB As System.Windows.Forms.Label
    Public WithEvents Date_Member As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateMember_LB As System.Windows.Forms.Label
    Friend WithEvents MemberID_TB As System.Windows.Forms.TextBox
    Friend WithEvents Member_LB As System.Windows.Forms.Label
    Friend WithEvents Clear_BT As System.Windows.Forms.Button
    Friend WithEvents Date_Birth As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Delete_BT As System.Windows.Forms.Button
    Friend WithEvents Update_BT As System.Windows.Forms.Button
    Friend WithEvents GetData_BT As System.Windows.Forms.Button
    Friend WithEvents Age_TB As System.Windows.Forms.TextBox
    Friend WithEvents LastN_TB As System.Windows.Forms.TextBox
    Friend WithEvents FirstN_TB As System.Windows.Forms.TextBox
    Friend WithEvents IDCard_TB As System.Windows.Forms.TextBox
    Friend WithEvents Add_BT As System.Windows.Forms.Button
    Friend WithEvents Famale_RB As System.Windows.Forms.RadioButton
    Friend WithEvents Male_RB As System.Windows.Forms.RadioButton
    Friend WithEvents Datebirth_LB As System.Windows.Forms.Label
    Friend WithEvents Depart_LB As System.Windows.Forms.Label
    Friend WithEvents Gender_LB As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents IDCard_LB As System.Windows.Forms.Label
    Friend WithEvents LastN_LB As System.Windows.Forms.Label
    Friend WithEvents FirstN_LB As System.Windows.Forms.Label
    Friend WithEvents Depart_CB As System.Windows.Forms.ComboBox
    Friend WithEvents Head_LB As System.Windows.Forms.Label
    Friend WithEvents Province_LB As System.Windows.Forms.Label
    Friend WithEvents District_LB As System.Windows.Forms.Label
    Friend WithEvents Subdistrict_LB As System.Windows.Forms.Label
    Friend WithEvents Zipcode_LB As System.Windows.Forms.Label
    Friend WithEvents Province_CB As System.Windows.Forms.ComboBox
    Friend WithEvents Subdistrict_CB As System.Windows.Forms.ComboBox
    Friend WithEvents District_CB As System.Windows.Forms.ComboBox
    Friend WithEvents DailyMonthly_LB As System.Windows.Forms.Label
    Friend WithEvents DailyMonthly_CB As System.Windows.Forms.ComboBox
    Friend WithEvents Cooperativeloan_TB As System.Windows.Forms.TextBox
    Friend WithEvents Cooperativeloan_LB As System.Windows.Forms.Label
    Friend WithEvents Libilities_TB As System.Windows.Forms.TextBox
    Friend WithEvents Liabilities_LB As System.Windows.Forms.Label
    Friend WithEvents Personalinfo_LB As System.Windows.Forms.GroupBox
    Friend WithEvents Data2 As System.Windows.Forms.GroupBox
    Friend WithEvents Zipcode_TB As System.Windows.Forms.TextBox
    Friend WithEvents Typeloan_LB As System.Windows.Forms.Label
    Friend WithEvents Typeloan_TB As System.Windows.Forms.TextBox

End Class
