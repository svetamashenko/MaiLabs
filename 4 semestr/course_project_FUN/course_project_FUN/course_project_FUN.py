from tkinter import *
import random
root = Tk();

canvas_width = 500 #i2
canvas_height= 500 #j1

C = [[1/3, 0, 0, 1/3, 0, 0], 
     [1/3, 0, 0, 1/3, 1/3, 0],
     [1/3, 0, 0, 1/3, 2/3, 2/3],
     [1/3, 0, 0, 1/3, 1/3, 2/3]]

C_transform = [[0, 0, 0, 0, 0, 0],
              [0, 0, 0, 0, 0, 0],
              [0, 0, 0, 0, 0, 0],
              [0, 0, 0, 0, 0, 0]]
i1 = 0;
j1 = canvas_height
i2 = canvas_width
j2 = 0
x1 = 0
x2 = 1
y1 = 0
y2 = 1

M_11 = (i2 - i1) / (x2 - x1)
M_22 = (j2 - j1)/(y2 - y1)
w1 = i1 - M_11 * x1
w2 = j1 - M_22 * y1

for i in range(len(C)):
    C_transform[i][0] = C[i][0]
    C_transform[i][1] = M_11*C[i][1]/M_22
    C_transform[i][2] = M_22*C[i][2]/M_11
    C_transform[i][3] = C[i][3]
    C_transform[i][4] = (1-C_transform[i][0])*w1 - C_transform[i][1]*w2 + M_11*C[i][4]
    C_transform[i][5] = -C_transform[i][2]*w1 + (1-C[i][3])*w2 + M_22*C[i][5]

canvas = Canvas(root, width=canvas_width, height=canvas_height)
canvas.pack()

x0 = 10
y0 = 10
x = 0
y = 0
k = 0

for j in range(10000):
    k = random.randint(0, 3)
    x=C_transform[k][0]*x0+C_transform[k][1]*y0 + C_transform[k][4]
    y=C_transform[k][2]*x0+C_transform[k][3]*y0 + C_transform[k][5]
    canvas.create_oval(x, y, x+0.05, y+0.05, fill="#0019d2")
    x0=x
    y0=y


root.mainloop()