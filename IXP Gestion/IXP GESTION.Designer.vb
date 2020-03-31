<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Main
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
        Me.BT_CHARGE_E_PUBLI = New System.Windows.Forms.Button()
        Me.BT_CHARGE_E_TICKET = New System.Windows.Forms.Button()
        Me.GB_CHARGE_DONNEE = New System.Windows.Forms.GroupBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.GB_REPORTING = New System.Windows.Forms.GroupBox()
        Me.LBL_DER_REPORTING = New System.Windows.Forms.Label()
        Me.BT_CREER_REPORTING = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LBL_DER_MAJ = New System.Windows.Forms.Label()
        Me.LBL_CHEM_SOURCE = New System.Windows.Forms.Label()
        Me.LBL_SEMAINE = New System.Windows.Forms.Label()
        Me.GB_CHARGE_DONNEE.SuspendLayout()
        Me.GB_REPORTING.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BT_CHARGE_E_PUBLI
        '
        Me.BT_CHARGE_E_PUBLI.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_CHARGE_E_PUBLI.Location = New System.Drawing.Point(15, 28)
        Me.BT_CHARGE_E_PUBLI.Name = "BT_CHARGE_E_PUBLI"
        Me.BT_CHARGE_E_PUBLI.Size = New System.Drawing.Size(137, 39)
        Me.BT_CHARGE_E_PUBLI.TabIndex = 0
        Me.BT_CHARGE_E_PUBLI.Text = "Charger un fichier d'Export Publipostage"
        Me.BT_CHARGE_E_PUBLI.UseVisualStyleBackColor = True
        '
        'BT_CHARGE_E_TICKET
        '
        Me.BT_CHARGE_E_TICKET.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_CHARGE_E_TICKET.Location = New System.Drawing.Point(15, 85)
        Me.BT_CHARGE_E_TICKET.Name = "BT_CHARGE_E_TICKET"
        Me.BT_CHARGE_E_TICKET.Size = New System.Drawing.Size(137, 39)
        Me.BT_CHARGE_E_TICKET.TabIndex = 1
        Me.BT_CHARGE_E_TICKET.Text = "Charger un fichier d'Export Ticket"
        Me.BT_CHARGE_E_TICKET.UseVisualStyleBackColor = True
        '
        'GB_CHARGE_DONNEE
        '
        Me.GB_CHARGE_DONNEE.Controls.Add(Me.BT_CHARGE_E_TICKET)
        Me.GB_CHARGE_DONNEE.Controls.Add(Me.BT_CHARGE_E_PUBLI)
        Me.GB_CHARGE_DONNEE.Location = New System.Drawing.Point(231, 77)
        Me.GB_CHARGE_DONNEE.Name = "GB_CHARGE_DONNEE"
        Me.GB_CHARGE_DONNEE.Size = New System.Drawing.Size(170, 144)
        Me.GB_CHARGE_DONNEE.TabIndex = 2
        Me.GB_CHARGE_DONNEE.TabStop = False
        Me.GB_CHARGE_DONNEE.Text = "Charger des données"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "Fichier CSV (*.csv) | *.csv"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(18, 59)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(352, 20)
        Me.TextBox1.TabIndex = 3
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog2"
        '
        'GB_REPORTING
        '
        Me.GB_REPORTING.Controls.Add(Me.LBL_DER_REPORTING)
        Me.GB_REPORTING.Controls.Add(Me.BT_CREER_REPORTING)
        Me.GB_REPORTING.Location = New System.Drawing.Point(13, 77)
        Me.GB_REPORTING.Name = "GB_REPORTING"
        Me.GB_REPORTING.Size = New System.Drawing.Size(200, 144)
        Me.GB_REPORTING.TabIndex = 4
        Me.GB_REPORTING.TabStop = False
        Me.GB_REPORTING.Text = "Reporting"
        '
        'LBL_DER_REPORTING
        '
        Me.LBL_DER_REPORTING.AutoSize = True
        Me.LBL_DER_REPORTING.Location = New System.Drawing.Point(15, 41)
        Me.LBL_DER_REPORTING.Name = "LBL_DER_REPORTING"
        Me.LBL_DER_REPORTING.Size = New System.Drawing.Size(91, 13)
        Me.LBL_DER_REPORTING.TabIndex = 1
        Me.LBL_DER_REPORTING.Text = "Dernier reporting :"
        '
        'BT_CREER_REPORTING
        '
        Me.BT_CREER_REPORTING.Location = New System.Drawing.Point(7, 85)
        Me.BT_CREER_REPORTING.Name = "BT_CREER_REPORTING"
        Me.BT_CREER_REPORTING.Size = New System.Drawing.Size(187, 39)
        Me.BT_CREER_REPORTING.TabIndex = 0
        Me.BT_CREER_REPORTING.Text = "Créer le reporting de la Semaine"
        Me.BT_CREER_REPORTING.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LBL_DER_MAJ)
        Me.GroupBox1.Controls.Add(Me.LBL_CHEM_SOURCE)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 236)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(388, 185)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Information Fichier"
        '
        'LBL_DER_MAJ
        '
        Me.LBL_DER_MAJ.AutoSize = True
        Me.LBL_DER_MAJ.Location = New System.Drawing.Point(15, 91)
        Me.LBL_DER_MAJ.Name = "LBL_DER_MAJ"
        Me.LBL_DER_MAJ.Size = New System.Drawing.Size(109, 13)
        Me.LBL_DER_MAJ.TabIndex = 1
        Me.LBL_DER_MAJ.Text = "Dernière mise a jour : "
        '
        'LBL_CHEM_SOURCE
        '
        Me.LBL_CHEM_SOURCE.AutoSize = True
        Me.LBL_CHEM_SOURCE.Location = New System.Drawing.Point(15, 32)
        Me.LBL_CHEM_SOURCE.Name = "LBL_CHEM_SOURCE"
        Me.LBL_CHEM_SOURCE.Size = New System.Drawing.Size(117, 13)
        Me.LBL_CHEM_SOURCE.TabIndex = 0
        Me.LBL_CHEM_SOURCE.Text = "Chemin du fichier .csv :"
        '
        'LBL_SEMAINE
        '
        Me.LBL_SEMAINE.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBL_SEMAINE.AutoSize = True
        Me.LBL_SEMAINE.Location = New System.Drawing.Point(12, 50)
        Me.LBL_SEMAINE.Name = "LBL_SEMAINE"
        Me.LBL_SEMAINE.Size = New System.Drawing.Size(101, 13)
        Me.LBL_SEMAINE.TabIndex = 6
        Me.LBL_SEMAINE.Text = "Semaine en cours : "
        '
        'Form_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LBL_SEMAINE)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GB_REPORTING)
        Me.Controls.Add(Me.GB_CHARGE_DONNEE)
        Me.Name = "Form_Main"
        Me.Text = "IXP Gestion"
        Me.GB_CHARGE_DONNEE.ResumeLayout(False)
        Me.GB_REPORTING.ResumeLayout(False)
        Me.GB_REPORTING.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BT_CHARGE_E_PUBLI As Button
    Friend WithEvents BT_CHARGE_E_TICKET As Button
    Friend WithEvents GB_CHARGE_DONNEE As GroupBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents OpenFileDialog2 As OpenFileDialog
    Friend WithEvents GB_REPORTING As GroupBox
    Friend WithEvents LBL_DER_REPORTING As Label
    Friend WithEvents BT_CREER_REPORTING As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LBL_DER_MAJ As Label
    Friend WithEvents LBL_CHEM_SOURCE As Label
    Friend WithEvents LBL_SEMAINE As Label
End Class
