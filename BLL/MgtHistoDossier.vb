Imports BO

Public Class MgtHistoDossier
#Region "Pattern de singleton"
    Private Shared _instance As New MgtHistoDossier()

    Private Sub New()
    End Sub

    Public Shared Function getInstance() As MgtHistoDossier
        Return _instance
    End Function
#End Region

#Region "Attribut"
    Public listHistoDossier As List(Of HistoDossier)

#End Region
#Region "Méthodes"



    Public Sub AjouterHistoDossier(HistoDossier)

    End Sub
    Public Function ChargerHistoDossier() As List(Of HistoDossier)

    End Function
#End Region


End Class
