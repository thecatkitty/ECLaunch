Module Users
    Public Function IsRegistered(n As String) As Boolean
        Dim t As Boolean = False
        For Each i In My.Settings.UDB
            t = i.StartsWith(String.Format("{0};", n))
        Next
        IsRegistered = t
    End Function

    Public Function Authorize(a As String, b As String) As Boolean
        Dim t As Boolean = False
        For Each i In My.Settings.UDB
            t = i.StartsWith(String.Format("{0};{1};", a, b))
        Next
        Authorize = t
    End Function
End Module
