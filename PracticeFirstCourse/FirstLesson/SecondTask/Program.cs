using System;

namespace SecondTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int Key = 1;
            while (Key != 4)
            {
                Key = Menu();
                int lenght = 0;
                switch (Key)
                {
                    case 1:
                        Console.WriteLine(FindGuideNumber(GetArray()) + '.'); // Works also on unsorted arrays.
                        break;
                    case 2:
                        int[] New = FindMainIndexes(GetArray());
                        string s = "";
                        for (int i = 0; i < New.Length; i++)
                            s = s + ", " + New[i];
                        if (s == "")
                            System.Console.WriteLine("There is no Main Indexes.");
                        Console.WriteLine(s.Trim(',', ' ') + '.');
                        break;
                    case 3:
                        Console.WriteLine(FindVolume(GetArray()));
                        break;
                    case 4:
                        Console.WriteLine("Goodbye, User!");
                        break;
                    default:
                        Console.WriteLine("Error, try again.");
                        break;
                }
            }
        }
        public static int Menu()
        {
            int Key = 0;
            Console.WriteLine("Choose the action:");
            Console.WriteLine("1. Find Guide Number;");
            Console.WriteLine("2. Find Main Indexes;");
            Console.WriteLine("3. Find Volume;");
            Console.WriteLine("4. Exit.");
            if (int.TryParse(Console.ReadLine(), out int result))
                Key = result;
            else
            {
                Console.WriteLine("Error, enter the number.");
                Key = Menu();
            }
            return Key;
        }

        static public int[] GetArray()
        {
            int lenght = 0;
            Console.WriteLine("Enter the lenght of the array: ");
            if (int.TryParse(Console.ReadLine(), out int result))
                lenght = result;
            int[] array = new int[lenght];
            Console.WriteLine("Enter the elements of the array: ");
            for (int i = 0; i < lenght; i++)
                array[i] = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("\n");
            return array;
        }
        static public int FindGuideNumber(int[] list)
        {
            int[,] Help = new int[list.Length, 2];
            for (int i = 0; i < list.Length; i++)
            {
                for (int j = 0; j < list.Length; j++)
                {
                    if (list[i] == Help[j, 0])
                    {
                        Help[j, 1]++;
                        break;
                    }
                    else if (Help[j, 0] == 0)
                    {
                        Help[j, 0] = list[i];
                        Help[j, 1]++;
                        j = 0;
                        break;
                    }
                }
            }
            for (int i = 0; i < list.Length; i++)
            {
                if (Help[i, 1] > list.Length / 2)
                    return (Help[i, 0]);
            }
            return (-1);
        }
        static public int[] FindMainIndexes(int[] list)
        {
            int[] array = new int[0];
            int Left = 0, Right = 0;
            for (int i = 0; i < list.Length; i++)
            {
                for (int l = 0; l < i; l++)
                    Left = Left + list[l];
                for (int r = i + 1; r < list.Length; r++)
                    Right = Right + list[r];
                if (Left == Right)
                {
                    int[] NewArray = new int[array.Length + 1];
                    for (int k = 0; k < array.Length; k++)
                        NewArray[k] = array[k];
                    NewArray[array.Length] = i;
                    array = new int[array.Length + 1];
                    for (int j = 0; j < NewArray.Length; j++)
                        array[j] = NewArray[j];
                }
                Right = Left = 0;
            }
            return array;
        }
        public static int FindVolume(int[] list)
        {
            int First = -1, Second = -2, idFirst = -1, idSecond = -1;
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] > First)
                {
                    idSecond = idFirst;
                    idFirst = i;
                    Second = First;
                    First = list[i];
                }
                if (((list[i] < First) && (list[i] > Second) || ((idSecond < i) && (Second == list[i]) || ((list[i] == First) && (idFirst < i)))))
                {
                    idSecond = i;
                    Second = list[i];
                }
            }
            int pool = Second * (idSecond - idFirst - 1);
            System.Console.WriteLine(pool + " " + Second + " " + idFirst + " " + idSecond);
            for (int j = idFirst + 1; j < idSecond; j++)
                pool = pool - list[j];
            return pool;
        }
    }
}