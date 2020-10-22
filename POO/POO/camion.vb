Imports Microsoft.VisualBasic

Public Class camion

    'variables de instancia
    Private mchapa As Integer
    Private mcolor As String
    Private mAnio As Integer
    Private mVenta As String
    Private revision As String

    Public Sub New()
        Me.mchapa = 0
        Me.mcolor = "sin color"
    End Sub


    Public Overrides Function ToString() As String
        Return ("este es el camion de color " & Me.mcolor & ", tiene la matricula " & Me.mchapa & ", el estado de venta es: " & mVenta & " y " & revision)
    End Function

    Public Sub New(ByVal color As String, ByVal chapa As Integer)
        Me.chapa = chapa
        Me.mcolor = color
    End Sub

    Public Property chapa As Integer
        Get
            Return mchapa
        End Get
        Set(ByVal value As Integer)
            If mchapa = Nothing Then
                mchapa = value
            Else
                If chapa <> value Then
                    msgbox("la matricula no puede ser distinta")
                Else
                    mchapa = value
                End If
            End If
        End Set
    End Property

    Public Property color As String
        Get
            Return mcolor
        End Get
        Set(ByVal value As String)
            mcolor = value
        End Set
    End Property

    Public Property anio As String
        Get
            Return mAnio
        End Get
        Set(ByVal value As String)
            mAnio = value
            If value < 2020 Then
                revision = "le toca revision"
            Else
                revision = "no le toca revision"
            End If
        End Set
    End Property

    Public Property venta As String
        Get
            Return mVenta
        End Get
        Set(value As String)
            mVenta = value
        End Set
    End Property
End Class
