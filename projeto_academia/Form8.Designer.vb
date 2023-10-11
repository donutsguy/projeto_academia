<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form8))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_a = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_peso = New System.Windows.Forms.TextBox()
        Me.btn_imc = New System.Windows.Forms.Button()
        Me.lbl_res = New System.Windows.Forms.Label()
        Me.lbl_desc = New System.Windows.Forms.Label()
        Me.btn_return = New ns1.BunifuImageButton()
        Me.txt_altura = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.btn_return, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Location = New System.Drawing.Point(93, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Altura"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label4.Location = New System.Drawing.Point(295, 212)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 14)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Descrição sobre o IMC"
        '
        'lbl_a
        '
        Me.lbl_a.AutoSize = True
        Me.lbl_a.BackColor = System.Drawing.Color.Transparent
        Me.lbl_a.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lbl_a.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lbl_a.Location = New System.Drawing.Point(295, 118)
        Me.lbl_a.Name = "lbl_a"
        Me.lbl_a.Size = New System.Drawing.Size(100, 14)
        Me.lbl_a.TabIndex = 5
        Me.lbl_a.Text = "Resultado do IMC"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.Location = New System.Drawing.Point(93, 183)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 14)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Peso"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("AR DARLING", 20.75!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label5.Location = New System.Drawing.Point(221, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(206, 34)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "calculadora imc"
        '
        'txt_peso
        '
        Me.txt_peso.Location = New System.Drawing.Point(61, 212)
        Me.txt_peso.Name = "txt_peso"
        Me.txt_peso.Size = New System.Drawing.Size(100, 20)
        Me.txt_peso.TabIndex = 2
        '
        'btn_imc
        '
        Me.btn_imc.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_imc.Location = New System.Drawing.Point(72, 276)
        Me.btn_imc.Name = "btn_imc"
        Me.btn_imc.Size = New System.Drawing.Size(75, 23)
        Me.btn_imc.TabIndex = 10
        Me.btn_imc.Text = "Calcular"
        Me.btn_imc.UseVisualStyleBackColor = True
        '
        'lbl_res
        '
        Me.lbl_res.AutoSize = True
        Me.lbl_res.BackColor = System.Drawing.Color.Transparent
        Me.lbl_res.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lbl_res.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lbl_res.Location = New System.Drawing.Point(295, 147)
        Me.lbl_res.Name = "lbl_res"
        Me.lbl_res.Size = New System.Drawing.Size(28, 14)
        Me.lbl_res.TabIndex = 11
        Me.lbl_res.Text = "IMC"
        '
        'lbl_desc
        '
        Me.lbl_desc.AutoSize = True
        Me.lbl_desc.BackColor = System.Drawing.Color.Transparent
        Me.lbl_desc.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lbl_desc.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lbl_desc.Location = New System.Drawing.Point(295, 241)
        Me.lbl_desc.Name = "lbl_desc"
        Me.lbl_desc.Size = New System.Drawing.Size(56, 14)
        Me.lbl_desc.TabIndex = 12
        Me.lbl_desc.Text = "Descrição"
        '
        'btn_return
        '
        Me.btn_return.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_return.Image = CType(resources.GetObject("btn_return.Image"), System.Drawing.Image)
        Me.btn_return.ImageActive = Nothing
        Me.btn_return.Location = New System.Drawing.Point(-3, -1)
        Me.btn_return.Name = "btn_return"
        Me.btn_return.Size = New System.Drawing.Size(43, 18)
        Me.btn_return.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_return.TabIndex = 66
        Me.btn_return.TabStop = False
        Me.btn_return.Zoom = 10
        '
        'txt_altura
        '
        Me.txt_altura.Location = New System.Drawing.Point(61, 130)
        Me.txt_altura.Name = "txt_altura"
        Me.txt_altura.Size = New System.Drawing.Size(100, 20)
        Me.txt_altura.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 6.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label2.Location = New System.Drawing.Point(167, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 13)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "cm"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Tai Le", 6.25!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label6.Location = New System.Drawing.Point(167, 219)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(18, 13)
        Me.Label6.TabIndex = 68
        Me.Label6.Text = "kg"
        '
        'Form8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(677, 345)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_return)
        Me.Controls.Add(Me.lbl_desc)
        Me.Controls.Add(Me.lbl_res)
        Me.Controls.Add(Me.btn_imc)
        Me.Controls.Add(Me.txt_peso)
        Me.Controls.Add(Me.txt_altura)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl_a)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form8"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form8"
        CType(Me.btn_return, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_a As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_peso As TextBox
    Friend WithEvents btn_imc As Button
    Friend WithEvents lbl_res As Label
    Friend WithEvents lbl_desc As Label
    Friend WithEvents btn_return As ns1.BunifuImageButton
    Friend WithEvents txt_altura As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
End Class
