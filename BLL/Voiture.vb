

Public Class Voiture
    Inherits Automobile
    Private _couleur As String
    Private _marque As String
    Private _typeVoiture As String

    Public Property Couleur() As String

        Get
            Return _couleur

        End Get
        Set(ByVal value As String)
            _couleur = value

        End Set
    End Property
    Public Property Marque() As String



        Get
            Return _marque

        End Get
        Set(ByVal value As String)
            _marque = value

        End Set
    End Property

    Public Property TypeVoiture() As String



        Get
            Return _typeVoiture

        End Get
        Set(ByVal value As String)
            _typeVoiture = value

        End Set
    End Property


    Public Sub New()
  
    End Sub









    Public Sub New(ann As Int32, ByVal imm As String, ByVal coul As String, ByVal mar As String, ByVal typev As String)
        MyBase.New(ann, imm)
        _couleur = coul
        _marque = mar
        _typeVoiture = typev

    End Sub


    Public Overrides Function ToString() As String
        Return MyBase.ToString() + "la couleur est  " + _couleur + " La marque est " + _marque + " le type est " + _typeVoiture

    End Function


    Public Overloads Sub afficher()

        Console.WriteLine(ToString())
    End Sub

End Class

