using Controle_Arduino_Desktop_C_SHARP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_Arduino_Desktop_C_SHARP.Controller
{
    class LedController
    {
        public Led LigarLedVerde()
        {

            var netApi = new ConnectionApi();

            var resposta = (Led)netApi.LedApi("http://localhost:8080/led/ligar/verde");

            return resposta;


        }

        public Led DesligarLedVerde()
        {

            var netApi = new ConnectionApi();

            var resposta = (Led)netApi.LedApi("http://localhost:8080/led/desligar/verde");

            return resposta;

        }

        public Led StatusLedVerde()
        {

            var netApi = new ConnectionApi();

            var resposta = (Led)netApi.LedApi("http://localhost:8080/led/status/verde");

            return resposta;

        }
        public Led LigarLedAmarelo()
        {

            var netApi = new ConnectionApi();

            var resposta = (Led)netApi.LedApi("http://localhost:8080/led/ligar/amarelo");

            return resposta;


        }

        public Led DesligarLedAmarelo()
        {

            var netApi = new ConnectionApi();

            var resposta = (Led)netApi.LedApi("http://localhost:8080/led/desligar/amarelo");

            return resposta;

        }

        public Led StatusLedAmarelo()
        {

            var netApi = new ConnectionApi();

            var resposta = (Led)netApi.LedApi("http://localhost:8080/led/status/amarelo");

            return resposta;

        }

    }

}
