<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.BunifuCustomLabel1 = New ns1.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New ns1.BunifuCustomLabel()
        Me.BunifuCustomLabel4 = New ns1.BunifuCustomLabel()
        Me.BunifuCustomLabel5 = New ns1.BunifuCustomLabel()
        Me.txt_senha = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.txt_user = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.btn_login = New ns1.BunifuImageButton()
        Me.btn_ver = New ns1.BunifuImageButton()
        Me.btn_return = New ns1.BunifuImageButton()
        CType(Me.btn_login, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_ver, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_return, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Microsoft Tai Le", 11.75!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.Control
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(364, 171)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(69, 21)
        Me.BunifuCustomLabel1.TabIndex = 0
        Me.BunifuCustomLabel1.Text = "Usuário"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.Control
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(364, 107)
        Me.BunifuCustomLabel2.MaximumSize = New System.Drawing.Size(10000, 10000)
        Me.BunifuCustomLabel2.MinimumSize = New System.Drawing.Size(10, 10)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(78, 27)
        Me.BunifuCustomLabel2.TabIndex = 1
        Me.BunifuCustomLabel2.Text = "LOGIN"
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("AR DARLING", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(220, 37)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(361, 46)
        Me.BunifuCustomLabel4.TabIndex = 3
        Me.BunifuCustomLabel4.Text = "Academia Bubassauro"
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Microsoft Tai Le", 11.75!, System.Drawing.FontStyle.Bold)
        Me.BunifuCustomLabel5.ForeColor = System.Drawing.SystemColors.Control
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(367, 262)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(57, 21)
        Me.BunifuCustomLabel5.TabIndex = 4
        Me.BunifuCustomLabel5.Text = "Senha"
        '
        'txt_senha
        '
        Me.txt_senha.BorderColor = System.Drawing.Color.SeaGreen
        Me.txt_senha.Location = New System.Drawing.Point(323, 309)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.Size = New System.Drawing.Size(154, 20)
        Me.txt_senha.TabIndex = 2
        Me.txt_senha.UseSystemPasswordChar = True
        '
        'txt_user
        '
        Me.txt_user.BorderColor = System.Drawing.Color.SeaGreen
        Me.txt_user.Location = New System.Drawing.Point(323, 217)
        Me.txt_user.Name = "txt_user"
        Me.txt_user.Size = New System.Drawing.Size(154, 20)
        Me.txt_user.TabIndex = 1
        '
        'btn_login
        '
        Me.btn_login.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_login.Image = CType(resources.GetObject("btn_login.Image"), System.Drawing.Image)
        Me.btn_login.ImageActive = Nothing
        Me.btn_login.Location = New System.Drawing.Point(371, 352)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(57, 38)
        Me.btn_login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_login.TabIndex = 7
        Me.btn_login.TabStop = False
        Me.btn_login.Zoom = 10
        '
        'btn_ver
        '
        Me.btn_ver.BackColor = System.Drawing.Color.Silver
        Me.btn_ver.Image = CType(resources.GetObject("btn_ver.Image"), System.Drawing.Image)
        Me.btn_ver.ImageActive = Nothing
        Me.btn_ver.Location = New System.Drawing.Point(505, 309)
        Me.btn_ver.Name = "btn_ver"
        Me.btn_ver.Size = New System.Drawing.Size(25, 20)
        Me.btn_ver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_ver.TabIndex = 8
        Me.btn_ver.TabStop = False
        Me.btn_ver.Zoom = 10
        '
        'btn_return
        '
        Me.btn_return.BackColor = System.Drawing.Color.Transparent
        Me.btn_return.Image = CType(resources.GetObject("btn_return.Image"), System.Drawing.Image)
        Me.btn_return.ImageActive = Nothing
        Me.btn_return.Location = New System.Drawing.Point(763, 3)
        Me.btn_return.Name = "btn_return"
        Me.btn_return.Size = New System.Drawing.Size(43, 18)
        Me.btn_return.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_return.TabIndex = 66
        Me.btn_return.TabStop = False
        Me.btn_return.Zoom = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_return)
        Me.Controls.Add(Me.btn_ver)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.txt_user)
        Me.Controls.Add(Me.txt_senha)
        Me.Controls.Add(Me.BunifuCustomLabel5)
        Me.Controls.Add(Me.BunifuCustomLabel4)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.btn_login, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_ver, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_return, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuCustomLabel1 As ns1.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel2 As ns1.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel4 As ns1.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel5 As ns1.BunifuCustomLabel
    Friend WithEvents txt_senha As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents txt_user As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents btn_login As ns1.BunifuImageButton
    Friend WithEvents btn_ver As ns1.BunifuImageButton
    Friend WithEvents btn_return As ns1.BunifuImageButton
End Class
