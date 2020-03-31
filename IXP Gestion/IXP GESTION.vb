
Public Class Form_Main
    Private Sub Form_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.LBL_SEMAINE.Text = "Semaine en Cours : " + semaineEnCours()
    End Sub
    Private Sub BT_CHARGE_E_PUBLI_Click(sender As Object, e As EventArgs) Handles BT_CHARGE_E_PUBLI.Click
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim NomFichier As String = OpenFileDialog1.FileName
            If NomFichier.Contains("export_ticketpublipostage") = False Then
                TextBox1.Text = "C'est pas le bon fichier"
                MsgBox("Il ne s'agit pas d'un ficher export_ticketpublipostage", vbExclamation, "Mauvais Fichier")
            End If
        End If
    End Sub

    Private Sub BT_CHARGE_E_TICKET_Click(sender As Object, e As EventArgs) Handles BT_CHARGE_E_TICKET.Click
        If OpenFileDialog2.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim NomFichier As String = OpenFileDialog2.FileName
            TextBox1.Text = NomFichier
            If NomFichier.Contains("export_ticket") = False Then
                TextBox1.Text = NomFichier
                MsgBox("Il ne s'agit pas d'un ficher export_ticket")
            End If
        End If
    End Sub

    Private Sub BT_CREER_REPORTING_Click(sender As Object, e As EventArgs) Handles BT_CREER_REPORTING.Click

    End Sub


End Class
