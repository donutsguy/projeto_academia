Imports System.Data.OleDb
Imports System.Net.NetworkInformation

Public Class Form7
    Private Function GetDados(sql) As DataTable
        Dim connectionString As String = "Provider=Microsoft.JET.OLEDB.4.0;Data source = " & dir_banco
        Dim query As String = sql

        Dim dt As New DataTable()
        Using connection As New OleDbConnection(connectionString)
            Using adapter As New OleDbDataAdapter(query, connection)
                adapter.Fill(dt)
            End Using
        End Using

        Return dt
    End Function

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dados As DataTable = GetDados("SELECT id, nome FROM tb_cadastro where status = 'ATIVO' order by nome asc")

        cb_aluno.DisplayMember = "nome"
        cb_aluno.ValueMember = "id"
        cb_aluno.DataSource = dados

    End Sub

    Private Sub cb_grupo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_grupo.SelectedIndexChanged
        Dim dados As DataTable = GetDados("SELECT id, exer FROM tb_grupos where grupo = '" & cb_grupo.Text & "' ")

        cb_1.DisplayMember = "exer"
        cb_1.ValueMember = "id"
        cb_1.DataSource = dados

        Dim dados_1 As DataTable = GetDados("SELECT id, exer FROM tb_grupos where grupo = '" & cb_grupo.Text & "' ")
        cb_2.DisplayMember = "exer"
        cb_2.ValueMember = "id"
        cb_2.DataSource = dados_1

        Dim dados_2 As DataTable = GetDados("SELECT id, exer FROM tb_grupos where grupo = '" & cb_grupo.Text & "' ")
        cb_3.DisplayMember = "exer"
        cb_3.ValueMember = "id"
        cb_3.DataSource = dados_2

        Dim dados_3 As DataTable = GetDados("SELECT id, exer FROM tb_grupos where grupo = '" & cb_grupo.Text & "' ")
        cb_4.DisplayMember = "exer"
        cb_4.ValueMember = "id"
        cb_4.DataSource = dados_3

        Dim dados_4 As DataTable = GetDados("SELECT id, exer FROM tb_grupos where grupo = '" & cb_grupo.Text & "' ")
        cb_5.DisplayMember = "exer"
        cb_5.ValueMember = "id"
        cb_5.DataSource = dados_4
    End Sub

    Private Sub btn_cadt_Click(sender As Object, e As EventArgs) Handles btn_cadt.Click
        If String.IsNullOrEmpty(cb_aluno.Text) Or String.IsNullOrEmpty(cb_grupo.Text) Or String.IsNullOrEmpty(cb_1.Text) Or String.IsNullOrEmpty(cb_2.Text) Or String.IsNullOrEmpty(cb_3.Text) Or String.IsNullOrEmpty(cb_4.Text) Or String.IsNullOrEmpty(cb_5.Text) Then
            MsgBox("Preencha todos os campos!")
        Else
            sql = "select * from tb_treinos where id_aluno = " & CInt(cb_aluno.SelectedValue) & " and grupo_muscular = '" & cb_grupo.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = True Then
                sql = "INSERT INTO tb_treinos ([id_aluno], [id_fun], [grupo_muscular], [id_ex1], [id_l1], [id_ex2], [id_l2], [id_ex3], [id_l3], [id_ex4], [id_l4], [id_ex5], [id_l5]) VALUES (" & CInt(cb_aluno.SelectedValue) & ", " & p_id & ", '" & cb_grupo.Text & "', " & CInt(cb_1.SelectedValue) & ", " & CInt(cb_1.SelectedValue) & ", " & CInt(cb_2.SelectedValue) & ", " & CInt(cb_2.SelectedValue) & ", " & CInt(cb_3.SelectedValue) & ", " & CInt(cb_3.SelectedValue) & ", " & CInt(cb_4.SelectedValue) & ", " & CInt(cb_4.SelectedValue) & ", " & CInt(cb_5.SelectedValue) & ", " & CInt(cb_5.SelectedValue) & ")"
                rs = db.Execute(sql)
                MsgBox("Treino cadastrado com sucesso!")
            Else
                sql = "update tb_treinos set [id_fun] = " & p_id & ", [id_ex1] = " & CInt(cb_1.SelectedValue) & ", [id_l1] = " & CInt(cb_1.SelectedValue) & ", [id_ex2] = " & CInt(cb_2.SelectedValue) & ",  [id_l2] = " & CInt(cb_2.SelectedValue) & ", [id_ex3] = " & CInt(cb_3.SelectedValue) & ",  [id_l3] = " & CInt(cb_3.SelectedValue) & ",  [id_ex4] = " & CInt(cb_4.SelectedValue) & ",  [id_l4] = " & CInt(cb_4.SelectedValue) & ",  [id_ex5] = " & CInt(cb_5.SelectedValue) & ",  [id_l5] = " & CInt(cb_5.SelectedValue) & " where id_aluno = " & cb_aluno.SelectedValue & " and grupo_muscular = '" & cb_grupo.Text & "'"
                rs = db.Execute(sql)
                MsgBox("Treino alterado com sucesso!")
            End If
        End If
    End Sub

    Private Sub btn_return_Click(sender As Object, e As EventArgs) Handles btn_return.Click
        Me.Hide()
        Form4.Show()
    End Sub
End Class