Module Module1
    Public Const psofa = 280.99
    Public Const pindividual = 150.99

    Public Const pdoble = 200.99
    Public Const pcuero = 75.0
    Public Const pcuerina = 45.99

    Public numeroventa(8)
    Public tamaño(8)
    Public material(8)
    Public preciocosto(8)
    Public preciomanodeobra(8)
    Public precioventa(8)

    Public contador = 0

    Sub LIMPIAR_listas()

        Form1.ListBox1.Items.Clear()
        Form1.ListBox2.Items.Clear()
        Form1.ListBox3.Items.Clear()
        Form1.ListBox4.Items.Clear()
        Form1.ListBox5.Items.Clear()
        Form1.ListBox6.Items.Clear()


    End Sub
    Sub LIMPIAR_ENTRADAS()
        Form1.ComboBox1.Text = ""
        Form1.ComboBox2.Text = ""

    End Sub
    Sub salir()
        If (MsgBox("DESEA SALIR", vbQuestion + vbYesNo, "mensaje de salida") = vbYes) Then
            End
        Else
            limpiar_entradas()
            LIMPIAR_listas()
        End If
    End Sub


End Module
