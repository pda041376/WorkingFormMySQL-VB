Public Class frmQuery
    Public MySQL As New DBControl

    Public Sub LoadGrid(Optional Query As String = "")
        If Query = "" Then
            MySQL.ExecQuery("SELECT lastname, firstname, email FROM mdl_user;")

        Else
            MySQL.ExecQuery(Query)
        End If
        If MySQL.HasExeception(True) Then Exit Sub
        dgvData.DataSource = MySQL.DBTable
    End Sub

    Private Sub LoadCBX()
        cbxItems.Items.Clear()
        MySQL.ExecQuery("SELECT DISTINCT data 
                        FROM mdl_user_info_data 
                        WHERE fieldid=8 AND (data <> '') 
                        ORDER by data;")

        If MySQL.HasExeception(True) Then Exit Sub
        For Each r As DataRow In MySQL.DBTable.Rows
            cbxItems.Items.Add(r("data").ToString)
        Next

    End Sub

    Private Sub SearchBox()
        MySQL.AddParam("@search", txtSearch.Text & "%")
        LoadGrid("SELECT lastname, firstname, email FROM mdl_user 
                  WHERE lastname LIKE @search AND 
                 (lastname <> ' ') AND
                 (email <> 'novalid@p2s.com') AND
                 (firstname <> 'admin') AND
                 (lastname <> 'admin') AND
                 (firstname <> 'test') AND
                 (lastname <> 'test') AND
                 email LIKE '%@p2s.com'
                 ORDER by lastname;")
    End Sub


    Private Sub frmQuery_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = LoginForm
        LoadGrid("SELECT CONCAT (mdl_user.lastname,', ',mdl_user.firstname) AS 'User',
                  mdl_course.fullname AS 'Training Assigned' 
                  FROM mdl_user 
                  LEFT JOIN mdl_user_enrolments ON mdl_user.id = mdl_user_enrolments.userid 
                  LEFT JOIN mdl_enrol ON mdl_user_enrolments.enrolid = mdl_enrol.id 
                  LEFT JOIN mdl_course ON mdl_enrol.courseid = mdl_course.id 
                  WHERE (lastname <> ' ') AND (userid <> ' ') 
                  ORDER by User;")
        LoadCBX()

    End Sub

    Private Sub 

    End Sub

    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
        SearchBox()
    End Sub

End Class