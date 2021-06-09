Public Class Form1
    Private Sub btnLigLedAmarelo_Click(sender As Object, e As EventArgs) Handles btnLigLedAmarelo.Click
        Dim ledController As New LedController()

        Dim led As Led = LedController.LigarLedAmarelo()

        entLed.Text = led.cor
        entStaLed.Text = led.statusLed

    End Sub

    Private Sub btnDesLedAmarelo_Click(sender As Object, e As EventArgs) Handles btnDesLedAmarelo.Click
        Dim ledController As New LedController()

        Dim led As Led = LedController.DesligarLedAmarelo()

        entLed.Text = led.cor
        entStaLed.Text = led.statusLed

    End Sub

    Private Sub btnStaLedAmarelo_Click(sender As Object, e As EventArgs) Handles btnStaLedAmarelo.Click
        Dim ledController As New LedController()

        Dim led As Led = LedController.StatusLedAmarelo()

        entLed.Text = led.cor
        entStaLed.Text = led.statusLed

    End Sub

    Private Sub btnLigLedVerde_Click(sender As Object, e As EventArgs) Handles btnLigLedVerde.Click
        Dim ledController As New LedController()

        Dim led As Led = LedController.LigarLedVerde()

        entLed.Text = led.cor
        entStaLed.Text = led.statusLed

    End Sub

    Private Sub btnDesLedVerde_Click(sender As Object, e As EventArgs) Handles btnDesLedVerde.Click
        Dim ledController As New LedController()

        Dim led As Led = LedController.DesligarLedVerde()

        entLed.Text = led.cor
        entStaLed.Text = led.statusLed

    End Sub

    Private Sub btnStaLedVerde_Click(sender As Object, e As EventArgs) Handles btnStaLedVerde.Click
        Dim ledController As New LedController()

        Dim led As Led = LedController.StatusLedVerde()

        entLed.Text = led.cor
        entStaLed.Text = led.statusLed

    End Sub

    Private Sub btnLigSomAlarme_Click(sender As Object, e As EventArgs) Handles btnLigSomAlarme.Click
        Dim BuzzerController As New BuzzerController()

        Dim buzzer As Buzzer = BuzzerController.TocarBuzzerAlarme()

        entSom.Text = buzzer.tipoSom
        entStaSom.Text = buzzer.status

    End Sub

    Private Sub btnPauSomAlarme_Click(sender As Object, e As EventArgs) Handles btnPauSomAlarme.Click
        Dim BuzzerController As New BuzzerController()

        Dim buzzer As Buzzer = BuzzerController.PausarBuzzerAlarme()

        entSom.Text = buzzer.tipoSom
        entStaSom.Text = buzzer.status

    End Sub

    Private Sub btnDesSomAlarme_Click(sender As Object, e As EventArgs) Handles btnDesSomAlarme.Click
        Dim BuzzerController As New BuzzerController()

        Dim buzzer As Buzzer = BuzzerController.DesligarBuzzerAlarme()

        entSom.Text = buzzer.tipoSom
        entStaSom.Text = buzzer.status

    End Sub

    Private Sub btnStatusSom_Click(sender As Object, e As EventArgs) Handles btnStatusSom.Click
        Dim BuzzerController As New BuzzerController()

        Dim buzzer As Buzzer = BuzzerController.StatusBuzzerAlarme()

        entSom.Text = buzzer.tipoSom
        entStaSom.Text = buzzer.status

    End Sub

    Private Sub btnLigSomAmbulancia_Click(sender As Object, e As EventArgs) Handles btnLigSomAmbulancia.Click
        Dim BuzzerController As New BuzzerController()

        Dim buzzer As Buzzer = BuzzerController.TocarBuzzerAmbulancia()

        entSom.Text = buzzer.tipoSom
        entStaSom.Text = buzzer.status


    End Sub

    Private Sub btnPauSomAmbulancia_Click(sender As Object, e As EventArgs) Handles btnPauSomAmbulancia.Click
        Dim BuzzerController As New BuzzerController()

        Dim buzzer As Buzzer = BuzzerController.PausarBuzzerAmbulancia()

        entSom.Text = buzzer.tipoSom
        entStaSom.Text = buzzer.status

    End Sub

    Private Sub btnDesSomAmbulancia_Click(sender As Object, e As EventArgs) Handles btnDesSomAmbulancia.Click
        Dim BuzzerController As New BuzzerController()

        Dim buzzer As Buzzer = BuzzerController.DesligarBuzzerAmbulancia()

        entSom.Text = buzzer.tipoSom
        entStaSom.Text = buzzer.status

    End Sub
End Class
