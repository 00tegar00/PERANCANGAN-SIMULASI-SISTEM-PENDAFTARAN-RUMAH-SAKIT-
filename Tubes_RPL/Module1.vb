Imports System.Data.Odbc
Imports System.Windows.Forms
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Module Module1
    Public Conn As OdbcConnection
    Public da As OdbcDataAdapter
    Public ds As DataSet
    Public cmd As OdbcCommand
    Public rd As OdbcDataReader
    Public str As String
    Public cryrpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument

    Public Sub Koneksi()
        str = "Driver={MySQL ODBC 3.51 Driver}; Database=rumah_sakit; server=localhost; uid=root"
        Conn = New OdbcConnection(str)
        If Conn.State = ConnectionState.Closed Then
            Conn.Open()
        End If
    End Sub
End Module
