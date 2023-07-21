<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Button1 = New Button()
        Button2 = New Button()
        Label1 = New Label()
        Button4 = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(62, 86)
        Button1.Name = "Button1"
        Button1.Size = New Size(441, 75)
        Button1.TabIndex = 1
        Button1.Text = "DESCARGAR FIRMWARE"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(62, 167)
        Button2.Name = "Button2"
        Button2.Size = New Size(441, 75)
        Button2.TabIndex = 2
        Button2.Text = "DESCARGAR KEYS"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(73, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(430, 32)
        Label1.TabIndex = 4
        Label1.Text = "YUZU FIRMWARE AND KEYS INSTALLER"
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(62, 266)
        Button4.Name = "Button4"
        Button4.Size = New Size(441, 112)
        Button4.TabIndex = 5
        Button4.Text = "INSTALAR"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(575, 450)
        Controls.Add(Button4)
        Controls.Add(Label1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button4 As Button
End Class
