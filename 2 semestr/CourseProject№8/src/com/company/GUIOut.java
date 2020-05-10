package com.company;

import javax.swing.*;
import java.awt.*;
import java.awt.Color;
import javax.swing.JFrame;
import java.awt.event.*;

public class GUIOut extends JPanel {
    public void paintComponent(Graphics g, int[] coloring) {
        this.setBackground(Color.WHITE);
        g.setColor(Color.BLACK);
        g.drawLine(10, 20, 100, 50);
        g.setColor(Color.BLUE);
        g.fillOval(30, 30, 400, 400);
    }
}