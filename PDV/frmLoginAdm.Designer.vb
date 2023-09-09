<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoginAdm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLoginAdm))
        Me.txtSenha = New System.Windows.Forms.MaskedTextBox()
        Me.btnAcesso = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtSenha
        '
        Me.txtSenha.BackColor = System.Drawing.Color.White
        Me.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSenha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSenha.Location = New System.Drawing.Point(32, 57)
        Me.txtSenha.Mask = "999,999,999-99"
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenha.Size = New System.Drawing.Size(128, 15)
        Me.txtSenha.TabIndex = 2
        '
        'btnAcesso
        '
        Me.btnAcesso.BackColor = System.Drawing.Color.Transparent
        Me.btnAcesso.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAcesso.FlatAppearance.BorderSize = 0
        Me.btnAcesso.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure
        Me.btnAcesso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnAcesso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAcesso.ForeColor = System.Drawing.Color.White
        Me.btnAcesso.Image = CType(resources.GetObject("btnAcesso.Image"), System.Drawing.Image)
        Me.btnAcesso.Location = New System.Drawing.Point(173, 41)
        Me.btnAcesso.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.btnAcesso.Name = "btnAcesso"
        Me.btnAcesso.Size = New System.Drawing.Size(89, 48)
        Me.btnAcesso.TabIndex = 168
        Me.btnAcesso.Text = "Acessar"
        Me.btnAcesso.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAcesso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAcesso.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(18, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(249, 20)
        Me.Label1.TabIndex = 169
        Me.Label1.Text = "LOGIN DO ADMINISTRADOR"
        '
        'frmLoginAdm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(314, 101)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAcesso)
        Me.Controls.Add(Me.txtSenha)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLoginAdm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login do Adm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSenha As MaskedTextBox
    Friend WithEvents btnAcesso As Button
    Friend WithEvents Label1 As Label
End Class
