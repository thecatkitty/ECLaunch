Public Class MainWindow
    Dim iAtt As Integer = 1
    Dim bLoggedIn As Boolean

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        Shell(Texts.ECGame)
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If My.Settings.UDB Is Nothing Then
            My.Settings.UDB = New System.Collections.Specialized.StringCollection
        End If
        If txtUsername.Text <> "" And
        txtPassword.Text <> "" Then
            If Authorize(txtUsername.Text, txtPassword.Text) Then
                bLoggedIn = True
                labHello.Text = String.Format(Texts.HelloU, txtUsername.Text)
                oProgress.Value = 100
                btnLogin.Text = Texts.Logout
                AddHandler btnLogin.Click, AddressOf logout
                labUsername.Hide()
                txtUsername.Hide()
                labPassword.Hide()
                txtPassword.Hide()
            ElseIf iAtt = 3 Then
                MsgBox(Texts.TMA, MsgBoxStyle.Critical, Texts.AuthFail)
                Close()
            Else
                MsgBox(String.Format(Texts.AttNOf3, iAtt.ToString), MsgBoxStyle.Exclamation, Texts.AuthErr)
                iAtt += 1
                txtUsername.Text = ""
                txtPassword.Text = ""
            End If
        End If
    End Sub

    Private Sub logout(sender As Object, e As EventArgs)
        bLoggedIn = False
        btnLogin.Text = Texts.Login
        AddHandler btnLogin.Click, AddressOf btnLogin_Click
        txtUsername.Text = ""
        txtPassword.Text = ""
        labHello.Text = Texts.HelloUU
        oProgress.Value = 0
        labUsername.Show()
        txtUsername.Show()
        labPassword.Show()
        txtPassword.Show()
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Registration.ShowDialog(Me)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub MainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        logout(btnLogin, New System.EventArgs)
        Me.Text = Texts.ECL
        labRelease.Text = String.Format(Texts.LauncherV, My.Application.Info.Version.Major.ToString, My.Application.Info.Version.Minor.ToString)
        labUsername.Text = Texts.Username
        labPassword.Text = Texts.Password
        labHello.Text = Texts.HelloUU
        btnPlay.Text = Texts.Play
        btnLogin.Text = Texts.Login
        btnRegister.Text = Texts.Register
        btnExit.Text = Texts.Quit
    End Sub

    Private Sub labCopy_Click(sender As Object, e As EventArgs) Handles labCopy.Click
        AboutBox.ShowDialog(Me)
    End Sub
End Class