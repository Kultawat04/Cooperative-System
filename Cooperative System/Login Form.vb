
Imports System.Data.Odbc


Public Class Login_Form



    Public Sub Clear_login()
        UsernameTB.Text = ""
        PwTB.Text = ""
    End Sub

    Private Sub LoginBT_Click(sender As System.Object, e As System.EventArgs) Handles LoginBT.Click
        Try
            Dim query As String = "SELECT * FROM Userlogin WHERE Username = '" & UsernameTB.Text & "' AND Password = '" & PwTB.Text & "'"
            Dim con As OdbcConnection = New OdbcConnection("Dsn=Cooperative_DB;uid=sa;pwd=sa")
            Dim cmd As OdbcCommand = New OdbcCommand(query, con)
            Dim da As New OdbcDataAdapter(cmd)
            Dim dt As New DataTable

            con.Open()
            da.Fill(dt)
            cmd.ExecuteScalar()
            If dt.Rows.Count > 0 Then
                MDI_Main.Show()
                Me.Hide()
            Else
                MessageBox.Show("Username and Password Incorrect", "Cooperative System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Close_BT_Click(sender As System.Object, e As System.EventArgs) Handles Close_BT.Click
        If MessageBox.Show("Exit application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes = True Then
            Application.Exit()
        End If
    End Sub

    Private Sub Login_Form_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class

