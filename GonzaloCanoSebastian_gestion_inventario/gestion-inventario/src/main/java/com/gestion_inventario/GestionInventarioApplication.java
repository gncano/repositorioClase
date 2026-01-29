package com.gestion_inventario;


import com.gestion_inventario.ui.VentanaPrincipal;
import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.context.ConfigurableApplicationContext;

import javax.swing.*;

@SpringBootApplication
public class GestionInventarioApplication {

    public static void main(String[] args) {
        System.out.println("Headless mode? " + java.awt.GraphicsEnvironment.isHeadless());
        ConfigurableApplicationContext contexto = SpringApplication.run(GestionInventarioApplication.class, args);


        SwingUtilities.invokeLater(() -> {
            VentanaPrincipal ventanaPrincipal = contexto.getBean(VentanaPrincipal.class);
            ventanaPrincipal.setVisible(true);
        });

    }

}
