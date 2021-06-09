Public Class BuzzerController

    Public Shared Function TocarBuzzerAlarme()
        Dim netApi = New ConnectionApi()

        Dim resposta As Buzzer = netApi.BuzzerApi("http://localhost:8080/buzzer/tocar/alarme")

        Return resposta


    End Function
    Public Shared Function PausarBuzzerAlarme()
        Dim netApi = New ConnectionApi()

        Dim resposta As Buzzer = netApi.BuzzerApi("http://localhost:8080/buzzer/pausar/alarme")

        Return resposta


    End Function
    Public Shared Function DesligarBuzzerAlarme()
        Dim netApi = New ConnectionApi()

        Dim resposta As Buzzer = netApi.BuzzerApi("http://localhost:8080/buzzer/desligar/alarme")

        Return resposta


    End Function
    Public Shared Function StatusBuzzerAlarme()
        Dim netApi = New ConnectionApi()

        Dim resposta As Buzzer = netApi.BuzzerApi("http://localhost:8080/buzzer/status")

        Return resposta


    End Function
    Public Shared Function TocarBuzzerAmbulancia()
        Dim netApi = New ConnectionApi()

        Dim resposta As Buzzer = netApi.BuzzerApi("http://localhost:8080/buzzer/tocar/ambulancia")

        Return resposta


    End Function
    Public Shared Function PausarBuzzerAmbulancia()
        Dim netApi = New ConnectionApi()

        Dim resposta As Buzzer = netApi.BuzzerApi("http://localhost:8080/buzzer/pausar/ambulancia")

        Return resposta


    End Function
    Public Shared Function DesligarBuzzerAmbulancia()
        Dim netApi = New ConnectionApi()

        Dim resposta As Buzzer = netApi.BuzzerApi("http://localhost:8080/buzzer/desligar/ambulancia")

        Return resposta


    End Function

End Class
