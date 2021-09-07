
<Serializable>
Public Class parametresDuTexte
    Private police As String
    Private couleurTexte As String
    Private couleurFond As String
    Private taille As String

    Public Property Police1 As String
        Get
            Return police
        End Get
        Set(value As String)
            police = value
        End Set
    End Property

    Public Property CouleurTexte1 As String
        Get
            Return couleurTexte
        End Get
        Set(value As String)
            couleurTexte = value
        End Set
    End Property

    Public Property CouleurFond1 As String
        Get
            Return couleurFond
        End Get
        Set(value As String)
            couleurFond = value
        End Set
    End Property

    Public Property Taille1 As String
        Get
            Return taille
        End Get
        Set(value As String)
            taille = value
        End Set
    End Property
    Sub New()
        Police1 = "Segoe UI"
        Taille1 = 12
        CouleurTexte1 = "Black"
        CouleurFond1 = "White"
    End Sub

    Public Sub New(police As String, couleurTexte As String, couleurFond As String, taille As String)
        Police1 = police
        CouleurTexte1 = couleurTexte
        CouleurFond1 = couleurFond
        Taille1 = taille
    End Sub
End Class
