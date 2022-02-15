Public Class Frm_Pricipal_01
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

        Me.Text = "1 - Primeira Classe"
        Lbl_Principal.Text = "1 - Primeira CLasse"
        Btn_acao.Text = "Conta Gabriela"
        Btn_Acao2.Text = "Conta Bruno"
        Lbl_Incremento.Text = "Ingremento"
        Lbl_Saldo.Text = "Saldo"

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Btn_acao_Click(sender As Object, e As EventArgs) Handles Btn_acao.Click
        Dim ContaDaGabriela As New ContaCorrente
        ContaDaGabriela.titular = "Gabriela"
        ContaDaGabriela.agencia = 863
        ContaDaGabriela.conta = 863141
        ContaDaGabriela.saldo = 0
        Txt_Saldo.Text = Val(Txt_Saldo.Text)

        MsgBox("O saldo da " + ContaDaGabriela.titular + " na C/C " + ContaDaGabriela.agencia.ToString _
               + " - " + ContaDaGabriela.conta.ToString + " é " + ContaDaGabriela.saldo.ToString)

        Dim vIncremento As Double = Val(Txt_Incremento.Text)
        ContaDaGabriela.saldo += vIncremento

        MsgBox("O saldo da " + ContaDaGabriela.titular + " na C/C " + ContaDaGabriela.agencia.ToString _
               + " - " + ContaDaGabriela.conta.ToString + " é " + ContaDaGabriela.saldo.ToString)
    End Sub

    Private Sub Btn_Acao2_Click(sender As Object, e As EventArgs) Handles Btn_Acao2.Click

    End Sub
End Class
