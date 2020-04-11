Imports System.IO

Public Class Form_Main

    Private Sub Form_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Récupère le numéro de la semaine en cours. 
        NumSemaine = SemaineEnCours()
        LBL_SEMAINE.Text = "Semaine en Cours : " + NumSemaine
        MajDonnee()
        LBL_DER_REPORTING.Text = CreeNomReporting()
        If CreerReportingIsOK() = False Then
            BT_CREER_REPORTING.Enabled = False
            BT_OUVRIR_REPORTING.Enabled = False
        Else
            BT_CREER_REPORTING.Enabled = True

        End If

    End Sub
    Private Sub BT_CHARGE_E_PUBLI_Click(sender As Object, e As EventArgs) Handles BT_CHARGE_E_PUBLI.Click
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim NomFichier As String = OpenFileDialog1.FileName
            TXT_CHEM_CSV.Text = NomFichier
            If NomFichier.Contains("export_ticketpublipostage") = False Then
                TXT_CHEM_CSV.Text = "C'est pas le bon fichier"
                MsgBox("Il ne s'agit pas d'un ficher export_ticketpublipostage", vbExclamation, "Mauvais Fichier")
            End If


        End If
    End Sub

    Private Sub BT_CREER_REPORTING_Click(sender As Object, e As EventArgs) Handles BT_CREER_REPORTING.Click

        CopieReporting()
    End Sub


    Private Sub BT_SAVE_Click(sender As Object, e As EventArgs) Handles BT_SAVE.Click
        If TXT_TRIGRAMME.Text = "" Then
            MsgBox("Vous devez entrer votre trigramme !", vbExclamation, "Trigramme manquant")
            Exit Sub
        End If
        If TXT_CHEM_CSV.Text = "Pas de donnée" Or TXT_CHEM_CSV.Text = "" Then
            MsgBox("Vous devez indiquer le chemin d'un fichier d'export_ticketpublipostage.csv", vbExclamation, "Chemin manquant")
            Exit Sub
        End If
        Trigramme = TXT_TRIGRAMME.Text
        SauveFichierIni()
        MsgBox("Les données ont bien été enregistrées.", vbInformation, "Enregistrement")
        MajDonnee()
        LBL_DER_REPORTING.Text = CreeNomReporting()
    End Sub

    Private Sub BT_SUPPR_Click(sender As Object, e As EventArgs) Handles BT_SUPPR.Click
        File.Delete(CFichierINI)
        TXT_TRIGRAMME.Text = Nothing
        TXT_CHEM_CSV.Text = Nothing
        LBL_DER_MAJ.Text = Nothing
        BT_CREER_REPORTING.Enabled = False
        BT_OUVRIR_REPORTING.Enabled = False
        LBL_EX.Text = MessageEntree
    End Sub

    Private Sub BT_OUVRIR_REPORTING_Click(sender As Object, e As EventArgs) Handles BT_OUVRIR_REPORTING.Click
        Process.Start("explorer.exe", MesDocReporting)
    End Sub
End Class
