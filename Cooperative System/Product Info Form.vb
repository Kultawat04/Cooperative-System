Imports System.Data
Imports System.Data.Odbc


Public Class Productinfo_Form

    Public Sub Clear_Product()
        Productid_TB.Text = ""
        Productname_TB.Text = ""
        Unitcounting_TB.Text = ""
        Costprice_TB.Text = ""
        Salesprice_TB.Text = ""
        Balances_TB.Text = ""

    End Sub

    Public Sub refresh_datagrid()
        Dim query As String = "SELECT * FROM ProductInfo"
        Dim con As OdbcConnection = New OdbcConnection("Dsn=Cooperative_DB;uid=sa;pwd=sa;")
        Dim da As New OdbcDataAdapter(query, con)
        Dim ds As DataSet = New DataSet

        con.Open()
        da.Fill(ds, "ProductInfo")
        DataGridView1.DataSource = ds.Tables("ProductInfo")
        DTgrvCh()
        con.Close()
    End Sub

    Public Sub DTgrvCh()

        DataGridView1.Font = New Font("AngsanaUPC", 14)

    End Sub

    Private Sub GetData_BT_Click(sender As System.Object, e As System.EventArgs) Handles GetData_BT.Click
        Try
            Dim query As String = "SELECT * FROM ProductInfo WHERE [Product ID] = '" & Productid_TB.Text & "'"
            Dim con As OdbcConnection = New OdbcConnection("Dsn=Cooperative_DB;uid=sa;pwd=sa;")
            Dim cmd As OdbcCommand = New OdbcCommand(query, con)
            Dim da As New OdbcDataAdapter(cmd)
            Dim dt As New DataTable

            con.Open()
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                Productid_TB.Text = dt.Rows(0)("Product ID")
                Productname_TB.Text = dt.Rows(0)("Product Name")
                Unitcounting_TB.Text = dt.Rows(0)("Unit of counting")
                Costprice_TB.Text = dt.Rows(0)("Cost price")
                Salesprice_TB.Text = dt.Rows(0)("Sales price")
                Balances_TB.Text = dt.Rows(0)("Balances")

            Else
                Clear_Product()
                MessageBox.Show("Product ID does not exist. Please check again.", "Cooperative System", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If

            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Add_BT_Click(sender As System.Object, e As System.EventArgs) Handles Add_BT.Click
        Try

            Dim query As String = "INSERT INTO ProductInfo ([Product ID], [Product Name], [Unit of counting], [Cost price], [Sales price], Balances) VALUES ('" & Productid_TB.Text & "', '" & Productname_TB.Text & "', '" & Unitcounting_TB.Text & "', '" & Costprice_TB.Text & "', '" & Salesprice_TB.Text & "', '" & Balances_TB.Text & "')"
            Dim con As OdbcConnection = New OdbcConnection("Dsn=Cooperative_DB;uid=sa;pwd=sa;")
            Dim cmd As OdbcCommand = New OdbcCommand(query, con)

            con.Open()
            If Productid_TB.Text = "" Then
                MessageBox.Show("Product ID must be not blank.", "Cooperative System", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Else
                If MessageBox.Show("Do you want to Add?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    cmd.Parameters.AddWithValue("Product ID", Productid_TB.Text)
                    cmd.Parameters.AddWithValue("Product Name", Productid_TB.Text)
                    cmd.Parameters.AddWithValue("Unit of counting", Unitcounting_TB.Text)
                    cmd.Parameters.AddWithValue("Cost price", Costprice_TB.Text)
                    cmd.Parameters.AddWithValue("Sales price", Salesprice_TB.Text)
                    cmd.Parameters.AddWithValue("Balances", Balances_TB.Text)
                    cmd.ExecuteNonQuery()
                    cmd.Parameters.Clear()
                    MessageBox.Show("Successfully Added", "Cooperative System", MessageBoxButtons.OK, MessageBoxIcon.None)
                    Clear_Product()
                End If
            End If

            con.Close()
            refresh_datagrid()

            'Catch ex As Exception
            'MsgBox(ex.Message)
            'End Try
        Catch
            MessageBox.Show("Invalid or Duplicate Data, Please Check.", "Cooperative System", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End Try

    End Sub

    Private Sub Update_BT_Click(sender As System.Object, e As System.EventArgs) Handles Update_BT.Click
        Try

            Dim query As String = "UPDATE ProductInfo SET [Product Name] = '" & Productname_TB.Text & "', [Unit of counting] = '" & Unitcounting_TB.Text & "', [Cost price] = '" & Costprice_TB.Text & "', [Sales price] = '" & Salesprice_TB.Text & "', Balances = '" & Balances_TB.Text & "' WHERE [Product ID] = '" & Productid_TB.Text & "'"
            Dim con As OdbcConnection = New OdbcConnection("Dsn=Cooperative_DB;uid=sa;pwd=sa;")
            Dim cmd As OdbcCommand = New OdbcCommand(query, con)

            con.Open()
            If Productid_TB.Text = "" Then
                MessageBox.Show("Please fill Product ID for Update.", "Cooperative System", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Else
                If (MessageBox.Show("Do you want to Update?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
                    cmd.Parameters.AddWithValue("Product ID", Productid_TB.Text)
                    cmd.Parameters.AddWithValue("Product Name", Productname_TB.Text)
                    cmd.Parameters.AddWithValue("Unit of counting", Unitcounting_TB.Text)
                    cmd.Parameters.AddWithValue("Cost price", Costprice_TB.Text)
                    cmd.Parameters.AddWithValue("Sales price", Salesprice_TB.Text)
                    cmd.Parameters.AddWithValue("Balances", Balances_TB.Text)
                    cmd.ExecuteNonQuery()
                    cmd.Parameters.Clear()
                    MessageBox.Show("Successfully Updated", "Cooperative System")
                    Clear_Product()
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
            Dim query As String = "DELETE FROM ProductInfo WHERE [Product ID] = '" & Productid_TB.Text & "'"
            Dim con As OdbcConnection = New OdbcConnection("Dsn=Cooperative_DB;uid=sa;pwd=sa;")
            Dim cmd As OdbcCommand = New OdbcCommand(query, con)

            con.Open()
            If Productid_TB.Text = "" Then
                MessageBox.Show("Please fill Product ID for Delete.", "Cooperative", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Else
                If (MessageBox.Show("Do you want to Delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
                    cmd.Parameters.AddWithValue("Product ID", Productid_TB.Text)
                    cmd.ExecuteNonQuery()
                    cmd.Parameters.Clear()
                    MessageBox.Show("Successfully Deleted", "Cooperative System", MessageBoxButtons.OK, MessageBoxIcon.None)
                    Clear_Product()
                End If
            End If
            con.Close()
            refresh_datagrid()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Clear_BT_Click(sender As System.Object, e As System.EventArgs) Handles Clear_BT.Click
        Clear_Product()
    End Sub

    Private Sub Showall_BT_Click(sender As System.Object, e As System.EventArgs) Handles Showall_BT.Click
        refresh_datagrid()
    End Sub

    Private Sub Search_TB_TextChanged(sender As System.Object, e As System.EventArgs) Handles Search_TB.TextChanged
        Dim query As String = "SELECT * FROM ProductInfo WHERE [Product ID] LIKE '%" & Search_TB.Text & "%' OR [Type/Brand] LIKE '%" & Search_TB.Text & "%' OR [Product Name] LIKE '%" & Search_TB.Text & "%'"
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

    
End Class