
Imports DAL
Imports BLL


Public Class Form1
    Dim garage As GarageDAO = New GarageDAO()
    Private Sub Lal_titre_Click(sender As Object, e As EventArgs) Handles Lal_titre.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        List_categorie.Items.Add("Voiture")
        List_categorie.Items.Add("Moto")

    End Sub

    Private Sub List_categorie_SelectedIndexChanged(sender As Object, e As EventArgs) Handles List_categorie.SelectedIndexChanged
        If (List_categorie.SelectedIndex = 0) Then
            Lbl_couleur.Visible = True
            LBL_Marque.Visible = True
            lbl_typeV.Visible = True

            Txt_couleur.Visible = True
            Txt_marque.Visible = True
            Txt_TypeV.Visible = True
            Lbl_Cylindre.Visible = False
            lbl_vitesse.Visible = False
            txt_Cylindre.Visible = False
            txt_Vitesse.Visible = False
        End If

        If (List_categorie.SelectedIndex = 1) Then
            Lbl_couleur.Visible = False
            LBL_Marque.Visible = False
            lbl_typeV.Visible = False

            Txt_couleur.Visible = False
            Txt_marque.Visible = False
            Txt_TypeV.Visible = False



            Lbl_Cylindre.Visible = True
            lbl_vitesse.Visible = True
            txt_Cylindre.Visible = True
            txt_Vitesse.Visible = True
        End If

    End Sub

    Private Sub Bt1_ajouter_Click(sender As Object, e As EventArgs) Handles Bt1_ajouter.Click
        If (List_categorie.SelectedIndex = 0) Then
            Dim v As Voiture = New Voiture()
            v.Annee = Convert.ToInt32(txt_Annee.Text)
            v.Couleur = Txt_couleur.Text
            v.Immatriculation = Txt_Immatriculation.Text
            v.Marque = Txt_marque.Text
            v.TypeVoiture = Txt_TypeV.Text
            If (garage.addCar(v)) Then
                MessageBox.Show("L'ajout d'une voiture bien fait")
            Else
                MessageBox.Show("Erreur, l'ajout d'une voiture mal fait")
            End If


        End If
        If (List_categorie.SelectedIndex = 1) Then
            Dim m As Moto = New Moto()
            m.Annee = Convert.ToInt32(txt_Annee.Text)
            m.Immatriculation = Txt_Immatriculation.Text
            m.Cylindre = Convert.ToInt32(txt_Cylindre.Text)
            m.VitesseMax = Convert.ToInt32(txt_Vitesse.Text)

            If (garage.addMoto(m)) Then
                MessageBox.Show("L'ajout d'un moto bien fait")
            Else
                MessageBox.Show("Erreur, l'ajout d'un moto mal fait")
            End If
        End If

    End Sub

    Private Sub btn_afficher_Voiture_Click(sender As Object, e As EventArgs) Handles btn_afficher_Voiture.Click
        Dim a As Afficher = New Afficher()
        a.Show()

    End Sub

    Private Sub btn_modifie_Click(sender As Object, e As EventArgs) Handles btn_modifie.Click
        Dim m As Modification = New Modification()
        m.Show()
    End Sub

    Private Sub btn_supp_Click(sender As Object, e As EventArgs) Handles btn_supp.Click
        Dim supp As Supprission = New Supprission()
        supp.Show()
    End Sub
End Class
