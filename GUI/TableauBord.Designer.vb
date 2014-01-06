<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TableauBord
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TableauBord))
        Me.DataGridViewTransfere = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.AddSauvegardePortable = New System.Windows.Forms.Button()
        Me.RemoveSauvegardePortable = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DownSERTA = New System.Windows.Forms.Button()
        Me.UpSERTA = New System.Windows.Forms.Button()
        Me.DataGridViewSERTA = New System.Windows.Forms.DataGridView()
        Me.RemoveRepertoireSERTA = New System.Windows.Forms.Button()
        Me.AddRepertoireSERTA = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DownTransfere = New System.Windows.Forms.Button()
        Me.UpTransfere = New System.Windows.Forms.Button()
        Me.RemoveSERTAPNS = New System.Windows.Forms.Button()
        Me.AddPNSSERTA = New System.Windows.Forms.Button()
        CType(Me.DataGridViewTransfere, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridViewSERTA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridViewTransfere
        '
        Me.DataGridViewTransfere.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewTransfere.Location = New System.Drawing.Point(6, 63)
        Me.DataGridViewTransfere.Name = "DataGridViewTransfere"
        Me.DataGridViewTransfere.Size = New System.Drawing.Size(418, 529)
        Me.DataGridViewTransfere.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView3)
        Me.GroupBox1.Controls.Add(Me.AddSauvegardePortable)
        Me.GroupBox1.Controls.Add(Me.RemoveSauvegardePortable)
        Me.GroupBox1.Location = New System.Drawing.Point(1, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(430, 600)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sauvegarde portable"
        '
        'DataGridView3
        '
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(6, 63)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(418, 529)
        Me.DataGridView3.TabIndex = 5
        '
        'AddSauvegardePortable
        '
        Me.AddSauvegardePortable.Location = New System.Drawing.Point(11, 19)
        Me.AddSauvegardePortable.Name = "AddSauvegardePortable"
        Me.AddSauvegardePortable.Size = New System.Drawing.Size(75, 23)
        Me.AddSauvegardePortable.TabIndex = 4
        Me.AddSauvegardePortable.Text = "Ajouter"
        Me.AddSauvegardePortable.UseVisualStyleBackColor = True
        '
        'RemoveSauvegardePortable
        '
        Me.RemoveSauvegardePortable.Location = New System.Drawing.Point(92, 19)
        Me.RemoveSauvegardePortable.Name = "RemoveSauvegardePortable"
        Me.RemoveSauvegardePortable.Size = New System.Drawing.Size(75, 23)
        Me.RemoveSauvegardePortable.TabIndex = 3
        Me.RemoveSauvegardePortable.Text = "Supprimer"
        Me.RemoveSauvegardePortable.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DownSERTA)
        Me.GroupBox2.Controls.Add(Me.UpSERTA)
        Me.GroupBox2.Controls.Add(Me.DataGridViewSERTA)
        Me.GroupBox2.Controls.Add(Me.RemoveRepertoireSERTA)
        Me.GroupBox2.Controls.Add(Me.AddRepertoireSERTA)
        Me.GroupBox2.Location = New System.Drawing.Point(437, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(430, 600)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Espace répertoire SERTA"
        '
        'DownSERTA
        '
        Me.DownSERTA.Image = CType(resources.GetObject("DownSERTA.Image"), System.Drawing.Image)
        Me.DownSERTA.Location = New System.Drawing.Point(239, 17)
        Me.DownSERTA.Name = "DownSERTA"
        Me.DownSERTA.Size = New System.Drawing.Size(40, 40)
        Me.DownSERTA.TabIndex = 6
        Me.DownSERTA.UseVisualStyleBackColor = True
        '
        'UpSERTA
        '
        Me.UpSERTA.Image = CType(resources.GetObject("UpSERTA.Image"), System.Drawing.Image)
        Me.UpSERTA.Location = New System.Drawing.Point(193, 17)
        Me.UpSERTA.Name = "UpSERTA"
        Me.UpSERTA.Size = New System.Drawing.Size(40, 40)
        Me.UpSERTA.TabIndex = 5
        Me.UpSERTA.UseVisualStyleBackColor = True
        '
        'DataGridViewSERTA
        '
        Me.DataGridViewSERTA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewSERTA.Location = New System.Drawing.Point(12, 63)
        Me.DataGridViewSERTA.Name = "DataGridViewSERTA"
        Me.DataGridViewSERTA.Size = New System.Drawing.Size(418, 529)
        Me.DataGridViewSERTA.TabIndex = 4
        '
        'RemoveRepertoireSERTA
        '
        Me.RemoveRepertoireSERTA.Location = New System.Drawing.Point(87, 19)
        Me.RemoveRepertoireSERTA.Name = "RemoveRepertoireSERTA"
        Me.RemoveRepertoireSERTA.Size = New System.Drawing.Size(75, 23)
        Me.RemoveRepertoireSERTA.TabIndex = 3
        Me.RemoveRepertoireSERTA.Text = "Supprimer"
        Me.RemoveRepertoireSERTA.UseVisualStyleBackColor = True
        '
        'AddRepertoireSERTA
        '
        Me.AddRepertoireSERTA.Location = New System.Drawing.Point(6, 19)
        Me.AddRepertoireSERTA.Name = "AddRepertoireSERTA"
        Me.AddRepertoireSERTA.Size = New System.Drawing.Size(75, 23)
        Me.AddRepertoireSERTA.TabIndex = 2
        Me.AddRepertoireSERTA.Text = "Ajouter"
        Me.AddRepertoireSERTA.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DownTransfere)
        Me.GroupBox3.Controls.Add(Me.UpTransfere)
        Me.GroupBox3.Controls.Add(Me.RemoveSERTAPNS)
        Me.GroupBox3.Controls.Add(Me.AddPNSSERTA)
        Me.GroupBox3.Controls.Add(Me.DataGridViewTransfere)
        Me.GroupBox3.Location = New System.Drawing.Point(873, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(430, 598)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Espace répertoire transfere PNS <->SERTA"
        '
        'DownTransfere
        '
        Me.DownTransfere.Image = CType(resources.GetObject("DownTransfere.Image"), System.Drawing.Image)
        Me.DownTransfere.Location = New System.Drawing.Point(234, 19)
        Me.DownTransfere.Name = "DownTransfere"
        Me.DownTransfere.Size = New System.Drawing.Size(40, 40)
        Me.DownTransfere.TabIndex = 4
        Me.DownTransfere.UseVisualStyleBackColor = True
        '
        'UpTransfere
        '
        Me.UpTransfere.Image = CType(resources.GetObject("UpTransfere.Image"), System.Drawing.Image)
        Me.UpTransfere.Location = New System.Drawing.Point(188, 19)
        Me.UpTransfere.Name = "UpTransfere"
        Me.UpTransfere.Size = New System.Drawing.Size(40, 40)
        Me.UpTransfere.TabIndex = 3
        Me.UpTransfere.UseVisualStyleBackColor = True
        '
        'RemoveSERTAPNS
        '
        Me.RemoveSERTAPNS.Location = New System.Drawing.Point(87, 19)
        Me.RemoveSERTAPNS.Name = "RemoveSERTAPNS"
        Me.RemoveSERTAPNS.Size = New System.Drawing.Size(75, 23)
        Me.RemoveSERTAPNS.TabIndex = 2
        Me.RemoveSERTAPNS.Text = "Supprimer"
        Me.RemoveSERTAPNS.UseVisualStyleBackColor = True
        '
        'AddPNSSERTA
        '
        Me.AddPNSSERTA.Location = New System.Drawing.Point(6, 19)
        Me.AddPNSSERTA.Name = "AddPNSSERTA"
        Me.AddPNSSERTA.Size = New System.Drawing.Size(75, 23)
        Me.AddPNSSERTA.TabIndex = 1
        Me.AddPNSSERTA.Text = "Ajouter"
        Me.AddPNSSERTA.UseVisualStyleBackColor = True
        '
        'TableauBord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1306, 613)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "TableauBord"
        Me.Text = "Form1"
        CType(Me.DataGridViewTransfere, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridViewSERTA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridViewTransfere As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents RemoveSERTAPNS As System.Windows.Forms.Button
    Friend WithEvents AddPNSSERTA As System.Windows.Forms.Button
    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents AddSauvegardePortable As System.Windows.Forms.Button
    Friend WithEvents RemoveSauvegardePortable As System.Windows.Forms.Button
    Friend WithEvents DataGridViewSERTA As System.Windows.Forms.DataGridView
    Friend WithEvents RemoveRepertoireSERTA As System.Windows.Forms.Button
    Friend WithEvents AddRepertoireSERTA As System.Windows.Forms.Button
    Friend WithEvents DownTransfere As System.Windows.Forms.Button
    Friend WithEvents UpTransfere As System.Windows.Forms.Button
    Friend WithEvents DownSERTA As System.Windows.Forms.Button
    Friend WithEvents UpSERTA As System.Windows.Forms.Button

End Class
