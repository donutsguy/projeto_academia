Imports System.Diagnostics
Public Class Form4
    Private accessProcess As Process
    Private Sub btn_1_Click(sender As Object, e As EventArgs) Handles btn_1.Click
        If p_tipo = "GERENTE" Then
            Me.Hide()
            carregar_dados()
            carregar_dadosf()
            Form6.Show()
        ElseIf p_tipo = "ALUNO" Then
            Me.Hide()
            Form5.Show()
        ElseIf p_tipo = "PROFESSOR" Then
            Me.Hide()
            Form7.Show()
        Else
            Me.Hide()
            Form2.Show()
        End If
    End Sub

    Private Sub btn_2_Click(sender As Object, e As EventArgs) Handles btn_2.Click
        If p_tipo = "GERENTE" Then
            Me.Hide()
            Form3.Show()
        ElseIf p_tipo = "ALUNO" Then
            Me.Hide()
            Form8.Show()
        Else
            Form6.Tabcontrol1.TabPages.Remove(Form6.tab_funcionarios)
            Me.Hide()
            carregar_dados()
            Form6.Show()
        End If
    End Sub

    Private Sub btn_3_Click(sender As Object, e As EventArgs) Handles btn_3.Click
        Dim accessFilePath As String = "E:\projeto_academia\bin\Debug\database.mdb"
        Dim reportName As String = "alunos_bloqueados"

        accessProcess = Process.Start("msaccess.exe", Chr(34) & accessFilePath & Chr(34) & " /cmd " & reportName & " /cmdline ""/cmd Report /x " & reportName & " /preview""")
    End Sub

    Private Sub btn_return_Click(sender As Object, e As EventArgs) Handles btn_return.Click
        op = MsgBox("Você desejar fazer o logout?", MsgBoxStyle.YesNo)
        If op = vbYes Then
            Me.Hide()
            Form1.Show()
        End If
    End Sub

End Class