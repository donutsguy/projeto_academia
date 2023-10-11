Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form2
    Private Sub btn_cad_alu_Click(sender As Object, e As EventArgs) Handles btn_cad_alu.Click
        If String.IsNullOrEmpty(txt_cad_cpf.Text) Or String.IsNullOrEmpty(txt_cad_nome.Text) Or String.IsNullOrEmpty(txt_cad_email.Text) Or String.IsNullOrEmpty(txt_cad_senha.Text) Or String.IsNullOrEmpty(txt_cad_csenha.Text) Or String.IsNullOrEmpty(txt_cad_cel.Text) Or String.IsNullOrEmpty(dir_foto) Or dir_foto = "OpenFileDialog1" Then
            MsgBox("Preencha todos os campos!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        ElseIf txt_cad_senha.Text <> txt_cad_csenha.Text Then
            MsgBox("As senhas não são iguais!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        ElseIf txt_cad_cpf.Text.Length < 11 Then
            MsgBox("Informe um CPF válido!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        ElseIf txt_cad_cel.Text.Length < 14 Then
            MsgBox("Informe um número de celular válido!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Else
            sql = "select * from tb_cadastro where cpf = '" & txt_cad_cpf.Text & "' or email = '" & txt_cad_email.Text & "'"
            rs = db.Execute(UCase(sql))
            If rs.EOF = True Then
                sql = "insert into tb_cadastro ([cpf], [nome], [email], [data_nasc], [celular], [senha], [status], [tipo], [foto]) values ('" & txt_cad_cpf.Text & "', '" & txt_cad_nome.Text & "', '" & txt_cad_email.Text & "', '" & txt_date.Value.Date & "', '" & txt_cad_cel.Text & "', '" & txt_cad_senha.Text & "',  'ATIVO', 'ALUNO' , '" & dir_foto & "')"
                rs = db.Execute(UCase(sql))
                MsgBox("Cadastro feito com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                limpar_dados_cad()
            Else
                sql = "update tb_cadastro set [nome] = '" & txt_cad_nome.Text & "',[email] = '" & txt_cad_cpf.Text & "', [data_nasc] = '" & txt_date.Value.Date & "', [celular] = '" & txt_cad_cel.Text & "', [senha] = '" & txt_cad_senha.Text & "', [foto] = '" & dir_foto & "' where [cpf] = '" & txt_cad_cpf.Text & "'"
                rs = db.Execute(UCase(sql))
                MsgBox("Cadastro alterado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                limpar_dados_cad()
            End If
        End If
    End Sub

    Private Sub img_cad_Click(sender As Object, e As EventArgs) Handles img_cad.Click
        Try
            With OpenFileDialog2
                .Title = "SELECIONE UMA FOTO"
                .InitialDirectory = Application.StartupPath & "\Fotos"
                .ShowDialog()
                dir_foto = .FileName
                img_cad.Load(dir_foto)
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub btn_vsenha_Click(sender As Object, e As EventArgs) Handles btn_vsenha.Click
        If txt_cad_senha.UseSystemPasswordChar = True Then
            txt_cad_senha.UseSystemPasswordChar = False
            txt_cad_csenha.UseSystemPasswordChar = False
        Else
            txt_cad_senha.UseSystemPasswordChar = True
            txt_cad_csenha.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub txt_cad_cel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cad_cel.KeyPress
        Dim maxLength As Integer = 9

        If txt_cad_cel.Text.Length >= maxLength AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        ElseIf Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_cad_cpf_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cad_cpf.KeyPress
        Dim maxLength As Integer = 11

        If txt_cad_cpf.Text.Length >= maxLength AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        ElseIf Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btn_return_Click(sender As Object, e As EventArgs) Handles btn_return.Click
        Me.Hide()
        Form4.Show()
        limpar_dados_cad()
    End Sub

    Private Sub txt_cad_nome_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cad_nome.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_cad_email_LostFocus(sender As Object, e As EventArgs) Handles txt_cad_email.LostFocus
        Dim email As String = txt_cad_email.Text.Trim()

        If Not email.Contains("@") AndAlso Not email.EndsWith(".com") Then
            email += "@hotmail.com"
            txt_cad_email.Text = email
        End If
    End Sub

End Class

