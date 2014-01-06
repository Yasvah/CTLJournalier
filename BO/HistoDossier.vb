Public Class HistoDossier
#Region "Déclaration attribut"
    Private _emplacementDossier As String
    Private _taille As Integer
    Private _derniereModif As Date
    Private _nombreFichiers As Integer
    Private _dateSnapshot
#End Region
#Region "Propiété"
    ''' <summary>
    ''' Propiété sur l'emplacement du dossier
    ''' </summary>
    ''' <value></value>
    ''' <returns>le chemin du dossier en String</returns>
    ''' <remarks></remarks>
    Public Property EmplacementDossier As String
        Get
            Return _emplacementDossier
        End Get
        Set(ByVal value As String)
            _emplacementDossier = value
        End Set
    End Property
    ''' <summary>
    ''' Taille du dossier (avec ses sous dossier) en Octet
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Taille As Integer
        Get
            Return _taille
        End Get
        Set(ByVal value As Integer)
            _taille = value
        End Set
    End Property
    ''' <summary>
    ''' Date de la dernier modification du dossier au moment du snapshot
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property DerniereModif As Date
        Get
            Return _derniereModif
        End Get
        Set(ByVal value As Date)
            _derniereModif = value
        End Set
    End Property
    ''' <summary>
    ''' Nombre de fichier present dans le dossier (avec l'exploration des sous dossiers)
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property NombreDeFichier As Integer
        Get
            Return _nombreFichiers
        End Get
        Set(ByVal value As Integer)
            _nombreFichiers = value
        End Set
    End Property
    ''' <summary>
    ''' Date à la quelle le snaptsnot du dossier a été pris
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property DateSnapshot As Date
        Get
            Return _dateSnapshot
        End Get
        Set(ByVal value As Date)
            _dateSnapshot = value
        End Set
    End Property

#End Region
#Region "Constructeur"
    ''' <summary>
    ''' Constructeur HistoDossier. cette classe permet de stocker les historique sur un dossier taille, nombre de fichier date de derniere modification
    ''' </summary>
    ''' <param name="EmplacementDuDossier">Emplacement du dossier</param>
    ''' <param name="TailleDuDossier"></param>
    ''' <param name="DateDernierModif"></param>
    ''' <param name="NombreDeFichier"></param>
    ''' <param name="DateDuSnapshot"></param>
    ''' <remarks></remarks>
    Sub New(EmplacementDuDossier As String, TailleDuDossier As Integer, DateDernierModif As Date, NombreDeFichier As Integer, DateDuSnapshot As Date)
        Me.EmplacementDossier = EmplacementDuDossier
        Me.Taille = TailleDuDossier
        Me.DerniereModif = DateDernierModif
        Me.NombreDeFichier = NombreDeFichier
        Me.DateSnapshot = DateDuSnapshot
    End Sub

#End Region

End Class
