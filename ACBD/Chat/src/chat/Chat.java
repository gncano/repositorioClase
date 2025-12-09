package chat;

import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.io.PrintWriter;
import java.net.ServerSocket;
import java.net.Socket;
import java.util.Scanner;

public class Chat {


    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        System.out.println("Elige entre servidor o clietne (s/c)");
        String opcion = sc.nextLine().trim().toLowerCase();

        if (opcion.equals("s")) {
            modoServidor();
        } else if (opcion.equals("c")) {
            modoCliente();
        } else {
            System.out.println("Opcion no valida.");
        }
    }

  
    public static void modoServidor() {
        try {
            Scanner sc = new Scanner(System.in);
            System.out.print("Introduce el puerto: ");
            int puerto = sc.nextInt();
            sc.nextLine(); 

            ServerSocket serverSocket = new ServerSocket(puerto);
            System.out.println("Servidor esperando conexion en el puerto " + puerto + "...");

            Socket socket = serverSocket.accept();
            System.out.println("Cliente conectado: " + socket.getInetAddress());

            manejarConexion(socket);

        } catch (Exception e) {
            System.out.println("Error en el servidor: " + e.getMessage());
        }
    }


    public static void modoCliente() {
        try {
            Scanner sc = new Scanner(System.in);

            System.out.print("Introduce la IP del servidor: ");
            String ip = sc.nextLine();

            System.out.print("Introduce el puerto: ");
            int puerto = sc.nextInt();
            sc.nextLine(); 

            Socket socket = new Socket(ip, puerto);
            System.out.println("Conectado al servidor.");

            manejarConexion(socket);

        } catch (Exception e) {
            System.out.println("Error en el cliente: " + e.getMessage());
        }
    }

 
    public static void manejarConexion(Socket socket) {
        try {
            BufferedReader entrada = new BufferedReader(new InputStreamReader(socket.getInputStream()));
            PrintWriter salida = new PrintWriter(socket.getOutputStream(), true);

            Scanner sc = new Scanner(System.in);

            
            Thread hiloRecibir = new Thread(() -> {
                try {
                    String msg;
                    while ((msg = entrada.readLine()) != null) {
                        System.out.println("\n[Mensaje recibido] " + msg);
                    }
                } catch (Exception e) {
                    System.out.println("Conexion cerrada.");
                }
            });

            hiloRecibir.setDaemon(true);
            hiloRecibir.start();

            // Bucle para enviar mensajes
            while (true) {
                System.out.print("Tu: ");
                String mensaje = sc.nextLine();
                salida.println(mensaje);
            }

        } catch (Exception e) {
            System.out.println("Error manejando la conexión: " + e.getMessage());
        }
    }
}

