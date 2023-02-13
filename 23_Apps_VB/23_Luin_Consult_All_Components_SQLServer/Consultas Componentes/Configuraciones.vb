Public Class Configuraciones
    Dim sidebarExpand As Boolean = True
    Public Function AnimationSidebar(P_Sidebar As Panel, T_Sidebar As Timer, LAcciones As Label, LComponentes As Label)
        If sidebarExpand Then
            P_Sidebar.Width -= 142
            If P_Sidebar.Width = P_Sidebar.Width Then
                sidebarExpand = False
                T_Sidebar.Stop()
                LAcciones.Visible = False
                LComponentes.Visible = False
            End If
        Else P_Sidebar.Width += 142
            If P_Sidebar.Width = P_Sidebar.MaximumSize.Width Then
                sidebarExpand = True
                T_Sidebar.Stop()
            End If
        End If
    End Function

    Public Function SizeWindow(Ventana As Object, Contenedor As Panel)
        Ventana.Size = New Size(588, 392)
        Contenedor.Location = New Point(0, 0)
    End Function
End Class
