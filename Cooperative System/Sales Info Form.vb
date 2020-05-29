Imports System.Data
Imports System.Data.Odbc

Public Class Salesinfo_Form

    Private Sub Salesinfo_Form_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Date_Sales.Value = DateTime.Now
    End Sub

    Public Sub Clear_Sales()
        Salesid_TB.Text = ""
        Seller_TB.Text = ""
        Productid_TB.Text = ""
        Productname_TB.Text = ""
        Buyer_TB.Text = ""
        Amountpurchased_TB.Text = ""
        Salepriceperunit_TB.Text = ""
        Paymenttype_CB.Text = ""
        Totalpurchaseprice_TB.Text = ""
        'Date_Sales.Text = ""
    End Sub

    Public Sub refresh_datagrid()
        Dim query As String = "SELECT * FROM SaleInfo"
        Dim con As OdbcConnection = New OdbcConnection("Dsn=Cooperative_DB;uid=sa;pwd=sa;")
        Dim da As New OdbcDataAdapter(query, con)
        Dim ds As DataSet = New DataSet

        con.Open()
        da.Fill(ds, "SaleInfo")
        DataGridView1.DataSource = ds.Tables("SaleInfo")
        con.Close()
    End Sub
    

    Private Sub GetData_BT_Click(sender As System.Object, e As System.EventArgs) Handles GetData_BT.Click
        Try
            Dim query As String = "SELECT * FROM SalesInfo WHERE [Sales ID] = '" & Salesid_TB.Text & "'"
            Dim con As OdbcConnection = New OdbcConnection("Dsn=Cooperative_DB;uid=sa;pwd=sa;")
            Dim cmd As OdbcCommand = New OdbcCommand(query, con)
            Dim da As New OdbcDataAdapter(cmd)
            Dim dt As New DataTable

            con.Open()
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                Salesid_TB.Text = dt.Rows(0)("Sale ID").ToString
                Seller_TB.Text = dt.Rows(0)("Seller").ToString
                Productid_TB.Text = dt.Rows(0)("Product ID").ToString
                Productname_TB.Text = dt.Rows(0)("Product Name").ToString
                Buyer_TB.Text = dt.Rows(0)("Buyer").ToString
                Amountpurchased_TB.Text = dt.Rows(0)("Amount purchased").ToString
                Salepriceperunit_TB.Text = dt.Rows(0)("Sales price per unit").ToString
                Paymenttype_CB.Text = dt.Rows(0)("Payment type").ToString
                Totalpurchaseprice_TB.Text = dt.Rows(0)("Total purchase price").ToString
                Date_Sales.Text = dt.Rows(0)("Date of sales").ToString
            Else
                Clear_Sales()
                MessageBox.Show("Sales ID does not exist. Please check again.", "Cooperative", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If

            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Add_BT_Click(sender As System.Object, e As System.EventArgs) Handles Add_BT.Click
        Dim query As String = "INSERT INTO SalesInfo ([Sales ID], Seller, [Product ID], [Product Name], Buyer, [Amount purchased], [Sales price per unit], [Payment type], [Total purchase price], [Date of sales]) VALUES '" & Salesid_TB.Text & "', '" & Seller_TB.Text & "', '" & Productid_TB.Text & "', '" & Productname_TB.Text & "', '" & Buyer_TB.Text & "', '" & Amountpurchased_TB.Text & "', '" & Salepriceperunit_TB.Text & "', '" & Salepriceperunit_TB.Text & "', '" & Paymenttype_CB.Text & "', '" & Totalpurchaseprice_TB.Text & "', '" & Date_Sales.Value & "' "
        Dim con As OdbcConnection = New OdbcConnection("Dsn=Cooperative_DB;uid=sa;pwd=sa;")
        Dim cmd As OdbcCommand = New OdbcCommand(query, con)

        con.Open()

        If Salesid_TB.Text = "" Or Productid_TB.Text Then
            MessageBox.Show("Sales ID and Product ID must be not blank.", "Cooperative", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            If MessageBox.Show("Do you want to Add?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                cmd.Parameters.AddWithValue("Sales ID", Salesid_TB.Text)
                cmd.Parameters.AddWithValue("Seller", Seller_TB.Text)
                cmd.Parameters.AddWithValue("Product ID", Productname_TB.Text)
                cmd.Parameters.AddWithValue("Buyer", Buyer_TB.Text)
                cmd.Parameters.AddWithValue("Amount purchased", Amountpurchased_TB.Text)
                cmd.Parameters.AddWithValue("Sales price per unit", Salepriceperunit_TB.Text)
                cmd.Parameters.AddWithValue("Payment type", Paymenttype_CB.Text).ToString()
                cmd.Parameters.AddWithValue("Total purchase price", Totalpurchaseprice_TB.Text)
                cmd.Parameters.AddWithValue("Date of sales", Date_Sales.Value)
                cmd.ExecuteNonQuery()
                cmd.Parameters.Clear()
                MessageBox.Show("Successfully Added", "Cooperative System", MessageBoxButtons.OK, MessageBoxIcon.None)
                Clear_Sales()

            End If
        End If

        con.Close()

    End Sub

    Private Sub Update_BT_Click(sender As System.Object, e As System.EventArgs) Handles Update_BT.Click
        Try
            Dim query As String = "UPDATE SalesInfo SET Seller = '" & Seller_TB.Text & "', [Product ID] = '" & Productid_TB.Text & "', [Product Name] = '" & Productname_TB.Text & "', Buyer = '" & Buyer_TB.Text & "', [Amount purchased] = '" & Amountpurchased_TB.Text & "', [Sales price per unit] = '" & Salepriceperunit_TB.Text & "', [Payment type] = '" & Paymenttype_CB.Text & "', [Total purchase price] = '" & Totalpurchaseprice_TB.Text & "', [Date of sales] = '" & Date_Sales.Value & "' WHERE [Sales ID] = '" & Salesid_TB.Text & "'"
            Dim con As OdbcConnection = New OdbcConnection("Dsn=Cooperative_DB;uid=sa;pwd=sa;")
            Dim cmd As OdbcCommand = New OdbcCommand(query, con)

            con.Open()

            If Salesid_TB.Text = "" Or Productid_TB.Text Then
                MessageBox.Show("Sales ID and Product ID must be not blank.", "Cooperative", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Else
                If MessageBox.Show("Do you want to Update?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    cmd.Parameters.AddWithValue("Sales ID", Salesid_TB.Text)
                    cmd.Parameters.AddWithValue("Seller", Seller_TB.Text)
                    cmd.Parameters.AddWithValue("Product ID", Productname_TB.Text)
                    cmd.Parameters.AddWithValue("Buyer", Buyer_TB.Text)
                    cmd.Parameters.AddWithValue("Amount purchased", Amountpurchased_TB.Text)
                    cmd.Parameters.AddWithValue("Sales price per unit", Salepriceperunit_TB.Text)
                    cmd.Parameters.AddWithValue("Payment type", Paymenttype_CB.Text)
                    cmd.Parameters.AddWithValue("Total purchase price", Totalpurchaseprice_TB.Text)
                    cmd.Parameters.AddWithValue("Date of sales", Date_Sales.Value)
                    cmd.ExecuteNonQuery()
                    cmd.Parameters.Clear()
                    MessageBox.Show("Successfully Added", "Cooperative System", MessageBoxButtons.OK, MessageBoxIcon.None)
                    Clear_Sales()

                End If
            End If

            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Delete_BT_Click(sender As System.Object, e As System.EventArgs) Handles Delete_BT.Click
        Try
            Dim query As String = "DELETE FROM SalesInfo WHERE [Sales ID] = '" & Salesid_TB.Text & "'"
            Dim con As OdbcConnection = New OdbcConnection("Dsn=Cooperative_DB;uid=sa;pwd=sa;")
            Dim cmd As OdbcCommand = New OdbcCommand(query, con)

            con.Open()

            If Salesid_TB.Text = "" Then
                MessageBox.Show("Please fill Sales ID for Delete.", "Cooperative System", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Else
                If (MessageBox.Show("Do you want to Delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
                    cmd.Parameters.AddWithValue("Sales ID", Salesid_TB.Text)
                    cmd.ExecuteNonQuery()
                    cmd.Parameters.Clear()
                    MessageBox.Show("Successfully Deleted", "Cooperative System", MessageBoxButtons.OK, MessageBoxIcon.None)
                    Clear_Sales()
                End If
            End If

            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Clear_BT_Click(sender As System.Object, e As System.EventArgs) Handles Clear_BT.Click
        Clear_Sales()
    End Sub

    Private Sub Showall_BT_Click(sender As System.Object, e As System.EventArgs) Handles Showall_BT.Click
        refresh_datagrid()

    End Sub

    Private Sub Search_TB_TextChanged(sender As System.Object, e As System.EventArgs) Handles Search_TB.TextChanged
        Dim query As String = "SELECT * FROM SaleInfo WHERE [Sales ID] LIKE '%" & Search_TB.Text & "%' OR Seller LIKE '%" & Search_TB.Text & "%' OR [Product ID] LIKE '%" & Search_TB.Text & "%' OR [Product Name] LIKE '%" & Search_TB.Text & "%' OR Buyer LIKE '%" & Search_TB.Text & "%'"
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
        dr.Close()
        con.Close()
    End Sub
End Class