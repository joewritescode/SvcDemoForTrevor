' NOTE: You can use the "Rename" command on the context menu to change the class name "FAQ" in code, svc and config file together.
Public Class FAQ
    Implements IFAQ

    Public Function HelloWorld(ByVal searchParm As String) As Monkeys Implements IFAQ.HelloWorld
        Dim myMonkeys As New Monkeys()

        Dim monkey As Monkey

        monkey = New Monkey()
        monkey.Name = "Trev"
        monkey.Age = 32

        myMonkeys.Add(monkey)

        monkey = New Monkey()
        monkey.Name = searchParm
        monkey.Age = 12

        myMonkeys.Add(monkey)

        Return myMonkeys

    End Function

End Class
