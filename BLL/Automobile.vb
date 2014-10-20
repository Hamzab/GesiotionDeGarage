Imports System

Public Class Automobile

    Private _annee As Int32
    Private _immatriculation As String

    'constructeur annee
    Public Property Annee As Int32
        Get
            Return _annee


        End Get
        Set(value As Int32)
            _annee = value
        End Set


    End Property


    ' constructeur  immatriculation

    Public Property Immatriculation As String

        Get
            Return _immatriculation

        End Get
        Set(ByVal value As String)
            _immatriculation = value

        End Set
    End Property

    Public Sub New()
        _annee = 0
        _immatriculation = ""
    End Sub
    Public Sub New(ann As Int32, imm As String)
        _annee = ann
        _immatriculation = imm
    End Sub

    Public Overrides Function ToString() As String
        Return "annee est " & _annee & " L'Immatriculation est " + _immatriculation

    End Function


    Public Sub afficher()

        Console.WriteLine(ToString())
    End Sub


End Class

