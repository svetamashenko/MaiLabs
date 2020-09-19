using System;
using System.Linq;

namespace FirstTask
{
    public class Main
    {
        static void MainProgram(string[] args)
        {
            char answer = '0';
            ListOfMatrix ListMatr = new ListOfMatrix();
            while (answer != '7')
            {
                System.Console.WriteLine("Hello\nChoose need option:");
                System.Console.WriteLine("1. Enter matrix through console");
                System.Console.WriteLine("2. Enter matrix through file");
                System.Console.WriteLine("3. Print matrix through console");
                System.Console.WriteLine("4. Print info");
                System.Console.WriteLine("5. Print all matrix, with certain determinate");
                System.Console.WriteLine("6. Print sort list");
                System.Console.WriteLine("7. Exit");
                answer = (char)System.Console.Read();
                switch (answer)
                {
                    case '1':
                        {
                            if (Matrix.TryParse(Console.ReadLine(), out Matrix matr))
                            {
                                ListMatr.AppendToList(matr);
                            }
                            else
                            {
                                Console.WriteLine("Error");
                            }
                        }
                        break;
                    case '2':
                        {
                            Console.WriteLine("Please, enter a path:");
                            ListMatr = MatrixLnOut.EnterMatrix(Console.ReadLine());
                        }
                        break;
                    case '3':
                        {
                            ListMatr.MatrixPrint();
                            Console.WriteLine();
                        }
                        break;
                    case '4':
                        {
                            Console.WriteLine($"Min element:");
                            ListMatr.MinMatrix().MatrixPrint();
                            Console.WriteLine($"Max element:");
                            ListMatr.MaxMatrix().MatrixPrint();
                            Console.WriteLine($"First element:");
                            System.Console.WriteLine(ListMatr.FirstOfList());
                            Console.WriteLine($"Last element:");
                            System.Console.WriteLine(ListMatr.EndOfList());
                            Console.WriteLine($"Count of element:");
                            System.Console.WriteLine(ListMatr.ToArray().Length);
                        }
                        break;
                    case '5':
                        {
                            ListOfMatrix ListMatrTMP = ListMatr;
                            System.Console.WriteLine("Enter determinate:");
                            double determinate = Console.Read();
                            ListMatrTMP = (ListOfMatrix)ListMatrTMP.ToArray().Select(x => x.get_determinator() <= determinate);
                            ListMatrTMP.MatrixPrint();
                        }
                        break;
                    case '6':
                        {
                            ListOfMatrix ListMatrTMP = ListMatr;
                            ListMatrTMP = ListMatrTMP.SortList();
                            ListMatrTMP.MatrixPrint();
                        }
                        break;
                    case '7':
                        break;
                    default:
                        {
                            Console.WriteLine("Wrong number, please, try again");
                        }
                        break;
                }


            }
            System.Console.WriteLine("Goodbye!");
            System.Console.ReadKey();

        }

    }

}