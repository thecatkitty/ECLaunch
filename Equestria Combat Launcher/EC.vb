#Const LANG = "en"

Namespace Texts
    Module EC
        Public Const ECBuild As String = "131231a"
        Public Const ECGame As String = "ecgame.exe"
    End Module
#If LANG = "en" Then
    Module UI
        Public Const ECL = "Equestria Combat Launcher"
        Public Const LauncherV As String = "Launcher v. {0}.{1}"
        Public Const Username As String = "Username"
        Public Const Password As String = "Password"
        Public Const HelloUU As String = "Hello, unregistered User!"
        Public Const Play As String = "Play Equestria Combat"
        Public Const Login As String = "Login"
        Public Const Register As String = "Register"
        Public Const Quit As String = "Quit"

        Public Const HelloU As String = "Hello, {0}!"
        Public Const Logout As String = "Logout"
        Public Const TMA As String = "Too many failed attempts, closing the launcher..."
        Public Const AuthFail As String = "Authorization failed"
        Public Const AttNOf3 As String = "Incorrect login and/or password. Attempt {0} of 3."
        Public Const AuthErr As String = "Authorization error"

        Public Const About As String = "Equestria Combat - about"
        Public Const Version As String = "Build {0}, Launcher version {1}.{2}.{3}"
        Public Const LOP As String = "Equestria Combat © 2012-2014 Drunked Lullabies. All rights reserved." & vbNewLine & vbNewLine & "Project leader - Gresiu" & vbNewLine & vbNewLine & "Developer - Chiredan" & vbNewLine & "Launcher developer - Matriksoft" & vbNewLine & vbNewLine & "Concept art - Sherman" & vbNewLine & vbNewLine & "Voice actors:" & vbNewLine & "Leurie as Sette" & vbNewLine & "Sherman as Sherman" & vbNewLine & "Natsus as Nuclear Silence" & vbNewLine & "MatriX5b as a someone" & vbNewLine & vbNewLine & "MADE IN POLAND"
        Public Const Project As String = "Equestria Combat"
    End Module
#ElseIf LANG = "pl" Then
    Module UI
        Public Const ECL = "Launcher Equestria Combat"
        Public Const LauncherV As String = "Launcher wer. {0}.{1}"
        Public Const Username As String = "Nazwa użytkownika"
        Public Const Password As String = "Hasło"
        Public Const HelloUU As String = "Witaj, niezarejestrowany Użytkowniku!"
        Public Const Play As String = "Uruchom Equestria Combat"
        Public Const Login As String = "Zaloguj"
        Public Const Register As String = "Zarejestruj"
        Public Const Quit As String = "Zakończ"

        Public Const HelloU As String = "Witaj, {0}!"
        Public Const Logout As String = "Wyloguj"
        Public Const TMA As String = "Przekroczono limit prób. Launcher zostanie zamknięty..."
        Public Const AuthFail As String = "Krytyczny błąd autoryzacji"
        Public Const AttNOf3 As String = "Niepoprawny login i/lub hasło. Próba {0} z 3."
        Public Const AuthErr As String = "Błąd autoryzacji"

        Public Const About As String = "Equestria Combat - informacje"
        Public Const Version As String = "Kompilacja {0}, wersja Launchera {1}.{2}.{3}"
        Public Const LOP As String = "Equestria Combat © 2012-2014 Drunked Lullabies. Wszelkie prawa zastrzeżone." & vbNewLine & vbNewLine & "Lider projektu - Gresiu" & vbNewLine & vbNewLine & "Programista - Chiredan" & vbNewLine & "Programista Launchera - Matriksoft" & vbNewLine & vbNewLine & "Concept art - Sherman" & vbNewLine & vbNewLine & "Aktorzy głosowi:" & vbNewLine & "Leurie jako Sette" & vbNewLine & "Sherman jako Sherman" & vbNewLine & "Natsus jako Nuclear Silence" & vbNewLine & "MatriX5b jako ktoś" & vbNewLine & vbNewLine & "PRODUKT POLSKI"
        Public Const Project As String = "Equestria Combat"
    End Module
#End If
End Namespace