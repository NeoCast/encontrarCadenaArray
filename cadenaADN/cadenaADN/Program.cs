using System;

namespace cadenaADN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            char[,] arrayLetras = new char[6, 6] {
            {'A', 'T', 'G', 'C', 'G','A' },
            {'C', 'A', 'G', 'T', 'G','C' },
            {'T', 'T', 'A', 'T', 'G','T' },
            {'A', 'G', 'A', 'A', 'G','G' },
            {'C', 'C', 'C', 'C', 'A','A' },
            {'T', 'C', 'A', 'C', 'T','G' },
            };

            int[] arrInt = new int[4];
            int cont = 0;

            for (int i = 0; i < arrayLetras.GetLength(0); i++)
            {

                for (int j = 0; j < arrayLetras.GetLength(1); j++)
                {

                    cont +=  buscarDiagonalAbajoIzq(arrayLetras,j, i);
                    cont +=  buscarDiagonalAbajoDer(arrayLetras, j, i);
                    cont +=  bucarAbajo(arrayLetras, j, i);
                    cont +=  buscarDer(arrayLetras, j, i);
                }

            }
        }

        private static int buscarDer(char[,] arrayLetras, int j, int i)
        {
            int retorno = 0;

            if ( j + 3 > arrayLetras.GetLength(1))
                return retorno;


            if (arrayLetras[i , j + 1] == arrayLetras[i, j] && arrayLetras[i, j + 2] == arrayLetras[i, j] && arrayLetras[i, j + 3] == arrayLetras[i, j])
            {
                retorno++;
            }

            return retorno;
        }

        private static int bucarAbajo(char[,] arrayLetras, int j, int i)
        {
            int retorno = 0;
            if (i + 3 > arrayLetras.GetLength(0))
                return retorno;

            if (arrayLetras[i + 1, j] == arrayLetras[i, j] && arrayLetras[i + 2, j ] == arrayLetras[i, j] && arrayLetras[i + 3, j] == arrayLetras[i, j])
            {
                retorno++;
            }

            return retorno;

        }

        private static int buscarDiagonalAbajoDer(char[,] arrayLetras, int j, int i)
        {
            int retorno = 0;

            if ((i + 3 > arrayLetras.GetLength(0) || j + 3 > arrayLetras.GetLength(1)))
                return retorno;


            if (arrayLetras[i + 1, j + 1] == arrayLetras[i, j] && arrayLetras[i + 2, j + 2] == arrayLetras[i, j] && arrayLetras[i + 3, j + 3] == arrayLetras[i, j])
            {
                retorno++;
            }

            return retorno;
        }

        private static int buscarDiagonalAbajoIzq(char[,] arrayLetras, int j, int i)
        {
            
            int retorno = 0;

                if ((i + 3 > arrayLetras.GetLength(0) || j - 3 < 0))
                return retorno;


                if (arrayLetras[i + 1, j - 1] == arrayLetras[i, j] && arrayLetras[i + 2, j -2] == arrayLetras[i,j] && arrayLetras[i+3, j-3] == arrayLetras[i,j])
                {
                retorno++;
                }
                

            return retorno;
            
        }
    }
}
