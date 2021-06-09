package com.controlearduino.controller;

/*
Classe responsavel por tratar as requisições http /buzzer

Aonde estiver net.enviaDados(<valor numerico>);
Esse comando envia o valor numerico para o microserviço em python na porta 5000
que faz a ponte de comunicação com o Arduino e envia esse valor numerico para 
ele via usb-serial. 
O Arduino intepreta esse valor e executa a ação solicitada e devolve uma resposta
para o microserviço que devolve aqui para esse objeto java.

Segue abaixo a descrição dos comandos que o programa executando no Arduino está 
preparado para receber, lembrando que essa classe só trata os controles 
referentes ao leds (comandos 1,2,3,4,8,9), para o buzzer veja a classe BuzzerController:

1 => Acente o led amarelo.
2 => Apaga o led amarelo.
3 => Acende o led verde.
4 => Apaga o led verde.
5 => Toca o som de alarme.
6 => Pausa o som de alarme.
7 => Desliga o som de alarme
8 => Devolve o status do led verde ( ON - ligado / OFF - desligado)
9 => Devolve o status do led amarelo ( ON - ligado / OFF - desligado)
10 => Toca o som de ambulancia.
11 => Pausa o som de ambulancia.
12 => Desliga o som de ambulancia.
13 => Devolve o status do buzzer.

*/
import java.io.IOException;

import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import com.controlearduino.model.Led;
import com.controlearduino.utils.Connect;


@RestController
@RequestMapping("/led")
public class LedController {

	
	private Connect net;
	
	public LedController() {
		 
			// Se conecta no microserviço em python que deve estar sendo executado 
			// aguardando conexões na porta 5000.
			net = new Connect("localhost"); 
			
		
	}
	
	// Exemplos de possiveis chamadas http para esse endpoint:
	
	// http://localhost:8080/led/status/verde
	// http://localhost:8080/led/status/amarelo
	
	// http://localhost:8080/led/ligar/verde
	// http://localhost:8080/led/desligar/verde
	
	// http://localhost:8080/led/ligar/amarelo
	// http://localhost:8080/led/desligar/amarelo
		
	
	@GetMapping("/{acaoLed}/{corLed}")
	public Led status( @PathVariable String corLed, @PathVariable String acaoLed) {
		
		 var led = new Led();
		 String resposta = "";
		 
		 net.open();
		 corLed = corLed.toLowerCase();
		 acaoLed = acaoLed.toLowerCase();
		 
		 if( corLed.equals("verde") && acaoLed.equals("status") ) {
			 led.setCor("Verde");
			 resposta = net.enviaDados(8);
		 }
			 
		 if( corLed.equals("amarelo") && acaoLed.equals("status") ) {
			 led.setCor("Amarelo");
			 resposta = net.enviaDados(9);
		 }
			 
		 if( corLed.equals("verde") && acaoLed.equals("ligar") ) {
			 led.setCor("Verde");
			 resposta = net.enviaDados(1);
		 }
			 
		 if( corLed.equals("verde") && acaoLed.equals("desligar") ) {
			 led.setCor("Verde");
			 resposta = net.enviaDados(2);
		 }
			 
		 if( corLed.equals("amarelo") && acaoLed.equals("ligar") ) {
			 led.setCor("Amarelo");
			 resposta = net.enviaDados(3);
		 }
			 
		 if( corLed.equals("amarelo") && acaoLed.equals("desligar") ) {
			 led.setCor("Amarelo");
			 resposta = net.enviaDados(4);
		 }
			 
		 
		 led.setStatusLed(resposta);
		 
		 try {
			 net.close();
		 } catch (IOException e) {
			 // TODO Auto-generated catch block
			 e.printStackTrace();
		 }

		 		 
		 	return led;
		 	
	}
	
}
