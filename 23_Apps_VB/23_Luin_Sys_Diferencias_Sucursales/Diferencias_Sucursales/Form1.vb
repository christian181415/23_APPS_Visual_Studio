Imports Microsoft.Office.Interop
Public Class Form1
    Dim RutaAccess = System.IO.Directory.GetCurrentDirectory + "DB\Sys_Dif_Suc_23.mdb"
    Private Sub BtnCargarArchivo_Click(sender As Object, e As EventArgs) Handles BtnCargarArchivo.Click
        Dim RutaExcel As String = OpenFileExcel.ShowDialog()


        If RutaExcel = Windows.Forms.DialogResult.OK Then
            Dim ConexionExcel = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & RutaExcel & ";Extended Properties='Excel 12.0 Xml;'"
            Dim TablaAccess As String = "Lotes"
            Dim HojaExcel As String = "[Lotes$]"

            Dim Consulta As String = String.Format("INSERT INTO {0} IN '{1}' SELECT [Codigo$, Producto$, Existencia$] FROM {2}", TablaAccess, RutaAccess, HojaExcel)
            Try
                Using ConexionDB As New OleDb.OleDbConnection(ConexionExcel)
                    Dim Comando As OleDb.OleDbCommand = ConexionDB.CreateCommand()
                    Comando.CommandText = Consulta
                    ConexionDB.Open()
                    Dim Registros As Integer = Comando.ExecuteNonQuery()
                    MsgBox("Nº de registros: " & Registros)
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim RutaAccess = System.IO.Directory.GetCurrentDirectory + "DB\Sys_Dif_Suc_23.mdb"
        MsgBox(RutaAccess)
    End Sub
End Class
