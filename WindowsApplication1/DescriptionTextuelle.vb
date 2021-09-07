Imports Guna.UI.Lib
Imports System.Xml.Serialization
Imports System.IO
Public Class DescriptionTextuelle
    Public pos, pos1, pos2, pos3, pos4, posPolice, posCouleurTexte, posCouleurFond, posTailleTexte As Point
    Dim couleur As Color
    Public etatPanneauReglage As String = "Fermer", etatPolice = "Monter", etatCouleurTexte = "Monter", etatCouleurFond = "Monter", etatTailleTexte = "Monter"

    Private Sub TailleDeTexte_Click(sender As Object, e As EventArgs) Handles TailleDeTexte.Click

        If (etatTailleTexte = "Monter") Then
            pos4.Y += 26
            comboBoxTailleTexte.Location = pos4
            etatTailleTexte = "Descendu"
        ElseIf (etatTailleTexte = "Descendu")
            pos4.Y -= 26
            comboBoxTailleTexte.Location = pos4
            etatTailleTexte = "Monter"
        End If
    End Sub

    Private Sub couleurDeFond_Click(sender As Object, e As EventArgs) Handles couleurDeFond.Click
        If (etatCouleurFond = "Monter") Then
            pos3.Y += 26
            posTailleTexte.Y += 26

            comboBoxCouleurFond.Location = pos3
            TailleDeTexte.Location = posTailleTexte

            pos4.Y += 26
            comboBoxTailleTexte.Location = pos4
            etatCouleurFond = "Descendu"
        ElseIf (etatCouleurFond = "Descendu")
            pos3.Y -= 26
            posTailleTexte.Y -= 26

            comboBoxCouleurFond.Location = pos3
            TailleDeTexte.Location = posTailleTexte

            pos4.Y -= 26
            comboBoxTailleTexte.Location = pos4
            etatCouleurFond = "Monter"
        End If
    End Sub

    Private Sub comboBoxPolice_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBoxPolice.SelectedIndexChanged
        Try
            policeDuTexte = comboBoxPolice.SelectedItem.ToString
            Dim fontDuTexte As New Font(policeDuTexte, CInt(tailleDuTexte))
            ChampTextuel.Font = fontDuTexte
        Catch ex As Exception

        End Try
    End Sub

    Private Sub comboBoxCouleurTexte_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBoxCouleurTexte.SelectedIndexChanged

        Try
            Select Case comboBoxCouleurTexte.SelectedItem.ToString
                Case "White"
                    ChampTextuel.ForeColor = Color.White
                    couleurDuTexte = "White"
                Case "Black"
                    ChampTextuel.ForeColor = Color.Black
                    couleurDuTexte = "Black"
                Case "Green"
                    ChampTextuel.ForeColor = Color.Green
                    couleurDuTexte = "Green"
                Case "Yellow"
                    ChampTextuel.ForeColor = Color.Yellow
                    couleurDuTexte = "Yellow"
                Case "Red"
                    ChampTextuel.ForeColor = Color.Red
                    couleurDuTexte = "Red"
                Case "Violet"
                    ChampTextuel.ForeColor = Color.Violet
                    couleurDuTexte = "Violet"
                Case "Indigo"
                    ChampTextuel.ForeColor = Color.Indigo
                    couleurDuTexte = "Indigo"
            End Select

        Catch ex As Exception

        End Try
    End Sub

    Private Sub comboBoxCouleurFond_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBoxCouleurFond.SelectedIndexChanged
        Try
            Select Case comboBoxCouleurFond.SelectedItem.ToString
                Case "White"
                    ChampTextuel.BaseColor = Color.White
                    couleurDuFond = "White"
                Case "Black"
                    ChampTextuel.BaseColor = Color.Black
                    couleurDuFond = "Black"
                Case "Green"
                    ChampTextuel.BaseColor = Color.Green
                    couleurDuFond = "Green"
                Case "Yellow"
                    ChampTextuel.BaseColor = Color.Yellow
                    couleurDuFond = "Yellow"
                Case "Red"
                    ChampTextuel.BaseColor = Color.Red
                    couleurDuFond = "Red"
                Case "Indigo"
                    ChampTextuel.BaseColor = Color.Indigo
                    couleurDuFond = "Indigo"
            End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Sub comboBoxTailleTexte_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBoxTailleTexte.SelectedIndexChanged
        tailleDuTexte = comboBoxTailleTexte.SelectedItem.ToString
        Try
            Dim fontDuTexte2 As New Font(policeDuTexte, CInt(tailleDuTexte))
            ChampTextuel.Font = fontDuTexte2
        Catch ex As Exception

        End Try
    End Sub

    Private Sub couleurTexte_Click(sender As Object, e As EventArgs) Handles couleurTexte.Click
        If (etatCouleurTexte = "Monter") Then
            pos2.Y += 26
            posCouleurFond.Y += 26
            posTailleTexte.Y += 26

            comboBoxCouleurTexte.Location = pos2
            couleurDeFond.Location = posCouleurFond
            TailleDeTexte.Location = posTailleTexte

            pos3.Y += 26
            pos4.Y += 26
            comboBoxCouleurFond.Location = pos3
            comboBoxTailleTexte.Location = pos4
            etatCouleurTexte = "Descendu"
        ElseIf (etatCouleurTexte = "Descendu")
            pos2.Y -= 26
            posCouleurFond.Y -= 26
            posTailleTexte.Y -= 26

            comboBoxCouleurTexte.Location = pos2
            couleurDeFond.Location = posCouleurFond
            TailleDeTexte.Location = posTailleTexte

            pos3.Y -= 26
            pos4.Y -= 26
            comboBoxCouleurFond.Location = pos3
            comboBoxTailleTexte.Location = pos4

            etatCouleurTexte = "Monter"

        End If
    End Sub

    Private Sub DescriptionTextuelle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pos.X = -298
        pos.Y = -2
        pos1.X = comboBoxPolice.Location.X
        pos1.Y = comboBoxPolice.Location.Y
        pos2.X = comboBoxCouleurTexte.Location.X
        pos2.Y = comboBoxCouleurTexte.Location.Y
        pos3.X = comboBoxCouleurFond.Location.X
        pos3.Y = comboBoxCouleurFond.Location.Y
        pos4.X = comboBoxTailleTexte.Location.X
        pos4.Y = comboBoxTailleTexte.Location.Y
        posPolice.X = policeTexte.Location.X
        posPolice.Y = policeTexte.Location.Y
        posCouleurTexte.X = couleurTexte.Location.X
        posCouleurTexte.Y = couleurTexte.Location.Y
        posCouleurFond.X = couleurDeFond.Location.X
        posCouleurFond.Y = couleurDeFond.Location.Y
        posTailleTexte.X = TailleDeTexte.Location.X
        posTailleTexte.Y = TailleDeTexte.Location.Y

        GraphicsHelper.DrawLineShadow(panneauDesReglages, Color.Black, 70, 20, Guna.UI.WinForms.VerHorAlign.VerticalRight)
        GraphicsHelper.DrawLineShadow(policeTexte, Color.Black, 70, 20, Guna.UI.WinForms.VerHorAlign.VerticalRight)
        GraphicsHelper.DrawLineShadow(couleurTexte, Color.Black, 70, 20, Guna.UI.WinForms.VerHorAlign.VerticalRight)
        GraphicsHelper.DrawLineShadow(couleurDeFond, Color.Black, 70, 20, Guna.UI.WinForms.VerHorAlign.VerticalRight)
        GraphicsHelper.DrawLineShadow(TailleDeTexte, Color.Black, 70, 20, Guna.UI.WinForms.VerHorAlign.VerticalRight)
        GraphicsHelper.DrawLineShadow(reglage, Color.Black, 70, 20, Guna.UI.WinForms.VerHorAlign.VerticalRight)

        panneauDesReglages.Location = pos


    End Sub

    Private Sub TimerDeplacerPanneauReglage_Tick(sender As Object, e As EventArgs) Handles TimerDeplacerPanneauReglage.Tick
        If (panneauDesReglages.Location.X < -2) Then
            pos.X += 2
            panneauDesReglages.Location = pos
        Else
            TimerDeplacerPanneauReglage.Stop()
            etatPanneauReglage = "Ouvert"
        End If


    End Sub

    Private Sub bouttonParametre_Click(sender As Object, e As EventArgs) Handles bouttonParametre.Click
        If (etatPanneauReglage = "Fermer") Then
            panneauDesReglages.Visible = True
            TimerDeplacerPanneauReglage.Start()
        ElseIf (etatPanneauReglage = "Ouvert") Then
            pos.X = -298
            pos.Y = -2
            panneauDesReglages.Location = pos
            panneauDesReglages.Visible = False
            etatPanneauReglage = "Fermer"
        End If
    End Sub

    Private Sub reduire_Click(sender As Object, e As EventArgs) Handles reduire.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub aide_MouseHover(sender As Object, e As EventArgs) Handles aide.MouseHover
        aideSupport.Visible = True
    End Sub

    Private Sub aide_MouseLeave(sender As Object, e As EventArgs) Handles aide.MouseLeave
        aideSupport.Visible = False
    End Sub

    Private Sub Fermer_Click(sender As Object, e As EventArgs) Handles Fermer.Click
        ChampTextuel.Text = ""
        Close()
        DescriptionImage.Show()
    End Sub

    Private Sub Annuler_Click(sender As Object, e As EventArgs) Handles Annuler.Click
        InformationsPourLaBarreDeRecherche.nomElement.Text = ""
        InformationsPourLaBarreDeRecherche.categorieElement.Text = ""
        InformationsPourLaBarreDeRecherche.lesMotsCler.Text = ""
        DescriptionAudio.LBL_FichierSonore.Text = ""
        DescriptionImage.LBL_Images.Text = ""
        ChampTextuel.Text = ""
        Close()
        FenetreTousLesElementsEtBarreDeRecherche.Show()
    End Sub

    Private Sub Terminer_Click(sender As Object, e As EventArgs) Handles Terminer.Click
        Dim informationAEnregistrer As New informationARechercher()
        Dim numeroDeLelementSuivant As Integer

        If (listeDinformations3.LongCount <> 0) Then
            numeroDeLelementSuivant = listeDinformations3(listeDinformations3.LongCount - 1).Numero1 + 1 'Numero du dernier élément plus 1
        ElseIf (listeDinformations3.LongCount = 0)
            numeroDeLelementSuivant = 0
        End If


        Dim unFlux As FileStream = New FileStream("miseEnFormeDuTexte.xml", FileMode.Open)
        Try
            Dim parametresTexteAEnregistrer As New parametresDuTexte(policeDuTexte, couleurDuTexte, couleurDuFond, tailleDuTexte)
            serialiseurDesParametresTexte.Serialize(unFlux, parametresTexteAEnregistrer)
            unFlux.Close()
        Catch ex As Exception
            unFlux.Close()
        End Try

        If (ChampTextuel.Text = "") Then
            MsgBox("REMPLISSEZ LE CHAMP TEXTUEL !", MsgBoxStyle.Information, "INFORMATION")
        Else
            descriptionTextuelleDeLelement = ChampTextuel.Text


            '##################
            'ICI IL EST QUESTION D'ENREGISTRER LA VERSION DU FICHIER XML Informations_Enregistrées.xml QUI N'A PAS D'ERREURS; QUI MARCHE BIEN
            'DONC ON ENREGISTRE LE FICHIER Informations_Enregistrées.xml AVANT QU'IL NE SOIT MODIFIER 
            'POUR QU'EN CAS D'ERREUR DANS LA NOUVELLE INSERTION QUI VA ETRE FAITE, QU'ON AIT UNE VERSION DE Informations_Enregistrées.xml 
            'QUI FONCTIONNE CORRECTEMENT SANS ERREURS.

            Try
                fluxDeDeSerialisation = New FileStream("Informations_Enregistrées.xml", FileMode.OpenOrCreate)
                listeDeSauvegarde = serialiseur.Deserialize(fluxDeDeSerialisation)
                fluxDeDeSerialisation.Close()
            Catch ex As Exception

            End Try

            If listeDeSauvegarde.LongCount > 0 Then
                'SI LE FICHIER Informations_Enregistrées.xml POSSEDE DES INFORMATIONS ALORS ON POURRA  ENREGISTRER CES INFORMATIONS AVANT 
                'L'AJOUT DE NOUVELLE INFORMATIONS . SINON IL EST VIDE ET ON NE FERA RIEN.
                fluxDeSerialisation = New FileStream("Sauvegarde_d'infos_nonCorrompues.xml", FileMode.Create)
                serialiseur.Serialize(fluxDeSerialisation, listeDeSauvegarde)
                fluxDeSerialisation.Close()
            End If

            '##################

            fluxDeDeSerialisation.Close()


            'ON VA METTRE TOUT CECI A LA FIN DE L'ENREGISTREMENT DE NOTRE ELEMENT.####
            fluxDeSerialisation = New FileStream("Informations_Enregistrées.xml", FileMode.OpenOrCreate)
            'tableauMotCles = stockerLesMotsCles(lesMotsCler.Text)
            informationAEnregistrer.Numero1 = numeroDeLelementSuivant 'listeDinformations3.LongCount
            numeroDeLinformation = informationAEnregistrer.Numero1
            informationAEnregistrer.Signature1 = nomDeLelement
            informationAEnregistrer.Categorie1 = categorieDeLelement
            informationAEnregistrer.DateDeCreation1 = Date.Today
            informationAEnregistrer.TableauMotCles1 = tableauMotCles
            informationAEnregistrer.DescriptionTextuelle1 = transformerDescriptionTextuelleEnCodeAscii(descriptionTextuelleDeLelement)
            informationAEnregistrer.ListeDePathDesImages1 = listeDePathDesImages
            informationAEnregistrer.ListeDePathDesMusiques1 = listeDePathDeMusiques
            listeDinformations3.Add(informationAEnregistrer)
            serialiseur.Serialize(fluxDeSerialisation, listeDinformations3)
            fluxDeSerialisation.Close()
            '#######TOUT CECI EN HAUT !

            copierListe1_Dans_Liste2(listeDePathDeMusiques, maPlaylist)
            copierListe1_Dans_Liste2(listeDePathDesImages, mesImages)

            listeDePathDeMusiques = New List(Of String)
            listeDePathDesImages = New List(Of String)


            '#######ICI C'EST POUR METTRE A JOUR NOTRE LISTE DE RESULTATS(AFFICHAGE) SANS QU'ON N'AIT TAPEZ RECHERCHER
            'PAS DU TOUT OBLIGATOIRE SI CA POSE PROBLEME ENLEVE CETTE PARTIE , C'EST JUSTE POUR ETRE UN PEU COHERENT DANS L'AFFICHAGE
            jetonAttibuer = 1
            indexDansLaListeDeResultat = 0
            onContinueLaffichageDesResultats = True
            FenetreTousLesElementsEtBarreDeRecherche.motClerEtResultat.Text = "Mot clé : Tous les éléments. | " & lancerLaRechercheDunElement("Tous les éléments.") & IIf(listeDeResultatsDeLaRecherche.LongCount > 1, " résultats trouvés !", " résultat trouvé !")
            afficherLesResultatsEnDescendantDansLaListeDeTousLesElements(listeDeResultatsDeLaRecherche)
            '^^^^^
            '#########
            Decrire_ImageSonTexte.Lbl_NomElmtASupprimer.Text = nomDeLelement
            Close()
            Decrire_ImageSonTexte.Show()
        End If
    End Sub
    Public Sub copierListe1_Dans_Liste2(ByRef liste1 As List(Of String), ByRef liste2 As List(Of String))
        For Each elmt In liste1
            liste2.Add(elmt)
        Next
    End Sub
    Private Sub policeTexte_Click(sender As Object, e As EventArgs) Handles policeTexte.Click
        If (etatPolice = "Monter") Then
            pos1.Y += 26
            posCouleurTexte.Y += 26
            posCouleurFond.Y += 26
            posTailleTexte.Y += 26

            comboBoxPolice.Location = pos1
            couleurTexte.Location = posCouleurTexte
            couleurDeFond.Location = posCouleurFond
            TailleDeTexte.Location = posTailleTexte

            pos2.Y += 26
            pos3.Y += 26
            pos4.Y += 26
            comboBoxCouleurTexte.Location = pos2
            comboBoxCouleurFond.Location = pos3
            comboBoxTailleTexte.Location = pos4
            etatPolice = "Descendu"
        ElseIf (etatPolice = "Descendu")
            pos1.Y -= 26
            posCouleurTexte.Y -= 26
            posCouleurFond.Y -= 26
            posTailleTexte.Y -= 26

            comboBoxPolice.Location = pos1
            couleurTexte.Location = posCouleurTexte
            couleurDeFond.Location = posCouleurFond
            TailleDeTexte.Location = posTailleTexte

            pos2.Y -= 26
            pos3.Y -= 26
            pos4.Y -= 26
            comboBoxCouleurTexte.Location = pos2
            comboBoxCouleurFond.Location = pos3
            comboBoxTailleTexte.Location = pos4
            etatPolice = "Monter"
        End If
    End Sub

End Class