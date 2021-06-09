package com.controlearduino.model;

// Classe modelo que representa as respostas vinda de uma requisição.

public class Buzzer {

	private String tipoSom;
	private String status;
	
	
	public String getTipoSom() {
		return tipoSom;
	}
	public void setTipoSom(String tipoSom) {
		this.tipoSom = tipoSom;
	}
	public String getStatus() {
		return status;
	}
	public void setStatus(String status) {
		this.status = status;
	}
	
	
	
}
