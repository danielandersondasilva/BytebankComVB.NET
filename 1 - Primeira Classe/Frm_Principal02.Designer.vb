<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Principal02
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
        Me.Lbl_Principal_02 = New System.Windows.Forms.Label()
        Me.Lbl_Valor_Sacar = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Lbl_Principal_02
        '
        Me.Lbl_Principal_02.AutoSize = True
        Me.Lbl_Principal_02.Location = New System.Drawing.Point(12, 18)
        Me.Lbl_Principal_02.Name = "Lbl_Principal_02"
        Me.Lbl_Principal_02.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Principal_02.TabIndex = 0
        Me.Lbl_Principal_02.Text = "Label1"
        '
        'Lbl_Valor_Sacar
        '
        Me.Lbl_Valor_Sacar.AutoSize = True
        Me.Lbl_Valor_Sacar.Location = New System.Drawing.Point(381, 219)
        Me.Lbl_Valor_Sacar.Name = "Lbl_Valor_Sacar"
        Me.Lbl_Valor_Sacar.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Valor_Sacar.TabIndex = 1
        Me.Lbl_Valor_Sacar.Text = "Label1"
        '
        'Frm_Principal02
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Lbl_Valor_Sacar)
        Me.Controls.Add(Me.Lbl_Principal_02)
        Me.Name = "Frm_Principal02"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_Principal02"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl_Principal_02 As Label
    Friend WithEvents Lbl_Valor_Sacar As Label
End Class
