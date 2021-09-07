Public Class DescriptionImage
    Private onAcliquerSurLeBouttonPlus As Boolean = False

    Private Sub aide_MouseHover(sender As Object, e As EventArgs) Handles aide.MouseHover
        aideSupport.Visible = True
    End Sub

    Private Sub aide_MouseLeave(sender As Object, e As EventArgs) Handles aide.MouseLeave
        aideSupport.Visible = False
    End Sub

    Private Sub Lbl_Image_TextChanged(sender As Object, e As EventArgs) Handles LBL_Images.TextChanged
        If (LBL_Images.Text.Length > 0) Then
            image1.Image = WindowsApplication1.My.Resources.Resources.checked_50px
        Else
            image1.Image = WindowsApplication1.My.Resources.Resources.cancel_50px
        End If
    End Sub

    Private Sub annuler_Click(sender As Object, e As EventArgs) Handles annuler.Click
        InformationsPourLaBarreDeRecherche.nomElement.Text = ""
        InformationsPourLaBarreDeRecherche.categorieElement.Text = ""
        InformationsPourLaBarreDeRecherche.lesMotsCler.Text = ""
        DescriptionAudio.LBL_FichierSonore.Text = ""
        LBL_Images.Text = ""
        Close()
        FenetreTousLesElementsEtBarreDeRecherche.Show()
    End Sub

    Private Sub Fermer_Click(sender As Object, e As EventArgs) Handles Fermer.Click
        LBL_Images.Text = ""
        Close()
        DescriptionAudio.Show()
    End Sub

    Private Sub Reduire_Click(sender As Object, e As EventArgs) Handles Reduire.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub continuer_Click(sender As Object, e As EventArgs) Handles continuer.Click
        If (LBL_Images.Text <> "" And Not (onAcliquerSurLeBouttonPlus)) Then
            MsgBox("Cliquez sur le boutton + pour ajouter une image !", MsgBoxStyle.Information, "INFORMATION")
        Else
            Close()
            DescriptionTextuelle.Show()
        End If
    End Sub

    Private Sub ajouterDesImages_Click(sender As Object, e As EventArgs) Handles ajouterDesImages.Click
        If (LBL_Images.Text <> "") Then 'ICI ON ENREGISTRE LE CHEMIN SEULEMENT SI ON A ECRIT QUELQUE CHOSE DANS LE TEXTBOX.

            Try 'ICI ON VA VERIFIER SI L'IMAGE SE TROUVE BIEN DANS LE CHEMIN D'ACCES ECRIT.
                Dim imageAfficher As New Bitmap(LBL_Images.Text) '(mesImages)
                Decrire_ImageSonTexte.lesImages.Image = imageAfficher 'mesImages(0)
                listeDePathDesImages.Add(LBL_Images.Text)
                Label1.Text = "La liste possede : " & listeDePathDesImages.LongCount & " éléments."
                onAcliquerSurLeBouttonPlus = True
                LBL_Images.Text = ""
            Catch ex As Exception
                MsgBox("L'image n'a pas été ajoutée , Vérifiez bien l'orthographe ! ", MsgBoxStyle.Information, "")
                MsgBox("Rassurez vous que le chemin d'accès spécifié existe bien !", MsgBoxStyle.Information, "")
            End Try
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

    Private Sub btn_OuvrirExplorateur_Click(sender As Object, e As EventArgs) Handles btn_OuvrirExplorateur.Click
        ExplorerDesMedias(explorerLesImages, LBL_Images)
    End Sub
End Class