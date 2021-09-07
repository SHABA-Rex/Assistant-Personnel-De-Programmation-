Imports System.Xml.Serialization
Imports System.IO
Public Class FenetreChargement

    Private Sub timer1_Tick(sender As Object, e As EventArgs) Handles timer1.Tick
        If (pgBar.Value < pgBar.Maximum) Then
            pgBar.Value += 1
        Else
            Me.Hide()
            FenetreTousLesElementsEtBarreDeRecherche.Show()
            timer1.Stop()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        timer1.Start()
        'ICI IL EST QUESTION DE CREER UN FICHIER DE SAUVEGARDE QUI VA PERMETTRE DE CONSERVER DES INFORMATIONS SUR ET NON CORROMPUES
        'POUR QUE SI JAMAIS LE FICHIER Informations_Enregistrées.xml EST CORROMPUS OU ALTERER OU MODIFIER SUPPRIMER ALORS 
        'LE FICHIER Sauvegarde_d'infos_nonCorrompues.xml PUISSE PRENDRE LE RELAIS ET CHARGER LES DERNIERES INFORMATIONS NON CORROMPUES
        'DANS Informations_Enregistrées.xml
        Dim fluxDeDeserialisation As FileStream = New FileStream("Sauvegarde_d'infos_nonCorrompues.xml", FileMode.OpenOrCreate)

        Try
            listeDinformationsSauvegarder = serialiseur.Deserialize(fluxDeDeserialisation)
        Catch ex As Exception

        End Try

        fluxDeDeserialisation.Close()

        'ICI ON TENTE DE RECUPERER LES ELEMENTS QUI SE TROUVE DANS LE FICHIER XML, SI CE FICHIER EST VIDE ALORS ON AURA UNE EXCEPTION LEVER , DONC AUCUNE INFOS 
        'NE SERA DESERIALIZER ,  SI LE FICHIER CONTIENT DES VALEURS ALORS ON VA POUVOIR DESERIALIZER ET STOCKER CES VALEURS DANS LA LISTE DES INFORMATIONS listeDinformations3.

        numeroDuResultatSelectionner = -100
        FenetreTousLesElementsEtBarreDeRecherche.laDate.Text = ""

        fluxDeDeserialisation = New FileStream("Informations_Enregistrées.xml", FileMode.OpenOrCreate)

        Try
            listeDinformations3 = serialiseur.Deserialize(fluxDeDeserialisation)
            'Label4.Text = listeDinformations3(1).Signature1
        Catch ex As Exception
            'SI ON ENTRE ICI C'EST QUE NOTRE FICHIER Informations_Enregistrées.xml NE POSSEDE AUCUN ELEMENTS(IL EST VIDE) 
            'CE QUI  PEUT ETRE LIEES A  DEUX CHOSES :
            '>SOIT ON N'A JAMAIS ENREGISTRER D'ELEMENTS DANS NOTRE FICHIER XML 
            '>SOIT LE FICHIER A ETE EFFACER A CAUSE D'UNE ERREUR RENCONTRER DANS SON CODE.:)
            'POUR CES DEUX CAS ON A UNE SOLUTION : CHARGER LE FICHIER DE SAUVEGARDE DANS Informations_Enregistrées.xml CECI SE FERA
            'EVIDEMENT SI LE FICHIER DE SAUVEGARDE POSSEDE BIEN DES ELEMENTS.
            'ON DEVRAIT LA CONDITION CI DESSOUS DANS CE CATH MAIS QUAND ILY'A UNE ERREUR DANS LE FICHIER(PREALABLEMENT REMPLI)  Informations_Enregistrées.xml 
            'ON NE REUSSIT PAS A ENTRER ICI JE SAIS PAS POURQUOI , MAIS LORSQUE LE FICHIER EST VIDE DES LE DEPART ON ENTRE ; MAIS
            'PEU IMPORTE CE CATCH VA EMPECHER LE PROGRAMME DE PLANTER EN CAS D'ERREUR DANS NOTRE FICHIER Informations_Enregistrées.xml
            'LE SI CI DESSOUS NOUS PERMET DE SAVOIR SI NOTRE Informations_Enregistrées.xml EST VIDE DANS CE CAS LA LA SAUVEGARDE
            'FAIT SON TRAVAIL SI ELLE POSSEDE BIEN DES INFORMATIONS.
        End Try

        If listeDinformations3.LongCount = 0 Then
            fluxDeDeserialisation.Close()
            fluxDeDeserialisation = New FileStream("Informations_Enregistrées.xml", FileMode.OpenOrCreate)
            If listeDinformationsSauvegarder.LongCount > 0 Then
                serialiseur.Serialize(fluxDeDeserialisation, listeDinformationsSauvegarder)
            End If
        End If

        fluxDeDeserialisation.Close()


        Dim fluxPourlesParametresDuTexte1 As FileStream = New FileStream("miseEnFormeDuTexte.xml", FileMode.OpenOrCreate)

        Try
            Dim parametreDinit As New parametresDuTexte()
            parametreDinit = serialiseurDesParametresTexte.Deserialize(fluxPourlesParametresDuTexte1)
            policeDuTexte = parametreDinit.Police1
            tailleDuTexte = parametreDinit.Taille1
            couleurDuFond = parametreDinit.CouleurFond1
            couleurDuTexte = parametreDinit.CouleurTexte1
            fluxPourlesParametresDuTexte1.Close()
        Catch ex As Exception
            fluxPourlesParametresDuTexte1.Close()
            Dim fluxPourlesParametresDuTexte2 As FileStream = New FileStream("miseEnFormeDuTexte.xml", FileMode.Create)
            Dim parametreDinitialisationDuTexte As New parametresDuTexte()
            serialiseurDesParametresTexte.Serialize(fluxPourlesParametresDuTexte2, parametreDinitialisationDuTexte)
            policeDuTexte = parametreDinitialisationDuTexte.Police1
            tailleDuTexte = parametreDinitialisationDuTexte.Taille1
            couleurDuFond = parametreDinitialisationDuTexte.CouleurFond1
            couleurDuTexte = parametreDinitialisationDuTexte.CouleurTexte1
            fluxPourlesParametresDuTexte2.Close()
        End Try


    End Sub
End Class
