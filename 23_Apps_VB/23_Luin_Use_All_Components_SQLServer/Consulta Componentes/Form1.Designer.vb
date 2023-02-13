<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits MaterialSkin.Controls.MaterialForm

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MaterialTabControl1 = New MaterialSkin.Controls.MaterialTabControl()
        Me.TP_Registrar = New System.Windows.Forms.TabPage()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.TP_Actualizar = New System.Windows.Forms.TabPage()
        Me.TP_Eliminar = New System.Windows.Forms.TabPage()
        Me.IconsNavbar = New System.Windows.Forms.ImageList(Me.components)
        Me.UI_TextBox1 = New UIDC.UI_TextBox()
        Me.UI_CustomDateTimePicker1 = New UIDC.UI_CustomDateTimePicker()
        Me.UI_ComboBox1 = New UIDC.UI_ComboBox()
        Me.MaterialTabControl1.SuspendLayout()
        Me.TP_Registrar.SuspendLayout()
        Me.SuspendLayout()
        '
        'MaterialTabControl1
        '
        Me.MaterialTabControl1.Controls.Add(Me.TP_Registrar)
        Me.MaterialTabControl1.Controls.Add(Me.TP_Actualizar)
        Me.MaterialTabControl1.Controls.Add(Me.TP_Eliminar)
        Me.MaterialTabControl1.Depth = 0
        Me.MaterialTabControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MaterialTabControl1.ImageList = Me.IconsNavbar
        Me.MaterialTabControl1.Location = New System.Drawing.Point(3, 64)
        Me.MaterialTabControl1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabControl1.Multiline = True
        Me.MaterialTabControl1.Name = "MaterialTabControl1"
        Me.MaterialTabControl1.SelectedIndex = 0
        Me.MaterialTabControl1.Size = New System.Drawing.Size(794, 383)
        Me.MaterialTabControl1.TabIndex = 0
        '
        'TP_Registrar
        '
        Me.TP_Registrar.BackColor = System.Drawing.SystemColors.Control
        Me.TP_Registrar.Controls.Add(Me.UI_ComboBox1)
        Me.TP_Registrar.Controls.Add(Me.UI_CustomDateTimePicker1)
        Me.TP_Registrar.Controls.Add(Me.UI_TextBox1)
        Me.TP_Registrar.Controls.Add(Me.MaterialLabel1)
        Me.TP_Registrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TP_Registrar.ForeColor = System.Drawing.Color.Black
        Me.TP_Registrar.ImageKey = "icons8_Check_Circle_24px_2.png"
        Me.TP_Registrar.Location = New System.Drawing.Point(4, 31)
        Me.TP_Registrar.Name = "TP_Registrar"
        Me.TP_Registrar.Padding = New System.Windows.Forms.Padding(3)
        Me.TP_Registrar.Size = New System.Drawing.Size(786, 348)
        Me.TP_Registrar.TabIndex = 0
        Me.TP_Registrar.Text = "Registrar"
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto Medium", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2
        Me.MaterialLabel1.Location = New System.Drawing.Point(15, 12)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(157, 17)
        Me.MaterialLabel1.TabIndex = 0
        Me.MaterialLabel1.Text = "REGISTRO DE USUARIOS"
        '
        'TP_Actualizar
        '
        Me.TP_Actualizar.ImageKey = "icons8_Restart_24px.png"
        Me.TP_Actualizar.Location = New System.Drawing.Point(4, 31)
        Me.TP_Actualizar.Name = "TP_Actualizar"
        Me.TP_Actualizar.Padding = New System.Windows.Forms.Padding(3)
        Me.TP_Actualizar.Size = New System.Drawing.Size(786, 348)
        Me.TP_Actualizar.TabIndex = 1
        Me.TP_Actualizar.Text = "Actualizar"
        Me.TP_Actualizar.UseVisualStyleBackColor = True
        '
        'TP_Eliminar
        '
        Me.TP_Eliminar.ImageKey = "icons8_cancel_24px_3.png"
        Me.TP_Eliminar.Location = New System.Drawing.Point(4, 31)
        Me.TP_Eliminar.Name = "TP_Eliminar"
        Me.TP_Eliminar.Padding = New System.Windows.Forms.Padding(3)
        Me.TP_Eliminar.Size = New System.Drawing.Size(786, 348)
        Me.TP_Eliminar.TabIndex = 2
        Me.TP_Eliminar.Text = "Eliminar"
        Me.TP_Eliminar.UseVisualStyleBackColor = True
        '
        'IconsNavbar
        '
        Me.IconsNavbar.ImageStream = CType(resources.GetObject("IconsNavbar.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.IconsNavbar.TransparentColor = System.Drawing.Color.Transparent
        Me.IconsNavbar.Images.SetKeyName(0, "icons8_Restart_24px.png")
        Me.IconsNavbar.Images.SetKeyName(1, "icons8_cancel_24px_3.png")
        Me.IconsNavbar.Images.SetKeyName(2, "icons8_Check_Circle_24px_2.png")
        '
        'UI_TextBox1
        '
        Me.UI_TextBox1.BackColor = System.Drawing.Color.Transparent
        Me.UI_TextBox1.BackgroundColour = System.Drawing.Color.White
        Me.UI_TextBox1.BorderColour = System.Drawing.Color.Empty
        Me.UI_TextBox1.BorderSize = 3
        Me.UI_TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.UI_TextBox1.Location = New System.Drawing.Point(18, 70)
        Me.UI_TextBox1.MaximumSize = New System.Drawing.Size(577, 20)
        Me.UI_TextBox1.MaxLength = 32767
        Me.UI_TextBox1.Multiline = False
        Me.UI_TextBox1.Name = "UI_TextBox1"
        Me.UI_TextBox1.ReadOnly = False
        Me.UI_TextBox1.Size = New System.Drawing.Size(226, 20)
        Me.UI_TextBox1.StyleBorder = UIDC.UI_TextBox.Styles.BorderRounded
        Me.UI_TextBox1.TabIndex = 8
        Me.UI_TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.UI_TextBox1.TextColour = System.Drawing.Color.Black
        Me.UI_TextBox1.UseSystemPasswordChar = False
        '
        'UI_CustomDateTimePicker1
        '
        Me.UI_CustomDateTimePicker1.BackColor = System.Drawing.Color.Transparent
        Me.UI_CustomDateTimePicker1.CollapseColor = System.Drawing.Color.Black
        Me.UI_CustomDateTimePicker1.CustomFormat = Nothing
        Me.UI_CustomDateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.UI_CustomDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.UI_CustomDateTimePicker1.HeightBase = 30
        Me.UI_CustomDateTimePicker1.LineColor = System.Drawing.Color.Empty
        Me.UI_CustomDateTimePicker1.LineSize = 3
        Me.UI_CustomDateTimePicker1.Location = New System.Drawing.Point(18, 129)
        Me.UI_CustomDateTimePicker1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.UI_CustomDateTimePicker1.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.UI_CustomDateTimePicker1.Name = "UI_CustomDateTimePicker1"
        Me.UI_CustomDateTimePicker1.Radius = True
        Me.UI_CustomDateTimePicker1.Size = New System.Drawing.Size(226, 24)
        Me.UI_CustomDateTimePicker1.SolidColor = System.Drawing.Color.White
        Me.UI_CustomDateTimePicker1.TabIndex = 9
        Me.UI_CustomDateTimePicker1.Text = "domingo, 12 de febrero de 2023"
        Me.UI_CustomDateTimePicker1.TextColor = System.Drawing.Color.Black
        Me.UI_CustomDateTimePicker1.Value = New Date(2023, 2, 12, 20, 17, 19, 54)
        '
        'UI_ComboBox1
        '
        Me.UI_ComboBox1.ArrowColour = System.Drawing.Color.Black
        Me.UI_ComboBox1.BackColor = System.Drawing.Color.Transparent
        Me.UI_ComboBox1.BaseColour = System.Drawing.Color.White
        Me.UI_ComboBox1.BorderColour = System.Drawing.Color.Empty
        Me.UI_ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.UI_ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.UI_ComboBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.UI_ComboBox1.FontColour = System.Drawing.Color.Black
        Me.UI_ComboBox1.FormattingEnabled = True
        Me.UI_ComboBox1.LineColour = System.Drawing.Color.Black
        Me.UI_ComboBox1.Location = New System.Drawing.Point(18, 97)
        Me.UI_ComboBox1.Name = "UI_ComboBox1"
        Me.UI_ComboBox1.Size = New System.Drawing.Size(226, 26)
        Me.UI_ComboBox1.SqaureColour = System.Drawing.Color.Gainsboro
        Me.UI_ComboBox1.SqaureHoverColour = System.Drawing.Color.Gray
        Me.UI_ComboBox1.StartIndex = 0
        Me.UI_ComboBox1.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MaterialTabControl1)
        Me.DrawerShowIconsWhenHidden = True
        Me.DrawerTabControl = Me.MaterialTabControl1
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Componentes"
        Me.MaterialTabControl1.ResumeLayout(False)
        Me.TP_Registrar.ResumeLayout(False)
        Me.TP_Registrar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MaterialTabControl1 As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents TP_Registrar As TabPage
    Friend WithEvents TP_Actualizar As TabPage
    Friend WithEvents TP_Eliminar As TabPage
    Private WithEvents IconsNavbar As ImageList
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents UI_TextBox1 As UIDC.UI_TextBox
    Friend WithEvents UI_CustomDateTimePicker1 As UIDC.UI_CustomDateTimePicker
    Friend WithEvents UI_ComboBox1 As UIDC.UI_ComboBox
End Class
