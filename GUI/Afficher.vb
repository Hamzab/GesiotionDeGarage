Imports DAL
Imports BLL
Public Class Afficher
    Dim garage As GarageDAO = New GarageDAO()
    Public Sub New()

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().

    End Sub
    Private Sub Afficher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        liste_auto.Items.Add("Voiture")
        liste_auto.Items.Add("Moto")
    End Sub



    Private Sub liste_auto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles liste_auto.SelectedIndexChanged
        ListBox1.Items.Clear()
        If (liste_auto.SelectedIndex = 0) Then

            ListBox1.Items.AddRange(garage.getLesVoitures().ToArray())
        End If
        If (liste_auto.SelectedIndex = 1) Then

            ListBox1.Items.AddRange(garage.getLesMotos().ToArray())
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim au As Automobile = ListBox1.SelectedItem
   
        If (liste_auto.SelectedIndex = 0) Then
            txt_annee.Text = ""
            txt_imm.Text = ""
            txt_col.Text = ""
            txt_mar.Text = ""
            txt_type.Text = ""
            txt_cyl.Text = ""
            txt_vitesse.Text = ""

            Dim v As Voiture = au
            If Not (v Is Nothing) Then
                txt_annee.Text = v.Annee.ToString()
                txt_imm.Text = v.Immatriculation.ToString()
                txt_col.Text = v.Couleur.ToString()
                txt_mar.Text = v.Marque.ToString()
                txt_type.Text = v.TypeVoiture.ToString()
            End If

        End If

        If (liste_auto.SelectedIndex = 1) Then
            txt_annee.Text = ""
            txt_imm.Text = ""
            txt_col.Text = ""
            txt_mar.Text = ""
            txt_type.Text = ""
            txt_cyl.Text = ""
            txt_vitesse.Text = ""

            Dim mo As Moto = au
            If Not (mo Is Nothing) Then
                txt_annee.Text = mo.Annee.ToString()
                txt_imm.Text = mo.Immatriculation.ToString()
                txt_cyl.Text = mo.Cylindre.ToString()
                txt_vitesse.Text = mo.VitesseMax.ToString()
            End If


        End If



    End Sub
End Class