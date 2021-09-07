Imports Guna.UI.WinForms
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.IO
Public Class FenetreTousLesElementsEtBarreDeRecherche

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles TimerChangerCouleur.Tick
        Seconde += 1
        BackColor = Color.PowderBlue
        Reduire.BaseColor = Color.PowderBlue
        Fermer.BaseColor = Color.PowderBlue

        If (Seconde = 2) Then
            BackColor = Color.DeepSkyBlue
            Reduire.BaseColor = Color.DeepSkyBlue
            Fermer.BaseColor = Color.DeepSkyBlue
            Seconde = 0
            TimerChangerCouleur.Stop()
        End If
    End Sub
    Public Sub deplacerCercleActifEnDescendant()
        pos = cercleActif.Location
        pos2 = laDate.Location
        Select Case cercleActif.Location.Y
            Case tabElmt(compteur)
                compteur = IIf(compteur < 6, compteur + 1, 0)
                pos.Y = tabElmt(compteur)
                pos2.Y = pos.Y + 3
                cercleActif.Location = pos
                laDate.Location = pos2
        End Select
    End Sub

    Private Sub bouttonSuivant_Click(sender As Object, e As EventArgs) Handles bouttonDescendre.Click
        donnerUneCouleurAL_elementActifEnDescendant()
        cercleActif.BackColor = Color.Indigo
        deplacerCercleActifEnDescendant()
        afficherLesProchainsElements()
        If (numeroDuResultatSelectionner <> -100) Then
            rendreLaDateVisible.Start()
        Else
            laDate.Visible = False
            rendreLaDateVisible.Stop()
        End If
        Seconde2 = 0
        NumeroBouttonActif.Text = compteur2
        'TimerChangerCouleur.Start()
    End Sub

    Public Sub deplacerCuseur(elmt As Label)
        Dim pos As Point = curseur.Location
        If (elmt.Location.X > curseur.Location.X) Then
            pos.X += 99
            curseur.Location = pos
        ElseIf (elmt.Location.X < curseur.Location.X)
            pos.X -= 99
            curseur.Location = pos
        End If
    End Sub



    Public Sub donnerUneCouleurAL_elementActifEnDescendant()


        jeCliqueSurDescendre = True

        If (jeCliqueSurMonter) Then
            compteur2 += 1
            jeCliqueSurMonter = False
        End If

        tabLesSujets = {element_1, element_2, element_3, element_4, element_5, element_6, element_7}
        If (compteur2 = 0) Then
            tabLesSujets(compteur2).Focus()
            tabLesSujets(compteur2).BaseColor = Color.Indigo
            tabLesSujets(compteur2).ForeColor = Color.White
            compteur2 = compteur2 + 1
        ElseIf (compteur2 <= 6) Then
            tabLesSujets(compteur2 - 1).ForeColor = Color.DimGray
            tabLesSujets(compteur2 - 1).BaseColor = Color.White
            tabLesSujets(compteur2).Focus()
            tabLesSujets(compteur2).BaseColor = Color.Indigo
            tabLesSujets(compteur2).ForeColor = Color.White
            compteur2 += 1
        ElseIf (compteur2 = 7)
            tabLesSujets(compteur2 - 1).ForeColor = Color.DimGray
            tabLesSujets(compteur2 - 1).BaseColor = Color.White
            compteur2 = 0
            tabLesSujets(compteur2).Focus()
            tabLesSujets(compteur2).ForeColor = Color.White
            tabLesSujets(compteur2).BaseColor = Color.Indigo
            compteur2 = compteur2 + 1
        End If


    End Sub



    Private Sub Form2_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FenetreChargement.Close()
    End Sub

    Private Sub rechercher_Click(sender As Object, e As EventArgs) Handles TousLesElementsEtBarreDeRecherche.Click
        rendreTousElementsVisible(False)
        deplacerCuseur(TousLesElementsEtBarreDeRecherche)
    End Sub

    Private Sub ajouterDesElements_MouseHover(sender As Object, e As EventArgs) Handles ajouterDesElements.MouseHover
        info1.Visible = True
        info1.Text = "Ajouter des éléments"
        infoBulleRecherche = info1
        afficherInfoBulle.Start()
    End Sub

    Private Sub ajouterDesElements_MouseLeave(sender As Object, e As EventArgs) Handles ajouterDesElements.MouseLeave
        info1.Visible = False
    End Sub

    Private Sub bouttonMonter_MouseHover(sender As Object, e As EventArgs) Handles bouttonMonter.MouseHover
        info2.Visible = True
        info2.Text = "Monter"
        infoBulleRecherche = info2
        afficherInfoBulle.Start()
    End Sub

    Private Sub bouttonMonter_MouseLeave(sender As Object, e As EventArgs) Handles bouttonMonter.MouseLeave
        info2.Visible = False
    End Sub

    Private Sub bouttonDescendre_MouseHover(sender As Object, e As EventArgs) Handles bouttonDescendre.MouseHover
        info3.Visible = True
        info3.Text = "Descendre"
        infoBulleRecherche = info3
        afficherInfoBulle.Start()
    End Sub

    Private Sub bouttonDescendre_MouseLeave(sender As Object, e As EventArgs) Handles bouttonDescendre.MouseLeave
        info3.Visible = False
    End Sub

    Private Sub mesFavoris_MouseHover(sender As Object, e As EventArgs)
        info2.Visible = True
        info2.Text = "Favoris"
        infoBulleRecherche = info2
        afficherInfoBulle.Start()
    End Sub

    Private Sub mesFavoris_MouseLeave(sender As Object, e As EventArgs)
        info2.Visible = False
    End Sub

    Private Sub monHistorique_MouseHover(sender As Object, e As EventArgs)
        info3.Visible = True
        info3.Text = "Historique"
        infoBulleRecherche = info3
        afficherInfoBulle.Start()
    End Sub

    Private Sub monHistorique_MouseLeave(sender As Object, e As EventArgs)
        info3.Visible = False
    End Sub

    Private Sub ajouterDesElements_Click(sender As Object, e As EventArgs) Handles ajouterDesElements.Click
        Hide()
        InformationsPourLaBarreDeRecherche.Show()
    End Sub

    Private Sub element_1_Click(sender As Object, e As EventArgs) Handles element_1.Click
        If (index_Resultat1.Text <> "*") Then
            Try
                mesImages = listeDeResultatsDeLaRecherche(CInt(index_Resultat1.Text)).ListeDePathDesImages1
                maPlaylist = listeDeResultatsDeLaRecherche(CInt(index_Resultat1.Text)).ListeDePathDesMusiques1
                descriptionTextuelleDeLelement = transformerDescriptionTextuelleEnCaractereNormaux(listeDeResultatsDeLaRecherche(CInt(index_Resultat1.Text)).DescriptionTextuelle1)
                Decrire_ImageSonTexte.Lbl_NomElmtASupprimer.Text = listeDeResultatsDeLaRecherche(CInt(index_Resultat1.Text)).Signature1
                numeroDeLinformation = listeDeResultatsDeLaRecherche(CInt(index_Resultat1.Text)).Numero1
                Hide()
                Decrire_ImageSonTexte.Show()
            Catch ex As Exception

            End Try

        End If

    End Sub

    Private Sub element_2_Click(sender As Object, e As EventArgs) Handles element_2.Click
        If (index_Resultat2.Text <> "*") Then
            Try
                numeroDeLinformation = listeDeResultatsDeLaRecherche(CInt(index_Resultat2.Text)).Numero1
                mesImages = listeDeResultatsDeLaRecherche(CInt(index_Resultat2.Text)).ListeDePathDesImages1
                maPlaylist = listeDeResultatsDeLaRecherche(CInt(index_Resultat2.Text)).ListeDePathDesMusiques1
                Decrire_ImageSonTexte.Lbl_NomElmtASupprimer.Text = listeDeResultatsDeLaRecherche(CInt(index_Resultat2.Text)).Signature1
                descriptionTextuelleDeLelement = transformerDescriptionTextuelleEnCaractereNormaux(listeDeResultatsDeLaRecherche(CInt(index_Resultat2.Text)).DescriptionTextuelle1)
                Hide()
                Decrire_ImageSonTexte.Show()
            Catch ex As Exception

            End Try

        End If
    End Sub

    Private Sub element_3_Click(sender As Object, e As EventArgs) Handles element_3.Click
        If (index_Resultat3.Text <> "*") Then
            Try
                numeroDeLinformation = listeDeResultatsDeLaRecherche(CInt(index_Resultat3.Text)).Numero1
                Decrire_ImageSonTexte.Lbl_NomElmtASupprimer.Text = listeDeResultatsDeLaRecherche(CInt(index_Resultat3.Text)).Signature1
                mesImages = listeDeResultatsDeLaRecherche(CInt(index_Resultat3.Text)).ListeDePathDesImages1
                maPlaylist = listeDeResultatsDeLaRecherche(CInt(index_Resultat3.Text)).ListeDePathDesMusiques1
                descriptionTextuelleDeLelement = transformerDescriptionTextuelleEnCaractereNormaux(listeDeResultatsDeLaRecherche(CInt(index_Resultat3.Text)).DescriptionTextuelle1)
                Hide()
                Decrire_ImageSonTexte.Show()
            Catch ex As Exception

            End Try

        End If
    End Sub

    Private Sub element_4_Click(sender As Object, e As EventArgs) Handles element_4.Click
        If (index_Resultat4.Text <> "*") Then
            Try
                numeroDeLinformation = listeDeResultatsDeLaRecherche(CInt(index_Resultat4.Text)).Numero1
                Decrire_ImageSonTexte.Lbl_NomElmtASupprimer.Text = listeDeResultatsDeLaRecherche(CInt(index_Resultat4.Text)).Signature1
                mesImages = listeDeResultatsDeLaRecherche(CInt(index_Resultat4.Text)).ListeDePathDesImages1
                maPlaylist = listeDeResultatsDeLaRecherche(CInt(index_Resultat4.Text)).ListeDePathDesMusiques1
                descriptionTextuelleDeLelement = transformerDescriptionTextuelleEnCaractereNormaux(listeDeResultatsDeLaRecherche(CInt(index_Resultat4.Text)).DescriptionTextuelle1)
                Hide()
                Decrire_ImageSonTexte.Show()
            Catch ex As Exception

            End Try

        End If
    End Sub

    Private Sub element_5_Click(sender As Object, e As EventArgs) Handles element_5.Click
        If (index_Resultat5.Text <> "*") Then
            Try
                numeroDeLinformation = listeDeResultatsDeLaRecherche(CInt(index_Resultat5.Text)).Numero1
                Decrire_ImageSonTexte.Lbl_NomElmtASupprimer.Text = listeDeResultatsDeLaRecherche(CInt(index_Resultat5.Text)).Signature1
                mesImages = listeDeResultatsDeLaRecherche(CInt(index_Resultat5.Text)).ListeDePathDesImages1
                maPlaylist = listeDeResultatsDeLaRecherche(CInt(index_Resultat5.Text)).ListeDePathDesMusiques1
                descriptionTextuelleDeLelement = transformerDescriptionTextuelleEnCaractereNormaux(listeDeResultatsDeLaRecherche(CInt(index_Resultat5.Text)).DescriptionTextuelle1)
                Hide()
                Decrire_ImageSonTexte.Show()
            Catch ex As Exception

            End Try

        End If
    End Sub

    Private Sub element_6_Click(sender As Object, e As EventArgs) Handles element_6.Click
        If (index_Resultat6.Text <> "*") Then
            Try
                numeroDeLinformation = listeDeResultatsDeLaRecherche(CInt(index_Resultat6.Text)).Numero1
                Decrire_ImageSonTexte.Lbl_NomElmtASupprimer.Text = listeDeResultatsDeLaRecherche(CInt(index_Resultat6.Text)).Signature1
                mesImages = listeDeResultatsDeLaRecherche(CInt(index_Resultat6.Text)).ListeDePathDesImages1
                maPlaylist = listeDeResultatsDeLaRecherche(CInt(index_Resultat6.Text)).ListeDePathDesMusiques1
                descriptionTextuelleDeLelement = transformerDescriptionTextuelleEnCaractereNormaux(listeDeResultatsDeLaRecherche(CInt(index_Resultat6.Text)).DescriptionTextuelle1)
                Hide()
                Decrire_ImageSonTexte.Show()
            Catch ex As Exception

            End Try

        End If
    End Sub

    Private Sub element_7_Click(sender As Object, e As EventArgs) Handles element_7.Click
        If (index_Resultat7.Text <> "*") Then
            Try
                numeroDeLinformation = listeDeResultatsDeLaRecherche(CInt(index_Resultat7.Text)).Numero1
                Decrire_ImageSonTexte.Lbl_NomElmtASupprimer.Text = listeDeResultatsDeLaRecherche(CInt(index_Resultat7.Text)).Signature1
                mesImages = listeDeResultatsDeLaRecherche(CInt(index_Resultat7.Text)).ListeDePathDesImages1
                maPlaylist = listeDeResultatsDeLaRecherche(CInt(index_Resultat7.Text)).ListeDePathDesMusiques1
                descriptionTextuelleDeLelement = transformerDescriptionTextuelleEnCaractereNormaux(listeDeResultatsDeLaRecherche(CInt(index_Resultat7.Text)).DescriptionTextuelle1)
                Hide()
                Decrire_ImageSonTexte.Show()
            Catch ex As Exception

            End Try

        End If
    End Sub

    Private Sub Reduire_Click(sender As Object, e As EventArgs) Handles Reduire.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Fermer_Click(sender As Object, e As EventArgs) Handles Fermer.Click
        Close()
    End Sub

    Private Sub aideSupport_MouseHover(sender As Object, e As EventArgs) Handles aideSupport.MouseHover
        Lbl_Aide.Visible = True
        infoBulleRecherche = info3
        infoBulleRecherche.Text = aideSupport.Name
    End Sub

    Private Sub aideSupport_MouseLeave(sender As Object, e As EventArgs) Handles aideSupport.MouseLeave
        Lbl_Aide.Visible = False
    End Sub

    Private Sub afficherInfoBulle_Tick(sender As Object, e As EventArgs) Handles afficherInfoBulle.Tick

        If (dureeInfoBulle = 3) Then
            Select Case infoBulleRecherche.Text
                Case "Monter", "Favoris"
                    info2.Visible = False
                Case "Descendre", "Historique"
                    info3.Visible = False
                Case "Ajouter des éléments"
                    info1.Visible = False
                Case "aideSupport"
                    Lbl_Aide.Visible = False
            End Select
            afficherInfoBulle.Stop()
            dureeInfoBulle = 0
        End If

        dureeInfoBulle += 1
    End Sub

    Private Sub elements_Click(sender As Object, e As EventArgs) Handles elements.Click
        laDate.Text = ""
        rendreTousElementsVisible(True)
        deplacerCuseur(elements)
    End Sub



    Private Sub rendreLaDateVisible_Tick(sender As Object, e As EventArgs) Handles rendreLaDateVisible.Tick
        laDate.Visible = True
        Try
            laDate.Text = "Créé le " & listeDeResultatsDeLaRecherche(numeroDuResultatSelectionner).DateDeCreation1
        Catch ex As Exception
        End Try
        Seconde2 += 1
        If (Seconde2 = 5) Then
            Seconde2 = 0
            laDate.Text = ""
            laDate.Visible = False
            rendreLaDateVisible.Stop()
        End If
    End Sub
    'La valeur maximale que peut prendre les elements enregistrer dans les noms c'est 46 Text.lenght

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        donnerUneCouleurAL_elementActifEnMontant()
        donnerUneCouleurAL_elementActifEnDescendant()
        rendreTousElementsVisible(False)
        NumeroBouttonActif.Text = compteur2
        ''#######ICI C'EST POUR METTRE A JOUR NOTRE LISTE DE RESULTATS(AFFICHAGE) SANS QU'ON N'AIT TAPEZ RECHERCHER
        ''PAS DU TOUT OBLIGATOIRE SI CA POSE PROBLEME ENLEVE CETTE PARTIE , C'EST JUSTE POUR ETRE UN PEU COHERENT DANS L'AFFICHAGE
        'jetonAttibuer = 1
        'indexDansLaListeDeResultat = 0
        'onContinueLaffichageDesResultats = True
        'motClerEtResultat.Text = "Mot clé : Tous les éléments. | " & lancerLaRechercheDunElement("Tous les éléments.") & IIf(listeDeResultatsDeLaRecherche.LongCount > 1, " résultats trouvés !", " résultat trouvé !")
        'afficherLesResultatsEnDescendantDansLaListeDeTousLesElements(listeDeResultatsDeLaRecherche)
        ''^^^^^
        ''#########
    End Sub

    Public Sub rendreTousElementsVisible(bool As Boolean)
        tabLesSujets = {element_1, element_2, element_3, element_4, element_5, element_6, element_7}
        motClerEtResultat.Visible = bool
        'LBL_TousLesElements.Visible = bool
        pos.X = 248
        pos.Y = 209

        pos2.X = 675
        pos2.Y = 209 '215

        pos3.X = 847
        pos3.Y = 465

        pos4.X = 847
        pos4.Y = 511
        For Each c As GunaAdvenceButton In tabLesSujets
            c.Visible = bool
        Next

        ajouterDesElements.Visible = bool
        bouttonDescendre.Visible = bool
        bouttonMonter.Visible = bool
        'nbrTotalDelements.Visible = bool

        laDate.Visible = bool

        cercleActif.Visible = bool

        barreDeRecherche.Visible = Not (bool)
        bouttonRecherche.Visible = Not (bool)
        'mesFavoris.Visible = Not (bool)
        'monHistorique.Visible = Not (bool)
        'nbrTotalDelements.Visible = bool
        If (bool) Then

            If (compteur3 = 0) Then
                tabLesSujets(compteur3).Focus()
                tabLesSujets(compteur3).BaseColor = Color.Indigo
                tabLesSujets(compteur3).ForeColor = Color.White
                compteur3 = compteur3 + 1
            End If

            rendreLaDateVisible.Start()
        Else
            laDate.Visible = False
            rendreLaDateVisible.Stop()
            barreDeRecherche.Location = pos
            bouttonRecherche.Location = pos2
            'mesFavoris.Location = pos3
            'monHistorique.Location = pos4
        End If

    End Sub


    Private Sub bouttonMonter_Click(sender As Object, e As EventArgs) Handles bouttonMonter.Click
        laDate.Text = ""
        donnerUneCouleurAL_elementActifEnMontant()
        deplacerCercleActifEnMontant()
        Seconde2 = 0
        cercleActif.BackColor = Color.Indigo
        NumeroBouttonActif.Text = compteur2
        afficherLesElementsPrecedents()
        If (numeroDuResultatSelectionner <> -100) Then
            rendreLaDateVisible.Start()
        Else
            laDate.Visible = False
            rendreLaDateVisible.Stop()
        End If

    End Sub

    Private Sub bouttonRecherche_Click(sender As Object, e As EventArgs) Handles bouttonRecherche.Click
        jetonAttibuer = 1
        indexDansLaListeDeResultat = 0
        onContinueLaffichageDesResultats = True
        motClerEtResultat.Text = "Mot clé : " & barreDeRecherche.Text & " | " & lancerLaRechercheDunElement(barreDeRecherche.Text) & IIf(listeDeResultatsDeLaRecherche.LongCount > 1, " résultats trouvés !", " résultat trouvé !")
        afficherLesResultatsEnDescendantDansLaListeDeTousLesElements(listeDeResultatsDeLaRecherche)

        'Si il y'a des resultats alors on peut partir sur l'onglet de tous les éléments.
        'Sinon on reste sur cette fenêtre et on attend , la saisie d'un mot à rechercher qui existe.
        If (listeDeResultatsDeLaRecherche.LongCount > 0) Then
            rendreTousElementsVisible(True)
            deplacerCuseur(elements)
        Else
            barreDeRecherche.Focus()
        End If

    End Sub

    Private Sub FenetreTousLesElementsEtBarreDeRecherche_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        '#######ICI C'EST POUR METTRE A JOUR NOTRE LISTE DE RESULTATS(AFFICHAGE) SANS QU'ON N'AIT TAPEZ RECHERCHER
        'PAS DU TOUT OBLIGATOIRE SI CA POSE PROBLEME ENLEVE CETTE PARTIE , C'EST JUSTE POUR ETRE UN PEU COHERENT DANS L'AFFICHAGE
        jetonAttibuer = 1
        indexDansLaListeDeResultat = 0
        onContinueLaffichageDesResultats = True
        motClerEtResultat.Text = "Mot clé : Tous les éléments. | " & lancerLaRechercheDunElement("Tous les éléments.") & IIf(listeDeResultatsDeLaRecherche.LongCount > 1, " résultats trouvés !", " résultat trouvé !")
        afficherLesResultatsEnDescendantDansLaListeDeTousLesElements(listeDeResultatsDeLaRecherche)
        '^^^^^
        '#########
    End Sub
End Class