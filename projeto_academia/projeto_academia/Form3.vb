Public Class Form3
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        If String.IsNullOrEmpty(txt_cadf_cpf.Text) Or String.IsNullOrEmpty(txt_cadf_nome.Text) Or String.IsNullOrEmpty(txt_cadf_email.Text) Or String.IsNullOrEmpty(txt_cadf_senha.Text) Or String.IsNullOrEmpty(txt_cadf_csenha.Text) Or String.IsNullOrEmpty(txt_cadf_cel.Text) Or String.IsNullOrEmpty(cb_tipo.Text) Or String.IsNullOrEmpty(dir_foto) Or dir_foto = "OpenFileDialog1" Then
            MsgBox("Preencha todos os campos!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        ElseIf txt_cadf_senha.Text <> txt_cadf_csenha.Text Then
            MsgBox("As senhas não são iguais!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        ElseIf txt_cadf_cpf.Text.Length < 11 Then
            MsgBox("Informe um CPF válido!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        ElseIf txt_cadf_cel.Text.Length < 14 Then
            MsgBox("Informe um número de celular válido!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Else
            sql = "select * from tb_cadastro_fun where cpf = '" & txt_cadf_cpf.Text & "' or email = '" & txt_cadf_email.Text & "'"
            rs = db.Execute(UCase(sql))
            If rs.EOF = True Then
                sql = "insert into tb_cadastro_fun ([cpf], [nome], [email], [data_nasc], [celular], [senha], [status], [tipo], [foto]) values ('" & txt_cadf_cpf.Text & "', '" & txt_cadf_nome.Text & "', '" & txt_cadf_email.Text & "', '" & txt_datef.Value.Date & "', '" & txt_cadf_cel.Text & "', '" & txt_cadf_senha.Text & "',  'ATIVO', '" & cb_tipo.Text & "', '" & dir_foto & "')"
                rs = db.Execute(UCase(sql))
                MsgBox("Cadastro feito com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                limpar_dados_cadf()
            Else
                sql = "update tb_cadastro_fun set [nome] = '" & txt_cadf_nome.Text & "',[email] = '" & txt_cadf_cpf.Text & "', [data_nasc] = '" & txt_datef.Value.Date & "', [celular] = '" & txt_cadf_cel.Text & "', [senha] = '" & txt_cadf_senha.Text & "', [foto] = '" & dir_foto & "', [tipo] = '" & cb_tipo.Text & "' where [cpf] = '" & txt_cadf_cpf.Text & "'"
                rs = db.Execute(UCase(sql))
                MsgBox("Cadastro alterado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                limpar_dados_cadf()
            End If
        End If
    End Sub

    Private Sub img_cadf_Click(sender As Object, e As EventArgs) Handles img_cadf.Click
        Try
            With OpenFileDialog1
                .Title = "SELECIONE UMA FOTO"
                .InitialDirectory = Application.StartupPath & "\Fotos"
                .ShowDialog()
                dir_foto = .FileName
                img_cadf.Load(dir_foto)
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub btn_vsenhaf_Click(sender As Object, e As EventArgs) Handles btn_vsenhaf.Click
        If txt_cadf_senha.UseSystemPasswordChar = True Then
            txt_cadf_senha.UseSystemPasswordChar = False
            txt_cadf_csenha.UseSystemPasswordChar = False
        Else
            txt_cadf_senha.UseSystemPasswordChar = True
            txt_cadf_csenha.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub txt_cadf_cel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cadf_cel.KeyPress
        Dim maxLength As Integer = 9

        If txt_cadf_cel.Text.Length >= maxLength AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        ElseIf Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_cadf_cpf_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cadf_cpf.KeyPress
        Dim maxLength As Integer = 11

        If txt_cadf_cpf.Text.Length >= maxLength AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        ElseIf Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btn_return_Click(sender As Object, e As EventArgs) Handles btn_return.Click
        Me.Hide()
        cb_tipo.Enabled = True
        limpar_dados_cadf()
        Form4.Show()
    End Sub

    Private Sub txt_cadf_nome_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cadf_nome.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_cadf_email_LostFocus(sender As Object, e As EventArgs) Handles txt_cadf_email.LostFocus
        Dim email As String = txt_cadf_email.Text.Trim()

        If Not email.Contains("@") AndAlso Not email.EndsWith(".com") Then
            email += "@hotmail.com"
            txt_cadf_email.Text = email
        End If
    End Sub
End Class