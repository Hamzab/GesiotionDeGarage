Imports DAL
Imports BLL
Public Class Modification
    Dim garage As GarageDAO = New GarageDAO()
    Private Sub Modification_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        List_categorie.Items.Add("Voiture")
        List_categorie.Items.Add("Moto")
    End Sub

    Private Sub List_categorie_SelectedIndexChanged(sender As Object, e As EventArgs) Handles List_categorie.SelectedIndexChanged
        If (List_categorie.SelectedIndex = 0) Then
            txt_annee_voiture.Visible = True
            Txt_Immatriculation.Visible = True
            Txt_couleur.Visible = True
            Txt_marque.Visible = True
            Txt_TypeV.Visible = True
            lbl_annee_voiture.Visible = True
            Labl_Immatriculation.Visible = True
            Lbl_couleur.Visible = True
            LBL_Marque.Visible = True
            lbl_typeV.Visible = True
            txt_annee_moto.Visible = False
            txt_Cylindre.Visible = False
            txt_Vitesse.Visible = False
            lbl_annee_moto.Visible = False
            Lbl_Cylindre.Visible = False
            lbl_vitesse.Visible = False
        End If
        If (List_categorie.SelectedIndex = 1) Then

            Txt_Immatriculation.Visible = True
            txt_annee_voiture.Visible = False
            Txt_couleur.Visible = False
            Txt_marque.Visible = False
            Txt_TypeV.Visible = False
            Labl_Immatriculation.Visible = True
            lbl_annee_voiture.Visible = False
            Lbl_couleur.Visible = False
            LBL_Marque.Visible = False
            lbl_typeV.Visible = False

            txt_annee_moto.Visible = True
            txt_Cylindre.Visible = True
            txt_Vitesse.Visible = True

            lbl_annee_moto.Visible = True
            Lbl_Cylindre.Visible = True
            lbl_vitesse.Visible = True
        End If
    End Sub

    Private Sub btn_modifie_Click(sender As Object, e As EventArgs) Handles btn_modifie.Click

        If (List_categorie.SelectedIndex = 0) Then
            Dim ann As Int32 = Int32.Parse(txt_annee_voiture.Text)
            Dim imm As String = Txt_Immatriculation.Text
            Dim coul As String = txt_annee_voiture.Text
            Dim mar As String = Txt_marque.Text
            Dim type As String = Txt_TypeV.Text
            Dim voi As Voiture = New Voiture(ann, imm, coul, mar, type)
            If (garage.modifierVoiture(imm, voi)) Then
                MessageBox.Show("Modification bien fait")
            Else
                MessageBox.Show("Erreur, la modification mal fait")
            End If
        End If
        If (List_categorie.SelectedIndex = 1) Then
            Dim ann As Int32 = Int32.Parse(txt_annee_moto.Text)
            Dim imm As String = Txt_Immatriculation.Text
            Dim cyl As Int32 = Int32.Parse(txt_Cylindre.Text)
            Dim vitesse As Int32 = Int32.Parse(txt_Vitesse.Text)
            Dim moto As Moto = New Moto(ann, imm, cyl, vitesse)
            If (garage.modifierMoto(imm, moto)) Then
                MessageBox.Show("Modification bien fait")
            Else
                MessageBox.Show("Erreur, la modification mal fait")
            End If
        End If
  
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Close()
    End Sub
End Class