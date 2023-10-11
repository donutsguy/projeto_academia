<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.img_cadf = New System.Windows.Forms.PictureBox()
        Me.BunifuCustomLabel5 = New ns1.BunifuCustomLabel()
        Me.cb_tipo = New System.Windows.Forms.ComboBox()
        Me.BunifuCustomLabel3 = New ns1.BunifuCustomLabel()
        Me.btn_return = New ns1.BunifuImageButton()
        Me.btn_login = New ns1.BunifuImageButton()
        Me.btn_vsenhaf = New ns1.BunifuImageButton()
        Me.txt_cadf_csenha = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.txt_cadf_senha = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel14 = New ns1.BunifuCustomLabel()
        Me.BunifuCustomLabel13 = New ns1.BunifuCustomLabel()
        Me.BunifuCustomLabel11 = New ns1.BunifuCustomLabel()
        Me.BunifuCustomLabel4 = New ns1.BunifuCustomLabel()
        Me.BunifuCustomLabel10 = New ns1.BunifuCustomLabel()
        Me.txt_cadf_email = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.txt_cadf_nome = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel2 = New ns1.BunifuCustomLabel()
        Me.BunifuCustomLabel1 = New ns1.BunifuCustomLabel()
        Me.txt_datef = New System.Windows.Forms.DateTimePicker()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.txt_cadf_cel = New System.Windows.Forms.MaskedTextBox()
        Me.txt_cadf_cpf = New System.Windows.Forms.TextBox()
        CType(Me.img_cadf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_return, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_login, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_vsenhaf, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'img_cadf
        '
        Me.img_cadf.ErrorImage = Nothing
        Me.img_cadf.Image = CType(resources.GetObject("img_cadf.Image"), System.Drawing.Image)
        Me.img_cadf.Location = New System.Drawing.Point(639, 56)
        Me.img_cadf.Name = "img_cadf"
        Me.img_cadf.Size = New System.Drawing.Size(139, 137)
        Me.img_cadf.TabIndex = 69
        Me.img_cadf.TabStop = False
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Microsoft Tai Le", 9.25!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel5.ForeColor = System.Drawing.SystemColors.Control
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(12, 228)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(35, 16)
        Me.BunifuCustomLabel5.TabIndex = 68
        Me.BunifuCustomLabel5.Text = "Tipo"
        '
        'cb_tipo
        '
        Me.cb_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_tipo.FormattingEnabled = True
        Me.cb_tipo.Items.AddRange(New Object() {"BALCONISTA", "PROFESSOR"})
        Me.cb_tipo.Location = New System.Drawing.Point(15, 250)
        Me.cb_tipo.Name = "cb_tipo"
        Me.cb_tipo.Size = New System.Drawing.Size(107, 21)
        Me.cb_tipo.TabIndex = 8
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("AR DARLING", 18.25!)
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.SystemColors.Control
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(243, 9)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(280, 31)
        Me.BunifuCustomLabel3.TabIndex = 66
        Me.BunifuCustomLabel3.Text = "cadastro de funcionários"
        '
        'btn_return
        '
        Me.btn_return.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_return.Image = CType(resources.GetObject("btn_return.Image"), System.Drawing.Image)
        Me.btn_return.ImageActive = Nothing
        Me.btn_return.Location = New System.Drawing.Point(-3, 0)
        Me.btn_return.Name = "btn_return"
        Me.btn_return.Size = New System.Drawing.Size(43, 18)
        Me.btn_return.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_return.TabIndex = 65
        Me.btn_return.TabStop = False
        Me.btn_return.Zoom = 10
        '
        'btn_login
        '
        Me.btn_login.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_login.Image = CType(resources.GetObject("btn_login.Image"), System.Drawing.Image)
        Me.btn_login.ImageActive = Nothing
        Me.btn_login.Location = New System.Drawing.Point(184, 242)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(57, 38)
        Me.btn_login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_login.TabIndex = 64
        Me.btn_login.TabStop = False
        Me.btn_login.Zoom = 10
        '
        'btn_vsenhaf
        '
        Me.btn_vsenhaf.BackColor = System.Drawing.Color.Silver
        Me.btn_vsenhaf.Image = CType(resources.GetObject("btn_vsenhaf.Image"), System.Drawing.Image)
        Me.btn_vsenhaf.ImageActive = Nothing
        Me.btn_vsenhaf.Location = New System.Drawing.Point(551, 181)
        Me.btn_vsenhaf.Name = "btn_vsenhaf"
        Me.btn_vsenhaf.Size = New System.Drawing.Size(25, 20)
        Me.btn_vsenhaf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_vsenhaf.TabIndex = 63
        Me.btn_vsenhaf.TabStop = False
        Me.btn_vsenhaf.Zoom = 10
        '
        'txt_cadf_csenha
        '
        Me.txt_cadf_csenha.BorderColor = System.Drawing.Color.SeaGreen
        Me.txt_cadf_csenha.Location = New System.Drawing.Point(437, 182)
        Me.txt_cadf_csenha.Name = "txt_cadf_csenha"
        Me.txt_cadf_csenha.Size = New System.Drawing.Size(80, 20)
        Me.txt_cadf_csenha.TabIndex = 7
        Me.txt_cadf_csenha.UseSystemPasswordChar = True
        '
        'txt_cadf_senha
        '
        Me.txt_cadf_senha.BorderColor = System.Drawing.Color.SeaGreen
        Me.txt_cadf_senha.Location = New System.Drawing.Point(314, 182)
        Me.txt_cadf_senha.Name = "txt_cadf_senha"
        Me.txt_cadf_senha.Size = New System.Drawing.Size(80, 20)
        Me.txt_cadf_senha.TabIndex = 6
        Me.txt_cadf_senha.UseSystemPasswordChar = True
        '
        'BunifuCustomLabel14
        '
        Me.BunifuCustomLabel14.AutoSize = True
        Me.BunifuCustomLabel14.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel14.Font = New System.Drawing.Font("Microsoft Tai Le", 9.25!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel14.ForeColor = System.Drawing.SystemColors.Control
        Me.BunifuCustomLabel14.Location = New System.Drawing.Point(434, 163)
        Me.BunifuCustomLabel14.Name = "BunifuCustomLabel14"
        Me.BunifuCustomLabel14.Size = New System.Drawing.Size(109, 16)
        Me.BunifuCustomLabel14.TabIndex = 59
        Me.BunifuCustomLabel14.Text = "Confirmar senha"
        '
        'BunifuCustomLabel13
        '
        Me.BunifuCustomLabel13.AutoSize = True
        Me.BunifuCustomLabel13.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel13.Font = New System.Drawing.Font("Microsoft Tai Le", 9.25!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel13.ForeColor = System.Drawing.SystemColors.Control
        Me.BunifuCustomLabel13.Location = New System.Drawing.Point(311, 163)
        Me.BunifuCustomLabel13.Name = "BunifuCustomLabel13"
        Me.BunifuCustomLabel13.Size = New System.Drawing.Size(44, 16)
        Me.BunifuCustomLabel13.TabIndex = 58
        Me.BunifuCustomLabel13.Text = "Senha"
        '
        'BunifuCustomLabel11
        '
        Me.BunifuCustomLabel11.AutoSize = True
        Me.BunifuCustomLabel11.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel11.Font = New System.Drawing.Font("Microsoft Tai Le", 9.25!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel11.ForeColor = System.Drawing.SystemColors.Control
        Me.BunifuCustomLabel11.Location = New System.Drawing.Point(157, 163)
        Me.BunifuCustomLabel11.Name = "BunifuCustomLabel11"
        Me.BunifuCustomLabel11.Size = New System.Drawing.Size(50, 16)
        Me.BunifuCustomLabel11.TabIndex = 57
        Me.BunifuCustomLabel11.Text = "Celular"
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Microsoft Tai Le", 9.25!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel4.ForeColor = System.Drawing.SystemColors.Control
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(15, 163)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(130, 16)
        Me.BunifuCustomLabel4.TabIndex = 56
        Me.BunifuCustomLabel4.Text = "Data de nascimento"
        '
        'BunifuCustomLabel10
        '
        Me.BunifuCustomLabel10.AutoSize = True
        Me.BunifuCustomLabel10.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel10.Font = New System.Drawing.Font("Microsoft Tai Le", 9.25!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel10.ForeColor = System.Drawing.SystemColors.Control
        Me.BunifuCustomLabel10.Location = New System.Drawing.Point(365, 75)
        Me.BunifuCustomLabel10.Name = "BunifuCustomLabel10"
        Me.BunifuCustomLabel10.Size = New System.Drawing.Size(41, 16)
        Me.BunifuCustomLabel10.TabIndex = 55
        Me.BunifuCustomLabel10.Text = "Email"
        '
        'txt_cadf_email
        '
        Me.txt_cadf_email.BorderColor = System.Drawing.Color.SeaGreen
        Me.txt_cadf_email.Location = New System.Drawing.Point(368, 91)
        Me.txt_cadf_email.Name = "txt_cadf_email"
        Me.txt_cadf_email.Size = New System.Drawing.Size(218, 20)
        Me.txt_cadf_email.TabIndex = 3
        '
        'txt_cadf_nome
        '
        Me.txt_cadf_nome.BorderColor = System.Drawing.Color.SeaGreen
        Me.txt_cadf_nome.Location = New System.Drawing.Point(159, 91)
        Me.txt_cadf_nome.Name = "txt_cadf_nome"
        Me.txt_cadf_nome.Size = New System.Drawing.Size(175, 20)
        Me.txt_cadf_nome.TabIndex = 2
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Microsoft Tai Le", 9.25!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.Control
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(157, 75)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(44, 16)
        Me.BunifuCustomLabel2.TabIndex = 50
        Me.BunifuCustomLabel2.Text = "Nome"
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Microsoft Tai Le", 9.25!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.Control
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(18, 75)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(30, 16)
        Me.BunifuCustomLabel1.TabIndex = 49
        Me.BunifuCustomLabel1.Text = "CPF"
        '
        'txt_datef
        '
        Me.txt_datef.Location = New System.Drawing.Point(15, 184)
        Me.txt_datef.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_datef.Name = "txt_datef"
        Me.txt_datef.Size = New System.Drawing.Size(104, 20)
        Me.txt_datef.TabIndex = 4
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'txt_cadf_cel
        '
        Me.txt_cadf_cel.Location = New System.Drawing.Point(159, 182)
        Me.txt_cadf_cel.Mask = "(99) 0000-0000"
        Me.txt_cadf_cel.Name = "txt_cadf_cel"
        Me.txt_cadf_cel.Size = New System.Drawing.Size(100, 20)
        Me.txt_cadf_cel.TabIndex = 5
        '
        'txt_cadf_cpf
        '
        Me.txt_cadf_cpf.Location = New System.Drawing.Point(15, 94)
        Me.txt_cadf_cpf.Name = "txt_cadf_cpf"
        Me.txt_cadf_cpf.Size = New System.Drawing.Size(100, 20)
        Me.txt_cadf_cpf.TabIndex = 1
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(837, 315)
        Me.Controls.Add(Me.txt_cadf_cpf)
        Me.Controls.Add(Me.txt_cadf_cel)
        Me.Controls.Add(Me.txt_datef)
        Me.Controls.Add(Me.img_cadf)
        Me.Controls.Add(Me.BunifuCustomLabel5)
        Me.Controls.Add(Me.cb_tipo)
        Me.Controls.Add(Me.BunifuCustomLabel3)
        Me.Controls.Add(Me.btn_return)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.btn_vsenhaf)
        Me.Controls.Add(Me.txt_cadf_csenha)
        Me.Controls.Add(Me.txt_cadf_senha)
        Me.Controls.Add(Me.BunifuCustomLabel14)
        Me.Controls.Add(Me.BunifuCustomLabel13)
        Me.Controls.Add(Me.BunifuCustomLabel11)
        Me.Controls.Add(Me.BunifuCustomLabel4)
        Me.Controls.Add(Me.BunifuCustomLabel10)
        Me.Controls.Add(Me.txt_cadf_email)
        Me.Controls.Add(Me.txt_cadf_nome)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form3"
        CType(Me.img_cadf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_return, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_login, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_vsenhaf, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents img_cadf As PictureBox
    Friend WithEvents BunifuCustomLabel5 As ns1.BunifuCustomLabel
    Friend WithEvents cb_tipo As ComboBox
    Friend WithEvents BunifuCustomLabel3 As ns1.BunifuCustomLabel
    Friend WithEvents btn_return As ns1.BunifuImageButton
    Friend WithEvents btn_login As ns1.BunifuImageButton
    Friend WithEvents btn_vsenhaf As ns1.BunifuImageButton
    Friend WithEvents txt_cadf_csenha As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents txt_cadf_senha As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel14 As ns1.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel13 As ns1.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel11 As ns1.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel4 As ns1.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel10 As ns1.BunifuCustomLabel
    Friend WithEvents txt_cadf_email As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents txt_cadf_nome As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel2 As ns1.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel1 As ns1.BunifuCustomLabel
    Friend WithEvents txt_datef As DateTimePicker
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents txt_cadf_cel As MaskedTextBox
    Friend WithEvents txt_cadf_cpf As TextBox
End Class
