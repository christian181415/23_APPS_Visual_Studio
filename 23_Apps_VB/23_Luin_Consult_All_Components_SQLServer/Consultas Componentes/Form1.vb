Public Class Form1
    Dim NewConfig As Configuraciones = New Configuraciones()
    Private Sub Consultas_Componentes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NewConfig.SizeWindow(Me, P_Padre)
    End Sub

    '----------------------------------------------------------------------------------------- CONFIGURACIONES
    Private Sub T_Sidebar_Tick(sender As Object, e As EventArgs) Handles T_Sidebar.Tick
        NewConfig.AnimationSidebar(P_Sidebar, T_Sidebar, LAcciones, LComponentes)
    End Sub
    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Application.Exit()
    End Sub
    Private Sub UI_BtnExit_Click(sender As Object, e As EventArgs) Handles UI_BtnExit.Click
        Application.Exit()
    End Sub
    Private Sub UI_BtnMinimize_Click(sender As Object, e As EventArgs) Handles UI_BtnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    '----------------------------------------------------------------------------------------- BOTONES
    Private Sub BtnNavbar_Click(sender As Object, e As EventArgs) Handles BtnNavbar.Click
        T_Sidebar.Start()
    End Sub
    'BOTON PARA REGISTRAR
    Private Sub BtnRegistrar_Click_1(sender As Object, e As EventArgs) Handles BtnRegistrar.Click
        Me.TSCContenedor.ContentPanel.Controls.Clear()
        Dim FormRegistro As New Registrar
        FormRegistro.MdiParent = Me
        Me.TSCContenedor.ContentPanel.Controls.Add(FormRegistro)
        FormRegistro.Show()
    End Sub
End Class
