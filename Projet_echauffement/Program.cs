using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_echauffement
{
    class Program
    {

        #region
        private static char[] operateur = {'+','-','*','/'};
        private static int operateur1 = 19;
        private static int operateur2 = 1;
        private static float reponce = 0;
        private static int i = 0;
        #endregion

        /// <summary>
        /// Affiche le calcul  et la réponce
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            for (i = 0; i < 4; i++) {
                //pour ecrire qqch
                Console.Write("Ecrivez votre calcul: " + operateur1 + operateur[i] + operateur2 + "\n");
                reponce = Calcul(operateur1,operateur2);
                Console.Write(reponce + "\n");
            }
            

            //arrete le defilement
            Console.Read();
        }


        private static float Calcul(float op1, float op2)
        {

            switch (i)
            {
                case 0:

                return op1 + op2;

                case 1:
                return op1 - op2;

                case 2:
                return op1 * op2;

                case 3:
                if ((op1 == 0) || (op2 == 0))
                {
                        return 12345;
                }

                return op1 / op2;

                default:
                return 1234;
            }

        }
    }
}
