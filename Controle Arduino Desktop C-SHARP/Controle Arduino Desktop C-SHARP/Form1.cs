using Controle_Arduino_Desktop_C_SHARP.Controller;
using Controle_Arduino_Desktop_C_SHARP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_Arduino_Desktop_C_SHARP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLigLedVerde_Click(object sender, EventArgs e)
        {
            var ledController = new LedController();

            var led = (Led) ledController.LigarLedVerde();

            entLed.Text = led.cor;
            entStaLed.Text = led.statusLed;
        }

        private void btnDesLedVerde_Click(object sender, EventArgs e) {
            {
                var ledController = new LedController();

                var led = (Led)ledController.DesligarLedVerde();

                entLed.Text = led.cor;
                entStaLed.Text = led.statusLed;

            }


        }

        private void btnStaLedVerde_Click(object sender, EventArgs e)  
        {
            var ledController = new LedController();

            var led = (Led) ledController.StatusLedVerde();

            entLed.Text = led.cor;
            entStaLed.Text = led.statusLed;
        }

        private void btnLigLedAmarelo_Click(object sender, EventArgs e)
        {
            var ledController = new LedController();

            var led = (Led) ledController.LigarLedAmarelo();

            entLed.Text = led.cor;
            entStaLed.Text = led.statusLed;
        }

        private void btnDesLedAmarelo_Click(object sender, EventArgs e)
        {

            var ledController = new LedController();

            var led = (Led)ledController.DesligarLedAmarelo();

            entLed.Text = led.cor;
            entStaLed.Text = led.statusLed;
        }

        private void btnStaLedAmarelo_Click(object sender, EventArgs e)
        {
            var ledController = new LedController();

            var led = (Led) ledController.StatusLedAmarelo();

            entLed.Text = led.cor;
            entStaLed.Text = led.statusLed;

        }

        private void btnLigAlarme_Click(object sender, EventArgs e)
        {
            var buzzerController = new BuzzerController();

            var buzzer = (Buzzer) buzzerController.TocarBuzzerAlarme();

            entSom.Text = buzzer.tipoSom;
            entStaSom.Text = buzzer.status;

        }

        private void btnPauAlarme_Click(object sender, EventArgs e)
        {
            var buzzerController = new BuzzerController();

            var buzzer = (Buzzer)buzzerController.PausarBuzzerAlarme();

            entSom.Text = buzzer.tipoSom;
            entStaSom.Text = buzzer.status;
        }

        private void btnDesAlarme_Click(object sender, EventArgs e)
        {
            var buzzerController = new BuzzerController();

            var buzzer = (Buzzer) buzzerController.DesligarBuzzerAlarme();

            entSom.Text = buzzer.tipoSom;
            entStaSom.Text = buzzer.status;
        }

        private void btnStaSom_Click(object sender, EventArgs e)
        {
            var BuzzerController = new BuzzerController();

            var buzzer = (Buzzer)BuzzerController.StatusBuzzerAlarme();

            entSom.Text = buzzer.tipoSom;
            entStaSom.Text = buzzer.status;
        }

        private void btnLigAmbulancia_Click(object sender, EventArgs e)
        {
            var BuzzerController = new BuzzerController();

            var buzzer = (Buzzer) BuzzerController.TocarBuzzerAmbulancia();

            entSom.Text = buzzer.tipoSom;
            entStaSom.Text = buzzer.status;
        }

        private void btnPauAmbulancia_Click(object sender, EventArgs e)
        {
            var BuzzerController = new BuzzerController();

            var buzzer = (Buzzer) BuzzerController.PausarBuzzerAmbulancia();

            entSom.Text = buzzer.tipoSom;
            entStaSom.Text = buzzer.status;
        }

        private void btnDesAmbulancia_Click(object sender, EventArgs e)
        {
            var buzzerController = new BuzzerController();

            var buzzer = (Buzzer) buzzerController.DesligarBuzzerAmbulancia();

            entSom.Text = buzzer.tipoSom;
            entStaSom.Text = buzzer.status;
        }
    }
}
