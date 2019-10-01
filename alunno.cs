using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_10
{
    class alunno
    {
        private string nome;
        private int[] voti = new int[3];
        public float media;
        public int somma;

        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value;
            }
        }

        public void voto()
        {
            int cnt;

            for (cnt = 0; cnt < 3; cnt++)
            {
                do
                {
                    Console.WriteLine("Inserire {0} voto: ", cnt + 1);
                    voti[cnt] = int.Parse(Console.ReadLine());
                } while (voti[cnt] < 0 || voti[cnt] > 10);

                if(voti[cnt] < 0 || voti[cnt] > 10)
                {
                    Console.WriteLine("Il numero inserito non è valido!!");
                }
            }
            media = Somma() / 3;
        }

        private int Somma()
        {
            int cnt;

            for (cnt = 0; cnt < 3; cnt++)
            {
                somma = somma + voti[cnt];
            }
            return somma;
        }

        public float Media()
        {

            media = somma / 3;
            return media;
        }
    }
}
