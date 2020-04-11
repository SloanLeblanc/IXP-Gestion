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
        Me.GB_CHARGE_DONNEE = New System.Windows.Forms.GroupBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TXT_CHEM_CSV = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.GB_REPORTING = New System.Windows.Forms.GroupBox()
        Me.BT_OUVRIR_REPORTING = New System.Windows.Forms.Button()
        Me.LBL_DER_REPORTING = New System.Windows.Forms.Label()
        Me.BT_CREER_REPORTING = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LBL_DER_MAJ = New System.Windows.Forms.Label()
        Me.LBL_CHEM_SOURCE = New System.Windows.Forms.Label()
        Me.LBL_SEMAINE = New System.Windows.Forms.Label()
        Me.LBL_TRIGRAMME = New System.Windows.Forms.Label()
        Me.TXT_TRIGRAMME = New System.Windows.Forms.TextBox()
        Me.BT_SAVE = New System.Windows.Forms.Button()
        Me.LBL_EX = New System.Windows.Forms.Label()
        Me.BT_SUPPR = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GB_CHARGE_DONNEE.SuspendLayout()
        Me.GB_REPORTING.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BT_CHARGE_E_PUBLI
        '
        Me.BT_CHARGE_E_PUBLI.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_CHARGE_E_PUBLI.Location = New System.Drawing.Point(15, 52)
        Me.BT_CHARGE_E_PUBLI.Name = "BT_CHARGE_E_PUBLI"
        Me.BT_CHARGE_E_PUBLI.Size = New System.Drawing.Size(137, 39)
        Me.BT_CHARGE_E_PUBLI.TabIndex = 0
        Me.BT_CHARGE_E_PUBLI.Text = "Charger un fichier d'Export Publipostage"
        Me.BT_CHARGE_E_PUBLI.UseVisualStyleBackColor = True
        '
        'GB_CHARGE_DONNEE
        '
        Me.GB_CHARGE_DONNEE.Controls.Add(Me.BT_CHARGE_E_PUBLI)
        Me.GB_CHARGE_DONNEE.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_CHARGE_DONNEE.Location = New System.Drawing.Point(230, 121)
        Me.GB_CHARGE_DONNEE.Name = "GB_CHARGE_DONNEE"
        Me.GB_CHARGE_DONNEE.Size = New System.Drawing.Size(170, 112)
        Me.GB_CHARGE_DONNEE.TabIndex = 2
        Me.GB_CHARGE_DONNEE.TabStop = False
        Me.GB_CHARGE_DONNEE.Text = "Charger des données"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "Fichier CSV (*.csv) | *.csv"
        '
        'TXT_CHEM_CSV
        '
        Me.TXT_CHEM_CSV.Location = New System.Drawing.Point(18, 59)
        Me.TXT_CHEM_CSV.Name = "TXT_CHEM_CSV"
        Me.TXT_CHEM_CSV.Size = New System.Drawing.Size(352, 22)
        Me.TXT_CHEM_CSV.TabIndex = 3
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog2"
        '
        'GB_REPORTING
        '
        Me.GB_REPORTING.Controls.Add(Me.BT_OUVRIR_REPORTING)
        Me.GB_REPORTING.Controls.Add(Me.LBL_DER_REPORTING)
        Me.GB_REPORTING.Controls.Add(Me.BT_CREER_REPORTING)
        Me.GB_REPORTING.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB_REPORTING.Location = New System.Drawing.Point(12, 387)
        Me.GB_REPORTING.Name = "GB_REPORTING"
        Me.GB_REPORTING.Size = New System.Drawing.Size(388, 118)
        Me.GB_REPORTING.TabIndex = 4
        Me.GB_REPORTING.TabStop = False
        Me.GB_REPORTING.Text = "Reporting"
        '
        'BT_OUVRIR_REPORTING
        '
        Me.BT_OUVRIR_REPORTING.Location = New System.Drawing.Point(199, 58)
        Me.BT_OUVRIR_REPORTING.Name = "BT_OUVRIR_REPORTING"
        Me.BT_OUVRIR_REPORTING.Size = New System.Drawing.Size(171, 39)
        Me.BT_OUVRIR_REPORTING.TabIndex = 2
        Me.BT_OUVRIR_REPORTING.Text = "Ouvrir le dossier reporting"
        Me.BT_OUVRIR_REPORTING.UseVisualStyleBackColor = True
        '
        'LBL_DER_REPORTING
        '
        Me.LBL_DER_REPORTING.AutoSize = True
        Me.LBL_DER_REPORTING.Location = New System.Drawing.Point(9, 28)
        Me.LBL_DER_REPORTING.Name = "LBL_DER_REPORTING"
        Me.LBL_DER_REPORTING.Size = New System.Drawing.Size(65, 14)
        Me.LBL_DER_REPORTING.TabIndex = 1
        Me.LBL_DER_REPORTING.Text = "Reporting :"
        '
        'BT_CREER_REPORTING
        '
        Me.BT_CREER_REPORTING.Location = New System.Drawing.Point(12, 58)
        Me.BT_CREER_REPORTING.Name = "BT_CREER_REPORTING"
        Me.BT_CREER_REPORTING.Size = New System.Drawing.Size(171, 39)
        Me.BT_CREER_REPORTING.TabIndex = 0
        Me.BT_CREER_REPORTING.Text = "Créer le reporting de la Semaine"
        Me.BT_CREER_REPORTING.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LBL_DER_MAJ)
        Me.GroupBox1.Controls.Add(Me.LBL_CHEM_SOURCE)
        Me.GroupBox1.Controls.Add(Me.TXT_CHEM_CSV)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 239)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(388, 91)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Information Fichier"
        '
        'LBL_DER_MAJ
        '
        Me.LBL_DER_MAJ.AutoSize = True
        Me.LBL_DER_MAJ.Location = New System.Drawing.Point(15, 91)
        Me.LBL_DER_MAJ.Name = "LBL_DER_MAJ"
        Me.LBL_DER_MAJ.Size = New System.Drawing.Size(0, 14)
        Me.LBL_DER_MAJ.TabIndex = 1
        '
        'LBL_CHEM_SOURCE
        '
        Me.LBL_CHEM_SOURCE.AutoSize = True
        Me.LBL_CHEM_SOURCE.Location = New System.Drawing.Point(15, 32)
        Me.LBL_CHEM_SOURCE.Name = "LBL_CHEM_SOURCE"
        Me.LBL_CHEM_SOURCE.Size = New System.Drawing.Size(129, 14)
        Me.LBL_CHEM_SOURCE.TabIndex = 0
        Me.LBL_CHEM_SOURCE.Text = "Chemin du fichier .csv :"
        '
        'LBL_SEMAINE
        '
        Me.LBL_SEMAINE.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBL_SEMAINE.AutoSize = True
        Me.LBL_SEMAINE.Location = New System.Drawing.Point(15, 77)
        Me.LBL_SEMAINE.Name = "LBL_SEMAINE"
        Me.LBL_SEMAINE.Size = New System.Drawing.Size(113, 14)
        Me.LBL_SEMAINE.TabIndex = 6
        Me.LBL_SEMAINE.Text = "Semaine en cours : "
        '
        'LBL_TRIGRAMME
        '
        Me.LBL_TRIGRAMME.AutoSize = True
        Me.LBL_TRIGRAMME.Location = New System.Drawing.Point(15, 52)
        Me.LBL_TRIGRAMME.Name = "LBL_TRIGRAMME"
        Me.LBL_TRIGRAMME.Size = New System.Drawing.Size(73, 14)
        Me.LBL_TRIGRAMME.TabIndex = 7
        Me.LBL_TRIGRAMME.Text = "Trigramme : "
        '
        'TXT_TRIGRAMME
        '
        Me.TXT_TRIGRAMME.Location = New System.Drawing.Point(94, 49)
        Me.TXT_TRIGRAMME.Name = "TXT_TRIGRAMME"
        Me.TXT_TRIGRAMME.Size = New System.Drawing.Size(49, 22)
        Me.TXT_TRIGRAMME.TabIndex = 8
        '
        'BT_SAVE
        '
        Me.BT_SAVE.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_SAVE.Location = New System.Drawing.Point(307, 345)
        Me.BT_SAVE.Name = "BT_SAVE"
        Me.BT_SAVE.Size = New System.Drawing.Size(75, 23)
        Me.BT_SAVE.TabIndex = 9
        Me.BT_SAVE.Text = "Enregister"
        Me.BT_SAVE.UseVisualStyleBackColor = True
        '
        'LBL_EX
        '
        Me.LBL_EX.AutoSize = True
        Me.LBL_EX.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_EX.Location = New System.Drawing.Point(60, 75)
        Me.LBL_EX.MaximumSize = New System.Drawing.Size(300, 0)
        Me.LBL_EX.Name = "LBL_EX"
        Me.LBL_EX.Size = New System.Drawing.Size(0, 18)
        Me.LBL_EX.TabIndex = 10
        Me.LBL_EX.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BT_SUPPR
        '
        Me.BT_SUPPR.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_SUPPR.Location = New System.Drawing.Point(226, 345)
        Me.BT_SUPPR.Name = "BT_SUPPR"
        Me.BT_SUPPR.Size = New System.Drawing.Size(75, 23)
        Me.BT_SUPPR.TabIndex = 11
        Me.BT_SUPPR.Text = "Supprimer"
        Me.BT_SUPPR.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LBL_TRIGRAMME)
        Me.GroupBox2.Controls.Add(Me.LBL_SEMAINE)
        Me.GroupBox2.Controls.Add(Me.TXT_TRIGRAMME)
        Me.GroupBox2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 121)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 112)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Initialisation"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("ISOCP", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(251, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 39)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "IXP Gestion"
        '
        'Form_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 516)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.BT_SUPPR)
        Me.Controls.Add(Me.LBL_EX)
        Me.Controls.Add(Me.BT_SAVE)
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
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BT_CHARGE_E_PUBLI As Button
    Friend WithEvents GB_CHARGE_DONNEE As GroupBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents TXT_CHEM_CSV As TextBox
    Friend WithEvents OpenFileDialog2 As OpenFileDialog
    Friend WithEvents GB_REPORTING As GroupBox
    Friend WithEvents LBL_DER_REPORTING As Label
    Friend WithEvents BT_CREER_REPORTING As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LBL_DER_MAJ As Label
    Friend WithEvents LBL_CHEM_SOURCE As Label
    Friend WithEvents LBL_SEMAINE As Label
    Friend WithEvents LBL_TRIGRAMME As Label
    Friend WithEvents TXT_TRIGRAMME As TextBox
    Friend WithEvents BT_SAVE As Button
    Friend WithEvents LBL_EX As Label
    Friend WithEvents BT_SUPPR As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents BT_OUVRIR_REPORTING As Button
    Friend WithEvents Label1 As Label
End Class
