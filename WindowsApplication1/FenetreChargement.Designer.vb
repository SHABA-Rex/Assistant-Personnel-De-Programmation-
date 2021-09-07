<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FenetreChargement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FenetreChargement))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GunaWinCircleProgressIndicator1 = New Guna.UI.WinForms.GunaWinCircleProgressIndicator()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pgBar = New Guna.UI.WinForms.GunaProgressBar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GunaImageButton1 = New Guna.UI.WinForms.GunaImageButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label1.Font = New System.Drawing.Font("Open Sans Light", 100.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(36, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(313, 182)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "APP"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GunaWinCircleProgressIndicator1
        '
        Me.GunaWinCircleProgressIndicator1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.GunaWinCircleProgressIndicator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GunaWinCircleProgressIndicator1.Location = New System.Drawing.Point(665, 226)
        Me.GunaWinCircleProgressIndicator1.Name = "GunaWinCircleProgressIndicator1"
        Me.GunaWinCircleProgressIndicator1.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaWinCircleProgressIndicator1.Size = New System.Drawing.Size(64, 64)
        Me.GunaWinCircleProgressIndicator1.TabIndex = 4
        Me.GunaWinCircleProgressIndicator1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label2.Font = New System.Drawing.Font("Open Sans Light", 16.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(88, 260)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(178, 30)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Mieux expliquer " & Global.Microsoft.VisualBasic.ChrW(13)
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'timer1
        '
        '
        'pgBar
        '
        Me.pgBar.BackColor = System.Drawing.Color.Transparent
        Me.pgBar.BorderColor = System.Drawing.Color.Black
        Me.pgBar.ColorStyle = Guna.UI.WinForms.ColorStyle.[Default]
        Me.pgBar.IdleColor = System.Drawing.Color.Gainsboro
        Me.pgBar.Location = New System.Drawing.Point(-1, 415)
        Me.pgBar.Name = "pgBar"
        Me.pgBar.ProgressMaxColor = System.Drawing.Color.Aqua
        Me.pgBar.ProgressMinColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.pgBar.Radius = 10
        Me.pgBar.Size = New System.Drawing.Size(744, 23)
        Me.pgBar.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label3.Font = New System.Drawing.Font("Open Sans Light", 16.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(51, 290)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(256, 30)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "pour mieux comprendre"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GunaImageButton1
        '
        Me.GunaImageButton1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.search_350px
        Me.GunaImageButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaImageButton1.Image = Nothing
        Me.GunaImageButton1.ImageSize = New System.Drawing.Size(64, 64)
        Me.GunaImageButton1.Location = New System.Drawing.Point(313, 25)
        Me.GunaImageButton1.Name = "GunaImageButton1"
        Me.GunaImageButton1.OnHoverImage = Nothing
        Me.GunaImageButton1.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.GunaImageButton1.Size = New System.Drawing.Size(346, 335)
        Me.GunaImageButton1.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(331, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Label4"
        Me.Label4.Visible = False
        '
        'FenetreChargement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(742, 433)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.pgBar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GunaImageButton1)
        Me.Controls.Add(Me.GunaWinCircleProgressIndicator1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FenetreChargement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Assistant Personnel De Programmation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents GunaWinCircleProgressIndicator1 As Guna.UI.WinForms.GunaWinCircleProgressIndicator
    Friend WithEvents GunaImageButton1 As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents Label2 As Label
    Friend WithEvents timer1 As Timer
    Friend WithEvents pgBar As Guna.UI.WinForms.GunaProgressBar
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
