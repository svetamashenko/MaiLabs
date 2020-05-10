package com.company;

class Coloring {
    public static int[] coloring(int[][] matrix) {
        double[] v = new double[5];
        v = count_verts(matrix);
        double max_verts = 0;
        for (int i = 0; i < 5; i++) {
            if (v[i] > max_verts) {
                max_verts = v[i];
            }
        }
        int[] coloring = new int[5];
        switch ((int) max_verts) {
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
                    int j = 1;
                    for (int i = 0; i < 5; i++) {
                        if ((th[i] == 1) || (thr[i] == 2)) {
                            coloring[i] = 4;
                        }
                    }
                } else if (three == 2) {
                    int[] th = new int[5];
                    int[] thr = new int[5];
                    for (int i = 0; i < 5; i++) {
                        if (v[i] != 3) {
                            th[i] = (int) v[i];
                            thr[i] = i + 5;
                        }
                    }
                    int j = 1;
                    for (int i = 0; i < 5; i++) {
                        if (v[i] == 3) {
                            coloring[i] = j;
                            j++;
                        }
                    }
                    int vert0 = 0;
                    int vert1 = 0;
                    int vert2 = 0;
                    for (int i = 0; i < 5; i++) {
                        if (th[i] == 0)
                            vert0++;
                        if (th[i] == 1)
                            vert1++;
                        if (th[i] == 2)
                            vert2++;
                    }
                    if ((vert2 == 3)) {
                        for (int i = 0; i < 5; i++)
                            if (coloring[i] == 0) {
                                coloring[i] = j;
                                j++;
                            }
                    } else if ((vert2 == 1) && (vert1 == 2)) {
                        for (int i = 0; i < 5; i++)
                            if ((coloring[i] == 0) && (v[i] == 2)) {
                                coloring[i] = j;
                                j++;
                            } else if ((coloring[i] == 0) && (v[i] == 1)) {
                                coloring[i] = 4;
                            }
                    } else if ((vert2 == 2) && (vert0 == 1)) {
                        for (int i = 0; i < 5; i++)
                            if ((coloring[i] == 0) && (v[i] == 2)) {
                                coloring[i] = j;
                                j++;
                            } else if ((coloring[i] == 0) && (v[i] == 0)) {
                                coloring[i] = 5;
                            }
                    }
                } else if (three == 1) {
                    int[] th = new int[5];
                    int[] thr = new int[5];
                    for (int i = 0; i < 5; i++) {
                        if (v[i] != 3) {
                            th[i] = (int) v[i];
                            thr[i] = i + 5;
                        }
                    }
                    int j = 1;
                    int vert0 = 0;
                    int vert1 = 0;
                    int vert2 = 0;
                    for (int i = 0; i < 5; i++) {
                        if (th[i] == 0)
                            vert0++;
                        if (th[i] == 1)
                            vert1++;
                        if (th[i] == 2)
                            vert2++;
                    }
                    if ((vert0 == 1)) {
                        for (int i = 0; i < 4; i++) {
                            if ((coloring[i] == 0) && (v[i] != 0)) {
                                coloring[i] = j;
                                j++;
                            }
                            if ((coloring[i] == 0) && (v[i] == 0))
                                coloring[i] = 1;
                        }
                    } else if (((vert2 == 3) && (vert1 == 1)) || ((vert2 == 2) && (vert1 == 2))) {
                        int k = 0;
                        int l = 0;
                        for (int i = 0; i < 5; i++) {
                            if (v[i] == 1)
                                k = i;
                        }
                        for (int i = 0; i < 5; i++) {
                            if ((matrix[i][k] == 0) && (v[i] != 3))
                                l = i;
                        }
                        for (int i = 0; i < 5; i++) {
                            if ((coloring[i] == 0) && (v[i] != 1) && (i != l)) {
                                coloring[i] = j;
                                j++;
                            } else
                                coloring[i] = 4;
                        }
                    } else if ((vert2 == 1) && (vert1 == 3)) {
                        int k = 0;
                        int l = 0;
                        for (int i = 0; i < 5; i++) {
                            if (v[i] == 1)
                                k = i;
                        }
                        for (int i = 0; i < 5; i++) {
                            if ((matrix[i][k] == 0) && (v[i] == 1))
                                l = i;
                        }
                        for (int i = 0; i < 5; i++) {
                            if ((coloring[i] == 0) && (v[i] != 1) && (i != l)) {
                                coloring[i] = j;
                                j++;
                            } else
                                coloring[i] = 4;
                        }
                    }
                }

            }
            case (2): {
                int[] th = new int[5];
                int[] thr = new int[5];
                for (int i = 0; i < 5; i++) {
                    if (v[i] != 3) {
                        th[i] = (int) v[i];
                        thr[i] = i + 5;
                    }
                }
                int j = 1;
                int y = 1;
                int vert0 = 0;
                int vert1 = 0;
                int vert2 = 0;
                for (int i = 0; i < 5; i++) {
                    if (th[i] == 0)
                        vert0++;
                    if (th[i] == 1)
                        vert1++;
                    if (th[i] == 2)
                        vert2++;
                }
                if ((vert2 == 5)) {
                    for (int i = 0; i < 5; i++) {
                        coloring[i] = j;
                        j++;
                    }
                } else if ((vert1 == 0) && (vert0 > 0)) {
                    for (int i = 0; i < 5; i++) {
                        if (v[i] == 2) {
                            coloring[i] = j;
                            j++;
                        } else
                            coloring[i] = 1;
                    }
                } else if ((vert2 == 3) && (vert1 == 2)) {
                    int k = 0;
                    int l = 0;
                    for (int i = 0; i < 5; i++) {
                        if (v[i] == 1)
                            k = i;
                    }
                    for (int i = 0; i < 5; i++)
                        for (int u = 0; j < 5; j++) {
                            if ((matrix[i][k] == 0) && (matrix[i][k] == 1) && (matrix[k][u] == 0) && (v[i] == 2))
                                l = i;
                        }
                    for (int i = 0; i < 5; i++) {
                        if ((i != k) && (i != l) && (v[i] != 0)) {
                            coloring[i] = j;
                            j++;
                        } else if (v[i] == 0)
                            coloring[i] = 1;
                        else
                            coloring[i] = 4;
                    }
                } else if ((vert2 == 1) && (vert1 == 4)) {
                    int k = 0;
                    for (int i = 0; i < 5; i++) {
                        if (v[i] == 2)
                            k = i;
                    }
                    for (int i = 0; i < 5; i++) {
                        if ((matrix[i][k] == 1) || ((v[i]) == 2)) {
                            coloring[i] = j;
                            j++;
                        } else {
                            coloring[i] = y;
                            y++;
                        }
                    }
                } else if ((vert2 == 1) && (vert1 == 4)) {
                    int k = 0;
                    for (int i = 0; i < 5; i++) {
                        if (v[i] == 2)
                            k = i;
                    }
                    for (int i = 0; i < 5; i++) {
                        if ((matrix[i][k] == 1) || ((v[i]) == 2)) {
                            coloring[i] = j;
                            j++;
                        } else {
                            coloring[i] = 1;
                        }
                    }
                }
            }
            case (1): {
                int[] th = new int[5];
                int[] thr = new int[5];
                for (int i = 0; i < 5; i++) {
                    if (v[i] != 3) {
                        th[i] = (int) v[i];
                        thr[i] = i + 5;
                    }
                }
                int j = 1;
                int vert0 = 0;
                int vert1 = 0;
                for (int i = 0; i < 5; i++) {
                    if (th[i] == 0)
                        vert0++;
                    if (th[i] == 1)
                        vert1++;
                }
                if ((vert1 == 2) && (vert1 == 3)) {
                    int k = 0;
                    for (int i = 0; i < 5; i++) {
                        if (v[i] == 1)
                            k = i;
                    }
                    for (int i = 0; i < 5; i++) {
                        if ((matrix[i][k] == 1) || ((v[i]) == 1)) {
                            coloring[i] = j;
                            j++;
                        } else {
                            coloring[i] = 1;
                        }
                    }
                }
                if ((vert1 == 2) && (vert1 == 3)) {
                    int k = 0;
                    int b = 0;
                    for (int i = 0; i < 5; i++) {
                        if (v[i] == 1)
                            k = i;
                    }
                    for (int i = 0; i < 5; i++)
                        for (int u = 0; u < 5; u++) {
                            if ((v[i] == 1) && (i != k) && (matrix[k][u] == 0) && (matrix[i][k] == 0))
                                b = i;
                        }
                    for (int i = 0; i < 5; i++) {
                        if ((i == b)||(i==k)||v[i] ==0) {
                            coloring[i] = 1;
                        } else {
                            coloring[i] = 2;
                        }
                    }
                }
            }
            case (0): {
                for (int i = 0; i < 5; i++)
                    coloring[i] = 1;
            }

        }
        return (coloring);
    }

    public static double[] count_verts(int[][] matrix) {
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
        return (v);
    }
}
