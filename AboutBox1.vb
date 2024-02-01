Public NotInheritable Class apropos

    Private Sub AboutBox1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub

    Private Sub LabelCopyright_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelCopyright.Click

    End Sub
End Class
