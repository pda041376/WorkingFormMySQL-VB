Imports MySql.Data.MySqlClient

Public Class DBControl
    Private DBCon As New MySqlConnection("server=192.168.20.106;username=root;password=RT10@gne;database=moodle;Sslmode=none")
    Private DBCmd As MySqlCommand


    Public DBDA As MySqlDataAdapter
    Public DBTable As DataTable
    Public Params As New List(Of MySqlParameter)
    Public Records As Integer
    Public Exception As String

    Public Sub New()
    End Sub

    Public Sub New(ConnectionString As String)
        DBCon = New MySqlConnection()
    End Sub

    Public Sub ExecQuery(Query As String)
        Records = 0
        Exception = ""

        Try
            DBCon.Open()
            DBCmd = New MySqlCommand(Query, DBCon)
            Params.ForEach(Sub(p) DBCmd.Parameters.Add(p))
            Params.Clear()
            DBTable = New DataTable
            DBDA = New MySqlDataAdapter(DBCmd)
            Records = DBDA.Fill(DBTable)

        Catch ex As Exception
            Exception = "ExecQuery Error: " & vbNewLine & ex.Message
        Finally
            If DBCon.State = ConnectionState.Open Then DBCon.Close()
        End Try
    End Sub

    Public Sub AddParam(Name As String, Value As Object)
        Dim NewParam As New MySqlParameter(Name, Value)
        Params.Add(NewParam)
    End Sub

    Public Function HasExeception(Optional Report As Boolean = True) As Boolean
        If String.IsNullOrEmpty(Exception) Then Return False
        If Report = True Then MsgBox(Exception, MsgBoxStyle.Critical, "Exception: ")
        Return True
    End Function
End Class
