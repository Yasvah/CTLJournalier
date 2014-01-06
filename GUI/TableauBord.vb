Imports CodeControleJourna

Public Class TableauBord
    Dim ListAffichageGridViewTransfere As List(Of AffichageDataGrid) = New List(Of AffichageDataGrid)
    Dim ListAffichageGridViewSERTA As List(Of AffichageDataGrid) = New List(Of AffichageDataGrid)

    Private Sub Form1_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        ChargerDataGridViewTransfere()
        ChargerDataGridViewSerta()
    End Sub
#Region "Transfere"
    Private Sub ChargerDataGridViewTransfere()
        DataGridViewTransfere.DataSource = ""
        ListAffichageGridViewTransfere.Clear()
        For Each unDossier As Dossier In MgtTransfere.getInstance.listeDossiers
            ListAffichageGridViewTransfere.Add(New AffichageDataGrid(unDossier.ArbreDossier.Name, unDossier.TailleEtNombreFichier, unDossier.numOrdre))
        Next
        DataGridViewTransfere.DataSource = ListAffichageGridViewTransfere
    End Sub

    Private Class AffichageDataGrid
        Dim _NomDossier As String
        Dim _InfoDossier As String
        Dim _numOrdre As Integer
        Public ReadOnly Property numOrdre
            Get
                Return _numOrdre
            End Get
        End Property
        Public ReadOnly Property NomDossier
            Get
                Return _NomDossier
            End Get
        End Property
        Public ReadOnly Property InfoDossier
            Get
                Return _InfoDossier
            End Get
        End Property

        Sub New(NomDossier As String, InfoDossier As String, numOrdre As Integer)
            Me._NomDossier = NomDossier
            Me._InfoDossier = InfoDossier
            Me._numOrdre = numOrdre
        End Sub
    End Class
    ''' <summary>
    ''' Ajouter un dossier SERTA
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub AddPNSSERTA_Click(sender As Object, e As EventArgs) Handles AddPNSSERTA.Click
        Dim cheminDossier As String
        Dim dialogFolderBox As New DialogOpenFolder
        If dialogFolderBox.ShowDialog() = Windows.Forms.DialogResult.OK Then
            cheminDossier = dialogFolderBox.CheminFolder.Text
            MgtTransfere.getInstance.ajouter(cheminDossier)
            ChargerDataGridViewTransfere()
        End If
    End Sub
    ''' <summary>
    ''' Supprimer un dossier PNS
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub RemoveSERTAPNS_Click(sender As Object, e As EventArgs) Handles RemoveSERTAPNS.Click
        Dim ligneSelectionner As DataGridViewSelectedRowCollection
        ligneSelectionner = DataGridViewTransfere.SelectedRows()
        If (ligneSelectionner.Count > 0) Then
            If MsgBox("Voulez-vous supprimer la selection?", MsgBoxStyle.OkCancel) Then
                For Each uneLigne As DataGridViewRow In ligneSelectionner
                    MgtTransfere.getInstance.supprimer(MgtTransfere.getInstance.rechercherDossier(uneLigne.Cells.Item(1).Value.ToString))
                Next
                ChargerDataGridViewTransfere()
            End If
        End If
    End Sub
    Private Sub UpTransfere_Click(sender As Object, e As EventArgs) Handles UpTransfere.Click
        Dim ligneSelectionner As DataGridViewSelectedRowCollection
        ligneSelectionner = DataGridViewTransfere.SelectedRows()
        If (ligneSelectionner.Count > 0) Then
            For Each uneLigne As DataGridViewRow In ligneSelectionner
                MgtTransfere.getInstance.monter(MgtTransfere.getInstance.rechercherDossier(uneLigne.Cells.Item(1).Value.ToString))
            Next
            ChargerDataGridViewTransfere()
        End If
    End Sub
    Private Sub DownTransfere_Click(sender As Object, e As EventArgs) Handles DownTransfere.Click
        Dim ligneSelectionner As DataGridViewSelectedRowCollection
        ligneSelectionner = DataGridViewTransfere.SelectedRows()
        If (ligneSelectionner.Count > 0) Then
            For Each uneLigne As DataGridViewRow In ligneSelectionner
                MgtTransfere.getInstance.descendre(MgtTransfere.getInstance.rechercherDossier(uneLigne.Cells.Item(1).Value.ToString))
            Next
            ChargerDataGridViewTransfere()
        End If
    End Sub
#End Region
#Region "Serta"
    Private Sub ChargerDataGridViewSerta()
        ListAffichageGridViewSERTA.Clear()
        DataGridViewSERTA.DataSource = ""
        For Each Dossier In MgtSerta.getInstance.listeDossiers
            ListAffichageGridViewSERTA.Add(New AffichageDataGrid(Dossier.ArbreDossier.Name, Dossier.TailleEtNombreFichier, Dossier.numOrdre))
        Next
        DataGridViewSERTA.DataSource = ListAffichageGridViewSERTA
    End Sub


    Private Sub AddRepertoireSERTA_Click(sender As Object, e As EventArgs) Handles AddRepertoireSERTA.Click
        Dim cheminDossier As String
        Dim dialogFolderBox As New DialogOpenFolder
        If dialogFolderBox.ShowDialog() = Windows.Forms.DialogResult.OK Then
            cheminDossier = dialogFolderBox.CheminFolder.Text
            MgtSerta.getInstance.ajouter(cheminDossier)
            ChargerDataGridViewSerta()
        End If
    End Sub

    Private Sub RemoveRepertoireSERTA_Click(sender As Object, e As EventArgs) Handles RemoveRepertoireSERTA.Click
        Dim ligneSelectionner As DataGridViewSelectedRowCollection
        ligneSelectionner = DataGridViewSERTA.SelectedRows()
        If (ligneSelectionner.Count > 0) Then
            If MsgBox("Voulez-vous supprimer la selection?", MsgBoxStyle.OkCancel) Then
                For Each uneLigne As DataGridViewRow In ligneSelectionner
                    MgtSerta.getInstance.supprimer(MgtSerta.getInstance.rechercherDossier(uneLigne.Cells.Item(1).Value.ToString))
                Next
                ChargerDataGridViewSerta()
            End If
        End If
    End Sub
    Private Sub UpSERTA_Click(sender As Object, e As EventArgs) Handles UpSERTA.Click
        Dim ligneSelectionner As DataGridViewSelectedRowCollection
        ligneSelectionner = DataGridViewSERTA.SelectedRows()
        If (ligneSelectionner.Count > 0) Then
            For Each uneLigne As DataGridViewRow In ligneSelectionner
                MgtSerta.getInstance.monter(MgtSerta.getInstance.rechercherDossier(uneLigne.Cells.Item(1).Value.ToString))
            Next
            ChargerDataGridViewSerta()
        End If
    End Sub
    Private Sub DownSERTA_Click(sender As Object, e As EventArgs) Handles DownSERTA.Click
        Dim ligneSelectionner As DataGridViewSelectedRowCollection
        ligneSelectionner = DataGridViewSERTA.SelectedRows()
        If (ligneSelectionner.Count > 0) Then
            For Each uneLigne As DataGridViewRow In ligneSelectionner
                MgtSerta.getInstance.monter(MgtSerta.getInstance.rechercherDossier(uneLigne.Cells.Item(1).Value.ToString))
            Next
            ChargerDataGridViewSerta()
        End If
    End Sub
#End Region
End Class
