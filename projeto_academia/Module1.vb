Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Module Module1
    Public form_login = Form1, form_cad = Form2, form_cadf = Form3, form_tela = Form4, form_treinos = Form5, form_bloqueio = Form6, form_progresso = Form7
    Public sql, sqlf, dgv_cpf, dgv_status, op, dir_foto, p_nome, p_email, p_tipo, p_cel, p_foto, l1, l2, l3 As String
    Public p_id, a_id As Integer
    Public res_imc As Double
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public dir_banco = "database.mdb"

    Sub conectar_banco()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=Microsoft.JET.OLEDB.4.0;Data source = " & dir_banco)
        Catch ex As Exception
            MsgBox("erro: " & ex.ToString)
        End Try
    End Sub

    Sub carregar_dados()
        sql = "select * from tb_cadastro order by nome asc"
        rs = db.Execute(sql)
        With Form6.dgv_alu
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(5).Value, rs.Fields(6).Value, rs.Fields(8).Value, rs.Fields(7).Value, Nothing, Nothing, Nothing)
                rs.MoveNext()
            Loop
        End With
    End Sub

    Sub carregar_dadosf()
        sql = "select * from tb_cadastro_fun where tipo = 'BALCONISTA' or tipo = 'PROFESSOR' order by nome asc"
        rs = db.Execute(sql)
        With Form6.dgv_fun
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(5).Value, rs.Fields(6).Value, rs.Fields(8).Value, rs.Fields(7).Value, Nothing, Nothing, Nothing)
                rs.MoveNext()
            Loop
        End With
    End Sub

    Sub limpar_dados_cad()
        With Form2
            .txt_cad_cpf.Clear()
            .txt_cad_nome.Clear()
            .txt_cad_email.Clear()
            .txt_cad_cel.Clear()
            .txt_cad_senha.Clear()
            .txt_cad_csenha.Clear()
            .txt_date.Value = Now
            dir_foto = ""
            .img_cad.Load("E:\projeto_academia\Fotos\8680242_image_add_fill_icon.png")
        End With
    End Sub

    Sub limpar_dados_cadf()
        With Form3
            .txt_cadf_cpf.Clear()
            .txt_cadf_nome.Clear()
            .txt_cadf_email.Clear()
            .txt_cadf_cel.Clear()
            .txt_cadf_senha.Clear()
            .txt_cadf_csenha.Clear()
            .txt_datef.Value = Now
            dir_foto = ""
            .img_cadf.Load("E:\projeto_academia\Fotos\8680242_image_add_fill_icon.png")
        End With
    End Sub

    Sub login_sucesso()
        p_id = rs.Fields(0).Value
        p_nome = rs.Fields(2).Value
        p_email = rs.Fields(3).Value
        p_cel = rs.Fields(5).Value
        p_tipo = rs.Fields(8).Value
        p_foto = rs.Fields(9).Value
        With Form4
            .lbl_ini_nome.Text = p_nome
            .lbl_nome_cliente.Text = p_nome
            .lbl_ini_email.Text = p_email
            .lbl_ini_tipo.Text = p_tipo
            .lbl_ini_cel.Text = p_cel
            .img_ini.Load(p_foto)
            If p_tipo = "GERENTE" Then
                .lbl_1.Text = "Gerenciamento"
                .lbl_1.Show()
                .btn_1.Show()
                .lbl_2.Text = "Cadastro"
                .lbl_2.Show()
                .btn_2.Show()
                .lbl_3.Show()
                .lbl_3.Text = "Relatório"
                .btn_3.Show()
            ElseIf p_tipo = "BALCONISTA" Then
                .lbl_1.Text = "Cadastro de alunos"
                .lbl_1.Show()
                .btn_1.Show()
                .lbl_2.Text = "Gerenciamento de alunos"
                .lbl_2.Show()
                .btn_2.Show()
                .lbl_3.Hide()
                .btn_3.Hide()
            ElseIf p_tipo = "PROFESSOR" Then
                .lbl_1.Text = "Cadastro de treinos"
                .lbl_1.Show()
                .btn_1.Show()
                .lbl_2.Hide()
                .btn_2.Hide()
                .lbl_3.Hide()
                .btn_3.Hide()
            Else
                .lbl_1.Text = "Treinos"
                .lbl_1.Show()
                .btn_1.Show()
                .lbl_2.Text = "Calculadora IMC"
                .lbl_2.Show()
                .btn_2.Show()
                .lbl_3.Hide()
                .btn_3.Hide()
            End If
        End With
        form_login.hide()
        form_tela.show()
    End Sub

    Sub carregar_abs()
        sql = "SELECT tb_treinos.id, tb_cadastro.nome, tb_cadastro_fun.nome,
                   g1.exer AS exer1, l1.link AS link1,
                   g2.exer AS exer2, l2.link AS link2,
                   g3.exer AS exer3, l3.link AS link3,
                   g4.exer AS exer4, l4.link AS link4,
                   g5.exer AS exer5, l5.link AS link5
                FROM (((((((((((tb_treinos
                LEFT JOIN tb_cadastro ON tb_treinos.id_aluno = tb_cadastro.id)
                LEFT JOIN tb_cadastro_fun ON tb_treinos.id_fun = tb_cadastro_fun.id)
                LEFT JOIN tb_grupos AS g1 ON tb_treinos.id_ex1 = g1.id)
                LEFT JOIN tb_grupos AS l1 ON tb_treinos.id_l1 = l1.id)
                LEFT JOIN tb_grupos AS g2 ON tb_treinos.id_ex2 = g2.id)
                LEFT JOIN tb_grupos AS l2 ON tb_treinos.id_l2 = l2.id)
                LEFT JOIN tb_grupos AS g3 ON tb_treinos.id_ex3 = g3.id)
                LEFT JOIN tb_grupos AS l3 ON tb_treinos.id_l3 = l3.id)
                LEFT JOIN tb_grupos AS g4 ON tb_treinos.id_ex4 = g4.id)
                LEFT JOIN tb_grupos AS l4 ON tb_treinos.id_l4 = l4.id)
                LEFT JOIN tb_grupos AS g5 ON tb_treinos.id_ex5 = g5.id)
                LEFT JOIN tb_grupos AS l5 ON tb_treinos.id_l5 = l5.id
                WHERE tb_cadastro.id = " & a_id & " and tb_treinos.grupo_muscular = '" & Form5.tp_ab.Text & "';"
        rs = db.Execute(sql)

        If rs.EOF = True Then
            With Form5
                .lbl_f1ex1.Text = "Peça para algum professor fazer seu treino personalizado!"
                .lbl_f1l1.Hide()
                .lbl_f1ex2.Hide()
                .lbl_f1l2.Hide()
                .lbl_f1ex3.Hide()
                .lbl_f1l3.Hide()
                .lbl_f1ex4.Hide()
                .lbl_f1l4.Hide()
                .lbl_f1ex5.Hide()
                .lbl_f1l5.Hide()
                .lbl_p1.Hide()
                .lbl_t1.Hide()
            End With
        Else
            With Form5
                .lbl_p1.Text = rs.Fields(2).Value
                .lbl_f1ex1.Text = rs.Fields(3).Value
                .lbl_f1l1.Text = rs.Fields(4).Value
                .lbl_f1ex2.Text = rs.Fields(5).Value
                .lbl_f1l2.Text = rs.Fields(6).Value
                .lbl_f1ex3.Text = rs.Fields(7).Value
                .lbl_f1l3.Text = rs.Fields(8).Value
                .lbl_f1ex4.Text = rs.Fields(9).Value
                .lbl_f1l4.Text = rs.Fields(10).Value
                .lbl_f1ex5.Text = rs.Fields(11).Value
                .lbl_f1l5.Text = rs.Fields(12).Value
            End With
        End If
    End Sub

    Sub carregar_bic()
        sql = "SELECT tb_treinos.id, tb_cadastro.nome, tb_cadastro_fun.nome,
                    g1.exer AS exer1, l1.link AS link1,
                    g2.exer AS exer2, l2.link AS link2,
                    g3.exer AS exer3, l3.link AS link3,
                    g4.exer AS exer4, l4.link AS link4,
                    g5.exer AS exer5, l5.link AS link5
                FROM (((((((((((tb_treinos
                LEFT JOIN tb_cadastro ON tb_treinos.id_aluno = tb_cadastro.id)
                LEFT JOIN tb_cadastro_fun ON tb_treinos.id_fun = tb_cadastro_fun.id)
                LEFT JOIN tb_grupos AS g1 ON tb_treinos.id_ex1 = g1.id)
                LEFT JOIN tb_grupos AS l1 ON tb_treinos.id_l1 = l1.id)
                LEFT JOIN tb_grupos AS g2 ON tb_treinos.id_ex2 = g2.id)
                LEFT JOIN tb_grupos AS l2 ON tb_treinos.id_l2 = l2.id)
                LEFT JOIN tb_grupos AS g3 ON tb_treinos.id_ex3 = g3.id)
                LEFT JOIN tb_grupos AS l3 ON tb_treinos.id_l3 = l3.id)
                LEFT JOIN tb_grupos AS g4 ON tb_treinos.id_ex4 = g4.id)
                LEFT JOIN tb_grupos AS l4 ON tb_treinos.id_l4 = l4.id)
                LEFT JOIN tb_grupos AS g5 ON tb_treinos.id_ex5 = g5.id)
                LEFT JOIN tb_grupos AS l5 ON tb_treinos.id_l5 = l5.id
                WHERE tb_cadastro.id = " & a_id & " and tb_treinos.grupo_muscular = '" & Form5.tp_bic.Text & "';"
        rs = db.Execute(sql)

        If rs.EOF = True Then
            With Form5
                .lbl_f2ex1.Text = "Peça para algum professor fazer seu treino personalizado!"
                .lbl_f2l1.Hide()
                .lbl_f2ex2.Hide()
                .lbl_f2l2.Hide()
                .lbl_f2ex3.Hide()
                .lbl_f2l3.Hide()
                .lbl_f2ex4.Hide()
                .lbl_f2l4.Hide()
                .lbl_f2ex5.Hide()
                .lbl_f2l5.Hide()
                .lbl_p2.Hide()
                .lbl_t2.Hide()
            End With
        Else
            With Form5
                .lbl_p2.Text = rs.Fields(2).Value
                .lbl_f2ex1.Text = rs.Fields(3).Value
                .lbl_f2l1.Text = rs.Fields(4).Value
                .lbl_f2ex2.Text = rs.Fields(5).Value
                .lbl_f2l2.Text = rs.Fields(6).Value
                .lbl_f2ex3.Text = rs.Fields(7).Value
                .lbl_f2l3.Text = rs.Fields(8).Value
                .lbl_f2ex4.Text = rs.Fields(9).Value
                .lbl_f2l4.Text = rs.Fields(10).Value
                .lbl_f2ex5.Text = rs.Fields(11).Value
                .lbl_f2l5.Text = rs.Fields(12).Value
            End With
        End If
    End Sub

    Sub carregar_cos()
        sql = "SELECT tb_treinos.id, tb_cadastro.nome, tb_cadastro_fun.nome,
                    g1.exer AS exer1, l1.link AS link1,
                    g2.exer AS exer2, l2.link AS link2,
                    g3.exer AS exer3, l3.link AS link3,
                    g4.exer AS exer4, l4.link AS link4,
                    g5.exer AS exer5, l5.link AS link5
                FROM (((((((((((tb_treinos
                LEFT JOIN tb_cadastro ON tb_treinos.id_aluno = tb_cadastro.id)
                LEFT JOIN tb_cadastro_fun ON tb_treinos.id_fun = tb_cadastro_fun.id)
                LEFT JOIN tb_grupos AS g1 ON tb_treinos.id_ex1 = g1.id)
                LEFT JOIN tb_grupos AS l1 ON tb_treinos.id_l1 = l1.id)
                LEFT JOIN tb_grupos AS g2 ON tb_treinos.id_ex2 = g2.id)
                LEFT JOIN tb_grupos AS l2 ON tb_treinos.id_l2 = l2.id)
                LEFT JOIN tb_grupos AS g3 ON tb_treinos.id_ex3 = g3.id)
                LEFT JOIN tb_grupos AS l3 ON tb_treinos.id_l3 = l3.id)
                LEFT JOIN tb_grupos AS g4 ON tb_treinos.id_ex4 = g4.id)
                LEFT JOIN tb_grupos AS l4 ON tb_treinos.id_l4 = l4.id)
                LEFT JOIN tb_grupos AS g5 ON tb_treinos.id_ex5 = g5.id)
                LEFT JOIN tb_grupos AS l5 ON tb_treinos.id_l5 = l5.id
                WHERE tb_cadastro.id = " & a_id & " and tb_treinos.grupo_muscular = '" & Form5.tp_cos.Text & "';"
        rs = db.Execute(sql)

        If rs.EOF = True Then
            With Form5
                .lbl_f3ex1.Text = "Peça para algum professor fazer seu treino personalizado!"
                .lbl_f3l1.Hide()
                .lbl_f3ex2.Hide()
                .lbl_f3l2.Hide()
                .lbl_f3ex3.Hide()
                .lbl_f3l3.Hide()
                .lbl_f3ex4.Hide()
                .lbl_f3l4.Hide()
                .lbl_f3ex5.Hide()
                .lbl_f3l5.Hide()
                .lbl_p3.Hide()
                .lbl_t3.Hide()
            End With
        Else
            With Form5
                .lbl_p3.Text = rs.Fields(2).Value
                .lbl_f3ex1.Text = rs.Fields(3).Value
                .lbl_f3l1.Text = rs.Fields(4).Value
                .lbl_f3ex2.Text = rs.Fields(5).Value
                .lbl_f3l2.Text = rs.Fields(6).Value
                .lbl_f3ex3.Text = rs.Fields(7).Value
                .lbl_f3l3.Text = rs.Fields(8).Value
                .lbl_f3ex4.Text = rs.Fields(9).Value
                .lbl_f3l4.Text = rs.Fields(10).Value
                .lbl_f3ex5.Text = rs.Fields(11).Value
                .lbl_f3l5.Text = rs.Fields(12).Value
            End With
        End If
    End Sub

    Sub carregar_glu()
        sql = "SELECT tb_treinos.id, tb_cadastro.nome, tb_cadastro_fun.nome,
                    g1.exer AS exer1, l1.link AS link1,
                    g2.exer AS exer2, l2.link AS link2,
                    g3.exer AS exer3, l3.link AS link3,
                    g4.exer AS exer4, l4.link AS link4,
                    g5.exer AS exer5, l5.link AS link5
                FROM (((((((((((tb_treinos
                LEFT JOIN tb_cadastro ON tb_treinos.id_aluno = tb_cadastro.id)
                LEFT JOIN tb_cadastro_fun ON tb_treinos.id_fun = tb_cadastro_fun.id)
                LEFT JOIN tb_grupos AS g1 ON tb_treinos.id_ex1 = g1.id)
                LEFT JOIN tb_grupos AS l1 ON tb_treinos.id_l1 = l1.id)
                LEFT JOIN tb_grupos AS g2 ON tb_treinos.id_ex2 = g2.id)
                LEFT JOIN tb_grupos AS l2 ON tb_treinos.id_l2 = l2.id)
                LEFT JOIN tb_grupos AS g3 ON tb_treinos.id_ex3 = g3.id)
                LEFT JOIN tb_grupos AS l3 ON tb_treinos.id_l3 = l3.id)
                LEFT JOIN tb_grupos AS g4 ON tb_treinos.id_ex4 = g4.id)
                LEFT JOIN tb_grupos AS l4 ON tb_treinos.id_l4 = l4.id)
                LEFT JOIN tb_grupos AS g5 ON tb_treinos.id_ex5 = g5.id)
                LEFT JOIN tb_grupos AS l5 ON tb_treinos.id_l5 = l5.id
                WHERE tb_cadastro.id = " & a_id & " and tb_treinos.grupo_muscular = '" & Form5.tp_glu.Text & "';"
        rs = db.Execute(sql)

        If rs.EOF = True Then
            With Form5
                .lbl_f4ex1.Text = "Peça para algum professor fazer seu treino personalizado!"
                .lbl_f4l1.Hide()
                .lbl_f4ex2.Hide()
                .lbl_f4l2.Hide()
                .lbl_f4ex3.Hide()
                .lbl_f4l3.Hide()
                .lbl_f4ex4.Hide()
                .lbl_f4l4.Hide()
                .lbl_f4ex5.Hide()
                .lbl_f4l5.Hide()
                .lbl_p4.Hide()
                .lbl_t4.Hide()
            End With
        Else
            With Form5
                .lbl_p4.Text = rs.Fields(2).Value
                .lbl_f4ex1.Text = rs.Fields(3).Value
                .lbl_f4l1.Text = rs.Fields(4).Value
                .lbl_f4ex2.Text = rs.Fields(5).Value
                .lbl_f4l2.Text = rs.Fields(6).Value
                .lbl_f4ex3.Text = rs.Fields(7).Value
                .lbl_f4l3.Text = rs.Fields(8).Value
                .lbl_f4ex4.Text = rs.Fields(9).Value
                .lbl_f4l4.Text = rs.Fields(10).Value
                .lbl_f4ex5.Text = rs.Fields(11).Value
                .lbl_f4l5.Text = rs.Fields(12).Value
            End With
        End If
    End Sub

    Sub carregar_omb()
        sql = "SELECT tb_treinos.id, tb_cadastro.nome, tb_cadastro_fun.nome,
                    g1.exer AS exer1, l1.link AS link1,
                    g2.exer AS exer2, l2.link AS link2,
                    g3.exer AS exer3, l3.link AS link3,
                    g4.exer AS exer4, l4.link AS link4,
                    g5.exer AS exer5, l5.link AS link5
                FROM (((((((((((tb_treinos
                LEFT JOIN tb_cadastro ON tb_treinos.id_aluno = tb_cadastro.id)
                LEFT JOIN tb_cadastro_fun ON tb_treinos.id_fun = tb_cadastro_fun.id)
                LEFT JOIN tb_grupos AS g1 ON tb_treinos.id_ex1 = g1.id)
                LEFT JOIN tb_grupos AS l1 ON tb_treinos.id_l1 = l1.id)
                LEFT JOIN tb_grupos AS g2 ON tb_treinos.id_ex2 = g2.id)
                LEFT JOIN tb_grupos AS l2 ON tb_treinos.id_l2 = l2.id)
                LEFT JOIN tb_grupos AS g3 ON tb_treinos.id_ex3 = g3.id)
                LEFT JOIN tb_grupos AS l3 ON tb_treinos.id_l3 = l3.id)
                LEFT JOIN tb_grupos AS g4 ON tb_treinos.id_ex4 = g4.id)
                LEFT JOIN tb_grupos AS l4 ON tb_treinos.id_l4 = l4.id)
                LEFT JOIN tb_grupos AS g5 ON tb_treinos.id_ex5 = g5.id)
                LEFT JOIN tb_grupos AS l5 ON tb_treinos.id_l5 = l5.id
                WHERE tb_cadastro.id = " & a_id & " and tb_treinos.grupo_muscular = '" & Form5.tp_omb.Text & "';"
        rs = db.Execute(sql)

        If rs.EOF = True Then
            With Form5
                .lbl_f5ex1.Text = "Peça para algum professor fazer seu treino personalizado!"
                .lbl_f5l1.Hide()
                .lbl_f5ex2.Hide()
                .lbl_f5l2.Hide()
                .lbl_f5ex3.Hide()
                .lbl_f5l3.Hide()
                .lbl_f5ex4.Hide()
                .lbl_f5l4.Hide()
                .lbl_f5ex5.Hide()
                .lbl_f5l5.Hide()
                .lbl_p5.Hide()
                .lbl_t5.Hide()
            End With
        Else
            With Form5
                .lbl_p5.Text = rs.Fields(2).Value
                .lbl_f5ex1.Text = rs.Fields(3).Value
                .lbl_f5l1.Text = rs.Fields(4).Value
                .lbl_f5ex2.Text = rs.Fields(5).Value
                .lbl_f5l2.Text = rs.Fields(6).Value
                .lbl_f5ex3.Text = rs.Fields(7).Value
                .lbl_f5l3.Text = rs.Fields(8).Value
                .lbl_f5ex4.Text = rs.Fields(9).Value
                .lbl_f5l4.Text = rs.Fields(10).Value
                .lbl_f5ex5.Text = rs.Fields(11).Value
                .lbl_f5l5.Text = rs.Fields(12).Value
            End With
        End If
    End Sub

    Sub carregar_pan()
        sql = "SELECT tb_treinos.id, tb_cadastro.nome, tb_cadastro_fun.nome,
                    g1.exer AS exer1, l1.link AS link1,
                    g2.exer AS exer2, l2.link AS link2,
                    g3.exer AS exer3, l3.link AS link3,
                    g4.exer AS exer4, l4.link AS link4,
                    g5.exer AS exer5, l5.link AS link5
                FROM (((((((((((tb_treinos
                LEFT JOIN tb_cadastro ON tb_treinos.id_aluno = tb_cadastro.id)
                LEFT JOIN tb_cadastro_fun ON tb_treinos.id_fun = tb_cadastro_fun.id)
                LEFT JOIN tb_grupos AS g1 ON tb_treinos.id_ex1 = g1.id)
                LEFT JOIN tb_grupos AS l1 ON tb_treinos.id_l1 = l1.id)
                LEFT JOIN tb_grupos AS g2 ON tb_treinos.id_ex2 = g2.id)
                LEFT JOIN tb_grupos AS l2 ON tb_treinos.id_l2 = l2.id)
                LEFT JOIN tb_grupos AS g3 ON tb_treinos.id_ex3 = g3.id)
                LEFT JOIN tb_grupos AS l3 ON tb_treinos.id_l3 = l3.id)
                LEFT JOIN tb_grupos AS g4 ON tb_treinos.id_ex4 = g4.id)
                LEFT JOIN tb_grupos AS l4 ON tb_treinos.id_l4 = l4.id)
                LEFT JOIN tb_grupos AS g5 ON tb_treinos.id_ex5 = g5.id)
                LEFT JOIN tb_grupos AS l5 ON tb_treinos.id_l5 = l5.id
                WHERE tb_cadastro.id = " & a_id & " and tb_treinos.grupo_muscular = '" & Form5.tp_pan.Text & "';"
        rs = db.Execute(sql)

        If rs.EOF = True Then
            With Form5
                .lbl_f6ex1.Text = "Peça para algum professor fazer seu treino personalizado!"
                .lbl_f6l1.Hide()
                .lbl_f6ex2.Hide()
                .lbl_f6l2.Hide()
                .lbl_f6ex3.Hide()
                .lbl_f6l3.Hide()
                .lbl_f6ex4.Hide()
                .lbl_f6l4.Hide()
                .lbl_f6ex5.Hide()
                .lbl_f6l5.Hide()
                .lbl_p6.Hide()
                .lbl_t6.Hide()
            End With
        Else
            With Form5
                .lbl_p6.Text = rs.Fields(2).Value
                .lbl_f6ex1.Text = rs.Fields(3).Value
                .lbl_f6l1.Text = rs.Fields(4).Value
                .lbl_f6ex2.Text = rs.Fields(5).Value
                .lbl_f6l2.Text = rs.Fields(6).Value
                .lbl_f6ex3.Text = rs.Fields(7).Value
                .lbl_f6l3.Text = rs.Fields(8).Value
                .lbl_f6ex4.Text = rs.Fields(9).Value
                .lbl_f6l4.Text = rs.Fields(10).Value
                .lbl_f6ex5.Text = rs.Fields(11).Value
                .lbl_f6l5.Text = rs.Fields(12).Value
            End With
        End If
    End Sub

    Sub carregar_pei()
        sql = "SELECT tb_treinos.id, tb_cadastro.nome, tb_cadastro_fun.nome,
                    g1.exer AS exer1, l1.link AS link1,
                    g2.exer AS exer2, l2.link AS link2,
                    g3.exer AS exer3, l3.link AS link3,
                    g4.exer AS exer4, l4.link AS link4,
                    g5.exer AS exer5, l5.link AS link5
                FROM (((((((((((tb_treinos
                LEFT JOIN tb_cadastro ON tb_treinos.id_aluno = tb_cadastro.id)
                LEFT JOIN tb_cadastro_fun ON tb_treinos.id_fun = tb_cadastro_fun.id)
                LEFT JOIN tb_grupos AS g1 ON tb_treinos.id_ex1 = g1.id)
                LEFT JOIN tb_grupos AS l1 ON tb_treinos.id_l1 = l1.id)
                LEFT JOIN tb_grupos AS g2 ON tb_treinos.id_ex2 = g2.id)
                LEFT JOIN tb_grupos AS l2 ON tb_treinos.id_l2 = l2.id)
                LEFT JOIN tb_grupos AS g3 ON tb_treinos.id_ex3 = g3.id)
                LEFT JOIN tb_grupos AS l3 ON tb_treinos.id_l3 = l3.id)
                LEFT JOIN tb_grupos AS g4 ON tb_treinos.id_ex4 = g4.id)
                LEFT JOIN tb_grupos AS l4 ON tb_treinos.id_l4 = l4.id)
                LEFT JOIN tb_grupos AS g5 ON tb_treinos.id_ex5 = g5.id)
                LEFT JOIN tb_grupos AS l5 ON tb_treinos.id_l5 = l5.id
                WHERE tb_cadastro.id = " & a_id & " and tb_treinos.grupo_muscular = '" & Form5.tp_pei.Text & "';"
        rs = db.Execute(sql)

        If rs.EOF = True Then
            With Form5
                .lbl_f7ex1.Text = "Peça para algum professor fazer seu treino personalizado!"
                .lbl_f7l1.Hide()
                .lbl_f7ex2.Hide()
                .lbl_f7l2.Hide()
                .lbl_f7ex3.Hide()
                .lbl_f7l3.Hide()
                .lbl_f7ex4.Hide()
                .lbl_f7l4.Hide()
                .lbl_f7ex5.Hide()
                .lbl_f7l5.Hide()
                .lbl_p7.Hide()
                .lbl_t7.Hide()
            End With
        Else
            With Form5
                .lbl_p7.Text = rs.Fields(2).Value
                .lbl_f7ex1.Text = rs.Fields(3).Value
                .lbl_f7l1.Text = rs.Fields(4).Value
                .lbl_f7ex2.Text = rs.Fields(5).Value
                .lbl_f7l2.Text = rs.Fields(6).Value
                .lbl_f7ex3.Text = rs.Fields(7).Value
                .lbl_f7l3.Text = rs.Fields(8).Value
                .lbl_f7ex4.Text = rs.Fields(9).Value
                .lbl_f7l4.Text = rs.Fields(10).Value
                .lbl_f7ex5.Text = rs.Fields(11).Value
                .lbl_f7l5.Text = rs.Fields(12).Value
            End With
        End If
    End Sub

    Sub carregar_pos()
        sql = "SELECT tb_treinos.id, tb_cadastro.nome, tb_cadastro_fun.nome,
                    g1.exer AS exer1, l1.link AS link1,
                    g2.exer AS exer2, l2.link AS link2,
                    g3.exer AS exer3, l3.link AS link3,
                    g4.exer AS exer4, l4.link AS link4,
                    g5.exer AS exer5, l5.link AS link5
                FROM (((((((((((tb_treinos
                LEFT JOIN tb_cadastro ON tb_treinos.id_aluno = tb_cadastro.id)
                LEFT JOIN tb_cadastro_fun ON tb_treinos.id_fun = tb_cadastro_fun.id)
                LEFT JOIN tb_grupos AS g1 ON tb_treinos.id_ex1 = g1.id)
                LEFT JOIN tb_grupos AS l1 ON tb_treinos.id_l1 = l1.id)
                LEFT JOIN tb_grupos AS g2 ON tb_treinos.id_ex2 = g2.id)
                LEFT JOIN tb_grupos AS l2 ON tb_treinos.id_l2 = l2.id)
                LEFT JOIN tb_grupos AS g3 ON tb_treinos.id_ex3 = g3.id)
                LEFT JOIN tb_grupos AS l3 ON tb_treinos.id_l3 = l3.id)
                LEFT JOIN tb_grupos AS g4 ON tb_treinos.id_ex4 = g4.id)
                LEFT JOIN tb_grupos AS l4 ON tb_treinos.id_l4 = l4.id)
                LEFT JOIN tb_grupos AS g5 ON tb_treinos.id_ex5 = g5.id)
                LEFT JOIN tb_grupos AS l5 ON tb_treinos.id_l5 = l5.id
                WHERE tb_cadastro.id = " & a_id & " and tb_treinos.grupo_muscular = '" & Form5.tp_pos.Text & "';"
        rs = db.Execute(sql)

        If rs.EOF = True Then
            With Form5
                .lbl_f8ex1.Text = "Peça para algum professor fazer seu treino personalizado!"
                .lbl_f8l1.Hide()
                .lbl_f8ex2.Hide()
                .lbl_f8l2.Hide()
                .lbl_f8ex3.Hide()
                .lbl_f8l3.Hide()
                .lbl_f8ex4.Hide()
                .lbl_f8l4.Hide()
                .lbl_f8ex5.Hide()
                .lbl_f8l5.Hide()
                .lbl_p8.Hide()
                .lbl_t8.Hide()
            End With
        Else
            With Form5
                .lbl_p8.Text = rs.Fields(2).Value
                .lbl_f8ex1.Text = rs.Fields(3).Value
                .lbl_f8l1.Text = rs.Fields(4).Value
                .lbl_f8ex2.Text = rs.Fields(5).Value
                .lbl_f8l2.Text = rs.Fields(6).Value
                .lbl_f8ex3.Text = rs.Fields(7).Value
                .lbl_f8l3.Text = rs.Fields(8).Value
                .lbl_f8ex4.Text = rs.Fields(9).Value
                .lbl_f8l4.Text = rs.Fields(10).Value
                .lbl_f8ex5.Text = rs.Fields(11).Value
                .lbl_f8l5.Text = rs.Fields(12).Value
            End With
        End If
    End Sub

    Sub carregar_qua()
        sql = "SELECT tb_treinos.id, tb_cadastro.nome, tb_cadastro_fun.nome,
                    g1.exer AS exer1, l1.link AS link1,
                    g2.exer AS exer2, l2.link AS link2,
                    g3.exer AS exer3, l3.link AS link3,
                    g4.exer AS exer4, l4.link AS link4,
                    g5.exer AS exer5, l5.link AS link5
                FROM (((((((((((tb_treinos
                LEFT JOIN tb_cadastro ON tb_treinos.id_aluno = tb_cadastro.id)
                LEFT JOIN tb_cadastro_fun ON tb_treinos.id_fun = tb_cadastro_fun.id)
                LEFT JOIN tb_grupos AS g1 ON tb_treinos.id_ex1 = g1.id)
                LEFT JOIN tb_grupos AS l1 ON tb_treinos.id_l1 = l1.id)
                LEFT JOIN tb_grupos AS g2 ON tb_treinos.id_ex2 = g2.id)
                LEFT JOIN tb_grupos AS l2 ON tb_treinos.id_l2 = l2.id)
                LEFT JOIN tb_grupos AS g3 ON tb_treinos.id_ex3 = g3.id)
                LEFT JOIN tb_grupos AS l3 ON tb_treinos.id_l3 = l3.id)
                LEFT JOIN tb_grupos AS g4 ON tb_treinos.id_ex4 = g4.id)
                LEFT JOIN tb_grupos AS l4 ON tb_treinos.id_l4 = l4.id)
                LEFT JOIN tb_grupos AS g5 ON tb_treinos.id_ex5 = g5.id)
                LEFT JOIN tb_grupos AS l5 ON tb_treinos.id_l5 = l5.id
                WHERE tb_cadastro.id = " & a_id & " and tb_treinos.grupo_muscular = '" & Form5.tp_qua.Text & "';"
        rs = db.Execute(sql)

        If rs.EOF = True Then
            With Form5
                .lbl_f9ex1.Text = "Peça para algum professor fazer seu treino personalizado!"
                .lbl_f9l1.Hide()
                .lbl_f9ex2.Hide()
                .lbl_f9l2.Hide()
                .lbl_f9ex3.Hide()
                .lbl_f9l3.Hide()
                .lbl_f9ex4.Hide()
                .lbl_f9l4.Hide()
                .lbl_f9ex5.Hide()
                .lbl_f9l5.Hide()
                .lbl_p9.Hide()
                .lbl_t9.Hide()
            End With
        Else
            With Form5
                .lbl_p9.Text = rs.Fields(2).Value
                .lbl_f9ex1.Text = rs.Fields(3).Value
                .lbl_f9l1.Text = rs.Fields(4).Value
                .lbl_f9ex2.Text = rs.Fields(5).Value
                .lbl_f9l2.Text = rs.Fields(6).Value
                .lbl_f9ex3.Text = rs.Fields(7).Value
                .lbl_f9l3.Text = rs.Fields(8).Value
                .lbl_f9ex4.Text = rs.Fields(9).Value
                .lbl_f9l4.Text = rs.Fields(10).Value
                .lbl_f9ex5.Text = rs.Fields(11).Value
                .lbl_f9l5.Text = rs.Fields(12).Value
            End With
        End If
    End Sub

    Sub carregar_tri()
        sql = "SELECT tb_treinos.id, tb_cadastro.nome, tb_cadastro_fun.nome,
                    g1.exer AS exer1, l1.link AS link1,
                    g2.exer AS exer2, l2.link AS link2,
                    g3.exer AS exer3, l3.link AS link3,
                    g4.exer AS exer4, l4.link AS link4,
                    g5.exer AS exer5, l5.link AS link5
                FROM (((((((((((tb_treinos
                LEFT JOIN tb_cadastro ON tb_treinos.id_aluno = tb_cadastro.id)
                LEFT JOIN tb_cadastro_fun ON tb_treinos.id_fun = tb_cadastro_fun.id)
                LEFT JOIN tb_grupos AS g1 ON tb_treinos.id_ex1 = g1.id)
                LEFT JOIN tb_grupos AS l1 ON tb_treinos.id_l1 = l1.id)
                LEFT JOIN tb_grupos AS g2 ON tb_treinos.id_ex2 = g2.id)
                LEFT JOIN tb_grupos AS l2 ON tb_treinos.id_l2 = l2.id)
                LEFT JOIN tb_grupos AS g3 ON tb_treinos.id_ex3 = g3.id)
                LEFT JOIN tb_grupos AS l3 ON tb_treinos.id_l3 = l3.id)
                LEFT JOIN tb_grupos AS g4 ON tb_treinos.id_ex4 = g4.id)
                LEFT JOIN tb_grupos AS l4 ON tb_treinos.id_l4 = l4.id)
                LEFT JOIN tb_grupos AS g5 ON tb_treinos.id_ex5 = g5.id)
                LEFT JOIN tb_grupos AS l5 ON tb_treinos.id_l5 = l5.id
                WHERE tb_cadastro.id = " & a_id & " and tb_treinos.grupo_muscular = '" & Form5.tp_tri.Text & "';"
        rs = db.Execute(sql)

        If rs.EOF = True Then
            With Form5
                .lbl_f10ex1.Text = "Peça para algum professor fazer seu treino personalizado!"
                .lbl_f10l1.Hide()
                .lbl_f10ex2.Hide()
                .lbl_f10l2.Hide()
                .lbl_f10ex3.Hide()
                .lbl_f10l3.Hide()
                .lbl_f10ex4.Hide()
                .lbl_f10l4.Hide()
                .lbl_f10ex5.Hide()
                .lbl_f10l5.Hide()
                .lbl_p10.Hide()
                .lbl_t10.Hide()
            End With
        Else
            With Form5
                .lbl_p10.Text = rs.Fields(2).Value
                .lbl_f10ex1.Text = rs.Fields(3).Value
                .lbl_f10l1.Text = rs.Fields(4).Value
                .lbl_f10ex2.Text = rs.Fields(5).Value
                .lbl_f10l2.Text = rs.Fields(6).Value
                .lbl_f10ex3.Text = rs.Fields(7).Value
                .lbl_f10l3.Text = rs.Fields(8).Value
                .lbl_f10ex4.Text = rs.Fields(9).Value
                .lbl_f10l4.Text = rs.Fields(10).Value
                .lbl_f10ex5.Text = rs.Fields(11).Value
                .lbl_f10l5.Text = rs.Fields(12).Value
            End With
        End If
    End Sub

End Module
