using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsComputer
{
    public class Matrizes
    {
        public static int[,] CriarMatriz2D()
        {
            int[,] matriz2D = new int[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    matriz2D[i, j] = i+j;
                }
            }
            return matriz2D;
        }
        public static int[,] CriarMatriz3D()
        {
            int[,] matriz3D = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matriz3D[i, j] = i+j;
                }
            }
            return matriz3D;
        }
    }
}
