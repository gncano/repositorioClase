package com.gestion_inventario;

import com.gestion_inventario.servicios.ProductoServicio;
import com.gestion_inventario.ui.VentanaPrincipal;
import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.context.ApplicationContext;

@SpringBootApplication
public class GestionInventarioApplication {

    public static void main(String[] args) {
        System.out.println("Headless mode? " + java.awt.GraphicsEnvironment.isHeadless());
        ApplicationContext contexto = SpringApplication.run(GestionInventarioApplication.class, args);
        ProductoServicio productoServicio =contexto.getBean(ProductoServicio.class);
        VentanaPrincipal ventanaPrincipal = new VentanaPrincipal(productoServicio);
        ventanaPrincipal.setVisible(true);

    }

}
