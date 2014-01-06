Imports System.Windows.Forms

Public Class DialogOpenFolder

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles CheminFolder.TextChanged

    End Sub

    Private Sub Parcourir_Click(sender As Object, e As EventArgs) Handles Parcourir.Click
        Dim cheminDossier As String
        Dim dialog As FolderBrowserDialog = New FolderBrowserDialog()
        dialog.Description = "Selectionner un dossier"
        dialog.ShowDialog()
        cheminDossier = dialog.SelectedPath
        If Not IsNothing(cheminDossier) Then
            CheminFolder.Text = cheminDossier
        End If

    End Sub
End Class
