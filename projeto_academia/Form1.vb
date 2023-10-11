Imports System.Diagnostics.Eventing.Reader
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Try
            If String.IsNullOrEmpty(txt_senha.Text) Or String.IsNullOrEmpty(txt_user.Text) Then
                MsgBox("Preencha todos os campos!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            Else
                sql = "select * from tb_cadastro where cpf = '" & txt_user.Text & "' and senha = '" & txt_senha.Text & "' or email = '" & txt_user.Text & "' and senha = '" & txt_senha.Text & "'"
                rs = db.Execute(UCase(sql))
                If rs.EOF = True Then
                    sqlf = "select * from tb_cadastro_fun where cpf = '" & txt_user.Text & "' and senha = '" & txt_senha.Text & "' or email = '" & txt_user.Text & "' and senha = '" & txt_senha.Text & "'"
                    rs = db.Execute(ucase(sqlf))
                    If rs.EOF = True Then
                        MsgBox("Usuário ou senha inválidos", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    ElseIf rs.EOF = False And rs.Fields(7).Value = "ATIVO" Then
                        MsgBox("Login feito com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                        txt_senha.Clear()
                        txt_user.Clear()
                        login_sucesso()
                    Else
                        MsgBox("Conta bloqueada!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    End If
                ElseIf rs.EOF = False And rs.Fields(7).Value = "ATIVO" Then
                    MsgBox("Login feito com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                    a_id = rs.Fields(0).Value
                    txt_senha.Clear()
                    txt_user.Clear()
                    login_sucesso()
                ElseIf rs.EOF = False And rs.Fields(7).Value <> "ATIVO" Then
                    MsgBox("Conta bloqueada!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                Else
                    MsgBox("Usuário ou senha inválidos", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                End If
            End If
        Catch ex As Exception
            MsgBox("erro: " & ex.ToString)
        End Try
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_banco()
    End Sub

    Private Sub btn_return_Click(sender As Object, e As EventArgs) Handles btn_return.Click
        op = MsgBox("Deseja realmente sair?", vbYesNo)
        If op = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles btn_ver.Click
        If txt_senha.UseSystemPasswordChar = True Then
            txt_senha.UseSystemPasswordChar = False
        Else
            txt_senha.UseSystemPasswordChar = True
        End If
    End Sub
End Class