package com.controlearduino.model;

// Classe modelo que representa as respostas vinda de uma requisição.

public class Led {

	private String cor = "";
	private String statusLed = "";
	
	
	public String getCor() {
		return cor;
	}

	public void setCor(String cor) {
		this.cor = cor;
	}

	public String getStatusLed() {
		return statusLed;
	}

	public void setStatusLed(String statusLed) {
		this.statusLed = statusLed;
	}
	
	
	
}
