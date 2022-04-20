
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixWorks
{
    class NewMatrix
    {
        private int[,] matrix = new int[10, 10];
        private int rows;
        private int cols;
        private int sorindex;
        private int oszlopindex;
        private int minuszegydb = 0;
        private string key;

        public NewMatrix(int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
            this.sorindex = sorindex;
            this.oszlopindex = oszlopindex;
            this.key = "a";
        }

        public NewMatrix()
        {
            this.rows = 0;
            this.cols = 0;
            this.sorindex = -1;
            this.oszlopindex = -1;
            this.key = "";
        }

        public void Fill()
        {
            bool folytat = true;
            Console.WriteLine("Add meg hány sora és oszlopa lesz a mátrixnak:");
            Console.WriteLine("Sorok száma:");
            rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Oszlopok száma:");
            cols = int.Parse(Console.ReadLine());

            /*
            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine("\n{0}. sor elemei:", i + 1);
                for (int j = 0; j < cols; j++)
                {
                    
                    
                    Console.WriteLine("{0} sor {1} elem", i + 1, j + 1);
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            */

            while (folytat = true)
            {
                Console.WriteLine("Folytatod a beolvasást? (i/n)");
                key = Console.ReadLine();
                /*f ((key != "i") || (key != "n"))
                {
                    Console.WriteLine("Érvénytelen");
                }*///
                if (key == "n")
                {
                    folytat = false;
                    break;
                }
                if (key == "i")
                {
                    Console.WriteLine("Add meg a sort:");
                    sorindex = int.Parse(Console.ReadLine());
                    Console.WriteLine("Add meg az oszlopot:");
                    oszlopindex = int.Parse(Console.ReadLine());

                    if (matrix[sorindex - 1, oszlopindex - 1] != 0)
                    {
                        Console.WriteLine("A megadott helyen már szerepel érték");
                        continue;
                    }

                    Console.WriteLine("Add meg az értéket:");
                    matrix[sorindex - 1, oszlopindex - 1] = int.Parse(Console.ReadLine());
                    if (matrix[sorindex - 1, oszlopindex - 1] < 0)
                    {
                        Console.WriteLine("A megadott érték nem felel meg a beviteli feltételeknek, \naz abszolút értéke jelenik meg a tömbben.");
                        matrix[sorindex - 1, oszlopindex - 1] = Math.Abs(matrix[sorindex - 1, oszlopindex - 1]);
                    }
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        matrix[i, j] = -1;
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
                    Console.Write("{0} ", matrix[i, j]);
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
            nm.Screen();


            Console.ReadLine();
        }
    }
}

// Homestead II.