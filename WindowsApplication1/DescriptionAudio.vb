Imports System.IO
Public Class DescriptionAudio
    Private onACliquerSurLeBouttonPlus As Boolean = False
    Private Sub Reduire_Click(sender As Object, e As EventArgs) Handles Reduire.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Fermer_Click(sender As Object, e As EventArgs) Handles Fermer.Click
        LBL_FichierSonore.Text = ""
        If ajoutDeMusiqueAvantOuApres = "Avant enregistrement" Then 'SI LE FORMULAIRE DescriptionAudio A ETE OUVERT AVANT L'ENREGISTREMENT OU EN COURS D'ENREGISTREMENT.
            Close()
            InformationsPourLaBarreDeRecherche.Show()
        ElseIf ajoutDeMusiqueAvantOuApres = "Apres enregistrement" 'SI LE FORMULAIRE DescriptionAudio A ETE OUVERT APRES L'ENREGISTREMENT DE NOTRE ELEMENT, DONC ON A CLIQUER SUR AjouterImageOuMusique.
            ajoutDeMusiqueAvantOuApres = "Avant enregistrement"
            Close()
        End If
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
        If ajoutDeMusiqueAvantOuApres = "Avant enregistrement" Then
            Close()
            FenetreTousLesElementsEtBarreDeRecherche.Show()
        ElseIf ajoutDeMusiqueAvantOuApres = "Apres enregistrement" Then
            ajoutDeMusiqueAvantOuApres = "Avant enregistrement"
            Close()
        End If
    End Sub

    Private Sub continuer_Click(sender As Object, e As EventArgs) Handles continuer.Click
        If (LBL_FichierSonore.Text <> "" And Not (onACliquerSurLeBouttonPlus)) Then
            MsgBox("Cliquez sur le boutton + pour ajouter la musique !", MsgBoxStyle.Information, "INFORMATION")
        Else
            If ajoutDeMusiqueAvantOuApres = "Avant enregistrement" Then
                Close()
                DescriptionImage.Show()
            ElseIf ajoutDeMusiqueAvantOuApres = "Apres enregistrement" Then
                ajoutDeMusiqueAvantOuApres = "Avant enregistrement"
                For Each i In listeDePathDeMusiques
                    'ICI ON VEUT QUE LES IMAGES NOUVELLEMENT AJOUTER SOIT PRISE EN COMPTE 
                    'DANS LES IMAGES A AFFICHER SUR Decrire_SonImageTexte
                    'ELLES DOIVENT AUSSI ETRE AJOUTER DANS LA LISTE D'IMAGE DE L'ELEMENT QUI A ETE OUVERT , SUR LEQUEL ON A CLIQUER , OU QU'ON VIENT DE CREER.
                    maPlaylist.Add(i)
                Next
                Try
                    'ICI ON VEUT QUE LES IMAGES QUI ONT ETE AJOUTER SOIT APRES LE CLICK SUR UN ELEMENT ,SOIT IMEDIATEMENT APRES SON ENREGISTREMENT
                    'SOIENT AJOUTER DANS LA LISTE DES IMAGES DE NOTRE ELEMNENT POUR QU'A LA PROCHAINE OUVERTURE CES IMAGES PUISSENT TOUJOURS EXISTER.
                    Dim listeTemporaire As New List(Of informationARechercher)
                    Dim fluxTemporaire3 As FileStream = New FileStream("Informations_Enregistrées.xml", FileMode.Open)
                    listeTemporaire = serialiseur.Deserialize(fluxTemporaire3)
                    fluxTemporaire3.Close()

                    listeTemporaire(numeroDeLinformation).ListeDePathDesMusiques1 = maPlaylist
                    Dim fluxTemporaire2 As FileStream = New FileStream("Informations_Enregistrées.xml", FileMode.Create)
                    serialiseur.Serialize(fluxTemporaire2, listeTemporaire)
                    fluxTemporaire2.Close()

                    WindowsApplication1.Decrire_ImageSonTexte.lecteurMusique.URL = maPlaylist(0) 'INITIALISATION DU LECTEUR SI LA MUSIQUE EXISTE.
                    'MsgBox("les Modifications ont été enregistrées!", MsgBoxStyle.Information, "")
                    'MsgBox("Elles seront effectives à la prochaine ouverture du programme !", MsgBoxStyle.Information, "")
                Catch ex As Exception

                End Try
                Close()
            End If
        End If
    End Sub



    Private Sub ajouterFichierSonore_Click(sender As Object, e As EventArgs) Handles ajouterFichierSonore.Click

        If (LBL_FichierSonore.Text <> "") Then 'ICI ON ENREGISTRE LE CHEMIN SEULEMENT SI ON A ECRIT QUELQUE CHOSE DANS LE TEXTBOX.
            '#######La liste qui est sur le point d'être modifié interviendra dans deux cas de figures
            '#######1-Lors de l'enregistrement d'un élément , pendant l'ajout d'une musique.
            '#######2-Lors de l'ajout de nouvelle musique, dans le formulaire decrire_ImageSonTexte.
            listeDePathDeMusiques.Add(LBL_FichierSonore.Text)
            '#######
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

    Private Sub btn_OuvrirExplorateur_Click(sender As Object, e As EventArgs) Handles btn_OuvrirExplorateur.Click
        ExplorerDesMedias(explorateurDeSons, LBL_FichierSonore)
    End Sub
End Class