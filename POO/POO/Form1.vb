Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim unCamion As New camion

        'MsgBox(unCamion.ToString)

        Dim otroCamion As New camion("rojo", 123)

        ' MsgBox(otroCamion.ToString)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Micamion As New camion
        Dim s As Integer

        Micamion.color = txtColor.Text
        Micamion.chapa = txtChapa.Text
        Micamion.venta = txtVenta.Text
        Micamion.anio = txtAnio.Text

        s = InputBox("")
        Micamion.chapa = s

        MsgBox(Micamion.ToString)

    End Sub
End Class
