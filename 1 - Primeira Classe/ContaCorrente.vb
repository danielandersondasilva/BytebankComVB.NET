﻿Public Class ContaCorrente

    Public titular As String
    Public agencia As Integer
    Public conta As Integer
    Public saldo As Double = 100

    Public Function Sacar(valorSacar As Double) As Boolean
        Dim Retorno As Boolean
        If saldo < valorSacar Then
            Retorno = False
        Else
            saldo -= valorSacar
            Retorno = True
        End If
        Return Retorno
    End Function

    Public Sub Depositar(valorDepositar As Double)
        saldo += valorDepositar
    End Sub



End Class