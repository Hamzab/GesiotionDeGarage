
Public Class Garage


    Private _autos As List(Of Automobile)
    Private _adresse As String


    Public Property Adresse As String

        Get
            Return _adresse

        End Get
        Set(ByVal value As String)
            _adresse = value

        End Set
    End Property

    Public Sub New(ByVal adr As String)

        _adresse = adr
        _autos = New List(Of Automobile)


    End Sub
    ' Add Auto
    Public Function AddAuto(auto As Automobile) As String
        Try
            _autos.Add(auto)
            Return "automobile inséré"
        Catch ex As Exception
            Return "erreur l'ajout d'automobile"
        End Try
    End Function

    ' Get Auto
    Public Function GetAuto(immatrica As String) As Automobile
        For Each a As Automobile In _autos
            If (a.Immatriculation.Equals(immatrica)) Then

                Return a

            End If
        Next
        Return Nothing

    End Function

End Class

