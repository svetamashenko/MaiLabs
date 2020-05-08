#!usr\bin\bash
CC = gcc
LD = gcc
CCFLAGS = -g -Wall -pedantic -std=c99
LDFLAGS = 
OBJ = menu.o concatenation/concatenation.o output/output.c push_pop/push_pop.o sort/sort.o
.SUFFIXES: .c .o 
menu: $(OBJ)
	$(LD) $(LDFLAGS) -o menu $(OBJ)
menu.o: menu.c concatenation/concatenation.h output/output.h push_pop/push_pop.h sort/sort.h
.c.o :
	$(CC) $(CCFLAGS) -c $< -o $@
concatenation/concatenation.c: concatenation/concatenation.h
output/output.c: output/output.h
push_pop/push_pop.c: push_pop/push_pop.h
sort/sort/c: sort/sort.h
clean:
	rm -f *.o prog
