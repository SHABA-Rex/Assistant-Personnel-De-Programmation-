<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Decrire_ImageSonTexte
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Decrire_ImageSonTexte))
        Me.afficherLesInfosBulles = New System.Windows.Forms.Timer(Me.components)
        Me.Lbl_DescriptionSonore = New Guna.UI.WinForms.GunaLabel()
        Me.Lbl_DescriptionTextuelle = New Guna.UI.WinForms.GunaLabel()
        Me.Lbl_DescriptionImage = New Guna.UI.WinForms.GunaLabel()
        Me.Lbl_Home = New Guna.UI.WinForms.GunaLabel()
        Me.Lbl_Reduire = New Guna.UI.WinForms.GunaLabel()
        Me.Lbl_Fermer = New Guna.UI.WinForms.GunaLabel()
        Me.previousImage = New Guna.UI.WinForms.GunaGradientButton()
        Me.nextImage = New Guna.UI.WinForms.GunaGradientButton()
        Me.ChampTextuel = New Guna.UI.WinForms.GunaTextBox()
        Me.Lbl_Aide = New Guna.UI.WinForms.GunaLabel()
        Me.modifierSauvegarder = New Guna.UI.WinForms.GunaButton()
        Me.lecteurMusique = New AxWMPLib.AxWindowsMediaPlayer()
        Me.previousMusique = New Guna.UI.WinForms.GunaCircleButton()
        Me.nextMusique = New Guna.UI.WinForms.GunaCircleButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lesMotsCler = New Guna.UI.WinForms.GunaLineTextBox()
        Me.GunaAdvenceButton1 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.categorieElement = New Guna.UI.WinForms.GunaLineTextBox()
        Me.nomElement = New Guna.UI.WinForms.GunaLineTextBox()
        Me.lesImages = New Guna.UI.WinForms.GunaGradientButton()
        Me.corbeille = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.descriptionImage = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.descriptionSonore = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.descriptionTextuelle = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.home = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Reduire = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Fermer = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.aide = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaImageButton23 = New Guna.UI.WinForms.GunaImageButton()
        Me.GunaImageButton21 = New Guna.UI.WinForms.GunaImageButton()
        Me.GunaImageButton20 = New Guna.UI.WinForms.GunaImageButton()
        Me.GunaImageButton19 = New Guna.UI.WinForms.GunaImageButton()
        Me.GunaImageButton18 = New Guna.UI.WinForms.GunaImageButton()
        Me.GunaImageButton17 = New Guna.UI.WinForms.GunaImageButton()
        Me.GunaImageButton16 = New Guna.UI.WinForms.GunaImageButton()
        Me.GunaImageButton15 = New Guna.UI.WinForms.GunaImageButton()
        Me.GunaImageButton14 = New Guna.UI.WinForms.GunaImageButton()
        Me.GunaImageButton13 = New Guna.UI.WinForms.GunaImageButton()
        Me.GunaImageButton12 = New Guna.UI.WinForms.GunaImageButton()
        Me.GunaImageButton11 = New Guna.UI.WinForms.GunaImageButton()
        Me.GunaImageButton9 = New Guna.UI.WinForms.GunaImageButton()
        Me.GunaImageButton8 = New Guna.UI.WinForms.GunaImageButton()
        Me.GunaImageButton7 = New Guna.UI.WinForms.GunaImageButton()
        Me.GunaImageButton6 = New Guna.UI.WinForms.GunaImageButton()
        Me.GunaImageButton5 = New Guna.UI.WinForms.GunaImageButton()
        Me.GunaImageButton4 = New Guna.UI.WinForms.GunaImageButton()
        Me.GunaImageButton3 = New Guna.UI.WinForms.GunaImageButton()
        Me.GunaImageButton2 = New Guna.UI.WinForms.GunaImageButton()
        Me.GunaImageButton1 = New Guna.UI.WinForms.GunaImageButton()
        Me.GunaImageButton10 = New Guna.UI.WinForms.GunaImageButton()
        Me.supprimerInfo = New Guna.UI.WinForms.GunaLabel()
        Me.panneauDeSuppression = New Guna.UI.WinForms.GunaPanel()
        Me.Btn_Oui = New Guna.UI.WinForms.GunaButton()
        Me.Btn_Non = New Guna.UI.WinForms.GunaButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Lbl_NomElmtASupprimer = New System.Windows.Forms.Label()
        Me.msg_ImageInexistante1 = New Guna.UI.WinForms.GunaGradientButton()
        Me.msg_ImageInexistante2 = New Guna.UI.WinForms.GunaGradientButton()
        CType(Me.lecteurMusique, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.panneauDeSuppression.SuspendLayout()
        Me.SuspendLayout()
        '
        'afficherLesInfosBulles
        '
        Me.afficherLesInfosBulles.Interval = 1000
        '
        'Lbl_DescriptionSonore
        '
        Me.Lbl_DescriptionSonore.AutoSize = True
        Me.Lbl_DescriptionSonore.BackColor = System.Drawing.Color.DimGray
        Me.Lbl_DescriptionSonore.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Lbl_DescriptionSonore.ForeColor = System.Drawing.Color.White
        Me.Lbl_DescriptionSonore.Location = New System.Drawing.Point(85, 31)
        Me.Lbl_DescriptionSonore.Name = "Lbl_DescriptionSonore"
        Me.Lbl_DescriptionSonore.Size = New System.Drawing.Size(124, 19)
        Me.Lbl_DescriptionSonore.TabIndex = 163
        Me.Lbl_DescriptionSonore.Text = "Description sonore"
        Me.Lbl_DescriptionSonore.Visible = False
        '
        'Lbl_DescriptionTextuelle
        '
        Me.Lbl_DescriptionTextuelle.AutoSize = True
        Me.Lbl_DescriptionTextuelle.BackColor = System.Drawing.Color.DimGray
        Me.Lbl_DescriptionTextuelle.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Lbl_DescriptionTextuelle.ForeColor = System.Drawing.Color.White
        Me.Lbl_DescriptionTextuelle.Location = New System.Drawing.Point(48, 33)
        Me.Lbl_DescriptionTextuelle.Name = "Lbl_DescriptionTextuelle"
        Me.Lbl_DescriptionTextuelle.Size = New System.Drawing.Size(133, 19)
        Me.Lbl_DescriptionTextuelle.TabIndex = 164
        Me.Lbl_DescriptionTextuelle.Text = "Description textuelle"
        Me.Lbl_DescriptionTextuelle.Visible = False
        '
        'Lbl_DescriptionImage
        '
        Me.Lbl_DescriptionImage.AutoSize = True
        Me.Lbl_DescriptionImage.BackColor = System.Drawing.Color.DimGray
        Me.Lbl_DescriptionImage.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Lbl_DescriptionImage.ForeColor = System.Drawing.Color.White
        Me.Lbl_DescriptionImage.Location = New System.Drawing.Point(85, 34)
        Me.Lbl_DescriptionImage.Name = "Lbl_DescriptionImage"
        Me.Lbl_DescriptionImage.Size = New System.Drawing.Size(138, 19)
        Me.Lbl_DescriptionImage.TabIndex = 163
        Me.Lbl_DescriptionImage.Text = "Description en image"
        Me.Lbl_DescriptionImage.Visible = False
        '
        'Lbl_Home
        '
        Me.Lbl_Home.AutoSize = True
        Me.Lbl_Home.BackColor = System.Drawing.Color.DimGray
        Me.Lbl_Home.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Lbl_Home.ForeColor = System.Drawing.Color.White
        Me.Lbl_Home.Location = New System.Drawing.Point(4, 33)
        Me.Lbl_Home.Name = "Lbl_Home"
        Me.Lbl_Home.Size = New System.Drawing.Size(46, 19)
        Me.Lbl_Home.TabIndex = 165
        Me.Lbl_Home.Text = "Home"
        Me.Lbl_Home.Visible = False
        '
        'Lbl_Reduire
        '
        Me.Lbl_Reduire.AutoSize = True
        Me.Lbl_Reduire.BackColor = System.Drawing.Color.DimGray
        Me.Lbl_Reduire.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Lbl_Reduire.ForeColor = System.Drawing.Color.White
        Me.Lbl_Reduire.Location = New System.Drawing.Point(1274, 35)
        Me.Lbl_Reduire.Name = "Lbl_Reduire"
        Me.Lbl_Reduire.Size = New System.Drawing.Size(55, 19)
        Me.Lbl_Reduire.TabIndex = 167
        Me.Lbl_Reduire.Text = "Réduire"
        Me.Lbl_Reduire.Visible = False
        '
        'Lbl_Fermer
        '
        Me.Lbl_Fermer.AutoSize = True
        Me.Lbl_Fermer.BackColor = System.Drawing.Color.DimGray
        Me.Lbl_Fermer.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Lbl_Fermer.ForeColor = System.Drawing.Color.White
        Me.Lbl_Fermer.Location = New System.Drawing.Point(1320, 34)
        Me.Lbl_Fermer.Name = "Lbl_Fermer"
        Me.Lbl_Fermer.Size = New System.Drawing.Size(52, 19)
        Me.Lbl_Fermer.TabIndex = 168
        Me.Lbl_Fermer.Text = "Fermer"
        Me.Lbl_Fermer.Visible = False
        '
        'previousImage
        '
        Me.previousImage.AnimationHoverSpeed = 0.07!
        Me.previousImage.AnimationSpeed = 0.03!
        Me.previousImage.BackColor = System.Drawing.Color.SlateBlue
        Me.previousImage.BaseColor1 = System.Drawing.Color.SlateBlue
        Me.previousImage.BaseColor2 = System.Drawing.Color.Fuchsia
        Me.previousImage.BorderColor = System.Drawing.Color.Black
        Me.previousImage.DialogResult = System.Windows.Forms.DialogResult.None
        Me.previousImage.FocusedColor = System.Drawing.Color.Empty
        Me.previousImage.Font = New System.Drawing.Font("Segoe UI", 22.0!)
        Me.previousImage.ForeColor = System.Drawing.Color.White
        Me.previousImage.Image = Nothing
        Me.previousImage.ImageSize = New System.Drawing.Size(20, 20)
        Me.previousImage.Location = New System.Drawing.Point(30, 367)
        Me.previousImage.Name = "previousImage"
        Me.previousImage.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.previousImage.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.previousImage.OnHoverBorderColor = System.Drawing.Color.Black
        Me.previousImage.OnHoverForeColor = System.Drawing.Color.White
        Me.previousImage.OnHoverImage = Nothing
        Me.previousImage.OnPressedColor = System.Drawing.Color.Black
        Me.previousImage.Size = New System.Drawing.Size(60, 60)
        Me.previousImage.TabIndex = 169
        Me.previousImage.Text = "<"
        Me.previousImage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'nextImage
        '
        Me.nextImage.AnimationHoverSpeed = 0.07!
        Me.nextImage.AnimationSpeed = 0.03!
        Me.nextImage.BackColor = System.Drawing.Color.Fuchsia
        Me.nextImage.BaseColor1 = System.Drawing.Color.SlateBlue
        Me.nextImage.BaseColor2 = System.Drawing.Color.Fuchsia
        Me.nextImage.BorderColor = System.Drawing.Color.Black
        Me.nextImage.DialogResult = System.Windows.Forms.DialogResult.None
        Me.nextImage.FocusedColor = System.Drawing.Color.Empty
        Me.nextImage.Font = New System.Drawing.Font("Segoe UI", 22.0!)
        Me.nextImage.ForeColor = System.Drawing.Color.White
        Me.nextImage.Image = Nothing
        Me.nextImage.ImageSize = New System.Drawing.Size(20, 20)
        Me.nextImage.Location = New System.Drawing.Point(1282, 367)
        Me.nextImage.Name = "nextImage"
        Me.nextImage.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.nextImage.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.nextImage.OnHoverBorderColor = System.Drawing.Color.Black
        Me.nextImage.OnHoverForeColor = System.Drawing.Color.White
        Me.nextImage.OnHoverImage = Nothing
        Me.nextImage.OnPressedColor = System.Drawing.Color.Black
        Me.nextImage.Size = New System.Drawing.Size(60, 60)
        Me.nextImage.TabIndex = 171
        Me.nextImage.Text = ">"
        Me.nextImage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ChampTextuel
        '
        Me.ChampTextuel.BackColor = System.Drawing.Color.Transparent
        Me.ChampTextuel.BaseColor = System.Drawing.Color.White
        Me.ChampTextuel.BorderColor = System.Drawing.Color.Silver
        Me.ChampTextuel.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ChampTextuel.FocusedBaseColor = System.Drawing.Color.White
        Me.ChampTextuel.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChampTextuel.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.ChampTextuel.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ChampTextuel.Location = New System.Drawing.Point(392, 314)
        Me.ChampTextuel.MultiLine = True
        Me.ChampTextuel.Name = "ChampTextuel"
        Me.ChampTextuel.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ChampTextuel.Radius = 18
        Me.ChampTextuel.Size = New System.Drawing.Size(100, 522)
        Me.ChampTextuel.TabIndex = 172
        Me.ChampTextuel.Visible = False
        '
        'Lbl_Aide
        '
        Me.Lbl_Aide.AutoSize = True
        Me.Lbl_Aide.BackColor = System.Drawing.Color.DimGray
        Me.Lbl_Aide.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Lbl_Aide.ForeColor = System.Drawing.Color.White
        Me.Lbl_Aide.Location = New System.Drawing.Point(919, 35)
        Me.Lbl_Aide.Name = "Lbl_Aide"
        Me.Lbl_Aide.Size = New System.Drawing.Size(377, 76)
        Me.Lbl_Aide.TabIndex = 173
        Me.Lbl_Aide.Text = "Cette fenêtre vous permet d'avoir une description " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "détaillée de votre élément en" &
    " image , en Son , en Texte." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Vous pourrez retourner à la fenêtre de recherche en" &
    " cliquant" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "sur Home."
        Me.Lbl_Aide.Visible = False
        '
        'modifierSauvegarder
        '
        Me.modifierSauvegarder.AnimationHoverSpeed = 0.07!
        Me.modifierSauvegarder.AnimationSpeed = 0.03!
        Me.modifierSauvegarder.BackColor = System.Drawing.Color.Transparent
        Me.modifierSauvegarder.BaseColor = System.Drawing.Color.Lime
        Me.modifierSauvegarder.BorderColor = System.Drawing.Color.Black
        Me.modifierSauvegarder.DialogResult = System.Windows.Forms.DialogResult.None
        Me.modifierSauvegarder.FocusedColor = System.Drawing.Color.Empty
        Me.modifierSauvegarder.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modifierSauvegarder.ForeColor = System.Drawing.Color.White
        Me.modifierSauvegarder.Image = Nothing
        Me.modifierSauvegarder.ImageSize = New System.Drawing.Size(20, 20)
        Me.modifierSauvegarder.Location = New System.Drawing.Point(491, 19)
        Me.modifierSauvegarder.Name = "modifierSauvegarder"
        Me.modifierSauvegarder.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.modifierSauvegarder.OnHoverBorderColor = System.Drawing.Color.Black
        Me.modifierSauvegarder.OnHoverForeColor = System.Drawing.Color.White
        Me.modifierSauvegarder.OnHoverImage = Nothing
        Me.modifierSauvegarder.OnPressedColor = System.Drawing.Color.Black
        Me.modifierSauvegarder.Radius = 10
        Me.modifierSauvegarder.Size = New System.Drawing.Size(289, 42)
        Me.modifierSauvegarder.TabIndex = 174
        Me.modifierSauvegarder.Text = "Sauvegarder vos modifications."
        Me.modifierSauvegarder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.modifierSauvegarder.Visible = False
        '
        'lecteurMusique
        '
        Me.lecteurMusique.Enabled = True
        Me.lecteurMusique.Location = New System.Drawing.Point(309, 133)
        Me.lecteurMusique.Name = "lecteurMusique"
        Me.lecteurMusique.OcxState = CType(resources.GetObject("lecteurMusique.OcxState"), System.Windows.Forms.AxHost.State)
        Me.lecteurMusique.Size = New System.Drawing.Size(836, 449)
        Me.lecteurMusique.TabIndex = 175
        Me.lecteurMusique.Visible = False
        '
        'previousMusique
        '
        Me.previousMusique.AnimationHoverSpeed = 0.07!
        Me.previousMusique.AnimationSpeed = 0.03!
        Me.previousMusique.BackColor = System.Drawing.Color.White
        Me.previousMusique.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.previousMusique.BorderColor = System.Drawing.Color.Black
        Me.previousMusique.DialogResult = System.Windows.Forms.DialogResult.None
        Me.previousMusique.FocusedColor = System.Drawing.Color.Empty
        Me.previousMusique.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.previousMusique.ForeColor = System.Drawing.Color.White
        Me.previousMusique.Image = Nothing
        Me.previousMusique.ImageSize = New System.Drawing.Size(52, 52)
        Me.previousMusique.Location = New System.Drawing.Point(367, 555)
        Me.previousMusique.Name = "previousMusique"
        Me.previousMusique.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.previousMusique.OnHoverBorderColor = System.Drawing.Color.Black
        Me.previousMusique.OnHoverForeColor = System.Drawing.Color.White
        Me.previousMusique.OnHoverImage = Nothing
        Me.previousMusique.OnPressedColor = System.Drawing.Color.Black
        Me.previousMusique.Size = New System.Drawing.Size(20, 20)
        Me.previousMusique.TabIndex = 176
        Me.previousMusique.Text = "<"
        Me.previousMusique.Visible = False
        '
        'nextMusique
        '
        Me.nextMusique.AnimationHoverSpeed = 0.07!
        Me.nextMusique.AnimationSpeed = 0.03!
        Me.nextMusique.BackColor = System.Drawing.Color.White
        Me.nextMusique.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.nextMusique.BorderColor = System.Drawing.Color.Black
        Me.nextMusique.DialogResult = System.Windows.Forms.DialogResult.None
        Me.nextMusique.FocusedColor = System.Drawing.Color.Empty
        Me.nextMusique.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.nextMusique.ForeColor = System.Drawing.Color.White
        Me.nextMusique.Image = Nothing
        Me.nextMusique.ImageSize = New System.Drawing.Size(52, 52)
        Me.nextMusique.Location = New System.Drawing.Point(392, 555)
        Me.nextMusique.Name = "nextMusique"
        Me.nextMusique.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.nextMusique.OnHoverBorderColor = System.Drawing.Color.Black
        Me.nextMusique.OnHoverForeColor = System.Drawing.Color.White
        Me.nextMusique.OnHoverImage = Nothing
        Me.nextMusique.OnPressedColor = System.Drawing.Color.Black
        Me.nextMusique.Size = New System.Drawing.Size(20, 20)
        Me.nextMusique.TabIndex = 177
        Me.nextMusique.Text = ">"
        Me.nextMusique.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Indigo
        Me.Panel1.Controls.Add(Me.lesMotsCler)
        Me.Panel1.Controls.Add(Me.GunaAdvenceButton1)
        Me.Panel1.Controls.Add(Me.categorieElement)
        Me.Panel1.Controls.Add(Me.nomElement)
        Me.Panel1.Location = New System.Drawing.Point(264, 614)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(623, 424)
        Me.Panel1.TabIndex = 162
        Me.Panel1.Visible = False
        '
        'lesMotsCler
        '
        Me.lesMotsCler.BackColor = System.Drawing.Color.White
        Me.lesMotsCler.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lesMotsCler.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lesMotsCler.Font = New System.Drawing.Font("Open Sans Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lesMotsCler.LineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lesMotsCler.Location = New System.Drawing.Point(118, 344)
        Me.lesMotsCler.Name = "lesMotsCler"
        Me.lesMotsCler.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.lesMotsCler.Size = New System.Drawing.Size(363, 36)
        Me.lesMotsCler.TabIndex = 180
        '
        'GunaAdvenceButton1
        '
        Me.GunaAdvenceButton1.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton1.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton1.BaseColor = System.Drawing.Color.Indigo
        Me.GunaAdvenceButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.CheckedImage = Nothing
        Me.GunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton1.Font = New System.Drawing.Font("Segoe UI", 30.0!)
        Me.GunaAdvenceButton1.ForeColor = System.Drawing.Color.DimGray
        Me.GunaAdvenceButton1.Image = Global.WindowsApplication1.My.Resources.Resources.delete_50px
        Me.GunaAdvenceButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.GunaAdvenceButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton1.Location = New System.Drawing.Point(584, 3)
        Me.GunaAdvenceButton1.Name = "GunaAdvenceButton1"
        Me.GunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.MediumSlateBlue
        Me.GunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.OnHoverImage = Nothing
        Me.GunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.Size = New System.Drawing.Size(36, 30)
        Me.GunaAdvenceButton1.TabIndex = 141
        Me.GunaAdvenceButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'categorieElement
        '
        Me.categorieElement.BackColor = System.Drawing.Color.White
        Me.categorieElement.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.categorieElement.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.categorieElement.Font = New System.Drawing.Font("Open Sans Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.categorieElement.LineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.categorieElement.Location = New System.Drawing.Point(118, 245)
        Me.categorieElement.Name = "categorieElement"
        Me.categorieElement.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.categorieElement.Size = New System.Drawing.Size(363, 36)
        Me.categorieElement.TabIndex = 179
        '
        'nomElement
        '
        Me.nomElement.BackColor = System.Drawing.Color.White
        Me.nomElement.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.nomElement.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.nomElement.Font = New System.Drawing.Font("Open Sans Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nomElement.LineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.nomElement.Location = New System.Drawing.Point(118, 163)
        Me.nomElement.Name = "nomElement"
        Me.nomElement.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.nomElement.Size = New System.Drawing.Size(363, 36)
        Me.nomElement.TabIndex = 178
        '
        'lesImages
        '
        Me.lesImages.AnimationHoverSpeed = 0.07!
        Me.lesImages.AnimationSpeed = 0.03!
        Me.lesImages.BaseColor1 = System.Drawing.Color.SlateBlue
        Me.lesImages.BaseColor2 = System.Drawing.Color.Fuchsia
        Me.lesImages.BorderColor = System.Drawing.Color.Black
        Me.lesImages.DialogResult = System.Windows.Forms.DialogResult.None
        Me.lesImages.Enabled = False
        Me.lesImages.FocusedColor = System.Drawing.Color.Empty
        Me.lesImages.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lesImages.ForeColor = System.Drawing.Color.White
        Me.lesImages.Image = Nothing
        Me.lesImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.lesImages.ImageSize = New System.Drawing.Size(0, 0)
        Me.lesImages.Location = New System.Drawing.Point(15, 34)
        Me.lesImages.Name = "lesImages"
        Me.lesImages.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.lesImages.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lesImages.OnHoverBorderColor = System.Drawing.Color.Black
        Me.lesImages.OnHoverForeColor = System.Drawing.Color.White
        Me.lesImages.OnHoverImage = Nothing
        Me.lesImages.OnPressedColor = System.Drawing.Color.Black
        Me.lesImages.Size = New System.Drawing.Size(1340, 720)
        Me.lesImages.TabIndex = 160
        '
        'corbeille
        '
        Me.corbeille.AnimationHoverSpeed = 0.07!
        Me.corbeille.AnimationSpeed = 0.03!
        Me.corbeille.BackColor = System.Drawing.Color.Transparent
        Me.corbeille.BaseColor = System.Drawing.Color.DeepSkyBlue
        Me.corbeille.BorderColor = System.Drawing.Color.Black
        Me.corbeille.CheckedBaseColor = System.Drawing.Color.Gray
        Me.corbeille.CheckedBorderColor = System.Drawing.Color.Black
        Me.corbeille.CheckedForeColor = System.Drawing.Color.White
        Me.corbeille.CheckedImage = Nothing
        Me.corbeille.CheckedLineColor = System.Drawing.Color.DimGray
        Me.corbeille.DialogResult = System.Windows.Forms.DialogResult.None
        Me.corbeille.FocusedColor = System.Drawing.Color.Empty
        Me.corbeille.Font = New System.Drawing.Font("Segoe UI", 30.0!)
        Me.corbeille.ForeColor = System.Drawing.Color.DimGray
        Me.corbeille.Image = Global.WindowsApplication1.My.Resources.Resources.waste_32px
        Me.corbeille.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.corbeille.ImageSize = New System.Drawing.Size(20, 20)
        Me.corbeille.LineBottom = 1
        Me.corbeille.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.corbeille.Location = New System.Drawing.Point(164, 1)
        Me.corbeille.Name = "corbeille"
        Me.corbeille.OnHoverBaseColor = System.Drawing.Color.Indigo
        Me.corbeille.OnHoverBorderColor = System.Drawing.Color.Black
        Me.corbeille.OnHoverForeColor = System.Drawing.Color.White
        Me.corbeille.OnHoverImage = Nothing
        Me.corbeille.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.corbeille.OnPressedColor = System.Drawing.Color.Black
        Me.corbeille.Size = New System.Drawing.Size(36, 30)
        Me.corbeille.TabIndex = 178
        Me.corbeille.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'descriptionImage
        '
        Me.descriptionImage.AnimationHoverSpeed = 0.07!
        Me.descriptionImage.AnimationSpeed = 0.03!
        Me.descriptionImage.BackColor = System.Drawing.Color.Transparent
        Me.descriptionImage.BaseColor = System.Drawing.Color.DeepSkyBlue
        Me.descriptionImage.BorderColor = System.Drawing.Color.Black
        Me.descriptionImage.CheckedBaseColor = System.Drawing.Color.Gray
        Me.descriptionImage.CheckedBorderColor = System.Drawing.Color.Black
        Me.descriptionImage.CheckedForeColor = System.Drawing.Color.White
        Me.descriptionImage.CheckedImage = Nothing
        Me.descriptionImage.CheckedLineColor = System.Drawing.Color.DimGray
        Me.descriptionImage.DialogResult = System.Windows.Forms.DialogResult.None
        Me.descriptionImage.FocusedColor = System.Drawing.Color.Empty
        Me.descriptionImage.Font = New System.Drawing.Font("Segoe UI", 30.0!)
        Me.descriptionImage.ForeColor = System.Drawing.Color.DimGray
        Me.descriptionImage.Image = Global.WindowsApplication1.My.Resources.Resources.image_24px
        Me.descriptionImage.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.descriptionImage.ImageSize = New System.Drawing.Size(20, 20)
        Me.descriptionImage.LineBottom = 1
        Me.descriptionImage.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.descriptionImage.Location = New System.Drawing.Point(126, 1)
        Me.descriptionImage.Name = "descriptionImage"
        Me.descriptionImage.OnHoverBaseColor = System.Drawing.Color.Indigo
        Me.descriptionImage.OnHoverBorderColor = System.Drawing.Color.Black
        Me.descriptionImage.OnHoverForeColor = System.Drawing.Color.White
        Me.descriptionImage.OnHoverImage = Nothing
        Me.descriptionImage.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.descriptionImage.OnPressedColor = System.Drawing.Color.Black
        Me.descriptionImage.Size = New System.Drawing.Size(36, 30)
        Me.descriptionImage.TabIndex = 157
        Me.descriptionImage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'descriptionSonore
        '
        Me.descriptionSonore.AnimationHoverSpeed = 0.07!
        Me.descriptionSonore.AnimationSpeed = 0.03!
        Me.descriptionSonore.BackColor = System.Drawing.Color.Transparent
        Me.descriptionSonore.BaseColor = System.Drawing.Color.DeepSkyBlue
        Me.descriptionSonore.BorderColor = System.Drawing.Color.Black
        Me.descriptionSonore.CheckedBaseColor = System.Drawing.Color.Gray
        Me.descriptionSonore.CheckedBorderColor = System.Drawing.Color.Black
        Me.descriptionSonore.CheckedForeColor = System.Drawing.Color.White
        Me.descriptionSonore.CheckedImage = Nothing
        Me.descriptionSonore.CheckedLineColor = System.Drawing.Color.DimGray
        Me.descriptionSonore.DialogResult = System.Windows.Forms.DialogResult.None
        Me.descriptionSonore.FocusedColor = System.Drawing.Color.Empty
        Me.descriptionSonore.Font = New System.Drawing.Font("Segoe UI", 30.0!)
        Me.descriptionSonore.ForeColor = System.Drawing.Color.DimGray
        Me.descriptionSonore.Image = Global.WindowsApplication1.My.Resources.Resources.musical_notes_24px
        Me.descriptionSonore.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.descriptionSonore.ImageSize = New System.Drawing.Size(20, 20)
        Me.descriptionSonore.LineBottom = 1
        Me.descriptionSonore.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.descriptionSonore.Location = New System.Drawing.Point(89, 1)
        Me.descriptionSonore.Name = "descriptionSonore"
        Me.descriptionSonore.OnHoverBaseColor = System.Drawing.Color.Indigo
        Me.descriptionSonore.OnHoverBorderColor = System.Drawing.Color.Black
        Me.descriptionSonore.OnHoverForeColor = System.Drawing.Color.White
        Me.descriptionSonore.OnHoverImage = Nothing
        Me.descriptionSonore.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.descriptionSonore.OnPressedColor = System.Drawing.Color.Black
        Me.descriptionSonore.Size = New System.Drawing.Size(36, 30)
        Me.descriptionSonore.TabIndex = 156
        Me.descriptionSonore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'descriptionTextuelle
        '
        Me.descriptionTextuelle.AnimationHoverSpeed = 0.07!
        Me.descriptionTextuelle.AnimationSpeed = 0.03!
        Me.descriptionTextuelle.BackColor = System.Drawing.Color.Transparent
        Me.descriptionTextuelle.BaseColor = System.Drawing.Color.DeepSkyBlue
        Me.descriptionTextuelle.BorderColor = System.Drawing.Color.Black
        Me.descriptionTextuelle.CheckedBaseColor = System.Drawing.Color.Gray
        Me.descriptionTextuelle.CheckedBorderColor = System.Drawing.Color.Black
        Me.descriptionTextuelle.CheckedForeColor = System.Drawing.Color.White
        Me.descriptionTextuelle.CheckedImage = Nothing
        Me.descriptionTextuelle.CheckedLineColor = System.Drawing.Color.DimGray
        Me.descriptionTextuelle.DialogResult = System.Windows.Forms.DialogResult.None
        Me.descriptionTextuelle.FocusedColor = System.Drawing.Color.Empty
        Me.descriptionTextuelle.Font = New System.Drawing.Font("Segoe UI", 30.0!)
        Me.descriptionTextuelle.ForeColor = System.Drawing.Color.DimGray
        Me.descriptionTextuelle.Image = Global.WindowsApplication1.My.Resources.Resources.text_32px
        Me.descriptionTextuelle.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.descriptionTextuelle.ImageSize = New System.Drawing.Size(20, 20)
        Me.descriptionTextuelle.LineBottom = 1
        Me.descriptionTextuelle.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.descriptionTextuelle.Location = New System.Drawing.Point(52, 1)
        Me.descriptionTextuelle.Name = "descriptionTextuelle"
        Me.descriptionTextuelle.OnHoverBaseColor = System.Drawing.Color.Indigo
        Me.descriptionTextuelle.OnHoverBorderColor = System.Drawing.Color.Black
        Me.descriptionTextuelle.OnHoverForeColor = System.Drawing.Color.White
        Me.descriptionTextuelle.OnHoverImage = Nothing
        Me.descriptionTextuelle.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.descriptionTextuelle.OnPressedColor = System.Drawing.Color.Black
        Me.descriptionTextuelle.Size = New System.Drawing.Size(36, 30)
        Me.descriptionTextuelle.TabIndex = 155
        Me.descriptionTextuelle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'home
        '
        Me.home.AnimationHoverSpeed = 0.07!
        Me.home.AnimationSpeed = 0.03!
        Me.home.BackColor = System.Drawing.Color.Transparent
        Me.home.BaseColor = System.Drawing.Color.DeepSkyBlue
        Me.home.BorderColor = System.Drawing.Color.Black
        Me.home.CheckedBaseColor = System.Drawing.Color.Gray
        Me.home.CheckedBorderColor = System.Drawing.Color.Black
        Me.home.CheckedForeColor = System.Drawing.Color.White
        Me.home.CheckedImage = Nothing
        Me.home.CheckedLineColor = System.Drawing.Color.DimGray
        Me.home.DialogResult = System.Windows.Forms.DialogResult.None
        Me.home.FocusedColor = System.Drawing.Color.Empty
        Me.home.Font = New System.Drawing.Font("Segoe UI", 30.0!)
        Me.home.ForeColor = System.Drawing.Color.DimGray
        Me.home.Image = CType(resources.GetObject("home.Image"), System.Drawing.Image)
        Me.home.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.home.ImageSize = New System.Drawing.Size(20, 20)
        Me.home.LineBottom = 1
        Me.home.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.home.Location = New System.Drawing.Point(15, 1)
        Me.home.Name = "home"
        Me.home.OnHoverBaseColor = System.Drawing.Color.Indigo
        Me.home.OnHoverBorderColor = System.Drawing.Color.Black
        Me.home.OnHoverForeColor = System.Drawing.Color.White
        Me.home.OnHoverImage = Nothing
        Me.home.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.home.OnPressedColor = System.Drawing.Color.Black
        Me.home.Size = New System.Drawing.Size(36, 30)
        Me.home.TabIndex = 154
        Me.home.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Reduire
        '
        Me.Reduire.AnimationHoverSpeed = 0.07!
        Me.Reduire.AnimationSpeed = 0.03!
        Me.Reduire.BackColor = System.Drawing.Color.Transparent
        Me.Reduire.BaseColor = System.Drawing.Color.LightSteelBlue
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
        Me.Reduire.Location = New System.Drawing.Point(1297, -1)
        Me.Reduire.Name = "Reduire"
        Me.Reduire.OnHoverBaseColor = System.Drawing.Color.Indigo
        Me.Reduire.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Reduire.OnHoverForeColor = System.Drawing.Color.White
        Me.Reduire.OnHoverImage = Nothing
        Me.Reduire.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Reduire.OnPressedColor = System.Drawing.Color.Black
        Me.Reduire.Size = New System.Drawing.Size(36, 30)
        Me.Reduire.TabIndex = 114
        Me.Reduire.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Fermer
        '
        Me.Fermer.AnimationHoverSpeed = 0.07!
        Me.Fermer.AnimationSpeed = 0.03!
        Me.Fermer.BackColor = System.Drawing.Color.Transparent
        Me.Fermer.BaseColor = System.Drawing.Color.LightSteelBlue
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
        Me.Fermer.Location = New System.Drawing.Point(1334, -1)
        Me.Fermer.Name = "Fermer"
        Me.Fermer.OnHoverBaseColor = System.Drawing.Color.Indigo
        Me.Fermer.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Fermer.OnHoverForeColor = System.Drawing.Color.White
        Me.Fermer.OnHoverImage = Nothing
        Me.Fermer.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Fermer.OnPressedColor = System.Drawing.Color.Black
        Me.Fermer.Size = New System.Drawing.Size(36, 30)
        Me.Fermer.TabIndex = 113
        Me.Fermer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'aide
        '
        Me.aide.AnimationHoverSpeed = 0.07!
        Me.aide.AnimationSpeed = 0.03!
        Me.aide.BackColor = System.Drawing.Color.Transparent
        Me.aide.BaseColor = System.Drawing.Color.LightSteelBlue
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
        Me.aide.Location = New System.Drawing.Point(1260, -1)
        Me.aide.Name = "aide"
        Me.aide.OnHoverBaseColor = System.Drawing.Color.Indigo
        Me.aide.OnHoverBorderColor = System.Drawing.Color.Black
        Me.aide.OnHoverForeColor = System.Drawing.Color.White
        Me.aide.OnHoverImage = Nothing
        Me.aide.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.aide.OnPressedColor = System.Drawing.Color.Black
        Me.aide.Size = New System.Drawing.Size(36, 30)
        Me.aide.TabIndex = 115
        Me.aide.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaImageButton23
        '
        Me.GunaImageButton23.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.sphere_128px
        Me.GunaImageButton23.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaImageButton23.Image = Nothing
        Me.GunaImageButton23.ImageSize = New System.Drawing.Size(64, 64)
        Me.GunaImageButton23.Location = New System.Drawing.Point(-12, -65)
        Me.GunaImageButton23.Name = "GunaImageButton23"
        Me.GunaImageButton23.OnHoverImage = Nothing
        Me.GunaImageButton23.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.GunaImageButton23.Size = New System.Drawing.Size(130, 126)
        Me.GunaImageButton23.TabIndex = 151
        '
        'GunaImageButton21
        '
        Me.GunaImageButton21.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.sphere_128px
        Me.GunaImageButton21.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaImageButton21.Image = Nothing
        Me.GunaImageButton21.ImageSize = New System.Drawing.Size(64, 64)
        Me.GunaImageButton21.Location = New System.Drawing.Point(650, -74)
        Me.GunaImageButton21.Name = "GunaImageButton21"
        Me.GunaImageButton21.OnHoverImage = Nothing
        Me.GunaImageButton21.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.GunaImageButton21.Size = New System.Drawing.Size(130, 126)
        Me.GunaImageButton21.TabIndex = 150
        '
        'GunaImageButton20
        '
        Me.GunaImageButton20.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.sphere_128px
        Me.GunaImageButton20.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaImageButton20.Image = Nothing
        Me.GunaImageButton20.ImageSize = New System.Drawing.Size(64, 64)
        Me.GunaImageButton20.Location = New System.Drawing.Point(421, 235)
        Me.GunaImageButton20.Name = "GunaImageButton20"
        Me.GunaImageButton20.OnHoverImage = Nothing
        Me.GunaImageButton20.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.GunaImageButton20.Size = New System.Drawing.Size(130, 126)
        Me.GunaImageButton20.TabIndex = 147
        '
        'GunaImageButton19
        '
        Me.GunaImageButton19.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.sphere_128px
        Me.GunaImageButton19.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaImageButton19.Image = Nothing
        Me.GunaImageButton19.ImageSize = New System.Drawing.Size(64, 64)
        Me.GunaImageButton19.Location = New System.Drawing.Point(703, 486)
        Me.GunaImageButton19.Name = "GunaImageButton19"
        Me.GunaImageButton19.OnHoverImage = Nothing
        Me.GunaImageButton19.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.GunaImageButton19.Size = New System.Drawing.Size(130, 126)
        Me.GunaImageButton19.TabIndex = 144
        '
        'GunaImageButton18
        '
        Me.GunaImageButton18.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.sphere_128px
        Me.GunaImageButton18.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaImageButton18.Image = Nothing
        Me.GunaImageButton18.ImageSize = New System.Drawing.Size(64, 64)
        Me.GunaImageButton18.Location = New System.Drawing.Point(570, 482)
        Me.GunaImageButton18.Name = "GunaImageButton18"
        Me.GunaImageButton18.OnHoverImage = Nothing
        Me.GunaImageButton18.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.GunaImageButton18.Size = New System.Drawing.Size(130, 126)
        Me.GunaImageButton18.TabIndex = 143
        '
        'GunaImageButton17
        '
        Me.GunaImageButton17.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.sphere_128px
        Me.GunaImageButton17.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaImageButton17.Image = Nothing
        Me.GunaImageButton17.ImageSize = New System.Drawing.Size(64, 64)
        Me.GunaImageButton17.Location = New System.Drawing.Point(671, 350)
        Me.GunaImageButton17.Name = "GunaImageButton17"
        Me.GunaImageButton17.OnHoverImage = Nothing
        Me.GunaImageButton17.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.GunaImageButton17.Size = New System.Drawing.Size(130, 126)
        Me.GunaImageButton17.TabIndex = 142
        '
        'GunaImageButton16
        '
        Me.GunaImageButton16.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.sphere_128px
        Me.GunaImageButton16.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaImageButton16.Image = Nothing
        Me.GunaImageButton16.ImageSize = New System.Drawing.Size(64, 64)
        Me.GunaImageButton16.Location = New System.Drawing.Point(535, 322)
        Me.GunaImageButton16.Name = "GunaImageButton16"
        Me.GunaImageButton16.OnHoverImage = Nothing
        Me.GunaImageButton16.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.GunaImageButton16.Size = New System.Drawing.Size(130, 126)
        Me.GunaImageButton16.TabIndex = 141
        '
        'GunaImageButton15
        '
        Me.GunaImageButton15.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.sphere_128px
        Me.GunaImageButton15.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaImageButton15.Image = Nothing
        Me.GunaImageButton15.ImageSize = New System.Drawing.Size(64, 64)
        Me.GunaImageButton15.Location = New System.Drawing.Point(160, 441)
        Me.GunaImageButton15.Name = "GunaImageButton15"
        Me.GunaImageButton15.OnHoverImage = Nothing
        Me.GunaImageButton15.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.GunaImageButton15.Size = New System.Drawing.Size(130, 126)
        Me.GunaImageButton15.TabIndex = 140
        '
        'GunaImageButton14
        '
        Me.GunaImageButton14.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.sphere_128px
        Me.GunaImageButton14.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaImageButton14.Image = Nothing
        Me.GunaImageButton14.ImageSize = New System.Drawing.Size(64, 64)
        Me.GunaImageButton14.Location = New System.Drawing.Point(407, 441)
        Me.GunaImageButton14.Name = "GunaImageButton14"
        Me.GunaImageButton14.OnHoverImage = Nothing
        Me.GunaImageButton14.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.GunaImageButton14.Size = New System.Drawing.Size(130, 126)
        Me.GunaImageButton14.TabIndex = 139
        '
        'GunaImageButton13
        '
        Me.GunaImageButton13.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.sphere_128px
        Me.GunaImageButton13.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaImageButton13.Image = Nothing
        Me.GunaImageButton13.ImageSize = New System.Drawing.Size(64, 64)
        Me.GunaImageButton13.Location = New System.Drawing.Point(285, 322)
        Me.GunaImageButton13.Name = "GunaImageButton13"
        Me.GunaImageButton13.OnHoverImage = Nothing
        Me.GunaImageButton13.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.GunaImageButton13.Size = New System.Drawing.Size(130, 126)
        Me.GunaImageButton13.TabIndex = 138
        '
        'GunaImageButton12
        '
        Me.GunaImageButton12.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.sphere_128px
        Me.GunaImageButton12.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaImageButton12.Image = Nothing
        Me.GunaImageButton12.ImageSize = New System.Drawing.Size(64, 64)
        Me.GunaImageButton12.Location = New System.Drawing.Point(670, 200)
        Me.GunaImageButton12.Name = "GunaImageButton12"
        Me.GunaImageButton12.OnHoverImage = Nothing
        Me.GunaImageButton12.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.GunaImageButton12.Size = New System.Drawing.Size(130, 126)
        Me.GunaImageButton12.TabIndex = 137
        '
        'GunaImageButton11
        '
        Me.GunaImageButton11.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.sphere_128px
        Me.GunaImageButton11.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaImageButton11.Image = Nothing
        Me.GunaImageButton11.ImageSize = New System.Drawing.Size(64, 64)
        Me.GunaImageButton11.Location = New System.Drawing.Point(392, 86)
        Me.GunaImageButton11.Name = "GunaImageButton11"
        Me.GunaImageButton11.OnHoverImage = Nothing
        Me.GunaImageButton11.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.GunaImageButton11.Size = New System.Drawing.Size(130, 126)
        Me.GunaImageButton11.TabIndex = 136
        '
        'GunaImageButton9
        '
        Me.GunaImageButton9.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.sphere_128px
        Me.GunaImageButton9.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaImageButton9.Image = Nothing
        Me.GunaImageButton9.ImageSize = New System.Drawing.Size(64, 64)
        Me.GunaImageButton9.Location = New System.Drawing.Point(237, 119)
        Me.GunaImageButton9.Name = "GunaImageButton9"
        Me.GunaImageButton9.OnHoverImage = Nothing
        Me.GunaImageButton9.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.GunaImageButton9.Size = New System.Drawing.Size(130, 126)
        Me.GunaImageButton9.TabIndex = 135
        '
        'GunaImageButton8
        '
        Me.GunaImageButton8.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.sphere_128px
        Me.GunaImageButton8.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaImageButton8.Image = Nothing
        Me.GunaImageButton8.ImageSize = New System.Drawing.Size(64, 64)
        Me.GunaImageButton8.Location = New System.Drawing.Point(135, 235)
        Me.GunaImageButton8.Name = "GunaImageButton8"
        Me.GunaImageButton8.OnHoverImage = Nothing
        Me.GunaImageButton8.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.GunaImageButton8.Size = New System.Drawing.Size(130, 126)
        Me.GunaImageButton8.TabIndex = 134
        '
        'GunaImageButton7
        '
        Me.GunaImageButton7.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.sphere_128px
        Me.GunaImageButton7.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaImageButton7.Image = Nothing
        Me.GunaImageButton7.ImageSize = New System.Drawing.Size(64, 64)
        Me.GunaImageButton7.Location = New System.Drawing.Point(12, 379)
        Me.GunaImageButton7.Name = "GunaImageButton7"
        Me.GunaImageButton7.OnHoverImage = Nothing
        Me.GunaImageButton7.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.GunaImageButton7.Size = New System.Drawing.Size(130, 126)
        Me.GunaImageButton7.TabIndex = 133
        '
        'GunaImageButton6
        '
        Me.GunaImageButton6.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.sphere_128px
        Me.GunaImageButton6.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaImageButton6.Image = Nothing
        Me.GunaImageButton6.ImageSize = New System.Drawing.Size(64, 64)
        Me.GunaImageButton6.Location = New System.Drawing.Point(796, 209)
        Me.GunaImageButton6.Name = "GunaImageButton6"
        Me.GunaImageButton6.OnHoverImage = Nothing
        Me.GunaImageButton6.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.GunaImageButton6.Size = New System.Drawing.Size(130, 126)
        Me.GunaImageButton6.TabIndex = 132
        '
        'GunaImageButton5
        '
        Me.GunaImageButton5.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.sphere_128px
        Me.GunaImageButton5.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaImageButton5.Image = Nothing
        Me.GunaImageButton5.ImageSize = New System.Drawing.Size(64, 64)
        Me.GunaImageButton5.Location = New System.Drawing.Point(713, 58)
        Me.GunaImageButton5.Name = "GunaImageButton5"
        Me.GunaImageButton5.OnHoverImage = Nothing
        Me.GunaImageButton5.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.GunaImageButton5.Size = New System.Drawing.Size(130, 126)
        Me.GunaImageButton5.TabIndex = 131
        '
        'GunaImageButton4
        '
        Me.GunaImageButton4.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.sphere_128px
        Me.GunaImageButton4.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaImageButton4.Image = Nothing
        Me.GunaImageButton4.ImageSize = New System.Drawing.Size(64, 64)
        Me.GunaImageButton4.Location = New System.Drawing.Point(535, 34)
        Me.GunaImageButton4.Name = "GunaImageButton4"
        Me.GunaImageButton4.OnHoverImage = Nothing
        Me.GunaImageButton4.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.GunaImageButton4.Size = New System.Drawing.Size(130, 126)
        Me.GunaImageButton4.TabIndex = 130
        '
        'GunaImageButton3
        '
        Me.GunaImageButton3.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.sphere_128px
        Me.GunaImageButton3.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaImageButton3.Image = Nothing
        Me.GunaImageButton3.ImageSize = New System.Drawing.Size(64, 64)
        Me.GunaImageButton3.Location = New System.Drawing.Point(392, -46)
        Me.GunaImageButton3.Name = "GunaImageButton3"
        Me.GunaImageButton3.OnHoverImage = Nothing
        Me.GunaImageButton3.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.GunaImageButton3.Size = New System.Drawing.Size(130, 126)
        Me.GunaImageButton3.TabIndex = 129
        '
        'GunaImageButton2
        '
        Me.GunaImageButton2.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.sphere_128px
        Me.GunaImageButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaImageButton2.Image = Nothing
        Me.GunaImageButton2.ImageSize = New System.Drawing.Size(64, 64)
        Me.GunaImageButton2.Location = New System.Drawing.Point(214, -46)
        Me.GunaImageButton2.Name = "GunaImageButton2"
        Me.GunaImageButton2.OnHoverImage = Nothing
        Me.GunaImageButton2.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.GunaImageButton2.Size = New System.Drawing.Size(130, 126)
        Me.GunaImageButton2.TabIndex = 128
        '
        'GunaImageButton1
        '
        Me.GunaImageButton1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.sphere_128px
        Me.GunaImageButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaImageButton1.Image = Nothing
        Me.GunaImageButton1.ImageSize = New System.Drawing.Size(64, 64)
        Me.GunaImageButton1.Location = New System.Drawing.Point(78, 67)
        Me.GunaImageButton1.Name = "GunaImageButton1"
        Me.GunaImageButton1.OnHoverImage = Nothing
        Me.GunaImageButton1.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.GunaImageButton1.Size = New System.Drawing.Size(130, 126)
        Me.GunaImageButton1.TabIndex = 127
        '
        'GunaImageButton10
        '
        Me.GunaImageButton10.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.sphere_128px
        Me.GunaImageButton10.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaImageButton10.Image = Nothing
        Me.GunaImageButton10.ImageSize = New System.Drawing.Size(64, 64)
        Me.GunaImageButton10.Location = New System.Drawing.Point(-23, 190)
        Me.GunaImageButton10.Name = "GunaImageButton10"
        Me.GunaImageButton10.OnHoverImage = Nothing
        Me.GunaImageButton10.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.GunaImageButton10.Size = New System.Drawing.Size(130, 126)
        Me.GunaImageButton10.TabIndex = 126
        '
        'supprimerInfo
        '
        Me.supprimerInfo.AutoSize = True
        Me.supprimerInfo.BackColor = System.Drawing.Color.Red
        Me.supprimerInfo.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.supprimerInfo.ForeColor = System.Drawing.Color.White
        Me.supprimerInfo.Location = New System.Drawing.Point(204, 6)
        Me.supprimerInfo.Name = "supprimerInfo"
        Me.supprimerInfo.Size = New System.Drawing.Size(225, 19)
        Me.supprimerInfo.TabIndex = 179
        Me.supprimerInfo.Text = "Supprimer l'information enregistrée"
        Me.supprimerInfo.Visible = False
        '
        'panneauDeSuppression
        '
        Me.panneauDeSuppression.Controls.Add(Me.Btn_Oui)
        Me.panneauDeSuppression.Controls.Add(Me.Btn_Non)
        Me.panneauDeSuppression.Controls.Add(Me.Label2)
        Me.panneauDeSuppression.Controls.Add(Me.Lbl_NomElmtASupprimer)
        Me.panneauDeSuppression.Location = New System.Drawing.Point(437, 283)
        Me.panneauDeSuppression.Name = "panneauDeSuppression"
        Me.panneauDeSuppression.Size = New System.Drawing.Size(537, 245)
        Me.panneauDeSuppression.TabIndex = 180
        Me.panneauDeSuppression.Visible = False
        '
        'Btn_Oui
        '
        Me.Btn_Oui.AnimationHoverSpeed = 0.07!
        Me.Btn_Oui.AnimationSpeed = 0.03!
        Me.Btn_Oui.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Oui.BaseColor = System.Drawing.Color.Red
        Me.Btn_Oui.BorderColor = System.Drawing.Color.Black
        Me.Btn_Oui.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Btn_Oui.FocusedColor = System.Drawing.Color.Empty
        Me.Btn_Oui.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Oui.ForeColor = System.Drawing.Color.White
        Me.Btn_Oui.Image = Nothing
        Me.Btn_Oui.ImageSize = New System.Drawing.Size(20, 20)
        Me.Btn_Oui.Location = New System.Drawing.Point(170, 184)
        Me.Btn_Oui.Name = "Btn_Oui"
        Me.Btn_Oui.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_Oui.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btn_Oui.OnHoverForeColor = System.Drawing.Color.White
        Me.Btn_Oui.OnHoverImage = Nothing
        Me.Btn_Oui.OnPressedColor = System.Drawing.Color.Black
        Me.Btn_Oui.Radius = 10
        Me.Btn_Oui.Size = New System.Drawing.Size(108, 42)
        Me.Btn_Oui.TabIndex = 182
        Me.Btn_Oui.Text = "OUI"
        Me.Btn_Oui.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Btn_Non
        '
        Me.Btn_Non.AnimationHoverSpeed = 0.07!
        Me.Btn_Non.AnimationSpeed = 0.03!
        Me.Btn_Non.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Non.BaseColor = System.Drawing.Color.Lime
        Me.Btn_Non.BorderColor = System.Drawing.Color.Black
        Me.Btn_Non.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Btn_Non.FocusedColor = System.Drawing.Color.Empty
        Me.Btn_Non.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Non.ForeColor = System.Drawing.Color.White
        Me.Btn_Non.Image = Nothing
        Me.Btn_Non.ImageSize = New System.Drawing.Size(20, 20)
        Me.Btn_Non.Location = New System.Drawing.Point(281, 184)
        Me.Btn_Non.Name = "Btn_Non"
        Me.Btn_Non.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_Non.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Btn_Non.OnHoverForeColor = System.Drawing.Color.White
        Me.Btn_Non.OnHoverImage = Nothing
        Me.Btn_Non.OnPressedColor = System.Drawing.Color.Black
        Me.Btn_Non.Radius = 10
        Me.Btn_Non.Size = New System.Drawing.Size(108, 42)
        Me.Btn_Non.TabIndex = 181
        Me.Btn_Non.Text = "NON"
        Me.Btn_Non.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(113, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(334, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Voulez vous vraiment supprimer l'élément :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_NomElmtASupprimer
        '
        Me.Lbl_NomElmtASupprimer.Font = New System.Drawing.Font("Gill Sans MT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_NomElmtASupprimer.Location = New System.Drawing.Point(-37, 91)
        Me.Lbl_NomElmtASupprimer.Name = "Lbl_NomElmtASupprimer"
        Me.Lbl_NomElmtASupprimer.Size = New System.Drawing.Size(627, 70)
        Me.Lbl_NomElmtASupprimer.TabIndex = 0
        Me.Lbl_NomElmtASupprimer.Text = "Bin"
        Me.Lbl_NomElmtASupprimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'msg_ImageInexistante1
        '
        Me.msg_ImageInexistante1.AnimationHoverSpeed = 0.07!
        Me.msg_ImageInexistante1.AnimationSpeed = 0.03!
        Me.msg_ImageInexistante1.BaseColor1 = System.Drawing.Color.SlateBlue
        Me.msg_ImageInexistante1.BaseColor2 = System.Drawing.Color.Fuchsia
        Me.msg_ImageInexistante1.BorderColor = System.Drawing.Color.Black
        Me.msg_ImageInexistante1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.msg_ImageInexistante1.Enabled = False
        Me.msg_ImageInexistante1.FocusedColor = System.Drawing.Color.Empty
        Me.msg_ImageInexistante1.Font = New System.Drawing.Font("Open Sans Light", 19.0!)
        Me.msg_ImageInexistante1.ForeColor = System.Drawing.Color.White
        Me.msg_ImageInexistante1.Image = Nothing
        Me.msg_ImageInexistante1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.msg_ImageInexistante1.ImageSize = New System.Drawing.Size(0, 0)
        Me.msg_ImageInexistante1.Location = New System.Drawing.Point(407, 186)
        Me.msg_ImageInexistante1.Name = "msg_ImageInexistante1"
        Me.msg_ImageInexistante1.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.msg_ImageInexistante1.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.msg_ImageInexistante1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.msg_ImageInexistante1.OnHoverForeColor = System.Drawing.Color.White
        Me.msg_ImageInexistante1.OnHoverImage = Nothing
        Me.msg_ImageInexistante1.OnPressedColor = System.Drawing.Color.Black
        Me.msg_ImageInexistante1.Size = New System.Drawing.Size(580, 91)
        Me.msg_ImageInexistante1.TabIndex = 181
        Me.msg_ImageInexistante1.Text = "Aucune image à afficher."
        Me.msg_ImageInexistante1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.msg_ImageInexistante1.Visible = False
        '
        'msg_ImageInexistante2
        '
        Me.msg_ImageInexistante2.AnimationHoverSpeed = 0.07!
        Me.msg_ImageInexistante2.AnimationSpeed = 0.03!
        Me.msg_ImageInexistante2.BaseColor1 = System.Drawing.Color.SlateBlue
        Me.msg_ImageInexistante2.BaseColor2 = System.Drawing.Color.Fuchsia
        Me.msg_ImageInexistante2.BorderColor = System.Drawing.Color.Black
        Me.msg_ImageInexistante2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.msg_ImageInexistante2.Enabled = False
        Me.msg_ImageInexistante2.FocusedColor = System.Drawing.Color.Empty
        Me.msg_ImageInexistante2.Font = New System.Drawing.Font("Open Sans Light", 14.0!)
        Me.msg_ImageInexistante2.ForeColor = System.Drawing.Color.White
        Me.msg_ImageInexistante2.Image = Nothing
        Me.msg_ImageInexistante2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.msg_ImageInexistante2.ImageSize = New System.Drawing.Size(0, 0)
        Me.msg_ImageInexistante2.Location = New System.Drawing.Point(407, 252)
        Me.msg_ImageInexistante2.Name = "msg_ImageInexistante2"
        Me.msg_ImageInexistante2.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.msg_ImageInexistante2.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.msg_ImageInexistante2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.msg_ImageInexistante2.OnHoverForeColor = System.Drawing.Color.White
        Me.msg_ImageInexistante2.OnHoverImage = Nothing
        Me.msg_ImageInexistante2.OnPressedColor = System.Drawing.Color.Black
        Me.msg_ImageInexistante2.Size = New System.Drawing.Size(580, 22)
        Me.msg_ImageInexistante2.TabIndex = 182
        Me.msg_ImageInexistante2.Text = "assurez vous que l'image n'ai  pas été supprimée ou modifiée."
        Me.msg_ImageInexistante2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.msg_ImageInexistante2.Visible = False
        '
        'Decrire_ImageSonTexte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(1354, 733)
        Me.Controls.Add(Me.msg_ImageInexistante2)
        Me.Controls.Add(Me.msg_ImageInexistante1)
        Me.Controls.Add(Me.panneauDeSuppression)
        Me.Controls.Add(Me.supprimerInfo)
        Me.Controls.Add(Me.corbeille)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.nextMusique)
        Me.Controls.Add(Me.previousMusique)
        Me.Controls.Add(Me.lecteurMusique)
        Me.Controls.Add(Me.modifierSauvegarder)
        Me.Controls.Add(Me.Lbl_Aide)
        Me.Controls.Add(Me.ChampTextuel)
        Me.Controls.Add(Me.nextImage)
        Me.Controls.Add(Me.previousImage)
        Me.Controls.Add(Me.Lbl_Fermer)
        Me.Controls.Add(Me.Lbl_Reduire)
        Me.Controls.Add(Me.Lbl_Home)
        Me.Controls.Add(Me.Lbl_DescriptionImage)
        Me.Controls.Add(Me.Lbl_DescriptionTextuelle)
        Me.Controls.Add(Me.Lbl_DescriptionSonore)
        Me.Controls.Add(Me.lesImages)
        Me.Controls.Add(Me.descriptionImage)
        Me.Controls.Add(Me.descriptionSonore)
        Me.Controls.Add(Me.descriptionTextuelle)
        Me.Controls.Add(Me.home)
        Me.Controls.Add(Me.Reduire)
        Me.Controls.Add(Me.Fermer)
        Me.Controls.Add(Me.aide)
        Me.Controls.Add(Me.GunaImageButton23)
        Me.Controls.Add(Me.GunaImageButton21)
        Me.Controls.Add(Me.GunaImageButton20)
        Me.Controls.Add(Me.GunaImageButton19)
        Me.Controls.Add(Me.GunaImageButton18)
        Me.Controls.Add(Me.GunaImageButton17)
        Me.Controls.Add(Me.GunaImageButton16)
        Me.Controls.Add(Me.GunaImageButton15)
        Me.Controls.Add(Me.GunaImageButton14)
        Me.Controls.Add(Me.GunaImageButton13)
        Me.Controls.Add(Me.GunaImageButton12)
        Me.Controls.Add(Me.GunaImageButton11)
        Me.Controls.Add(Me.GunaImageButton9)
        Me.Controls.Add(Me.GunaImageButton8)
        Me.Controls.Add(Me.GunaImageButton7)
        Me.Controls.Add(Me.GunaImageButton6)
        Me.Controls.Add(Me.GunaImageButton5)
        Me.Controls.Add(Me.GunaImageButton4)
        Me.Controls.Add(Me.GunaImageButton3)
        Me.Controls.Add(Me.GunaImageButton2)
        Me.Controls.Add(Me.GunaImageButton1)
        Me.Controls.Add(Me.GunaImageButton10)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Decrire_ImageSonTexte"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Caractéristiques de l'élément"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.lecteurMusique, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.panneauDeSuppression.ResumeLayout(False)
        Me.panneauDeSuppression.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GunaImageButton10 As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents GunaImageButton1 As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents GunaImageButton2 As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents GunaImageButton3 As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents GunaImageButton4 As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents GunaImageButton5 As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents GunaImageButton6 As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents GunaImageButton7 As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents GunaImageButton8 As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents GunaImageButton9 As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents GunaImageButton11 As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents GunaImageButton12 As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents GunaImageButton13 As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents GunaImageButton14 As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents GunaImageButton15 As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents GunaImageButton16 As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents GunaImageButton17 As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents GunaImageButton18 As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents GunaImageButton19 As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents GunaImageButton20 As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents GunaImageButton21 As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents GunaImageButton23 As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents Fermer As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents aide As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Reduire As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents home As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents descriptionTextuelle As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents descriptionSonore As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents descriptionImage As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents lesImages As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents afficherLesInfosBulles As Timer
    Friend WithEvents Lbl_DescriptionSonore As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Lbl_DescriptionTextuelle As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Lbl_DescriptionImage As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Lbl_Home As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Lbl_Reduire As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Lbl_Fermer As Guna.UI.WinForms.GunaLabel
    Friend WithEvents previousImage As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents nextImage As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents ChampTextuel As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Lbl_Aide As Guna.UI.WinForms.GunaLabel
    Friend WithEvents modifierSauvegarder As Guna.UI.WinForms.GunaButton
    Friend WithEvents lecteurMusique As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents previousMusique As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents nextMusique As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GunaAdvenceButton1 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents lesMotsCler As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents categorieElement As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents nomElement As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents corbeille As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents supprimerInfo As Guna.UI.WinForms.GunaLabel
    Friend WithEvents panneauDeSuppression As Guna.UI.WinForms.GunaPanel
    Friend WithEvents Btn_Oui As Guna.UI.WinForms.GunaButton
    Friend WithEvents Btn_Non As Guna.UI.WinForms.GunaButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Lbl_NomElmtASupprimer As Label
    Friend WithEvents msg_ImageInexistante1 As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents msg_ImageInexistante2 As Guna.UI.WinForms.GunaGradientButton
End Class
