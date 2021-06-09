Public Class LedController

    Public Shared Function LigarLedAmarelo()
        Dim netApi = New ConnectionApi()

        Dim resposta As Led = netApi.LedApi("http://localhost:8080/led/ligar/amarelo")

        Return resposta


    End Function
    Public Shared Function DesligarLedAmarelo()
        Dim netApi = New ConnectionApi()

        Dim resposta As Led = netApi.LedApi("http://localhost:8080/led/desligar/amarelo")

        Return resposta


    End Function
    Public Shared Function StatusLedAmarelo()
        Dim netApi = New ConnectionApi()

        Dim resposta As Led = netApi.LedApi("http://localhost:8080/led/status/amarelo")

        Return resposta


    End Function
    Public Shared Function LigarLedVerde()
        Dim netApi = New ConnectionApi()

        Dim resposta As Led = netApi.LedApi("http://localhost:8080/led/ligar/verde")

        Return resposta


    End Function
    Public Shared Function DesligarLedVerde()
        Dim netApi = New ConnectionApi()

        Dim resposta As Led = netApi.LedApi("http://localhost:8080/led/desligar/verde")

        Return resposta


    End Function
    Public Shared Function StatusLedVerde()
        Dim netApi = New ConnectionApi()

        Dim resposta As Led = netApi.LedApi("http://localhost:8080/led/status/verde")

        Return resposta


    End Function
End Class
