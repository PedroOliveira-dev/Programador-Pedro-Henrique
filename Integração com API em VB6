Public Sub FetchAndDisplayUser()
    Dim http As Object
    Set http = CreateObject("MSXML2.XMLHTTP")
    http.Open "GET", "https://randomuser.me/api/", False
    http.send

    Dim response As String
    response = http.responseText

    ' Parse o JSON e exiba os dados na tela
    ' Esta parte pode exigir uma biblioteca de JSON para VB6
    MsgBox response
End Sub
