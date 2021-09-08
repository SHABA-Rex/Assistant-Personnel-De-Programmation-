Imports Guna.UI.WinForms
Imports System.Xml.Serialization
Imports System.IO

'On a un probleme au niveau de la liste peut etre qu'on va en creer une autre pour separer les utilisations.

Module Les_Fonctions

    Public optionSelectioner, policeDuTexte, couleurDuFond, couleurDuTexte As String
    Public tailleDuTexte As Integer = 0
    Public Seconde As Integer = 0, compteur As Integer = 0, Seconde2 As Integer = 0, compteur2 As Integer = 0, compteur3 As Integer = 0, dureeInfoBulle As Integer = 1 'Rend ça plus explicite.
    Public mot As String
    Public jeCliqueSurMonter = False, jeCliqueSurDescendre = False
    Public pos, pos2, pos3, pos4 As Point
    Public tabElmt() As Integer = {117, 164, 210, 259, 308, 355, 403}
    Public tabLesSujets() As GunaAdvenceButton
    Public infoBulleRecherche As GunaLabel
    Public ascenceurActiver As String = ""
    Public descriptionTextuelleDeLelement As String = "" 'A effacer
    Public indexDansLaListeDeResultat As Integer = 0
    Public jetonAttibuer As Integer = 1 'IL Y'EN AURA 7, PUSQU'IL Y'A DANS L'ONGLET TOUS LES ELEMENTS  : 7 Bouttons .
    Public listeDeResultatsDeLaRecherche As New List(Of informationARechercher)
    Public onContinueLaffichageDesResultats As Boolean = True
    Public numeroDuDernierResultatAfficher, numeroDuResultatSelectionner, numeroDuPremierResultatAfficher, numeroDuResultatSelectionnerEnmontant As Integer
    Public maPlaylist As New List(Of String)
    Public mesImages As New List(Of String)
    Public numeroDeLinformation = 0
    Public ajoutDimageAvantOuApres As String = "Avant enregistrement" 'Avant ou apres l'enregistrement des images dans à aprtir du formulaire.
    'Public informationAEnregistrer As New informationARechercher()
    '######### VARIABLES UTILISER POUR LE STOCKAGE DANS LE FICHIER XML.
    Public nomDeLelement, categorieDeLelement As String
    Public listeDePathDeMusiques As New List(Of String)
    Public listeVide As New List(Of String)
    Public listeDePathDesImages As New List(Of String)
    Public tableauMotCles As String() '#######ARRET ICI >>>>>>>>>>>DescriptionAudio'IL FAUT QUE J'UTILISE LES LISTES A LA PLACE DES TABLEAUX POUR ENREGISTRER LES MUSIQUES, LES IMAGES. DONC CHERCHE PARTOUT OU TU AS UTILISER LES TABLEAUXMusic TABLEAUXImage pour les remplacer par les listes.
    Public listeDinformations As New List(Of informationARechercher)
    Public fluxDeSerialisation As FileStream
    Public fluxDeDeSerialisation As FileStream
    Public serialiseur As New XmlSerializer(GetType(List(Of informationARechercher)))
    Public serialiseurDesParametresTexte As New XmlSerializer(GetType(parametresDuTexte))

    'Public information0PourInitialisation As New informationARechercher("none", "none", "none", tableauMotCles, tableauMusiques, tableauImages, "")
    'Public informationPourInitialisation As New informationARechercher()
    Public listeDinformations3 As New List(Of informationARechercher) 'C'est ici qu'on stocke les éléments qu'on enregistre.
    Public listeDinformationsSauvegarder As New List(Of informationARechercher)
    Public listeDeSauvegarde As New List(Of informationARechercher)
    'Ces informations seront chargées dans informations.xml, si le fichier d'informations après avoir rencontrée une erreur s'est effacée 
    'seul permettant ainsi d'assurer la sauvegarde des dernières informations sûr et non corrompu. 
    Public onAMisUnPointAlaFinDesMotsCle As Boolean = False
    '###########
    'IL FAUT QUE JE POSITIONNE LES ELEMENTS RESULTATS DANS LA LISTE DES ELEMENTS
    'NOUS LORSQU'IL Y'A DES RESULTATS LA LISTE DE CES RESULTATS EST DEJA ENREGISTRER DONC ON POURRA LA RECUPERER POUR STOCKER SES ELEMENTS DANS LA LISTE DES RESULTATS.

    Public Function stockerLesMotsCles(lesMotsCles As String) As String()
        '########
        'ICI ON VA DETERMINER SI ON A MIS UN POINT OU UNE VIRGULE A LA FIN DE NOS MOTS CLES 
        'POUR SOIT EMPÊCHER LA SAUVEGARDE DE L'ELEMENT, SOIT CONTINUER LA SAUVEGARDE DE L'ELEMENT.
        'DescriptionAudio.Label1.Text = lesMotsCles(lesMotsCles.Length - 1)
        onAMisUnPointAlaFinDesMotsCle = False
        If (lesMotsCles.Length > 0) Then
            If (lesMotsCles(lesMotsCles.Length - 1) = "." Or lesMotsCles(lesMotsCles.Length - 1) = ",") Then
                onAMisUnPointAlaFinDesMotsCle = True
            End If
        Else
            MsgBox("Saisissez au moins un mot clé pour la recherche !", MsgBoxStyle.Information, Title:="INFORMATION")
            MsgBox("Vous devez remplir tous les champs!", MsgBoxStyle.Information, Title:="INFORMATION")
        End If
        '########

        Dim tableauMotCles(7) As String
        Dim unMot As String = ""
        Dim index = 0

        tableauMotCles = {"//*none*\\", "//*none*\\", "//*none*\\", "//*none*\\", "//*none*\\", "//*none*\\", "Tous les éléments."}

        For Each carac In lesMotsCles
            If (carac = "," Or carac = ".") Then
                If (index <= 5) Then
                    tableauMotCles(index) = unMot
                    unMot = ""
                    index += 1
                End If
            Else
                unMot += carac
            End If
        Next

        Return tableauMotCles

    End Function
    Public Function lancerLaRechercheDunElement(uneCaracteristique As String)

        'On va retourner le nombre de resultats de la recherche.
        Dim aucunResultatTouverNullePart As Boolean = True
        Dim onAdejaUneCorrespondance As Boolean = False
        Dim compteurDeResultat As Integer = 0
        Dim onAtrouverUnresultat As Boolean = False
        Dim laListeDeResultatEstInitialiser As Boolean = True
        Dim listeDeResultats As New List(Of informationARechercher)
        Dim listeDeResultatsARetourner As New List(Of informationARechercher)
        Dim activerLaRechercheDansSignature = True, activerLaRechercheDansCategorie = True, activerLaRechercheDansMotCles = True
        'LA RECHERCHE VAS SE FAIRE A TROIS NIVEAUX : 
        '- DANS LES SIGNATURES (NOMS)
        '- DANS LES CATEGORIES 
        '- DANS LES MOTS CLES

        Dim fluxDeDeserialisation As FileStream = New FileStream("Informations_Enregistrées.xml", FileMode.OpenOrCreate)

        Try
            listeDeResultats = serialiseur.Deserialize(fluxDeDeserialisation) 'On enleve toutes les infos dans le fichier XML , s'il y en a , s'il n'y en a pas on va pas continuer la recherche, elle sera annulée.
        Catch ex As Exception 'ON ENTRE ICI SI LE FICHIER XML EST VIDE  OU SI LE FICHIER XML A UNE ERREUR DANS SON CONTENU.
            fluxDeDeserialisation.Close() 'ICI ON ARRETE LE PRECEDENT FLUX AVANT DE CREER LE SUIVANT.
            '#######
            'CE FLUX PERMET D'EFFACER TOTALEMENT LE CONTENU DE NOTRE FICHIER XML CAR ON S'EST RENDU COMPTE QUE L'UTILISATEUR L'A MODIFIER CE QUI A ENTRAINER UNE ERREUR
            'IL REMPLACERA UN FICHIER VIDE SI ON SE REND COMPTE QU'IL EST VIDE.
            Dim fluxTemporaire As FileStream = New FileStream("Informations_Enregistrées.xml", FileMode.Create)
            fluxTemporaire.Close()
            '#######
            laListeDeResultatEstInitialiser = False
        End Try

        fluxDeDeserialisation.Close()


        If (laListeDeResultatEstInitialiser) Then 'ICI ON DECIDE DE SI ON CONTINUE LA RECHERCHE OU SI ON L'ANNULE.

            If (activerLaRechercheDansSignature) Then
                For Each elmt In listeDeResultats
                    If ((uneCaracteristique.ToLower).Equals(elmt.Signature1.ToLower)) Then 'On met tout en minuscule avant de comparer.
                        compteurDeResultat += 1
                        listeDeResultatsARetourner.Add(elmt)
                        activerLaRechercheDansCategorie = False
                        activerLaRechercheDansMotCles = False
                        aucunResultatTouverNullePart = False
                    End If
                Next
            End If

            If (activerLaRechercheDansCategorie) Then 'On recherche tous les éléments qui ont pour categorie 'uneCaracteristique'
                For Each elmt In listeDeResultats
                    If ((uneCaracteristique.ToLower).Equals(elmt.Categorie1.ToLower)) Then 'On met tout en minuscule avant de comparer.
                        compteurDeResultat += 1 'A la place on va juste enregistrer le numero de chaque élément qui correspond.
                        listeDeResultatsARetourner.Add(elmt)
                        activerLaRechercheDansMotCles = False
                        aucunResultatTouverNullePart = False
                    End If
                Next
            End If

            If (activerLaRechercheDansMotCles) Then
                For Each elmt In listeDeResultats
                    For Each motCle In elmt.TableauMotCles1
                        If ((uneCaracteristique.ToLower).Equals(motCle.ToLower)) And Not (onAdejaUneCorrespondance) Then
                            compteurDeResultat += 1 'A la place on va juste enregistrer le numero de chaque élément qui correspond dans une autre listeResultats 
                            listeDeResultatsARetourner.Add(elmt)
                            aucunResultatTouverNullePart = False
                            onAdejaUneCorrespondance = True
                        End If
                    Next
                    onAdejaUneCorrespondance = False 'C'est ici qu'on va recuperer le numero des elements qui correspondent.
                Next
            End If
            If (aucunResultatTouverNullePart) Then
                MsgBox("   Aucun résultats trouvés ! ", MsgBoxStyle.Information, "")
                MsgBox(" Vérifiez bien l'orthographe ! ", MsgBoxStyle.Information, "")
            End If
        Else
            MsgBox("Aucune informations n'est enregistrées ! ", MsgBoxStyle.Information, "IMPORTANT")
            MsgBox("Une fenetre va s'ouvrir , vous pourrez commencez l'enregistrement ! ", MsgBoxStyle.Information, "IMPORTANT")
            InformationsPourLaBarreDeRecherche.Show()
            FenetreTousLesElementsEtBarreDeRecherche.Hide()
        End If
        listeDeResultatsDeLaRecherche = listeDeResultatsARetourner
        Return listeDeResultatsARetourner.LongCount 'compteurDeResultat 'On doit recuperer la liste.

    End Function
    Public Sub donnerUneCouleurAL_elementActifEnMontant()

        jeCliqueSurMonter = True

        If (jeCliqueSurDescendre) Then
            compteur2 -= 1
            jeCliqueSurDescendre = False
        End If

        'FenetreTousLesElementsEtBarreDeRecherche.Label1.Text = compteur2
        tabLesSujets = {FenetreTousLesElementsEtBarreDeRecherche.element_1, FenetreTousLesElementsEtBarreDeRecherche.element_2, FenetreTousLesElementsEtBarreDeRecherche.element_3, FenetreTousLesElementsEtBarreDeRecherche.element_4, FenetreTousLesElementsEtBarreDeRecherche.element_5, FenetreTousLesElementsEtBarreDeRecherche.element_6, FenetreTousLesElementsEtBarreDeRecherche.element_7}

        If (compteur2 = 0) Then
            tabLesSujets(6).Focus()
            tabLesSujets(6).BaseColor = Color.Indigo
            tabLesSujets(6).ForeColor = Color.White
            tabLesSujets(0).ForeColor = Color.DimGray
            tabLesSujets(0).BaseColor = Color.White
            compteur2 = 6
        ElseIf (compteur2 <= 6) Then
            tabLesSujets(compteur2).ForeColor = Color.DimGray
            tabLesSujets(compteur2).BaseColor = Color.White
            tabLesSujets(compteur2 - 1).Focus()
            tabLesSujets(compteur2 - 1).BaseColor = Color.Indigo
            tabLesSujets(compteur2 - 1).ForeColor = Color.White
            compteur2 -= 1
        End If

        'ElseIf (compteur2 = 7)
        '    tabLesSujets(compteur2 - 1).ForeColor = Color.DimGray
        '    tabLesSujets(compteur2 - 1).BaseColor = Color.White
        '    compteur2 = 0
        '    tabLesSujets(compteur2).Focus()
        '    tabLesSujets(compteur2).ForeColor = Color.White
        '    tabLesSujets(compteur2).BaseColor = Color.Indigo
        '    compteur2 = compteur2 + 1
        'End If

    End Sub
    Public Sub deplacerCercleActifEnMontant()
        pos = FenetreTousLesElementsEtBarreDeRecherche.cercleActif.Location
        pos2 = FenetreTousLesElementsEtBarreDeRecherche.laDate.Location
        Select Case FenetreTousLesElementsEtBarreDeRecherche.cercleActif.Location.Y
            Case tabElmt(compteur)
                compteur = IIf(compteur > 0, compteur - 1, 6)
                pos.Y = tabElmt(compteur)
                If (compteur = 6) Then
                    pos2.Y = pos.Y + 15
                Else
                    pos2.Y = pos.Y - 3
                End If
                FenetreTousLesElementsEtBarreDeRecherche.cercleActif.Location = pos
                FenetreTousLesElementsEtBarreDeRecherche.laDate.Location = pos2
        End Select
    End Sub
    Public Sub rendreVisibleTousLesElementsDesDescriptions(Optional bool As Boolean = True)
        Dim p As Point
        p.X = 250
        p.Y = 120
        If (optionSelectioner = Decrire_ImageSonTexte.descriptionTextuelle.Name Or optionSelectioner = Decrire_ImageSonTexte.descriptionImage.Name) Then
            Decrire_ImageSonTexte.nextMusique.Visible = False
            Decrire_ImageSonTexte.previousMusique.Visible = False
            'Decrire_ImageSonTexte.ChampTextuel.Enabled = False
            Decrire_ImageSonTexte.modifierSauvegarder.Visible = Not (bool)
            Decrire_ImageSonTexte.lesImages.Visible = bool
            Decrire_ImageSonTexte.previousImage.Visible = bool
            Decrire_ImageSonTexte.nextImage.Visible = bool
            Decrire_ImageSonTexte.lecteurMusique.Visible = False
            Decrire_ImageSonTexte.ChampTextuel.Visible = Not (bool)
            Decrire_ImageSonTexte.ChampTextuel.Location = p
            Decrire_ImageSonTexte.ChampTextuel.Width = DescriptionTextuelle.ChampTextuel.Width
            Decrire_ImageSonTexte.ChampTextuel.Height = DescriptionTextuelle.ChampTextuel.Height
        ElseIf (optionSelectioner = Decrire_ImageSonTexte.descriptionSonore.Name)
            Decrire_ImageSonTexte.nextMusique.Visible = True
            Decrire_ImageSonTexte.previousMusique.Visible = True
            'Decrire_ImageSonTexte.ChampTextuel.Enabled = True
            Decrire_ImageSonTexte.modifierSauvegarder.Visible = False
            Decrire_ImageSonTexte.lesImages.Visible = False
            Decrire_ImageSonTexte.previousImage.Visible = False
            Decrire_ImageSonTexte.nextImage.Visible = False
            Decrire_ImageSonTexte.lecteurMusique.Visible = True
            Decrire_ImageSonTexte.ChampTextuel.Visible = False
        End If
    End Sub
    Public Sub afficherLesResultatsEnDescendantDansLaListeDeTousLesElements(ListeDeResultats As List(Of informationARechercher))

        FenetreTousLesElementsEtBarreDeRecherche.element_1.Text = ""
        FenetreTousLesElementsEtBarreDeRecherche.element_2.Text = ""
        FenetreTousLesElementsEtBarreDeRecherche.element_3.Text = ""
        FenetreTousLesElementsEtBarreDeRecherche.element_4.Text = ""
        FenetreTousLesElementsEtBarreDeRecherche.element_5.Text = ""
        FenetreTousLesElementsEtBarreDeRecherche.element_6.Text = ""
        FenetreTousLesElementsEtBarreDeRecherche.element_7.Text = ""


        FenetreTousLesElementsEtBarreDeRecherche.index_Resultat1.Text = "*"
        FenetreTousLesElementsEtBarreDeRecherche.index_Resultat2.Text = "*"
        FenetreTousLesElementsEtBarreDeRecherche.index_Resultat3.Text = "*"
        FenetreTousLesElementsEtBarreDeRecherche.index_Resultat4.Text = "*"
        FenetreTousLesElementsEtBarreDeRecherche.index_Resultat5.Text = "*"
        FenetreTousLesElementsEtBarreDeRecherche.index_Resultat6.Text = "*"
        FenetreTousLesElementsEtBarreDeRecherche.index_Resultat7.Text = "*"

        If (ListeDeResultats.LongCount >= 1) Then
            While (onContinueLaffichageDesResultats)

                Select Case jetonAttibuer
                    Case 1
                        FenetreTousLesElementsEtBarreDeRecherche.element_1.Text = ListeDeResultats(indexDansLaListeDeResultat).Signature1
                        FenetreTousLesElementsEtBarreDeRecherche.index_Resultat1.Text = indexDansLaListeDeResultat
                        numeroDuPremierResultatAfficher = indexDansLaListeDeResultat
                        numeroDuDernierResultatAfficher = indexDansLaListeDeResultat
                        If (indexDansLaListeDeResultat < ListeDeResultats.LongCount - 1) Then
                            indexDansLaListeDeResultat += 1
                            jetonAttibuer = 2
                        Else
                            indexDansLaListeDeResultat = 0
                            jetonAttibuer = 1
                            onContinueLaffichageDesResultats = False
                        End If
                    Case 2
                        FenetreTousLesElementsEtBarreDeRecherche.element_2.Text = ListeDeResultats(indexDansLaListeDeResultat).Signature1
                        FenetreTousLesElementsEtBarreDeRecherche.index_Resultat2.Text = indexDansLaListeDeResultat
                        numeroDuDernierResultatAfficher = indexDansLaListeDeResultat
                        If (indexDansLaListeDeResultat < ListeDeResultats.LongCount - 1) Then
                            indexDansLaListeDeResultat += 1
                            jetonAttibuer = 3
                        Else
                            indexDansLaListeDeResultat = 0
                            jetonAttibuer = 1
                            onContinueLaffichageDesResultats = False
                        End If
                    Case 3
                        FenetreTousLesElementsEtBarreDeRecherche.element_3.Text = ListeDeResultats(indexDansLaListeDeResultat).Signature1
                        FenetreTousLesElementsEtBarreDeRecherche.index_Resultat3.Text = indexDansLaListeDeResultat
                        numeroDuDernierResultatAfficher = indexDansLaListeDeResultat
                        If (indexDansLaListeDeResultat < ListeDeResultats.LongCount - 1) Then
                            indexDansLaListeDeResultat += 1
                            jetonAttibuer = 4
                        Else
                            indexDansLaListeDeResultat = 0
                            jetonAttibuer = 1
                            onContinueLaffichageDesResultats = False
                        End If
                    Case 4
                        FenetreTousLesElementsEtBarreDeRecherche.element_4.Text = ListeDeResultats(indexDansLaListeDeResultat).Signature1
                        FenetreTousLesElementsEtBarreDeRecherche.index_Resultat4.Text = indexDansLaListeDeResultat
                        numeroDuDernierResultatAfficher = indexDansLaListeDeResultat
                        If (indexDansLaListeDeResultat < ListeDeResultats.LongCount - 1) Then
                            indexDansLaListeDeResultat += 1
                            jetonAttibuer = 5
                        Else
                            indexDansLaListeDeResultat = 0
                            jetonAttibuer = 1
                            onContinueLaffichageDesResultats = False
                        End If
                    Case 5
                        FenetreTousLesElementsEtBarreDeRecherche.element_5.Text = ListeDeResultats(indexDansLaListeDeResultat).Signature1
                        FenetreTousLesElementsEtBarreDeRecherche.index_Resultat5.Text = indexDansLaListeDeResultat
                        numeroDuDernierResultatAfficher = indexDansLaListeDeResultat
                        If (indexDansLaListeDeResultat < ListeDeResultats.LongCount - 1) Then
                            indexDansLaListeDeResultat += 1
                            jetonAttibuer = 6
                        Else
                            indexDansLaListeDeResultat = 0
                            jetonAttibuer = 1
                            onContinueLaffichageDesResultats = False
                        End If
                    Case 6
                        FenetreTousLesElementsEtBarreDeRecherche.element_6.Text = ListeDeResultats(indexDansLaListeDeResultat).Signature1
                        FenetreTousLesElementsEtBarreDeRecherche.index_Resultat6.Text = indexDansLaListeDeResultat
                        numeroDuDernierResultatAfficher = indexDansLaListeDeResultat
                        If (indexDansLaListeDeResultat < ListeDeResultats.LongCount - 1) Then
                            indexDansLaListeDeResultat += 1
                            jetonAttibuer = 7
                        Else
                            indexDansLaListeDeResultat = 0
                            jetonAttibuer = 1
                            onContinueLaffichageDesResultats = False
                        End If
                    Case 7
                        FenetreTousLesElementsEtBarreDeRecherche.element_7.Text = ListeDeResultats(indexDansLaListeDeResultat).Signature1
                        FenetreTousLesElementsEtBarreDeRecherche.index_Resultat7.Text = indexDansLaListeDeResultat
                        numeroDuDernierResultatAfficher = indexDansLaListeDeResultat
                        onContinueLaffichageDesResultats = False
                        If (indexDansLaListeDeResultat < ListeDeResultats.LongCount - 1) Then
                            indexDansLaListeDeResultat += 1
                            jetonAttibuer = 1
                        Else
                            indexDansLaListeDeResultat = 0
                            jetonAttibuer = 1
                        End If
                End Select
            End While
        End If

    End Sub
    Public Sub afficherLesProchainsElements()

        '#######################################1à6 
        'ICI ON VEUT RECUPERER LE NUMERO DU RESULTAT SELECTIONNER AFIN DE SAVOIR S'IL S'AGIT DU DERNIER ELEMENT DE NOTRE LISTE >>AFFICHER<< JE DIS BIEN DE NOTRE LISTE AFFICHER 
        'CELLE QUE TU VOIS QUAND TU CLIQUE SUR DESCENDRE.
        'POUR CETTE DESCENTE LES NUMEROS DES BOUTTONS VONT DE 1 à 7 mais pour la montée ça va de 0 à 6.




        If (numeroDuDernierResultatAfficher = numeroDuResultatSelectionner) Then 'DONC SI ON A ATTEINT LE DERNIER RESULTAT DE NOTRE LISTE AFFICHER.
            onContinueLaffichageDesResultats = True
            afficherLesResultatsEnDescendantDansLaListeDeTousLesElements(listeDeResultatsDeLaRecherche)
        End If

        Select Case compteur2
            'On ne recupere les numeros actifs que s'il sont different de '*'
            Case 1
                numeroDuResultatSelectionner = IIf(FenetreTousLesElementsEtBarreDeRecherche.index_Resultat1.Text <> "*", FenetreTousLesElementsEtBarreDeRecherche.index_Resultat1.Text, -100)
            Case 2
                numeroDuResultatSelectionner = IIf(FenetreTousLesElementsEtBarreDeRecherche.index_Resultat2.Text <> "*", FenetreTousLesElementsEtBarreDeRecherche.index_Resultat2.Text, -100)
            Case 3
                numeroDuResultatSelectionner = IIf(FenetreTousLesElementsEtBarreDeRecherche.index_Resultat3.Text <> "*", FenetreTousLesElementsEtBarreDeRecherche.index_Resultat3.Text, -100)
            Case 4
                numeroDuResultatSelectionner = IIf(FenetreTousLesElementsEtBarreDeRecherche.index_Resultat4.Text <> "*", FenetreTousLesElementsEtBarreDeRecherche.index_Resultat4.Text, -100)
            Case 5
                numeroDuResultatSelectionner = IIf(FenetreTousLesElementsEtBarreDeRecherche.index_Resultat5.Text <> "*", FenetreTousLesElementsEtBarreDeRecherche.index_Resultat5.Text, -100)
            Case 6
                numeroDuResultatSelectionner = IIf(FenetreTousLesElementsEtBarreDeRecherche.index_Resultat6.Text <> "*", FenetreTousLesElementsEtBarreDeRecherche.index_Resultat6.Text, -100)
            Case 7
                numeroDuResultatSelectionner = IIf(FenetreTousLesElementsEtBarreDeRecherche.index_Resultat7.Text <> "*", FenetreTousLesElementsEtBarreDeRecherche.index_Resultat7.Text, -100)
        End Select

    End Sub
    Public Sub afficherLesElementsPrecedents()
        If (compteur2 = 0) Then 'ICI ON SE TROUVE SUR LE PREMIER BOUTTON IL LE FAUT SINON ON NE REMONTE PAS LA LISTE. ON NE FAIT RIEN DU TOUT.
            numeroDuResultatSelectionnerEnmontant = IIf(FenetreTousLesElementsEtBarreDeRecherche.index_Resultat1.Text <> "*", FenetreTousLesElementsEtBarreDeRecherche.index_Resultat1.Text, -100)
            If (numeroDuResultatSelectionnerEnmontant > 0) Then 'ICI ON AURA LA POSSIBILITE DE REMONTER LA LISTE DE NOS RESULTATS SI ON PAS SITUER SUR 0 , DONC LE TOUT PREMIER DE NOS RESULTATS.
                indexDansLaListeDeResultat = numeroDuResultatSelectionnerEnmontant - 7
                onContinueLaffichageDesResultats = True
                jetonAttibuer = 1
                afficherLesResultatsEnDescendantDansLaListeDeTousLesElements(listeDeResultatsDeLaRecherche)
            End If
        End If

        '##########
        'ICI IL EST JUSTE QUESTION DE METTRE A JOUR LE NUMERO SELECTIONNER , POUR L'UTILISER AU COURS DE NOS DESCENTE.
        Select Case compteur2
            'On ne recupere les numeros actifs que s'il sont different de '*'
            Case 0
                numeroDuResultatSelectionner = IIf(FenetreTousLesElementsEtBarreDeRecherche.index_Resultat1.Text <> "*", FenetreTousLesElementsEtBarreDeRecherche.index_Resultat1.Text, -100)
            Case 1
                numeroDuResultatSelectionner = IIf(FenetreTousLesElementsEtBarreDeRecherche.index_Resultat2.Text <> "*", FenetreTousLesElementsEtBarreDeRecherche.index_Resultat2.Text, -100)
            Case 2
                numeroDuResultatSelectionner = IIf(FenetreTousLesElementsEtBarreDeRecherche.index_Resultat3.Text <> "*", FenetreTousLesElementsEtBarreDeRecherche.index_Resultat3.Text, -100)
            Case 3
                numeroDuResultatSelectionner = IIf(FenetreTousLesElementsEtBarreDeRecherche.index_Resultat4.Text <> "*", FenetreTousLesElementsEtBarreDeRecherche.index_Resultat4.Text, -100)
            Case 4
                numeroDuResultatSelectionner = IIf(FenetreTousLesElementsEtBarreDeRecherche.index_Resultat5.Text <> "*", FenetreTousLesElementsEtBarreDeRecherche.index_Resultat5.Text, -100)
            Case 5
                numeroDuResultatSelectionner = IIf(FenetreTousLesElementsEtBarreDeRecherche.index_Resultat6.Text <> "*", FenetreTousLesElementsEtBarreDeRecherche.index_Resultat6.Text, -100)
            Case 6
                numeroDuResultatSelectionner = IIf(FenetreTousLesElementsEtBarreDeRecherche.index_Resultat7.Text <> "*", FenetreTousLesElementsEtBarreDeRecherche.index_Resultat7.Text, -100)
        End Select
        '#########
    End Sub
    Public Function supprimerUneInformationDeNosFichiers(numeroDeLinformationAsupprimer As Integer)

        Try

            Dim serialiseurDeSuppression As New XmlSerializer(GetType(List(Of informationARechercher)))
            Dim compteur = 0
            Dim tabNumeros(listeDinformations3.LongCount - 1) As Integer

            For Each elmt In listeDinformations3 'ON STOCKE
                'ICI ON STOCKE NOS INFORMATIONS DANS UN TABLEAU , LA RECUPERATION DU numero1 AVEC LA LISTE ET LE FOR POSE 
                'UN PROBLEME DONC ON VA JUSTE COPIER LA LISTE D'INFOS DANS UN TABLEAU ET VU QUE LES DEUX ONT LA MEME TAILLE ALORS 
                'LES ELEMENTS DE LA LISTE ET LES ELEMENTS DU TABLEAU SERONT STOCKER  AU MEME INDEX , DANS CETTE BOUCLE FOR ON VA METTRE DONC 
                'CHAQUE NUMERO1 DE CHAQUE ELEMENT DE LA LISTE DANS CHAQUE ELEMENT CORRESPONDANT DANS LE TABLEAU.
                tabNumeros(compteur) = elmt.Numero1
                compteur += 1
            Next

            For compteur = 0 To (listeDinformations3.LongCount - 1) 'ON SUPPRIME
                'ICI ON VA JUSTE SUPPRIMER DE LA LISTE, L'ELEMENT QUI A le numeroDeLinformationAsupprimer et VU QUE 
                'LES ELEMENTS DU TABLEAU ET LES DE LA LISTE ONT LES MEME INDEX , JE PEUX FAIRE LA COMPARAISON DANS LE TABLEAU AU LIEU DE LA FAIRE DANS LA LISTE.
                'C'EST UNE COPIE CA PRODUIRA LE MEME RESULTAT QUE SI J'AVAIS UTILISER LA LISTE(Mais on ne peut pas à cause du probleme cité plus haut.)
                If (tabNumeros(compteur) = numeroDeLinformationAsupprimer) Then
                    listeDinformations3.RemoveAt(compteur)
                End If
            Next

            'ON RESTOCKE DANS LE XML

            Dim fluxTemporaireDeSuppression As FileStream = New FileStream("Informations_Enregistrées.xml", FileMode.Create) 'ICI ON STOCKE LA NOUVELLE LISTE PRIVEE DE L'INFORMATION SUPPRIMEE
            If (listeDinformations3.LongCount <> 0) Then
                serialiseurDeSuppression.Serialize(fluxTemporaireDeSuppression, listeDinformations3)
            End If
            fluxTemporaireDeSuppression.Close()

            'ON RESTOCKE DANS LA LISTE

            Try
                fluxTemporaireDeSuppression = New FileStream("Informations_Enregistrées.xml", FileMode.Open)
                listeDinformations3 = serialiseurDeSuppression.Deserialize(fluxTemporaireDeSuppression) 'ICI ON RESTOCKE LES INFOS ENREGISTRER DANS LE FICHIER XML , DANS LA LISTE_DES_INFORMATIONS QUI SERA UTILISER AU COURS DU PROGRAMME.
                fluxTemporaireDeSuppression.Close()
            Catch ex As Exception
                fluxTemporaireDeSuppression.Close()
                'FenetreTousLesElementsEtBarreDeRecherche.Label1.Text = ex.ToString
            End Try

        Catch ex As Exception
            '    FenetreTousLesElementsEtBarreDeRecherche.Label1.Text = ex.ToString
        End Try


        Return listeDinformations3

    End Function

    ''' <summary>
    ''' On veut pouvoir utiliser le saut de ligne dans nos descriptions textuelles
    ''' c'est pour cela qu'on va d'abord transformer la dite description textuelle en code ASCII
    ''' Chaque caractere de la description textuelle sera transformer en code ASCII, même le saut de ligne(valeur ascii 13)
    ''' Donc etape 1 transformer la description textuelle en code ASCII
    '''      etape 2 trasformer le code ASCII  de la description en CARACTERES normaux.
    ''' </summary>
    ''' <param name="leTexte">Représente la description textuelle.</param>
    ''' leTexteTransformerEnAscii represente la description textuelle transformer en code ASCII.
    ''' C'est cette valeur qu'on va retourner.
    ''' Le ",0" c'est pour séparer les différentes valeurs ASCII par des virgules et puisque 013==13 le 0 nous empêche de terminer
    ''' notre chaîne avec un espace vide ce qui provoquerait une ERREUR!!Cool
    ''' <returns></returns>
    Public Function transformerDescriptionTextuelleEnCodeAscii(leTexte As String) As String

        Dim leTexteTransformerEnAscii As String = ""

        For Each elmt In leTexte
            leTexteTransformerEnAscii += CStr(Asc(elmt)) + ",0"
        Next
        Return leTexteTransformerEnAscii
    End Function
    ''' <summary>
    ''' Ici il est question de transformer les codes ASCII de la description textuelle en CARACTERES NORMAUX
    ''' </summary>
    ''' <param name="leTexteEnCodeAscii">Représente la description en codeASCII.</param>
    ''' <returns></returns>
    Public Function transformerDescriptionTextuelleEnCaractereNormaux(leTexteEnCodeAscii As String) As String
        Dim tabDeCodeAsccii() As String = leTexteEnCodeAscii.Split(",")
        Dim laDescriptionTextuelle As String = Nothing
        For Each elmt In tabDeCodeAsccii
            laDescriptionTextuelle += Chr(CInt(elmt))
        Next
        Return laDescriptionTextuelle
    End Function

    Public Sub ExplorerDesMedias(explorateurDeMedia As OpenFileDialog, cheminDacces As GunaLineTextBox)
        explorateurDeMedia.ShowDialog()
        cheminDacces.Text = explorateurDeMedia.FileName()
    End Sub
End Module

