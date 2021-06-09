/*
 * Controle Arduino via serial v1.0
 * Autor: Rafael Costa Teixeira ( 07/06/2021 )
 * Licença: GNU/GPL v3
 */

int ledVerde =  2; // atribui o pino digital 2 a variável ledVerde 
int ledAmarelo = 4; // atribui o pino digital 4 a variável ledAmarelo
int buzzer = 3; // atribui o pino digital 5 a variavel buzzer 
int cmd; // variável que receberá os comandos da porta serial
int freq = 0; // frequencia do som ( vai mudar conforme o tipo de som escolhido alarme ou ambulancia ( comandos 5 ou 10 )
int somup = 1; // controle do loop do som.
int alarme = 0; // controla quando esta tocando o som de alarme
int ambulancia = 0; // controla quando esta tocando o som de ambulancia
int pausar = 0; // controla quando o som esta pausado
int temposom = 0; // controla o tempo de cada uma das duas frequencias do som da ambulancia.
char statusSom[3]; // declara uma variavel de 3 posições para armazenar o status do som que sera retornado pela serial 
                    //  ( al = Alarme / am = Ambulancia ) 
                    // ( l = ligado / p = pausado / d = desligado // 
                    // Exemplo: aml = indica que o som da ambulancia esta ligada / alp = indica que o som de alarme esta pausado)
int pinoSensorLuz = A4; // atribui o pino analogico A4 a variavel pinoSensorLuz.
int valorLuz = 0; // Declara variavel que recebera a leitura do sensor Ldr (sensor de luminosidade)
int statusLdr = 1; // Declara variavel que controla se o sensor de ldr vai estar ativo ou não 
                  // ( desativado no momento que estiver executando os comandos 5,6,10,11 e ativado depois dos comandos 7,12)


void setup(){
  
  Serial.begin(9600); //frequência da porta serial
   pinMode(ledVerde,OUTPUT); //define o pino o ledVerde como saída
   pinMode(ledAmarelo,OUTPUT); //define o pino o ledAmarelo como saída
   pinMode(buzzer,OUTPUT); // define o pino do buzzer como saida.
   pinMode(pinoSensorLuz,INPUT); // define o pino do ldr como entrada
   
   statusSom[2] = 'd'; // atribui o  valor d (desligado) por padrão.
   
}

// inicia o loop infinito.

void loop(){


if( statusLdr == 1 ) {
  
  valorLuz = analogRead(pinoSensorLuz);
          
  if(valorLuz<400)
  {                
          alarme = 1;
          ambulancia = 0;
          pausar = 0;
          //freq = 0;
          statusSom[2] = 'l';

  }
  else
  {                    
          alarme = 0;
          ambulancia = 0;
          freq = 0;
          pausar = 0;
          tone(buzzer,0);
          noTone(buzzer);
          statusSom[2] = 'd';

  }

}
    tone(buzzer,freq);
    delay(10);  

  if( alarme == 1 && pausar == 0 ) {
    
  
    if( somup == 1 && alarme == 1 ) { 
      freq = freq + 40; 
    } 

    if( somup == 0 && alarme == 1 ) { 
      freq = freq - 40;
    }

    if( somup == 1 && freq > 1500 && alarme == 1 ) {
      somup = 0;
    }
    
    if( somup == 0 && freq < 0  && alarme == 1 ) {
      somup = 1;
    }
  
  }
  
  if( ambulancia == 1 && pausar == 0 ) {
    
  
    if( temposom == 0 ) { 
      freq = 2000; 
    } 

      temposom++;
      
    if( temposom > 100 ) {
      freq = 1500;
      //temposom = 0;
    }

    if( temposom > 200 ) {
      temposom = 0;
    }
    
  }
  
    if(Serial.available() > 0){ // verifica se existe comunicação com a porta serial


      cmd = Serial.read();// lê os dados da porta serial
     
      switch(cmd){
        case 1:
           digitalWrite(ledVerde,HIGH); //liga o pino ledVerde
           Serial.write("OK "); // escreve os dados na porta serial
        break;
        
        case 2:
           digitalWrite(ledVerde,LOW); //desliga o pino ledVerde
           Serial.write("OK "); // escreve os dados na porta serial
         break;
         
        case 3:
           digitalWrite(ledAmarelo,HIGH); //liga o pino ledAmarelo
           Serial.write("OK "); // escreve os dados na porta serial
         break;
         
        case 4:
           digitalWrite(ledAmarelo,LOW); //desliga o pino ledAmarelo
           Serial.write("OK "); // escreve os dados na porta serial
         break;
         
         case 5:
          Serial.write("OK "); // escreve os dados na porta serial
          statusLdr = 0;
          alarme = 1;
          ambulancia = 0;
          pausar = 0;
          freq = 0;
          statusSom[2] = 'l';
          break;
          
         case 6:
          statusLdr = 0;
          alarme = 1;
          ambulancia = 0;
          pausar = 1;
          statusSom[2] = 'p';
          Serial.write("OK "); // escreve os dados na porta serial
          break;
          
         case 7:
          statusLdr = 1;
          alarme = 0;
          ambulancia = 0;
          freq = 0;
          pausar = 0;
          tone(buzzer,0);
          noTone(buzzer);
          statusSom[2] = 'd';
          Serial.write("OK "); // escreve os dados na porta serial
          break;

         case 8:

          if( digitalRead(ledVerde) == LOW ) {
            Serial.write("OFF"); // escreve os dados na porta serial
          } else {
            Serial.write("ON "); // escreve os dados na porta serial
          }
          break;

         case 9:
         
          if( digitalRead(ledAmarelo) == LOW ) {
            Serial.write("OFF"); // escreve os dados na porta serial
          } else {
            Serial.write("ON "); // escreve os dados na porta serial
          }
          break;
          
         case 10:
         
          Serial.write("OK "); // escreve os dados na porta serial
          statusLdr = 0;
          statusSom[2] = 'l';
          alarme = 0;
          ambulancia = 1;
          pausar = 0;
          freq = 0;
          somup = 0;
          temposom = 0;
          break;
          
         case 11:

          statusLdr = 0;
          statusSom[2] = 'p';
          alarme = 0;
          ambulancia = 1;
          pausar =1;
          somup = 0;
          temposom = 0;
          Serial.write("OK "); // escreve os dados na porta serial
          break;
          
         case 12:
          statusLdr = 1;
          statusSom[2] = 'd';
          alarme = 0;
          ambulancia = 0;
          pausar = 0;
          freq = 0;
          somup = 0;
          temposom = 0;
          tone(buzzer,0);
          noTone(buzzer);
          Serial.write("OK "); // escreve os dados na porta serial
          break;

         case 13:
         
            if( alarme == 1 ) {
              statusSom[0] = 'a';
              statusSom[1] = 'l';
              Serial.write("al"); // // escreve os dados na porta serial
            }

            if( ambulancia == 1 ) {
              statusSom[0] = 'a';
              statusSom[1] = 'm';
              Serial.write("am"); // escreve os dados na porta serial
            }

            if( alarme == 0 && ambulancia == 0 ) {
              Serial.write("ns"); // escreve os dados na porta serial
            }
         
            if( statusSom[2] == 'l' ) {
              Serial.write("l"); // escreve os dados na porta serial
            }
          
            if( statusSom[2] == 'p' ) {
              Serial.write("p"); // escreve os dados na porta serial
            }
          
            if( statusSom[2] == 'd' ) {
              Serial.write("d"); // escreve os dados na porta serial
            } 
            break;

          default:
            Serial.write("nop"); // escreve os dados na porta serial
            break;
          
    } // fim do switch
    
  } // fim do if(Serial.available() > 0) 

} // fim da função void loop()
