Imports DAL
Imports BLL

Public Class Supprission

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Close()
    End Sub

    Private Sub btn_sup_Click(sender As Object, e As EventArgs) Handles btn_sup.Click
        Dim imm As String = txt_imatriculation.Text
        Dim garage As GarageDAO = New GarageDAO()
        If (garage.supprimerAutomobile(imm)) Then
            MessageBox.Show("Supprission bien fait")
        Else
            MessageBox.Show("Erreur, l'immatriculation n'existe pas!")
        End If
    End Sub
End Class