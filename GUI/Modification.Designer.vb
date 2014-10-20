<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Modification
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
        Me.List_categorie = New System.Windows.Forms.ComboBox()
        Me.Txt_Immatriculation = New System.Windows.Forms.TextBox()
        Me.txt_annee_moto = New System.Windows.Forms.TextBox()
        Me.Lbl_Categorie = New System.Windows.Forms.Label()
        Me.Labl_Immatriculation = New System.Windows.Forms.Label()
        Me.lbl_annee_moto = New System.Windows.Forms.Label()
        Me.txt_Vitesse = New System.Windows.Forms.TextBox()
        Me.Lbl_Cylindre = New System.Windows.Forms.Label()
        Me.txt_Cylindre = New System.Windows.Forms.TextBox()
        Me.lbl_vitesse = New System.Windows.Forms.Label()
        Me.Gorupe_Moto = New System.Windows.Forms.GroupBox()
        Me.Combo_Voiture = New System.Windows.Forms.GroupBox()
        Me.Txt_TypeV = New System.Windows.Forms.TextBox()
        Me.lbl_typeV = New System.Windows.Forms.Label()
        Me.Txt_marque = New System.Windows.Forms.TextBox()
        Me.LBL_Marque = New System.Windows.Forms.Label()
        Me.Txt_couleur = New System.Windows.Forms.TextBox()
        Me.Lbl_couleur = New System.Windows.Forms.Label()
        Me.btn_modifie = New System.Windows.Forms.Button()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.txt_annee_voiture = New System.Windows.Forms.TextBox()
        Me.lbl_annee_voiture = New System.Windows.Forms.Label()
        Me.Gorupe_Moto.SuspendLayout()
        Me.Combo_Voiture.SuspendLayout()
        Me.SuspendLayout()
        '
        'List_categorie
        '
        Me.List_categorie.FormattingEnabled = True
        Me.List_categorie.Location = New System.Drawing.Point(319, 117)
        Me.List_categorie.Name = "List_categorie"
        Me.List_categorie.Size = New System.Drawing.Size(121, 21)
        Me.List_categorie.TabIndex = 11
        '
        'Txt_Immatriculation
        '
        Me.Txt_Immatriculation.Location = New System.Drawing.Point(319, 70)
        Me.Txt_Immatriculation.Name = "Txt_Immatriculation"
        Me.Txt_Immatriculation.Size = New System.Drawing.Size(118, 20)
        Me.Txt_Immatriculation.TabIndex = 10
        '
        'txt_annee_moto
        '
        Me.txt_annee_moto.Location = New System.Drawing.Point(112, 51)
        Me.txt_annee_moto.Name = "txt_annee_moto"
        Me.txt_annee_moto.Size = New System.Drawing.Size(118, 20)
        Me.txt_annee_moto.TabIndex = 9
        '
        'Lbl_Categorie
        '
        Me.Lbl_Categorie.AutoSize = True
        Me.Lbl_Categorie.Location = New System.Drawing.Point(236, 120)
        Me.Lbl_Categorie.Name = "Lbl_Categorie"
        Me.Lbl_Categorie.Size = New System.Drawing.Size(52, 13)
        Me.Lbl_Categorie.TabIndex = 8
        Me.Lbl_Categorie.Text = "Categorie"
        '
        'Labl_Immatriculation
        '
        Me.Labl_Immatriculation.AutoSize = True
        Me.Labl_Immatriculation.Location = New System.Drawing.Point(236, 77)
        Me.Labl_Immatriculation.Name = "Labl_Immatriculation"
        Me.Labl_Immatriculation.Size = New System.Drawing.Size(74, 13)
        Me.Labl_Immatriculation.TabIndex = 7
        Me.Labl_Immatriculation.Text = "Immatriculaion"
        '
        'lbl_annee_moto
        '
        Me.lbl_annee_moto.AutoSize = True
        Me.lbl_annee_moto.Location = New System.Drawing.Point(29, 51)
        Me.lbl_annee_moto.Name = "lbl_annee_moto"
        Me.lbl_annee_moto.Size = New System.Drawing.Size(38, 13)
        Me.lbl_annee_moto.TabIndex = 6
        Me.lbl_annee_moto.Text = "Annee"
        '
        'txt_Vitesse
        '
        Me.txt_Vitesse.Location = New System.Drawing.Point(112, 128)
        Me.txt_Vitesse.Name = "txt_Vitesse"
        Me.txt_Vitesse.Size = New System.Drawing.Size(118, 20)
        Me.txt_Vitesse.TabIndex = 8
        '
        'Lbl_Cylindre
        '
        Me.Lbl_Cylindre.AutoSize = True
        Me.Lbl_Cylindre.Location = New System.Drawing.Point(24, 89)
        Me.Lbl_Cylindre.Name = "Lbl_Cylindre"
        Me.Lbl_Cylindre.Size = New System.Drawing.Size(44, 13)
        Me.Lbl_Cylindre.TabIndex = 7
        Me.Lbl_Cylindre.Text = "Cylindre"
        '
        'txt_Cylindre
        '
        Me.txt_Cylindre.Location = New System.Drawing.Point(112, 89)
        Me.txt_Cylindre.Name = "txt_Cylindre"
        Me.txt_Cylindre.Size = New System.Drawing.Size(118, 20)
        Me.txt_Cylindre.TabIndex = 6
        '
        'lbl_vitesse
        '
        Me.lbl_vitesse.AutoSize = True
        Me.lbl_vitesse.Location = New System.Drawing.Point(24, 128)
        Me.lbl_vitesse.Name = "lbl_vitesse"
        Me.lbl_vitesse.Size = New System.Drawing.Size(41, 13)
        Me.lbl_vitesse.TabIndex = 5
        Me.lbl_vitesse.Text = "Vitesse"
        '
        'Gorupe_Moto
        '
        Me.Gorupe_Moto.Controls.Add(Me.txt_Vitesse)
        Me.Gorupe_Moto.Controls.Add(Me.Lbl_Cylindre)
        Me.Gorupe_Moto.Controls.Add(Me.txt_Cylindre)
        Me.Gorupe_Moto.Controls.Add(Me.lbl_vitesse)
        Me.Gorupe_Moto.Controls.Add(Me.txt_annee_moto)
        Me.Gorupe_Moto.Controls.Add(Me.lbl_annee_moto)
        Me.Gorupe_Moto.Location = New System.Drawing.Point(34, 229)
        Me.Gorupe_Moto.Name = "Gorupe_Moto"
        Me.Gorupe_Moto.Size = New System.Drawing.Size(267, 178)
        Me.Gorupe_Moto.TabIndex = 12
        Me.Gorupe_Moto.TabStop = False
        Me.Gorupe_Moto.Text = "Moto"
        '
        'Combo_Voiture
        '
        Me.Combo_Voiture.Controls.Add(Me.lbl_annee_voiture)
        Me.Combo_Voiture.Controls.Add(Me.txt_annee_voiture)
        Me.Combo_Voiture.Controls.Add(Me.Txt_TypeV)
        Me.Combo_Voiture.Controls.Add(Me.lbl_typeV)
        Me.Combo_Voiture.Controls.Add(Me.Txt_marque)
        Me.Combo_Voiture.Controls.Add(Me.LBL_Marque)
        Me.Combo_Voiture.Controls.Add(Me.Txt_couleur)
        Me.Combo_Voiture.Controls.Add(Me.Lbl_couleur)
        Me.Combo_Voiture.Location = New System.Drawing.Point(350, 229)
        Me.Combo_Voiture.Name = "Combo_Voiture"
        Me.Combo_Voiture.Size = New System.Drawing.Size(276, 178)
        Me.Combo_Voiture.TabIndex = 13
        Me.Combo_Voiture.TabStop = False
        Me.Combo_Voiture.Text = "Voiture"
        '
        'Txt_TypeV
        '
        Me.Txt_TypeV.Location = New System.Drawing.Point(121, 136)
        Me.Txt_TypeV.Name = "Txt_TypeV"
        Me.Txt_TypeV.Size = New System.Drawing.Size(118, 20)
        Me.Txt_TypeV.TabIndex = 14
        '
        'lbl_typeV
        '
        Me.lbl_typeV.AutoSize = True
        Me.lbl_typeV.Location = New System.Drawing.Point(15, 143)
        Me.lbl_typeV.Name = "lbl_typeV"
        Me.lbl_typeV.Size = New System.Drawing.Size(67, 13)
        Me.lbl_typeV.TabIndex = 13
        Me.lbl_typeV.Text = "Type Voiture"
        '
        'Txt_marque
        '
        Me.Txt_marque.Location = New System.Drawing.Point(121, 107)
        Me.Txt_marque.Name = "Txt_marque"
        Me.Txt_marque.Size = New System.Drawing.Size(118, 20)
        Me.Txt_marque.TabIndex = 12
        '
        'LBL_Marque
        '
        Me.LBL_Marque.AutoSize = True
        Me.LBL_Marque.Location = New System.Drawing.Point(15, 107)
        Me.LBL_Marque.Name = "LBL_Marque"
        Me.LBL_Marque.Size = New System.Drawing.Size(43, 13)
        Me.LBL_Marque.TabIndex = 11
        Me.LBL_Marque.Text = "Marque"
        '
        'Txt_couleur
        '
        Me.Txt_couleur.Location = New System.Drawing.Point(121, 69)
        Me.Txt_couleur.Name = "Txt_couleur"
        Me.Txt_couleur.Size = New System.Drawing.Size(118, 20)
        Me.Txt_couleur.TabIndex = 10
        '
        'Lbl_couleur
        '
        Me.Lbl_couleur.AutoSize = True
        Me.Lbl_couleur.Location = New System.Drawing.Point(15, 69)
        Me.Lbl_couleur.Name = "Lbl_couleur"
        Me.Lbl_couleur.Size = New System.Drawing.Size(43, 13)
        Me.Lbl_couleur.TabIndex = 9
        Me.Lbl_couleur.Text = "Couleur"
        '
        'btn_modifie
        '
        Me.btn_modifie.Location = New System.Drawing.Point(128, 424)
        Me.btn_modifie.Name = "btn_modifie"
        Me.btn_modifie.Size = New System.Drawing.Size(75, 23)
        Me.btn_modifie.TabIndex = 14
        Me.btn_modifie.Text = "Modifie"
        Me.btn_modifie.UseVisualStyleBackColor = True
        '
        'btn_close
        '
        Me.btn_close.Location = New System.Drawing.Point(422, 424)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(75, 23)
        Me.btn_close.TabIndex = 15
        Me.btn_close.Text = "Close"
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'txt_annee_voiture
        '
        Me.txt_annee_voiture.Location = New System.Drawing.Point(121, 31)
        Me.txt_annee_voiture.Name = "txt_annee_voiture"
        Me.txt_annee_voiture.Size = New System.Drawing.Size(118, 20)
        Me.txt_annee_voiture.TabIndex = 16
        '
        'lbl_annee_voiture
        '
        Me.lbl_annee_voiture.AutoSize = True
        Me.lbl_annee_voiture.Location = New System.Drawing.Point(15, 34)
        Me.lbl_annee_voiture.Name = "lbl_annee_voiture"
        Me.lbl_annee_voiture.Size = New System.Drawing.Size(38, 13)
        Me.lbl_annee_voiture.TabIndex = 17
        Me.lbl_annee_voiture.Text = "Annee"
        '
        'Modification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(695, 468)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.btn_modifie)
        Me.Controls.Add(Me.Combo_Voiture)
        Me.Controls.Add(Me.Gorupe_Moto)
        Me.Controls.Add(Me.List_categorie)
        Me.Controls.Add(Me.Txt_Immatriculation)
        Me.Controls.Add(Me.Lbl_Categorie)
        Me.Controls.Add(Me.Labl_Immatriculation)
        Me.Name = "Modification"
        Me.Text = "Modification"
        Me.Gorupe_Moto.ResumeLayout(False)
        Me.Gorupe_Moto.PerformLayout()
        Me.Combo_Voiture.ResumeLayout(False)
        Me.Combo_Voiture.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents List_categorie As System.Windows.Forms.ComboBox
    Friend WithEvents Txt_Immatriculation As System.Windows.Forms.TextBox
    Friend WithEvents txt_annee_moto As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Categorie As System.Windows.Forms.Label
    Friend WithEvents Labl_Immatriculation As System.Windows.Forms.Label
    Friend WithEvents lbl_annee_moto As System.Windows.Forms.Label
    Friend WithEvents txt_Vitesse As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Cylindre As System.Windows.Forms.Label
    Friend WithEvents txt_Cylindre As System.Windows.Forms.TextBox
    Friend WithEvents lbl_vitesse As System.Windows.Forms.Label
    Friend WithEvents Gorupe_Moto As System.Windows.Forms.GroupBox
    Friend WithEvents Combo_Voiture As System.Windows.Forms.GroupBox
    Friend WithEvents Txt_TypeV As System.Windows.Forms.TextBox
    Friend WithEvents lbl_typeV As System.Windows.Forms.Label
    Friend WithEvents Txt_marque As System.Windows.Forms.TextBox
    Friend WithEvents LBL_Marque As System.Windows.Forms.Label
    Friend WithEvents Txt_couleur As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_couleur As System.Windows.Forms.Label
    Friend WithEvents btn_modifie As System.Windows.Forms.Button
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents lbl_annee_voiture As System.Windows.Forms.Label
    Friend WithEvents txt_annee_voiture As System.Windows.Forms.TextBox
End Class
