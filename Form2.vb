Public Class Form2

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Width = 1200
        Me.Height = 600
        Me.CenterToScreen()
        Me.WebBrowser1.Dock = DockStyle.Fill
        Dim chemin As String = Application.StartupPath
        chemin &= "\aide.html"
        Me.WebBrowser1.Navigate(chemin)

    End Sub
End Class