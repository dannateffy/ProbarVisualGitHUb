using System;
using System.Collections.Generic;
using System.Text;

namespace ProbarVisualGitHUb
{
    public class Primo:IPrimo
    {
        public double Num1 { set; get; }


        public bool Pri()
        {
            int i, cd = 0;
            bool pri = true;

            for (i = 1; i <= Num1; i++)
            {
                if (Num1 % i == 0)
                {
                    cd++;
                }
                if (cd != 2)
                {
                    pri = false;

                }
                else
                {
                    pri = true;

                }
            }
            return pri;

        }

        public void NumPri()
        {
            if (Pri() == true)
            {
                Console.WriteLine("El numero "+ Num1+ " es primo");              
            }
            else
            {
                Console.WriteLine("El numero " + Num1 + " no es primo");
            }
        }
    }
}

