<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FenetreTousLesElementsEtBarreDeRecherche
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FenetreTousLesElementsEtBarreDeRecherche))
        Me.TousLesElementsEtBarreDeRecherche = New Guna.UI.WinForms.GunaLabel()
        Me.elements = New Guna.UI.WinForms.GunaLabel()
        Me.TimerChangerCouleur = New System.Windows.Forms.Timer(Me.components)
        Me.laDate = New Guna.UI.WinForms.GunaLabel()
        Me.rendreLaDateVisible = New System.Windows.Forms.Timer(Me.components)
        Me.nbrTotalDelements = New Guna.UI.WinForms.GunaLabel()
        Me.ajouterDesElements = New Guna.UI.WinForms.GunaCircleButton()
        Me.aideSupport = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.cercleActif = New Guna.UI.WinForms.GunaImageButton()
        Me.bouttonDescendre = New Guna.UI.WinForms.GunaCircleButton()
        Me.bouttonMonter = New Guna.UI.WinForms.GunaCircleButton()
        Me.GunaImageButton22 = New Guna.UI.WinForms.GunaImageButton()
        Me.GunaImageButton21 = New Guna.UI.WinForms.GunaImageButton()
        Me.element_1 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.element_2 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.element_7 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.element_6 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.element_5 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.element_4 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.element_3 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaImageButton20 = New Guna.UI.WinForms.GunaImageButton()
        Me.GunaImageButton19 = New Guna.UI.WinForms.GunaImageButton()
        Me.GunaImageButton18 = New Guna.UI.WinForms.GunaImageButton()
        Me.GunaImageButton17 = New Guna.UI.WinForms.GunaImageButton()
        Me.GunaImageButton16 = New Guna.UI.WinForms.GunaImageButton()
        Me.GunaImageButton15 = New Guna.UI.WinForms.GunaImageButton()
        Me.GunaImageButton14 = New Guna.UI.WinForms.GunaImageButton()
        Me.GunaImageButton12 = New Guna.UI.WinForms.GunaImageButton()
        Me.GunaImageButton11 = New Guna.UI.WinForms.GunaImageButton()
        Me.GunaImageButton10 = New Guna.UI.WinForms.GunaImageButton()
        Me.GunaImageButton6 = New Guna.UI.WinForms.GunaImageButton()
        Me.GunaImageButton9 = New Guna.UI.WinForms.GunaImageButton()
        Me.GunaImageButton8 = New Guna.UI.WinForms.GunaImageButton()
        Me.GunaImageButton7 = New Guna.UI.WinForms.GunaImageButton()
        Me.GunaImageButton5 = New Guna.UI.WinForms.GunaImageButton()
        Me.GunaImageButton4 = New Guna.UI.WinForms.GunaImageButton()
        Me.GunaImageButton3 = New Guna.UI.WinForms.GunaImageButton()
        Me.GunaImageButton2 = New Guna.UI.WinForms.GunaImageButton()
        Me.GunaImageButton1 = New Guna.UI.WinForms.GunaImageButton()
        Me.GunaImageButton13 = New Guna.UI.WinForms.GunaImageButton()
        Me.Reduire = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Fermer = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.curseur = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.motClerEtResultat = New Guna.UI.WinForms.GunaLabel()
        Me.barreDeRecherche = New Guna.UI.WinForms.GunaTextBox()
        Me.bouttonRecherche = New Guna.UI.WinForms.GunaButton()
        Me.info1 = New Guna.UI.WinForms.GunaLabel()
        Me.info2 = New Guna.UI.WinForms.GunaLabel()
        Me.info3 = New Guna.UI.WinForms.GunaLabel()
        Me.afficherInfoBulle = New System.Windows.Forms.Timer(Me.components)
        Me.Lbl_Aide = New Guna.UI.WinForms.GunaLabel()
        Me.NumeroBouttonActif = New Guna.UI.WinForms.GunaLabel()
        Me.index_Resultat1 = New Guna.UI.WinForms.GunaLabel()
        Me.index_Resultat2 = New Guna.UI.WinForms.GunaLabel()
        Me.index_Resultat3 = New Guna.UI.WinForms.GunaLabel()
        Me.index_Resultat4 = New Guna.UI.WinForms.GunaLabel()
        Me.index_Resultat5 = New Guna.UI.WinForms.GunaLabel()
        Me.index_Resultat6 = New Guna.UI.WinForms.GunaLabel()
        Me.index_Resultat7 = New Guna.UI.WinForms.GunaLabel()
        Me.dernierResultat = New Guna.UI.WinForms.GunaLabel()
        Me.SuspendLayout()
        '
        'TousLesElementsEtBarreDeRecherche
        '
        Me.TousLesElementsEtBarreDeRecherche.AutoSize = True
        Me.TousLesElementsEtBarreDeRecherche.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TousLesElementsEtBarreDeRecherche.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TousLesElementsEtBarreDeRecherche.Location = New System.Drawing.Point(10, 527)
        Me.TousLesElementsEtBarreDeRecherche.Name = "TousLesElementsEtBarreDeRecherche"
        Me.TousLesElementsEtBarreDeRecherche.Size = New System.Drawing.Size(88, 21)
        Me.TousLesElementsEtBarreDeRecherche.TabIndex = 20
        Me.TousLesElementsEtBarreDeRecherche.Text = "Rechercher"
        Me.TousLesElementsEtBarreDeRecherche.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'elements
        '
        Me.elements.AutoSize = True
        Me.elements.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.elements.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.elements.Location = New System.Drawing.Point(109, 527)
        Me.elements.Name = "elements"
        Me.elements.Size = New System.Drawing.Size(98, 21)
        Me.elements.TabIndex = 24
        Me.elements.Text = "Tous Les élé.."
        Me.elements.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TimerChangerCouleur
        '
        '
        'laDate
        '
        Me.laDate.AutoSize = True
        Me.laDate.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.laDate.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.laDate.Location = New System.Drawing.Point(671, 120)
        Me.laDate.Name = "laDate"
        Me.laDate.Size = New System.Drawing.Size(146, 21)
        Me.laDate.TabIndex = 94
        Me.laDate.Text = "Créé le 13/05/2021"
        Me.laDate.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.laDate.Visible = False
        '
        'rendreLaDateVisible
        '
        Me.rendreLaDateVisible.Interval = 500
        '
        'nbrTotalDelements
        '
        Me.nbrTotalDelements.AutoSize = True
        Me.nbrTotalDelements.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.nbrTotalDelements.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.nbrTotalDelements.Location = New System.Drawing.Point(767, 517)
        Me.nbrTotalDelements.Name = "nbrTotalDelements"
        Me.nbrTotalDelements.Size = New System.Drawing.Size(76, 21)
        Me.nbrTotalDelements.TabIndex = 119
        Me.nbrTotalDelements.Text = "1 sur 100"
        Me.nbrTotalDelements.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.nbrTotalDelements.Visible = False
        '
        'ajouterDesElements
        '
        Me.ajouterDesElements.AnimationHoverSpeed = 0.07!
        Me.ajouterDesElements.AnimationSpeed = 0.03!
        Me.ajouterDesElements.BackColor = System.Drawing.Color.Transparent
        Me.ajouterDesElements.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ajouterDesElements.BorderColor = System.Drawing.Color.Black
        Me.ajouterDesElements.DialogResult = System.Windows.Forms.DialogResult.None
        Me.ajouterDesElements.FocusedColor = System.Drawing.Color.Empty
        Me.ajouterDesElements.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.ajouterDesElements.ForeColor = System.Drawing.Color.White
        Me.ajouterDesElements.Image = Global.WindowsApplication1.My.Resources.Resources.plus_math_50px
        Me.ajouterDesElements.ImageSize = New System.Drawing.Size(30, 30)
        Me.ajouterDesElements.Location = New System.Drawing.Point(850, 405)
        Me.ajouterDesElements.Name = "ajouterDesElements"
        Me.ajouterDesElements.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ajouterDesElements.OnHoverBorderColor = System.Drawing.Color.Black
        Me.ajouterDesElements.OnHoverForeColor = System.Drawing.Color.White
        Me.ajouterDesElements.OnHoverImage = Nothing
        Me.ajouterDesElements.OnPressedColor = System.Drawing.Color.Indigo
        Me.ajouterDesElements.Size = New System.Drawing.Size(45, 45)
        Me.ajouterDesElements.TabIndex = 118
        Me.ajouterDesElements.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAliasGridFit
        '
        'aideSupport
        '
        Me.aideSupport.AnimationHoverSpeed = 0.07!
        Me.aideSupport.AnimationSpeed = 0.03!
        Me.aideSupport.BackColor = System.Drawing.Color.Transparent
        Me.aideSupport.BaseColor = System.Drawing.Color.DeepSkyBlue
        Me.aideSupport.BorderColor = System.Drawing.Color.Black
        Me.aideSupport.CheckedBaseColor = System.Drawing.Color.Gray
        Me.aideSupport.CheckedBorderColor = System.Drawing.Color.Black
        Me.aideSupport.CheckedForeColor = System.Drawing.Color.White
        Me.aideSupport.CheckedImage = Nothing
        Me.aideSupport.CheckedLineColor = System.Drawing.Color.DimGray
        Me.aideSupport.DialogResult = System.Windows.Forms.DialogResult.None
        Me.aideSupport.FocusedColor = System.Drawing.Color.Empty
        Me.aideSupport.Font = New System.Drawing.Font("Segoe UI", 30.0!)
        Me.aideSupport.ForeColor = System.Drawing.Color.DimGray
        Me.aideSupport.Image = Global.WindowsApplication1.My.Resources.Resources.help_100px
        Me.aideSupport.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.aideSupport.ImageSize = New System.Drawing.Size(20, 20)
        Me.aideSupport.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.aideSupport.Location = New System.Drawing.Point(786, -2)
        Me.aideSupport.Name = "aideSupport"
        Me.aideSupport.OnHoverBaseColor = System.Drawing.Color.CornflowerBlue
        Me.aideSupport.OnHoverBorderColor = System.Drawing.Color.Black
        Me.aideSupport.OnHoverForeColor = System.Drawing.Color.White
        Me.aideSupport.OnHoverImage = Nothing
        Me.aideSupport.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.aideSupport.OnPressedColor = System.Drawing.Color.Black
        Me.aideSupport.Size = New System.Drawing.Size(36, 30)
        Me.aideSupport.TabIndex = 116
        Me.aideSupport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cercleActif
        '
        Me.cercleActif.BackColor = System.Drawing.Color.Indigo
        Me.cercleActif.DialogResult = System.Windows.Forms.DialogResult.None
        Me.cercleActif.Image = Global.WindowsApplication1.My.Resources.Resources.new_moon_24px
        Me.cercleActif.ImageSize = New System.Drawing.Size(20, 20)
        Me.cercleActif.Location = New System.Drawing.Point(627, 117)
        Me.cercleActif.Name = "cercleActif"
        Me.cercleActif.OnHoverImage = Nothing
        Me.cercleActif.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.cercleActif.Size = New System.Drawing.Size(28, 29)
        Me.cercleActif.TabIndex = 95
        '
        'bouttonDescendre
        '
        Me.bouttonDescendre.AnimationHoverSpeed = 0.07!
        Me.bouttonDescendre.AnimationSpeed = 0.03!
        Me.bouttonDescendre.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bouttonDescendre.BorderColor = System.Drawing.Color.Black
        Me.bouttonDescendre.DialogResult = System.Windows.Forms.DialogResult.None
        Me.bouttonDescendre.FocusedColor = System.Drawing.Color.Empty
        Me.bouttonDescendre.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.bouttonDescendre.ForeColor = System.Drawing.Color.White
        Me.bouttonDescendre.Image = Global.WindowsApplication1.My.Resources.Resources.down_arrow_50px
        Me.bouttonDescendre.ImageSize = New System.Drawing.Size(32, 32)
        Me.bouttonDescendre.Location = New System.Drawing.Point(849, 505)
        Me.bouttonDescendre.Name = "bouttonDescendre"
        Me.bouttonDescendre.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bouttonDescendre.OnHoverBorderColor = System.Drawing.Color.Black
        Me.bouttonDescendre.OnHoverForeColor = System.Drawing.Color.White
        Me.bouttonDescendre.OnHoverImage = Nothing
        Me.bouttonDescendre.OnPressedColor = System.Drawing.Color.Black
        Me.bouttonDescendre.Size = New System.Drawing.Size(45, 45)
        Me.bouttonDescendre.TabIndex = 93
        '
        'bouttonMonter
        '
        Me.bouttonMonter.AnimationHoverSpeed = 0.07!
        Me.bouttonMonter.AnimationSpeed = 0.03!
        Me.bouttonMonter.BackColor = System.Drawing.Color.Transparent
        Me.bouttonMonter.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bouttonMonter.BorderColor = System.Drawing.Color.Black
        Me.bouttonMonter.DialogResult = System.Windows.Forms.DialogResult.None
        Me.bouttonMonter.FocusedColor = System.Drawing.Color.Empty
        Me.bouttonMonter.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.bouttonMonter.ForeColor = System.Drawing.Color.White
        Me.bouttonMonter.Image = Global.WindowsApplication1.My.Resources.Resources.up_50px
        Me.bouttonMonter.ImageSize = New System.Drawing.Size(32, 32)
        Me.bouttonMonter.Location = New System.Drawing.Point(849, 454)
        Me.bouttonMonter.Name = "bouttonMonter"
        Me.bouttonMonter.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bouttonMonter.OnHoverBorderColor = System.Drawing.Color.Black
        Me.bouttonMonter.OnHoverForeColor = System.Drawing.Color.White
        Me.bouttonMonter.OnHoverImage = Nothing
        Me.bouttonMonter.OnPressedColor = System.Drawing.Color.Indigo
        Me.bouttonMonter.Size = New System.Drawing.Size(45, 45)
        Me.bouttonMonter.TabIndex = 92
        Me.bouttonMonter.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAliasGridFit
        '
        'GunaImageButton22
        '
        Me.GunaImageButton22.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.sphere_128px
        Me.GunaImageButton22.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaImageButton22.Image = Nothing
        Me.GunaImageButton22.ImageSize = New System.Drawing.Size(64, 64)
        Me.GunaImageButton22.Location = New System.Drawing.Point(657, 524)
        Me.GunaImageButton22.Name = "GunaImageButton22"
        Me.GunaImageButton22.OnHoverImage = Nothing
        Me.GunaImageButton22.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.GunaImageButton22.Size = New System.Drawing.Size(130, 126)
        Me.GunaImageButton22.TabIndex = 89
        '
        'GunaImageButton21
        '
        Me.GunaImageButton21.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.sphere_128px
        Me.GunaImageButton21.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaImageButton21.Image = Nothing
        Me.GunaImageButton21.ImageSize = New System.Drawing.Size(64, 64)
        Me.GunaImageButton21.Location = New System.Drawing.Point(445, 491)
        Me.GunaImageButton21.Name = "GunaImageButton21"
        Me.GunaImageButton21.OnHoverImage = Nothing
        Me.GunaImageButton21.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.GunaImageButton21.Size = New System.Drawing.Size(130, 126)
        Me.GunaImageButton21.TabIndex = 88
        '
        'element_1
        '
        Me.element_1.AnimationHoverSpeed = 0.07!
        Me.element_1.AnimationSpeed = 0.03!
        Me.element_1.BackColor = System.Drawing.Color.Transparent
        Me.element_1.BaseColor = System.Drawing.Color.White
        Me.element_1.BorderColor = System.Drawing.Color.Black
        Me.element_1.CheckedBaseColor = System.Drawing.Color.Gray
        Me.element_1.CheckedBorderColor = System.Drawing.Color.Black
        Me.element_1.CheckedForeColor = System.Drawing.Color.White
        Me.element_1.CheckedImage = CType(resources.GetObject("element_1.CheckedImage"), System.Drawing.Image)
        Me.element_1.CheckedLineColor = System.Drawing.Color.DimGray
        Me.element_1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.element_1.FocusedColor = System.Drawing.Color.Empty
        Me.element_1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.element_1.ForeColor = System.Drawing.Color.DimGray
        Me.element_1.Image = CType(resources.GetObject("element_1.Image"), System.Drawing.Image)
        Me.element_1.ImageSize = New System.Drawing.Size(20, 20)
        Me.element_1.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.element_1.Location = New System.Drawing.Point(256, 108)
        Me.element_1.Name = "element_1"
        Me.element_1.OnHoverBaseColor = System.Drawing.Color.Indigo
        Me.element_1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.element_1.OnHoverForeColor = System.Drawing.Color.White
        Me.element_1.OnHoverImage = Nothing
        Me.element_1.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.element_1.OnPressedColor = System.Drawing.Color.Black
        Me.element_1.Radius = 10
        Me.element_1.Size = New System.Drawing.Size(412, 42)
        Me.element_1.TabIndex = 87
        '
        'element_2
        '
        Me.element_2.AnimationHoverSpeed = 0.07!
        Me.element_2.AnimationSpeed = 0.03!
        Me.element_2.BackColor = System.Drawing.Color.Transparent
        Me.element_2.BaseColor = System.Drawing.Color.White
        Me.element_2.BorderColor = System.Drawing.Color.Black
        Me.element_2.CheckedBaseColor = System.Drawing.Color.Gray
        Me.element_2.CheckedBorderColor = System.Drawing.Color.Black
        Me.element_2.CheckedForeColor = System.Drawing.Color.White
        Me.element_2.CheckedImage = CType(resources.GetObject("element_2.CheckedImage"), System.Drawing.Image)
        Me.element_2.CheckedLineColor = System.Drawing.Color.DimGray
        Me.element_2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.element_2.FocusedColor = System.Drawing.Color.Empty
        Me.element_2.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.element_2.ForeColor = System.Drawing.Color.DimGray
        Me.element_2.Image = CType(resources.GetObject("element_2.Image"), System.Drawing.Image)
        Me.element_2.ImageSize = New System.Drawing.Size(20, 20)
        Me.element_2.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.element_2.Location = New System.Drawing.Point(256, 156)
        Me.element_2.Name = "element_2"
        Me.element_2.OnHoverBaseColor = System.Drawing.Color.Indigo
        Me.element_2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.element_2.OnHoverForeColor = System.Drawing.Color.White
        Me.element_2.OnHoverImage = Nothing
        Me.element_2.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.element_2.OnPressedColor = System.Drawing.Color.Black
        Me.element_2.Radius = 10
        Me.element_2.Size = New System.Drawing.Size(412, 42)
        Me.element_2.TabIndex = 86
        '
        'element_7
        '
        Me.element_7.AnimationHoverSpeed = 0.07!
        Me.element_7.AnimationSpeed = 0.03!
        Me.element_7.BackColor = System.Drawing.Color.Transparent
        Me.element_7.BaseColor = System.Drawing.Color.White
        Me.element_7.BorderColor = System.Drawing.Color.Black
        Me.element_7.CheckedBaseColor = System.Drawing.Color.Gray
        Me.element_7.CheckedBorderColor = System.Drawing.Color.Black
        Me.element_7.CheckedForeColor = System.Drawing.Color.White
        Me.element_7.CheckedImage = CType(resources.GetObject("element_7.CheckedImage"), System.Drawing.Image)
        Me.element_7.CheckedLineColor = System.Drawing.Color.DimGray
        Me.element_7.DialogResult = System.Windows.Forms.DialogResult.None
        Me.element_7.FocusedColor = System.Drawing.Color.Empty
        Me.element_7.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.element_7.ForeColor = System.Drawing.Color.DimGray
        Me.element_7.Image = CType(resources.GetObject("element_7.Image"), System.Drawing.Image)
        Me.element_7.ImageSize = New System.Drawing.Size(20, 20)
        Me.element_7.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.element_7.Location = New System.Drawing.Point(256, 396)
        Me.element_7.Name = "element_7"
        Me.element_7.OnHoverBaseColor = System.Drawing.Color.Indigo
        Me.element_7.OnHoverBorderColor = System.Drawing.Color.Black
        Me.element_7.OnHoverForeColor = System.Drawing.Color.White
        Me.element_7.OnHoverImage = Nothing
        Me.element_7.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.element_7.OnPressedColor = System.Drawing.Color.Black
        Me.element_7.Radius = 10
        Me.element_7.Size = New System.Drawing.Size(412, 42)
        Me.element_7.TabIndex = 85
        '
        'element_6
        '
        Me.element_6.AnimationHoverSpeed = 0.07!
        Me.element_6.AnimationSpeed = 0.03!
        Me.element_6.BackColor = System.Drawing.Color.Transparent
        Me.element_6.BaseColor = System.Drawing.Color.White
        Me.element_6.BorderColor = System.Drawing.Color.Black
        Me.element_6.CheckedBaseColor = System.Drawing.Color.Gray
        Me.element_6.CheckedBorderColor = System.Drawing.Color.Black
        Me.element_6.CheckedForeColor = System.Drawing.Color.White
        Me.element_6.CheckedImage = CType(resources.GetObject("element_6.CheckedImage"), System.Drawing.Image)
        Me.element_6.CheckedLineColor = System.Drawing.Color.DimGray
        Me.element_6.DialogResult = System.Windows.Forms.DialogResult.None
        Me.element_6.FocusedColor = System.Drawing.Color.Empty
        Me.element_6.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.element_6.ForeColor = System.Drawing.Color.DimGray
        Me.element_6.Image = CType(resources.GetObject("element_6.Image"), System.Drawing.Image)
        Me.element_6.ImageSize = New System.Drawing.Size(20, 20)
        Me.element_6.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.element_6.Location = New System.Drawing.Point(256, 348)
        Me.element_6.Name = "element_6"
        Me.element_6.OnHoverBaseColor = System.Drawing.Color.Indigo
        Me.element_6.OnHoverBorderColor = System.Drawing.Color.Black
        Me.element_6.OnHoverForeColor = System.Drawing.Color.White
        Me.element_6.OnHoverImage = Nothing
        Me.element_6.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.element_6.OnPressedColor = System.Drawing.Color.Black
        Me.element_6.Radius = 10
        Me.element_6.Size = New System.Drawing.Size(412, 42)
        Me.element_6.TabIndex = 84
        '
        'element_5
        '
        Me.element_5.AnimationHoverSpeed = 0.07!
        Me.element_5.AnimationSpeed = 0.03!
        Me.element_5.BackColor = System.Drawing.Color.Transparent
        Me.element_5.BaseColor = System.Drawing.Color.White
        Me.element_5.BorderColor = System.Drawing.Color.Black
        Me.element_5.CheckedBaseColor = System.Drawing.Color.Gray
        Me.element_5.CheckedBorderColor = System.Drawing.Color.Black
        Me.element_5.CheckedForeColor = System.Drawing.Color.White
        Me.element_5.CheckedImage = CType(resources.GetObject("element_5.CheckedImage"), System.Drawing.Image)
        Me.element_5.CheckedLineColor = System.Drawing.Color.DimGray
        Me.element_5.DialogResult = System.Windows.Forms.DialogResult.None
        Me.element_5.FocusedColor = System.Drawing.Color.Empty
        Me.element_5.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.element_5.ForeColor = System.Drawing.Color.DimGray
        Me.element_5.Image = CType(resources.GetObject("element_5.Image"), System.Drawing.Image)
        Me.element_5.ImageSize = New System.Drawing.Size(20, 20)
        Me.element_5.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.element_5.Location = New System.Drawing.Point(256, 300)
        Me.element_5.Name = "element_5"
        Me.element_5.OnHoverBaseColor = System.Drawing.Color.Indigo
        Me.element_5.OnHoverBorderColor = System.Drawing.Color.Black
        Me.element_5.OnHoverForeColor = System.Drawing.Color.White
        Me.element_5.OnHoverImage = Nothing
        Me.element_5.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.element_5.OnPressedColor = System.Drawing.Color.Black
        Me.element_5.Radius = 10
        Me.element_5.Size = New System.Drawing.Size(412, 42)
        Me.element_5.TabIndex = 83
        '
        'element_4
        '
        Me.element_4.AnimationHoverSpeed = 0.07!
        Me.element_4.AnimationSpeed = 0.03!
        Me.element_4.BackColor = System.Drawing.Color.Transparent
        Me.element_4.BaseColor = System.Drawing.Color.White
        Me.element_4.BorderColor = System.Drawing.Color.Black
        Me.element_4.CheckedBaseColor = System.Drawing.Color.Gray
        Me.element_4.CheckedBorderColor = System.Drawing.Color.Black
        Me.element_4.CheckedForeColor = System.Drawing.Color.White
        Me.element_4.CheckedImage = CType(resources.GetObject("element_4.CheckedImage"), System.Drawing.Image)
        Me.element_4.CheckedLineColor = System.Drawing.Color.DimGray
        Me.element_4.DialogResult = System.Windows.Forms.DialogResult.None
        Me.element_4.FocusedColor = System.Drawing.Color.Empty
        Me.element_4.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.element_4.ForeColor = System.Drawing.Color.DimGray
        Me.element_4.Image = CType(resources.GetObject("element_4.Image"), System.Drawing.Image)
        Me.element_4.ImageSize = New System.Drawing.Size(20, 20)
        Me.element_4.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.element_4.Location = New System.Drawing.Point(256, 252)
        Me.element_4.Name = "element_4"
        Me.element_4.OnHoverBaseColor = System.Drawing.Color.Indigo
        Me.element_4.OnHoverBorderColor = System.Drawing.Color.Black
        Me.element_4.OnHoverForeColor = System.Drawing.Color.White
        Me.element_4.OnHoverImage = Nothing
        Me.element_4.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.element_4.OnPressedColor = System.Drawing.Color.Black
        Me.element_4.Radius = 10
        Me.element_4.Size = New System.Drawing.Size(412, 42)
        Me.element_4.TabIndex = 82
        '
        'element_3
        '
        Me.element_3.AnimationHoverSpeed = 0.07!
        Me.element_3.AnimationSpeed = 0.03!
        Me.element_3.BackColor = System.Drawing.Color.Transparent
        Me.element_3.BaseColor = System.Drawing.Color.White
        Me.element_3.BorderColor = System.Drawing.Color.Black
        Me.element_3.CheckedBaseColor = System.Drawing.Color.Gray
        Me.element_3.CheckedBorderColor = System.Drawing.Color.Black
        Me.element_3.CheckedForeColor = System.Drawing.Color.White
        Me.element_3.CheckedImage = CType(resources.GetObject("element_3.CheckedImage"), System.Drawing.Image)
        Me.element_3.CheckedLineColor = System.Drawing.Color.DimGray
        Me.element_3.DialogResult = System.Windows.Forms.DialogResult.None
        Me.element_3.FocusedColor = System.Drawing.Color.Empty
        Me.element_3.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.element_3.ForeColor = System.Drawing.Color.DimGray
        Me.element_3.Image = CType(resources.GetObject("element_3.Image"), System.Drawing.Image)
        Me.element_3.ImageSize = New System.Drawing.Size(20, 20)
        Me.element_3.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.element_3.Location = New System.Drawing.Point(256, 204)
        Me.element_3.Name = "element_3"
        Me.element_3.OnHoverBaseColor = System.Drawing.Color.Indigo
        Me.element_3.OnHoverBorderColor = System.Drawing.Color.Black
        Me.element_3.OnHoverForeColor = System.Drawing.Color.White
        Me.element_3.OnHoverImage = Nothing
        Me.element_3.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.element_3.OnPressedColor = System.Drawing.Color.Black
        Me.element_3.Radius = 10
        Me.element_3.Size = New System.Drawing.Size(412, 42)
        Me.element_3.TabIndex = 81
        '
        'GunaImageButton20
        '
        Me.GunaImageButton20.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.sphere_128px
        Me.GunaImageButton20.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaImageButton20.Image = Nothing
        Me.GunaImageButton20.ImageSize = New System.Drawing.Size(64, 64)
        Me.GunaImageButton20.Location = New System.Drawing.Point(398, 355)
        Me.GunaImageButton20.Name = "GunaImageButton20"
        Me.GunaImageButton20.OnHoverImage = Nothing
        Me.GunaImageButton20.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.GunaImageButton20.Size = New System.Drawing.Size(130, 126)
        Me.GunaImageButton20.TabIndex = 80
        '
        'GunaImageButton19
        '
        Me.GunaImageButton19.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.sphere_128px
        Me.GunaImageButton19.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaImageButton19.Image = Nothing
        Me.GunaImageButton19.ImageSize = New System.Drawing.Size(64, 64)
        Me.GunaImageButton19.Location = New System.Drawing.Point(302, 489)
        Me.GunaImageButton19.Name = "GunaImageButton19"
        Me.GunaImageButton19.OnHoverImage = Nothing
        Me.GunaImageButton19.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.GunaImageButton19.Size = New System.Drawing.Size(130, 126)
        Me.GunaImageButton19.TabIndex = 79
        '
        'GunaImageButton18
        '
        Me.GunaImageButton18.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.sphere_128px
        Me.GunaImageButton18.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaImageButton18.Image = Nothing
        Me.GunaImageButton18.ImageSize = New System.Drawing.Size(64, 64)
        Me.GunaImageButton18.Location = New System.Drawing.Point(137, 398)
        Me.GunaImageButton18.Name = "GunaImageButton18"
        Me.GunaImageButton18.OnHoverImage = Nothing
        Me.GunaImageButton18.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.GunaImageButton18.Size = New System.Drawing.Size(130, 126)
        Me.GunaImageButton18.TabIndex = 78
        '
        'GunaImageButton17
        '
        Me.GunaImageButton17.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.sphere_128px
        Me.GunaImageButton17.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaImageButton17.Image = Nothing
        Me.GunaImageButton17.ImageSize = New System.Drawing.Size(64, 64)
        Me.GunaImageButton17.Location = New System.Drawing.Point(571, 405)
        Me.GunaImageButton17.Name = "GunaImageButton17"
        Me.GunaImageButton17.OnHoverImage = Nothing
        Me.GunaImageButton17.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.GunaImageButton17.Size = New System.Drawing.Size(130, 126)
        Me.GunaImageButton17.TabIndex = 77
        '
        'GunaImageButton16
        '
        Me.GunaImageButton16.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.sphere_128px
        Me.GunaImageButton16.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaImageButton16.Image = Nothing
        Me.GunaImageButton16.ImageSize = New System.Drawing.Size(64, 64)
        Me.GunaImageButton16.Location = New System.Drawing.Point(642, 189)
        Me.GunaImageButton16.Name = "GunaImageButton16"
        Me.GunaImageButton16.OnHoverImage = Nothing
        Me.GunaImageButton16.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.GunaImageButton16.Size = New System.Drawing.Size(130, 126)
        Me.GunaImageButton16.TabIndex = 75
        '
        'GunaImageButton15
        '
        Me.GunaImageButton15.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.sphere_128px
        Me.GunaImageButton15.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaImageButton15.Image = Nothing
        Me.GunaImageButton15.ImageSize = New System.Drawing.Size(64, 64)
        Me.GunaImageButton15.Location = New System.Drawing.Point(813, 252)
        Me.GunaImageButton15.Name = "GunaImageButton15"
        Me.GunaImageButton15.OnHoverImage = Nothing
        Me.GunaImageButton15.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.GunaImageButton15.Size = New System.Drawing.Size(130, 126)
        Me.GunaImageButton15.TabIndex = 73
        '
        'GunaImageButton14
        '
        Me.GunaImageButton14.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.sphere_128px
        Me.GunaImageButton14.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaImageButton14.Image = Nothing
        Me.GunaImageButton14.ImageSize = New System.Drawing.Size(64, 64)
        Me.GunaImageButton14.Location = New System.Drawing.Point(687, 311)
        Me.GunaImageButton14.Name = "GunaImageButton14"
        Me.GunaImageButton14.OnHoverImage = Nothing
        Me.GunaImageButton14.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.GunaImageButton14.Size = New System.Drawing.Size(130, 126)
        Me.GunaImageButton14.TabIndex = 72
        '
        'GunaImageButton12
        '
        Me.GunaImageButton12.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.sphere_128px
        Me.GunaImageButton12.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaImageButton12.Image = Nothing
        Me.GunaImageButton12.ImageSize = New System.Drawing.Size(64, 64)
        Me.GunaImageButton12.Location = New System.Drawing.Point(788, 124)
        Me.GunaImageButton12.Name = "GunaImageButton12"
        Me.GunaImageButton12.OnHoverImage = Nothing
        Me.GunaImageButton12.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.GunaImageButton12.Size = New System.Drawing.Size(130, 126)
        Me.GunaImageButton12.TabIndex = 71
        '
        'GunaImageButton11
        '
        Me.GunaImageButton11.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.sphere_128px
        Me.GunaImageButton11.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaImageButton11.Image = Nothing
        Me.GunaImageButton11.ImageSize = New System.Drawing.Size(64, 64)
        Me.GunaImageButton11.Location = New System.Drawing.Point(586, -51)
        Me.GunaImageButton11.Name = "GunaImageButton11"
        Me.GunaImageButton11.OnHoverImage = Nothing
        Me.GunaImageButton11.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.GunaImageButton11.Size = New System.Drawing.Size(130, 126)
        Me.GunaImageButton11.TabIndex = 70
        '
        'GunaImageButton10
        '
        Me.GunaImageButton10.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.sphere_128px
        Me.GunaImageButton10.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaImageButton10.Image = Nothing
        Me.GunaImageButton10.ImageSize = New System.Drawing.Size(64, 64)
        Me.GunaImageButton10.Location = New System.Drawing.Point(661, 71)
        Me.GunaImageButton10.Name = "GunaImageButton10"
        Me.GunaImageButton10.OnHoverImage = Nothing
        Me.GunaImageButton10.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.GunaImageButton10.Size = New System.Drawing.Size(130, 126)
        Me.GunaImageButton10.TabIndex = 70
        '
        'GunaImageButton6
        '
        Me.GunaImageButton6.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.sphere_128px
        Me.GunaImageButton6.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaImageButton6.Image = Nothing
        Me.GunaImageButton6.ImageSize = New System.Drawing.Size(64, 64)
        Me.GunaImageButton6.Location = New System.Drawing.Point(450, -44)
        Me.GunaImageButton6.Name = "GunaImageButton6"
        Me.GunaImageButton6.OnHoverImage = Nothing
        Me.GunaImageButton6.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.GunaImageButton6.Size = New System.Drawing.Size(130, 126)
        Me.GunaImageButton6.TabIndex = 69
        '
        'GunaImageButton9
        '
        Me.GunaImageButton9.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.sphere_128px
        Me.GunaImageButton9.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaImageButton9.Image = Nothing
        Me.GunaImageButton9.ImageSize = New System.Drawing.Size(64, 64)
        Me.GunaImageButton9.Location = New System.Drawing.Point(199, 279)
        Me.GunaImageButton9.Name = "GunaImageButton9"
        Me.GunaImageButton9.OnHoverImage = Nothing
        Me.GunaImageButton9.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.GunaImageButton9.Size = New System.Drawing.Size(130, 126)
        Me.GunaImageButton9.TabIndex = 53
        '
        'GunaImageButton8
        '
        Me.GunaImageButton8.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.sphere_128px
        Me.GunaImageButton8.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaImageButton8.Image = Nothing
        Me.GunaImageButton8.ImageSize = New System.Drawing.Size(64, 64)
        Me.GunaImageButton8.Location = New System.Drawing.Point(-63, 189)
        Me.GunaImageButton8.Name = "GunaImageButton8"
        Me.GunaImageButton8.OnHoverImage = Nothing
        Me.GunaImageButton8.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.GunaImageButton8.Size = New System.Drawing.Size(130, 126)
        Me.GunaImageButton8.TabIndex = 52
        '
        'GunaImageButton7
        '
        Me.GunaImageButton7.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.sphere_128px
        Me.GunaImageButton7.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaImageButton7.Image = Nothing
        Me.GunaImageButton7.ImageSize = New System.Drawing.Size(64, 64)
        Me.GunaImageButton7.Location = New System.Drawing.Point(-37, 348)
        Me.GunaImageButton7.Name = "GunaImageButton7"
        Me.GunaImageButton7.OnHoverImage = Nothing
        Me.GunaImageButton7.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.GunaImageButton7.Size = New System.Drawing.Size(130, 126)
        Me.GunaImageButton7.TabIndex = 51
        '
        'GunaImageButton5
        '
        Me.GunaImageButton5.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.sphere_128px
        Me.GunaImageButton5.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaImageButton5.Image = Nothing
        Me.GunaImageButton5.ImageSize = New System.Drawing.Size(64, 64)
        Me.GunaImageButton5.Location = New System.Drawing.Point(313, -43)
        Me.GunaImageButton5.Name = "GunaImageButton5"
        Me.GunaImageButton5.OnHoverImage = Nothing
        Me.GunaImageButton5.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.GunaImageButton5.Size = New System.Drawing.Size(130, 126)
        Me.GunaImageButton5.TabIndex = 50
        '
        'GunaImageButton4
        '
        Me.GunaImageButton4.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.sphere_128px
        Me.GunaImageButton4.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaImageButton4.Image = Nothing
        Me.GunaImageButton4.ImageSize = New System.Drawing.Size(64, 64)
        Me.GunaImageButton4.Location = New System.Drawing.Point(182, 48)
        Me.GunaImageButton4.Name = "GunaImageButton4"
        Me.GunaImageButton4.OnHoverImage = Nothing
        Me.GunaImageButton4.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.GunaImageButton4.Size = New System.Drawing.Size(130, 126)
        Me.GunaImageButton4.TabIndex = 49
        '
        'GunaImageButton3
        '
        Me.GunaImageButton3.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.sphere_128px
        Me.GunaImageButton3.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaImageButton3.Image = Nothing
        Me.GunaImageButton3.ImageSize = New System.Drawing.Size(64, 64)
        Me.GunaImageButton3.Location = New System.Drawing.Point(98, -72)
        Me.GunaImageButton3.Name = "GunaImageButton3"
        Me.GunaImageButton3.OnHoverImage = Nothing
        Me.GunaImageButton3.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.GunaImageButton3.Size = New System.Drawing.Size(130, 126)
        Me.GunaImageButton3.TabIndex = 48
        '
        'GunaImageButton2
        '
        Me.GunaImageButton2.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.sphere_128px
        Me.GunaImageButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaImageButton2.Image = Nothing
        Me.GunaImageButton2.ImageSize = New System.Drawing.Size(64, 64)
        Me.GunaImageButton2.Location = New System.Drawing.Point(58, 113)
        Me.GunaImageButton2.Name = "GunaImageButton2"
        Me.GunaImageButton2.OnHoverImage = Nothing
        Me.GunaImageButton2.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.GunaImageButton2.Size = New System.Drawing.Size(130, 126)
        Me.GunaImageButton2.TabIndex = 47
        '
        'GunaImageButton1
        '
        Me.GunaImageButton1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.sphere_128px
        Me.GunaImageButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaImageButton1.Image = Nothing
        Me.GunaImageButton1.ImageSize = New System.Drawing.Size(64, 64)
        Me.GunaImageButton1.Location = New System.Drawing.Point(69, 252)
        Me.GunaImageButton1.Name = "GunaImageButton1"
        Me.GunaImageButton1.OnHoverImage = Nothing
        Me.GunaImageButton1.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.GunaImageButton1.Size = New System.Drawing.Size(130, 126)
        Me.GunaImageButton1.TabIndex = 46
        '
        'GunaImageButton13
        '
        Me.GunaImageButton13.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.sphere_128px
        Me.GunaImageButton13.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaImageButton13.Image = Nothing
        Me.GunaImageButton13.ImageSize = New System.Drawing.Size(64, 64)
        Me.GunaImageButton13.Location = New System.Drawing.Point(-33, -14)
        Me.GunaImageButton13.Name = "GunaImageButton13"
        Me.GunaImageButton13.OnHoverImage = Nothing
        Me.GunaImageButton13.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.GunaImageButton13.Size = New System.Drawing.Size(130, 126)
        Me.GunaImageButton13.TabIndex = 43
        '
        'Reduire
        '
        Me.Reduire.AnimationHoverSpeed = 0.07!
        Me.Reduire.AnimationSpeed = 0.03!
        Me.Reduire.BackColor = System.Drawing.Color.Transparent
        Me.Reduire.BaseColor = System.Drawing.Color.DeepSkyBlue
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
        Me.Reduire.Location = New System.Drawing.Point(827, -3)
        Me.Reduire.Name = "Reduire"
        Me.Reduire.OnHoverBaseColor = System.Drawing.Color.CornflowerBlue
        Me.Reduire.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Reduire.OnHoverForeColor = System.Drawing.Color.White
        Me.Reduire.OnHoverImage = Nothing
        Me.Reduire.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Reduire.OnPressedColor = System.Drawing.Color.Black
        Me.Reduire.Size = New System.Drawing.Size(36, 30)
        Me.Reduire.TabIndex = 26
        Me.Reduire.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Fermer
        '
        Me.Fermer.AnimationHoverSpeed = 0.07!
        Me.Fermer.AnimationSpeed = 0.03!
        Me.Fermer.BackColor = System.Drawing.Color.Transparent
        Me.Fermer.BaseColor = System.Drawing.Color.DeepSkyBlue
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
        Me.Fermer.Location = New System.Drawing.Point(863, -3)
        Me.Fermer.Name = "Fermer"
        Me.Fermer.OnHoverBaseColor = System.Drawing.Color.CornflowerBlue
        Me.Fermer.OnHoverBorderColor = System.Drawing.Color.Black
        Me.Fermer.OnHoverForeColor = System.Drawing.Color.White
        Me.Fermer.OnHoverImage = Nothing
        Me.Fermer.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Fermer.OnPressedColor = System.Drawing.Color.Black
        Me.Fermer.Size = New System.Drawing.Size(36, 30)
        Me.Fermer.TabIndex = 25
        Me.Fermer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'curseur
        '
        Me.curseur.AnimationHoverSpeed = 0.07!
        Me.curseur.AnimationSpeed = 0.03!
        Me.curseur.BackColor = System.Drawing.Color.Transparent
        Me.curseur.BaseColor = System.Drawing.Color.DarkOrchid
        Me.curseur.BorderColor = System.Drawing.Color.Black
        Me.curseur.CheckedBaseColor = System.Drawing.Color.Gray
        Me.curseur.CheckedBorderColor = System.Drawing.Color.Black
        Me.curseur.CheckedForeColor = System.Drawing.Color.White
        Me.curseur.CheckedImage = CType(resources.GetObject("curseur.CheckedImage"), System.Drawing.Image)
        Me.curseur.CheckedLineColor = System.Drawing.Color.DimGray
        Me.curseur.DialogResult = System.Windows.Forms.DialogResult.None
        Me.curseur.FocusedColor = System.Drawing.Color.Empty
        Me.curseur.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.curseur.ForeColor = System.Drawing.Color.DimGray
        Me.curseur.Image = Nothing
        Me.curseur.ImageSize = New System.Drawing.Size(20, 20)
        Me.curseur.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.curseur.Location = New System.Drawing.Point(10, 548)
        Me.curseur.Name = "curseur"
        Me.curseur.OnHoverBaseColor = System.Drawing.Color.MediumOrchid
        Me.curseur.OnHoverBorderColor = System.Drawing.Color.Black
        Me.curseur.OnHoverForeColor = System.Drawing.Color.White
        Me.curseur.OnHoverImage = Nothing
        Me.curseur.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.curseur.OnPressedColor = System.Drawing.Color.Black
        Me.curseur.Size = New System.Drawing.Size(95, 10)
        Me.curseur.TabIndex = 19
        '
        'motClerEtResultat
        '
        Me.motClerEtResultat.AutoSize = True
        Me.motClerEtResultat.BackColor = System.Drawing.Color.Lime
        Me.motClerEtResultat.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.motClerEtResultat.ForeColor = System.Drawing.Color.DimGray
        Me.motClerEtResultat.Location = New System.Drawing.Point(0, 0)
        Me.motClerEtResultat.Name = "motClerEtResultat"
        Me.motClerEtResultat.Size = New System.Drawing.Size(0, 21)
        Me.motClerEtResultat.TabIndex = 132
        Me.motClerEtResultat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'barreDeRecherche
        '
        Me.barreDeRecherche.BackColor = System.Drawing.Color.Transparent
        Me.barreDeRecherche.BaseColor = System.Drawing.Color.White
        Me.barreDeRecherche.BorderColor = System.Drawing.Color.Silver
        Me.barreDeRecherche.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.barreDeRecherche.FocusedBaseColor = System.Drawing.Color.White
        Me.barreDeRecherche.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.barreDeRecherche.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.barreDeRecherche.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.barreDeRecherche.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.barreDeRecherche.Location = New System.Drawing.Point(-199, 197)
        Me.barreDeRecherche.Name = "barreDeRecherche"
        Me.barreDeRecherche.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.barreDeRecherche.Radius = 15
        Me.barreDeRecherche.Size = New System.Drawing.Size(427, 42)
        Me.barreDeRecherche.TabIndex = 152
        Me.barreDeRecherche.Text = "Rechercher"
        Me.barreDeRecherche.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.barreDeRecherche.Visible = False
        '
        'bouttonRecherche
        '
        Me.bouttonRecherche.AnimationHoverSpeed = 0.07!
        Me.bouttonRecherche.AnimationSpeed = 0.03!
        Me.bouttonRecherche.BackColor = System.Drawing.Color.Transparent
        Me.bouttonRecherche.BaseColor = System.Drawing.Color.Gainsboro
        Me.bouttonRecherche.BorderColor = System.Drawing.Color.Black
        Me.bouttonRecherche.DialogResult = System.Windows.Forms.DialogResult.None
        Me.bouttonRecherche.FocusedColor = System.Drawing.Color.Empty
        Me.bouttonRecherche.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.bouttonRecherche.ForeColor = System.Drawing.Color.White
        Me.bouttonRecherche.Image = Global.WindowsApplication1.My.Resources.Resources.search_32px
        Me.bouttonRecherche.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.bouttonRecherche.ImageOffsetX = 2
        Me.bouttonRecherche.ImageSize = New System.Drawing.Size(20, 20)
        Me.bouttonRecherche.Location = New System.Drawing.Point(170, 198)
        Me.bouttonRecherche.Name = "bouttonRecherche"
        Me.bouttonRecherche.OnHoverBaseColor = System.Drawing.Color.White
        Me.bouttonRecherche.OnHoverBorderColor = System.Drawing.Color.Black
        Me.bouttonRecherche.OnHoverForeColor = System.Drawing.Color.White
        Me.bouttonRecherche.OnHoverImage = Nothing
        Me.bouttonRecherche.OnPressedColor = System.Drawing.Color.Black
        Me.bouttonRecherche.Radius = 10
        Me.bouttonRecherche.Size = New System.Drawing.Size(40, 40)
        Me.bouttonRecherche.TabIndex = 155
        '
        'info1
        '
        Me.info1.AutoSize = True
        Me.info1.BackColor = System.Drawing.Color.DarkGray
        Me.info1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.info1.ForeColor = System.Drawing.Color.White
        Me.info1.Location = New System.Drawing.Point(720, 436)
        Me.info1.Name = "info1"
        Me.info1.Size = New System.Drawing.Size(143, 19)
        Me.info1.TabIndex = 156
        Me.info1.Text = "Ajouter des Elements."
        Me.info1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.info1.Visible = False
        '
        'info2
        '
        Me.info2.AutoSize = True
        Me.info2.BackColor = System.Drawing.Color.DarkGray
        Me.info2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.info2.ForeColor = System.Drawing.Color.White
        Me.info2.Location = New System.Drawing.Point(801, 472)
        Me.info2.Name = "info2"
        Me.info2.Size = New System.Drawing.Size(55, 19)
        Me.info2.TabIndex = 157
        Me.info2.Text = "Monter"
        Me.info2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.info2.Visible = False
        '
        'info3
        '
        Me.info3.AutoSize = True
        Me.info3.BackColor = System.Drawing.Color.DarkGray
        Me.info3.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.info3.ForeColor = System.Drawing.Color.White
        Me.info3.Location = New System.Drawing.Point(789, 521)
        Me.info3.Name = "info3"
        Me.info3.Size = New System.Drawing.Size(74, 19)
        Me.info3.TabIndex = 158
        Me.info3.Text = "Descendre"
        Me.info3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.info3.Visible = False
        '
        'afficherInfoBulle
        '
        Me.afficherInfoBulle.Interval = 1000
        '
        'Lbl_Aide
        '
        Me.Lbl_Aide.BackColor = System.Drawing.Color.DimGray
        Me.Lbl_Aide.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Lbl_Aide.ForeColor = System.Drawing.Color.White
        Me.Lbl_Aide.Location = New System.Drawing.Point(379, 26)
        Me.Lbl_Aide.Name = "Lbl_Aide"
        Me.Lbl_Aide.Size = New System.Drawing.Size(438, 406)
        Me.Lbl_Aide.TabIndex = 174
        Me.Lbl_Aide.Text = resources.GetString("Lbl_Aide.Text")
        Me.Lbl_Aide.Visible = False
        '
        'NumeroBouttonActif
        '
        Me.NumeroBouttonActif.AutoSize = True
        Me.NumeroBouttonActif.BackColor = System.Drawing.Color.DarkGray
        Me.NumeroBouttonActif.Font = New System.Drawing.Font("Segoe UI Semibold", 19.0!, System.Drawing.FontStyle.Bold)
        Me.NumeroBouttonActif.ForeColor = System.Drawing.Color.White
        Me.NumeroBouttonActif.Location = New System.Drawing.Point(866, 156)
        Me.NumeroBouttonActif.Name = "NumeroBouttonActif"
        Me.NumeroBouttonActif.Size = New System.Drawing.Size(29, 36)
        Me.NumeroBouttonActif.TabIndex = 175
        Me.NumeroBouttonActif.Text = "0"
        Me.NumeroBouttonActif.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.NumeroBouttonActif.Visible = False
        '
        'index_Resultat1
        '
        Me.index_Resultat1.AutoSize = True
        Me.index_Resultat1.BackColor = System.Drawing.Color.DarkGray
        Me.index_Resultat1.Font = New System.Drawing.Font("Segoe UI Semibold", 19.0!, System.Drawing.FontStyle.Bold)
        Me.index_Resultat1.ForeColor = System.Drawing.Color.White
        Me.index_Resultat1.Location = New System.Drawing.Point(221, 113)
        Me.index_Resultat1.Name = "index_Resultat1"
        Me.index_Resultat1.Size = New System.Drawing.Size(26, 36)
        Me.index_Resultat1.TabIndex = 176
        Me.index_Resultat1.Text = "*"
        Me.index_Resultat1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.index_Resultat1.Visible = False
        '
        'index_Resultat2
        '
        Me.index_Resultat2.AutoSize = True
        Me.index_Resultat2.BackColor = System.Drawing.Color.DarkGray
        Me.index_Resultat2.Font = New System.Drawing.Font("Segoe UI Semibold", 19.0!, System.Drawing.FontStyle.Bold)
        Me.index_Resultat2.ForeColor = System.Drawing.Color.White
        Me.index_Resultat2.Location = New System.Drawing.Point(221, 162)
        Me.index_Resultat2.Name = "index_Resultat2"
        Me.index_Resultat2.Size = New System.Drawing.Size(26, 36)
        Me.index_Resultat2.TabIndex = 177
        Me.index_Resultat2.Text = "*"
        Me.index_Resultat2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.index_Resultat2.Visible = False
        '
        'index_Resultat3
        '
        Me.index_Resultat3.AutoSize = True
        Me.index_Resultat3.BackColor = System.Drawing.Color.DarkGray
        Me.index_Resultat3.Font = New System.Drawing.Font("Segoe UI Semibold", 19.0!, System.Drawing.FontStyle.Bold)
        Me.index_Resultat3.ForeColor = System.Drawing.Color.White
        Me.index_Resultat3.Location = New System.Drawing.Point(221, 210)
        Me.index_Resultat3.Name = "index_Resultat3"
        Me.index_Resultat3.Size = New System.Drawing.Size(26, 36)
        Me.index_Resultat3.TabIndex = 178
        Me.index_Resultat3.Text = "*"
        Me.index_Resultat3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.index_Resultat3.Visible = False
        '
        'index_Resultat4
        '
        Me.index_Resultat4.AutoSize = True
        Me.index_Resultat4.BackColor = System.Drawing.Color.DarkGray
        Me.index_Resultat4.Font = New System.Drawing.Font("Segoe UI Semibold", 19.0!, System.Drawing.FontStyle.Bold)
        Me.index_Resultat4.ForeColor = System.Drawing.Color.White
        Me.index_Resultat4.Location = New System.Drawing.Point(221, 258)
        Me.index_Resultat4.Name = "index_Resultat4"
        Me.index_Resultat4.Size = New System.Drawing.Size(26, 36)
        Me.index_Resultat4.TabIndex = 179
        Me.index_Resultat4.Text = "*"
        Me.index_Resultat4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.index_Resultat4.Visible = False
        '
        'index_Resultat5
        '
        Me.index_Resultat5.AutoSize = True
        Me.index_Resultat5.BackColor = System.Drawing.Color.DarkGray
        Me.index_Resultat5.Font = New System.Drawing.Font("Segoe UI Semibold", 19.0!, System.Drawing.FontStyle.Bold)
        Me.index_Resultat5.ForeColor = System.Drawing.Color.White
        Me.index_Resultat5.Location = New System.Drawing.Point(221, 306)
        Me.index_Resultat5.Name = "index_Resultat5"
        Me.index_Resultat5.Size = New System.Drawing.Size(26, 36)
        Me.index_Resultat5.TabIndex = 180
        Me.index_Resultat5.Text = "*"
        Me.index_Resultat5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.index_Resultat5.Visible = False
        '
        'index_Resultat6
        '
        Me.index_Resultat6.AutoSize = True
        Me.index_Resultat6.BackColor = System.Drawing.Color.DarkGray
        Me.index_Resultat6.Font = New System.Drawing.Font("Segoe UI Semibold", 19.0!, System.Drawing.FontStyle.Bold)
        Me.index_Resultat6.ForeColor = System.Drawing.Color.White
        Me.index_Resultat6.Location = New System.Drawing.Point(221, 352)
        Me.index_Resultat6.Name = "index_Resultat6"
        Me.index_Resultat6.Size = New System.Drawing.Size(26, 36)
        Me.index_Resultat6.TabIndex = 181
        Me.index_Resultat6.Text = "*"
        Me.index_Resultat6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.index_Resultat6.Visible = False
        '
        'index_Resultat7
        '
        Me.index_Resultat7.AutoSize = True
        Me.index_Resultat7.BackColor = System.Drawing.Color.DarkGray
        Me.index_Resultat7.Font = New System.Drawing.Font("Segoe UI Semibold", 19.0!, System.Drawing.FontStyle.Bold)
        Me.index_Resultat7.ForeColor = System.Drawing.Color.White
        Me.index_Resultat7.Location = New System.Drawing.Point(221, 396)
        Me.index_Resultat7.Name = "index_Resultat7"
        Me.index_Resultat7.Size = New System.Drawing.Size(26, 36)
        Me.index_Resultat7.TabIndex = 182
        Me.index_Resultat7.Text = "*"
        Me.index_Resultat7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.index_Resultat7.Visible = False
        '
        'dernierResultat
        '
        Me.dernierResultat.AutoSize = True
        Me.dernierResultat.BackColor = System.Drawing.Color.DarkGray
        Me.dernierResultat.Font = New System.Drawing.Font("Segoe UI Semibold", 19.0!, System.Drawing.FontStyle.Bold)
        Me.dernierResultat.ForeColor = System.Drawing.Color.White
        Me.dernierResultat.Location = New System.Drawing.Point(865, 108)
        Me.dernierResultat.Name = "dernierResultat"
        Me.dernierResultat.Size = New System.Drawing.Size(29, 36)
        Me.dernierResultat.TabIndex = 183
        Me.dernierResultat.Text = "0"
        Me.dernierResultat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.dernierResultat.Visible = False
        '
        'FenetreTousLesElementsEtBarreDeRecherche
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(899, 554)
        Me.Controls.Add(Me.dernierResultat)
        Me.Controls.Add(Me.index_Resultat7)
        Me.Controls.Add(Me.index_Resultat6)
        Me.Controls.Add(Me.index_Resultat5)
        Me.Controls.Add(Me.index_Resultat4)
        Me.Controls.Add(Me.index_Resultat3)
        Me.Controls.Add(Me.index_Resultat2)
        Me.Controls.Add(Me.index_Resultat1)
        Me.Controls.Add(Me.NumeroBouttonActif)
        Me.Controls.Add(Me.Lbl_Aide)
        Me.Controls.Add(Me.info3)
        Me.Controls.Add(Me.info2)
        Me.Controls.Add(Me.info1)
        Me.Controls.Add(Me.bouttonRecherche)
        Me.Controls.Add(Me.barreDeRecherche)
        Me.Controls.Add(Me.motClerEtResultat)
        Me.Controls.Add(Me.nbrTotalDelements)
        Me.Controls.Add(Me.ajouterDesElements)
        Me.Controls.Add(Me.aideSupport)
        Me.Controls.Add(Me.cercleActif)
        Me.Controls.Add(Me.laDate)
        Me.Controls.Add(Me.bouttonDescendre)
        Me.Controls.Add(Me.bouttonMonter)
        Me.Controls.Add(Me.GunaImageButton22)
        Me.Controls.Add(Me.GunaImageButton21)
        Me.Controls.Add(Me.element_1)
        Me.Controls.Add(Me.element_2)
        Me.Controls.Add(Me.element_7)
        Me.Controls.Add(Me.element_6)
        Me.Controls.Add(Me.element_5)
        Me.Controls.Add(Me.element_4)
        Me.Controls.Add(Me.element_3)
        Me.Controls.Add(Me.GunaImageButton20)
        Me.Controls.Add(Me.GunaImageButton19)
        Me.Controls.Add(Me.GunaImageButton18)
        Me.Controls.Add(Me.GunaImageButton17)
        Me.Controls.Add(Me.GunaImageButton16)
        Me.Controls.Add(Me.GunaImageButton15)
        Me.Controls.Add(Me.GunaImageButton14)
        Me.Controls.Add(Me.GunaImageButton12)
        Me.Controls.Add(Me.GunaImageButton11)
        Me.Controls.Add(Me.GunaImageButton10)
        Me.Controls.Add(Me.GunaImageButton6)
        Me.Controls.Add(Me.GunaImageButton9)
        Me.Controls.Add(Me.GunaImageButton8)
        Me.Controls.Add(Me.GunaImageButton7)
        Me.Controls.Add(Me.GunaImageButton5)
        Me.Controls.Add(Me.GunaImageButton4)
        Me.Controls.Add(Me.GunaImageButton3)
        Me.Controls.Add(Me.GunaImageButton2)
        Me.Controls.Add(Me.GunaImageButton1)
        Me.Controls.Add(Me.GunaImageButton13)
        Me.Controls.Add(Me.Reduire)
        Me.Controls.Add(Me.Fermer)
        Me.Controls.Add(Me.elements)
        Me.Controls.Add(Me.TousLesElementsEtBarreDeRecherche)
        Me.Controls.Add(Me.curseur)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FenetreTousLesElementsEtBarreDeRecherche"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Assistant Personnel De Programmation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents curseur As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents TousLesElementsEtBarreDeRecherche As Guna.UI.WinForms.GunaLabel
    Friend WithEvents elements As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Fermer As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Reduire As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaImageButton13 As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents GunaImageButton1 As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents GunaImageButton2 As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents GunaImageButton3 As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents GunaImageButton4 As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents GunaImageButton5 As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents GunaImageButton7 As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents GunaImageButton8 As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents GunaImageButton9 As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents GunaImageButton6 As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents GunaImageButton10 As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents GunaImageButton11 As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents GunaImageButton12 As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents GunaImageButton14 As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents GunaImageButton15 As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents GunaImageButton16 As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents GunaImageButton17 As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents GunaImageButton18 As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents GunaImageButton19 As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents GunaImageButton20 As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents GunaImageButton21 As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents GunaImageButton22 As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents TimerChangerCouleur As Timer
    Friend WithEvents element_3 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents element_4 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents element_5 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents element_6 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents element_7 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents element_2 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents element_1 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents bouttonMonter As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents bouttonDescendre As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents laDate As Guna.UI.WinForms.GunaLabel
    Friend WithEvents cercleActif As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents rendreLaDateVisible As Timer
    Friend WithEvents aideSupport As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents ajouterDesElements As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents nbrTotalDelements As Guna.UI.WinForms.GunaLabel
    Friend WithEvents motClerEtResultat As Guna.UI.WinForms.GunaLabel
    Friend WithEvents barreDeRecherche As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents bouttonRecherche As Guna.UI.WinForms.GunaButton
    Friend WithEvents info1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents info2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents info3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents afficherInfoBulle As Timer
    Friend WithEvents Lbl_Aide As Guna.UI.WinForms.GunaLabel
    Friend WithEvents NumeroBouttonActif As Guna.UI.WinForms.GunaLabel
    Friend WithEvents index_Resultat1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents index_Resultat2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents index_Resultat3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents index_Resultat4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents index_Resultat5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents index_Resultat6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents index_Resultat7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents dernierResultat As Guna.UI.WinForms.GunaLabel
End Class
