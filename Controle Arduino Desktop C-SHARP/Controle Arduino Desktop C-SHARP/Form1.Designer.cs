
namespace Controle_Arduino_Desktop_C_SHARP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLigLedVerde = new System.Windows.Forms.Button();
            this.btnDesLedVerde = new System.Windows.Forms.Button();
            this.btnStaLedVerde = new System.Windows.Forms.Button();
            this.btnLigAlarme = new System.Windows.Forms.Button();
            this.btnPauAlarme = new System.Windows.Forms.Button();
            this.btnDesAlarme = new System.Windows.Forms.Button();
            this.btnLigLedAmarelo = new System.Windows.Forms.Button();
            this.btnDesLedAmarelo = new System.Windows.Forms.Button();
            this.btnStaLedAmarelo = new System.Windows.Forms.Button();
            this.btnLigAmbulancia = new System.Windows.Forms.Button();
            this.btnPauAmbulancia = new System.Windows.Forms.Button();
            this.btnDesAmbulancia = new System.Windows.Forms.Button();
            this.lblLed = new System.Windows.Forms.Label();
            this.lblStaLed = new System.Windows.Forms.Label();
            this.entLed = new System.Windows.Forms.Label();
            this.entStaLed = new System.Windows.Forms.Label();
            this.lblSom = new System.Windows.Forms.Label();
            this.entSom = new System.Windows.Forms.Label();
            this.lblStaSom = new System.Windows.Forms.Label();
            this.entStaSom = new System.Windows.Forms.Label();
            this.btnStaSom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLigLedVerde
            // 
            this.btnLigLedVerde.Location = new System.Drawing.Point(28, 140);
            this.btnLigLedVerde.Name = "btnLigLedVerde";
            this.btnLigLedVerde.Size = new System.Drawing.Size(140, 23);
            this.btnLigLedVerde.TabIndex = 0;
            this.btnLigLedVerde.Text = "Ligar Led Verde";
            this.btnLigLedVerde.UseVisualStyleBackColor = true;
            this.btnLigLedVerde.Click += new System.EventHandler(this.btnLigLedVerde_Click);
            // 
            // btnDesLedVerde
            // 
            this.btnDesLedVerde.Location = new System.Drawing.Point(28, 169);
            this.btnDesLedVerde.Name = "btnDesLedVerde";
            this.btnDesLedVerde.Size = new System.Drawing.Size(140, 23);
            this.btnDesLedVerde.TabIndex = 1;
            this.btnDesLedVerde.Text = "Desligar Led Verde";
            this.btnDesLedVerde.UseVisualStyleBackColor = true;
            this.btnDesLedVerde.Click += new System.EventHandler(this.btnDesLedVerde_Click);
            // 
            // btnStaLedVerde
            // 
            this.btnStaLedVerde.Location = new System.Drawing.Point(28, 198);
            this.btnStaLedVerde.Name = "btnStaLedVerde";
            this.btnStaLedVerde.Size = new System.Drawing.Size(140, 23);
            this.btnStaLedVerde.TabIndex = 2;
            this.btnStaLedVerde.Text = "Status Led Verde";
            this.btnStaLedVerde.UseVisualStyleBackColor = true;
            this.btnStaLedVerde.Click += new System.EventHandler(this.btnStaLedVerde_Click);
            // 
            // btnLigAlarme
            // 
            this.btnLigAlarme.Location = new System.Drawing.Point(28, 253);
            this.btnLigAlarme.Name = "btnLigAlarme";
            this.btnLigAlarme.Size = new System.Drawing.Size(140, 23);
            this.btnLigAlarme.TabIndex = 3;
            this.btnLigAlarme.Text = "Tocar Som Alarme";
            this.btnLigAlarme.UseVisualStyleBackColor = true;
            this.btnLigAlarme.Click += new System.EventHandler(this.btnLigAlarme_Click);
            // 
            // btnPauAlarme
            // 
            this.btnPauAlarme.Location = new System.Drawing.Point(28, 282);
            this.btnPauAlarme.Name = "btnPauAlarme";
            this.btnPauAlarme.Size = new System.Drawing.Size(140, 23);
            this.btnPauAlarme.TabIndex = 4;
            this.btnPauAlarme.Text = "Pausar Som Alarme";
            this.btnPauAlarme.UseVisualStyleBackColor = true;
            this.btnPauAlarme.Click += new System.EventHandler(this.btnPauAlarme_Click);
            // 
            // btnDesAlarme
            // 
            this.btnDesAlarme.Location = new System.Drawing.Point(28, 311);
            this.btnDesAlarme.Name = "btnDesAlarme";
            this.btnDesAlarme.Size = new System.Drawing.Size(140, 23);
            this.btnDesAlarme.TabIndex = 5;
            this.btnDesAlarme.Text = "Desligar Som Alarme";
            this.btnDesAlarme.UseVisualStyleBackColor = true;
            this.btnDesAlarme.Click += new System.EventHandler(this.btnDesAlarme_Click);
            // 
            // btnLigLedAmarelo
            // 
            this.btnLigLedAmarelo.Location = new System.Drawing.Point(200, 140);
            this.btnLigLedAmarelo.Name = "btnLigLedAmarelo";
            this.btnLigLedAmarelo.Size = new System.Drawing.Size(166, 23);
            this.btnLigLedAmarelo.TabIndex = 6;
            this.btnLigLedAmarelo.Text = "Ligar Led Amarelo";
            this.btnLigLedAmarelo.UseVisualStyleBackColor = true;
            this.btnLigLedAmarelo.Click += new System.EventHandler(this.btnLigLedAmarelo_Click);
            // 
            // btnDesLedAmarelo
            // 
            this.btnDesLedAmarelo.Location = new System.Drawing.Point(200, 169);
            this.btnDesLedAmarelo.Name = "btnDesLedAmarelo";
            this.btnDesLedAmarelo.Size = new System.Drawing.Size(166, 23);
            this.btnDesLedAmarelo.TabIndex = 7;
            this.btnDesLedAmarelo.Text = "Desligar Led Amarelo";
            this.btnDesLedAmarelo.UseVisualStyleBackColor = true;
            this.btnDesLedAmarelo.Click += new System.EventHandler(this.btnDesLedAmarelo_Click);
            // 
            // btnStaLedAmarelo
            // 
            this.btnStaLedAmarelo.Location = new System.Drawing.Point(200, 198);
            this.btnStaLedAmarelo.Name = "btnStaLedAmarelo";
            this.btnStaLedAmarelo.Size = new System.Drawing.Size(166, 23);
            this.btnStaLedAmarelo.TabIndex = 8;
            this.btnStaLedAmarelo.Text = "Status Led Amarelo";
            this.btnStaLedAmarelo.UseVisualStyleBackColor = true;
            this.btnStaLedAmarelo.Click += new System.EventHandler(this.btnStaLedAmarelo_Click);
            // 
            // btnLigAmbulancia
            // 
            this.btnLigAmbulancia.Location = new System.Drawing.Point(200, 253);
            this.btnLigAmbulancia.Name = "btnLigAmbulancia";
            this.btnLigAmbulancia.Size = new System.Drawing.Size(166, 23);
            this.btnLigAmbulancia.TabIndex = 9;
            this.btnLigAmbulancia.Text = "Tocar Som Ambulancia";
            this.btnLigAmbulancia.UseVisualStyleBackColor = true;
            this.btnLigAmbulancia.Click += new System.EventHandler(this.btnLigAmbulancia_Click);
            // 
            // btnPauAmbulancia
            // 
            this.btnPauAmbulancia.Location = new System.Drawing.Point(200, 282);
            this.btnPauAmbulancia.Name = "btnPauAmbulancia";
            this.btnPauAmbulancia.Size = new System.Drawing.Size(166, 23);
            this.btnPauAmbulancia.TabIndex = 10;
            this.btnPauAmbulancia.Text = "Pausar Som Ambulancia";
            this.btnPauAmbulancia.UseVisualStyleBackColor = true;
            this.btnPauAmbulancia.Click += new System.EventHandler(this.btnPauAmbulancia_Click);
            // 
            // btnDesAmbulancia
            // 
            this.btnDesAmbulancia.Location = new System.Drawing.Point(200, 311);
            this.btnDesAmbulancia.Name = "btnDesAmbulancia";
            this.btnDesAmbulancia.Size = new System.Drawing.Size(166, 23);
            this.btnDesAmbulancia.TabIndex = 11;
            this.btnDesAmbulancia.Text = "Desligar Som Ambulancia";
            this.btnDesAmbulancia.UseVisualStyleBackColor = true;
            this.btnDesAmbulancia.Click += new System.EventHandler(this.btnDesAmbulancia_Click);
            // 
            // lblLed
            // 
            this.lblLed.AutoSize = true;
            this.lblLed.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLed.Location = new System.Drawing.Point(28, 43);
            this.lblLed.Name = "lblLed";
            this.lblLed.Size = new System.Drawing.Size(30, 15);
            this.lblLed.TabIndex = 12;
            this.lblLed.Text = "Led:";
            // 
            // lblStaLed
            // 
            this.lblStaLed.AutoSize = true;
            this.lblStaLed.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStaLed.Location = new System.Drawing.Point(28, 73);
            this.lblStaLed.Name = "lblStaLed";
            this.lblStaLed.Size = new System.Drawing.Size(68, 15);
            this.lblStaLed.TabIndex = 13;
            this.lblStaLed.Text = "Status Led:";
            // 
            // entLed
            // 
            this.entLed.AutoSize = true;
            this.entLed.Location = new System.Drawing.Point(63, 43);
            this.entLed.Name = "entLed";
            this.entLed.Size = new System.Drawing.Size(25, 15);
            this.entLed.TabIndex = 14;
            this.entLed.Text = "n/a";
            // 
            // entStaLed
            // 
            this.entStaLed.AutoSize = true;
            this.entStaLed.Location = new System.Drawing.Point(98, 73);
            this.entStaLed.Name = "entStaLed";
            this.entStaLed.Size = new System.Drawing.Size(25, 15);
            this.entStaLed.TabIndex = 15;
            this.entStaLed.Text = "n/a";
            // 
            // lblSom
            // 
            this.lblSom.AutoSize = true;
            this.lblSom.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSom.Location = new System.Drawing.Point(200, 43);
            this.lblSom.Name = "lblSom";
            this.lblSom.Size = new System.Drawing.Size(35, 15);
            this.lblSom.TabIndex = 16;
            this.lblSom.Text = "Som:";
            // 
            // entSom
            // 
            this.entSom.AutoSize = true;
            this.entSom.Location = new System.Drawing.Point(240, 43);
            this.entSom.Name = "entSom";
            this.entSom.Size = new System.Drawing.Size(25, 15);
            this.entSom.TabIndex = 17;
            this.entSom.Text = "n/a";
            // 
            // lblStaSom
            // 
            this.lblStaSom.AutoSize = true;
            this.lblStaSom.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStaSom.Location = new System.Drawing.Point(200, 73);
            this.lblStaSom.Name = "lblStaSom";
            this.lblStaSom.Size = new System.Drawing.Size(73, 15);
            this.lblStaSom.TabIndex = 18;
            this.lblStaSom.Text = "Status Som:";
            // 
            // entStaSom
            // 
            this.entStaSom.AutoSize = true;
            this.entStaSom.Location = new System.Drawing.Point(275, 73);
            this.entStaSom.Name = "entStaSom";
            this.entStaSom.Size = new System.Drawing.Size(25, 15);
            this.entStaSom.TabIndex = 19;
            this.entStaSom.Text = "n/a";
            // 
            // btnStaSom
            // 
            this.btnStaSom.Location = new System.Drawing.Point(28, 340);
            this.btnStaSom.Name = "btnStaSom";
            this.btnStaSom.Size = new System.Drawing.Size(338, 23);
            this.btnStaSom.TabIndex = 20;
            this.btnStaSom.Text = "Status do Som";
            this.btnStaSom.UseVisualStyleBackColor = true;
            this.btnStaSom.Click += new System.EventHandler(this.btnStaSom_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 407);
            this.Controls.Add(this.btnStaSom);
            this.Controls.Add(this.entStaSom);
            this.Controls.Add(this.lblStaSom);
            this.Controls.Add(this.entSom);
            this.Controls.Add(this.lblSom);
            this.Controls.Add(this.entStaLed);
            this.Controls.Add(this.entLed);
            this.Controls.Add(this.lblStaLed);
            this.Controls.Add(this.lblLed);
            this.Controls.Add(this.btnDesAmbulancia);
            this.Controls.Add(this.btnPauAmbulancia);
            this.Controls.Add(this.btnLigAmbulancia);
            this.Controls.Add(this.btnStaLedAmarelo);
            this.Controls.Add(this.btnDesLedAmarelo);
            this.Controls.Add(this.btnLigLedAmarelo);
            this.Controls.Add(this.btnDesAlarme);
            this.Controls.Add(this.btnPauAlarme);
            this.Controls.Add(this.btnLigAlarme);
            this.Controls.Add(this.btnStaLedVerde);
            this.Controls.Add(this.btnDesLedVerde);
            this.Controls.Add(this.btnLigLedVerde);
            this.Name = "Form1";
            this.Text = "Controle Arduino Desktop C-SHARP v1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLigLedVerde;
        private System.Windows.Forms.Button btnDesLedVerde;
        private System.Windows.Forms.Button btnStaLedVerde;
        private System.Windows.Forms.Button btnLigAlarme;
        private System.Windows.Forms.Button btnPauAlarme;
        private System.Windows.Forms.Button btnDesAlarme;
        private System.Windows.Forms.Button btnLigLedAmarelo;
        private System.Windows.Forms.Button btnDesLedAmarelo;
        private System.Windows.Forms.Button btnStaLedAmarelo;
        private System.Windows.Forms.Button btnLigAmbulancia;
        private System.Windows.Forms.Button btnPauAmbulancia;
        private System.Windows.Forms.Button btnDesAmbulancia;
        private System.Windows.Forms.Label lblLed;
        private System.Windows.Forms.Label lblStaLed;
        private System.Windows.Forms.Label entLed;
        private System.Windows.Forms.Label entStaLed;
        private System.Windows.Forms.Label lblSom;
        private System.Windows.Forms.Label entSom;
        private System.Windows.Forms.Label lblStaSom;
        private System.Windows.Forms.Label entStaSom;
        private System.Windows.Forms.Button btnStaSom;
    }
}

