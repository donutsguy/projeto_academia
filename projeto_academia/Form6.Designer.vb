<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form6
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        Me.dgv_alu = New System.Windows.Forms.DataGridView()
        Me.cpf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Data_nasc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Celular = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Senha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Atvbloq = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Edita = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Excluir = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Tabcontrol1 = New System.Windows.Forms.TabControl()
        Me.tab_alunos = New System.Windows.Forms.TabPage()
        Me.tab_funcionarios = New System.Windows.Forms.TabPage()
        Me.dgv_fun = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewButtonColumn1 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        CType(Me.dgv_alu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tabcontrol1.SuspendLayout()
        Me.tab_alunos.SuspendLayout()
        Me.tab_funcionarios.SuspendLayout()
        CType(Me.dgv_fun, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_alu
        '
        Me.dgv_alu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_alu.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cpf, Me.Nome, Me.Email, Me.Data_nasc, Me.Celular, Me.Senha, Me.Tipo, Me.Status, Me.Atvbloq, Me.Edita, Me.Excluir})
        Me.dgv_alu.Location = New System.Drawing.Point(0, 0)
        Me.dgv_alu.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.dgv_alu.Name = "dgv_alu"
        Me.dgv_alu.RowHeadersWidth = 51
        Me.dgv_alu.Size = New System.Drawing.Size(1494, 448)
        Me.dgv_alu.TabIndex = 0
        '
        'cpf
        '
        Me.cpf.HeaderText = "CPF"
        Me.cpf.MinimumWidth = 6
        Me.cpf.Name = "cpf"
        Me.cpf.Width = 125
        '
        'Nome
        '
        Me.Nome.HeaderText = "Nome"
        Me.Nome.MinimumWidth = 6
        Me.Nome.Name = "Nome"
        Me.Nome.Width = 125
        '
        'Email
        '
        Me.Email.HeaderText = "Email"
        Me.Email.MinimumWidth = 6
        Me.Email.Name = "Email"
        Me.Email.Width = 125
        '
        'Data_nasc
        '
        Me.Data_nasc.HeaderText = "Data de nascimento"
        Me.Data_nasc.MinimumWidth = 6
        Me.Data_nasc.Name = "Data_nasc"
        Me.Data_nasc.Width = 125
        '
        'Celular
        '
        Me.Celular.HeaderText = "Celular"
        Me.Celular.MinimumWidth = 6
        Me.Celular.Name = "Celular"
        Me.Celular.Width = 125
        '
        'Senha
        '
        Me.Senha.HeaderText = "Senha"
        Me.Senha.MinimumWidth = 6
        Me.Senha.Name = "Senha"
        Me.Senha.Width = 125
        '
        'Tipo
        '
        Me.Tipo.HeaderText = "Tipo"
        Me.Tipo.MinimumWidth = 6
        Me.Tipo.Name = "Tipo"
        Me.Tipo.Width = 125
        '
        'Status
        '
        Me.Status.HeaderText = "Status"
        Me.Status.MinimumWidth = 6
        Me.Status.Name = "Status"
        Me.Status.Width = 125
        '
        'Atvbloq
        '
        Me.Atvbloq.HeaderText = "Ativar/Bloquear"
        Me.Atvbloq.MinimumWidth = 6
        Me.Atvbloq.Name = "Atvbloq"
        Me.Atvbloq.Width = 125
        '
        'Edita
        '
        Me.Edita.HeaderText = "Editar"
        Me.Edita.Image = CType(resources.GetObject("Edita.Image"), System.Drawing.Image)
        Me.Edita.MinimumWidth = 6
        Me.Edita.Name = "Edita"
        Me.Edita.Width = 125
        '
        'Excluir
        '
        Me.Excluir.HeaderText = "Excluir"
        Me.Excluir.MinimumWidth = 6
        Me.Excluir.Name = "Excluir"
        Me.Excluir.Width = 125
        '
        'Tabcontrol1
        '
        Me.Tabcontrol1.Controls.Add(Me.tab_alunos)
        Me.Tabcontrol1.Controls.Add(Me.tab_funcionarios)
        Me.Tabcontrol1.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Tabcontrol1.Location = New System.Drawing.Point(-2, 0)
        Me.Tabcontrol1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Tabcontrol1.Name = "Tabcontrol1"
        Me.Tabcontrol1.SelectedIndex = 0
        Me.Tabcontrol1.Size = New System.Drawing.Size(1494, 488)
        Me.Tabcontrol1.TabIndex = 1
        '
        'tab_alunos
        '
        Me.tab_alunos.Controls.Add(Me.dgv_alu)
        Me.tab_alunos.Location = New System.Drawing.Point(4, 23)
        Me.tab_alunos.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.tab_alunos.Name = "tab_alunos"
        Me.tab_alunos.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.tab_alunos.Size = New System.Drawing.Size(1486, 461)
        Me.tab_alunos.TabIndex = 0
        Me.tab_alunos.Text = "Alunos"
        Me.tab_alunos.UseVisualStyleBackColor = True
        '
        'tab_funcionarios
        '
        Me.tab_funcionarios.Controls.Add(Me.dgv_fun)
        Me.tab_funcionarios.Location = New System.Drawing.Point(4, 23)
        Me.tab_funcionarios.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.tab_funcionarios.Name = "tab_funcionarios"
        Me.tab_funcionarios.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.tab_funcionarios.Size = New System.Drawing.Size(1486, 461)
        Me.tab_funcionarios.TabIndex = 1
        Me.tab_funcionarios.Text = "Funcionários"
        Me.tab_funcionarios.UseVisualStyleBackColor = True
        '
        'dgv_fun
        '
        Me.dgv_fun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_fun.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewButtonColumn1, Me.DataGridViewImageColumn1, Me.DataGridViewImageColumn2})
        Me.dgv_fun.Location = New System.Drawing.Point(0, 0)
        Me.dgv_fun.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.dgv_fun.Name = "dgv_fun"
        Me.dgv_fun.RowHeadersWidth = 51
        Me.dgv_fun.Size = New System.Drawing.Size(1494, 488)
        Me.dgv_fun.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "CPF"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nome"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Data de nascimento"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Celular"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Senha"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 125
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "Tipo"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 125
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 125
        '
        'DataGridViewButtonColumn1
        '
        Me.DataGridViewButtonColumn1.HeaderText = "Ativar/Bloquear"
        Me.DataGridViewButtonColumn1.MinimumWidth = 6
        Me.DataGridViewButtonColumn1.Name = "DataGridViewButtonColumn1"
        Me.DataGridViewButtonColumn1.Width = 125
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "Editar"
        Me.DataGridViewImageColumn1.Image = CType(resources.GetObject("DataGridViewImageColumn1.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn1.MinimumWidth = 6
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Width = 125
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.HeaderText = "Excluir"
        Me.DataGridViewImageColumn2.MinimumWidth = 6
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.Width = 125
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1284, 505)
        Me.Controls.Add(Me.Tabcontrol1)
        Me.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Form6"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gerenciamento"
        CType(Me.dgv_alu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tabcontrol1.ResumeLayout(False)
        Me.tab_alunos.ResumeLayout(False)
        Me.tab_funcionarios.ResumeLayout(False)
        CType(Me.dgv_fun, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgv_alu As DataGridView
    Friend WithEvents Tabcontrol1 As TabControl
    Friend WithEvents tab_alunos As TabPage
    Friend WithEvents tab_funcionarios As TabPage
    Friend WithEvents dgv_fun As DataGridView
    Friend WithEvents cpf As DataGridViewTextBoxColumn
    Friend WithEvents Nome As DataGridViewTextBoxColumn
    Friend WithEvents Email As DataGridViewTextBoxColumn
    Friend WithEvents Data_nasc As DataGridViewTextBoxColumn
    Friend WithEvents Celular As DataGridViewTextBoxColumn
    Friend WithEvents Senha As DataGridViewTextBoxColumn
    Friend WithEvents Tipo As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents Atvbloq As DataGridViewButtonColumn
    Friend WithEvents Edita As DataGridViewImageColumn
    Friend WithEvents Excluir As DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewButtonColumn1 As DataGridViewButtonColumn
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As DataGridViewImageColumn
End Class
