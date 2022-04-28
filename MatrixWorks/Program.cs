
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixWorks
{
    class NewMatrix
    {
        private int[,,] matrix;
        private int rows;
        private int cols;
        private int sorindex;
        private int oszlopindex;
        private int minuszegydb = 0;
        private int ittvan;
        private string key;

        public NewMatrix()
        {
            Console.WriteLine("Add meg hány sora és oszlopa lesz a mátrixnak:");
            Console.WriteLine("Sorok száma:");
            rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Oszlopok száma:");
            cols = int.Parse(Console.ReadLine());
            this.matrix = new int[rows, cols, 2];
            this.sorindex = -1;
            this.oszlopindex = -1;
            this.key = "";
        }

        public void Fill()
        {
            bool folytat = true;

            while (folytat)
            {
                Console.WriteLine("Folytatod a beolvasást? (i/n)");
                key = Console.ReadLine();

                if (key == "n")
                {
                    folytat = false;
                    break;
                }
                if (key == "i")
                {
                    Console.WriteLine("Add meg a sorindexet:");
                    sorindex = int.Parse(Console.ReadLine());
                    Console.WriteLine("Add meg az oszlopindexet:");
                    oszlopindex = int.Parse(Console.ReadLine());

                    if (matrix[sorindex - 1, oszlopindex - 1, 1] != 0)
                    {
                        Console.WriteLine("A megadott helyen már szerepel érték");
                        continue;
                    }

                    Console.WriteLine("Add meg az értéket:");
                    matrix[sorindex - 1, oszlopindex - 1, 0] = int.Parse(Console.ReadLine());
                    matrix[sorindex - 1, oszlopindex - 1, 1] = 1;

                    if (matrix[sorindex - 1, oszlopindex - 1, 0] < 0)
                    {
                        Console.WriteLine("A megadott érték nem felel meg a beviteli feltételeknek, \naz abszolút értéke jelenik meg a tömbben.");
                        matrix[sorindex - 1, oszlopindex - 1, 0] = Math.Abs(matrix[sorindex - 1, oszlopindex - 1, 0]);
                    }
                }
            }
        }

        public void Count ()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j, 1] == 0)
                    {
                        minuszegydb++;
                    }
                }
            }
        }

        public void Screen()
        {
            Console.WriteLine("A megadott mátrix a következő:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write("{0} ", matrix[i, j, 0]);
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("A mátrixban {0} db elem nincs kitöltve.", minuszegydb);
            if (minuszegydb == 0)
            {
                Console.WriteLine("A mátrix betelt");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            NewMatrix nm = new NewMatrix();
            nm.Fill();
            nm.Count();
            nm.Screen();


            Console.ReadLine();
        }
    }
}

// Homestead II.