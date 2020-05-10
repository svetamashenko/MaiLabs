package com.company;

import javafx.scene.control.Cell;

import java.awt.Component;
import java.awt.Container;
import java.awt.GridLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.ButtonGroup;
import javax.swing.JButton;
import javax.swing.JCheckBox;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JRadioButton;
import javax.swing.JTextField;

public class SimpleGUIwrong extends JFrame {
    private JButton button = new JButton("Press");
    private JLabel label = new JLabel("Input:");
    private JLabel label1 = new JLabel("");
    private JLabel label2 = new JLabel("");
    private JLabel label3 = new JLabel("");
    private JLabel label4 = new JLabel("");
    public static JCheckBox check1 = new JCheckBox("", false);
    public static JCheckBox check2 = new JCheckBox("", false);
    public static JCheckBox check3 = new JCheckBox("", false);
    public static JCheckBox check4 = new JCheckBox("", false);
    public static JCheckBox check5 = new JCheckBox("", false);
    public static JCheckBox check6 = new JCheckBox("", false);
    public static JCheckBox check7 = new JCheckBox("", false);
    public static JCheckBox check8 = new JCheckBox("", false);
    public static JCheckBox check9 = new JCheckBox("", false);
    public static JCheckBox check10 = new JCheckBox("", false);
    public static JCheckBox check11 = new JCheckBox("", false);
    public static JCheckBox check12 = new JCheckBox("", false);
    public static JCheckBox check13 = new JCheckBox("", false);
    public static JCheckBox check14 = new JCheckBox("", false);
    public static JCheckBox check15 = new JCheckBox("", false);
    public static JCheckBox check16 = new JCheckBox("", false);
    public static JCheckBox check17 = new JCheckBox("", false);
    public static JCheckBox check18 = new JCheckBox("", false);
    public static JCheckBox check19 = new JCheckBox("", false);
    public static JCheckBox check20 = new JCheckBox("", false);
    public static JCheckBox check21 = new JCheckBox("", false);
    public static JCheckBox check22 = new JCheckBox("", false);
    public static JCheckBox check23 = new JCheckBox("", false);
    public static JCheckBox check24 = new JCheckBox("", false);
    public static JCheckBox check25 = new JCheckBox("", false);
    private JRadioButton radio1 = new JRadioButton("хуйня");
    private JRadioButton radio2 = new JRadioButton("эта ваша дискретка");
    private JCheckBox check = new JCheckBox("Check:", false);

    public SimpleGUIwrong() {
        super("Раскраска вершин графа");
        this.setBounds(100, 100, 500, 5 * 75);
        this.setDefaultCloseOperation(3);
        Container container = this.getContentPane();
        container.setLayout(new GridLayout(5 + 2, 5, 1, 1));
        container.add(label);
        container.add(label1);
        container.add(label2);
        container.add(label3);
        container.add(label4);
        container.add(check1);
        container.add(check1);
        container.add(check2);
        container.add(check3);
        container.add(check4);
        container.add(check5);
        container.add(check6);
        container.add(check7);
        container.add(check8);
        container.add(check9);
        container.add(check10);
        container.add(check11);
        container.add(check12);
        container.add(check13);
        container.add(check14);
        container.add(check15);
        container.add(check16);
        container.add(check17);
        container.add(check18);
        container.add(check19);
        container.add(check20);
        container.add(check21);
        container.add(check22);
        container.add(check23);
        container.add(check24);
        container.add(check25);
        ButtonGroup group = new ButtonGroup();
        group.add(radio1);
        group.add(radio2);
        container.add(radio1);
        radio1.setSelected(true);
        container.add(radio2);
        button.addActionListener(new MatrixFilling());
        container.add(this.button);
    }
}

class MatrixFilling implements ActionListener {
    public void actionPerformed(ActionEvent e) {
        int[][] matrix = new int[5][5];
        matrix[0][0] = (SimpleGUI.check1.isSelected()) ? 1 : 0;
        matrix[0][1] = (SimpleGUI.check2.isSelected()) ? 1 : 0;
        matrix[0][2] = (SimpleGUI.check3.isSelected()) ? 1 : 0;
        matrix[0][3] = (SimpleGUI.check4.isSelected()) ? 1 : 0;
        matrix[0][4] = (SimpleGUI.check5.isSelected()) ? 1 : 0;
        matrix[1][0] = (SimpleGUI.check6.isSelected()) ? 1 : 0;
        matrix[1][1] = (SimpleGUI.check7.isSelected()) ? 1 : 0;
        matrix[1][2] = (SimpleGUI.check8.isSelected()) ? 1 : 0;
        matrix[1][3] = (SimpleGUI.check9.isSelected()) ? 1 : 0;
        matrix[1][4] = (SimpleGUI.check10.isSelected()) ? 1 : 0;
        matrix[2][0] = (SimpleGUI.check11.isSelected()) ? 1 : 0;
        matrix[2][1] = (SimpleGUI.check12.isSelected()) ? 1 : 0;
        matrix[2][2] = (SimpleGUI.check13.isSelected()) ? 1 : 0;
        matrix[2][3] = (SimpleGUI.check14.isSelected()) ? 1 : 0;
        matrix[2][4] = (SimpleGUI.check15.isSelected()) ? 1 : 0;
        matrix[3][0] = (SimpleGUI.check16.isSelected()) ? 1 : 0;
        matrix[3][1] = (SimpleGUI.check17.isSelected()) ? 1 : 0;
        matrix[3][2] = (SimpleGUI.check18.isSelected()) ? 1 : 0;
        matrix[3][3] = (SimpleGUI.check19.isSelected()) ? 1 : 0;
        matrix[3][4] = (SimpleGUI.check20.isSelected()) ? 1 : 0;
        matrix[4][0] = (SimpleGUI.check21.isSelected()) ? 1 : 0;
        matrix[4][1] = (SimpleGUI.check22.isSelected()) ? 1 : 0;
        matrix[4][2] = (SimpleGUI.check23.isSelected()) ? 1 : 0;
        matrix[4][3] = (SimpleGUI.check24.isSelected()) ? 1 : 0;
        matrix[4][4] = (SimpleGUI.check25.isSelected()) ? 1 : 0;
        coloring(matrix);

    }

    public void coloring(int[][] matrix) {
        int k = 1;
        double[] v = new double[5];
        for (int i = 0; i < 5; i++) {
            v[i] = 0;
        }
        for (int i = 0; i < 5; i++) {
            for (int j = 0; j < 5; j++) {
                if ((matrix[i][j] == 1) && (matrix[j][i] == 0)) {
                    v[i]++;
                }
                if ((matrix[i][j] == 1) && (matrix[j][i] == 1)) {
                    v[i] = v[i] + 0.5;
                }
            }
        }
        for (int i = 0; i < 5; i++) {
            for (int j = 0; j < 5; j++) {
                if ((matrix[i][i] == 1) && (matrix[j][j] == 0)) {
                    v[i]--;
                }
                if ((matrix[j][j] == 1) && (matrix[i][i] == 0)) {
                    v[i]--;
                }
                if ((matrix[j][j] == 1) && (matrix[i][i] == 1)) {
                    v[i] = v[i] - 0.5;
                }
            }
        }
        double x = 0;
        int[] coloring = new int[5];
        for (int i = 0; i < 5; i++) {
            if (v[i] > x) {
                x = v[i];
            }
        }
        int c = (int) x;
        switch (c) {
            case (4): {
                for (int i = 0; i < 5; i++)
                    for (int j = 0; j < 5; j++)
                        coloring[i] = j;
            }
            break;
            case (3): {
                int three = 0;
                for (int i = 0; i < 5; i++)
                    if (v[i] == 3)
                        three++;
                if (three == 4) {
                    int th = 0;
                    int[] thr = new int[5];
                    for (int i = 0; i < 5; i++) {
                        if (v[i] != 3) {
                            th = (int) v[i];
                            thr[i] = i + 5;
                        }
                    }
                    if (th == 0) {
                        for (int i = 0; i < 5; i++) {
                            for (int j = 0; j < 5; j++)
                                coloring[i] = j;
                            if (thr[i] == i + 5)
                                coloring[i] = 1;
                        }
                    }
                    if (th == 2) {
                        for (int i = 0; i < 5; i++)
                            for (int j = 0; j < 5; j++)
                                coloring[i] = j;
                    }
                } else if (three == 3) {
                    int[] th = new int[5];
                    int[] thr = new int[5];
                    for (int i = 0; i < 5; i++) {
                        if (v[i] != 3) {
                            th[i] = (int) v[i];
                            thr[i] = i + 5;
                        }
                    }
                    for (int i = 0; i < 5; i++) {
                        if (th[i] == 1){
                            for (int j = 0; j < 5; j++)
                                coloring[i] = j;}
                        if (thr[i] == 2)
                            coloring[i] = 1;

                    if (th[i] == 2)
                        for (int j = 0; j < 5; j++)
                            coloring[i] = j;
                    }
                } else if (three == 2) {

                } else if (three == 1) {

                }
            }
        }
    }
}
