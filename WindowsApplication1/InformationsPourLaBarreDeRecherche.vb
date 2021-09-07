Imports System.Runtime.Serialization.Formatters.Binary
Imports System.IO

Public Class InformationsPourLaBarreDeRecherche
    Private Sub Fermer_Click(sender As Object, e As EventArgs) Handles Fermer.Click
        nomElement.Text = ""
        categorieElement.Text = ""
        lesMotsCler.Text = ""
        Close()
        FenetreTousLesElementsEtBarreDeRecherche.Show()
    End Sub

    Private Sub nomElement_TextChanged(sender As Object, e As EventArgs) Handles nomElement.TextChanged
        If (nomElement.Text.Length > 0) Then
            image1.Image = WindowsApplication1.My.Resources.Resources.checked_50px
        Else
            image1.Image = WindowsApplication1.My.Resources.Resources.cancel_50px
        End If
    End Sub

    Private Sub categorieElement_TextChanged(sender As Object, e As EventArgs) Handles categorieElement.TextChanged
        If (categorieElement.Text.Length > 0) Then
            image2.Image = WindowsApplication1.My.Resources.Resources.checked_50px
        Else
            image2.Image = WindowsApplication1.My.Resources.Resources.cancel_50px
        End If
    End Sub

    Private Sub lesMotsCler_TextChanged(sender As Object, e As EventArgs) Handles lesMotsCler.TextChanged
        If (lesMotsCler.Text.Length >= 2) Then
            If (lesMotsCler.Text(lesMotsCler.Text.Length - 1) = "." Or lesMotsCler.Text(lesMotsCler.Text.Length - 1) = ",") Then 'SI ON POSSEDE AU MOINS DEUX CARACTERES ET QUE LE DERNIER EST UN POINT OUNE VIRGULE ALORS ON MET LE JUSTE SINON C'EST LA CROIX.
                image3.Image = WindowsApplication1.My.Resources.Resources.checked_50px
            Else
                image3.Image = WindowsApplication1.My.Resources.Resources.cancel_50px
            End If
        Else
            image3.Image = WindowsApplication1.My.Resources.Resources.cancel_50px
        End If
    End Sub

    Private Sub annuler_Click(sender As Object, e As EventArgs) Handles annuler.Click
        nomElement.Text = ""
        categorieElement.Text = ""
        lesMotsCler.Text = ""
        Close()
        FenetreTousLesElementsEtBarreDeRecherche.Show()
    End Sub

    Private Sub continuer_Click(sender As Object, e As EventArgs) Handles continuer.Click
        'Dim informationAEnregistrer As New informationARechercher()

        'Dim listeDinformations2 As New List(Of informationARechercher)
        'informationPourInitialisation.Signature1 = nomElement.Text
        'informationPourInitialisation.Categorie1 = categorieElement.Text
        'informationPourInitialisation.DateDeCreation1 = Date.Today
        'informationPourInitialisation.TableauMotCles1 = tableauMotCles
        'listeDinformations2.Add(informationPourInitialisation)
        tableauMotCles = stockerLesMotsCles(lesMotsCler.Text) 'DANS LA FONCTION ON VA VERIFIER SI ON A MIS LE POINT(OU LA VIRGULE) DANS NOS MOTS CLES.

        If (onAMisUnPointAlaFinDesMotsCle) Then 'DANS LE CAS ON A MIS UN POINT SUR NOS MOTS CLES ALORS ON PEUT AGIR NORMALEMENT(ENREGISTRER OU PAS NOS ELEMENTS)
            If (nomElement.Text = "" Or categorieElement.Text = "" Or lesMotsCler.Text = "." Or lesMotsCler.Text = ",") Then
                MsgBox("REMPLISSEZ TOUS LES CHAMPS !", MsgBoxStyle.Information, Title:="INFORMATION")
            Else
                nomDeLelement = nomElement.Text
                categorieDeLelement = categorieElement.Text
                ''ON VA METTRE TOUT CECI A LA FIN DE L'ENREGISTREMENT DE NOTRE ELEMENT.####
                'fluxDeSerialisation = New FileStream("Informations_Enregistrées.xml", FileMode.OpenOrCreate)
                ''tableauMotCles = stockerLesMotsCles(lesMotsCler.Text)
                'informationAEnregistrer.Signature1 = InformationsPourLaBarreDeRecherche.nomElement.Text
                'informationAEnregistrer.Categorie1 = InformationsPourLaBarreDeRecherche.categorieElement.Text
                'informationAEnregistrer.DateDeCreation1 = Date.Today
                'informationAEnregistrer.TableauMotCles1 = tableauMotCles
                'informationAEnregistrer.DescriptionTextuelle1 = descriptionTextuelleDeLelement
                'informationAEnregistrer.ListeDePathDesImages1 = listeDePathDesImages
                'informationAEnregistrer.ListeDePathDesMusiques1 = listeDePathDeMusiques
                'listeDinformations3.Add(informationAEnregistrer)
                'serialiseur.Serialize(fluxDeSerialisation, listeDinformations3)
                'fluxDeSerialisation.Close()
                '#######TOUT CECI EN HAUT !
                Close()
                DescriptionAudio.Show()
            End If
        Else
            'DANS CE CAS CI ON N'A PAS MIS DE POINT A LA FIN DE NOS MOTS CLES.
            MsgBox("Mettez une virgule ou un point à la fin de votre liste de mots clés !", MsgBoxStyle.Exclamation, Title:="IMPORTANT")
        End If


    End Sub

    Private Sub InformationsPourLaBarreDeRecherche_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        laDate.Text = "Créé le " & Date.Today
    End Sub

    Private Sub aide_MouseHover(sender As Object, e As EventArgs) Handles aide.MouseHover
        aideSupport.Visible = True
    End Sub

    Private Sub aide_MouseLeave(sender As Object, e As EventArgs) Handles aide.MouseLeave
        aideSupport.Visible = False
    End Sub

    Private Sub Reduire_Click(sender As Object, e As EventArgs) Handles Reduire.Click
        WindowState = FormWindowState.Minimized
    End Sub

End Class