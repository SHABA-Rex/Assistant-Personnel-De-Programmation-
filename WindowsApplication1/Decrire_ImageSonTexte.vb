Imports System.Xml.Serialization
Imports System.IO
Public Class Decrire_ImageSonTexte
    Public seconde4 As Integer = 0
    Public infoBulleActive As String
    Dim indexImageAfficher = 0
    Dim imageAfficher As Bitmap
    Dim indexDeLaMusqique = 0

    Private Sub afficherLesInfosBulles_Tick(sender As Object, e As EventArgs) Handles afficherLesInfosBulles.Tick
        If (seconde4 = 3) Then
            Select Case infoBulleActive
                Case "Lbl_DescriptionImage"
                    Lbl_DescriptionImage.Visible = False
                    seconde4 = 0
                    afficherLesInfosBulles.Stop()
                Case "Lbl_DescriptionSonore"
                    Lbl_DescriptionSonore.Visible = False
                    seconde4 = 0
                    afficherLesInfosBulles.Stop()
                Case "Lbl_DescriptionTextuelle"
                    Lbl_DescriptionTextuelle.Visible = False
                    seconde4 = 0
                    afficherLesInfosBulles.Stop()
                Case "Lbl_Home"
                    Lbl_Home.Visible = False
                    seconde4 = 0
                    afficherLesInfosBulles.Stop()
                Case "Lbl_Aide"
                    Lbl_Aide.Visible = False
                    seconde4 = 0
                    afficherLesInfosBulles.Stop()
                Case "Lbl_Reduire"
                    Lbl_Reduire.Visible = False
                    seconde4 = 0
                    afficherLesInfosBulles.Stop()
                Case "Lbl_Fermer"
                    Lbl_Fermer.Visible = False
                    seconde4 = 0
                    afficherLesInfosBulles.Stop()
                Case "supprimerInfo"
                    supprimerInfo.Visible = False
                    seconde4 = 0
                    afficherLesInfosBulles.Stop()
                Case "lbl_AjouterImageOuSon"
                    lbl_AjouterImageOuSon.Visible = False
                    seconde4 = 0
                    afficherLesInfosBulles.Stop()
            End Select
        End If
        seconde4 += 1
    End Sub


    Private Sub descriptionImage_MouseHover(sender As Object, e As EventArgs) Handles descriptionImage.MouseHover
        Lbl_DescriptionImage.Visible = True
        infoBulleActive = Lbl_DescriptionImage.Name
        afficherLesInfosBulles.Start()
    End Sub

    Private Sub descriptionImage_MouseLeave(sender As Object, e As EventArgs) Handles descriptionImage.MouseLeave
        Lbl_DescriptionImage.Visible = False
        afficherLesInfosBulles.Stop()
        seconde4 = 0
    End Sub

    Private Sub descriptionSonore_MouseHover(sender As Object, e As EventArgs) Handles descriptionSonore.MouseHover
        infoBulleActive = Lbl_DescriptionSonore.Name
        Lbl_DescriptionSonore.Visible = True
        afficherLesInfosBulles.Start()
    End Sub

    Private Sub descriptionSonore_MouseLeave(sender As Object, e As EventArgs) Handles descriptionSonore.MouseLeave
        Lbl_DescriptionSonore.Visible = False
        afficherLesInfosBulles.Stop()
        seconde4 = 0
    End Sub

    Private Sub descriptionTextuelle_MouseHover(sender As Object, e As EventArgs) Handles descriptionTextuelle.MouseHover
        Lbl_DescriptionTextuelle.Visible = True
        infoBulleActive = Lbl_DescriptionTextuelle.Name
        afficherLesInfosBulles.Start()
    End Sub

    Private Sub descriptionTextuelle_MouseLeave(sender As Object, e As EventArgs) Handles descriptionTextuelle.MouseLeave
        Lbl_DescriptionTextuelle.Visible = False
        afficherLesInfosBulles.Stop()
        seconde4 = 0
    End Sub

    Private Sub home_MouseHover(sender As Object, e As EventArgs) Handles home.MouseHover
        Lbl_Home.Visible = True
        infoBulleActive = Lbl_Home.Name
        afficherLesInfosBulles.Start()
    End Sub

    Private Sub home_MouseLeave(sender As Object, e As EventArgs) Handles home.MouseLeave
        Lbl_Home.Visible = False
        afficherLesInfosBulles.Stop()
        seconde4 = 0
    End Sub

    Private Sub aide_MouseHover(sender As Object, e As EventArgs) Handles aide.MouseHover
        Lbl_Aide.Visible = True
        infoBulleActive = Lbl_Aide.Name
        afficherLesInfosBulles.Start()
    End Sub

    Private Sub aide_MouseLeave(sender As Object, e As EventArgs) Handles aide.MouseLeave
        Lbl_Aide.Visible = False
        afficherLesInfosBulles.Stop()
        seconde4 = 0
    End Sub

    Private Sub Reduire_MouseHover(sender As Object, e As EventArgs) Handles Reduire.MouseHover
        Lbl_Reduire.Visible = True
        infoBulleActive = Lbl_Reduire.Name
        afficherLesInfosBulles.Start()
    End Sub

    Private Sub Reduire_MouseLeave(sender As Object, e As EventArgs) Handles Reduire.MouseLeave
        Lbl_Reduire.Visible = False
        afficherLesInfosBulles.Stop()
        seconde4 = 0
    End Sub

    Private Sub Fermer_MouseHover(sender As Object, e As EventArgs) Handles Fermer.MouseHover
        Lbl_Fermer.Visible = True
        infoBulleActive = Lbl_Fermer.Name
        afficherLesInfosBulles.Start()
    End Sub

    Private Sub Fermer_MouseLeave(sender As Object, e As EventArgs) Handles Fermer.MouseLeave
        Lbl_Fermer.Visible = False
        afficherLesInfosBulles.Stop()
        seconde4 = 0
    End Sub

    Private Sub Reduire_Click(sender As Object, e As EventArgs) Handles Reduire.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Fermer_Click(sender As Object, e As EventArgs) Handles Fermer.Click
        FenetreTousLesElementsEtBarreDeRecherche.Show()
        Close()
    End Sub

    Private Sub home_Click(sender As Object, e As EventArgs) Handles home.Click
        panneauDeSuppression.Visible = False
        msg_ImageInexistante1.Visible = False
        msg_ImageInexistante2.Visible = False
        lecteurMusique.close()
        Close()
        FenetreTousLesElementsEtBarreDeRecherche.Show()
        FenetreTousLesElementsEtBarreDeRecherche.rendreTousElementsVisible(False)
        FenetreTousLesElementsEtBarreDeRecherche.deplacerCuseur(FenetreTousLesElementsEtBarreDeRecherche.TousLesElementsEtBarreDeRecherche)
    End Sub

    Private Sub descriptionTextuelle_Click(sender As Object, e As EventArgs) Handles descriptionTextuelle.Click
        panneauDeSuppression.Visible = False
        msg_ImageInexistante1.Visible = False
        msg_ImageInexistante2.Visible = False
        ajouterImageOuMusique.Visible = False
        optionSelectioner = descriptionTextuelle.Name
        rendreVisibleTousLesElementsDesDescriptions(False)

        Dim fontDuTexte3 As New Font(policeDuTexte, CInt(tailleDuTexte))
        ChampTextuel.Font = fontDuTexte3

        Select Case couleurDuFond
            Case "White"
                ChampTextuel.BaseColor = Color.White
            Case "Black"
                ChampTextuel.BaseColor = Color.Black
            Case "Green"
                ChampTextuel.BaseColor = Color.Green
            Case "Yellow"
                ChampTextuel.BaseColor = Color.Yellow
            Case "Red"
                ChampTextuel.BaseColor = Color.Red
            Case "Indigo"
                ChampTextuel.BaseColor = Color.Indigo
        End Select

        Select Case couleurDuTexte
            Case "White"
                ChampTextuel.ForeColor = Color.White
            Case "Black"
                ChampTextuel.ForeColor = Color.Black
            Case "Green"
                ChampTextuel.ForeColor = Color.Green
            Case "Yellow"
                ChampTextuel.ForeColor = Color.Yellow
            Case "Red"
                ChampTextuel.ForeColor = Color.Red
            Case "Violet"
                ChampTextuel.ForeColor = Color.Violet
            Case "Indigo"
                ChampTextuel.ForeColor = Color.Indigo
        End Select

        lecteurMusique.close()
    End Sub

    Private Sub descriptionImage_Click(sender As Object, e As EventArgs) Handles descriptionImage.Click
        panneauDeSuppression.Visible = False
        ajouterImageOuMusique.Visible = True
        ouEstOn = "On est sur image"
        lbl_AjouterImageOuSon.Text = "Ajouter une image."
        optionSelectioner = descriptionImage.Name
        rendreVisibleTousLesElementsDesDescriptions(True)
        lecteurMusique.close()
    End Sub

    Private Sub modifierSauvegarder_Click(sender As Object, e As EventArgs) Handles modifierSauvegarder.Click

        Try
            Dim listeTemporaire As New List(Of informationARechercher)
            Dim fluxTemporaire3 As FileStream = New FileStream("Informations_Enregistrées.xml", FileMode.Open)
            listeTemporaire = serialiseur.Deserialize(fluxTemporaire3)
            fluxTemporaire3.Close()

            listeTemporaire(numeroDeLinformation).DescriptionTextuelle1 = transformerDescriptionTextuelleEnCodeAscii(ChampTextuel.Text)
            Dim fluxTemporaire2 As FileStream = New FileStream("Informations_Enregistrées.xml", FileMode.Create)
            serialiseur.Serialize(fluxTemporaire2, listeTemporaire)
            fluxTemporaire2.Close()

            MsgBox("les Modifications ont été enregistrées!", MsgBoxStyle.Information, "")
            MsgBox("Elles seront effectives à la prochaine ouverture du programme !", MsgBoxStyle.Information, "")
            modifierSauvegarder.Visible = False
        Catch ex As Exception

        End Try
        'If (modifierSauvegarder.Text = "Modifier votre description textuelle") Then
        '    modifierSauvegarder.Text = "Sauvegarder vos modifications"
        '    ChampTextuel.Enabled = True
        'ElseIf (modifierSauvegarder.Text = "Sauvegarder vos modifications") Then
        '    modifierSauvegarder.Text = "Modifier votre description textuelle"
        '    ChampTextuel.Enabled = False
        'End If
    End Sub

    Private Sub descriptionSonore_Click(sender As Object, e As EventArgs) Handles descriptionSonore.Click
        panneauDeSuppression.Visible = False
        msg_ImageInexistante1.Visible = False
        msg_ImageInexistante2.Visible = False
        ajouterImageOuMusique.Visible = True
        ouEstOn = "On est sur musique"
        lbl_AjouterImageOuSon.Text = "Ajouter du son."
        optionSelectioner = descriptionSonore.Name
        rendreVisibleTousLesElementsDesDescriptions()
    End Sub

    Private Sub ChampTextuel_TextChanged(sender As Object, e As EventArgs) Handles ChampTextuel.TextChanged
        If (descriptionTextuelleDeLelement <> ChampTextuel.Text) Then
            modifierSauvegarder.Visible = True
        Else
            modifierSauvegarder.Visible = False
        End If
    End Sub

    Private Sub Decrire_ImageSonTexte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ouEstOn = "On est sur image"
        Width = 784
        Height = 1382
        ChampTextuel.Text = descriptionTextuelleDeLelement
        indexImageAfficher = 0
        indexDeLaMusqique = 0

        Try
            Dim imageAfficher As New Bitmap(mesImages(indexImageAfficher))
            lesImages.Image = imageAfficher
            lesImages.ImageSize = imageAfficher.Size
        Catch ex As Exception

        End Try

        Try
            lecteurMusique.URL = maPlaylist(indexDeLaMusqique)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub previousImage_Click(sender As Object, e As EventArgs) Handles previousImage.Click
        If (mesImages.LongCount <> 0) Then
            indexImageAfficher -= 1
            If (indexImageAfficher < 0) Then 'ICI LES IMAGES EXISTENT, DONC PAS BESOINS D'AFFICHER NOS MESSAGES.
                indexImageAfficher = mesImages.LongCount - 1
                msg_ImageInexistante1.Visible = False
                msg_ImageInexistante2.Visible = False
            End If

            Try
                imageAfficher = New Bitmap(mesImages(indexImageAfficher)) 'Dim imageAfficher As New Bitmap(mesImages(indexImageAfficher))
                lesImages.Image = imageAfficher
                lesImages.ImageSize = imageAfficher.Size
            Catch ex As Exception 'ICI LES IMAGES EXISTENT MAIS IL Y'A UN PROBLEME DESSUS , DONC ON VA AFFICHER NOS MESSAGES.
                msg_ImageInexistante1.Visible = True
                msg_ImageInexistante2.Visible = True
            End Try
        Else 'ICI LES IMAGES N'EXISTENT PAS OU ON RENCONTRENT DES PROBLEMES A LEUR OUVERTURE ; DONC ON VA AFFICHER NOS MESSAGES 
            msg_ImageInexistante1.Visible = True
            msg_ImageInexistante2.Visible = True
        End If
    End Sub

    Private Sub nextImage_Click(sender As Object, e As EventArgs) Handles nextImage.Click
        If (mesImages.LongCount <> 0) Then
            indexImageAfficher += 1
            If (indexImageAfficher = mesImages.LongCount) Then
                indexImageAfficher = 0
                msg_ImageInexistante1.Visible = False
                msg_ImageInexistante2.Visible = False
            End If

            Try
                imageAfficher = New Bitmap(mesImages(indexImageAfficher)) 'Dim imageAfficher As New Bitmap(mesImages(indexImageAfficher))
                lesImages.Image = imageAfficher
                lesImages.ImageSize = imageAfficher.Size
            Catch ex As Exception
                msg_ImageInexistante1.Visible = True
                msg_ImageInexistante2.Visible = True
            End Try
        Else
            msg_ImageInexistante1.Visible = True
            msg_ImageInexistante2.Visible = True
        End If
    End Sub

    Private Sub nextMusique_Click(sender As Object, e As EventArgs) Handles nextMusique.Click
        If (maPlaylist.LongCount <> 0) Then
            indexDeLaMusqique += 1
            If (indexDeLaMusqique = maPlaylist.LongCount) Then
                indexDeLaMusqique = 0
            End If

            Try
                lecteurMusique.URL = maPlaylist(indexDeLaMusqique)
            Catch ex As Exception

            End Try

        End If
    End Sub

    Private Sub previousMusique_Click(sender As Object, e As EventArgs) Handles previousMusique.Click
        If (maPlaylist.LongCount <> 0) Then
            indexDeLaMusqique -= 1
            If (indexDeLaMusqique < 0) Then
                indexDeLaMusqique = maPlaylist.LongCount - 1
            End If

            Try
                lecteurMusique.URL = maPlaylist(indexDeLaMusqique)
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub corbeille_MouseHover(sender As Object, e As EventArgs) Handles corbeille.MouseHover
        supprimerInfo.Visible = True
        infoBulleActive = supprimerInfo.Name
        afficherLesInfosBulles.Start()
    End Sub

    Private Sub corbeille_MouseLeave(sender As Object, e As EventArgs) Handles corbeille.MouseLeave
        supprimerInfo.Visible = False
        afficherLesInfosBulles.Stop()
        seconde4 = 0
    End Sub

    Private Sub corbeille_Click(sender As Object, e As EventArgs) Handles corbeille.Click
        mesImages.Clear()
        maPlaylist.Clear()
        If (panneauDeSuppression.Visible = False) Then
            panneauDeSuppression.Visible = True
        ElseIf (panneauDeSuppression.Visible = True)
            panneauDeSuppression.Visible = False
        End If
    End Sub

    Private Sub Btn_Oui_Click(sender As Object, e As EventArgs) Handles Btn_Oui.Click
        panneauDeSuppression.Visible = False
        listeDinformations3 = supprimerUneInformationDeNosFichiers(numeroDeLinformation) 'SUPPRESSION ET RESTOCKAGE DES ELEMENTS, EN CAS D'ERREUR C'EST LA MEME LISTE DE DEPART QUI SERA STOCKER , DONC PAS DE PROBLEME.

        Close()
        FenetreTousLesElementsEtBarreDeRecherche.Show()
        FenetreTousLesElementsEtBarreDeRecherche.rendreTousElementsVisible(False)
        FenetreTousLesElementsEtBarreDeRecherche.deplacerCuseur(FenetreTousLesElementsEtBarreDeRecherche.TousLesElementsEtBarreDeRecherche)


        jetonAttibuer = 1
        indexDansLaListeDeResultat = 0
        onContinueLaffichageDesResultats = True
        FenetreTousLesElementsEtBarreDeRecherche.motClerEtResultat.Text = "Mot clé : Tous les éléments. | " & lancerLaRechercheDunElement("Tous les éléments.") & IIf(listeDeResultatsDeLaRecherche.LongCount > 1, " résultats trouvés !", " résultat trouvé !")
        afficherLesResultatsEnDescendantDansLaListeDeTousLesElements(listeDeResultatsDeLaRecherche)

    End Sub

    Private Sub Btn_Non_Click(sender As Object, e As EventArgs) Handles Btn_Non.Click
        panneauDeSuppression.Visible = False
    End Sub

    Private Sub ajouterImageOuMusique_MouseHover(sender As Object, e As EventArgs) Handles ajouterImageOuMusique.MouseHover
        lbl_AjouterImageOuSon.Visible = True
        infoBulleActive = lbl_AjouterImageOuSon.Name
        afficherLesInfosBulles.Start()
    End Sub

    Private Sub ajouterImageOuMusique_MouseLeave(sender As Object, e As EventArgs) Handles ajouterImageOuMusique.MouseLeave
        lbl_AjouterImageOuSon.Visible = False
        afficherLesInfosBulles.Stop()
        seconde4 = 0
    End Sub

    Private Sub ajouterImageOuMusique_Click(sender As Object, e As EventArgs) Handles ajouterImageOuMusique.Click
        If ouEstOn = "On est sur image" Then
            ajoutDimageAvantOuApres = "Apres enregistrement"
            listeDePathDesImages.Clear()
            WindowsApplication1.DescriptionImage.Show()
        ElseIf ouEstOn = "On est sur musique" Then
            ajoutDeMusiqueAvantOuApres = "Apres enregistrement"
            listeDePathDeMusiques.Clear()
            DescriptionAudio.Show()
        End If
    End Sub
End Class