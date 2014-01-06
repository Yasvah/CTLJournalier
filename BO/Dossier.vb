Imports System.IO
''' <summary>
''' Cette classe est la réprensation d'un dossier
''' </summary>
''' <remarks></remarks>
Public Class Dossier

#Region "Déclaration attribut"
    Private _idGuid As Guid
    Private _ArbreDossier As DirectoryInfo
    Private _numOrdre As Integer
#End Region
#Region "Propiété"
    ''' <summary>
    ''' Retourne ou affecter les information d'un dossier
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ArbreDossier As DirectoryInfo
        Get
            Return _ArbreDossier
        End Get
        Set(value As DirectoryInfo)
            _ArbreDossier = value
        End Set
    End Property
    ''' <summary>
    ''' Retourne le nombre de fichier présent dans le dossier
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property NBFichier As Integer
        Get
            Return NombreDeFichier(ArbreDossier)
        End Get
    End Property
    ''' <summary>
    ''' Retoune la taille du dossier en octet
    ''' </summary>
    ''' <value></value>
    ''' <returns>Taille en octet</returns>
    ''' <remarks></remarks>
    Public ReadOnly Property TailleDossier As Long
        Get
            Return TailleDuDossier(ArbreDossier)
        End Get
    End Property
    ''' <summary>
    ''' Retourne la date de la dernière modifacation
    ''' </summary>
    ''' <value></value>
    ''' <returns>Modifié le</returns>
    ''' <remarks></remarks>
    Public ReadOnly Property DateModification As Date
        Get
            Return DerniereEcriture(ArbreDossier)
        End Get
    End Property
    ''' <summary>
    ''' Retourne la taille et le nombre de fichier présent dans le dossier sous une chaine de caractère
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property TailleEtNombreFichier As String
        Get
            Return TailleEtNBFichier(ArbreDossier)
        End Get
    End Property
    ''' <summary>
    ''' Attribuer ou avoir l'identification du dossier
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property identification As Guid
        Get
            Return _idGuid
        End Get
        Set(value As Guid)
            _idGuid = value
        End Set
    End Property
    ''' <summary>
    ''' Attribue ou retourne le numéro d'ordre
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property numOrdre As Integer
        Get
            Return _numOrdre
        End Get
        Set(value As Integer)
            _numOrdre = value
        End Set
    End Property

#End Region

#Region "Constructeur"
    Public Sub New(CheminDossier As String, identification As Guid, numOrdre As Integer)
        Me.ArbreDossier = New DirectoryInfo(CheminDossier)
        Me.identification = identification
        Me.numOrdre = numOrdre
    End Sub
    Public Sub New()
    End Sub
#End Region
#Region "Méthodes"
    ''' <summary>
    ''' Retourne un String avec la taille et le nombre de fichier dans le dossier
    ''' </summary>
    ''' <param name="Dossier">Dossier</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function TailleEtNBFichier(Dossier As DirectoryInfo) As String
        Dim Resultat As String
        Resultat = ConvertSizeFile(TailleDossier)
        Resultat = Resultat & " (" & NBFichier & ")"
        Return Resultat
    End Function

    ''' <summary>
    ''' Fonction qui compte le nombre de fichier dans le dossier en paramètre
    ''' </summary>
    ''' <param name="Dossier">Dossier</param>
    ''' <returns>Nombre de fichier présent</returns>
    ''' <remarks></remarks>
    Private Function NombreDeFichier(Dossier As DirectoryInfo) As Integer
        Return Dossier.GetFiles("*.*", SearchOption.AllDirectories).Count()
    End Function
    ''' <summary>
    ''' Fonction qui calcule la taille des fichiers present dans le dossier et ses sous-dossier
    ''' </summary>
    ''' <param name="Dossier"></param>
    ''' <returns>Taille en octet</returns>
    ''' <remarks></remarks>
    Private Function TailleDuDossier(Dossier As DirectoryInfo) As Long
        Dim size As Long
        For Each File In Dossier.GetFiles("*.*", SearchOption.AllDirectories)
            size += File.Length
        Next
        Return size
    End Function
    ''' <summary>
    ''' Retune la date de la derniere Ecriture dans le fichier
    ''' </summary>
    ''' <param name="Dossier">Le dossier</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function DerniereEcriture(Dossier As DirectoryInfo) As Date
        Return Dossier.LastWriteTime()
    End Function

    ''' <summary>
    ''' Converti une taille exprimée en octet en une chaine formattée
    ''' </summary>
    ''' <param name="Entier">Taille en octet</param>
    ''' <returns>Chaine formattée avec l'unité</returns>    
    Private Function ConvertSizeFile(ByVal Entier As Long) As String

        If (Entier >= &H10000000000) Then
            Return String.Format("{0:N2} To", Entier / &H10000000000)
        ElseIf (Entier >= &H40000000) Then
            Return String.Format("{0:N2} Go", Entier / &H40000000)
        ElseIf (Entier >= &H100000) Then
            Return String.Format("{0:N2} Mo", Entier / &H100000)
        ElseIf (Entier >= &H400) Then
            Return String.Format("{0:N2} Ko", Entier / &H400)
        Else
            Return String.Format("{0} oc", Entier)
        End If

    End Function
#End Region
End Class
