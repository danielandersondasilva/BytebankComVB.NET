<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Pricipal_01
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
        Me.Lbl_Principal = New System.Windows.Forms.Label()
        Me.Btn_acao = New System.Windows.Forms.Button()
        Me.Lbl_Incremento = New System.Windows.Forms.Label()
        Me.Lbl_Saldo = New System.Windows.Forms.Label()
        Me.Txt_Saldo = New System.Windows.Forms.TextBox()
        Me.Txt_Incremento = New System.Windows.Forms.TextBox()
        Me.Btn_Acao2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Lbl_Principal
        '
        Me.Lbl_Principal.AutoSize = True
        Me.Lbl_Principal.Location = New System.Drawing.Point(28, 21)
        Me.Lbl_Principal.Name = "Lbl_Principal"
        Me.Lbl_Principal.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Principal.TabIndex = 0
        Me.Lbl_Principal.Text = "Label1"
        '
        'Btn_acao
        '
        Me.Btn_acao.Location = New System.Drawing.Point(108, 172)
        Me.Btn_acao.Name = "Btn_acao"
        Me.Btn_acao.Size = New System.Drawing.Size(75, 23)
        Me.Btn_acao.TabIndex = 1
        Me.Btn_acao.Text = "Button1"
        Me.Btn_acao.UseVisualStyleBackColor = True
        '
        'Lbl_Incremento
        '
        Me.Lbl_Incremento.AutoSize = True
        Me.Lbl_Incremento.Location = New System.Drawing.Point(28, 81)
        Me.Lbl_Incremento.Name = "Lbl_Incremento"
        Me.Lbl_Incremento.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Incremento.TabIndex = 2
        Me.Lbl_Incremento.Text = "Label1"
        '
        'Lbl_Saldo
        '
        Me.Lbl_Saldo.AutoSize = True
        Me.Lbl_Saldo.Location = New System.Drawing.Point(161, 81)
        Me.Lbl_Saldo.Name = "Lbl_Saldo"
        Me.Lbl_Saldo.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Saldo.TabIndex = 3
        Me.Lbl_Saldo.Text = "Label2"
        '
        'Txt_Saldo
        '
        Me.Txt_Saldo.Location = New System.Drawing.Point(31, 111)
        Me.Txt_Saldo.Name = "Txt_Saldo"
        Me.Txt_Saldo.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Saldo.TabIndex = 4
        '
        'Txt_Incremento
        '
        Me.Txt_Incremento.Location = New System.Drawing.Point(164, 111)
        Me.Txt_Incremento.Name = "Txt_Incremento"
        Me.Txt_Incremento.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Incremento.TabIndex = 5
        '
        'Btn_Acao2
        '
        Me.Btn_Acao2.Location = New System.Drawing.Point(363, 214)
        Me.Btn_Acao2.Name = "Btn_Acao2"
        Me.Btn_Acao2.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Acao2.TabIndex = 6
        Me.Btn_Acao2.Text = "Button1"
        Me.Btn_Acao2.UseVisualStyleBackColor = True
        '
        'Frm_Pricipal_01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Btn_Acao2)
        Me.Controls.Add(Me.Txt_Incremento)
        Me.Controls.Add(Me.Txt_Saldo)
        Me.Controls.Add(Me.Lbl_Saldo)
        Me.Controls.Add(Me.Lbl_Incremento)
        Me.Controls.Add(Me.Btn_acao)
        Me.Controls.Add(Me.Lbl_Principal)
        Me.Name = "Frm_Pricipal_01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl_Principal As Label
    Friend WithEvents Btn_acao As Button
    Friend WithEvents Lbl_Incremento As Label
    Friend WithEvents Lbl_Saldo As Label
    Friend WithEvents Txt_Saldo As TextBox
    Friend WithEvents Txt_Incremento As TextBox
    Friend WithEvents Btn_Acao2 As Button
End Class
