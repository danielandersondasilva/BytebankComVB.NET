
Imports _2___ByteBank.ByteBank

Public Class ContaCorrente

#Region "CONSTRUTORES"

    Public Sub New(saldo As Double)
        saldo = m_Saldo
    End Sub
#End Region

#Region "PROPRIEDADES"
    'forma completa de fazer a implementação do get e do set
    Private m_Extrato As String
    Public Property Extrato As String
        Get
            Return m_Extrato
        End Get
        Set(value As String)
            m_Extrato = value
        End Set
    End Property
    '-----------------------------------------------------------


    'forma mais simples de implementar o get e o set
    Public Property Conta As Integer
    '-------------------------------------------------


    Public Property Agencia As Integer



    Private m_Titular As Cliente
    Public Property Titular As Cliente
        Get
            Return m_Titular
        End Get
        Set(value As Cliente)
            m_Titular = value
        End Set
    End Property

    Private m_Saldo As Double = 100
    Public Property Saldo As Double
        Get
            Return m_Saldo
        End Get
        Set(value As Double)
            If value < 0 Then
                m_Saldo = 0
            Else
                m_Saldo = value
            End If
        End Set

    End Property
#End Region

#Region "MÉTODOS"

    Public Function Sacar(valorSacar As Double) As Boolean
        Dim Retorno As Boolean
        If m_Saldo < valorSacar Then
            Retorno = False
        Else
            m_Saldo -= valorSacar
            Retorno = True
        End If
        Return Retorno
    End Function

    Public Sub Depositar(valorDepositar As Double)
        m_Saldo += valorDepositar
    End Sub

    Public Function Transferir(ValorTransferencia As Double, ByRef ContaDestino As ContaCorrente) As Boolean

        Dim Retorno As Boolean
        If m_Saldo < ValorTransferencia Then
            Retorno = False
        Else
            m_Saldo -= ValorTransferencia
            ContaDestino.Depositar(ValorTransferencia)
            Retorno = True
        End If
        Return Retorno
    End Function


#End Region

End Class