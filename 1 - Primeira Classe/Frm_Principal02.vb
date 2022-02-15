Public Class Frm_Principal02
    Dim ContaDaGabriela = New ContaCorrente

    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        Me.Text = "1 - Primeira Classe - Formulário 02"
        Lbl_Principal_02.Text = "1 - Primeira Classe - Formulário 02"
        Lbl_Valor.Text = "Valor"
        Btn_Sacar.Text = "Efetuar Saque"
        Lbl_Saldo.Text = "Novo Saldo"
        Lbl_Resultado.Text = "Resultado do saque"
        Lbl_SaldoAtual.Text = "Saldo atual"
        Btn_Depositar.Text = "Efetuar Deposito"


        'Inicializar os dados da class
        ContaDaGabriela.Titular = "Gabriela"
        ContaDaGabriela.Agencia = 863
        ContaDaGabriela.conta = 863141
        Txt_SaldoAtual.Text = ContaDaGabriela.saldo

        Lbl_bemVindo.Text = "Bem vindo " + ContaDaGabriela.titular + " Agência " + ContaDaGabriela.agencia.ToString +
            " Conta Corrente: " + ContaDaGabriela.conta.ToString
    End Sub

    Private Sub Frm_Principal02_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Btn_Sacar_Click(sender As Object, e As EventArgs) Handles Btn_Sacar.Click
        Txt_Resultado.Text = ""
        Txt_Saldo.Text = ""

        Dim ValorSacar As Double = Val(Txt_valor.Text)
        Dim RetornoSaque As Boolean = ContaDaGabriela.Sacar(ValorSacar)

        If RetornoSaque = False Then
            Txt_Resultado.Text = "Saque não é possível ser feito"
        Else
            Txt_Saldo.Text = ContaDaGabriela.Saldo.ToString
            Txt_Resultado.Text = "Saque efetuado com sucesso"

        End If
        Txt_SaldoAtual.Text = Txt_Saldo.Text
    End Sub

    Private Sub Btn_Depositar_Click(sender As Object, e As EventArgs) Handles Btn_Depositar.Click
        Txt_Resultado.Text = ""
        Txt_Saldo.Text = ""

        Dim ValorDepositar As Double = Val(Txt_valor.Text)
        ContaDaGabriela.Depositar(ValorDepositar)

        Txt_Saldo.Text = ContaDaGabriela.Saldo.ToString
        Txt_Resultado.Text = "Deposito efetuado com sucesso"
        Txt_SaldoAtual.Text = Txt_Saldo.Text
    End Sub
End Class