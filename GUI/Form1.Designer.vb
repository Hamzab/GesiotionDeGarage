<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Lbl_Annee = New System.Windows.Forms.Label()
        Me.Labl_Immatriculation = New System.Windows.Forms.Label()
        Me.Lbl_Categorie = New System.Windows.Forms.Label()
        Me.txt_Annee = New System.Windows.Forms.TextBox()
        Me.Txt_Immatriculation = New System.Windows.Forms.TextBox()
        Me.List_categorie = New System.Windows.Forms.ComboBox()
        Me.Gorupe_Moto = New System.Windows.Forms.GroupBox()
        Me.txt_Vitesse = New System.Windows.Forms.TextBox()
        Me.Lbl_Cylindre = New System.Windows.Forms.Label()
        Me.txt_Cylindre = New System.Windows.Forms.TextBox()
        Me.lbl_vitesse = New System.Windows.Forms.Label()
        Me.Combo_Voiture = New System.Windows.Forms.GroupBox()
        Me.Txt_TypeV = New System.Windows.Forms.TextBox()
        Me.lbl_typeV = New System.Windows.Forms.Label()
        Me.Txt_marque = New System.Windows.Forms.TextBox()
        Me.LBL_Marque = New System.Windows.Forms.Label()
        Me.Txt_couleur = New System.Windows.Forms.TextBox()
        Me.Lbl_couleur = New System.Windows.Forms.Label()
        Me.Bt1_ajouter = New System.Windows.Forms.Button()
        Me.btn_afficher_Voiture = New System.Windows.Forms.Button()
        Me.Lal_titre = New System.Windows.Forms.Label()
        Me.btn_modifie = New System.Windows.Forms.Button()
        Me.btn_supp = New System.Windows.Forms.Button()
        Me.Gorupe_Moto.SuspendLayout()
        Me.Combo_Voiture.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lbl_Annee
        '
        Me.Lbl_Annee.AutoSize = True
        Me.Lbl_Annee.Location = New System.Drawing.Point(243, 56)
        Me.Lbl_Annee.Name = "Lbl_Annee"
        Me.Lbl_Annee.Size = New System.Drawing.Size(38, 13)
        Me.Lbl_Annee.TabIndex = 0
        Me.Lbl_Annee.Text = "Annee"
        '
        'Labl_Immatriculation
        '
        Me.Labl_Immatriculation.AutoSize = True
        Me.Labl_Immatriculation.Location = New System.Drawing.Point(243, 93)
        Me.Labl_Immatriculation.Name = "Labl_Immatriculation"
        Me.Labl_Immatriculation.Size = New System.Drawing.Size(74, 13)
        Me.Labl_Immatriculation.TabIndex = 1
        Me.Labl_Immatriculation.Text = "Immatriculaion"
        '
        'Lbl_Categorie
        '
        Me.Lbl_Categorie.AutoSize = True
        Me.Lbl_Categorie.Location = New System.Drawing.Point(243, 121)
        Me.Lbl_Categorie.Name = "Lbl_Categorie"
        Me.Lbl_Categorie.Size = New System.Drawing.Size(52, 13)
        Me.Lbl_Categorie.TabIndex = 2
        Me.Lbl_Categorie.Text = "Categorie"
        '
        'txt_Annee
        '
        Me.txt_Annee.Location = New System.Drawing.Point(326, 56)
        Me.txt_Annee.Name = "txt_Annee"
        Me.txt_Annee.Size = New System.Drawing.Size(118, 20)
        Me.txt_Annee.TabIndex = 3
        '
        'Txt_Immatriculation
        '
        Me.Txt_Immatriculation.Location = New System.Drawing.Point(326, 86)
        Me.Txt_Immatriculation.Name = "Txt_Immatriculation"
        Me.Txt_Immatriculation.Size = New System.Drawing.Size(118, 20)
        Me.Txt_Immatriculation.TabIndex = 4
        '
        'List_categorie
        '
        Me.List_categorie.FormattingEnabled = True
        Me.List_categorie.Location = New System.Drawing.Point(326, 118)
        Me.List_categorie.Name = "List_categorie"
        Me.List_categorie.Size = New System.Drawing.Size(121, 21)
        Me.List_categorie.TabIndex = 5
        '
        'Gorupe_Moto
        '
        Me.Gorupe_Moto.Controls.Add(Me.txt_Vitesse)
        Me.Gorupe_Moto.Controls.Add(Me.Lbl_Cylindre)
        Me.Gorupe_Moto.Controls.Add(Me.txt_Cylindre)
        Me.Gorupe_Moto.Controls.Add(Me.lbl_vitesse)
        Me.Gorupe_Moto.Location = New System.Drawing.Point(51, 200)
        Me.Gorupe_Moto.Name = "Gorupe_Moto"
        Me.Gorupe_Moto.Size = New System.Drawing.Size(267, 178)
        Me.Gorupe_Moto.TabIndex = 6
        Me.Gorupe_Moto.TabStop = False
        Me.Gorupe_Moto.Text = "Moto"
        '
        'txt_Vitesse
        '
        Me.txt_Vitesse.Location = New System.Drawing.Point(121, 100)
        Me.txt_Vitesse.Name = "txt_Vitesse"
        Me.txt_Vitesse.Size = New System.Drawing.Size(118, 20)
        Me.txt_Vitesse.TabIndex = 8
        '
        'Lbl_Cylindre
        '
        Me.Lbl_Cylindre.AutoSize = True
        Me.Lbl_Cylindre.Location = New System.Drawing.Point(33, 48)
        Me.Lbl_Cylindre.Name = "Lbl_Cylindre"
        Me.Lbl_Cylindre.Size = New System.Drawing.Size(44, 13)
        Me.Lbl_Cylindre.TabIndex = 7
        Me.Lbl_Cylindre.Text = "Cylindre"
        '
        'txt_Cylindre
        '
        Me.txt_Cylindre.Location = New System.Drawing.Point(121, 48)
        Me.txt_Cylindre.Name = "txt_Cylindre"
        Me.txt_Cylindre.Size = New System.Drawing.Size(118, 20)
        Me.txt_Cylindre.TabIndex = 6
        '
        'lbl_vitesse
        '
        Me.lbl_vitesse.AutoSize = True
        Me.lbl_vitesse.Location = New System.Drawing.Point(33, 100)
        Me.lbl_vitesse.Name = "lbl_vitesse"
        Me.lbl_vitesse.Size = New System.Drawing.Size(41, 13)
        Me.lbl_vitesse.TabIndex = 5
        Me.lbl_vitesse.Text = "Vitesse"
        '
        'Combo_Voiture
        '
        Me.Combo_Voiture.Controls.Add(Me.Txt_TypeV)
        Me.Combo_Voiture.Controls.Add(Me.lbl_typeV)
        Me.Combo_Voiture.Controls.Add(Me.Txt_marque)
        Me.Combo_Voiture.Controls.Add(Me.LBL_Marque)
        Me.Combo_Voiture.Controls.Add(Me.Txt_couleur)
        Me.Combo_Voiture.Controls.Add(Me.Lbl_couleur)
        Me.Combo_Voiture.Location = New System.Drawing.Point(380, 199)
        Me.Combo_Voiture.Name = "Combo_Voiture"
        Me.Combo_Voiture.Size = New System.Drawing.Size(276, 178)
        Me.Combo_Voiture.TabIndex = 7
        Me.Combo_Voiture.TabStop = False
        Me.Combo_Voiture.Text = "Voiture"
        '
        'Txt_TypeV
        '
        Me.Txt_TypeV.Location = New System.Drawing.Point(121, 108)
        Me.Txt_TypeV.Name = "Txt_TypeV"
        Me.Txt_TypeV.Size = New System.Drawing.Size(118, 20)
        Me.Txt_TypeV.TabIndex = 14
        '
        'lbl_typeV
        '
        Me.lbl_typeV.AutoSize = True
        Me.lbl_typeV.Location = New System.Drawing.Point(6, 108)
        Me.lbl_typeV.Name = "lbl_typeV"
        Me.lbl_typeV.Size = New System.Drawing.Size(67, 13)
        Me.lbl_typeV.TabIndex = 13
        Me.lbl_typeV.Text = "Type Voiture"
        '
        'Txt_marque
        '
        Me.Txt_marque.Location = New System.Drawing.Point(121, 67)
        Me.Txt_marque.Name = "Txt_marque"
        Me.Txt_marque.Size = New System.Drawing.Size(118, 20)
        Me.Txt_marque.TabIndex = 12
        '
        'LBL_Marque
        '
        Me.LBL_Marque.AutoSize = True
        Me.LBL_Marque.Location = New System.Drawing.Point(15, 67)
        Me.LBL_Marque.Name = "LBL_Marque"
        Me.LBL_Marque.Size = New System.Drawing.Size(43, 13)
        Me.LBL_Marque.TabIndex = 11
        Me.LBL_Marque.Text = "Marque"
        '
        'Txt_couleur
        '
        Me.Txt_couleur.Location = New System.Drawing.Point(121, 29)
        Me.Txt_couleur.Name = "Txt_couleur"
        Me.Txt_couleur.Size = New System.Drawing.Size(118, 20)
        Me.Txt_couleur.TabIndex = 10
        '
        'Lbl_couleur
        '
        Me.Lbl_couleur.AutoSize = True
        Me.Lbl_couleur.Location = New System.Drawing.Point(15, 29)
        Me.Lbl_couleur.Name = "Lbl_couleur"
        Me.Lbl_couleur.Size = New System.Drawing.Size(43, 13)
        Me.Lbl_couleur.TabIndex = 9
        Me.Lbl_couleur.Text = "Couleur"
        '
        'Bt1_ajouter
        '
        Me.Bt1_ajouter.Location = New System.Drawing.Point(42, 384)
        Me.Bt1_ajouter.Name = "Bt1_ajouter"
        Me.Bt1_ajouter.Size = New System.Drawing.Size(134, 23)
        Me.Bt1_ajouter.TabIndex = 8
        Me.Bt1_ajouter.Text = "Ajouter Automobile"
        Me.Bt1_ajouter.UseVisualStyleBackColor = True
        '
        'btn_afficher_Voiture
        '
        Me.btn_afficher_Voiture.Location = New System.Drawing.Point(198, 384)
        Me.btn_afficher_Voiture.Name = "btn_afficher_Voiture"
        Me.btn_afficher_Voiture.Size = New System.Drawing.Size(140, 23)
        Me.btn_afficher_Voiture.TabIndex = 9
        Me.btn_afficher_Voiture.Text = "Afficher Automobile"
        Me.btn_afficher_Voiture.UseVisualStyleBackColor = True
        '
        'Lal_titre
        '
        Me.Lal_titre.AutoSize = True
        Me.Lal_titre.Location = New System.Drawing.Point(276, 19)
        Me.Lal_titre.Name = "Lal_titre"
        Me.Lal_titre.Size = New System.Drawing.Size(115, 13)
        Me.Lal_titre.TabIndex = 10
        Me.Lal_titre.Text = "Ajouter une automobile"
        '
        'btn_modifie
        '
        Me.btn_modifie.Location = New System.Drawing.Point(367, 384)
        Me.btn_modifie.Name = "btn_modifie"
        Me.btn_modifie.Size = New System.Drawing.Size(142, 23)
        Me.btn_modifie.TabIndex = 11
        Me.btn_modifie.Text = "Modifier Automobile"
        Me.btn_modifie.UseVisualStyleBackColor = True
        '
        'btn_supp
        '
        Me.btn_supp.Location = New System.Drawing.Point(548, 384)
        Me.btn_supp.Name = "btn_supp"
        Me.btn_supp.Size = New System.Drawing.Size(127, 23)
        Me.btn_supp.TabIndex = 12
        Me.btn_supp.Text = "Supprimer Automobile"
        Me.btn_supp.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(725, 428)
        Me.Controls.Add(Me.btn_supp)
        Me.Controls.Add(Me.btn_modifie)
        Me.Controls.Add(Me.Lal_titre)
        Me.Controls.Add(Me.btn_afficher_Voiture)
        Me.Controls.Add(Me.Bt1_ajouter)
        Me.Controls.Add(Me.Combo_Voiture)
        Me.Controls.Add(Me.Gorupe_Moto)
        Me.Controls.Add(Me.List_categorie)
        Me.Controls.Add(Me.Txt_Immatriculation)
        Me.Controls.Add(Me.txt_Annee)
        Me.Controls.Add(Me.Lbl_Categorie)
        Me.Controls.Add(Me.Labl_Immatriculation)
        Me.Controls.Add(Me.Lbl_Annee)
        Me.Name = "Form1"
        Me.Text = "Gestion de garage"
        Me.Gorupe_Moto.ResumeLayout(False)
        Me.Gorupe_Moto.PerformLayout()
        Me.Combo_Voiture.ResumeLayout(False)
        Me.Combo_Voiture.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl_Annee As System.Windows.Forms.Label
    Friend WithEvents Labl_Immatriculation As System.Windows.Forms.Label
    Friend WithEvents Lbl_Categorie As System.Windows.Forms.Label
    Friend WithEvents txt_Annee As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Immatriculation As System.Windows.Forms.TextBox
    Friend WithEvents List_categorie As System.Windows.Forms.ComboBox
    Friend WithEvents Gorupe_Moto As System.Windows.Forms.GroupBox
    Friend WithEvents txt_Vitesse As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Cylindre As System.Windows.Forms.Label
    Friend WithEvents txt_Cylindre As System.Windows.Forms.TextBox
    Friend WithEvents lbl_vitesse As System.Windows.Forms.Label
    Friend WithEvents Combo_Voiture As System.Windows.Forms.GroupBox
    Friend WithEvents Txt_TypeV As System.Windows.Forms.TextBox
    Friend WithEvents lbl_typeV As System.Windows.Forms.Label
    Friend WithEvents Txt_marque As System.Windows.Forms.TextBox
    Friend WithEvents LBL_Marque As System.Windows.Forms.Label
    Friend WithEvents Txt_couleur As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_couleur As System.Windows.Forms.Label
    Friend WithEvents Bt1_ajouter As System.Windows.Forms.Button
    Friend WithEvents btn_afficher_Voiture As System.Windows.Forms.Button
    Friend WithEvents Lal_titre As System.Windows.Forms.Label
    Friend WithEvents btn_modifie As System.Windows.Forms.Button
    Friend WithEvents btn_supp As System.Windows.Forms.Button

End Class
