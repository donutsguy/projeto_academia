<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.BunifuCustomLabel1 = New ns1.BunifuCustomLabel()
        Me.btn_1 = New ns1.BunifuImageButton()
        Me.lbl_1 = New ns1.BunifuCustomLabel()
        Me.lbl_2 = New ns1.BunifuCustomLabel()
        Me.btn_2 = New ns1.BunifuImageButton()
        Me.img_ini = New System.Windows.Forms.PictureBox()
        Me.lbl_nome_cliente = New System.Windows.Forms.Label()
        Me.lbl_ini_nome = New System.Windows.Forms.Label()
        Me.lbl_ini_tipo = New System.Windows.Forms.Label()
        Me.lbl_ini_email = New System.Windows.Forms.Label()
        Me.lbl_ini_cel = New System.Windows.Forms.Label()
        Me.btn_return = New ns1.BunifuImageButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_3 = New ns1.BunifuImageButton()
        Me.lbl_3 = New ns1.BunifuCustomLabel()
        CType(Me.btn_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_ini, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_return, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("AR DARLING", 27.75!)
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(328, 9)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(108, 46)
        Me.BunifuCustomLabel1.TabIndex = 0
        Me.BunifuCustomLabel1.Text = "início"
        '
        'btn_1
        '
        Me.btn_1.BackColor = System.Drawing.Color.SeaGreen
        Me.btn_1.Image = CType(resources.GetObject("btn_1.Image"), System.Drawing.Image)
        Me.btn_1.ImageActive = Nothing
        Me.btn_1.Location = New System.Drawing.Point(75, 353)
        Me.btn_1.Name = "btn_1"
        Me.btn_1.Size = New System.Drawing.Size(52, 48)
        Me.btn_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_1.TabIndex = 1
        Me.btn_1.TabStop = False
        Me.btn_1.Zoom = 10
        '
        'lbl_1
        '
        Me.lbl_1.AutoSize = True
        Me.lbl_1.BackColor = System.Drawing.Color.Transparent
        Me.lbl_1.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lbl_1.Location = New System.Drawing.Point(57, 325)
        Me.lbl_1.Name = "lbl_1"
        Me.lbl_1.Size = New System.Drawing.Size(107, 14)
        Me.lbl_1.TabIndex = 2
        Me.lbl_1.Text = "Cadastro de alunos"
        '
        'lbl_2
        '
        Me.lbl_2.AutoSize = True
        Me.lbl_2.BackColor = System.Drawing.Color.Transparent
        Me.lbl_2.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_2.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lbl_2.Location = New System.Drawing.Point(167, 325)
        Me.lbl_2.Name = "lbl_2"
        Me.lbl_2.Size = New System.Drawing.Size(92, 14)
        Me.lbl_2.TabIndex = 8
        Me.lbl_2.Text = "Calculadora IMC"
        '
        'btn_2
        '
        Me.btn_2.BackColor = System.Drawing.Color.SeaGreen
        Me.btn_2.Image = CType(resources.GetObject("btn_2.Image"), System.Drawing.Image)
        Me.btn_2.ImageActive = Nothing
        Me.btn_2.Location = New System.Drawing.Point(185, 353)
        Me.btn_2.Name = "btn_2"
        Me.btn_2.Size = New System.Drawing.Size(52, 48)
        Me.btn_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_2.TabIndex = 7
        Me.btn_2.TabStop = False
        Me.btn_2.Zoom = 10
        '
        'img_ini
        '
        Me.img_ini.Location = New System.Drawing.Point(610, 77)
        Me.img_ini.Name = "img_ini"
        Me.img_ini.Size = New System.Drawing.Size(139, 137)
        Me.img_ini.TabIndex = 48
        Me.img_ini.TabStop = False
        '
        'lbl_nome_cliente
        '
        Me.lbl_nome_cliente.AutoSize = True
        Me.lbl_nome_cliente.BackColor = System.Drawing.Color.Transparent
        Me.lbl_nome_cliente.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nome_cliente.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lbl_nome_cliente.Location = New System.Drawing.Point(607, 42)
        Me.lbl_nome_cliente.Name = "lbl_nome_cliente"
        Me.lbl_nome_cliente.Size = New System.Drawing.Size(142, 21)
        Me.lbl_nome_cliente.TabIndex = 49
        Me.lbl_nome_cliente.Text = "Nome do usuário"
        '
        'lbl_ini_nome
        '
        Me.lbl_ini_nome.AutoSize = True
        Me.lbl_ini_nome.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ini_nome.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ini_nome.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lbl_ini_nome.Location = New System.Drawing.Point(102, 97)
        Me.lbl_ini_nome.Name = "lbl_ini_nome"
        Me.lbl_ini_nome.Size = New System.Drawing.Size(114, 16)
        Me.lbl_ini_nome.TabIndex = 50
        Me.lbl_ini_nome.Text = "Nome do usuário"
        '
        'lbl_ini_tipo
        '
        Me.lbl_ini_tipo.AutoSize = True
        Me.lbl_ini_tipo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ini_tipo.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ini_tipo.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lbl_ini_tipo.Location = New System.Drawing.Point(96, 154)
        Me.lbl_ini_tipo.Name = "lbl_ini_tipo"
        Me.lbl_ini_tipo.Size = New System.Drawing.Size(105, 16)
        Me.lbl_ini_tipo.TabIndex = 51
        Me.lbl_ini_tipo.Text = "Tipo do usuário"
        '
        'lbl_ini_email
        '
        Me.lbl_ini_email.AutoSize = True
        Me.lbl_ini_email.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ini_email.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ini_email.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lbl_ini_email.Location = New System.Drawing.Point(96, 126)
        Me.lbl_ini_email.Name = "lbl_ini_email"
        Me.lbl_ini_email.Size = New System.Drawing.Size(111, 16)
        Me.lbl_ini_email.TabIndex = 52
        Me.lbl_ini_email.Text = "Email do usuário"
        '
        'lbl_ini_cel
        '
        Me.lbl_ini_cel.AutoSize = True
        Me.lbl_ini_cel.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ini_cel.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ini_cel.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lbl_ini_cel.Location = New System.Drawing.Point(96, 186)
        Me.lbl_ini_cel.Name = "lbl_ini_cel"
        Me.lbl_ini_cel.Size = New System.Drawing.Size(120, 16)
        Me.lbl_ini_cel.TabIndex = 53
        Me.lbl_ini_cel.Text = "Celular do usuário"
        '
        'btn_return
        '
        Me.btn_return.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_return.Image = CType(resources.GetObject("btn_return.Image"), System.Drawing.Image)
        Me.btn_return.ImageActive = Nothing
        Me.btn_return.Location = New System.Drawing.Point(1, 1)
        Me.btn_return.Name = "btn_return"
        Me.btn_return.Size = New System.Drawing.Size(43, 18)
        Me.btn_return.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_return.TabIndex = 65
        Me.btn_return.TabStop = False
        Me.btn_return.Zoom = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Location = New System.Drawing.Point(36, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 16)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "Nome: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label2.Location = New System.Drawing.Point(36, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 16)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "Email: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.Location = New System.Drawing.Point(36, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 16)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "Tipo:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label4.Location = New System.Drawing.Point(36, 186)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 16)
        Me.Label4.TabIndex = 69
        Me.Label4.Text = "Celular:"
        '
        'btn_3
        '
        Me.btn_3.BackColor = System.Drawing.Color.SeaGreen
        Me.btn_3.Image = CType(resources.GetObject("btn_3.Image"), System.Drawing.Image)
        Me.btn_3.ImageActive = Nothing
        Me.btn_3.Location = New System.Drawing.Point(293, 353)
        Me.btn_3.Name = "btn_3"
        Me.btn_3.Size = New System.Drawing.Size(52, 48)
        Me.btn_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_3.TabIndex = 3
        Me.btn_3.TabStop = False
        Me.btn_3.Zoom = 10
        '
        'lbl_3
        '
        Me.lbl_3.AutoSize = True
        Me.lbl_3.BackColor = System.Drawing.Color.Transparent
        Me.lbl_3.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_3.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lbl_3.Location = New System.Drawing.Point(297, 325)
        Me.lbl_3.Name = "lbl_3"
        Me.lbl_3.Size = New System.Drawing.Size(45, 14)
        Me.lbl_3.TabIndex = 4
        Me.lbl_3.Text = "Treinos"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_return)
        Me.Controls.Add(Me.lbl_ini_cel)
        Me.Controls.Add(Me.lbl_ini_email)
        Me.Controls.Add(Me.lbl_ini_tipo)
        Me.Controls.Add(Me.lbl_ini_nome)
        Me.Controls.Add(Me.lbl_nome_cliente)
        Me.Controls.Add(Me.img_ini)
        Me.Controls.Add(Me.lbl_2)
        Me.Controls.Add(Me.btn_2)
        Me.Controls.Add(Me.lbl_3)
        Me.Controls.Add(Me.btn_3)
        Me.Controls.Add(Me.lbl_1)
        Me.Controls.Add(Me.btn_1)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form4"
        CType(Me.btn_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_ini, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_return, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuCustomLabel1 As ns1.BunifuCustomLabel
    Friend WithEvents btn_1 As ns1.BunifuImageButton
    Friend WithEvents lbl_1 As ns1.BunifuCustomLabel
    Friend WithEvents lbl_2 As ns1.BunifuCustomLabel
    Friend WithEvents btn_2 As ns1.BunifuImageButton
    Friend WithEvents img_ini As PictureBox
    Friend WithEvents lbl_nome_cliente As Label
    Friend WithEvents lbl_ini_nome As Label
    Friend WithEvents lbl_ini_tipo As Label
    Friend WithEvents lbl_ini_email As Label
    Friend WithEvents lbl_ini_cel As Label
    Friend WithEvents btn_return As ns1.BunifuImageButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_3 As ns1.BunifuImageButton
    Friend WithEvents lbl_3 As ns1.BunifuCustomLabel
End Class
