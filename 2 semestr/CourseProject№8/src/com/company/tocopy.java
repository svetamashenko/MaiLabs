package com.company;
import java.util.Scanner;

public class tocopy {

    public static void main(String[] args) {
        System.out.print("Введите число вершин: ");
        Scanner number = new Scanner(System.in);
        int count = number.nextInt();
        System.out.println(count);
        System.out.print("Введите матрицу смежности:");
        int[][] matrix = new int[count][count];
        for (int i = 0; i < count; i++) {
            for (int j = 0; j < count; j++) {
                Scanner sc = new Scanner(System.in);
                matrix[i][j] = sc.nextInt();
            }
        }
        System.out.println(matrix[1][2]);
    }

    void func(String[] args) {

    }
}