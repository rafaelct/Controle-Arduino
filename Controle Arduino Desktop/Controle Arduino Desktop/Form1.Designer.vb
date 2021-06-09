<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnLigLedVerde = New System.Windows.Forms.Button()
        Me.btnDesLedVerde = New System.Windows.Forms.Button()
        Me.btnLigLedAmarelo = New System.Windows.Forms.Button()
        Me.btnDesLedAmarelo = New System.Windows.Forms.Button()
        Me.btnStaLedVerde = New System.Windows.Forms.Button()
        Me.btnStaLedAmarelo = New System.Windows.Forms.Button()
        Me.btnLigSomAlarme = New System.Windows.Forms.Button()
        Me.btnPauSomAlarme = New System.Windows.Forms.Button()
        Me.btnDesSomAlarme = New System.Windows.Forms.Button()
        Me.btnLigSomAmbulancia = New System.Windows.Forms.Button()
        Me.btnPauSomAmbulancia = New System.Windows.Forms.Button()
        Me.btnDesSomAmbulancia = New System.Windows.Forms.Button()
        Me.btnStatusSom = New System.Windows.Forms.Button()
        Me.lblLed = New System.Windows.Forms.Label()
        Me.entLed = New System.Windows.Forms.Label()
        Me.lblStaLed = New System.Windows.Forms.Label()
        Me.entStaLed = New System.Windows.Forms.Label()
        Me.lblSom = New System.Windows.Forms.Label()
        Me.entSom = New System.Windows.Forms.Label()
        Me.lblStaSom = New System.Windows.Forms.Label()
        Me.entStaSom = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnLigLedVerde
        '
        Me.btnLigLedVerde.Location = New System.Drawing.Point(23, 142)
        Me.btnLigLedVerde.Name = "btnLigLedVerde"
        Me.btnLigLedVerde.Size = New System.Drawing.Size(140, 23)
        Me.btnLigLedVerde.TabIndex = 0
        Me.btnLigLedVerde.Text = "Ligar Led Verde"
        Me.btnLigLedVerde.UseVisualStyleBackColor = True
        '
        'btnDesLedVerde
        '
        Me.btnDesLedVerde.Location = New System.Drawing.Point(23, 171)
        Me.btnDesLedVerde.Name = "btnDesLedVerde"
        Me.btnDesLedVerde.Size = New System.Drawing.Size(140, 23)
        Me.btnDesLedVerde.TabIndex = 1
        Me.btnDesLedVerde.Text = "Desligar Led Verde"
        Me.btnDesLedVerde.UseVisualStyleBackColor = True
        '
        'btnLigLedAmarelo
        '
        Me.btnLigLedAmarelo.Location = New System.Drawing.Point(180, 142)
        Me.btnLigLedAmarelo.Name = "btnLigLedAmarelo"
        Me.btnLigLedAmarelo.Size = New System.Drawing.Size(169, 23)
        Me.btnLigLedAmarelo.TabIndex = 2
        Me.btnLigLedAmarelo.Text = "Ligar Led Amarelo"
        Me.btnLigLedAmarelo.UseVisualStyleBackColor = True
        '
        'btnDesLedAmarelo
        '
        Me.btnDesLedAmarelo.Location = New System.Drawing.Point(180, 171)
        Me.btnDesLedAmarelo.Name = "btnDesLedAmarelo"
        Me.btnDesLedAmarelo.Size = New System.Drawing.Size(169, 23)
        Me.btnDesLedAmarelo.TabIndex = 3
        Me.btnDesLedAmarelo.Text = "Desligar Led Amarelo"
        Me.btnDesLedAmarelo.UseVisualStyleBackColor = True
        '
        'btnStaLedVerde
        '
        Me.btnStaLedVerde.Location = New System.Drawing.Point(23, 200)
        Me.btnStaLedVerde.Name = "btnStaLedVerde"
        Me.btnStaLedVerde.Size = New System.Drawing.Size(140, 23)
        Me.btnStaLedVerde.TabIndex = 4
        Me.btnStaLedVerde.Text = "Status Led Verde"
        Me.btnStaLedVerde.UseVisualStyleBackColor = True
        '
        'btnStaLedAmarelo
        '
        Me.btnStaLedAmarelo.Location = New System.Drawing.Point(180, 200)
        Me.btnStaLedAmarelo.Name = "btnStaLedAmarelo"
        Me.btnStaLedAmarelo.Size = New System.Drawing.Size(169, 23)
        Me.btnStaLedAmarelo.TabIndex = 5
        Me.btnStaLedAmarelo.Text = "Status Led Amarelo"
        Me.btnStaLedAmarelo.UseVisualStyleBackColor = True
        '
        'btnLigSomAlarme
        '
        Me.btnLigSomAlarme.Location = New System.Drawing.Point(23, 286)
        Me.btnLigSomAlarme.Name = "btnLigSomAlarme"
        Me.btnLigSomAlarme.Size = New System.Drawing.Size(140, 23)
        Me.btnLigSomAlarme.TabIndex = 6
        Me.btnLigSomAlarme.Text = "Tocar Som Alarme"
        Me.btnLigSomAlarme.UseVisualStyleBackColor = True
        '
        'btnPauSomAlarme
        '
        Me.btnPauSomAlarme.Location = New System.Drawing.Point(23, 318)
        Me.btnPauSomAlarme.Name = "btnPauSomAlarme"
        Me.btnPauSomAlarme.Size = New System.Drawing.Size(140, 23)
        Me.btnPauSomAlarme.TabIndex = 7
        Me.btnPauSomAlarme.Text = "Pausar Som Alarme"
        Me.btnPauSomAlarme.UseVisualStyleBackColor = True
        '
        'btnDesSomAlarme
        '
        Me.btnDesSomAlarme.Location = New System.Drawing.Point(23, 347)
        Me.btnDesSomAlarme.Name = "btnDesSomAlarme"
        Me.btnDesSomAlarme.Size = New System.Drawing.Size(140, 23)
        Me.btnDesSomAlarme.TabIndex = 8
        Me.btnDesSomAlarme.Text = "Desligar Som Alarme"
        Me.btnDesSomAlarme.UseVisualStyleBackColor = True
        '
        'btnLigSomAmbulancia
        '
        Me.btnLigSomAmbulancia.Location = New System.Drawing.Point(180, 286)
        Me.btnLigSomAmbulancia.Name = "btnLigSomAmbulancia"
        Me.btnLigSomAmbulancia.Size = New System.Drawing.Size(169, 23)
        Me.btnLigSomAmbulancia.TabIndex = 9
        Me.btnLigSomAmbulancia.Text = "Tocar Som Ambulancia"
        Me.btnLigSomAmbulancia.UseVisualStyleBackColor = True
        '
        'btnPauSomAmbulancia
        '
        Me.btnPauSomAmbulancia.Location = New System.Drawing.Point(180, 318)
        Me.btnPauSomAmbulancia.Name = "btnPauSomAmbulancia"
        Me.btnPauSomAmbulancia.Size = New System.Drawing.Size(169, 23)
        Me.btnPauSomAmbulancia.TabIndex = 10
        Me.btnPauSomAmbulancia.Text = "Pausar Som Ambulancia"
        Me.btnPauSomAmbulancia.UseVisualStyleBackColor = True
        '
        'btnDesSomAmbulancia
        '
        Me.btnDesSomAmbulancia.Location = New System.Drawing.Point(180, 347)
        Me.btnDesSomAmbulancia.Name = "btnDesSomAmbulancia"
        Me.btnDesSomAmbulancia.Size = New System.Drawing.Size(169, 23)
        Me.btnDesSomAmbulancia.TabIndex = 11
        Me.btnDesSomAmbulancia.Text = "Desligar Som Ambulancia"
        Me.btnDesSomAmbulancia.UseVisualStyleBackColor = True
        '
        'btnStatusSom
        '
        Me.btnStatusSom.Location = New System.Drawing.Point(23, 376)
        Me.btnStatusSom.Name = "btnStatusSom"
        Me.btnStatusSom.Size = New System.Drawing.Size(326, 23)
        Me.btnStatusSom.TabIndex = 12
        Me.btnStatusSom.Text = "Status do Som"
        Me.btnStatusSom.UseVisualStyleBackColor = True
        '
        'lblLed
        '
        Me.lblLed.AutoSize = True
        Me.lblLed.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblLed.Location = New System.Drawing.Point(23, 66)
        Me.lblLed.Name = "lblLed"
        Me.lblLed.Size = New System.Drawing.Size(30, 15)
        Me.lblLed.TabIndex = 13
        Me.lblLed.Text = "Led:"
        '
        'entLed
        '
        Me.entLed.AutoSize = True
        Me.entLed.Location = New System.Drawing.Point(58, 66)
        Me.entLed.Name = "entLed"
        Me.entLed.Size = New System.Drawing.Size(25, 15)
        Me.entLed.TabIndex = 14
        Me.entLed.Text = "n/a"
        '
        'lblStaLed
        '
        Me.lblStaLed.AutoSize = True
        Me.lblStaLed.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblStaLed.Location = New System.Drawing.Point(23, 91)
        Me.lblStaLed.Name = "lblStaLed"
        Me.lblStaLed.Size = New System.Drawing.Size(68, 15)
        Me.lblStaLed.TabIndex = 15
        Me.lblStaLed.Text = "Status Led:"
        '
        'entStaLed
        '
        Me.entStaLed.AutoSize = True
        Me.entStaLed.Location = New System.Drawing.Point(93, 91)
        Me.entStaLed.Name = "entStaLed"
        Me.entStaLed.Size = New System.Drawing.Size(25, 15)
        Me.entStaLed.TabIndex = 16
        Me.entStaLed.Text = "n/a"
        '
        'lblSom
        '
        Me.lblSom.AutoSize = True
        Me.lblSom.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblSom.Location = New System.Drawing.Point(180, 66)
        Me.lblSom.Name = "lblSom"
        Me.lblSom.Size = New System.Drawing.Size(35, 15)
        Me.lblSom.TabIndex = 17
        Me.lblSom.Text = "Som:"
        '
        'entSom
        '
        Me.entSom.AutoSize = True
        Me.entSom.Location = New System.Drawing.Point(215, 66)
        Me.entSom.Name = "entSom"
        Me.entSom.Size = New System.Drawing.Size(25, 15)
        Me.entSom.TabIndex = 18
        Me.entSom.Text = "n/a"
        '
        'lblStaSom
        '
        Me.lblStaSom.AutoSize = True
        Me.lblStaSom.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblStaSom.Location = New System.Drawing.Point(180, 91)
        Me.lblStaSom.Name = "lblStaSom"
        Me.lblStaSom.Size = New System.Drawing.Size(73, 15)
        Me.lblStaSom.TabIndex = 19
        Me.lblStaSom.Text = "Status Som:"
        '
        'entStaSom
        '
        Me.entStaSom.AutoSize = True
        Me.entStaSom.Location = New System.Drawing.Point(255, 91)
        Me.entStaSom.Name = "entStaSom"
        Me.entStaSom.Size = New System.Drawing.Size(25, 15)
        Me.entStaSom.TabIndex = 20
        Me.entStaSom.Text = "n/a"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(388, 450)
        Me.Controls.Add(Me.entStaSom)
        Me.Controls.Add(Me.lblStaSom)
        Me.Controls.Add(Me.entSom)
        Me.Controls.Add(Me.lblSom)
        Me.Controls.Add(Me.entStaLed)
        Me.Controls.Add(Me.lblStaLed)
        Me.Controls.Add(Me.entLed)
        Me.Controls.Add(Me.lblLed)
        Me.Controls.Add(Me.btnStatusSom)
        Me.Controls.Add(Me.btnDesSomAmbulancia)
        Me.Controls.Add(Me.btnPauSomAmbulancia)
        Me.Controls.Add(Me.btnLigSomAmbulancia)
        Me.Controls.Add(Me.btnDesSomAlarme)
        Me.Controls.Add(Me.btnPauSomAlarme)
        Me.Controls.Add(Me.btnLigSomAlarme)
        Me.Controls.Add(Me.btnStaLedAmarelo)
        Me.Controls.Add(Me.btnStaLedVerde)
        Me.Controls.Add(Me.btnDesLedAmarelo)
        Me.Controls.Add(Me.btnLigLedAmarelo)
        Me.Controls.Add(Me.btnDesLedVerde)
        Me.Controls.Add(Me.btnLigLedVerde)
        Me.Name = "Form1"
        Me.Text = "Controle Arduino Desktop v1.0"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLigLedVerde As Button
    Friend WithEvents btnDesLedVerde As Button
    Friend WithEvents btnLigLedAmarelo As Button
    Friend WithEvents btnDesLedAmarelo As Button
    Friend WithEvents btnStaLedVerde As Button
    Friend WithEvents btnStaLedAmarelo As Button
    Friend WithEvents btnLigSomAlarme As Button
    Friend WithEvents btnPauSomAlarme As Button
    Friend WithEvents btnDesSomAlarme As Button
    Friend WithEvents btnLigSomAmbulancia As Button
    Friend WithEvents btnPauSomAmbulancia As Button
    Friend WithEvents btnDesSomAmbulancia As Button
    Friend WithEvents btnStatusSom As Button
    Friend WithEvents lblLed As Label
    Friend WithEvents entLed As Label
    Friend WithEvents lblStaLed As Label
    Friend WithEvents entStaLed As Label
    Friend WithEvents lblSom As Label
    Friend WithEvents entSom As Label
    Friend WithEvents lblStaSom As Label
    Friend WithEvents entStaSom As Label
End Class
