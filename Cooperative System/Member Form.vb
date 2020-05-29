Imports System.Data
Imports System.Data.Odbc

Public Class Member_Form

    Public Sub GetData_BT_Click(sender As System.Object, e As System.EventArgs) Handles GetData_BT.Click
        Try
            Dim query As String = "SELECT * FROM Member WHERE [Member ID] = '" & MemberID_TB.Text & "'"
            Dim con As OdbcConnection = New OdbcConnection("Dsn=Cooperative_DB;uid=sa;pwd=sa;")
            Dim cmd As OdbcCommand = New OdbcCommand(query, con)
            Dim da As New OdbcDataAdapter(cmd)
            Dim dt As New DataTable

            con.Open()
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                IDCard_TB.Text = dt.Rows(0)("ID Card")
                FirstN_TB.Text = dt.Rows(0)("First Name").ToString
                LastN_TB.Text = dt.Rows(0)("Last Name").ToString

                If dt.Rows(0)("Gender") = "Male" Then
                    Male_RB.Checked = True
                Else
                    Famale_RB.Checked = True
                End If

                Date_Birth.Value = dt.Rows(0)("Date of Birth").ToString
                Age_TB.Text = dt.Rows(0)("Age")
                Depart_CB.Text = dt.Rows(0)("Department").ToString
                Address_TB.Text = dt.Rows(0)("Address").ToString
                Subdistrict_CB.Text = dt.Rows(0)("Subdistrict").ToString
                District_CB.Text = dt.Rows(0)("District").ToString
                Province_CB.Text = dt.Rows(0)("Province").ToString
                Zipcode_TB.Text = dt.Rows(0)("Zipcode").ToString
                Tel_TB.Text = dt.Rows(0)("Tel")
                Income_TB.Text = dt.Rows(0)("Income/THB")
                DailyMonthly_CB.Text = dt.Rows(0)("Daily/Monthly")
                Investment_TB.Text = dt.Rows(0)("Investment/THB")
                Numbershare_TB.Text = dt.Rows(0)("Number of shares")
                Typeloan_TB.Text = dt.Rows(0)("Type of loan")
                Cooperativeloan_TB.Text = dt.Rows(0)("Cooperative Loan/THB")
                Libilities_TB.Text = dt.Rows(0)("List of liabities").ToString
                Date_Member.Value = dt.Rows(0)("Date of Membership")

            Else
                Clear_Member()
                MessageBox.Show("Member ID does not exist. Please check again.", "Cooperative", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If

            con.Close()
            'refresh_datagrid()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub Add_BT_Click(sender As System.Object, e As System.EventArgs) Handles Add_BT.Click
        Try

            Dim gender As String = ""

            If Male_RB.Checked = True Then
                gender = Male_RB.Text
            Else
                gender = Famale_RB.Text
            End If

            Dim query As String = "INSERT INTO Member ([Member ID], [ID Card], [First Name], [Last Name], Gender, [Date of Birth], Age, Department, Address, Subdistrict, District, Province, Zipcode, Tel, [Income/THB], [Daily/Monthly], [Investment/THB], [Number of shares], [Type of loan], [Cooperative Loan/THB], [List of liabities], [Date of Membership]) VALUES ('" & MemberID_TB.Text & "', '" & IDCard_TB.Text & "', '" & FirstN_TB.Text & "', '" & LastN_TB.Text & "', '" & gender & "', '" & Date_Birth.Value & "', '" & Age_TB.Text & "', '" & Depart_CB.SelectedItem & "', '" & Address_TB.Text & "', '" & Subdistrict_CB.Text & "', '" & District_CB.Text & "','" & Province_CB.Text & "', '" & Zipcode_TB.Text & "', '" & Tel_TB.Text & "', '" & Income_TB.Text & "', '" & DailyMonthly_CB.SelectedItem & "', '" & Investment_TB.Text & "', '" & Numbershare_TB.Text & "', '" & Typeloan_TB.Text & "','" & Cooperativeloan_TB.Text & "', '" & Libilities_TB.Text & "', '" & Date_Member.Value & "')"
            Dim con As OdbcConnection = New OdbcConnection("Dsn=Cooperative_DB;uid=sa;pwd=sa;")
            Dim cmd As OdbcCommand = New OdbcCommand(query, con)

            con.Open()
            If MemberID_TB.Text = "" Or IDCard_TB.Text = "" Then
                MessageBox.Show("Member ID and ID Card must be not blank.", "Cooperative", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Else
                If MessageBox.Show("Do you want to Add?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    cmd.Parameters.AddWithValue("Member ID", MemberID_TB.Text)
                    cmd.Parameters.AddWithValue("ID Card", IDCard_TB.Text)
                    cmd.Parameters.AddWithValue("First Name", FirstN_TB.Text)
                    cmd.Parameters.AddWithValue("Last Name", LastN_TB.Text)
                    cmd.Parameters.AddWithValue("Gender", gender)
                    cmd.Parameters.AddWithValue("Date of Birth", Date_Birth.Value)
                    cmd.Parameters.AddWithValue("Age", Age_TB.Text)
                    cmd.Parameters.AddWithValue("Department", Depart_CB.SelectedItem)
                    cmd.Parameters.AddWithValue("Address", Address_TB.Text)
                    cmd.Parameters.AddWithValue("Subdistrict", Subdistrict_CB.Text)
                    cmd.Parameters.AddWithValue("District", District_CB.Text)
                    cmd.Parameters.AddWithValue("Province", Province_CB.Text)
                    cmd.Parameters.AddWithValue("Zipcode", Zipcode_TB.Text)
                    cmd.Parameters.AddWithValue("Tel", Tel_TB.Text)
                    cmd.Parameters.AddWithValue("Income/THB", Income_TB.Text)
                    cmd.Parameters.AddWithValue("Daily/Monthly", DailyMonthly_CB.SelectedItem)
                    cmd.Parameters.AddWithValue("Investment/THB", Investment_TB.Text)
                    cmd.Parameters.AddWithValue("Number of shares", Numbershare_TB.Text)
                    cmd.Parameters.AddWithValue("Type of loadn", Typeloan_TB.Text)
                    cmd.Parameters.AddWithValue("Cooperative Loan/THB", Cooperativeloan_TB.Text)
                    cmd.Parameters.AddWithValue("List of liabities", Libilities_TB.Text)
                    cmd.Parameters.AddWithValue("Date of Membership", Date_Member.Value)
                    cmd.ExecuteNonQuery()
                    cmd.Parameters.Clear()
                    MessageBox.Show("Successfully Added", "Cooperative System", MessageBoxButtons.OK, MessageBoxIcon.None)
                    Clear_Member()
                End If
            End If

            con.Close()
            refresh_datagrid()

        Catch 'ex As Exception
            'MsgBox(ex.Message)
            MessageBox.Show("Invalid or Duplicate Data, Please Check.", "Cooperative System")
        End Try

    End Sub

    Private Sub Update_BT_Click(sender As System.Object, e As System.EventArgs) Handles Update_BT.Click
        Try

            Dim gender As String = ""

            If Male_RB.Checked = True Then
                gender = Male_RB.Text
            Else
                gender = Famale_RB.Text
            End If

            Dim query As String = "UPDATE Member SET [ID Card] = '" & IDCard_TB.Text & "', [First Name] = '" & FirstN_TB.Text & "', [Last Name] = '" & LastN_TB.Text & "', Gender = '" & gender & "', [Date of Birth] = '" & Date_Birth.Value & "', Age = '" & Age_TB.Text & "', Department = '" & Depart_CB.SelectedItem & "', Address = '" & Address_TB.Text & "', Subdistrict = '" & Subdistrict_CB.Text & "', District = '" & District_CB.Text & "', Province = '" & Province_CB.Text & "', Zipcode = '" & Zipcode_TB.Text & "', Tel = '" & Tel_TB.Text & "', [Income/THB] = '" & Income_TB.Text & "', [Daily/Monthly] = '" & DailyMonthly_CB.SelectedItem & "', [Investment/THB] = '" & Investment_TB.Text & "', [Number of shares] = '" & Numbershare_TB.Text & "', [Type of loan] = '" & Typeloan_TB.Text & "', [Cooperative Loan/THB] = '" & Cooperativeloan_TB.Text & "', [List of liabities]= '" & Libilities_TB.Text & "', [Date of Membership] = '" & Date_Member.Value & "' WHERE [Member ID] = '" & MemberID_TB.Text & "'"
            Dim con As OdbcConnection = New OdbcConnection("Dsn=Cooperative_DB;uid=sa;pwd=sa;")
            Dim cmd As OdbcCommand = New OdbcCommand(query, con)

            con.Open()
            If MemberID_TB.Text = "" Then
                MessageBox.Show("Please fill Member ID for Update.", "Cooperative System", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Else
                If (MessageBox.Show("Do you want to Update?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
                    cmd.Parameters.AddWithValue("Member ID", MemberID_TB.Text)
                    cmd.Parameters.AddWithValue("ID Card", IDCard_TB.Text)
                    cmd.Parameters.AddWithValue("First Name", FirstN_TB.Text)
                    cmd.Parameters.AddWithValue("Last Name", LastN_TB.Text)
                    cmd.Parameters.AddWithValue("Gender", gender)
                    cmd.Parameters.AddWithValue("Date of Birth", Date_Birth.Value)
                    cmd.Parameters.AddWithValue("Age", Age_TB.Text)
                    cmd.Parameters.AddWithValue("Department", Depart_CB.SelectedItem)
                    cmd.Parameters.AddWithValue("Address", Address_TB.Text)
                    cmd.Parameters.AddWithValue("Subdistrict", Subdistrict_CB.Text)
                    cmd.Parameters.AddWithValue("District", District_CB.Text)
                    cmd.Parameters.AddWithValue("Province", Province_CB.Text)
                    cmd.Parameters.AddWithValue("Zipcode", Zipcode_TB.Text)
                    cmd.Parameters.AddWithValue("Tel", Tel_TB.Text)
                    cmd.Parameters.AddWithValue("Income/THB", Income_TB.Text)
                    cmd.Parameters.AddWithValue("Daily/Monthly", DailyMonthly_CB.SelectedItem)
                    cmd.Parameters.AddWithValue("Investment/THB", Investment_TB.Text)
                    cmd.Parameters.AddWithValue("Number of shares", Numbershare_TB.Text)
                    cmd.Parameters.AddWithValue("Type of loan", Typeloan_TB.Text)
                    cmd.Parameters.AddWithValue("Cooperative Loan/THB", Cooperativeloan_TB.Text)
                    cmd.Parameters.AddWithValue("List of liabities", Libilities_TB.Text)
                    cmd.Parameters.AddWithValue("Date of Membership", Date_Member.Value)
                    cmd.ExecuteNonQuery()
                    cmd.Parameters.Clear()
                    MessageBox.Show("Successfully Updated", "Cooperative System")
                    Clear_Member()
                End If
            End If

            con.Close()
            refresh_datagrid()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Delete_BT_Click(sender As System.Object, e As System.EventArgs) Handles Delete_BT.Click
        Try
            Dim query As String = "DELETE FROM Member WHERE [Member ID] = '" & MemberID_TB.Text & "'"
            Dim con As OdbcConnection = New OdbcConnection("Dsn=Cooperative_DB;uid=sa;pwd=sa;")
            Dim cmd As OdbcCommand = New OdbcCommand(query, con)

            con.Open()
            If MemberID_TB.Text = "" Then
                MessageBox.Show("Please fill Member ID for Delete.", "Cooperative System", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Else
                If (MessageBox.Show("Do you want to Delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
                    cmd.Parameters.AddWithValue("[Member ID]", MemberID_TB.Text)
                    cmd.ExecuteNonQuery()
                    cmd.Parameters.Clear()
                    MessageBox.Show("Successfully Deleted", "Cooperative System", MessageBoxButtons.OK, MessageBoxIcon.None)
                    Clear_Member()
                End If
            End If
            con.Close()
            refresh_datagrid()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Clear_Member()
        MemberID_TB.Text = ""
        IDCard_TB.Text = ""
        FirstN_TB.Text = ""
        LastN_TB.Text = ""
        Date_Birth.Text = ""
        'Age_TB.Text = ""
        'Depart_CB.Text = ""
        Address_TB.Text = ""
        'Subdistrict_CB.Text = ""
        'District_CB.Text = ""
        'Province_CB.Text = ""
        'Zipcode_TB.Text = ""
        Tel_TB.Text = ""
        Income_TB.Text = ""
        'DailyMonthly_CB.Text = ""
        Investment_TB.Text = ""
        Numbershare_TB.Text = ""
        Typeloan_TB.Text = ""
        Cooperativeloan_TB.Text = ""
        Libilities_TB.Text = ""
        Date_Member.Text = ""
    End Sub

    Private Sub Clear_BT_Click_1(sender As System.Object, e As System.EventArgs) Handles Clear_BT.Click
        Clear_Member()
    End Sub

    Private Sub Member_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Date_Birth.Value = Date.Now
        Date_Member.Value = DateTime.Now
    End Sub

    Public Sub refresh_datagrid()
        Dim query As String = "SELECT * FROM Member"
        Dim con As OdbcConnection = New OdbcConnection("Dsn=Cooperative_DB;uid=sa;pwd=sa;")
        Dim da As New OdbcDataAdapter(query, con)
        Dim ds As DataSet = New DataSet

        con.Open()
        da.Fill(ds, "Member")
        DataGridView1.DataSource = ds.Tables("Member")
        DTgrvCh()
        con.Close()
    End Sub

    Private Sub Showall_BT_Click(sender As System.Object, e As System.EventArgs) Handles Showall_BT.Click
        refresh_datagrid()
    End Sub

    Private Sub Search_TB_TextChanged(sender As System.Object, e As System.EventArgs) Handles Search_TB.TextChanged
        Dim query As String = "SELECT * FROM Member WHERE [Member ID] LIKE '%" & Search_TB.Text & "%' OR [ID Card] LIKE '%" & Search_TB.Text & "%' OR [First Name] LIKE '%" & Search_TB.Text & "%' OR [Last Name] LIKE '%" & Search_TB.Text & "%' "
        Dim con As OdbcConnection = New OdbcConnection("Dsn=Cooperative_DB;uid=sa;pwd=sa;")
        Dim cmd As OdbcCommand = New OdbcCommand(query, con)

        con.Open()
        Dim dr As OdbcDataReader = cmd.ExecuteReader
        Dim dt As New DataTable

        Search_TB.Text = Search_TB.Text.Replace("%", "").Replace("'", "").Replace("*", "")

        If Search_TB.Text = "" Or Len(Search_TB.Text) = 0 Then
            Exit Sub
        End If

        dt.Load(dr)
        DataGridView1.DataSource = dt
        DTgrvCh()
        dr.Close()
        con.Close()

    End Sub


    Public Sub DTgrvCh()

        DataGridView1.Font = New Font("AngsanaUPC", 14)
        'DataGridView1.Columns(0).HeaderText() = "รหัสสมาชิก"
        'DataGridView1.Columns.Item(0).Width = 70
        'DataGridView1.Columns(1).HeaderText() = "หมายเลขบัตรประชาชน"
        ''DataGridView1.Columns(2).HeaderText() = "ชื่อ"
        'DataGridView1.Columns(3).HeaderText() = "นามสกุล"
        'DataGridView1.Columns(4).HeaderText() = "เพศ"
        'DataGridView1.Columns(5).HeaderText() = "วันเกิด"
        DataGridView1.Columns(5).DefaultCellStyle.Format = "dd/MM/yyyy"
        'DataGridView1.Columns(6).HeaderText() = "อายุ"
        'DataGridView1.Columns(7).HeaderText() = "ที่อยู่"
        'DataGridView1.Columns(8).HeaderText() = "เบอร์โทรศัพท์"
        'DataGridView1.Columns.(9).HeaderText() = "เงินเดือน"
        'DataGridView1.Columns(9).HeaderText() = "เงินลงทุน"
        'DataGridView1.Columns(10).HeaderText() = "จำนวนหุ้น"
        'DataGridView1.Columns(11).HeaderText() = "ฝ่าย/ตำแหน่ง"
        'DataGridView1.Columns(12).HeaderText() = "วันที่สมัครสมาชิก"
        DataGridView1.Columns(12).DefaultCellStyle.Format = "dd/MM/yyyy"

    End Sub

    Private Sub Date_Birth_ValueChanged(sender As System.Object, e As System.EventArgs) Handles Date_Birth.ValueChanged

        Dim y1 As New DateTime
        Dim y2 As New DateTime
        y2 = DateTime.Now.ToString("dd/MM/yyyy")
        y1 = Date_Birth.Value.ToString("dd/MM/yyyy")

        Dim year As Integer = DateDiff(DateInterval.Year, CDate(y1), CDate(y2))
        Age_TB.Text = year
    End Sub

    Public Sub provinces()
        Try
            Dim query As String = "SELECT * FROM Provinces ORDER BY Id ASC"
            Dim con As OdbcConnection = New OdbcConnection("Dsn=Cooperative_DB;uid=sa;pwd=sa;")
            Dim da As New OdbcDataAdapter
            Dim ds As New DataSet

            con.Open()
            da.SelectCommand = New OdbcCommand(query, con)
            da.Fill(ds)

            With Province_CB
                .DataSource = ds.Tables(0)
                .ValueMember = "Id"
                .DisplayMember = "NameInThai"
            End With

            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub districts()
        Try

            Dim query As String = "SELECT * FROM Districts WHERE ProvinceId = '" & Province_CB.SelectedValue & "' ORDER BY Id ASC "
            Dim con As OdbcConnection = New OdbcConnection("Dsn=Cooperative_DB;uid=sa;pwd=sa;")
            Dim da As New OdbcDataAdapter
            Dim ds As New DataSet

            con.Open()
            da.SelectCommand = New OdbcCommand(query, con)
            da.Fill(ds)

            With District_CB
                .DataSource = ds.Tables(0)
                .ValueMember = "ProvinceId"
                .DisplayMember = "NameInThai"
            End With

            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub subdistricts()
        Try

            Dim query As String = "SELECT * FROM Subdistricts WHERE DistrictId = '" & District_CB.SelectedValue & "' ORDER BY Id ASC"
            Dim con As OdbcConnection = New OdbcConnection("Dsn=Cooperative_DB;uid=sa;pwd=sa;")
            Dim da As New OdbcDataAdapter
            Dim ds As New DataSet

            con.Open()
            da.SelectCommand = New OdbcCommand(query, con)
            da.Fill(ds)

            With Subdistrict_CB
                .DataSource = ds.Tables(0)
                .ValueMember = "ZipCode"
                .DisplayMember = "NameInThai"
            End With

            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Member_Form_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        provinces()
    End Sub

    Private Sub Province_CB_SelectionChangeCommitted(sender As System.Object, e As System.EventArgs) Handles Province_CB.SelectionChangeCommitted
        districts()
    End Sub

    Private Sub District_CB_SelectionChangeCommitted(sender As System.Object, e As System.EventArgs) Handles District_CB.SelectionChangeCommitted
        subdistricts()
    End Sub

    Private Sub Subdistrict_CB_SelectionChangeCommitted(sender As System.Object, e As System.EventArgs) Handles Subdistrict_CB.SelectionChangeCommitted
        Zipcode_TB.Text = Subdistrict_CB.SelectedValue

    End Sub

End Class