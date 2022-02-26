Imports _2___ByteBank.ByteBank
Public Class Frm_Principal_02

    Dim ContaDaGabriela = New ContaCorrente("1000")
    Dim ContaDoBruno = New ContaCorrente("500")
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        Me.Text = "1 - Primeira Classe - Formulário 02"

        'inicialização dos textos da gabriela
        Lbl_Principal_02.Text = "1 - Primeira Classe - Formulário 02"
        Lbl_Valor_Gabriela.Text = "Valor"
        Btn_Sacar_Gabriela.Text = "Efetuar Saque"
        Lbl_Saldo_Gabriela.Text = "Novo Saldo"
        Lbl_Resultado_Gabriela.Text = "Resultado do saque"
        Lbl_SaldoAtual_Gabriela.Text = "Saldo atual"
        Btn_Depositar_Gabriela.Text = "Efetuar Deposito"
        Grp_Gabriela.Text = "Gabriela"
        Btn_Transferir_Gabriela.Text = "Efetuar Transferencia"
        Txt_SaldoAtual_Gabriela.ReadOnly = True
        Txt_Saldo_Gabriela.ReadOnly = True
        Txt_Resultado_Gabriela.ReadOnly = True
        Txt_Extrato_Gabriela.ReadOnly = True

        'inicialização dos textos do Bruno
        Lbl_Principal_02.Text = "1 - Primeira Classe - Formulário 02"
        Lbl_Valor_Bruno.Text = "Valor"
        Btn_Sacar_Bruno.Text = "Efetuar Saque"
        Lbl_Saldo_Bruno.Text = "Novo Saldo"
        Lbl_Resultado_Bruno.Text = "Resultado do saque"
        Lbl_SaldoAtual_Bruno.Text = "Saldo atual"
        Btn_Depositar_Bruno.Text = "Efetuar Deposito"
        Grp_Bruno.Text = "Bruno"
        Btn_Transferir_Bruno.Text = "Efetuar Transferencia"
        Txt_SaldoAtual_Bruno.ReadOnly = True
        Txt_Saldo_Bruno.ReadOnly = True
        Txt_Resultado_Bruno.ReadOnly = True
        Txt_Extrato_Bruno.ReadOnly = True



        'Inicializar os dados da class da Gabriela

        Dim Gabriela As New Cliente("Gabriela", "12345678910")
        Gabriela.Profissao = "Analista de Sistemas"
        Gabriela.Cidade = "Rio de Janeiro"

        ContaDaGabriela.Titular = Gabriela
        ContaDaGabriela.Agencia = 863
        ContaDaGabriela.conta = 863141
        Txt_SaldoAtual_Gabriela.Text = ContaDaGabriela.Saldo


        Lbl_bemVindo_Gabriela.Text = "Bem vindo " + ContaDaGabriela.titular.Nome + " Agência " + ContaDaGabriela.agencia.ToString +
            " Conta Corrente: " + ContaDaGabriela.conta.ToString + "CPF: " + ContaDaGabriela.Titular.CPF

        'Inicializar os dados da class do Bruno

        Dim Bruno As New Cliente("Bruno", "987654321110")
        Bruno.Profissao = "Advogado"
        Bruno.Cidade = "São Paulo"

        ContaDoBruno.Titular = Bruno
        ContaDoBruno.Agencia = 863
        ContaDoBruno.conta = 863224
        Txt_SaldoAtual_Bruno.Text = ContaDoBruno.Saldo

        Lbl_bemVindo_Bruno.Text = "Bem vindo " + ContaDoBruno.titular.Nome + " Agência " + ContaDoBruno.agencia.ToString +
            " Conta Corrente: " + ContaDoBruno.conta.ToString

        Lbl_NumeroDeClientes.Text = "o número de clientes é :" + Cliente.NumeroClientes.ToString

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Btn_Depositar_Gabriela_Click(sender As Object, e As EventArgs) Handles Btn_Depositar_Gabriela.Click
        Txt_Resultado_Gabriela.Text = ""
        Txt_Saldo_Gabriela.Text = ""

        Dim ValorDepositar As Double = Val(Txt_valor_Gabriela.Text)
        ContaDaGabriela.Depositar(ValorDepositar)

        Txt_Saldo_Gabriela.Text = ContaDaGabriela.Saldo.ToString
        Txt_Resultado_Gabriela.Text = "Deposito efetuado com sucesso"
        Txt_SaldoAtual_Gabriela.Text = Txt_Saldo_Gabriela.Text
        ContaDaGabriela.Extrato += Now + " Depósito de " + ValorDepositar.ToString + " saldo " _
            + ContaDaGabriela.Saldo.ToString + vbCrLf
        Txt_Extrato_Gabriela.Text = ContaDaGabriela.Extrato
    End Sub

    Private Sub Btn_Sacar_Gabriela_Click(sender As Object, e As EventArgs) Handles Btn_Sacar_Gabriela.Click
        Txt_Resultado_Gabriela.Text = ""
        Txt_Saldo_Gabriela.Text = ""

        Dim ValorSacar As Double = Val(Txt_valor_Gabriela.Text)
        Dim RetornoSaque As Boolean = ContaDaGabriela.Sacar(ValorSacar)

        If RetornoSaque = False Then
            Txt_Resultado_Gabriela.Text = "Saque não é possível ser feito"
        Else
            Txt_Saldo_Gabriela.Text = ContaDaGabriela.Saldo.ToString
            Txt_Resultado_Gabriela.Text = "Saque efetuado com sucesso"
            ContaDaGabriela.Extrato = Now + " Saque de " + ValorSacar.ToString + " saldo " _
                + ContaDaGabriela.Saldo.ToString + vbCrLf
            Txt_Extrato_Gabriela.Text += ContaDaGabriela.Extrato


        End If
        Txt_SaldoAtual_Gabriela.Text = Txt_Saldo_Gabriela.Text
    End Sub

    Private Sub Btn_Transferir_Gabriela_Click(sender As Object, e As EventArgs) Handles Btn_Transferir_Gabriela.Click
        Txt_Resultado_Gabriela.Text = ""
        Txt_Saldo_Gabriela.Text = ""

        Dim ValorTransferir As Double = Val(Txt_valor_Gabriela.Text)
        Dim RetornoTransferencia As Boolean = ContaDaGabriela.Transferir(ValorTransferir, ContaDoBruno)

        If RetornoTransferencia = False Then
            Txt_Resultado_Gabriela.Text = "Transferencia não é possível ser feito"
        Else
            Txt_Saldo_Gabriela.Text = ContaDaGabriela.Saldo.ToString
            Txt_Saldo_Bruno.Text = ContaDoBruno.Saldo.ToString

            Txt_Resultado_Gabriela.Text = "Transferencia efetuada com sucesso"
            Txt_SaldoAtual_Gabriela.Text = Txt_Saldo_Gabriela.Text
            Txt_SaldoAtual_Bruno.Text = Txt_Saldo_Bruno.Text

            ContaDaGabriela.Extrato += Now.ToString + " Transferencia de " + ValorTransferir.ToString +
            " Saldo " + ContaDaGabriela.Saldo.ToString + vbCrLf
            ContaDoBruno.Extrato += Now.ToString + " Transferencia de " + ValorTransferir.ToString +
            " Saldo " + ContaDoBruno.Saldo.ToString + vbCrLf

            Txt_Extrato_Gabriela.Text = ContaDaGabriela.Extrato
            Txt_Extrato_Bruno.Text = ContaDoBruno.Extrato
        End If
    End Sub

    Private Sub Btn_Depositar_Bruno_Click(sender As Object, e As EventArgs) Handles Btn_Depositar_Bruno.Click
        Txt_Resultado_Bruno.Text = ""
        Txt_Saldo_Bruno.Text = ""

        Dim ValorDepositar As Double = Val(Txt_valor_Bruno.Text)
        ContaDoBruno.Depositar(ValorDepositar)

        Txt_Saldo_Bruno.Text = ContaDoBruno.Saldo.ToString
        Txt_Resultado_Bruno.Text = "Deposito efetuado com sucesso"
        Txt_SaldoAtual_Bruno.Text = Txt_Saldo_Bruno.Text
        ContaDoBruno.Extrato += Now + " Depósito de " + ValorDepositar.ToString + " saldo " _
            + ContaDoBruno.Saldo.ToString + vbCrLf
        Txt_Extrato_Bruno.Text = ContaDoBruno.Extrato
    End Sub

    Private Sub Btn_Sacar_Bruno_Click(sender As Object, e As EventArgs) Handles Btn_Sacar_Bruno.Click
        Txt_Resultado_Bruno.Text = ""
        Txt_Saldo_Bruno.Text = ""

        Dim ValorSacar As Double = Val(Txt_valor_Bruno.Text)
        Dim RetornoSaque As Boolean = ContaDoBruno.Sacar(ValorSacar)

        If RetornoSaque = False Then
            Txt_Resultado_Bruno.Text = "Saque não é possível ser feito"
        Else
            Txt_Saldo_Bruno.Text = ContaDoBruno.Saldo.ToString
            Txt_Resultado_Bruno.Text = "Saque efetuado com sucesso"
            ContaDoBruno.Extrato = Now + " Saque de " + ValorSacar.ToString + " saldo " _
                + ContaDoBruno.Saldo.ToString + vbCrLf
            Txt_Extrato_Bruno.Text += ContaDoBruno.Extrato


        End If
        Txt_SaldoAtual_Bruno.Text = Txt_Saldo_Bruno.Text
    End Sub

    Private Sub Btn_Transferir_Bruno_Click(sender As Object, e As EventArgs) Handles Btn_Transferir_Bruno.Click
        Txt_Resultado_Bruno.Text = ""
        Txt_Saldo_Bruno.Text = ""

        Dim ValorTransferir As Double = Val(Txt_valor_Bruno.Text)
        Dim RetornoTransferencia As Boolean = ContaDoBruno.Transferir(ValorTransferir, ContaDaGabriela)

        If RetornoTransferencia = False Then
            Txt_Resultado_Bruno.Text = "Transferencia não é possível ser feito"
        Else
            Txt_Saldo_Gabriela.Text = ContaDaGabriela.Saldo.ToString
            Txt_Saldo_Bruno.Text = ContaDoBruno.Saldo.ToString

            Txt_Resultado_Bruno.Text = "Transferencia efetuada com sucesso"
            Txt_SaldoAtual_Gabriela.Text = Txt_Saldo_Gabriela.Text
            Txt_SaldoAtual_Bruno.Text = Txt_Saldo_Bruno.Text

            ContaDaGabriela.Extrato += Now.ToString + " Transferencia de " + ValorTransferir.ToString +
                " Saldo " + ContaDaGabriela.Saldo.ToString + vbCrLf
            ContaDoBruno.Extrato += Now.ToString + " Transferencia de " + ValorTransferir.ToString +
                " Saldo " + ContaDoBruno.Saldo.ToString + vbCrLf

            Txt_Extrato_Gabriela.Text = ContaDaGabriela.Extrato
            Txt_Extrato_Bruno.Text = ContaDoBruno.Extrato
        End If
    End Sub
End Class
