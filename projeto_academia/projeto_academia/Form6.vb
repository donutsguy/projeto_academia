Public Class Form6
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dir_foto = ""
    End Sub

    Private Sub dgv_alu_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_alu.CellContentClick
        Try
            With dgv_alu
                If .CurrentRow.Cells(9).Selected = True Then
                    dgv_cpf = .CurrentRow.Cells(0).Value
                    If String.IsNullOrEmpty(dgv_cpf) Then
                        .CurrentRow.Cells(9).Selected = False
                    Else
                        Me.Hide()
                        form_cad.show()
                        sql = "select * from tb_cadastro where cpf = '" & dgv_cpf & "'"
                        rs = db.Execute(sql)
                        With Form2
                            .txt_cad_cpf.Text = rs.Fields(1).Value
                            .txt_cad_nome.Text = rs.Fields(2).Value
                            .txt_cad_email.Text = rs.Fields(3).Value
                            .txt_date.Value = rs.Fields(4).Value
                            .txt_cad_cel.Text = rs.Fields(5).Value
                            .txt_cad_senha.Text = rs.Fields(6).Value
                            .txt_cad_csenha.Text = rs.Fields(6).Value
                            .img_cad.Load(rs.Fields(9).Value)
                            dir_foto = rs.Fields(9).Value
                        End With
                    End If
                ElseIf .CurrentRow.Cells(10).Selected = True Then
                    dgv_cpf = .CurrentRow.Cells(0).Value
                    If String.IsNullOrEmpty(dgv_cpf) Then
                        .CurrentRow.Cells(10).Selected = False
                    Else
                        op = MsgBox("Deseja realmente excluir essa conta?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "AVISO")
                        If op = MsgBoxResult.Yes Then
                            sql = "select * from tb_cadastro where cpf = '" & dgv_cpf & "'"
                            rs = db.Execute(sql)
                            sql = "delete * from tb_treinos where id_aluno = " & rs.Fields(0).Value & ""
                            rs = db.Execute(sql)
                            sql = "delete * from tb_cadastro where cpf = '" & dgv_cpf & "'"
                            rs = db.Execute(sql)
                            MsgBox("Registro excluido com sucesso!", vbOKOnly + vbInformation, "AVISO")
                            carregar_dados()
                        End If
                    End If
                ElseIf .CurrentRow.Cells(8).Selected = True Then
                    dgv_cpf = .CurrentRow.Cells(0).Value
                    dgv_status = .CurrentRow.Cells(7).Value
                    If String.IsNullOrEmpty(dgv_cpf) Then
                        .CurrentRow.Cells(8).Selected = False
                    Else
                        If dgv_status = "ATIVO" Then
                            sql = "update tb_cadastro set [status] = 'BLOQUEADO' where cpf = '" & dgv_cpf & "'"
                            rs = db.Execute(sql)
                            carregar_dados()
                        Else
                            sql = "update tb_cadastro set [status] = 'ATIVO' where cpf = '" & dgv_cpf & "'"
                            rs = db.Execute(sql)
                            carregar_dados()
                        End If
                    End If
                End If
            End With
        Catch ex As Exception
            MsgBox("erro: " & ex.ToString)
        End Try
    End Sub

    Private Sub dgv_fun_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_fun.CellContentClick
        Try
            With dgv_fun
                If .CurrentRow.Cells(9).Selected = True Then
                    dgv_cpf = .CurrentRow.Cells(0).Value
                    If String.IsNullOrEmpty(dgv_cpf) Then
                        .CurrentRow.Cells(9).Selected = False
                    Else
                        Me.Hide()
                        form_cadf.show()
                        sql = "select * from tb_cadastro_fun where cpf = '" & dgv_cpf & "'"
                        rs = db.Execute(sql)
                        With Form3
                            .txt_cadf_cpf.Text = rs.Fields(1).Value
                            .txt_cadf_nome.Text = rs.Fields(2).Value
                            .txt_cadf_email.Text = rs.Fields(3).Value
                            .txt_datef.Value = rs.Fields(4).Value
                            .txt_cadf_cel.Text = rs.Fields(5).Value
                            .txt_cadf_senha.Text = rs.Fields(6).Value
                            .txt_cadf_csenha.Text = rs.Fields(6).Value
                            .cb_tipo.Text = rs.Fields(8).Value
                            .img_cadf.Load(rs.Fields(9).Value)
                            If rs.Fields(8).Value = "PROFESSOR" Then
                                .cb_tipo.Enabled = False
                            Else
                                .cb_tipo.Enabled = True
                            End If
                            dir_foto = rs.Fields(9).Value
                        End With
                    End If
                ElseIf .CurrentRow.Cells(10).Selected = True Then
                    dgv_cpf = .CurrentRow.Cells(0).Value
                    If String.IsNullOrEmpty(dgv_cpf) Then
                        .CurrentRow.Cells(10).Selected = False
                    Else
                        op = MsgBox("Deseja realmente excluir essa conta?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "AVISO")
                        If op = MsgBoxResult.Yes Then
                            sql = "delete * from tb_cadastro_fun where cpf = '" & dgv_cpf & "'"
                            rs = db.Execute(sql)
                            MsgBox("Registro excluido com sucesso!", vbOKOnly + vbInformation, "AVISO")
                            carregar_dadosf()
                        End If
                    End If
                ElseIf .CurrentRow.Cells(8).Selected = True Then
                    dgv_cpf = .CurrentRow.Cells(0).Value
                    dgv_status = .CurrentRow.Cells(7).Value
                    If String.IsNullOrEmpty(dgv_cpf) Then
                        .CurrentRow.Cells(8).Selected = False
                    Else
                        If dgv_status = "ATIVO" Then
                            sql = "update tb_cadastro_fun set [status] = 'BLOQUEADO' where cpf = '" & dgv_cpf & "'"
                            rs = db.Execute(sql)
                            carregar_dadosf()
                        Else
                            sql = "update tb_cadastro_fun set [status] = 'ATIVO' where cpf = '" & dgv_cpf & "'"
                            rs = db.Execute(sql)
                            carregar_dadosf()
                        End If
                    End If
                End If
            End With
        Catch ex As Exception
            MsgBox("Não é possível excluir o professor pois ele tem treinos cadastrados!")
        End Try
    End Sub

    Private Sub Form6_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Form4.Show()
    End Sub
End Class