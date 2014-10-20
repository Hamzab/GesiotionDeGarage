<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Supprission
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
        Me.txt_imatriculation = New System.Windows.Forms.TextBox()
        Me.btn_sup = New System.Windows.Forms.Button()
        Me.lbl_imm = New System.Windows.Forms.Label()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_imatriculation
        '
        Me.txt_imatriculation.Location = New System.Drawing.Point(219, 149)
        Me.txt_imatriculation.Name = "txt_imatriculation"
        Me.txt_imatriculation.Size = New System.Drawing.Size(145, 20)
        Me.txt_imatriculation.TabIndex = 0
        '
        'btn_sup
        '
        Me.btn_sup.Location = New System.Drawing.Point(107, 245)
        Me.btn_sup.Name = "btn_sup"
        Me.btn_sup.Size = New System.Drawing.Size(123, 23)
        Me.btn_sup.TabIndex = 1
        Me.btn_sup.Text = "Supprime Automobile"
        Me.btn_sup.UseVisualStyleBackColor = True
        '
        'lbl_imm
        '
        Me.lbl_imm.AutoSize = True
        Me.lbl_imm.Location = New System.Drawing.Point(93, 149)
        Me.lbl_imm.Name = "lbl_imm"
        Me.lbl_imm.Size = New System.Drawing.Size(77, 13)
        Me.lbl_imm.TabIndex = 2
        Me.lbl_imm.Text = "Immatriculation"
        '
        'btn_close
        '
        Me.btn_close.Location = New System.Drawing.Point(330, 245)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(75, 23)
        Me.btn_close.TabIndex = 3
        Me.btn_close.Text = "Fermer"
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'Supprission
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 415)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.lbl_imm)
        Me.Controls.Add(Me.btn_sup)
        Me.Controls.Add(Me.txt_imatriculation)
        Me.Name = "Supprission"
        Me.Text = "Supprission"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_imatriculation As System.Windows.Forms.TextBox
    Friend WithEvents btn_sup As System.Windows.Forms.Button
    Friend WithEvents lbl_imm As System.Windows.Forms.Label
    Friend WithEvents btn_close As System.Windows.Forms.Button
End Class
