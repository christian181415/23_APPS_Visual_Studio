Imports System.Data.OleDb
Imports MaterialSkin
Imports Microsoft.Office.Interop

Public Class Form1
    'VARIABLES GLOBALES
    Dim RutaArchivo, NombreArchivo As String
    'VARIABLES PARA LOTES
    Dim NAlmacenL, AlmacenL, NCodigoL, CodigoL, ProductoL, ExistenciaL, FechaRegistroL, InsertarContentL, NombreL As String
    Dim TotalFilasL, FilasL As Long
    'VARIABLES PARA INVENTARIOS
    Dim NAlmacenI, AlmacenI, NCodigoI, CodigoI, ProductoI, ExistenciaI, FechaRegistroI, InsertarContentI, NombreI As String
    Dim TotalFilasI, FilasI As Long


    'VARIABLES Y RUTAS DE ACCESO
    Dim RutaAccess = Convert.ToString(System.IO.Directory.GetCurrentDirectory + "\DB\Sys_Dif_Suc_2023.mdb")
    Dim CadenaConexionExcel As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + RutaArchivo + ";" & "Extended Properties='Excel 12.0 Xml;'"
    Dim TablaAccessLotes As String = "Lotes (Almacen, Codigo, Producto, Existencia, Fecha_Registro)"
    Dim TablaAccessExistencias As String = "Existencias (Almacen, Codigo, Producto, Existencia, Fecha_Registro)"


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'CONFIGURA EL PAQUETE NUGET 'MATERIAL SKIN 2' QUE PERMITE MOSTRAR APLICACIONES CON DISEÑOS MODERNOS
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.DARK
        SkinManager.ColorScheme = New ColorScheme(9054763, 9054763, Primary.Red500, 16777215, TextShade.WHITE)

        BWLotes.WorkerReportsProgress = True
        BWLotes.WorkerSupportsCancellation = True
    End Sub
    '-------------------------------------------------------------------------------------------------------------------------------------------
    '------------------------------------------------------------FUNCIONES PARA LOTES-----------------------------------------------------------
    Private Sub BtnArchivo_Click(sender As Object, e As EventArgs) Handles BtnArchivo.Click
        If OpenFileDialog.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            OpenFileDialog.Title = "Seleccione el archivo Excel a cargar."
            OpenFileDialog.Filter = "Archivos Excel(*.xls;*.xlsx)|*.xls;*xlsx"
            RutaArchivo = OpenFileDialog.FileName
            NombreArchivo = OpenFileDialog.SafeFileName

            BWLotes.RunWorkerAsync()
            BWInventarios.RunWorkerAsync()

            LArchivo.Visible = True
            LArchivo.Text = NombreArchivo
            LLotes.Visible = True
            PBarLotes.Visible = True
            LInventario.Visible = True
            PBarInventario.Visible = True
        End If

    End Sub

    Private Sub BWLotes_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BWLotes.DoWork
        Dim CadenaConexionAccess = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + RutaAccess + "; Persist Security Info=False"
        'UTILIZACION DE LIBRERIA EXCEL
        Dim HojaExcel As Object
        Dim ExApp As Object
        Dim ExWB As Excel.Workbook = Nothing
        Dim ExSheets As Excel.Sheets = Nothing

        ExApp = New Excel.Application()
        ExWB = ExApp.Workbooks.Open(RutaArchivo)
        HojaExcel = ExWB.Worksheets("Lotes General")
        TotalFilasL = HojaExcel.UsedRange.SpecialCells(Microsoft.Office.Interop.Excel.XlCellType.xlCellTypeLastCell).Row - 1
        Try
            Using ConexionDB As New System.Data.OleDb.OleDbConnection(CadenaConexionAccess)
                Dim Comando As OleDbCommand = ConexionDB.CreateCommand()
                ConexionDB.Open()
                For FilasL = 4 To TotalFilasL
                    BWLotes.ReportProgress(FilasL)
                    NCodigoL = HojaExcel.Cells(FilasL + 1, 2).value
                    If NCodigoL <> "" Then
                        AlmacenL = HojaExcel.Cells(FilasL + 1, 2).value
                        CodigoL = HojaExcel.Cells(FilasL + 1, 3).value.ToString.Replace("'", "")
                        ProductoL = HojaExcel.Cells(FilasL + 1, 4).value.ToString.Replace("'", "")
                        ExistenciaL = HojaExcel.Cells(FilasL + 1, 8).value
                        FechaRegistroL = Date.Today()
                    End If

                    InsertarContentL = String.Format("INSERT INTO {0} VALUES('{1}','{2}','{3}',{4}, '{5}');", TablaAccessLotes, AlmacenL, CodigoL, ProductoL, ExistenciaL, FechaRegistroL)
                    NombreL = "Lote: " & AlmacenL & " " & CodigoL
                    Comando.CommandText = InsertarContentL
                    Dim Datos As Integer = Comando.ExecuteNonQuery()
                Next
                'ConexionDB.Close()
            End Using
            ExWB.Close(True)
            ExApp.Quit()
        Catch ex As Exception
            MsgBox(ex.Message)
            ExWB.Close(True)
            ExApp.Quit()
        End Try
    End Sub

    Private Sub BWLotes_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BWLotes.ProgressChanged
        PBarLotes.Maximum = TotalFilasL
        PBarLotes.Value = e.ProgressPercentage
        LLotes.Text = NombreL
    End Sub






    '-------------------------------------------------------------------------------------------------------------------------------------------
    '------------------------------------------------------------FUNCIONES PARA INVENTARIOS-----------------------------------------------------
    Private Sub BWInventarios_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BWInventarios.DoWork
        Dim CadenaConexionAccess = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + RutaAccess + "; Persist Security Info=False"
        'UTILIZACION DE LIBRERIA EXCEL
        Dim HojaExcel As Object
        Dim ExApp As Object
        Dim ExWB As Excel.Workbook = Nothing
        Dim ExSheets As Excel.Sheets = Nothing

        ExApp = New Excel.Application()
        ExWB = ExApp.Workbooks.Open(RutaArchivo)
        HojaExcel = ExWB.Worksheets("Inventario General")
        TotalFilasI = HojaExcel.UsedRange.SpecialCells(Microsoft.Office.Interop.Excel.XlCellType.xlCellTypeLastCell).Row - 25
        Try
            Using ConexionDB As New System.Data.OleDb.OleDbConnection(CadenaConexionAccess)
                Dim Comando As OleDbCommand = ConexionDB.CreateCommand()
                ConexionDB.Open()

                For FilasI = 9 To TotalFilasI
                    BWInventarios.ReportProgress(FilasI)
                    NCodigoI = HojaExcel.Cells(FilasI + 2, 2).value
                    If NCodigoI <> "" And NCodigoI <> "Almacén:" And NCodigoI <> "Nombre:" And NCodigoI <> "Código Producto" Then
                        CodigoI = HojaExcel.Cells(FilasI + 2, 2).value.ToString.Replace("'", "")
                        ProductoI = HojaExcel.Cells(FilasI + 2, 3).value.ToString.Replace("'", "")
                        ExistenciaI = HojaExcel.Cells(FilasI + 2, 9).value
                        FechaRegistroI = Date.Today()
                    Else
                        FilasI = FilasI + 4
                        CodigoI = HojaExcel.Cells(FilasI + 2, 2).value.ToString.Replace("'", "")
                        ProductoI = HojaExcel.Cells(FilasI + 2, 3).value.ToString.Replace("'", "")
                        ExistenciaI = HojaExcel.Cells(FilasI + 2, 9).value
                        FechaRegistroI = Date.Today()
                    End If

                    NAlmacenI = HojaExcel.Cells(FilasI + 1, 2).value
                    If NAlmacenI = "Nombre:" Then
                        AlmacenI = HojaExcel.Cells(FilasI + 1, 3).value
                    End If
                    InsertarContentI = String.Format("INSERT INTO {0} VALUES('{1}','{2}','{3}',{4}, '{5}');", TablaAccessExistencias, AlmacenI, CodigoI, ProductoI, ExistenciaI, FechaRegistroI)
                    NombreI = "Existencias: " & AlmacenI & " " & CodigoI
                    Comando.CommandText = InsertarContentI
                    Dim Datos As Integer = Comando.ExecuteNonQuery()
                Next
                'ConexionDB.Close()
                MsgBox("Proceso terminado" & Chr(10) & "Nº de registros insertados correctamente: " & FilasL & Chr(10) & "Hora de termino: " & DateTime.Now.ToShortTimeString())
            End Using
            ExWB.Close(True)
            ExApp.Quit()
        Catch ex As Exception
            MsgBox(ex.Message)
            ExWB.Close(True)
            ExApp.Quit()
        End Try
    End Sub

    Private Sub BWInventarios_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BWInventarios.ProgressChanged
        PBarInventario.Maximum = TotalFilasI
        PBarInventario.Value = e.ProgressPercentage
        LInventario.Text = NombreI
    End Sub
End Class
