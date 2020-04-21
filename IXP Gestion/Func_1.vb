Imports System.IO
Imports xls = Microsoft.Office.Interop.Excel
Module Func_1
#Region "Constantes et déclarations public"
    'Constantes pour le fichier .ini
    Public Const CFichierINI As String = "IXP_Gestion.ini"
    Const CNbLigne As Integer = 4
    Public Const CleTrigramme As String = "Trigramme"
    Public Const CleChemExport As String = "CheminExport"
    'Public Const CleChemDossierDefaut As String = "CheminDossierParDefaut"

    Public Trigramme As String
    Public NumSemaine As String
    Public Const MessageEntree As String = "Indiquez votre Trigramme et choisisez un fichier d'export_ticketpublipostage"


    'Chemin de l'appli
    Public ChemAppli As String = Application.StartupPath
    'Chemin pour pour le dossier reporting par défaut dans mes documents
    Public MesDocReporting As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\IXP Reporting"


#End Region
    Public Function CreerReportingIsOK() As Boolean
        'Vérification des préalables à la création du reporting 
        If Form_Main.TXT_TRIGRAMME.Text = "" Or Form_Main.TXT_CHEM_CSV.Text = "" Then
            Return False
        Else
            Return True
        End If

    End Function

    Function CreeNomReporting() As String
        'Crée le nom du reporting de la semaine
        If CreerReportingIsOK() = True Then
            Dim Annee As Integer = Year(Now)
            Dim NomFichier As String = "Reporting" + Trigramme + "_" + CStr(Annee) + "_" + NumSemaine + ".xlsm"
            Return NomFichier
        Else
            Return ""
        End If
    End Function

    Sub VerifDossier(monDossier As String)
        'Vérifie si le dossier existe sinon on le créer
        If Directory.Exists(monDossier) = False Then
            My.Computer.FileSystem.CreateDirectory(monDossier)
        End If
    End Sub

    Public Sub CopieReporting()
        'Vérifie si le dossier existe sinon on le créer
        VerifDossier(MesDocReporting)
        'Trouve le chemin du fichier excel de base
        Dim CheminSource As String
        'CheminSource = Replace(ChemAppli, "\IXP Gestion\bin\Debug", "\Reporting IXP\")
        'MsgBox(CheminSource)
        'If Directory.Exists(CheminSource) = True Then
        'CheminSource = CheminSource & "reportingBaseLocal.xlsm"
        'Else
        CheminSource = ChemAppli & "\reportingBaseLocal.xlsm"
        'End If

        'Choisir un dossier de destination pour le reporting

        Dim CheminComplet As String = MesDocReporting & "\" & CreeNomReporting()
        Try
            FileIO.FileSystem.CopyFile(CheminSource, CheminComplet)
            Dim XlsApp As xls.Application = New xls.Application With {
                .Visible = True
            }
            XlsApp.Workbooks.Open(CheminComplet)
            Dim xlsSheets As xls.Worksheet
            xlsSheets = CType(XlsApp.ActiveWorkbook.Worksheets("Commande"), xls.Worksheet)
            With xlsSheets
                .Select()
                .Range("C15").Value = Trigramme
                .Range("C16").Value = SemaineEnCours()
                .Range("C30").Value = RecupereCleFichierIni(CleChemExport)
            End With

        Catch ex As IOException
            Dim rep = MsgBox("Le Fichier existe déjà. Souhaitez-vous enregister par dessus",
                                             MsgBoxStyle.YesNo,
                                             "Attention")
            If rep = MsgBoxResult.Yes Then
                FileIO.FileSystem.CopyFile(CheminSource, CheminComplet, overwrite:=True)
                Dim XlsApp As xls.Application = New xls.Application With {
                .Visible = True
            }
                XlsApp.Workbooks.Open(CheminComplet)

                Dim xlsSheets As xls.Worksheet
                xlsSheets = CType(XlsApp.ActiveWorkbook.Worksheets("Commande"), xls.Worksheet)
                With xlsSheets
                    .Select()
                    .Range("C15").Value = Trigramme
                    .Range("C16").Value = SemaineEnCours()
                    .Range("C30").Value = RecupereCleFichierIni(CleChemExport)
                End With

            Else
                Form_Main.BT_OUVRIR_REPORTING.Enabled = True
                Exit Sub
            End If

        Catch ex As Exception
            MsgBox("Erreur : " & Err.Number & vbCrLf & Err.Description & vbCrLf &
                   Err.HelpContext & vbCrLf & Err.HelpFile & vbCrLf & ex.Message)
        End Try


    End Sub



    'Function ChoisirDossier() As String
    ''On défini le dossier Mes Documents comme repertoir par défaut
    ''TODO : Se souvenir du dossier choisi comme dossier par défaut
    'With Form_Main.FolderBrowserDialog1
    '.Description = "Veuillez selectionner le dossier où vous souhaitez enregistrer le Reporting"
    '.SelectedPath = RecupereCleFichierIni(CleChemDossierDefaut)
    '
    'End With
    'If Form_Main.FolderBrowserDialog1.ShowDialog = DialogResult.OK Then
    '       ChoisirDossier = Form_Main.FolderBrowserDialog1.SelectedPath

    'Return ChoisirDossier
    'Else
    'Return MsgBox("Vous devez Choisir un Dossier")
    'End If
    'End Function
    Public Function SemaineEnCours() As String

        Dim semaine_en_cours As String
        'Détermine le numéro de la semaine en cours
        Dim num_semaine As Integer = DatePart(DateInterval.WeekOfYear, Now)
        'Si la semaine en cours est 53 on revient a la semaine 1
        'TODO : A prendre en compte si on créer des dossiers par Année
        If num_semaine = 53 Then num_semaine = 1
        'Ajoute un S et un zero si il n'y a qu'un chiffre
        If num_semaine > 9 Then
            semaine_en_cours = "S" & num_semaine
        Else
            semaine_en_cours = "S0" & num_semaine
        End If
        'Retourne le numéro de semaine sous la forme S01, S02, S12 etc.. 
        Return semaine_en_cours
    End Function

#Region "fichier ini"
    Public Sub SauveFichierIni()
        'Sauve les infos dans le fichier .ini
        File.WriteAllLines(CFichierINI, CreerFichierIni(Form_Main.TXT_TRIGRAMME.Text, Form_Main.TXT_CHEM_CSV.Text))
        With Form_Main
            .LBL_EX.Text = ""
            .BT_CREER_REPORTING.Enabled = True
        End With
    End Sub
    Function CreerFichierIni(ByVal Trigramme As String, ByVal ChemExport As String) As String()
        'Ajoute les données au fichier .ini sous la forme d'un tableau
        Dim FichierIni(CNbLigne) As String
        FichierIni(0) = ";Fichier de configuration de IXP Gestion"
        FichierIni(1) = "[Configuration]"
        FichierIni(2) = CleTrigramme & "=" & Trigramme
        FichierIni(3) = CleChemExport & "=" & ChemExport

        '
        'TODO : Lister les reporting passé (nom et chemin)
        '
        Return FichierIni
    End Function

    Function RecupereCleFichierIni(ByVal Cle As String) As String
        Try
            For Each Ligne As String In File.ReadAllLines(CFichierINI)
                'Découpe la ligne au niveau de « = » (s'il existe), 
                'Compare la première partie de la ligne (soit la clé)
                If Ligne.Split("=")(0) = Cle Then
                    'Recupère la seconde partie de la ligne (soit la valeur)
                    Return Ligne.Split("=")(1)
                End If
            Next
            'Sinon ne retourne rien
            Return ""
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Sub MajDonnee()
        'Récupere les données du fichier ini et les renseigne dans les textbox correspondant. 
        Try
            Form_Main.TXT_TRIGRAMME.Text = RecupereCleFichierIni(CleTrigramme)
            Trigramme = Form_Main.TXT_TRIGRAMME.Text
        Catch ex As FileNotFoundException
            'Si le fichier est absent (cath erreur) on demande de renseigner le trigramme
            Form_Main.LBL_EX.Text = MessageEntree
        End Try

        Try
            'idem avec le fichier import
            Dim chemFichier As String = RecupereCleFichierIni(CleChemExport)
            'on indique le nom du chemin dans le le textbox
            Form_Main.TXT_CHEM_CSV.Text = chemFichier
            'on trouve la date du fichier et on l'indique dans le label
            Dim DateModif As Date = File.GetLastWriteTime(chemFichier)
            Form_Main.LBL_DER_MAJ.Text = "Dernière modif du fichier : " & DateModif
            'TODO : Trouver l'ancienneté du fichier d'export
        Catch ex As FileNotFoundException
            'Si le fichier n'existe pas on vide le textbox
            Form_Main.TXT_CHEM_CSV.Text = ""
        End Try
        Form_Main.BT_OUVRIR_REPORTING.Enabled = True
        'Maj des donnée dans le reporting

    End Sub

    Sub test()

    End Sub
#End Region

End Module



