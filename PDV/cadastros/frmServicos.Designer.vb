﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmServicos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmServicos))
        Me.txtNumServico = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtTelCel = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTelRes = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.mktDtEntrada = New System.Windows.Forms.MaskedTextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cbTipoServico = New System.Windows.Forms.ComboBox()
        Me.cbCliente = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbStatusPgto = New System.Windows.Forms.ComboBox()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.mktHora = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.mktDtEntrega = New System.Windows.Forms.MaskedTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbGarantia = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtResponsavel = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtEndereco = New System.Windows.Forms.TextBox()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtCompl = New System.Windows.Forms.TextBox()
        Me.txtCEP = New System.Windows.Forms.MaskedTextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtBairro = New System.Windows.Forms.TextBox()
        Me.txtUF = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtObs = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dgvServico = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btNovo = New System.Windows.Forms.Button()
        Me.btSair = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btSalvar = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Cadastro = New System.Windows.Forms.TabPage()
        Me.Consulta = New System.Windows.Forms.TabPage()
        Me.dtData = New System.Windows.Forms.DateTimePicker()
        Me.rbData = New System.Windows.Forms.RadioButton()
        Me.rbCliente = New System.Windows.Forms.RadioButton()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.cbClientes = New System.Windows.Forms.ComboBox()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvServico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.Cadastro.SuspendLayout()
        Me.Consulta.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtNumServico
        '
        Me.txtNumServico.Location = New System.Drawing.Point(1077, 268)
        Me.txtNumServico.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtNumServico.Name = "txtNumServico"
        Me.txtNumServico.Size = New System.Drawing.Size(107, 23)
        Me.txtNumServico.TabIndex = 173
        Me.txtNumServico.Visible = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(671, 252)
        Me.Label22.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(92, 17)
        Me.Label22.TabIndex = 177
        Me.Label22.Text = "Núm Serviço:"
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(776, 249)
        Me.txtCodigo.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(107, 23)
        Me.txtCodigo.TabIndex = 176
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.txtTelCel)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.txtTelRes)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.txtEmail)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Black
        Me.GroupBox4.Location = New System.Drawing.Point(15, 389)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.GroupBox4.Size = New System.Drawing.Size(621, 116)
        Me.GroupBox4.TabIndex = 175
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Contato"
        '
        'txtTelCel
        '
        Me.txtTelCel.Location = New System.Drawing.Point(451, 32)
        Me.txtTelCel.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtTelCel.Mask = "(00) 00000-0000"
        Me.txtTelCel.Name = "txtTelCel"
        Me.txtTelCel.Size = New System.Drawing.Size(156, 23)
        Me.txtTelCel.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(388, 36)
        Me.Label7.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 17)
        Me.Label7.TabIndex = 70
        Me.Label7.Text = "Celular:"
        '
        'txtTelRes
        '
        Me.txtTelRes.Location = New System.Drawing.Point(88, 32)
        Me.txtTelRes.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtTelRes.Mask = "(00) 00000-0000"
        Me.txtTelRes.Name = "txtTelRes"
        Me.txtTelRes.Size = New System.Drawing.Size(164, 23)
        Me.txtTelRes.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 35)
        Me.Label6.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 17)
        Me.Label6.TabIndex = 67
        Me.Label6.Text = "Telefone:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(88, 75)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(519, 23)
        Me.txtEmail.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(37, 78)
        Me.Label4.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 17)
        Me.Label4.TabIndex = 68
        Me.Label4.Text = "Email:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.mktDtEntrada)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.cbTipoServico)
        Me.GroupBox1.Controls.Add(Me.cbCliente)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(9, 9)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(633, 142)
        Me.GroupBox1.TabIndex = 174
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Solicitação de Serviço "
        '
        'mktDtEntrada
        '
        Me.mktDtEntrada.Location = New System.Drawing.Point(132, 104)
        Me.mktDtEntrada.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.mktDtEntrada.Mask = "00/00/0000"
        Me.mktDtEntrada.Name = "mktDtEntrada"
        Me.mktDtEntrada.Size = New System.Drawing.Size(91, 22)
        Me.mktDtEntrada.TabIndex = 4
        Me.mktDtEntrada.ValidatingType = GetType(Date)
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(13, 106)
        Me.Label13.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(109, 16)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Data de Entrada:"
        '
        'cbTipoServico
        '
        Me.cbTipoServico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoServico.FormattingEnabled = True
        Me.cbTipoServico.Location = New System.Drawing.Point(132, 65)
        Me.cbTipoServico.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.cbTipoServico.Name = "cbTipoServico"
        Me.cbTipoServico.Size = New System.Drawing.Size(457, 24)
        Me.cbTipoServico.TabIndex = 3
        '
        'cbCliente
        '
        Me.cbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCliente.FormattingEnabled = True
        Me.cbCliente.Location = New System.Drawing.Point(131, 25)
        Me.cbCliente.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.cbCliente.Name = "cbCliente"
        Me.cbCliente.Size = New System.Drawing.Size(463, 24)
        Me.cbCliente.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(65, 28)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Cliente:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 68)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Tipo de Serviço:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.cbStatusPgto)
        Me.GroupBox2.Controls.Add(Me.txtValor)
        Me.GroupBox2.Controls.Add(Me.mktHora)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.mktDtEntrega)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.cbGarantia)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.txtResponsavel)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(653, 26)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.GroupBox2.Size = New System.Drawing.Size(532, 214)
        Me.GroupBox2.TabIndex = 179
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Dados do Atendimento"
        '
        'cbStatusPgto
        '
        Me.cbStatusPgto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbStatusPgto.FormattingEnabled = True
        Me.cbStatusPgto.Items.AddRange(New Object() {"", "Ordem Paga", "Aguardando Pagamento"})
        Me.cbStatusPgto.Location = New System.Drawing.Point(147, 171)
        Me.cbStatusPgto.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.cbStatusPgto.Name = "cbStatusPgto"
        Me.cbStatusPgto.Size = New System.Drawing.Size(359, 24)
        Me.cbStatusPgto.TabIndex = 23
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(145, 139)
        Me.txtValor.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(145, 23)
        Me.txtValor.TabIndex = 22
        '
        'mktHora
        '
        Me.mktHora.Location = New System.Drawing.Point(344, 106)
        Me.mktHora.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.mktHora.Mask = "90:00"
        Me.mktHora.Name = "mktHora"
        Me.mktHora.Size = New System.Drawing.Size(55, 23)
        Me.mktHora.TabIndex = 21
        Me.mktHora.ValidatingType = GetType(Date)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(41, 174)
        Me.Label8.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 16)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Status Pagto.:"
        '
        'mktDtEntrega
        '
        Me.mktDtEntrega.Location = New System.Drawing.Point(145, 105)
        Me.mktDtEntrega.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.mktDtEntrega.Mask = "00/00/0000"
        Me.mktDtEntrega.Name = "mktDtEntrega"
        Me.mktDtEntrega.Size = New System.Drawing.Size(85, 23)
        Me.mktDtEntrega.TabIndex = 20
        Me.mktDtEntrega.ValidatingType = GetType(Date)
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(88, 142)
        Me.Label12.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(43, 16)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Valor:"
        '
        'cbGarantia
        '
        Me.cbGarantia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGarantia.FormattingEnabled = True
        Me.cbGarantia.Items.AddRange(New Object() {"", "1 Mês", "2 Meses", "3 Meses", "6 Meses", "1 Ano"})
        Me.cbGarantia.Location = New System.Drawing.Point(144, 70)
        Me.cbGarantia.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.cbGarantia.Name = "cbGarantia"
        Me.cbGarantia.Size = New System.Drawing.Size(361, 24)
        Me.cbGarantia.TabIndex = 19
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(37, 109)
        Me.Label21.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(100, 17)
        Me.Label21.TabIndex = 16
        Me.Label21.Text = "Dt de Entrega:"
        '
        'txtResponsavel
        '
        Me.txtResponsavel.Location = New System.Drawing.Point(144, 37)
        Me.txtResponsavel.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtResponsavel.Name = "txtResponsavel"
        Me.txtResponsavel.Size = New System.Drawing.Size(361, 23)
        Me.txtResponsavel.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(39, 40)
        Me.Label10.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 16)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Responsável:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(69, 78)
        Me.Label11.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 16)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Garantia:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(293, 111)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Hora:"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.txtEndereco)
        Me.GroupBox3.Controls.Add(Me.txtNumero)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.txtCompl)
        Me.GroupBox3.Controls.Add(Me.txtCEP)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.txtBairro)
        Me.GroupBox3.Controls.Add(Me.txtUF)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.txtCidade)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(15, 160)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.GroupBox3.Size = New System.Drawing.Size(628, 217)
        Me.GroupBox3.TabIndex = 178
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Local do Serviço"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(20, 33)
        Me.Label14.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(73, 17)
        Me.Label14.TabIndex = 61
        Me.Label14.Text = "Endereço:"
        '
        'txtEndereco
        '
        Me.txtEndereco.Location = New System.Drawing.Point(104, 30)
        Me.txtEndereco.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(511, 23)
        Me.txtEndereco.TabIndex = 6
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(105, 68)
        Me.txtNumero.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(73, 23)
        Me.txtNumero.TabIndex = 7
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(69, 71)
        Me.Label15.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(28, 17)
        Me.Label15.TabIndex = 83
        Me.Label15.Text = "N°:"
        '
        'txtCompl
        '
        Me.txtCompl.Location = New System.Drawing.Point(277, 71)
        Me.txtCompl.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtCompl.Name = "txtCompl"
        Me.txtCompl.Size = New System.Drawing.Size(337, 23)
        Me.txtCompl.TabIndex = 8
        '
        'txtCEP
        '
        Me.txtCEP.Location = New System.Drawing.Point(296, 182)
        Me.txtCEP.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtCEP.Mask = "00000-999"
        Me.txtCEP.Name = "txtCEP"
        Me.txtCEP.Size = New System.Drawing.Size(136, 23)
        Me.txtCEP.TabIndex = 12
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(214, 74)
        Me.Label16.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(55, 17)
        Me.Label16.TabIndex = 85
        Me.Label16.Text = "Compl.:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(251, 184)
        Me.Label17.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(39, 17)
        Me.Label17.TabIndex = 94
        Me.Label17.Text = "CEP:"
        '
        'txtBairro
        '
        Me.txtBairro.Location = New System.Drawing.Point(104, 108)
        Me.txtBairro.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(511, 23)
        Me.txtBairro.TabIndex = 9
        '
        'txtUF
        '
        Me.txtUF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtUF.FormattingEnabled = True
        Me.txtUF.Items.AddRange(New Object() {"AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO"})
        Me.txtUF.Location = New System.Drawing.Point(104, 182)
        Me.txtUF.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtUF.Name = "txtUF"
        Me.txtUF.Size = New System.Drawing.Size(129, 24)
        Me.txtUF.TabIndex = 11
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(43, 111)
        Me.Label18.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(50, 17)
        Me.Label18.TabIndex = 92
        Me.Label18.Text = "Bairro:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(69, 185)
        Me.Label19.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(30, 17)
        Me.Label19.TabIndex = 87
        Me.Label19.Text = "UF:"
        '
        'txtCidade
        '
        Me.txtCidade.Location = New System.Drawing.Point(105, 145)
        Me.txtCidade.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(509, 23)
        Me.txtCidade.TabIndex = 10
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(40, 148)
        Me.Label20.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(56, 17)
        Me.Label20.TabIndex = 88
        Me.Label20.Text = "Cidade:"
        '
        'txtObs
        '
        Me.txtObs.Location = New System.Drawing.Point(692, 309)
        Me.txtObs.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Size = New System.Drawing.Size(503, 195)
        Me.txtObs.TabIndex = 181
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(698, 284)
        Me.Label9.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(101, 18)
        Me.Label9.TabIndex = 180
        Me.Label9.Text = "Observações:"
        '
        'dgvServico
        '
        Me.dgvServico.AllowUserToAddRows = False
        Me.dgvServico.AllowUserToDeleteRows = False
        Me.dgvServico.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvServico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvServico.GridColor = System.Drawing.SystemColors.HotTrack
        Me.dgvServico.Location = New System.Drawing.Point(12, 48)
        Me.dgvServico.Margin = New System.Windows.Forms.Padding(12, 10, 12, 10)
        Me.dgvServico.Name = "dgvServico"
        Me.dgvServico.ReadOnly = True
        Me.dgvServico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvServico.Size = New System.Drawing.Size(1192, 432)
        Me.dgvServico.TabIndex = 182
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(1106, 491)
        Me.Label1.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 20)
        Me.Label1.TabIndex = 189
        Me.Label1.Text = "Total:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.Black
        Me.lblTotal.Location = New System.Drawing.Point(1168, 491)
        Me.lblTotal.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(14, 20)
        Me.lblTotal.TabIndex = 188
        Me.lblTotal.Text = "-"
        '
        'btNovo
        '
        Me.btNovo.BackColor = System.Drawing.Color.Transparent
        Me.btNovo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btNovo.FlatAppearance.BorderSize = 0
        Me.btNovo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue
        Me.btNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btNovo.ForeColor = System.Drawing.Color.Black
        Me.btNovo.Image = CType(resources.GetObject("btNovo.Image"), System.Drawing.Image)
        Me.btNovo.Location = New System.Drawing.Point(9, 11)
        Me.btNovo.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.btNovo.Name = "btNovo"
        Me.btNovo.Size = New System.Drawing.Size(105, 55)
        Me.btNovo.TabIndex = 183
        Me.btNovo.Text = "Novo"
        Me.btNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btNovo.UseVisualStyleBackColor = False
        '
        'btSair
        '
        Me.btSair.BackColor = System.Drawing.Color.Transparent
        Me.btSair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btSair.FlatAppearance.BorderSize = 0
        Me.btSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue
        Me.btSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSair.ForeColor = System.Drawing.Color.Black
        Me.btSair.Image = CType(resources.GetObject("btSair.Image"), System.Drawing.Image)
        Me.btSair.Location = New System.Drawing.Point(531, 11)
        Me.btSair.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.btSair.Name = "btSair"
        Me.btSair.Size = New System.Drawing.Size(105, 55)
        Me.btSair.TabIndex = 187
        Me.btSair.Text = "Sair"
        Me.btSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btSair.UseVisualStyleBackColor = False
        '
        'btnExcluir
        '
        Me.btnExcluir.BackColor = System.Drawing.Color.Transparent
        Me.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExcluir.FlatAppearance.BorderSize = 0
        Me.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue
        Me.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcluir.ForeColor = System.Drawing.Color.Black
        Me.btnExcluir.Image = CType(resources.GetObject("btnExcluir.Image"), System.Drawing.Image)
        Me.btnExcluir.Location = New System.Drawing.Point(412, 11)
        Me.btnExcluir.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(105, 55)
        Me.btnExcluir.TabIndex = 186
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExcluir.UseVisualStyleBackColor = False
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.Transparent
        Me.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditar.FlatAppearance.BorderSize = 0
        Me.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue
        Me.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.ForeColor = System.Drawing.Color.Black
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.Location = New System.Drawing.Point(279, 11)
        Me.btnEditar.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(105, 55)
        Me.btnEditar.TabIndex = 185
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'btSalvar
        '
        Me.btSalvar.BackColor = System.Drawing.Color.Transparent
        Me.btSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btSalvar.FlatAppearance.BorderSize = 0
        Me.btSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue
        Me.btSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSalvar.ForeColor = System.Drawing.Color.Black
        Me.btSalvar.Image = CType(resources.GetObject("btSalvar.Image"), System.Drawing.Image)
        Me.btSalvar.Location = New System.Drawing.Point(144, 11)
        Me.btSalvar.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.btSalvar.Name = "btSalvar"
        Me.btSalvar.Size = New System.Drawing.Size(105, 55)
        Me.btSalvar.TabIndex = 184
        Me.btSalvar.Text = "Salvar"
        Me.btSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btSalvar.UseVisualStyleBackColor = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btNovo)
        Me.GroupBox5.Controls.Add(Me.btSalvar)
        Me.GroupBox5.Controls.Add(Me.btnEditar)
        Me.GroupBox5.Controls.Add(Me.btSair)
        Me.GroupBox5.Controls.Add(Me.btnExcluir)
        Me.GroupBox5.Location = New System.Drawing.Point(3, 580)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox5.Size = New System.Drawing.Size(663, 71)
        Me.GroupBox5.TabIndex = 190
        Me.GroupBox5.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Cadastro)
        Me.TabControl1.Controls.Add(Me.Consulta)
        Me.TabControl1.Location = New System.Drawing.Point(3, 15)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1231, 555)
        Me.TabControl1.TabIndex = 191
        '
        'Cadastro
        '
        Me.Cadastro.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Cadastro.Controls.Add(Me.GroupBox1)
        Me.Cadastro.Controls.Add(Me.GroupBox3)
        Me.Cadastro.Controls.Add(Me.txtNumServico)
        Me.Cadastro.Controls.Add(Me.GroupBox2)
        Me.Cadastro.Controls.Add(Me.txtCodigo)
        Me.Cadastro.Controls.Add(Me.GroupBox4)
        Me.Cadastro.Controls.Add(Me.Label9)
        Me.Cadastro.Controls.Add(Me.Label22)
        Me.Cadastro.Controls.Add(Me.txtObs)
        Me.Cadastro.Location = New System.Drawing.Point(4, 25)
        Me.Cadastro.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Cadastro.Name = "Cadastro"
        Me.Cadastro.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Cadastro.Size = New System.Drawing.Size(1223, 526)
        Me.Cadastro.TabIndex = 0
        Me.Cadastro.Text = "Cadastro"
        '
        'Consulta
        '
        Me.Consulta.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Consulta.Controls.Add(Me.dtData)
        Me.Consulta.Controls.Add(Me.rbData)
        Me.Consulta.Controls.Add(Me.rbCliente)
        Me.Consulta.Controls.Add(Me.Label24)
        Me.Consulta.Controls.Add(Me.cbClientes)
        Me.Consulta.Controls.Add(Me.dgvServico)
        Me.Consulta.Controls.Add(Me.Label1)
        Me.Consulta.Controls.Add(Me.lblTotal)
        Me.Consulta.Location = New System.Drawing.Point(4, 25)
        Me.Consulta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Consulta.Name = "Consulta"
        Me.Consulta.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Consulta.Size = New System.Drawing.Size(1223, 526)
        Me.Consulta.TabIndex = 1
        Me.Consulta.Text = "Consulta"
        '
        'dtData
        '
        Me.dtData.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtData.Location = New System.Drawing.Point(567, 16)
        Me.dtData.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtData.Name = "dtData"
        Me.dtData.Size = New System.Drawing.Size(208, 23)
        Me.dtData.TabIndex = 198
        '
        'rbData
        '
        Me.rbData.AutoSize = True
        Me.rbData.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbData.ForeColor = System.Drawing.Color.Black
        Me.rbData.Location = New System.Drawing.Point(232, 16)
        Me.rbData.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbData.Name = "rbData"
        Me.rbData.Size = New System.Drawing.Size(57, 22)
        Me.rbData.TabIndex = 197
        Me.rbData.TabStop = True
        Me.rbData.Text = "Data"
        Me.rbData.UseVisualStyleBackColor = True
        '
        'rbCliente
        '
        Me.rbCliente.AutoSize = True
        Me.rbCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCliente.ForeColor = System.Drawing.Color.Black
        Me.rbCliente.Location = New System.Drawing.Point(117, 15)
        Me.rbCliente.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbCliente.Name = "rbCliente"
        Me.rbCliente.Size = New System.Drawing.Size(71, 22)
        Me.rbCliente.TabIndex = 195
        Me.rbCliente.TabStop = True
        Me.rbCliente.Text = "Cliente"
        Me.rbCliente.UseVisualStyleBackColor = True
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(31, 15)
        Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(59, 18)
        Me.Label24.TabIndex = 194
        Me.Label24.Text = "Buscar:"
        '
        'cbClientes
        '
        Me.cbClientes.FormattingEnabled = True
        Me.cbClientes.Location = New System.Drawing.Point(316, 17)
        Me.cbClientes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbClientes.Name = "cbClientes"
        Me.cbClientes.Size = New System.Drawing.Size(208, 24)
        Me.cbClientes.TabIndex = 192
        '
        'frmServicos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1247, 666)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmServicos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Servicos"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgvServico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.Cadastro.ResumeLayout(False)
        Me.Cadastro.PerformLayout()
        Me.Consulta.ResumeLayout(False)
        Me.Consulta.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtNumServico As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtTelCel As MaskedTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtTelRes As MaskedTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents mktDtEntrada As MaskedTextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents cbTipoServico As ComboBox
    Friend WithEvents cbCliente As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cbStatusPgto As ComboBox
    Friend WithEvents txtValor As TextBox
    Friend WithEvents mktHora As MaskedTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents mktDtEntrega As MaskedTextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents cbGarantia As ComboBox
    Friend WithEvents Label21 As Label
    Friend WithEvents txtResponsavel As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtEndereco As TextBox
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtCompl As TextBox
    Friend WithEvents txtCEP As MaskedTextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents txtBairro As TextBox
    Friend WithEvents txtUF As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents txtCidade As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txtObs As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents dgvServico As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents btNovo As Button
    Friend WithEvents btSair As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btSalvar As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Cadastro As TabPage
    Friend WithEvents Consulta As TabPage
    Friend WithEvents dtData As DateTimePicker
    Friend WithEvents rbData As RadioButton
    Friend WithEvents rbCliente As RadioButton
    Friend WithEvents Label24 As Label
    Friend WithEvents cbClientes As ComboBox
End Class