
Imports BLL
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class GarageDAO
    'ajouter voiture 
    'Create a Connection object.
    Public Sub New()

    End Sub
    Public Function addCar(v As Voiture) As Boolean
        Dim SQLCon As New SqlConnection With {.ConnectionString = "Initial Catalog=GarageHamza; Data Source=hamza-pc;Integrated Security=SSPI;"}

        Dim SQLCmd As SqlCommand

        Try
            SQLCon.Open()

            Dim req As String = "Insert Into Automobile (Annee,Immatriculation,Coulour,Marque,TypeV,AutoMoto) Values(" + v.Annee.ToString() + ",'" + v.Immatriculation + "','" + v.Couleur + "','" + v.Marque + "','" + v.TypeVoiture + "','True');"

            SQLCmd = New SqlCommand(req, SQLCon)

            If (SQLCmd.ExecuteNonQuery() > 0) Then

                SQLCon.Close()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

    End Function

    Public Function addMoto(m As Moto) As Boolean
        Dim SQLCon As New SqlConnection With {.ConnectionString = "Initial Catalog=GarageHamza; Data Source=hamza-pc;Integrated Security=SSPI;"}

        Dim SQLCmd As SqlCommand

        Try
            SQLCon.Open()

            Dim req As String = "Insert Into Automobile (Annee,Immatriculation,Cylindre,VitesseMax,AutoMoto) Values(" + m.Annee.ToString() + ",'" + m.Immatriculation + "','" + m.Cylindre.ToString() + "','" + m.VitesseMax.ToString() + "','False');"

            SQLCmd = New SqlCommand(req, SQLCon)

            If (SQLCmd.ExecuteNonQuery() > 0) Then

                SQLCon.Close()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

    End Function


    Public Function getLesVoitures() As List(Of Voiture)
        Dim voitures As List(Of Voiture) = New List(Of Voiture)
        Dim SQLCon As New SqlConnection With {.ConnectionString = "Initial Catalog=GarageHamza; Data Source=hamza-pc;Integrated Security=SSPI;"}

        Dim SQLCmd As SqlCommand

        Try


            SQLCon.Open()
            Dim req As String = "select * from Automobile where AutoMoto='True';"

            SQLCmd = New SqlCommand(req, SQLCon)

            Dim reder As SqlDataReader = SQLCmd.ExecuteReader()

            While (reder.Read())
                Dim annee As Int32 = Int32.Parse(reder("Annee"))
                Dim imm As String = reder("Immatriculation")
                Dim coul As String = reder("Coulour")
                Dim marque As String = reder("Marque")
                Dim typev As String = reder("TypeV")
               

                Dim uneVoitue As Voiture = New Voiture(annee, imm, coul, marque, typev)
                voitures.Add(uneVoitue)
            End While
            SQLCon.Close()
         
            Return voitures
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function


    Public Function getLesMotos() As List(Of Moto)
        Dim motos As List(Of Moto) = New List(Of Moto)
        Dim SQLCon As New SqlConnection With {.ConnectionString = "Initial Catalog=GarageHamza; Data Source=hamza-pc;Integrated Security=SSPI;"}

        Dim SQLCmd As SqlCommand

        Try
            SQLCon.Open()
            Dim req As String = "select * from Automobile where AutoMoto='False';"

            SQLCmd = New SqlCommand(req, SQLCon)

            Dim reder As SqlDataReader = SQLCmd.ExecuteReader()

            While (reder.Read())
                Dim annee As Int32 = Int32.Parse(reder("Annee"))
                Dim imm As String = reder("Immatriculation")
                Dim cyl As Int32 = reder("Cylindre")
                Dim vitesse As Int32 = reder("VitesseMax")


                Dim unMoto As Moto = New Moto(annee, imm, cyl, vitesse)
                motos.Add(unMoto)
            End While
            SQLCon.Close()

            Return motos
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function

    Public Function modifierVoiture(imm As String, v As Voiture) As Boolean
        Dim SQLCon As New SqlConnection With {.ConnectionString = "Initial Catalog=GarageHamza; Data Source=hamza-pc;Integrated Security=SSPI;"}

        Dim SQLCmd As SqlCommand

        Try
            SQLCon.Open()

            Dim req As String = "Update Automobile Set Annee=" + v.Annee.ToString() + ",Coulour='" + v.Couleur + "',Marque='" + v.Marque + "',TypeV='" + v.TypeVoiture + "' Where AutoMoto='True' And Immatriculation='" + imm + "';"

            SQLCmd = New SqlCommand(req, SQLCon)

            If (SQLCmd.ExecuteNonQuery() > 0) Then

                SQLCon.Close()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function modifierMoto(imm As String, m As Moto) As Boolean
        Dim SQLCon As New SqlConnection With {.ConnectionString = "Initial Catalog=GarageHamza; Data Source=hamza-pc;Integrated Security=SSPI;"}

        Dim SQLCmd As SqlCommand

        Try
            SQLCon.Open()

            Dim req As String = "Update Automobile Set Annee=" + m.Annee.ToString() + ",Cylindre=" + m.Cylindre.ToString() + ",VitesseMax=" + m.VitesseMax.ToString() + " Where AutoMoto='False' And Immatriculation='" + imm + "';"

            SQLCmd = New SqlCommand(req, SQLCon)

            If (SQLCmd.ExecuteNonQuery() > 0) Then

                SQLCon.Close()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function


    Public Function supprimerAutomobile(imm As String) As Boolean
        Dim SQLCon As New SqlConnection With {.ConnectionString = "Initial Catalog=GarageHamza; Data Source=hamza-pc;Integrated Security=SSPI;"}

        Dim SQLCmd As SqlCommand

        Try
            SQLCon.Open()

            Dim req As String = "Delete From Automobile Where Immatriculation='" + imm + "';"

            SQLCmd = New SqlCommand(req, SQLCon)

            If (SQLCmd.ExecuteNonQuery() > 0) Then

                SQLCon.Close()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

End Class

