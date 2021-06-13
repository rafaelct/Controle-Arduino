using Controle_Arduino_Desktop_C_SHARP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_Arduino_Desktop_C_SHARP.Controller
{
    class BuzzerController
    {

        public Buzzer TocarBuzzerAlarme() {
            var netApi = new ConnectionApi();

            var resposta = (Buzzer)netApi.BuzzerApi("http://localhost:8080/buzzer/tocar/alarme");

            return resposta;


    }
        public Buzzer PausarBuzzerAlarme() {

            var netApi = new ConnectionApi();
    
        var resposta = (Buzzer) netApi.BuzzerApi("http://localhost:8080/buzzer/pausar/alarme");

        return resposta;
    

    }

    public Buzzer DesligarBuzzerAlarme() {
            var netApi = new ConnectionApi();

            var resposta = (Buzzer)netApi.BuzzerApi("http://localhost:8080/buzzer/desligar/alarme");

            return resposta;


    }

    public Buzzer StatusBuzzerAlarme() {
            var netApi = new ConnectionApi();

            var resposta = (Buzzer)netApi.BuzzerApi("http://localhost:8080/buzzer/status");

            return resposta;


    }

    public Buzzer TocarBuzzerAmbulancia() {
        
            var netApi = new ConnectionApi();

            var resposta = (Buzzer) netApi.BuzzerApi("http://localhost:8080/buzzer/tocar/ambulancia");

            return resposta;


    }

    public Buzzer PausarBuzzerAmbulancia() {
            var netApi = new ConnectionApi();

            var resposta = (Buzzer)netApi.BuzzerApi("http://localhost:8080/buzzer/pausar/ambulancia");

            return resposta;


    }

    public Buzzer DesligarBuzzerAmbulancia() {
            var netApi = new ConnectionApi();

            var resposta = (Buzzer) netApi.BuzzerApi("http://localhost:8080/buzzer/desligar/ambulancia");

            return resposta;


    }

    }
}
