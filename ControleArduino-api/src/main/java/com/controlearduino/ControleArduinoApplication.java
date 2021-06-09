package com.controlearduino;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;

import com.controlearduino.utils.Connect;

@SpringBootApplication
public class ControleArduinoApplication {

	public static void main(String[] args) {
		
		// Inicia a aplicação spring.
		SpringApplication.run(ControleArduinoApplication.class, args);
	}

}
