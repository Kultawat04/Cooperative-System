Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data
Imports System.Data.Odbc


Public Class Report_Form

    Private Sub Report_Form_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub ViewReport_BT_Click(sender As System.Object, e As System.EventArgs) Handles ViewReport_BT.Click
        Dim query As String = "SELECT * FROM Member"
        Dim con As OdbcConnection = New OdbcConnection("Dsn=Cooperative_DB;uid=sa;pwd=sa;")
        Dim cmd As OdbcCommand = New OdbcCommand(query, con)
        Dim da As New OdbcDataAdapter
        Dim dt As DataTable
        Dim ds As DataSet = New DataSet

        With cmd
            .Connection = con
            .CommandText = query
            .CommandType = CommandType.Text
        End With

        da.SelectCommand = cmd
        da.Fill(ds, "Member")
        dt = ds.Tables(0)
        da = Nothing
        con.Close()
        con = Nothing

        Dim rpt As New ReportDocument()
        Dim directory As String = My.Application.Info.DirectoryPath
        'rpt.Load(directory & "\\myCrystalReport.rpt")
        rpt.Load("D:\Kultawat_Data\Programming\VB\Project\Cooperative System\Cooperative System\Member Report.rpt")
        rpt.SetDataSource(dt)
        Me.CrystalReportViewer1.ReportSource = rpt
        Me.CrystalReportViewer1.RefreshReport()

    End Sub
End Class
   