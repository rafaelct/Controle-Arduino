import socket # importação do modulo para criarmos uma conexão TCP
import serial # importação do modulo para comunicarmos pela porta serial.

def server(host = 'localhost', port=5000): # Padrão localhost na porta 5000
    data_payload = 2048 # Tamanho maximo de dados que podem ser recebidos.
    # Criando um socket TCP
    sock = socket.socket(socket.AF_INET,  socket.SOCK_STREAM)
    # Habilitando reuso do endereço e porta
    sock.setsockopt(socket.SOL_SOCKET, socket.SO_REUSEADDR, 1)
    # Escuta do servidor na porta
    server_address = (host, port)
    
   
    print ("Iniciando escuta do servidor em %s  porta %s" % server_address)
    sock.bind(server_address)
    
    # Limite de conexões por vez.
    sock.listen(1) 
    i = 0
    
    ser = serial.Serial()
    ser.baudrate = 9600 # Velocidade de transmissão pela porta serial, deixe esse valor 9600 que também está configurado no código do Arduino.
    ser.port = "COM4" # Porta aonde o Arduino está conectado, mude caso seja diferente no seu caso.
    ser.open()

    while True: 
        
        print("Aguardando uma conexão de algum cliente...")
       
        client, address = sock.accept() 
        data = client.recv(data_payload) # recebendo os dados e armazenando na variavel dados.
        

        if data:
            print ("Data: %s" %data)

            tipoOperacao = data
            
            print("Tipo Operacao:"+ str(tipoOperacao) )
            
            ser.write(tipoOperacao) # enviando dados para o Arduino via serial.
            
            resp = b''
            
            i = 0
            
            while( i < 3 ): # faz 3 leituras dos dados vindos do Arduino.
                resp = resp + ser.read() # recebendo os dados vindos do Arduino pela serial.
                i = i + 1 # inclementa o contador de loop.
            
            print("Resposta recebida do Arduino: "+ str(resp) )
               
            resp = str(resp)
            #resp = resp.split("'")[1]
            
            print("enviando resposta para o java...");
            client.send(resp.encode('utf-8'))
            
            print("encerrando a conexão");
            client.close()
            
            #ser.close()
            

# inicio desse programa      
server()

