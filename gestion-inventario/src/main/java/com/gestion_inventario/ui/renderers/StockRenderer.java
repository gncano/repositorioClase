package com.gestion_inventario.ui.renderers;

import javax.swing.table.DefaultTableCellRenderer;
import java.awt.Color;
import java.awt.Component;
import javax.swing.JTable;

public class StockRenderer extends DefaultTableCellRenderer {
    @Override
    public Component getTableCellRendererComponent(JTable table, Object value, boolean isSelected, boolean hasFocus, int row, int column) {

        Component c = super.getTableCellRendererComponent(table, value, isSelected, hasFocus, row, column);

        int stockActual = Integer.parseInt(table.getValueAt(row, 4).toString());
        int stockMinimo = Integer.parseInt(table.getValueAt(row, 5).toString());

        if (!isSelected) {
            if (stockActual <= stockMinimo) {
                c.setBackground(new Color(255, 180, 180));
            } else {
                c.setBackground(Color.WHITE);
            }
        }
        return c;
    }
}
