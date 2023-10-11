<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.img_cad = New System.Windows.Forms.PictureBox()
        Me.BunifuCustomLabel3 = New ns1.BunifuCustomLabel()
        Me.btn_return = New ns1.BunifuImageButton()
        Me.btn_cad_alu = New ns1.BunifuImageButton()
        Me.btn_vsenha = New ns1.BunifuImageButton()
        Me.txt_cad_csenha = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.txt_cad_senha = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel14 = New ns1.BunifuCustomLabel()
        Me.BunifuCustomLabel13 = New ns1.BunifuCustomLabel()
        Me.BunifuCustomLabel11 = New ns1.BunifuCustomLabel()
        Me.BunifuCustomLabel4 = New ns1.BunifuCustomLabel()
        Me.BunifuCustomLabel10 = New ns1.BunifuCustomLabel()
        Me.txt_cad_email = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.txt_cad_nome = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel2 = New ns1.BunifuCustomLabel()
        Me.BunifuCustomLabel1 = New ns1.BunifuCustomLabel()
        Me.txt_date = New System.Windows.Forms.DateTimePicker()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.txt_cad_cel = New System.Windows.Forms.MaskedTextBox()
        Me.txt_cad_cpf = New System.Windows.Forms.TextBox()
        CType(Me.img_cad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_return, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_cad_alu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_vsenha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'img_cad
        '
        Me.img_cad.Image = CType(resources.GetObject("img_cad.Image"), System.Drawing.Image)
        Me.img_cad.Location = New System.Drawing.Point(670, 41)
        Me.img_cad.Name = "img_cad"
        Me.img_cad.Size = New System.Drawing.Size(139, 137)
        Me.img_cad.TabIndex = 66
        Me.img_cad.TabStop = False
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("AR DARLING", 18.25!)
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.SystemColors.Control
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(232, 9)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(218, 31)
        Me.BunifuCustomLabel3.TabIndex = 65
        Me.BunifuCustomLabel3.Text = "cadastro de alunos"
        '
        'btn_return
        '
        Me.btn_return.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_return.Image = CType(resources.GetObject("btn_return.Image"), System.Drawing.Image)
        Me.btn_return.ImageActive = Nothing
        Me.btn_return.Location = New System.Drawing.Point(0, 0)
        Me.btn_return.Name = "btn_return"
        Me.btn_return.Size = New System.Drawing.Size(43, 18)
        Me.btn_return.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_return.TabIndex = 64
        Me.btn_return.TabStop = False
        Me.btn_return.Zoom = 10
        '
        'btn_cad_alu
        '
        Me.btn_cad_alu.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_cad_alu.Image = CType(resources.GetObject("btn_cad_alu.Image"), System.Drawing.Image)
        Me.btn_cad_alu.ImageActive = Nothing
        Me.btn_cad_alu.Location = New System.Drawing.Point(570, 172)
        Me.btn_cad_alu.Name = "btn_cad_alu"
        Me.btn_cad_alu.Size = New System.Drawing.Size(57, 38)
        Me.btn_cad_alu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_cad_alu.TabIndex = 63
        Me.btn_cad_alu.TabStop = False
        Me.btn_cad_alu.Zoom = 10
        '
        'btn_vsenha
        '
        Me.btn_vsenha.BackColor = System.Drawing.Color.Silver
        Me.btn_vsenha.Image = CType(resources.GetObject("btn_vsenha.Image"), System.Drawing.Image)
        Me.btn_vsenha.ImageActive = Nothing
        Me.btn_vsenha.Location = New System.Drawing.Point(515, 181)
        Me.btn_vsenha.Name = "btn_vsenha"
        Me.btn_vsenha.Size = New System.Drawing.Size(25, 20)
        Me.btn_vsenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_vsenha.TabIndex = 62
        Me.btn_vsenha.TabStop = False
        Me.btn_vsenha.Zoom = 10
        '
        'txt_cad_csenha
        '
        Me.txt_cad_csenha.BorderColor = System.Drawing.Color.SeaGreen
        Me.txt_cad_csenha.Location = New System.Drawing.Point(402, 181)
        Me.txt_cad_csenha.Name = "txt_cad_csenha"
        Me.txt_cad_csenha.Size = New System.Drawing.Size(80, 20)
        Me.txt_cad_csenha.TabIndex = 7
        '
        'txt_cad_senha
        '
        Me.txt_cad_senha.BorderColor = System.Drawing.Color.SeaGreen
        Me.txt_cad_senha.Location = New System.Drawing.Point(296, 181)
        Me.txt_cad_senha.Name = "txt_cad_senha"
        Me.txt_cad_senha.Size = New System.Drawing.Size(80, 20)
        Me.txt_cad_senha.TabIndex = 6
        '
        'BunifuCustomLabel14
        '
        Me.BunifuCustomLabel14.AutoSize = True
        Me.BunifuCustomLabel14.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel14.Font = New System.Drawing.Font("Microsoft Tai Le", 9.25!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel14.ForeColor = System.Drawing.SystemColors.Control
        Me.BunifuCustomLabel14.Location = New System.Drawing.Point(399, 162)
        Me.BunifuCustomLabel14.Name = "BunifuCustomLabel14"
        Me.BunifuCustomLabel14.Size = New System.Drawing.Size(109, 16)
        Me.BunifuCustomLabel14.TabIndex = 58
        Me.BunifuCustomLabel14.Text = "Confirmar senha"
        '
        'BunifuCustomLabel13
        '
        Me.BunifuCustomLabel13.AutoSize = True
        Me.BunifuCustomLabel13.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel13.Font = New System.Drawing.Font("Microsoft Tai Le", 9.25!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel13.ForeColor = System.Drawing.SystemColors.Control
        Me.BunifuCustomLabel13.Location = New System.Drawing.Point(293, 162)
        Me.BunifuCustomLabel13.Name = "BunifuCustomLabel13"
        Me.BunifuCustomLabel13.Size = New System.Drawing.Size(44, 16)
        Me.BunifuCustomLabel13.TabIndex = 57
        Me.BunifuCustomLabel13.Text = "Senha"
        '
        'BunifuCustomLabel11
        '
        Me.BunifuCustomLabel11.AutoSize = True
        Me.BunifuCustomLabel11.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel11.Font = New System.Drawing.Font("Microsoft Tai Le", 9.25!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel11.ForeColor = System.Drawing.SystemColors.Control
        Me.BunifuCustomLabel11.Location = New System.Drawing.Point(158, 162)
        Me.BunifuCustomLabel11.Name = "BunifuCustomLabel11"
        Me.BunifuCustomLabel11.Size = New System.Drawing.Size(50, 16)
        Me.BunifuCustomLabel11.TabIndex = 56
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
        Me.BunifuCustomLabel4.TabIndex = 55
        Me.BunifuCustomLabel4.Text = "Data de nascimento"
        '
        'BunifuCustomLabel10
        '
        Me.BunifuCustomLabel10.AutoSize = True
        Me.BunifuCustomLabel10.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel10.Font = New System.Drawing.Font("Microsoft Tai Le", 9.25!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel10.ForeColor = System.Drawing.SystemColors.Control
        Me.BunifuCustomLabel10.Location = New System.Drawing.Point(362, 75)
        Me.BunifuCustomLabel10.Name = "BunifuCustomLabel10"
        Me.BunifuCustomLabel10.Size = New System.Drawing.Size(41, 16)
        Me.BunifuCustomLabel10.TabIndex = 54
        Me.BunifuCustomLabel10.Text = "Email"
        '
        'txt_cad_email
        '
        Me.txt_cad_email.BorderColor = System.Drawing.Color.SeaGreen
        Me.txt_cad_email.Location = New System.Drawing.Point(365, 91)
        Me.txt_cad_email.Name = "txt_cad_email"
        Me.txt_cad_email.Size = New System.Drawing.Size(218, 20)
        Me.txt_cad_email.TabIndex = 3
        '
        'txt_cad_nome
        '
        Me.txt_cad_nome.BorderColor = System.Drawing.Color.SeaGreen
        Me.txt_cad_nome.Location = New System.Drawing.Point(156, 91)
        Me.txt_cad_nome.Name = "txt_cad_nome"
        Me.txt_cad_nome.Size = New System.Drawing.Size(175, 20)
        Me.txt_cad_nome.TabIndex = 2
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Microsoft Tai Le", 9.25!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.Control
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(154, 75)
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
        'txt_date
        '
        Me.txt_date.Location = New System.Drawing.Point(18, 181)
        Me.txt_date.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_date.Name = "txt_date"
        Me.txt_date.Size = New System.Drawing.Size(104, 20)
        Me.txt_date.TabIndex = 4
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog1"
        '
        'txt_cad_cel
        '
        Me.txt_cad_cel.Location = New System.Drawing.Point(156, 181)
        Me.txt_cad_cel.Mask = "(99) 0000-0000"
        Me.txt_cad_cel.Name = "txt_cad_cel"
        Me.txt_cad_cel.Size = New System.Drawing.Size(100, 20)
        Me.txt_cad_cel.TabIndex = 5
        '
        'txt_cad_cpf
        '
        Me.txt_cad_cpf.Location = New System.Drawing.Point(18, 91)
        Me.txt_cad_cpf.Name = "txt_cad_cpf"
        Me.txt_cad_cpf.Size = New System.Drawing.Size(100, 20)
        Me.txt_cad_cpf.TabIndex = 1
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(821, 259)
        Me.Controls.Add(Me.txt_cad_cpf)
        Me.Controls.Add(Me.txt_cad_cel)
        Me.Controls.Add(Me.txt_date)
        Me.Controls.Add(Me.img_cad)
        Me.Controls.Add(Me.BunifuCustomLabel3)
        Me.Controls.Add(Me.btn_return)
        Me.Controls.Add(Me.btn_cad_alu)
        Me.Controls.Add(Me.btn_vsenha)
        Me.Controls.Add(Me.txt_cad_csenha)
        Me.Controls.Add(Me.txt_cad_senha)
        Me.Controls.Add(Me.BunifuCustomLabel14)
        Me.Controls.Add(Me.BunifuCustomLabel13)
        Me.Controls.Add(Me.BunifuCustomLabel11)
        Me.Controls.Add(Me.BunifuCustomLabel4)
        Me.Controls.Add(Me.BunifuCustomLabel10)
        Me.Controls.Add(Me.txt_cad_email)
        Me.Controls.Add(Me.txt_cad_nome)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        CType(Me.img_cad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_return, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_cad_alu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_vsenha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents img_cad As PictureBox
    Friend WithEvents BunifuCustomLabel3 As ns1.BunifuCustomLabel
    Friend WithEvents btn_return As ns1.BunifuImageButton
    Friend WithEvents btn_cad_alu As ns1.BunifuImageButton
    Friend WithEvents btn_vsenha As ns1.BunifuImageButton
    Friend WithEvents txt_cad_csenha As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents txt_cad_senha As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel14 As ns1.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel13 As ns1.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel11 As ns1.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel4 As ns1.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel10 As ns1.BunifuCustomLabel
    Friend WithEvents txt_cad_email As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents txt_cad_nome As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel2 As ns1.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel1 As ns1.BunifuCustomLabel
    Friend WithEvents txt_date As DateTimePicker
    Friend WithEvents OpenFileDialog2 As OpenFileDialog
    Friend WithEvents txt_cad_cel As MaskedTextBox
    Friend WithEvents txt_cad_cpf As TextBox
End Class
