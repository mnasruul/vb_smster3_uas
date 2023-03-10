Imports System.Data
Imports System.Data.OleDb
Imports System.Data.Sql
Public Class koneksi
    Public Shared stLogin As Boolean = False
    Public Shared Kduser As String = ""
    Public Shared Nmuser As String = ""
    Dim msaccess = New DataTable
    Public Shared sql As String
    Dim koneksi As OleDb.OleDbConnection
    Dim command As OleDb.OleDbCommand
    Dim dataadapter As OleDbDataAdapter
    Dim ds As DataSet
    Dim dt As DataTable

    Public Function openconn() As Boolean
        koneksi = New OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source=D:\KULIAH\SEMESTER 3\VB\UAS\MuhammadNasrul_3SIC2.accdb;Persist Security Info=False")
        'koneksi = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;data source=D:\KULIAH\SEMESTER 3\VB\PERTEMUAN\penjualan_Muhammad Nasrul.accdb")
        koneksi.Open()
        If koneksi.State <> ConnectionState.Open Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Sub closeconn()
        If Not IsNothing(koneksi) Then
            koneksi.Close()
            koneksi = Nothing
        End If
    End Sub

    Public Function executequery(ByVal query As String) As DataTable
        If Not openconn() Then
            MsgBox("Koneksi gagal..!!", MsgBoxStyle.Critical, "access failed")
            Return Nothing
            Exit Function
        End If
        command = New OleDb.OleDbCommand(query, koneksi)
        dataadapter = New OleDb.OleDbDataAdapter
        dataadapter.SelectCommand = command
        ds = New Data.DataSet
        dataadapter.Fill(ds)
        dt = ds.Tables(0)
        Return dt
        dt = Nothing
        ds = Nothing
        dataadapter = Nothing
        command = Nothing
        closeconn()
    End Function

    Public Sub executenonquery(ByVal query As String)
        If Not openconn() Then
            MsgBox("Koneksi gagal..!!", MsgBoxStyle.Critical, "access failed")
            Exit Sub
        End If
        command = New OleDb.OleDbCommand
        command.Connection = koneksi
        command.CommandType = CommandType.Text
        command.CommandText = query
        command.ExecuteNonQuery()
        command = Nothing
        closeconn()
    End Sub
    Public Shared Sub CloseAllForm()
        Application.Exit()
    End Sub
End Class
