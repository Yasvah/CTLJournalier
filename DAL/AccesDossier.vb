Imports BO
Imports System.IO
Imports System.Xml.Serialization
Imports System.Xml
Imports System.Xml.XPath

Public Class AccesDossier

#Region "Pattern de singleton"
    Private Shared _instance As New AccesDossier()
    Private documentXML As XmlDocument

    Private Sub New()
    End Sub

    Public Shared Function getInstance() As AccesDossier
        Return _instance
    End Function
#End Region

#Region "Propriété"


#End Region
    Public Function ChargerListeDossier(cheminXML As String) As List(Of Dossier)
        Dim noeuds As XPathNodeIterator = creationNavigateurXML("/AllDossier/Dossier", cheminXML)
        Dim lesDossier As New List(Of Dossier)
        'Parcour le fichier et ajoute les Objects DossierHisto dans une liste
        While noeuds.MoveNext()
            Dim unDossier As Dossier
            Dim id As Guid
            Dim numOrdre As Integer
            Dim cheminDossier As String
            id = New Guid(noeuds.Current.GetAttribute("id", ""))
            noeuds.Current.MoveToChild("CheminDossier", "")
            cheminDossier = noeuds.Current.Value
            noeuds.Current.MoveToNextAttribute()
            'numOrdre = noeuds.Current.Value
            unDossier = New Dossier(cheminDossier, id, 0)
            lesDossier.Add(unDossier)
        End While
        Console.WriteLine(lesDossier.ToString)
        Return lesDossier
    End Function
    ''' <summary>
    ''' Ajoute un dossier au fichier XML
    ''' </summary>
    ''' <param name="EmplacementDossier">le chemin du dossier</param>
    ''' <param name="identification">le GUID du dossier</param>
    ''' <param name="cheminXML">Le chemin du fichier XML</param>
    ''' <remarks></remarks>
    Public Sub AjouterDossier(EmplacementDossier As String, identification As Guid, cheminXML As String, numOrdre As Integer)
        Dim noeuds As XPathNodeIterator = creationNavigateurXML("/AllDossier/Dossier", cheminXML)
        noeuds.MoveNext()
        noeuds.Current.InsertElementAfter("", "Dossier", "", "")
        '' On se place sur le noeud ainsi créé. */
        noeuds.Current.MoveToNext(XPathNodeType.Element)
        noeuds.Current.CreateAttribute("", "id", "", identification.ToString)
        noeuds.Current.AppendChildElement("", "CheminDossier", "", EmplacementDossier)
        'noeuds.Current.CreateAttribute("", "numOrdre", "", numOrdre.ToString)
        documentXML.Save(cheminXML)
    End Sub

    Public Sub supprimerDossier(dossier As Dossier, cheminXML As String)
        Dim noeuds As XPathNodeIterator = creationNavigateurXML("/", cheminXML)
        noeuds.Current.SelectSingleNode("/AllDossier/Dossier[@id = '" + dossier.identification.ToString + "']").DeleteSelf()
        documentXML.Save(cheminXML)
    End Sub
    ''' <summary>
    ''' Charger le document XML qui contient les informations sur les dossier à charger
    ''' </summary>
    ''' <param name="cheminXML">Le chemin du fichier XML</param>
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
    ''' Modifier un dissier dans le fichier XML (Le GUID sert d'identification)
    ''' </summary>
    ''' <param name="dossier">Le dossier modifié</param>
    ''' <param name="CheminXML">Le chemin du fichier XML</param>
    ''' <remarks></remarks>
    Public Sub modifierDossier(dossier As Dossier, CheminXML As String)
        Dim noeuds As XPathNodeIterator = creationNavigateurXML("/", CheminXML)
        Dim Nodes As XPathNodeIterator
        Nodes = noeuds.Current.Select("/AllDossier/Dossier[@id = '" + dossier.identification.ToString + "']")
        Nodes.MoveNext()
        Nodes.Current.MoveToFirstChild()
        Nodes.Current.SetValue(dossier.ArbreDossier.Name)

        documentXML.Save(CheminXML)
    End Sub

End Class
