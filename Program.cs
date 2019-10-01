using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_10
{
    class Program
    {
        static void Main()
        {
            int scelta;
            alunno alunno1 = new alunno();
            alunno alunno2 = new alunno();
            alunno alunno3 = new alunno();

            alunno1.Nome = "Alberto Bufalo";
            alunno2.Nome = "Claudio Dermatologo";
            alunno3.Nome = "Eusebio Ferrari";

            do
            {
                scelta = menu(alunno1, alunno2, alunno3);
                switch(scelta)
                {
                    case 1:
                        alunno1.voto();
                        break;

                    case 2:
                        alunno2.voto();
                        break;

                    case 3:
                        alunno3.voto();
                        break;

                }
            } while (scelta != 0);
        }

        static int menu(alunno alunno1, alunno alunno2, alunno alunno3)
        {
            int sc;
            if(alunno1.media == 0)
                Console.WriteLine("1. {0} Inserire voti - Media: non calcolata", alunno1.Nome);
            else
            Console.WriteLine("1. {0} Inserire voti - Media: {1}", alunno1.Nome, alunno1.Media());
            if (alunno2.media == 0)
                Console.WriteLine("1. {0} Inserire voti - Media: non calcolata", alunno2.Nome);
            else
                Console.WriteLine("2. {0} Inserire voti - Media: {1}", alunno2.Nome, alunno2.Media());
            if (alunno3.media == 0)
                Console.WriteLine("1. {0} Inserire voti - Media: non calcolata", alunno3.Nome);
            else
                Console.WriteLine("3. {0} Inserire voti - Media: {1}", alunno3.Nome, alunno3.Media());
            Console.WriteLine("0. Fine");
            sc = int.Parse(Console.ReadLine());
            return sc;
        }
    }
}
