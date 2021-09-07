<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DescriptionImage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DescriptionImage))
        Me.annuler = New Guna.UI.WinForms.GunaButton()
        Me.continuer = New Guna.UI.WinForms.GunaButton()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.LBL_Images = New Guna.UI.WinForms.GunaLineTextBox()
        Me.ajouterDesImages = New Guna.UI.WinForms.GunaCircleButton()
        Me.aide = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Reduire = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Fermer = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.image1 = New Guna.UI.WinForms.GunaImageButton()
        Me.aideSupport = New Guna.UI.WinForms.GunaLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bulle_Explorateur = New Guna.UI.WinForms.GunaLabel()
        Me.btn_OuvrirExplorateur = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.explorerLesImages = New System.Windows.Forms.OpenFileDialog()
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
        Me.annuler.Location = New System.Drawing.Point(137, 386)
        Me.annuler.Name = "annuler"
        Me.annuler.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.annuler.OnHoverBorderColor = System.Drawing.Color.Black
        Me.annuler.OnHoverForeColor = System.Drawing.Color.White
        Me.annuler.OnHoverImage = Nothing
        Me.annuler.OnPressedColor = System.Drawing.Color.Black
        Me.annuler.Radius = 10
        Me.annuler.Size = New System.Drawing.Size(130, 42)
        Me.annuler.TabIndex = 133
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
        Me.continuer.Location = New System.Drawing.Point(274, 386)
        Me.continuer.Name = "continuer"
        Me.continuer.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.continuer.OnHoverBorderColor = System.Drawing.Color.Black
        Me.continuer.OnHoverForeColor = System.Drawing.Color.White
        Me.continuer.OnHoverImage = Nothing
        Me.continuer.OnPressedColor = System.Drawing.Color.Black
        Me.continuer.Radius = 10
        Me.continuer.Size = New System.Drawing.Size(130, 42)
        Me.continuer.TabIndex = 132
        Me.continuer.Text = "Continuer"
        Me.continuer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel1
        '
        Me.GunaLabel1.BackColor = System.Drawing.Color.DarkGray
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold)
        Me.GunaLabel1.ForeColor = System.Drawing.Color.White
        Me.GunaLabel1.Location = New System.Drawing.Point(50, 174)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(293, 30)
        Me.GunaLabel1.TabIndex = 130
        Me.GunaLabel1.Text = "Fichier Image"
        Me.GunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LBL_Images
        '
        Me.LBL_Images.BackColor = System.Drawing.Color.White
        Me.LBL_Images.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.LBL_Images.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LBL_Images.Font = New System.Drawing.Font("Open Sans Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Images.LineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LBL_Images.Location = New System.Drawing.Point(49, 207)
        Me.LBL_Images.Name = "LBL_Images"
        Me.LBL_Images.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.LBL_Images.Size = New System.Drawing.Size(293, 36)
        Me.LBL_Images.TabIndex = 129
        '
        'ajouterDesImages
        '
        Me.ajouterDesImages.AnimationHoverSpeed = 0.07!
        Me.ajouterDesImages.AnimationSpeed = 0.03!
        Me.ajouterDesImages.BackColor = System.Drawing.Color.Transparent
        Me.ajouterDesImages.BaseColor = System.Drawing.Color.Orange
        Me.ajouterDesImages.BorderColor = System.Drawing.Color.Black
        Me.ajouterDesImages.DialogResult = System.Windows.Forms.DialogResult.None
        Me.ajouterDesImages.FocusedColor = System.Drawing.Color.Empty
        Me.ajouterDesImages.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.ajouterDesImages.ForeColor = System.Drawing.Color.White
        Me.ajouterDesImages.Image = Global.WindowsApplication1.My.Resources.Resources.plus_math_50px
        Me.ajouterDesImages.ImageSize = New System.Drawing.Size(25, 25)
        Me.ajouterDesImages.Location = New System.Drawing.Point(346, 174)
        Me.ajouterDesImages.Name = "ajouterDesImages"
        Me.ajouterDesImages.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ajouterDesImages.OnHoverBorderColor = System.Drawing.Color.Black
        Me.ajouterDesImages.OnHoverForeColor = System.Drawing.Color.White
        Me.ajouterDesImages.OnHoverImage = Nothing
        Me.ajouterDesImages.OnPressedColor = System.Drawing.Color.Indigo
        Me.ajouterDesImages.Size = New System.Drawing.Size(35, 35)
        Me.ajouterDesImages.TabIndex = 131
        Me.ajouterDesImages.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAliasGridFit
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
        Me.aide.Location = New System.Drawing.Point(296, 4)
        Me.aide.Name = "aide"
        Me.aide.OnHoverBaseColor = System.Drawing.Color.LightGray
        Me.aide.OnHoverBorderColor = System.Drawing.Color.Black
        Me.aide.OnHoverForeColor = System.Drawing.Color.White
        Me.aide.OnHoverImage = Nothing
        Me.aide.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.aide.OnPressedColor = System.Drawing.Color.Black
        Me.aide.Size = New System.Drawing.Size(36, 30)
        Me.aide.TabIndex = 128
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
        Me.Reduire.Location = New System.Drawing.Point(332, 4)
        Me.Reduire.Name = "Reduire"
        Me.Reduire.OnHoverBaseColor = System.Drawing.Color.LightGray
        Me.Reduire.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Reduire.OnHoverForeColor = System.Drawing.Color.White
        Me.Reduire.OnHoverImage = Nothing
        Me.Reduire.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Reduire.OnPressedColor = System.Drawing.Color.Black
        Me.Reduire.Size = New System.Drawing.Size(36, 30)
        Me.Reduire.TabIndex = 127
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
        Me.Fermer.Location = New System.Drawing.Point(368, 4)
        Me.Fermer.Name = "Fermer"
        Me.Fermer.OnHoverBaseColor = System.Drawing.Color.LightGray
        Me.Fermer.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Fermer.OnHoverForeColor = System.Drawing.Color.White
        Me.Fermer.OnHoverImage = Nothing
        Me.Fermer.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Fermer.OnPressedColor = System.Drawing.Color.Black
        Me.Fermer.Size = New System.Drawing.Size(36, 30)
        Me.Fermer.TabIndex = 126
        Me.Fermer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'image1
        '
        Me.image1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.image1.Image = Global.WindowsApplication1.My.Resources.Resources.cancel_50px
        Me.image1.ImageSize = New System.Drawing.Size(20, 20)
        Me.image1.Location = New System.Drawing.Point(348, 209)
        Me.image1.Name = "image1"
        Me.image1.OnHoverImage = Nothing
        Me.image1.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.image1.Size = New System.Drawing.Size(30, 30)
        Me.image1.TabIndex = 154
        '
        'aideSupport
        '
        Me.aideSupport.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.aideSupport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.aideSupport.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.aideSupport.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.aideSupport.ForeColor = System.Drawing.Color.Black
        Me.aideSupport.Location = New System.Drawing.Point(13, 37)
        Me.aideSupport.Name = "aideSupport"
        Me.aideSupport.Size = New System.Drawing.Size(381, 202)
        Me.aideSupport.TabIndex = 155
        Me.aideSupport.Text = resources.GetString("aideSupport.Text")
        Me.aideSupport.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 316)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 156
        Me.Label1.Text = "Label1"
        Me.Label1.Visible = False
        '
        'bulle_Explorateur
        '
        Me.bulle_Explorateur.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.bulle_Explorateur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.bulle_Explorateur.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bulle_Explorateur.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.bulle_Explorateur.ForeColor = System.Drawing.Color.Black
        Me.bulle_Explorateur.Location = New System.Drawing.Point(99, 6)
        Me.bulle_Explorateur.Name = "bulle_Explorateur"
        Me.bulle_Explorateur.Size = New System.Drawing.Size(152, 24)
        Me.bulle_Explorateur.TabIndex = 159
        Me.bulle_Explorateur.Text = "Explorateur d'image(s)."
        Me.bulle_Explorateur.Visible = False
        '
        'btn_OuvrirExplorateur
        '
        Me.btn_OuvrirExplorateur.AnimationHoverSpeed = 0.07!
        Me.btn_OuvrirExplorateur.AnimationSpeed = 0.03!
        Me.btn_OuvrirExplorateur.BackColor = System.Drawing.Color.Transparent
        Me.btn_OuvrirExplorateur.BaseColor = System.Drawing.Color.WhiteSmoke
        Me.btn_OuvrirExplorateur.BorderColor = System.Drawing.Color.Black
        Me.btn_OuvrirExplorateur.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btn_OuvrirExplorateur.CheckedBorderColor = System.Drawing.Color.Black
        Me.btn_OuvrirExplorateur.CheckedForeColor = System.Drawing.Color.White
        Me.btn_OuvrirExplorateur.CheckedImage = Nothing
        Me.btn_OuvrirExplorateur.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btn_OuvrirExplorateur.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_OuvrirExplorateur.FocusedColor = System.Drawing.Color.Empty
        Me.btn_OuvrirExplorateur.Font = New System.Drawing.Font("Segoe UI", 30.0!)
        Me.btn_OuvrirExplorateur.ForeColor = System.Drawing.Color.DimGray
        Me.btn_OuvrirExplorateur.Image = CType(resources.GetObject("btn_OuvrirExplorateur.Image"), System.Drawing.Image)
        Me.btn_OuvrirExplorateur.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btn_OuvrirExplorateur.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_OuvrirExplorateur.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_OuvrirExplorateur.Location = New System.Drawing.Point(254, 4)
        Me.btn_OuvrirExplorateur.Name = "btn_OuvrirExplorateur"
        Me.btn_OuvrirExplorateur.OnHoverBaseColor = System.Drawing.Color.LightGray
        Me.btn_OuvrirExplorateur.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn_OuvrirExplorateur.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_OuvrirExplorateur.OnHoverImage = Nothing
        Me.btn_OuvrirExplorateur.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_OuvrirExplorateur.OnPressedColor = System.Drawing.Color.Black
        Me.btn_OuvrirExplorateur.Size = New System.Drawing.Size(36, 30)
        Me.btn_OuvrirExplorateur.TabIndex = 160
        Me.btn_OuvrirExplorateur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DescriptionImage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(406, 430)
        Me.Controls.Add(Me.btn_OuvrirExplorateur)
        Me.Controls.Add(Me.bulle_Explorateur)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.aideSupport)
        Me.Controls.Add(Me.image1)
        Me.Controls.Add(Me.annuler)
        Me.Controls.Add(Me.continuer)
        Me.Controls.Add(Me.ajouterDesImages)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.LBL_Images)
        Me.Controls.Add(Me.aide)
        Me.Controls.Add(Me.Reduire)
        Me.Controls.Add(Me.Fermer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DescriptionImage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Description image"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents annuler As Guna.UI.WinForms.GunaButton
    Friend WithEvents continuer As Guna.UI.WinForms.GunaButton
    Friend WithEvents ajouterDesImages As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents LBL_Images As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents aide As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Reduire As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Fermer As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents image1 As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents aideSupport As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents bulle_Explorateur As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btn_OuvrirExplorateur As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents explorerLesImages As OpenFileDialog
End Class
