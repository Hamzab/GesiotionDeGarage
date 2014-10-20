<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Afficher
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
        Me.txt_annee = New System.Windows.Forms.TextBox()
        Me.txt_imm = New System.Windows.Forms.TextBox()
        Me.txt_cyl = New System.Windows.Forms.TextBox()
        Me.txt_type = New System.Windows.Forms.TextBox()
        Me.txt_mar = New System.Windows.Forms.TextBox()
        Me.txt_col = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.liste_auto = New System.Windows.Forms.ComboBox()
        Me.lbl_annee = New System.Windows.Forms.Label()
        Me.lbl_coulour = New System.Windows.Forms.Label()
        Me.lbl_imm = New System.Windows.Forms.Label()
        Me.lbl_marque = New System.Windows.Forms.Label()
        Me.lbl_typeV = New System.Windows.Forms.Label()
        Me.lbl_cyl = New System.Windows.Forms.Label()
        Me.lbl_vitesse = New System.Windows.Forms.Label()
        Me.txt_vitesse = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txt_annee
        '
        Me.txt_annee.Location = New System.Drawing.Point(408, 34)
        Me.txt_annee.Name = "txt_annee"
        Me.txt_annee.Size = New System.Drawing.Size(100, 20)
        Me.txt_annee.TabIndex = 0
        '
        'txt_imm
        '
        Me.txt_imm.Location = New System.Drawing.Point(408, 83)
        Me.txt_imm.Name = "txt_imm"
        Me.txt_imm.Size = New System.Drawing.Size(100, 20)
        Me.txt_imm.TabIndex = 1
        '
        'txt_cyl
        '
        Me.txt_cyl.Location = New System.Drawing.Point(408, 290)
        Me.txt_cyl.Name = "txt_cyl"
        Me.txt_cyl.Size = New System.Drawing.Size(100, 20)
        Me.txt_cyl.TabIndex = 2
        '
        'txt_type
        '
        Me.txt_type.Location = New System.Drawing.Point(408, 239)
        Me.txt_type.Name = "txt_type"
        Me.txt_type.Size = New System.Drawing.Size(100, 20)
        Me.txt_type.TabIndex = 3
        '
        'txt_mar
        '
        Me.txt_mar.Location = New System.Drawing.Point(408, 183)
        Me.txt_mar.Name = "txt_mar"
        Me.txt_mar.Size = New System.Drawing.Size(100, 20)
        Me.txt_mar.TabIndex = 4
        '
        'txt_col
        '
        Me.txt_col.Location = New System.Drawing.Point(408, 128)
        Me.txt_col.Name = "txt_col"
        Me.txt_col.Size = New System.Drawing.Size(100, 20)
        Me.txt_col.TabIndex = 5
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(40, 108)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(192, 199)
        Me.ListBox1.TabIndex = 6
        '
        'liste_auto
        '
        Me.liste_auto.FormattingEnabled = True
        Me.liste_auto.Location = New System.Drawing.Point(40, 33)
        Me.liste_auto.Name = "liste_auto"
        Me.liste_auto.Size = New System.Drawing.Size(121, 21)
        Me.liste_auto.TabIndex = 7
        '
        'lbl_annee
        '
        Me.lbl_annee.AutoSize = True
        Me.lbl_annee.Location = New System.Drawing.Point(352, 41)
        Me.lbl_annee.Name = "lbl_annee"
        Me.lbl_annee.Size = New System.Drawing.Size(38, 13)
        Me.lbl_annee.TabIndex = 8
        Me.lbl_annee.Text = "Annee"
        '
        'lbl_coulour
        '
        Me.lbl_coulour.AutoSize = True
        Me.lbl_coulour.Location = New System.Drawing.Point(352, 131)
        Me.lbl_coulour.Name = "lbl_coulour"
        Me.lbl_coulour.Size = New System.Drawing.Size(43, 13)
        Me.lbl_coulour.TabIndex = 9
        Me.lbl_coulour.Text = "Couleur"
        '
        'lbl_imm
        '
        Me.lbl_imm.AutoSize = True
        Me.lbl_imm.Location = New System.Drawing.Point(314, 86)
        Me.lbl_imm.Name = "lbl_imm"
        Me.lbl_imm.Size = New System.Drawing.Size(77, 13)
        Me.lbl_imm.TabIndex = 10
        Me.lbl_imm.Text = "Immatriculation"
        '
        'lbl_marque
        '
        Me.lbl_marque.AutoSize = True
        Me.lbl_marque.Location = New System.Drawing.Point(352, 190)
        Me.lbl_marque.Name = "lbl_marque"
        Me.lbl_marque.Size = New System.Drawing.Size(43, 13)
        Me.lbl_marque.TabIndex = 12
        Me.lbl_marque.Text = "Marque"
        '
        'lbl_typeV
        '
        Me.lbl_typeV.AutoSize = True
        Me.lbl_typeV.Location = New System.Drawing.Point(335, 246)
        Me.lbl_typeV.Name = "lbl_typeV"
        Me.lbl_typeV.Size = New System.Drawing.Size(67, 13)
        Me.lbl_typeV.TabIndex = 13
        Me.lbl_typeV.Text = "Type Voiture"
        '
        'lbl_cyl
        '
        Me.lbl_cyl.AutoSize = True
        Me.lbl_cyl.Location = New System.Drawing.Point(352, 297)
        Me.lbl_cyl.Name = "lbl_cyl"
        Me.lbl_cyl.Size = New System.Drawing.Size(44, 13)
        Me.lbl_cyl.TabIndex = 14
        Me.lbl_cyl.Text = "Cylindre"
        '
        'lbl_vitesse
        '
        Me.lbl_vitesse.AutoSize = True
        Me.lbl_vitesse.Location = New System.Drawing.Point(352, 340)
        Me.lbl_vitesse.Name = "lbl_vitesse"
        Me.lbl_vitesse.Size = New System.Drawing.Size(41, 13)
        Me.lbl_vitesse.TabIndex = 16
        Me.lbl_vitesse.Text = "Vitesse"
        '
        'txt_vitesse
        '
        Me.txt_vitesse.Location = New System.Drawing.Point(408, 333)
        Me.txt_vitesse.Name = "txt_vitesse"
        Me.txt_vitesse.Size = New System.Drawing.Size(100, 20)
        Me.txt_vitesse.TabIndex = 15
        '
        'Afficher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(585, 376)
        Me.Controls.Add(Me.lbl_vitesse)
        Me.Controls.Add(Me.txt_vitesse)
        Me.Controls.Add(Me.lbl_cyl)
        Me.Controls.Add(Me.lbl_typeV)
        Me.Controls.Add(Me.lbl_marque)
        Me.Controls.Add(Me.lbl_imm)
        Me.Controls.Add(Me.lbl_coulour)
        Me.Controls.Add(Me.lbl_annee)
        Me.Controls.Add(Me.liste_auto)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.txt_col)
        Me.Controls.Add(Me.txt_mar)
        Me.Controls.Add(Me.txt_type)
        Me.Controls.Add(Me.txt_cyl)
        Me.Controls.Add(Me.txt_imm)
        Me.Controls.Add(Me.txt_annee)
        Me.Name = "Afficher"
        Me.Text = "Afficher"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_annee As System.Windows.Forms.TextBox
    Friend WithEvents txt_imm As System.Windows.Forms.TextBox
    Friend WithEvents txt_cyl As System.Windows.Forms.TextBox
    Friend WithEvents txt_type As System.Windows.Forms.TextBox
    Friend WithEvents txt_mar As System.Windows.Forms.TextBox
    Friend WithEvents txt_col As System.Windows.Forms.TextBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents liste_auto As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_annee As System.Windows.Forms.Label
    Friend WithEvents lbl_coulour As System.Windows.Forms.Label
    Friend WithEvents lbl_imm As System.Windows.Forms.Label
    Friend WithEvents lbl_marque As System.Windows.Forms.Label
    Friend WithEvents lbl_typeV As System.Windows.Forms.Label
    Friend WithEvents lbl_cyl As System.Windows.Forms.Label
    Friend WithEvents lbl_vitesse As System.Windows.Forms.Label
    Friend WithEvents txt_vitesse As System.Windows.Forms.TextBox
End Class
