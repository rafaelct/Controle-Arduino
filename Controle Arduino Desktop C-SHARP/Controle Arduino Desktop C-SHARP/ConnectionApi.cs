using Controle_Arduino_Desktop_C_SHARP.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Controle_Arduino_Desktop_C_SHARP
{
    class ConnectionApi
    {

        public Led LedApi(String url) {


            var client = new WebClient();
            client.Headers.Add("User-Agent", "Nobody");


            try
            {
                var response = client.DownloadString(new Uri(url));
                var led = (Led)JsonConvert.DeserializeObject<Led>(response);
                return led;
    
            }
        catch( Exception ex ) {
                throw ex;
        }
        
        }

        public Buzzer BuzzerApi(String url) {


            var client = new WebClient();
            client.Headers.Add("User-Agent", "Nobody");

            try
            {
                var response = client.DownloadString(new Uri(url));
                var buzzer = (Buzzer)JsonConvert.DeserializeObject<Buzzer>(response);
                return buzzer;
            }
            catch ( Exception ex ) {
                throw ex;
            }

            


        }

    }
}
