Imports BO
Imports DAL
Imports System.Xml.Serialization
Imports System.IO

Public Class MgtDossierSERTA
#Region "Pattern de singleton"
    Private Shared _instance As New MgtDossierSERTA()

    Private Sub New()
    End Sub

    Public Shared Function getInstance() As MgtDossierSERTA
        Return _instance
    End Function
#End Region
#Region "Déclaration attribut"
    Dim _ListDossier As List(Of Dossier) = New List(Of Dossier)
#End Region
#Region "Propiété"

    ''' <summary>
    ''' Retourne la liste des dossier
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property ListeDossier As List(Of Dossier)
        Get
            Return _ListDossier
        End Get
    End Property
#End Region
#Region "Méthodes"

    ''' <summary>
    ''' Ajouter un dossier à la liste des dossiers
    ''' </summary>
    ''' <param name="CheminDossier">Le chemin du dossier à ajouter</param>
    ''' <returns>Retourne la liste des dossiers</returns>
    ''' <remarks></remarks>
    Public Function AjouterDossier(CheminDossier As String, CheminXMLFichier As String) As List(Of Dossier)
        Dim newId As Guid = Guid.NewGuid
        'AccesDossier.getInstance.AjouterDossier(CheminDossier, newId, CheminXMLFichier, _ListDossier.Count)
        _ListDossier.Add(New Dossier(CheminDossier, newId, _ListDossier.Count))
        Return _ListDossier
    End Function
    ''' <summary>
    ''' Charge la liste des dossiers présent dans un fichier XML
    ''' </summary>
    ''' <param name="CheminXMLFichier"></param>
    ''' <remarks></remarks>
    Public Function chargerDossier(CheminXMLFichier As String) As List(Of Dossier)
        _ListDossier = AccesDossier.getInstance.ChargerListeDossier(CheminXMLFichier)
        Return _ListDossier
    End Function

    Public Sub supprimerDossier(NomDossier As String, CheminXMLFichier As String)
        Dim DossierAtDelete As Dossier
        DossierAtDelete = ListeDossier.Find(Function(dossier As Dossier) dossier.ArbreDossier.Name = NomDossier)
        'AccesDossier.getInstance.supprimerDossier(DossierAtDelete, CheminXMLFichier)
        ListeDossier.Remove(DossierAtDelete)
    End Sub

    Public Sub modifierDossier(dossier As Dossier, cheminXML As String)
        Dim modifierDossier As Dossier

    End Sub

    Public Sub upOrdreDossier(nomDossier As String, cheminFichierXML As String)

    End Sub

    Public Sub downOrdreDossier(nomdossier As String, cheminFichierXML As String)

    End Sub

    Public Sub serialiser()
        Dim xs As New XmlSerializer(GetType(List(Of Dossier)))
        Using wr As New StreamWriter("contactBook.xml")
            xs.Serialize(wr, ListeDossier)
        End Using

    End Sub


#End Region
End Class
