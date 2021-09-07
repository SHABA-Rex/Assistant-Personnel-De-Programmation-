<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InformationsPourLaBarreDeRecherche
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InformationsPourLaBarreDeRecherche))
        Me.annuler = New Guna.UI.WinForms.GunaButton()
        Me.continuer = New Guna.UI.WinForms.GunaButton()
        Me.nomElement = New Guna.UI.WinForms.GunaLineTextBox()
        Me.categorieElement = New Guna.UI.WinForms.GunaLineTextBox()
        Me.lesMotsCler = New Guna.UI.WinForms.GunaLineTextBox()
        Me.laDate = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.image3 = New Guna.UI.WinForms.GunaImageButton()
        Me.image2 = New Guna.UI.WinForms.GunaImageButton()
        Me.image1 = New Guna.UI.WinForms.GunaImageButton()
        Me.aide = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Reduire = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Fermer = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.aideSupport = New Guna.UI.WinForms.GunaLabel()
        Me.SuspendLayout()
        '
        'annuler
        '
        Me.annuler.AnimationHoverSpeed = 0.07!
        Me.annuler.AnimationSpeed = 0.03!
        Me.annuler.BackColor = System.Drawing.Color.Transparent
        Me.annuler.BaseColor = System.Drawing.Color.Red
        Me.annuler.BorderColor = System.Drawing.Color.Black
        Me.annuler.DialogResult = System.Windows.Forms.DialogResult.None
        Me.annuler.FocusedColor = System.Drawing.Color.Empty
        Me.annuler.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.annuler.ForeColor = System.Drawing.Color.White
        Me.annuler.Image = Nothing
        Me.annuler.ImageSize = New System.Drawing.Size(20, 20)
        Me.annuler.Location = New System.Drawing.Point(209, 527)
        Me.annuler.Name = "annuler"
        Me.annuler.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.annuler.OnHoverBorderColor = System.Drawing.Color.Black
        Me.annuler.OnHoverForeColor = System.Drawing.Color.White
        Me.annuler.OnHoverImage = Nothing
        Me.annuler.OnPressedColor = System.Drawing.Color.Black
        Me.annuler.Radius = 10
        Me.annuler.Size = New System.Drawing.Size(130, 42)
        Me.annuler.TabIndex = 135
        Me.annuler.Text = "Annuler"
        Me.annuler.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'continuer
        '
        Me.continuer.AnimationHoverSpeed = 0.07!
        Me.continuer.AnimationSpeed = 0.03!
        Me.continuer.BackColor = System.Drawing.Color.Transparent
        Me.continuer.BaseColor = System.Drawing.Color.Lime
        Me.continuer.BorderColor = System.Drawing.Color.Black
        Me.continuer.DialogResult = System.Windows.Forms.DialogResult.None
        Me.continuer.FocusedColor = System.Drawing.Color.Empty
        Me.continuer.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.continuer.ForeColor = System.Drawing.Color.White
        Me.continuer.Image = Nothing
        Me.continuer.ImageSize = New System.Drawing.Size(20, 20)
        Me.continuer.Location = New System.Drawing.Point(345, 527)
        Me.continuer.Name = "continuer"
        Me.continuer.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.continuer.OnHoverBorderColor = System.Drawing.Color.Black
        Me.continuer.OnHoverForeColor = System.Drawing.Color.White
        Me.continuer.OnHoverImage = Nothing
        Me.continuer.OnPressedColor = System.Drawing.Color.Black
        Me.continuer.Radius = 10
        Me.continuer.Size = New System.Drawing.Size(130, 42)
        Me.continuer.TabIndex = 134
        Me.continuer.Text = "Continuer"
        Me.continuer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'nomElement
        '
        Me.nomElement.BackColor = System.Drawing.Color.White
        Me.nomElement.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.nomElement.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.nomElement.Font = New System.Drawing.Font("Open Sans Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nomElement.LineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.nomElement.Location = New System.Drawing.Point(58, 221)
        Me.nomElement.Name = "nomElement"
        Me.nomElement.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.nomElement.Size = New System.Drawing.Size(363, 36)
        Me.nomElement.TabIndex = 140
        '
        'categorieElement
        '
        Me.categorieElement.BackColor = System.Drawing.Color.White
        Me.categorieElement.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.categorieElement.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.categorieElement.Font = New System.Drawing.Font("Open Sans Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.categorieElement.LineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.categorieElement.Location = New System.Drawing.Point(58, 303)
        Me.categorieElement.Name = "categorieElement"
        Me.categorieElement.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.categorieElement.Size = New System.Drawing.Size(363, 36)
        Me.categorieElement.TabIndex = 141
        '
        'lesMotsCler
        '
        Me.lesMotsCler.BackColor = System.Drawing.Color.White
        Me.lesMotsCler.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lesMotsCler.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lesMotsCler.Font = New System.Drawing.Font("Open Sans Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lesMotsCler.LineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lesMotsCler.Location = New System.Drawing.Point(58, 402)
        Me.lesMotsCler.Name = "lesMotsCler"
        Me.lesMotsCler.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.lesMotsCler.Size = New System.Drawing.Size(363, 36)
        Me.lesMotsCler.TabIndex = 142
        '
        'laDate
        '
        Me.laDate.AutoSize = True
        Me.laDate.BackColor = System.Drawing.SystemColors.Control
        Me.laDate.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.laDate.ForeColor = System.Drawing.Color.Black
        Me.laDate.Location = New System.Drawing.Point(167, 146)
        Me.laDate.Name = "laDate"
        Me.laDate.Size = New System.Drawing.Size(146, 21)
        Me.laDate.TabIndex = 147
        Me.laDate.Text = "Créé le 13/03/2021"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.GunaLabel3.ForeColor = System.Drawing.Color.White
        Me.GunaLabel3.Location = New System.Drawing.Point(106, 92)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(275, 28)
        Me.GunaLabel3.TabIndex = 143
        Me.GunaLabel3.Text = "Renseignement sur l'élément : "
        Me.GunaLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'image3
        '
        Me.image3.DialogResult = System.Windows.Forms.DialogResult.None
        Me.image3.Image = Global.WindowsApplication1.My.Resources.Resources.cancel_50px
        Me.image3.ImageSize = New System.Drawing.Size(20, 20)
        Me.image3.Location = New System.Drawing.Point(427, 402)
        Me.image3.Name = "image3"
        Me.image3.OnHoverImage = Nothing
        Me.image3.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.image3.Size = New System.Drawing.Size(30, 30)
        Me.image3.TabIndex = 146
        '
        'image2
        '
        Me.image2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.image2.Image = Global.WindowsApplication1.My.Resources.Resources.cancel_50px
        Me.image2.ImageSize = New System.Drawing.Size(20, 20)
        Me.image2.Location = New System.Drawing.Point(427, 303)
        Me.image2.Name = "image2"
        Me.image2.OnHoverImage = Nothing
        Me.image2.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.image2.Size = New System.Drawing.Size(30, 30)
        Me.image2.TabIndex = 145
        '
        'image1
        '
        Me.image1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.image1.Image = Global.WindowsApplication1.My.Resources.Resources.cancel_50px
        Me.image1.ImageSize = New System.Drawing.Size(20, 20)
        Me.image1.Location = New System.Drawing.Point(427, 221)
        Me.image1.Name = "image1"
        Me.image1.OnHoverImage = Nothing
        Me.image1.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.image1.Size = New System.Drawing.Size(30, 30)
        Me.image1.TabIndex = 144
        '
        'aide
        '
        Me.aide.AnimationHoverSpeed = 0.07!
        Me.aide.AnimationSpeed = 0.03!
        Me.aide.BackColor = System.Drawing.Color.Transparent
        Me.aide.BaseColor = System.Drawing.Color.WhiteSmoke
        Me.aide.BorderColor = System.Drawing.Color.Black
        Me.aide.CheckedBaseColor = System.Drawing.Color.Gray
        Me.aide.CheckedBorderColor = System.Drawing.Color.Black
        Me.aide.CheckedForeColor = System.Drawing.Color.White
        Me.aide.CheckedImage = Nothing
        Me.aide.CheckedLineColor = System.Drawing.Color.DimGray
        Me.aide.DialogResult = System.Windows.Forms.DialogResult.None
        Me.aide.FocusedColor = System.Drawing.Color.Empty
        Me.aide.Font = New System.Drawing.Font("Segoe UI", 30.0!)
        Me.aide.ForeColor = System.Drawing.Color.DimGray
        Me.aide.Image = Global.WindowsApplication1.My.Resources.Resources.help_100px
        Me.aide.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.aide.ImageSize = New System.Drawing.Size(20, 20)
        Me.aide.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.aide.Location = New System.Drawing.Point(367, 2)
        Me.aide.Name = "aide"
        Me.aide.OnHoverBaseColor = System.Drawing.Color.LightGray
        Me.aide.OnHoverBorderColor = System.Drawing.Color.Black
        Me.aide.OnHoverForeColor = System.Drawing.Color.White
        Me.aide.OnHoverImage = Nothing
        Me.aide.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.aide.OnPressedColor = System.Drawing.Color.Black
        Me.aide.Size = New System.Drawing.Size(36, 30)
        Me.aide.TabIndex = 138
        Me.aide.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Reduire
        '
        Me.Reduire.AnimationHoverSpeed = 0.07!
        Me.Reduire.AnimationSpeed = 0.03!
        Me.Reduire.BackColor = System.Drawing.Color.Transparent
        Me.Reduire.BaseColor = System.Drawing.Color.WhiteSmoke
        Me.Reduire.BorderColor = System.Drawing.Color.Black
        Me.Reduire.CheckedBaseColor = System.Drawing.Color.Gray
        Me.Reduire.CheckedBorderColor = System.Drawing.Color.Black
        Me.Reduire.CheckedForeColor = System.Drawing.Color.White
        Me.Reduire.CheckedImage = Nothing
        Me.Reduire.CheckedLineColor = System.Drawing.Color.DimGray
        Me.Reduire.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Reduire.FocusedColor = System.Drawing.Color.Empty
        Me.Reduire.Font = New System.Drawing.Font("Segoe UI", 30.0!)
        Me.Reduire.ForeColor = System.Drawing.Color.DimGray
        Me.Reduire.Image = Global.WindowsApplication1.My.Resources.Resources.compress_50px
        Me.Reduire.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Reduire.ImageSize = New System.Drawing.Size(20, 20)
        Me.Reduire.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Reduire.Location = New System.Drawing.Point(403, 2)
        Me.Reduire.Name = "Reduire"
        Me.Reduire.OnHoverBaseColor = System.Drawing.Color.LightGray
        Me.Reduire.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Reduire.OnHoverForeColor = System.Drawing.Color.White
        Me.Reduire.OnHoverImage = Nothing
        Me.Reduire.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Reduire.OnPressedColor = System.Drawing.Color.Black
        Me.Reduire.Size = New System.Drawing.Size(36, 30)
        Me.Reduire.TabIndex = 137
        Me.Reduire.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Fermer
        '
        Me.Fermer.AnimationHoverSpeed = 0.07!
        Me.Fermer.AnimationSpeed = 0.03!
        Me.Fermer.BackColor = System.Drawing.Color.Transparent
        Me.Fermer.BaseColor = System.Drawing.Color.WhiteSmoke
        Me.Fermer.BorderColor = System.Drawing.Color.Black
        Me.Fermer.CheckedBaseColor = System.Drawing.Color.Gray
        Me.Fermer.CheckedBorderColor = System.Drawing.Color.Black
        Me.Fermer.CheckedForeColor = System.Drawing.Color.White
        Me.Fermer.CheckedImage = Nothing
        Me.Fermer.CheckedLineColor = System.Drawing.Color.DimGray
        Me.Fermer.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Fermer.FocusedColor = System.Drawing.Color.Empty
        Me.Fermer.Font = New System.Drawing.Font("Segoe UI", 30.0!)
        Me.Fermer.ForeColor = System.Drawing.Color.DimGray
        Me.Fermer.Image = Global.WindowsApplication1.My.Resources.Resources.delete_50px
        Me.Fermer.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Fermer.ImageSize = New System.Drawing.Size(20, 20)
        Me.Fermer.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Fermer.Location = New System.Drawing.Point(439, 2)
        Me.Fermer.Name = "Fermer"
        Me.Fermer.OnHoverBaseColor = System.Drawing.Color.LightGray
        Me.Fermer.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Fermer.OnHoverForeColor = System.Drawing.Color.White
        Me.Fermer.OnHoverImage = Nothing
        Me.Fermer.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Fermer.OnPressedColor = System.Drawing.Color.Black
        Me.Fermer.Size = New System.Drawing.Size(36, 30)
        Me.Fermer.TabIndex = 136
        Me.Fermer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.GunaLabel1.ForeColor = System.Drawing.Color.White
        Me.GunaLabel1.Location = New System.Drawing.Point(60, 191)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(154, 28)
        Me.GunaLabel1.TabIndex = 148
        Me.GunaLabel1.Text = "Nom , Signature"
        Me.GunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.GunaLabel4.ForeColor = System.Drawing.Color.White
        Me.GunaLabel4.Location = New System.Drawing.Point(58, 273)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(97, 28)
        Me.GunaLabel4.TabIndex = 149
        Me.GunaLabel4.Text = "Catégorie"
        Me.GunaLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.GunaLabel5.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.GunaLabel5.ForeColor = System.Drawing.Color.White
        Me.GunaLabel5.Location = New System.Drawing.Point(59, 372)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(208, 28)
        Me.GunaLabel5.TabIndex = 150
        Me.GunaLabel5.Text = "mots clés(Maximum 6)"
        Me.GunaLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'aideSupport
        '
        Me.aideSupport.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.aideSupport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.aideSupport.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.aideSupport.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.aideSupport.ForeColor = System.Drawing.Color.Black
        Me.aideSupport.Location = New System.Drawing.Point(33, 35)
        Me.aideSupport.Name = "aideSupport"
        Me.aideSupport.Size = New System.Drawing.Size(400, 203)
        Me.aideSupport.TabIndex = 151
        Me.aideSupport.Text = resources.GetString("aideSupport.Text")
        Me.aideSupport.Visible = False
        '
        'InformationsPourLaBarreDeRecherche
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 572)
        Me.Controls.Add(Me.aideSupport)
        Me.Controls.Add(Me.GunaLabel5)
        Me.Controls.Add(Me.GunaLabel4)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.laDate)
        Me.Controls.Add(Me.image3)
        Me.Controls.Add(Me.image2)
        Me.Controls.Add(Me.image1)
        Me.Controls.Add(Me.GunaLabel3)
        Me.Controls.Add(Me.lesMotsCler)
        Me.Controls.Add(Me.categorieElement)
        Me.Controls.Add(Me.nomElement)
        Me.Controls.Add(Me.aide)
        Me.Controls.Add(Me.Reduire)
        Me.Controls.Add(Me.Fermer)
        Me.Controls.Add(Me.annuler)
        Me.Controls.Add(Me.continuer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "InformationsPourLaBarreDeRecherche"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Caratéristiques"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents annuler As Guna.UI.WinForms.GunaButton
    Friend WithEvents continuer As Guna.UI.WinForms.GunaButton
    Friend WithEvents aide As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Reduire As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Fermer As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents nomElement As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents categorieElement As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents lesMotsCler As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents image1 As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents image2 As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents image3 As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents laDate As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents aideSupport As Guna.UI.WinForms.GunaLabel
End Class
