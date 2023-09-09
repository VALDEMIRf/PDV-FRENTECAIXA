<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TestesJson
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
        Me.btSalvar = New System.Windows.Forms.Button()
        Me.btCarregar = New System.Windows.Forms.Button()
        Me.txtVeiculos = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btSalvar
        '
        Me.btSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btSalvar.Location = New System.Drawing.Point(24, 21)
        Me.btSalvar.Name = "btSalvar"
        Me.btSalvar.Size = New System.Drawing.Size(87, 31)
        Me.btSalvar.TabIndex = 0
        Me.btSalvar.Text = "Salvar"
        Me.btSalvar.UseVisualStyleBackColor = True
        '
        'btCarregar
        '
        Me.btCarregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btCarregar.Location = New System.Drawing.Point(136, 21)
        Me.btCarregar.Name = "btCarregar"
        Me.btCarregar.Size = New System.Drawing.Size(75, 31)
        Me.btCarregar.TabIndex = 1
        Me.btCarregar.Text = "Carregar"
        Me.btCarregar.UseVisualStyleBackColor = True
        '
        'txtVeiculos
        '
        Me.txtVeiculos.Location = New System.Drawing.Point(24, 58)
        Me.txtVeiculos.Multiline = True
        Me.txtVeiculos.Name = "txtVeiculos"
        Me.txtVeiculos.Size = New System.Drawing.Size(411, 322)
        Me.txtVeiculos.TabIndex = 2
        '
        'TestesJson
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 392)
        Me.Controls.Add(Me.txtVeiculos)
        Me.Controls.Add(Me.btCarregar)
        Me.Controls.Add(Me.btSalvar)
        Me.Name = "TestesJson"
        Me.Text = "TestesJson"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btSalvar As Button
    Friend WithEvents btCarregar As Button
    Friend WithEvents txtVeiculos As TextBox
End Class
