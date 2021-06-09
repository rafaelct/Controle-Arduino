package com.controlearduino.utils;

import java.net.Socket;
import java.net.UnknownHostException;
import java.io.File;
import java.io.FileInputStream;
import java.io.InputStream;
import java.io.ObjectOutputStream;
import java.io.ObjectInputStream;
import java.io.IOException;
import java.io.OutputStream;
//import java.io.ClassNotFoundException;
import java.util.Vector;

import org.springframework.beans.factory.annotation.Value;
import org.springframework.stereotype.Component;

import java.util.Date;
import java.util.Properties;


public class Connect {

	private Socket socket;
	private OutputStream output;
	private InputStream input;
	
	private OutputStream out;
	private InputStream in;
	
	
	private String server;
	
	
	public Connect(String servidor) {
		
		
		this.server = servidor;
		
		
		//System.out.println("Connect a " + this.server);
	}
	

	public int open() {
		
		try{
		socket = new Socket(this.server,5000); // Cria uma conexão via socket tcp no host/ip na porta 5000.
		                                       // Na porta 5000 esta o microserviço em python que esta esperando comandos para repasar para o Arduino via conexão USB-Serial.
		
		output = socket.getOutputStream(); // Pega um canal para enviar os dados para o microserviço em python.
		input = socket.getInputStream(); // Pega um canal para receber os dados vinda do microserviço em python.
		
		
		}catch(IOException e) {
			//e.printStackTrace();
			return 1;
		}catch(Exception e) {
			return 2;
		}
		return 0;
		
	}

	// fecha a conexão
	public void close() throws IOException {
		
		output.close();
		input.close();
		socket.close();
		
		output = null;
		socket = null;
		input = null;
		
	}

	public String enviaDados(int cmd) {
		
		String resposta = "";
		
		try {
			
			// envia comando para o microserviço em python que faz a ponte de 
			// comunicação com o Arduino.
			output.write(cmd);
			output.flush();
			
			// Declarando um array de 3 bytes para receber a resposta do 
			// microserviço em python que a resposta vinda do arduino via 
			// codigo Serial.write.
			byte b[] = new byte[3];
			
			// resposta do servidor vem nesse formato:
			// b'OK '
			
			// pega os dois primeiros bytes vindos da resposta do servidor ( b' ) 
			// e não armazena em nenhuma variavel, pois não me interessa.
			
			input.read(); // pega o primeiro byte
			input.read(); // pega o segundo byte
			
			// Pega mais 3 bytes vindos da resposta do servidor ( OK e um espaço em branco )
			// e armazena cada byte em um vetor de bytes de 3 posições.
			
			b[0] = (byte) input.read(); // "O"
			b[1] = (byte) input.read(); // "K"
			b[2] = (byte) input.read(); // " "
			
			resposta = new String(b,"UTF-8"); // Converte os bytes para uma string em utf-8
			                                  // e armazena na variavel resposta.
			
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		
		return resposta.trim(); // retorno da resposta usando o trim() para eliminar os espaços em branco.
		
	}
		
}