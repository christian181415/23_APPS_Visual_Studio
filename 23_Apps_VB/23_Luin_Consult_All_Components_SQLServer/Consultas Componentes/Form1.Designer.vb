<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.T_Sidebar = New System.Windows.Forms.Timer(Me.components)
        Me.UI_Notification1 = New UIDC.UI_Notification()
        Me.P_Padre = New System.Windows.Forms.Panel()
        Me.P_Sidebar = New System.Windows.Forms.Panel()
        Me.BtnRegistrar = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.PictureBox()
        Me.BtnTablas = New System.Windows.Forms.Button()
        Me.BtnListas = New System.Windows.Forms.Button()
        Me.BtnTextBox = New System.Windows.Forms.Button()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.Panel18 = New System.Windows.Forms.Panel()
        Me.LComponentes = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.LAcciones = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.UI_BtnMinimize = New UIDC.UI_ButtonImage()
        Me.UI_BtnExit = New UIDC.UI_ButtonImage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BtnNavbar = New System.Windows.Forms.PictureBox()
        Me.TSCContenedor = New System.Windows.Forms.ToolStripContainer()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.P_Padre.SuspendLayout()
        Me.P_Sidebar.SuspendLayout()
        CType(Me.BtnExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel17.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.UI_BtnMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UI_BtnExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnNavbar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TSCContenedor.ContentPanel.SuspendLayout()
        Me.TSCContenedor.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'T_Sidebar
        '
        Me.T_Sidebar.Interval = 10
        '
        'UI_Notification1
        '
        Me.UI_Notification1.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.UI_Notification1.CloseInterval = 5
        Me.UI_Notification1.EnabledNoti = False
        Me.UI_Notification1.Image = CType(resources.GetObject("UI_Notification1.Image"), System.Drawing.Image)
        Me.UI_Notification1.ImageBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.UI_Notification1.ImageElipse = True
        Me.UI_Notification1.ImageVisible = True
        Me.UI_Notification1.SoundEnabled = True
        Me.UI_Notification1.Text = "Notification text (Place text)"
        Me.UI_Notification1.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.UI_Notification1.TextForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.UI_Notification1.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.UI_Notification1.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.UI_Notification1.TitleText = "Notification title"
        Me.UI_Notification1.TypeSound = UIDC.UI_Notification.sun.Asterisk
        '
        'P_Padre
        '
        Me.P_Padre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.P_Padre.Controls.Add(Me.P_Sidebar)
        Me.P_Padre.Controls.Add(Me.TSCContenedor)
        Me.P_Padre.Controls.Add(Me.Panel3)
        Me.P_Padre.Location = New System.Drawing.Point(0, 0)
        Me.P_Padre.Name = "P_Padre"
        Me.P_Padre.Size = New System.Drawing.Size(588, 392)
        Me.P_Padre.TabIndex = 4
        '
        'P_Sidebar
        '
        Me.P_Sidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.P_Sidebar.Controls.Add(Me.BtnRegistrar)
        Me.P_Sidebar.Controls.Add(Me.BtnActualizar)
        Me.P_Sidebar.Controls.Add(Me.BtnEliminar)
        Me.P_Sidebar.Controls.Add(Me.BtnExit)
        Me.P_Sidebar.Controls.Add(Me.BtnTablas)
        Me.P_Sidebar.Controls.Add(Me.BtnListas)
        Me.P_Sidebar.Controls.Add(Me.BtnTextBox)
        Me.P_Sidebar.Controls.Add(Me.Panel17)
        Me.P_Sidebar.Controls.Add(Me.Panel4)
        Me.P_Sidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.P_Sidebar.Location = New System.Drawing.Point(0, 42)
        Me.P_Sidebar.MaximumSize = New System.Drawing.Size(142, 350)
        Me.P_Sidebar.MinimumSize = New System.Drawing.Size(42, 350)
        Me.P_Sidebar.Name = "P_Sidebar"
        Me.P_Sidebar.Size = New System.Drawing.Size(133, 350)
        Me.P_Sidebar.TabIndex = 6
        '
        'BtnRegistrar
        '
        Me.BtnRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnRegistrar.FlatAppearance.BorderSize = 0
        Me.BtnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegistrar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegistrar.ForeColor = System.Drawing.Color.White
        Me.BtnRegistrar.Image = CType(resources.GetObject("BtnRegistrar.Image"), System.Drawing.Image)
        Me.BtnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRegistrar.Location = New System.Drawing.Point(3, 32)
        Me.BtnRegistrar.Name = "BtnRegistrar"
        Me.BtnRegistrar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnRegistrar.Size = New System.Drawing.Size(130, 30)
        Me.BtnRegistrar.TabIndex = 1
        Me.BtnRegistrar.Text = "             Registrar"
        Me.BtnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRegistrar.UseVisualStyleBackColor = True
        '
        'BtnActualizar
        '
        Me.BtnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnActualizar.FlatAppearance.BorderSize = 0
        Me.BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnActualizar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActualizar.ForeColor = System.Drawing.Color.White
        Me.BtnActualizar.Image = CType(resources.GetObject("BtnActualizar.Image"), System.Drawing.Image)
        Me.BtnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnActualizar.Location = New System.Drawing.Point(3, 65)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnActualizar.Size = New System.Drawing.Size(128, 30)
        Me.BtnActualizar.TabIndex = 1
        Me.BtnActualizar.Text = "             Actualizar"
        Me.BtnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnEliminar.FlatAppearance.BorderSize = 0
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.ForeColor = System.Drawing.Color.White
        Me.BtnEliminar.Image = CType(resources.GetObject("BtnEliminar.Image"), System.Drawing.Image)
        Me.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminar.Location = New System.Drawing.Point(3, 98)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnEliminar.Size = New System.Drawing.Size(128, 30)
        Me.BtnEliminar.TabIndex = 1
        Me.BtnEliminar.Text = "             Eliminar"
        Me.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.BackgroundImage = CType(resources.GetObject("BtnExit.BackgroundImage"), System.Drawing.Image)
        Me.BtnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnExit.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnExit.Location = New System.Drawing.Point(0, 316)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(133, 34)
        Me.BtnExit.TabIndex = 13
        Me.BtnExit.TabStop = False
        '
        'BtnTablas
        '
        Me.BtnTablas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnTablas.FlatAppearance.BorderSize = 0
        Me.BtnTablas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTablas.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTablas.ForeColor = System.Drawing.Color.White
        Me.BtnTablas.Image = CType(resources.GetObject("BtnTablas.Image"), System.Drawing.Image)
        Me.BtnTablas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnTablas.Location = New System.Drawing.Point(3, 171)
        Me.BtnTablas.Name = "BtnTablas"
        Me.BtnTablas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnTablas.Size = New System.Drawing.Size(128, 30)
        Me.BtnTablas.TabIndex = 9
        Me.BtnTablas.Text = "             Tablas"
        Me.BtnTablas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnTablas.UseVisualStyleBackColor = True
        '
        'BtnListas
        '
        Me.BtnListas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnListas.FlatAppearance.BorderSize = 0
        Me.BtnListas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnListas.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnListas.ForeColor = System.Drawing.Color.White
        Me.BtnListas.Image = CType(resources.GetObject("BtnListas.Image"), System.Drawing.Image)
        Me.BtnListas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnListas.Location = New System.Drawing.Point(3, 204)
        Me.BtnListas.Name = "BtnListas"
        Me.BtnListas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnListas.Size = New System.Drawing.Size(128, 30)
        Me.BtnListas.TabIndex = 10
        Me.BtnListas.Text = "             Listas"
        Me.BtnListas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnListas.UseVisualStyleBackColor = True
        '
        'BtnTextBox
        '
        Me.BtnTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnTextBox.FlatAppearance.BorderSize = 0
        Me.BtnTextBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTextBox.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTextBox.ForeColor = System.Drawing.Color.White
        Me.BtnTextBox.Image = CType(resources.GetObject("BtnTextBox.Image"), System.Drawing.Image)
        Me.BtnTextBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnTextBox.Location = New System.Drawing.Point(3, 237)
        Me.BtnTextBox.Name = "BtnTextBox"
        Me.BtnTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnTextBox.Size = New System.Drawing.Size(128, 30)
        Me.BtnTextBox.TabIndex = 11
        Me.BtnTextBox.Text = "             Text Box"
        Me.BtnTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnTextBox.UseVisualStyleBackColor = True
        '
        'Panel17
        '
        Me.Panel17.Controls.Add(Me.Panel18)
        Me.Panel17.Controls.Add(Me.LComponentes)
        Me.Panel17.Location = New System.Drawing.Point(0, 145)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(133, 25)
        Me.Panel17.TabIndex = 6
        '
        'Panel18
        '
        Me.Panel18.BackColor = System.Drawing.Color.White
        Me.Panel18.Location = New System.Drawing.Point(0, 19)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(142, 1)
        Me.Panel18.TabIndex = 6
        '
        'LComponentes
        '
        Me.LComponentes.AutoSize = True
        Me.LComponentes.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LComponentes.ForeColor = System.Drawing.Color.White
        Me.LComponentes.Location = New System.Drawing.Point(0, 3)
        Me.LComponentes.Name = "LComponentes"
        Me.LComponentes.Size = New System.Drawing.Size(96, 15)
        Me.LComponentes.TabIndex = 5
        Me.LComponentes.Text = "COMPONENTES"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Controls.Add(Me.LAcciones)
        Me.Panel4.Location = New System.Drawing.Point(0, 6)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(133, 25)
        Me.Panel4.TabIndex = 2
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Location = New System.Drawing.Point(0, 19)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(142, 1)
        Me.Panel5.TabIndex = 6
        '
        'LAcciones
        '
        Me.LAcciones.AutoSize = True
        Me.LAcciones.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LAcciones.ForeColor = System.Drawing.Color.White
        Me.LAcciones.Location = New System.Drawing.Point(0, 3)
        Me.LAcciones.Name = "LAcciones"
        Me.LAcciones.Size = New System.Drawing.Size(66, 15)
        Me.LAcciones.TabIndex = 5
        Me.LAcciones.Text = "ACCIONES"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Panel3.Controls.Add(Me.UI_BtnMinimize)
        Me.Panel3.Controls.Add(Me.UI_BtnExit)
        Me.Panel3.Controls.Add(Me.Panel2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.MaximumSize = New System.Drawing.Size(588, 42)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(588, 42)
        Me.Panel3.TabIndex = 7
        '
        'UI_BtnMinimize
        '
        Me.UI_BtnMinimize.BackgroundImage = CType(resources.GetObject("UI_BtnMinimize.BackgroundImage"), System.Drawing.Image)
        Me.UI_BtnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.UI_BtnMinimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UI_BtnMinimize.Image = CType(resources.GetObject("UI_BtnMinimize.Image"), System.Drawing.Image)
        Me.UI_BtnMinimize.ImageActive = Nothing
        Me.UI_BtnMinimize.Location = New System.Drawing.Point(545, 3)
        Me.UI_BtnMinimize.Name = "UI_BtnMinimize"
        Me.UI_BtnMinimize.Size = New System.Drawing.Size(17, 17)
        Me.UI_BtnMinimize.TabIndex = 2
        Me.UI_BtnMinimize.TabStop = False
        Me.UI_BtnMinimize.Zoom = 10
        '
        'UI_BtnExit
        '
        Me.UI_BtnExit.BackgroundImage = CType(resources.GetObject("UI_BtnExit.BackgroundImage"), System.Drawing.Image)
        Me.UI_BtnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.UI_BtnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UI_BtnExit.Image = CType(resources.GetObject("UI_BtnExit.Image"), System.Drawing.Image)
        Me.UI_BtnExit.ImageActive = Nothing
        Me.UI_BtnExit.Location = New System.Drawing.Point(568, 3)
        Me.UI_BtnExit.Name = "UI_BtnExit"
        Me.UI_BtnExit.Size = New System.Drawing.Size(17, 17)
        Me.UI_BtnExit.TabIndex = 1
        Me.UI_BtnExit.TabStop = False
        Me.UI_BtnExit.Zoom = 10
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.BtnNavbar)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(133, 42)
        Me.Panel2.TabIndex = 0
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox2.Location = New System.Drawing.Point(43, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(90, 42)
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'BtnNavbar
        '
        Me.BtnNavbar.BackgroundImage = CType(resources.GetObject("BtnNavbar.BackgroundImage"), System.Drawing.Image)
        Me.BtnNavbar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnNavbar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNavbar.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnNavbar.Location = New System.Drawing.Point(0, 0)
        Me.BtnNavbar.Name = "BtnNavbar"
        Me.BtnNavbar.Size = New System.Drawing.Size(43, 42)
        Me.BtnNavbar.TabIndex = 4
        Me.BtnNavbar.TabStop = False
        '
        'TSCContenedor
        '
        Me.TSCContenedor.BottomToolStripPanelVisible = False
        '
        'TSCContenedor.ContentPanel
        '
        Me.TSCContenedor.ContentPanel.Controls.Add(Me.PictureBox1)
        Me.TSCContenedor.ContentPanel.Size = New System.Drawing.Size(455, 350)
        Me.TSCContenedor.LeftToolStripPanelVisible = False
        Me.TSCContenedor.Location = New System.Drawing.Point(133, 42)
        Me.TSCContenedor.Name = "TSCContenedor"
        Me.TSCContenedor.RightToolStripPanelVisible = False
        Me.TSCContenedor.Size = New System.Drawing.Size(455, 350)
        Me.TSCContenedor.TabIndex = 8
        Me.TSCContenedor.Text = "ToolStripContainer1"
        Me.TSCContenedor.TopToolStripPanelVisible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(109, 98)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(243, 169)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(588, 392)
        Me.Controls.Add(Me.P_Padre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "Form1"
        Me.Text = "Consultas Componentes"
        Me.P_Padre.ResumeLayout(False)
        Me.P_Sidebar.ResumeLayout(False)
        CType(Me.BtnExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel17.ResumeLayout(False)
        Me.Panel17.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.UI_BtnMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UI_BtnExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnNavbar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TSCContenedor.ContentPanel.ResumeLayout(False)
        Me.TSCContenedor.ResumeLayout(False)
        Me.TSCContenedor.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents T_Sidebar As Timer
    Friend WithEvents UI_Notification1 As UIDC.UI_Notification
    Friend WithEvents P_Padre As Panel
    Friend WithEvents P_Sidebar As Panel
    Friend WithEvents BtnRegistrar As Button
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnExit As PictureBox
    Friend WithEvents BtnTablas As Button
    Friend WithEvents BtnListas As Button
    Friend WithEvents BtnTextBox As Button
    Friend WithEvents Panel17 As Panel
    Friend WithEvents Panel18 As Panel
    Friend WithEvents LComponentes As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents LAcciones As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents UI_BtnMinimize As UIDC.UI_ButtonImage
    Friend WithEvents UI_BtnExit As UIDC.UI_ButtonImage
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BtnNavbar As PictureBox
    Friend WithEvents TSCContenedor As ToolStripContainer
    Friend WithEvents PictureBox1 As PictureBox
End Class
