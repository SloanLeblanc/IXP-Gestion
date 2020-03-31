Module Func_1
    Public Function CopieReporting()

    End Function

    Public Function semaineEnCours() As String

        Dim semaine_en_cours As String
        Dim num_semaine As Integer = DatePart(DateInterval.WeekOfYear, Now)

        If num_semaine = 53 Then num_semaine = 1
        If num_semaine > 9 Then
            semaine_en_cours = "S" & num_semaine
        Else
            semaine_en_cours = "S0" & num_semaine
        End If
        Return semaine_en_cours
    End Function

End Module
