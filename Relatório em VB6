Public Sub ListUsers()
    Dim conn As Object
    Set conn = CreateObject("ADODB.Connection")
    conn.Open "Host=myserver;Username=mylogin;Password=mypass;Database=mydatabase"

    Dim rs As Object
    Set rs = conn.Execute("SELECT * FROM Users")

    Do While Not rs.EOF
        Debug.Print rs.Fields("Id").Value & " " & rs.Fields("FirstName").Value & " " & rs.Fields("LastName").Value
        rs.MoveNext
    Loop

    rs.Close
    Set rs = Nothing
    conn.Close
    Set conn = Nothing
End Sub
