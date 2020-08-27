﻿Imports System.Runtime.InteropServices
Imports ADODB
Imports Persistencia

Public Class FrmLogin
    Dim db As New ConnectionDB()

    Private Sub Cerrar()
        If MsgBox("Está seguro que desea cerrar ?", MsgBoxStyle.YesNoCancel, "Cerrar Programa") = MsgBoxResult.Yes Then
            End
        End If
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Cerrar()
    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub BtnTopExit_Click(sender As Object, e As EventArgs) Handles BtnTopExit.Click
        End
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        If TxtUser.Text.Trim.Length = 0 Or TxtPass.Text.Trim.Length = 0 Then
            MessageBox.Show("CAMPOS VACIOS!!")
        Else
            Dim rslog As Boolean = db.CheckLog(TxtUser.Text.ToString(), TxtPass.Text.ToString())
            If rslog = False Then
                Console.WriteLine("NO EXISTE")
                MessageBox.Show("Usuario o Contraseña Equivocada!!")
            Else
                Console.WriteLine("--------------------EXISTEEE------------------")
                Me.Hide()
                FrmHome.Show()
            End If
        End If
    End Sub
End Class