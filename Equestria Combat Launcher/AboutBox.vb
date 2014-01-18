Public NotInheritable Class AboutBox

    Private Sub AboutBox_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = Texts.About
        Me.LabelVersion.Text = String.Format(Texts.Version, Texts.ECBuild, My.Application.Info.Version.Major.ToString, My.Application.Info.Version.Minor.ToString, My.Application.Info.Version.Build.ToString)
        Me.LabelCopyright.Text = My.Application.Info.Copyright
        TextBoxDescription.Text = Texts.LOP
        LabelProductName.Text = Texts.Project
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub

End Class
