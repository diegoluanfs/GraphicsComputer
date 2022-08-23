using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsComputer
{
    public class Vetores
    {
        public int[] CriarVetor2D()
        {
            int[] vetor2D = new int[2];
            for(int i = 0; i < 2; i++)
            {
                vetor2D[i] = i;
            }
            return vetor2D;
        }
        public int[] CriarVetor3D()
        {
            int[] vetor3D = new int[3];
            for(int i = 0; i < 3; i++)
            {
                vetor3D[i] = i;
            }
            return vetor3D;
        }
        public static void MostrarVetor(int[] vetorResp)
        {
            for(int i = 0; i < vetorResp.Length; i++)
            {
                Console.WriteLine("[" + vetorResp[i] + "]");
            }
        }
    }
}
