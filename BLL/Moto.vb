

Public Class Moto
    Inherits Automobile

    Private _cylindre As Integer
    Private _vitesseMax As Integer

    Public Property Cylindre() As Integer

        Get
            Return _cylindre

        End Get
        Set(ByVal value As Integer)
            _cylindre = value

        End Set
    End Property
    Public Property VitesseMax() As Integer

        Get
            Return _vitesseMax

        End Get
        Set(ByVal value As Integer)
            _vitesseMax = value

        End Set
    End Property

    Public Sub New()
    End Sub
    Public Sub New(ByVal ann As Integer, ByVal imm As String, ByVal cyl As Integer, ByVal vitesse As Integer)
        MyBase.New(ann, imm)
        _cylindre = cyl
        _vitesseMax = vitesse

    End Sub


    Public Overrides Function ToString() As String
        Return MyBase.ToString() + "le cylindre est    " & _cylindre & " de vitesse max" & _vitesseMax

    End Function


    Public Overloads Sub afficher()

        Console.WriteLine(ToString())
    End Sub

End Class

