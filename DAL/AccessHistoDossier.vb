Imports BO
Imports System.Xml.XPath
Imports System.Xml

Public Class AccessHistoDossier

    Dim documentXML As XmlDocument

#Region "Pattern de singleton"
    Private Shared _instance As New AccessHistoDossier()

    Private Sub New()
    End Sub

    Public Shared Function getInstance() As AccessHistoDossier
        Return _instance
    End Function
#End Region
    ''' <summary>
    ''' Charge le fichier XML
    ''' </summary>
    ''' <param name="cheminXML"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function chargerXML(ByVal cheminXML As String) As XmlDocument
        chargerXML = New XmlDocument()
        chargerXML.Load(cheminXML)
    End Function

    Public Function creationNavigateurXML(ByVal paramtreRecherche As String, ByVal cheminXML As String) As XPathNodeIterator
        documentXML = chargerXML(cheminXML)
        Dim navigateur As XPathNavigator = documentXML.CreateNavigator()
        Dim noeuds As XPathNodeIterator = navigateur.Select(paramtreRecherche)
        Return noeuds
    End Function
    ''' <summary>
    ''' Parcour l'arborescence du fichier xml et retourne une liste de HistoDossier
    ''' </summary>
    ''' <param name="cheminXML"></param>
    ''' <returns>Liste des HistoDossier du fichier XML</returns>
    ''' <remarks></remarks>
    Public Function ChargerHistoDossier(ByVal cheminXML As String)
        Dim noeuds As XPathNodeIterator = creationNavigateurXML("/HistorisationDossier/HistoDossier", cheminXML)
        Dim CheminDossier As String
        Dim taille As Integer
        Dim DerniereModif As Date
        Dim nombreFichier As Integer
        Dim dateSnapshot As Date
        Dim ListHistoDossier As List(Of HistoDossier)
        'Parcour le fichier et ajoute les Objects DossierHisto dans une liste
        While noeuds.MoveNext()
            noeuds.Current.MoveToChild("CheminDossier", "")
            CheminDossier = noeuds.Current.Value
            noeuds.Current.MoveToParent()
            noeuds.Current.MoveToChild("taille", "")
            taille = noeuds.Current.ValueAsDouble
            noeuds.Current.MoveToParent()
            noeuds.Current.MoveToChild("DerniereModif", "")
            DerniereModif = noeuds.Current.Value
            noeuds.Current.MoveToParent()
            noeuds.Current.MoveToChild("Nombrefichier", "")
            nombreFichier = noeuds.Current.Value
            noeuds.Current.MoveToParent()
            noeuds.Current.MoveToChild("DateSnapshot", "")
            dateSnapshot = noeuds.Current.Value
            ListHistoDossier.Add(New HistoDossier(CheminDossier, taille, DerniereModif, nombreFichier, dateSnapshot))
        End While
        Return ListHistoDossier
    End Function

    ''' <summary>
    ''' Ajouter un snapshot d'un dossier dans le fichier XML
    ''' </summary>
    ''' <param name="HistoDossier"></param>
    ''' <param name="cheminXML">le chemin du fichier XML</param>
    ''' <remarks></remarks>
    Public Sub ajouterHistoDossier(HistoDossier As HistoDossier, cheminXML As String)
        Dim noeuds As XPathNodeIterator = creationNavigateurXML("/HistorisationDossier/HistoDossier", cheminXML)
        noeuds.MoveNext()
        noeuds.Current.InsertElementAfter("", "HistoDossier", "", "")
        '' On se place sur le noeud ainsi créé. */
        noeuds.Current.MoveToNext(XPathNodeType.Element)
        noeuds.Current.CreateAttribute("", "id", "", Guid.NewGuid.ToString)
        noeuds.Current.AppendChildElement("", "CheminDossier", "", HistoDossier.EmplacementDossier)
        noeuds.Current.AppendChildElement("", "taille", "", HistoDossier.Taille)
        noeuds.Current.AppendChildElement("", "DerniereModif", "", HistoDossier.DerniereModif)
        noeuds.Current.AppendChildElement("", "Nombrefichier", "", HistoDossier.NombreDeFichier)
        noeuds.Current.AppendChildElement("", "DateSnapshot", "", HistoDossier.DateSnapshot)
        documentXML.Save(cheminXML)
    End Sub
End Class
