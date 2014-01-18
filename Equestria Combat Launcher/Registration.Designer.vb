<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registration
    Inherits System.Windows.Forms.Form

    'Formularz zastępuje metodę dispose, aby wyczyścić listę składników.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wymagane przez Projektanta formularzy systemu Windows
    Private components As System.ComponentModel.IContainer

    'UWAGA: Następująca procedura jest wymagana przez Projektanta formularzy systemu Windows
    'Można to modyfikować, używając Projektanta formularzy systemu Windows.  
    'Nie należy modyfikować za pomocą edytora kodu.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.labUsername = New System.Windows.Forms.Label()
        Me.labPassword = New System.Windows.Forms.Label()
        Me.labRepeat = New System.Windows.Forms.Label()
        Me.labEmail = New System.Windows.Forms.Label()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtRepeat = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.labUsername, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.labPassword, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.labRepeat, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.labEmail, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.btnRegister, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.btnCancel, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.txtUsername, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtPassword, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtRepeat, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtEmail, 1, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(184, 161)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'labUsername
        '
        Me.labUsername.AutoSize = True
        Me.labUsername.Dock = System.Windows.Forms.DockStyle.Right
        Me.labUsername.Location = New System.Drawing.Point(34, 0)
        Me.labUsername.Name = "labUsername"
        Me.labUsername.Size = New System.Drawing.Size(55, 32)
        Me.labUsername.TabIndex = 0
        Me.labUsername.Text = "Username"
        Me.labUsername.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'labPassword
        '
        Me.labPassword.AutoSize = True
        Me.labPassword.Dock = System.Windows.Forms.DockStyle.Right
        Me.labPassword.Location = New System.Drawing.Point(36, 32)
        Me.labPassword.Name = "labPassword"
        Me.labPassword.Size = New System.Drawing.Size(53, 32)
        Me.labPassword.TabIndex = 1
        Me.labPassword.Text = "Password"
        Me.labPassword.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'labRepeat
        '
        Me.labRepeat.AutoSize = True
        Me.labRepeat.Dock = System.Windows.Forms.DockStyle.Right
        Me.labRepeat.Location = New System.Drawing.Point(37, 64)
        Me.labRepeat.Name = "labRepeat"
        Me.labRepeat.Size = New System.Drawing.Size(52, 32)
        Me.labRepeat.TabIndex = 2
        Me.labRepeat.Text = "Repeat password"
        Me.labRepeat.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'labEmail
        '
        Me.labEmail.AutoSize = True
        Me.labEmail.Dock = System.Windows.Forms.DockStyle.Right
        Me.labEmail.Location = New System.Drawing.Point(14, 96)
        Me.labEmail.Name = "labEmail"
        Me.labEmail.Size = New System.Drawing.Size(75, 32)
        Me.labEmail.TabIndex = 3
        Me.labEmail.Text = "E-mail address"
        Me.labEmail.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnRegister
        '
        Me.btnRegister.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnRegister.Location = New System.Drawing.Point(3, 135)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(86, 23)
        Me.btnRegister.TabIndex = 4
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnCancel.Location = New System.Drawing.Point(95, 135)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(86, 23)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtUsername
        '
        Me.txtUsername.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtUsername.Location = New System.Drawing.Point(95, 3)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(86, 20)
        Me.txtUsername.TabIndex = 6
        '
        'txtPassword
        '
        Me.txtPassword.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtPassword.Location = New System.Drawing.Point(95, 35)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(86, 20)
        Me.txtPassword.TabIndex = 7
        '
        'txtRepeat
        '
        Me.txtRepeat.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtRepeat.Location = New System.Drawing.Point(95, 67)
        Me.txtRepeat.Name = "txtRepeat"
        Me.txtRepeat.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtRepeat.Size = New System.Drawing.Size(86, 20)
        Me.txtRepeat.TabIndex = 8
        '
        'txtEmail
        '
        Me.txtEmail.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtEmail.Location = New System.Drawing.Point(95, 99)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(86, 20)
        Me.txtEmail.TabIndex = 9
        '
        'Registration
        '
        Me.AcceptButton = Me.btnRegister
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(184, 161)
        Me.ControlBox = False
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.MaximumSize = New System.Drawing.Size(200, 200)
        Me.MinimumSize = New System.Drawing.Size(200, 200)
        Me.Name = "Registration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Registration"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents labUsername As System.Windows.Forms.Label
    Friend WithEvents labPassword As System.Windows.Forms.Label
    Friend WithEvents labRepeat As System.Windows.Forms.Label
    Friend WithEvents labEmail As System.Windows.Forms.Label
    Friend WithEvents btnRegister As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtRepeat As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
End Class
