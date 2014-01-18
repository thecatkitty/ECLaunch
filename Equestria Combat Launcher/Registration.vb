Public Class Registration
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If My.Settings.UDB Is Nothing Then
            My.Settings.UDB = New System.Collections.Specialized.StringCollection
        End If
        If txtUsername.Text <> "" And
        txtPassword.Text <> "" Then
            If IsRegistered(txtUsername.Text) Then
                MsgBox(String.Format("Username {0} is already registered.", txtUsername.Text), MsgBoxStyle.Exclamation, "Invalid input")
            ElseIf txtPassword.Text = txtRepeat.Text Then
                If txtPassword.Text.Contains(";") Then
                    MsgBox("Neither username nor password, nor e-mail address can contain a semicolon.", MsgBoxStyle.Exclamation, "Invalid input")
                Else
                    My.Settings.UDB.Add(String.Format("{0};{1};{2}", txtUsername.Text, txtPassword.Text, txtEmail.Text))
                    My.Settings.Save()
                    txtEmail.Text = ""
                    txtPassword.Text = ""
                    txtRepeat.Text = ""
                    txtUsername.Text = ""
                    Me.Close()
                End If
            Else
                MsgBox("Passwords aren't the same!", MsgBoxStyle.Exclamation, "Equestria Combat registration")
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtEmail.Text = ""
        txtPassword.Text = ""
        txtRepeat.Text = ""
        txtUsername.Text = ""
        Me.Close()
    End Sub
End Class