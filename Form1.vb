Imports System.Environment
Imports System.IO

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Obtener la ruta al directorio AppData
        Dim appDataDir As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
        Dim rutaFirmware As String = appDataDir + "\yuzu\fwki\firmware.cmd"

        If File.Exists(rutaFirmware) Then
            ' Crear un nuevo proceso para ejecutar el script CMD
            Dim proceso As New Process()
            proceso.StartInfo.FileName = "cmd.exe"
            proceso.StartInfo.Arguments = "/C " & rutaFirmware ' "/C" se utiliza para cerrar la ventana de CMD después de ejecutar el script
            proceso.Start()
        Else
            MessageBox.Show("El archivo del script no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Obtener la ruta al directorio AppData
        Dim appDataDir As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
        Dim rutaKeys As String = appDataDir + "\yuzu\fwki\keys.cmd"

        If File.Exists(rutaKeys) Then
            ' Crear un nuevo proceso para ejecutar el script CMD
            Dim proceso As New Process()
            proceso.StartInfo.FileName = "cmd.exe"
            proceso.StartInfo.Arguments = "/C " & rutaKeys ' "/C" se utiliza para cerrar la ventana de CMD después de ejecutar el script
            proceso.Start()
        Else
            MessageBox.Show("El archivo del script no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' Obtener la ruta al directorio AppData
        Dim appDataDir As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
        Dim rutaInst As String = appDataDir + "\yuzu\fwki\installer.cmd"

        If File.Exists(rutaInst) Then
            ' Crear un nuevo proceso para ejecutar el script CMD
            Dim proceso As New Process()
            proceso.StartInfo.FileName = "cmd.exe"
            proceso.StartInfo.Arguments = "/C " & rutaInst ' "/C" se utiliza para cerrar la ventana de CMD después de ejecutar el script
            proceso.Start()
        Else
            MessageBox.Show("El archivo del script no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub
End Class