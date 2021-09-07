Public Class DescriptionAudio
    Private onACliquerSurLeBouttonPlus As Boolean = False
    Private Sub Reduire_Click(sender As Object, e As EventArgs) Handles Reduire.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Fermer_Click(sender As Object, e As EventArgs) Handles Fermer.Click
        LBL_FichierSonore.Text = ""
        Close()
        InformationsPourLaBarreDeRecherche.Show()
    End Sub

    Private Sub aide_MouseHover(sender As Object, e As EventArgs) Handles aide.MouseHover
        aideSupport.Visible = True
    End Sub

    Private Sub aide_MouseLeave(sender As Object, e As EventArgs) Handles aide.MouseLeave
        aideSupport.Visible = False
    End Sub

    Private Sub LBL_FichierSonore_TextChanged(sender As Object, e As EventArgs) Handles LBL_FichierSonore.TextChanged
        If (LBL_FichierSonore.Text.Length > 0) Then
            image1.Image = WindowsApplication1.My.Resources.Resources.checked_50px
        Else
            image1.Image = WindowsApplication1.My.Resources.Resources.cancel_50px
        End If
    End Sub

    Private Sub Annuler_Click(sender As Object, e As EventArgs) Handles Annuler.Click
        InformationsPourLaBarreDeRecherche.nomElement.Text = ""
        InformationsPourLaBarreDeRecherche.categorieElement.Text = ""
        InformationsPourLaBarreDeRecherche.lesMotsCler.Text = ""
        LBL_FichierSonore.Text = ""
        Close()
        FenetreTousLesElementsEtBarreDeRecherche.Show()
    End Sub

    Private Sub continuer_Click(sender As Object, e As EventArgs) Handles continuer.Click
        If (LBL_FichierSonore.Text <> "" And Not (onACliquerSurLeBouttonPlus)) Then
            MsgBox("Cliquez sur le boutton + pour ajouter la musique !", MsgBoxStyle.Information, "INFORMATION")
        Else
            Close()
            DescriptionImage.Show()
        End If
    End Sub



    Private Sub ajouterFichierSonore_Click(sender As Object, e As EventArgs) Handles ajouterFichierSonore.Click

        If (LBL_FichierSonore.Text <> "") Then 'ICI ON ENREGISTRE LE CHEMIN SEULEMENT SI ON A ECRIT QUELQUE CHOSE DANS LE TEXTBOX.

            listeDePathDeMusiques.Add(LBL_FichierSonore.Text)
            onACliquerSurLeBouttonPlus = True
            Label1.Text = "La liste possede : " & listeDePathDeMusiques.LongCount & " élément."
            LBL_FichierSonore.Text = ""
        Else
            MsgBox("Il faut d'abord remplir le champ textuel ci dessous !", MsgBoxStyle.Information, "INFORMATION")
        End If
    End Sub

    Private Sub btn_OuvrirExplorateur_MouseHover(sender As Object, e As EventArgs) Handles btn_OuvrirExplorateur.MouseHover
        bulle_Explorateur.Visible = True
    End Sub

    Private Sub btn_OuvrirExplorateur_MouseLeave(sender As Object, e As EventArgs) Handles btn_OuvrirExplorateur.MouseLeave
        bulle_Explorateur.Visible = False
    End Sub
End Class