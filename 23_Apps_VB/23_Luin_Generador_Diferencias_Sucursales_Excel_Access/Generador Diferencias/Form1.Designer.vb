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
        Dim ListViewItem41 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("0")
        Dim ListViewItem42 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("0")
        Dim ListViewItem43 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("0")
        Dim ListViewItem44 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("0")
        Dim ListViewItem45 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("0")
        Dim ListViewItem46 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("0")
        Dim ListViewItem47 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("0")
        Dim ListViewItem48 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("0")
        Dim ListViewItem49 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("0")
        Dim ListViewItem50 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("0")
        Me.MaterialTabControl1 = New MaterialSkin.Controls.MaterialTabControl()
        Me.TP_Diferencias = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LInventario = New MaterialSkin.Controls.MaterialLabel()
        Me.PBarInventario = New MaterialSkin.Controls.MaterialProgressBar()
        Me.LLotes = New MaterialSkin.Controls.MaterialLabel()
        Me.PBarLotes = New MaterialSkin.Controls.MaterialProgressBar()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LArchivo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnArchivo = New MaterialSkin.Controls.MaterialButton()
        Me.TP_Historial = New System.Windows.Forms.TabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MaterialButton2 = New MaterialSkin.Controls.MaterialButton()
        Me.BWLotes = New System.ComponentModel.BackgroundWorker()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.BWInventarios = New System.ComponentModel.BackgroundWorker()
        Me.MaterialListView1 = New MaterialSkin.Controls.MaterialListView()
        Me.ColumnCodigo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnProducto = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnInventario = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnLotes = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.UI_CustomDateTimePicker1 = New UIDC.UI_CustomDateTimePicker()
        Me.UI_ComboBox1 = New UIDC.UI_ComboBox()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialTabControl1.SuspendLayout()
        Me.TP_Diferencias.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TP_Historial.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'MaterialTabControl1
        '
        Me.MaterialTabControl1.Controls.Add(Me.TP_Diferencias)
        Me.MaterialTabControl1.Controls.Add(Me.TP_Historial)
        Me.MaterialTabControl1.Depth = 0
        Me.MaterialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MaterialTabControl1.Location = New System.Drawing.Point(3, 64)
        Me.MaterialTabControl1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabControl1.Multiline = True
        Me.MaterialTabControl1.Name = "MaterialTabControl1"
        Me.MaterialTabControl1.SelectedIndex = 0
        Me.MaterialTabControl1.Size = New System.Drawing.Size(794, 383)
        Me.MaterialTabControl1.TabIndex = 0
        '
        'TP_Diferencias
        '
        Me.TP_Diferencias.BackColor = System.Drawing.Color.Transparent
        Me.TP_Diferencias.Controls.Add(Me.Panel2)
        Me.TP_Diferencias.Controls.Add(Me.Panel1)
        Me.TP_Diferencias.Location = New System.Drawing.Point(4, 22)
        Me.TP_Diferencias.Name = "TP_Diferencias"
        Me.TP_Diferencias.Padding = New System.Windows.Forms.Padding(3)
        Me.TP_Diferencias.Size = New System.Drawing.Size(786, 357)
        Me.TP_Diferencias.TabIndex = 0
        Me.TP_Diferencias.Text = "Diferencias"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(168, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(615, 351)
        Me.Panel2.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Panel1.Controls.Add(Me.LInventario)
        Me.Panel1.Controls.Add(Me.PBarInventario)
        Me.Panel1.Controls.Add(Me.LLotes)
        Me.Panel1.Controls.Add(Me.PBarLotes)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.LArchivo)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.BtnArchivo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(165, 351)
        Me.Panel1.TabIndex = 5
        '
        'LInventario
        '
        Me.LInventario.Depth = 0
        Me.LInventario.Font = New System.Drawing.Font("Roboto", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.LInventario.FontType = MaterialSkin.MaterialSkinManager.fontType.Overline
        Me.LInventario.ForeColor = System.Drawing.Color.White
        Me.LInventario.Location = New System.Drawing.Point(10, 250)
        Me.LInventario.MouseState = MaterialSkin.MouseState.HOVER
        Me.LInventario.Name = "LInventario"
        Me.LInventario.Size = New System.Drawing.Size(144, 13)
        Me.LInventario.TabIndex = 12
        Me.LInventario.Text = "Inventario:"
        Me.LInventario.Visible = False
        '
        'PBarInventario
        '
        Me.PBarInventario.BackColor = System.Drawing.Color.White
        Me.PBarInventario.Depth = 0
        Me.PBarInventario.ForeColor = System.Drawing.Color.White
        Me.PBarInventario.Location = New System.Drawing.Point(10, 266)
        Me.PBarInventario.MouseState = MaterialSkin.MouseState.HOVER
        Me.PBarInventario.Name = "PBarInventario"
        Me.PBarInventario.Size = New System.Drawing.Size(145, 5)
        Me.PBarInventario.TabIndex = 11
        Me.PBarInventario.Visible = False
        '
        'LLotes
        '
        Me.LLotes.Depth = 0
        Me.LLotes.Font = New System.Drawing.Font("Roboto", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.LLotes.FontType = MaterialSkin.MaterialSkinManager.fontType.Overline
        Me.LLotes.ForeColor = System.Drawing.Color.White
        Me.LLotes.Location = New System.Drawing.Point(10, 225)
        Me.LLotes.MouseState = MaterialSkin.MouseState.HOVER
        Me.LLotes.Name = "LLotes"
        Me.LLotes.Size = New System.Drawing.Size(144, 13)
        Me.LLotes.TabIndex = 10
        Me.LLotes.Text = "Lotes:"
        Me.LLotes.Visible = False
        '
        'PBarLotes
        '
        Me.PBarLotes.BackColor = System.Drawing.Color.White
        Me.PBarLotes.Depth = 0
        Me.PBarLotes.ForeColor = System.Drawing.Color.White
        Me.PBarLotes.Location = New System.Drawing.Point(10, 241)
        Me.PBarLotes.MouseState = MaterialSkin.MouseState.HOVER
        Me.PBarLotes.Name = "PBarLotes"
        Me.PBarLotes.Size = New System.Drawing.Size(145, 5)
        Me.PBarLotes.TabIndex = 9
        Me.PBarLotes.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(25, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "DEFERENCIAS"
        '
        'LArchivo
        '
        Me.LArchivo.AutoSize = True
        Me.LArchivo.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.LArchivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LArchivo.ForeColor = System.Drawing.Color.White
        Me.LArchivo.Location = New System.Drawing.Point(30, 197)
        Me.LArchivo.Name = "LArchivo"
        Me.LArchivo.Size = New System.Drawing.Size(98, 13)
        Me.LArchivo.TabIndex = 7
        Me.LArchivo.Text = "C:/Sys_Diferencias"
        Me.LArchivo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LArchivo.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(43, 133)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "ARCHIVO"
        '
        'BtnArchivo
        '
        Me.BtnArchivo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnArchivo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.BtnArchivo.Depth = 0
        Me.BtnArchivo.HighEmphasis = True
        Me.BtnArchivo.Icon = Nothing
        Me.BtnArchivo.Location = New System.Drawing.Point(9, 155)
        Me.BtnArchivo.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BtnArchivo.MouseState = MaterialSkin.MouseState.HOVER
        Me.BtnArchivo.Name = "BtnArchivo"
        Me.BtnArchivo.NoAccentTextColor = System.Drawing.Color.Empty
        Me.BtnArchivo.Size = New System.Drawing.Size(145, 36)
        Me.BtnArchivo.TabIndex = 5
        Me.BtnArchivo.Text = "CARGAR ARCHIVO"
        Me.BtnArchivo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.BtnArchivo.UseAccentColor = False
        Me.BtnArchivo.UseVisualStyleBackColor = True
        '
        'TP_Historial
        '
        Me.TP_Historial.Controls.Add(Me.Panel3)
        Me.TP_Historial.Controls.Add(Me.Panel4)
        Me.TP_Historial.Location = New System.Drawing.Point(4, 22)
        Me.TP_Historial.Name = "TP_Historial"
        Me.TP_Historial.Padding = New System.Windows.Forms.Padding(3)
        Me.TP_Historial.Size = New System.Drawing.Size(786, 357)
        Me.TP_Historial.TabIndex = 1
        Me.TP_Historial.Text = "Historial"
        Me.TP_Historial.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Panel3.Controls.Add(Me.MaterialListView1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(168, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(615, 351)
        Me.Panel3.TabIndex = 8
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Panel4.Controls.Add(Me.MaterialLabel2)
        Me.Panel4.Controls.Add(Me.MaterialLabel1)
        Me.Panel4.Controls.Add(Me.UI_ComboBox1)
        Me.Panel4.Controls.Add(Me.UI_CustomDateTimePicker1)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.MaterialButton2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(3, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(165, 351)
        Me.Panel4.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(38, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "HISTORIAL"
        '
        'MaterialButton2
        '
        Me.MaterialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MaterialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.MaterialButton2.Depth = 0
        Me.MaterialButton2.HighEmphasis = True
        Me.MaterialButton2.Icon = Nothing
        Me.MaterialButton2.Location = New System.Drawing.Point(41, 220)
        Me.MaterialButton2.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialButton2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialButton2.Name = "MaterialButton2"
        Me.MaterialButton2.NoAccentTextColor = System.Drawing.Color.Empty
        Me.MaterialButton2.Size = New System.Drawing.Size(79, 36)
        Me.MaterialButton2.TabIndex = 5
        Me.MaterialButton2.Text = "CARGAR"
        Me.MaterialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.MaterialButton2.UseAccentColor = False
        Me.MaterialButton2.UseVisualStyleBackColor = True
        '
        'BWLotes
        '
        Me.BWLotes.WorkerReportsProgress = True
        Me.BWLotes.WorkerSupportsCancellation = True
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog"
        '
        'BWInventarios
        '
        Me.BWInventarios.WorkerReportsProgress = True
        Me.BWInventarios.WorkerSupportsCancellation = True
        '
        'MaterialListView1
        '
        Me.MaterialListView1.AutoSizeTable = False
        Me.MaterialListView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MaterialListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnCodigo, Me.ColumnProducto, Me.ColumnInventario, Me.ColumnLotes})
        Me.MaterialListView1.Depth = 0
        Me.MaterialListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MaterialListView1.FullRowSelect = True
        Me.MaterialListView1.GridLines = True
        Me.MaterialListView1.HideSelection = False
        Me.MaterialListView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem41, ListViewItem42, ListViewItem43, ListViewItem44, ListViewItem45, ListViewItem46, ListViewItem47, ListViewItem48, ListViewItem49, ListViewItem50})
        Me.MaterialListView1.Location = New System.Drawing.Point(0, 0)
        Me.MaterialListView1.MinimumSize = New System.Drawing.Size(200, 100)
        Me.MaterialListView1.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialListView1.MouseState = MaterialSkin.MouseState.OUT
        Me.MaterialListView1.Name = "MaterialListView1"
        Me.MaterialListView1.OwnerDraw = True
        Me.MaterialListView1.Size = New System.Drawing.Size(615, 351)
        Me.MaterialListView1.TabIndex = 0
        Me.MaterialListView1.UseCompatibleStateImageBehavior = False
        Me.MaterialListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnCodigo
        '
        Me.ColumnCodigo.Text = "Codigo"
        Me.ColumnCodigo.Width = 84
        '
        'ColumnProducto
        '
        Me.ColumnProducto.Text = "Producto"
        Me.ColumnProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnProducto.Width = 318
        '
        'ColumnInventario
        '
        Me.ColumnInventario.Text = "Inventario"
        Me.ColumnInventario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnInventario.Width = 104
        '
        'ColumnLotes
        '
        Me.ColumnLotes.Text = "Existencias"
        Me.ColumnLotes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnLotes.Width = 109
        '
        'UI_CustomDateTimePicker1
        '
        Me.UI_CustomDateTimePicker1.BackColor = System.Drawing.Color.Transparent
        Me.UI_CustomDateTimePicker1.CollapseColor = System.Drawing.Color.White
        Me.UI_CustomDateTimePicker1.CustomFormat = Nothing
        Me.UI_CustomDateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.UI_CustomDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.UI_CustomDateTimePicker1.HeightBase = 30
        Me.UI_CustomDateTimePicker1.LineColor = System.Drawing.Color.White
        Me.UI_CustomDateTimePicker1.LineSize = 0
        Me.UI_CustomDateTimePicker1.Location = New System.Drawing.Point(16, 179)
        Me.UI_CustomDateTimePicker1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.UI_CustomDateTimePicker1.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.UI_CustomDateTimePicker1.Name = "UI_CustomDateTimePicker1"
        Me.UI_CustomDateTimePicker1.Radius = True
        Me.UI_CustomDateTimePicker1.Size = New System.Drawing.Size(133, 22)
        Me.UI_CustomDateTimePicker1.SolidColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.UI_CustomDateTimePicker1.TabIndex = 9
        Me.UI_CustomDateTimePicker1.Text = "26/02/2023"
        Me.UI_CustomDateTimePicker1.TextColor = System.Drawing.Color.White
        Me.UI_CustomDateTimePicker1.Value = New Date(2023, 2, 26, 23, 42, 24, 11)
        '
        'UI_ComboBox1
        '
        Me.UI_ComboBox1.ArrowColour = System.Drawing.Color.White
        Me.UI_ComboBox1.BackColor = System.Drawing.Color.Transparent
        Me.UI_ComboBox1.BaseColour = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.UI_ComboBox1.BorderColour = System.Drawing.Color.White
        Me.UI_ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.UI_ComboBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.UI_ComboBox1.FontColour = System.Drawing.Color.White
        Me.UI_ComboBox1.ForeColor = System.Drawing.Color.White
        Me.UI_ComboBox1.FormattingEnabled = True
        Me.UI_ComboBox1.Items.AddRange(New Object() {"CEDIS Farma", "PTRME", "APZCE", "OAXCE", "VRCZE"})
        Me.UI_ComboBox1.LineColour = System.Drawing.Color.White
        Me.UI_ComboBox1.Location = New System.Drawing.Point(16, 123)
        Me.UI_ComboBox1.Name = "UI_ComboBox1"
        Me.UI_ComboBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.UI_ComboBox1.Size = New System.Drawing.Size(133, 26)
        Me.UI_ComboBox1.SqaureColour = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.UI_ComboBox1.SqaureHoverColour = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.UI_ComboBox1.StartIndex = 0
        Me.UI_ComboBox1.TabIndex = 10
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.White
        Me.MaterialLabel1.Location = New System.Drawing.Point(13, 162)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(118, 14)
        Me.MaterialLabel1.TabIndex = 11
        Me.MaterialLabel1.Text = "Seleccione una fecha:"
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.White
        Me.MaterialLabel2.Location = New System.Drawing.Point(13, 106)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(128, 14)
        Me.MaterialLabel2.TabIndex = 12
        Me.MaterialLabel2.Text = "Seleccione un almacen:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MaterialTabControl1)
        Me.DrawerTabControl = Me.MaterialTabControl1
        Me.Name = "Form1"
        Me.Text = "Sistema de diferencias"
        Me.MaterialTabControl1.ResumeLayout(False)
        Me.TP_Diferencias.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TP_Historial.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MaterialTabControl1 As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents TP_Diferencias As TabPage
    Friend WithEvents TP_Historial As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnArchivo As MaterialSkin.Controls.MaterialButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents MaterialButton2 As MaterialSkin.Controls.MaterialButton
    Friend WithEvents LInventario As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents PBarInventario As MaterialSkin.Controls.MaterialProgressBar
    Friend WithEvents LLotes As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents PBarLotes As MaterialSkin.Controls.MaterialProgressBar
    Friend WithEvents Label4 As Label
    Friend WithEvents LArchivo As Label
    Friend WithEvents BWLotes As System.ComponentModel.BackgroundWorker
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents BWInventarios As System.ComponentModel.BackgroundWorker
    Friend WithEvents MaterialListView1 As MaterialSkin.Controls.MaterialListView
    Friend WithEvents ColumnCodigo As ColumnHeader
    Friend WithEvents ColumnProducto As ColumnHeader
    Friend WithEvents ColumnInventario As ColumnHeader
    Friend WithEvents ColumnLotes As ColumnHeader
    Friend WithEvents UI_ComboBox1 As UIDC.UI_ComboBox
    Friend WithEvents UI_CustomDateTimePicker1 As UIDC.UI_CustomDateTimePicker
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
End Class
