Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.SelectedIndex = -1 Or ComboBox2.SelectedIndex = -1 Then
            MsgBox("selecione todos los campos")
            Exit Sub
        End If
        If contador < 8 Then

            numeroventa(contador) = contador + 1
            tamaño(contador) = ComboBox1.SelectedItem
            material(contador) = ComboBox2.SelectedItem


            Select Case tamaño(contador)


                Case "sofa"
                    Select Case material(contador)
                        Case "cuero"
                            preciomanodeobra(contador) = psofa
                            preciocosto(contador) = 8 * pcuero + preciomanodeobra(contador)

                        Case "cuerina"
                            preciomanodeobra(contador) = pcuerina
                            preciocosto(contador) = 8 * pcuerina + preciomanodeobra(contador)

                    End Select

                Case "individual"
                    Select Case material(contador)
                        Case "cuero"

                            preciomanodeobra(contador) = pindividual
                            preciocosto(contador) = 3.5 * pcuero + preciomanodeobra(contador)

                        Case "cuerina"

                            preciomanodeobra(contador) = pindividual
                            preciocosto(contador) = 3.5 * pcuerina + preciomanodeobra(contador)

                    End Select

                Case "doble"
                    Select Case material(contador)
                        Case "cuero"

                            preciomanodeobra(contador) = pdoble
                            preciocosto(contador) = 6 * pcuero + preciomanodeobra(contador)

                        Case "cuerina"
                            preciomanodeobra(contador) = pcuerina
                            preciocosto(contador) = 6 * pcuerina + preciomanodeobra(contador)

                    End Select
            End Select
            precioventa(contador) = preciocosto(contador) * 1.65

            ListBox1.Items.Add(numeroventa(contador))
            ListBox2.Items.Add(tamaño(contador))

            ListBox3.Items.Add(material(contador))
            ListBox4.Items.Add(preciocosto(contador))
            ListBox5.Items.Add(preciomanodeobra(contador))
            ListBox6.Items.Add(precioventa(contador))




            contador = contador + 1
                            Else
                            MsgBox("llego el limite de registro")

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        contador = 0
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        ListBox4.Items.Clear()
        ListBox5.Items.Clear()
        ListBox6.Items.Clear()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Call salir()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) 

    End Sub
End Class
