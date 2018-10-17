﻿Public Class frmQuery
    Public MySQL As New DBControl

    Public Sub LoadGrid(Optional Query As String = "")
        If Query = "" Then
            MySQL.ExecQuery("SELECT * FROM mdl_user;")

        Else
            MySQL.ExecQuery(Query)
        End If
        If MySQL.HasExeception(True) Then Exit Sub
        dgvData.DataSource = MySQL.DBTable
    End Sub

    Private Sub SearchBox()
        MySQL.AddParam("@search", txtSearch.Text & "%")
        LoadGrid("SELECT email, firstname, lastname, id  FROM mdl_user WHERE lastname LIKE @search")
    End Sub


    Private Sub frmQuery_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = LoginForm
        'LoadGrid("SELECT email, lastname, firstname FROM mdl_user WHERE (lastname <> '') ;")
        LoadGrid("select CONCAT (mdl_user.lastname,', ',mdl_user.firstname) AS 'User', mdl_course.fullname AS 'Training Assigned' FROM mdl_user LEFT JOIN mdl_user_enrolments ON mdl_user.id = mdl_user_enrolments.userid LEFT JOIN mdl_enrol ON mdl_user_enrolments.enrolid = mdl_enrol.id LEFT JOIN mdl_course ON mdl_enrol.courseid = mdl_course.id ORDER by mdl_user.id;")


    End Sub

    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
        SearchBox()
    End Sub
End Class