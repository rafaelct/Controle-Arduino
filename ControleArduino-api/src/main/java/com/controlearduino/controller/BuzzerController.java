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
 referentes aos buzzer (comandos 5,6,7,10,11,12,13), para os leds veja a classe LedController:
 
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


import org.springframework.http.HttpStatus;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.ResponseStatus;
import org.springframework.web.bind.annotation.RestController;

import com.controlearduino.model.Buzzer;
import com.controlearduino.utils.Connect;



@RestController
@RequestMapping("/buzzer")
public class BuzzerController {

	
	private Connect net;
	
	public BuzzerController() {
		 
			// Se conecta no microserviço em python que deve estar sendo executado 
			// aguardando conexões na porta 5000.
			net = new Connect("localhost");
			
		
	}
	
	// Exemplo de possivel chamada http para esse endpoint:
	
	// http://localhost:8080/buzzer/status

	@GetMapping("/status")
	public Buzzer status() {
		
		 var buzzer = new Buzzer();
		 String resposta = "";
		 
		 net.open();
		 
		 resposta = net.enviaDados(13);
		 
		 String respSom = resposta.substring(0,2);
		 String respStatus = resposta.substring(2,3);

		 if( respSom.equals("al") ) buzzer.setTipoSom("Alarme");
		 if( respSom.equals("am") ) buzzer.setTipoSom("Ambulancia");
		 if( respSom.equals("ns") ) buzzer.setTipoSom("Nenhum");

		 if( respStatus.equals("l") ) buzzer.setStatus("Ligado");
		 if( respStatus.equals("p") ) buzzer.setStatus("Pausado");
		 if( respStatus.equals("d") ) buzzer.setStatus("Desligado");

		 return buzzer;
		 
	}

	// Exemplos de possiveis chamadas http para esse endpoint:
	
	// http://localhost:8080/buzzer/tocar/alarme
	// http://localhost:8080/buzzer/pausar/alarme
	// http://localhost:8080/buzzer/desligar/alarme

	// http://localhost:8080/buzzer/tocar/ambulancia
	// http://localhost:8080/buzzer/pausar/ambulancia
	// http://localhost:8080/buzzer/desligar/ambulancia
	
	// http://localhost:8080/led/pause/
	// http://localhost:8080/led/desligar/verde
	
	// http://localhost:8080/led/ligar/amarelo
	// http://localhost:8080/led/desligar/amarelo
		

	@GetMapping("/{acaoBuzzer}/{tipoSom}")
	public Buzzer acao( @PathVariable String tipoSom, @PathVariable String acaoBuzzer) {
		
		 var buzzer = new Buzzer();
		 String resposta = "";
		 
		 net.open();
		 tipoSom = tipoSom.toLowerCase();
		 acaoBuzzer = acaoBuzzer.toLowerCase();
		 
		 if( tipoSom.equals("alarme") && acaoBuzzer.equals("tocar") ) {
			 buzzer.setTipoSom("Alarme");
			 buzzer.setStatus("Tocando");
			 resposta = net.enviaDados(5);
		 }
			 
		 if( tipoSom.equals("alarme") && acaoBuzzer.equals("pausar") ) {
			 buzzer.setTipoSom("Alarme");
			 buzzer.setStatus("Pausado");
			 resposta = net.enviaDados(6);
		 }
			 
		 if( tipoSom.equals("alarme") && acaoBuzzer.equals("desligar") ) {
			 buzzer.setTipoSom("Alarme");
			 buzzer.setStatus("Desligado");
			 resposta = net.enviaDados(7);
		 }
		 
		 
		 if( tipoSom.equals("ambulancia") && acaoBuzzer.equals("tocar") ) {
			 buzzer.setTipoSom("Ambulancia");
			 buzzer.setStatus("Tocando");
			 resposta = net.enviaDados(10);
		 }
			 
		 if( tipoSom.equals("ambulancia") && acaoBuzzer.equals("pausar") ) {
			 buzzer.setTipoSom("Ambulancia");
			 buzzer.setStatus("Pausado");
			 resposta = net.enviaDados(11);
		 }
			 
		 if( tipoSom.equals("ambulancia") && acaoBuzzer.equals("desligar") ) {
			 buzzer.setTipoSom("Ambulancia");
			 buzzer.setStatus("Desligado");
			 resposta = net.enviaDados(12);
		 }
		 
		 
		 try {
			 net.close();
		 } catch (IOException e) {
			 // TODO Auto-generated catch block
			 e.printStackTrace();
		 }

		 		 
		 	return buzzer;
		 	
	}
	
	/*
	@PostMapping
	@ResponseStatus(HttpStatus.CREATED)
	public Buzzer acionar(@Valid @RequestBody Buzzer buzzer) {
		return clientesRepository.save(cliente);
	}
	*/
	
}
