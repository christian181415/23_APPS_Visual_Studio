<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.UI_GradientPanel1 = New UIDC.UI_GradientPanel()
        Me.ElContainer1 = New Klik.Windows.Forms.v1.EntryLib.ELContainer()
        Me.ElContainer2 = New Klik.Windows.Forms.v1.EntryLib.ELContainer()
        Me.ElCalculator1 = New Klik.Windows.Forms.v1.EntryLib.ELCalculator()
        Me.ElCalendar1 = New Klik.Windows.Forms.v1.EntryLib.ELCalendar()
        Me.UI_Card1 = New UIDC.UI_Card()
        CType(Me.ElContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ElContainer1.SuspendLayout()
        CType(Me.ElContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElCalculator1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElCalendar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UI_GradientPanel1
        '
        Me.UI_GradientPanel1.BackColor = System.Drawing.Color.White
        Me.UI_GradientPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.UI_GradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.UI_GradientPanel1.Name = "UI_GradientPanel1"
        Me.UI_GradientPanel1.Size = New System.Drawing.Size(200, 450)
        Me.UI_GradientPanel1.TabIndex = 0
        Me.UI_GradientPanel1.UIBackColor = System.Drawing.Color.Empty
        Me.UI_GradientPanel1.UIBottomLeft = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.UI_GradientPanel1.UIBottomRight = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.UI_GradientPanel1.UIForeColor = System.Drawing.Color.Empty
        Me.UI_GradientPanel1.UIPrimerColor = System.Drawing.Color.White
        Me.UI_GradientPanel1.UIStyle = UIDC.UI_GradientPanel.GradientStyle.Corners
        Me.UI_GradientPanel1.UITopLeft = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.UI_GradientPanel1.UITopRight = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        '
        'ElContainer1
        '
        Me.ElContainer1.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElContainer1.BackgroundStyle.SolidColor = System.Drawing.Color.White
        Me.ElContainer1.BorderStyle.SolidColor = System.Drawing.Color.White
        Me.ElContainer1.Controls.Add(Me.ElContainer2)
        Me.ElContainer1.Location = New System.Drawing.Point(206, 31)
        Me.ElContainer1.Name = "ElContainer1"
        Me.ElContainer1.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ElContainer1.Size = New System.Drawing.Size(170, 66)
        Me.ElContainer1.TabIndex = 1
        Me.ElContainer1.VisualStyle = Klik.Windows.Forms.v1.Common.ControlVisualStyles.Custom
        '
        'ElContainer2
        '
        Me.ElContainer2.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElContainer2.BackgroundStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ElContainer2.BorderStyle.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Rectangle
        Me.ElContainer2.BorderStyle.BorderShape.TopRight = Klik.Windows.Forms.v1.Common.BorderShapes.Rectangle
        Me.ElContainer2.BorderStyle.SolidColor = System.Drawing.Color.White
        Me.ElContainer2.Cursor = System.Windows.Forms.Cursors.Default
        Me.ElContainer2.Location = New System.Drawing.Point(-1, -1)
        Me.ElContainer2.Name = "ElContainer2"
        Me.ElContainer2.Padding = New System.Windows.Forms.Padding(3, 3, 4, 3)
        Me.ElContainer2.Size = New System.Drawing.Size(10, 68)
        Me.ElContainer2.TabIndex = 2
        Me.ElContainer2.VisualStyle = Klik.Windows.Forms.v1.Common.ControlVisualStyles.Custom
        '
        'ElCalculator1
        '
        Me.ElCalculator1.ButtonTexts = New String() {"Round", "Back", "CE", "C", "MC", "MR", "MS", "M+", "÷", "X", "-", "+", "%", "1/ x", "=", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "+/-", ".", "Ok", "Cancel"}
        Me.ElCalculator1.ContainerStyle.BackgroundStyle.GradientAngle = 45.0!
        Me.ElCalculator1.Dock = System.Windows.Forms.DockStyle.Right
        Me.ElCalculator1.Expanded = True
        Me.ElCalculator1.FooterStyle.BackgroundStyle.GradientAngle = 45.0!
        Me.ElCalculator1.FooterStyle.FlashStyle.GradientAngle = 0!
        Me.ElCalculator1.FooterStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElCalculator1.FooterStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.ElCalculator1.FooterStyle.TextStyle.Text = "Footer of ElCalculator1"
        Me.ElCalculator1.HeaderStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElCalculator1.HeaderStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.ElCalculator1.HeaderStyle.Height = 24
        Me.ElCalculator1.HeaderStyle.TextStyle.Text = "ElCalculator1"
        Me.ElCalculator1.Location = New System.Drawing.Point(619, 0)
        Me.ElCalculator1.Name = "ElCalculator1"
        Me.ElCalculator1.Size = New System.Drawing.Size(181, 450)
        Me.ElCalculator1.TabIndex = 2
        '
        'ElCalendar1
        '
        Me.ElCalendar1.ButtonVisualStyle = Klik.Windows.Forms.v1.EntryLib.CalendarButtonVisualStyles.System
        Me.ElCalendar1.CaptionBackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElCalendar1.CaptionBackgroundStyle.SolidColor = System.Drawing.Color.NavajoWhite
        Me.ElCalendar1.ContainerStyle.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElCalendar1.ContainerStyle.BackgroundStyle.SolidColor = System.Drawing.Color.White
        Me.ElCalendar1.ContainerStyle.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias
        Me.ElCalendar1.ContainerStyle.BorderStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ElCalendar1.ContainerStyle.VisualStyle = Klik.Windows.Forms.v1.Common.ControlVisualStyles.Custom
        Me.ElCalendar1.Expanded = True
        Me.ElCalendar1.FooterStyle.BackgroundStyle.GradientAngle = 0!
        Me.ElCalendar1.FooterStyle.BackgroundStyle.GradientEndColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ElCalendar1.FooterStyle.BackgroundStyle.GradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ElCalendar1.FooterStyle.FlashStyle.GradientAngle = 0!
        Me.ElCalendar1.FooterStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElCalendar1.FooterStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.ElCalendar1.FooterStyle.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ElCalendar1.FooterStyle.TextStyle.ForeColor = System.Drawing.Color.White
        Me.ElCalendar1.FooterStyle.TextStyle.Text = "Footer of ElCalendar1"
        Me.ElCalendar1.FooterStyle.VisualStyle = Klik.Windows.Forms.v1.Common.ControlVisualStyles.Custom
        Me.ElCalendar1.HeaderStyle.BackgroundStyle.GradientEndColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ElCalendar1.HeaderStyle.BackgroundStyle.GradientStartColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ElCalendar1.HeaderStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElCalendar1.HeaderStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.ElCalendar1.HeaderStyle.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ElCalendar1.HeaderStyle.Height = 24
        Me.ElCalendar1.HeaderStyle.TextStyle.BackColor = System.Drawing.Color.Black
        Me.ElCalendar1.HeaderStyle.TextStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ElCalendar1.HeaderStyle.TextStyle.ForeColor = System.Drawing.Color.White
        Me.ElCalendar1.HeaderStyle.TextStyle.Text = "ElCalendar1"
        Me.ElCalendar1.HeaderStyle.TextStyle.TextType = Klik.Windows.Forms.v1.Common.TextTypes.BlockShadow
        Me.ElCalendar1.HeaderStyle.VisualStyle = Klik.Windows.Forms.v1.Common.ControlVisualStyles.Custom
        Me.ElCalendar1.Location = New System.Drawing.Point(457, 0)
        Me.ElCalendar1.Name = "ElCalendar1"
        Me.ElCalendar1.SelectionBackColor = System.Drawing.Color.BurlyWood
        Me.ElCalendar1.Size = New System.Drawing.Size(156, 192)
        Me.ElCalendar1.TabIndex = 3
        Me.ElCalendar1.TodayDate = New Date(2023, 2, 6, 0, 0, 0, 0)
        Me.ElCalendar1.Value = New Date(2023, 2, 6, 0, 0, 0, 0)
        Me.ElCalendar1.Values = New Date() {New Date(2023, 2, 6, 0, 0, 0, 0)}
        Me.ElCalendar1.VisualStyle = Klik.Windows.Forms.v1.Common.ControlVisualStyles.Custom
        '
        'UI_Card1
        '
        Me.UI_Card1.ButtonColor = "#33b679"
        Me.UI_Card1.ContentColor = "#444444"
        Me.UI_Card1.ContentText = "Card Content is here"
        Me.UI_Card1.Location = New System.Drawing.Point(106, 103)
        Me.UI_Card1.Name = "UI_Card1"
        Me.UI_Card1.Size = New System.Drawing.Size(294, 299)
        Me.UI_Card1.TabIndex = 4
        Me.UI_Card1.Text = "UI_Card1"
        Me.UI_Card1.TitleColor = "#33b679"
        Me.UI_Card1.UIImage = Nothing
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.UI_Card1)
        Me.Controls.Add(Me.ElCalendar1)
        Me.Controls.Add(Me.ElCalculator1)
        Me.Controls.Add(Me.ElContainer1)
        Me.Controls.Add(Me.UI_GradientPanel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.ElContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ElContainer1.ResumeLayout(False)
        CType(Me.ElContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElCalculator1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElCalendar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UI_GradientPanel1 As UIDC.UI_GradientPanel
    Friend WithEvents ElContainer1 As Klik.Windows.Forms.v1.EntryLib.ELContainer
    Friend WithEvents ElContainer2 As Klik.Windows.Forms.v1.EntryLib.ELContainer
    Friend WithEvents ElCalculator1 As Klik.Windows.Forms.v1.EntryLib.ELCalculator
    Friend WithEvents ElCalendar1 As Klik.Windows.Forms.v1.EntryLib.ELCalendar
    Friend WithEvents UI_Card1 As UIDC.UI_Card
End Class
