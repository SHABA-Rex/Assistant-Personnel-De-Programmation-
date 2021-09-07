Imports WindowsApplication1

<Serializable>
Public Class informationARechercher
    Private signature As String
    Private categorie As String
    Private dateDeCreation As String
    Private tableauMotCles() As String
    Private descriptionTextuelle As String
    Private listeDePathDesMusiques As List(Of String)
    Private listeDePathDesImages As List(Of String)
    Private numero As Integer

    Sub New()

    End Sub

    Sub New(signature As String, categorie As String, dateDeCreation As String, tableauMotCles() As String, listeDesMusiques As List(Of String), listeDesImages As List(Of String), descriptionTextuelle As String)
        Signature1 = signature
        Categorie1 = categorie
        DateDeCreation1 = dateDeCreation
        TableauMotCles1 = tableauMotCles
        ListeDePathDesMusiques1 = listeDesMusiques
        ListeDePathDesImages1 = listeDesImages
        DescriptionTextuelle1 = descriptionTextuelle
    End Sub

    Public Property Signature1 As String
        Get
            Return signature
        End Get
        Set(value As String)
            signature = value
        End Set
    End Property

    Public Property Categorie1 As String
        Get
            Return categorie
        End Get
        Set(value As String)
            categorie = value
        End Set
    End Property

    Public Property DateDeCreation1 As String
        Get
            Return dateDeCreation
        End Get
        Set(value As String)
            dateDeCreation = value
        End Set
    End Property

    Public Property TableauMotCles1 As String()
        Get
            Return tableauMotCles
        End Get
        Set(value As String())
            tableauMotCles = value
        End Set
    End Property



    Public Property DescriptionTextuelle1 As String
        Get
            Return descriptionTextuelle
        End Get
        Set(value As String)
            descriptionTextuelle = value
        End Set
    End Property

    Public Property ListeDePathDesMusiques1 As List(Of String)
        Get
            Return listeDePathDesMusiques
        End Get
        Set(value As List(Of String))
            listeDePathDesMusiques = value
        End Set
    End Property

    Public Property ListeDePathDesImages1 As List(Of String)
        Get
            Return listeDePathDesImages
        End Get
        Set(value As List(Of String))
            listeDePathDesImages = value
        End Set
    End Property

    Public Property Numero1 As Integer
        Get
            Return numero
        End Get
        Set(value As Integer)
            numero = value
        End Set
    End Property
End Class
