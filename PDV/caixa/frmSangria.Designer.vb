<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSangria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSangria))
        Me.btnSalvarSangria = New System.Windows.Forms.Button()
        Me.txtSangria = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTotSangria = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSalvarSangria
        '
        Me.btnSalvarSangria.BackColor = System.Drawing.Color.Transparent
        Me.btnSalvarSangria.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalvarSangria.FlatAppearance.BorderSize = 0
        Me.btnSalvarSangria.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure
        Me.btnSalvarSangria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnSalvarSangria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalvarSangria.ForeColor = System.Drawing.Color.White
        Me.btnSalvarSangria.Image = CType(resources.GetObject("btnSalvarSangria.Image"), System.Drawing.Image)
        Me.btnSalvarSangria.Location = New System.Drawing.Point(227, 44)
        Me.btnSalvarSangria.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.btnSalvarSangria.Name = "btnSalvarSangria"
        Me.btnSalvarSangria.Size = New System.Drawing.Size(80, 48)
        Me.btnSalvarSangria.TabIndex = 167
        Me.btnSalvarSangria.Text = "Salvar"
        Me.btnSalvarSangria.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalvarSangria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalvarSangria.UseVisualStyleBackColor = False
        '
        'txtSangria
        '
        Me.txtSangria.Location = New System.Drawing.Point(133, 58)
        Me.txtSangria.Margin = New System.Windows.Forms.Padding(5)
        Me.txtSangria.Name = "txtSangria"
        Me.txtSangria.Size = New System.Drawing.Size(89, 20)
        Me.txtSangria.TabIndex = 168
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(13, 59)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 16)
        Me.Label2.TabIndex = 169
        Me.Label2.Text = "Valor da Sangria:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(13, 89)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 16)
        Me.Label1.TabIndex = 171
        Me.Label1.Text = "Total da Sangria:"
        '
        'lblTotSangria
        '
        Me.lblTotSangria.AutoSize = True
        Me.lblTotSangria.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotSangria.ForeColor = System.Drawing.Color.White
        Me.lblTotSangria.Location = New System.Drawing.Point(158, 88)
        Me.lblTotSangria.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblTotSangria.Name = "lblTotSangria"
        Me.lblTotSangria.Size = New System.Drawing.Size(14, 20)
        Me.lblTotSangria.TabIndex = 172
        Me.lblTotSangria.Text = "-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(125, 87)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 20)
        Me.Label3.TabIndex = 173
        Me.Label3.Text = "R$"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(70, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(169, 20)
        Me.Label4.TabIndex = 174
        Me.Label4.Text = "INSERIR SANGRIA"
        '
        'frmSangria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(311, 123)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblTotSangria)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSalvarSangria)
        Me.Controls.Add(Me.txtSangria)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSangria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sangria"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSalvarSangria As Button
    Friend WithEvents txtSangria As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTotSangria As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
