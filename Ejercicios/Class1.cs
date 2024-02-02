using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    public class Class1
    {
        public static void Main(string[] args)
        {
            Salario s = new Salario();
            double ig = new double();
            double eg = new double();
            double utilidad;
            int cp;

            do
            {
                cp = s.validar("Ingrese la cantidad de personas que desean conocer su utilidad: ");

            } while (cp <= 0 || cp > 10);

            for (int i = 0; i < cp; i++)
            {
                do
                {
                    ig = s.validar("Digite los ingresos de la persona [" + (i + 1) + "]:");
                    s.setIngreso(ig);
                } while (ig < 7000 || ig > 500000);

                do
                {
                    eg = s.validar("Digite los egresos de la persona [" + (i + 1 + "]:"));
                    s.setEgreso(eg);
                } while (eg < 0 || eg > ig);


                utilidad = ig - eg;
                Console.WriteLine("La utilidad es: " + utilidad);
            }


        }
    }
}
