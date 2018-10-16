﻿Imports MySql.Data.MySqlClient

Public Class LoginForm

    Dim connection As New MySqlConnection("server=192.168.20.106;username=root;password=RT10@gne;database=moodle;Sslmode=none")

    Private Sub chkShowPass_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPass.CheckedChanged

        If txtPassword.UseSystemPasswordChar = True Then

            txtPassword.UseSystemPasswordChar = False

        Else
            txtPassword.UseSystemPasswordChar = True
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        Dim command As New MySqlCommand("SELECT user, password FROM mysql.user WHERE user = @username AND password = PASSWORD(@password) ", connection)

        command.Parameters.Add("@username", MySqlDbType.VarChar).Value = txtUsername.Text
        command.Parameters.Add("@password", MySqlDbType.VarChar).Value = txtPassword.Text

        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable

        adapter.Fill(table)


        If table.Rows.Count >= 1 Then
            MsgBox("Connected")

        Else
            MsgBox("Not connected")
        End If


    End Sub


End Class
