Public Class Form8
    Private Sub btn_imc_Click(sender As Object, e As EventArgs) Handles btn_imc.Click
        If String.IsNullOrEmpty(txt_peso.Text) Or String.IsNullOrEmpty(txt_altura.Text) Then
            MsgBox("Preencha todos os campos!")
        Else
            res_imc = CDbl(txt_peso.Text * 10000) / (CDbl(txt_altura.Text ^ 2))
            lbl_res.Text = Math.Round(res_imc, 2)
            lbl_res.Show()
            If res_imc < 18.5 Then
                lbl_desc.Text = "Seu IMC está abaixo da média!" & vbNewLine & "Procure ajuda médica o quanto antes! "
                lbl_desc.Show()
            ElseIf res_imc < 24.9 Then
                lbl_desc.Text = "Seu IMC esta na média!" & vbNewLine & "Continue com os acompanhamentos médicos! "
                lbl_desc.Show()
            ElseIf res_imc < 29.9 Then
                lbl_desc.Text = "Seu IMC está começando a ficar acima da média!" & vbNewLine & "Procure ajuda médica para normalizar a sua situação!"
                lbl_desc.Show()
            ElseIf res_imc < 39.9 Then
                lbl_desc.Text = "Seu IMC está acima da média!" & vbNewLine & "Procure ajuda médica o quanto antes!"
                lbl_desc.Show()
            Else
                lbl_desc.Text = "Seu IMC está num nível de obesidade mórbida!" & vbNewLine & "Procure ajuda médica IMEDIATAMENTE!"
                lbl_desc.Show()
            End If
        End If
    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_desc.Hide()
        lbl_res.Hide()
    End Sub

    Private Sub btn_return_Click(sender As Object, e As EventArgs) Handles btn_return.Click
        Me.Hide()
        Form4.Show()
    End Sub
End Class