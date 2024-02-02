using System;
using System.Text;

namespace ConsoleApp2
{

    public class Salario
    {
        
        double ingreso, egreso;

        public Salario() { 
        
        }

        public Salario(double ingreso) {
            this.ingreso = ingreso;
        }

        public void setIngreso(double ingreso)
        {
            this.ingreso = ingreso;
        }

        public void setEgreso(double egreso)
        {
            this.egreso = egreso;
        }

        public int validar(String Mensaje)
        {
            int num = 0, v;
            do
            {
                v = 1;
                try
                {
                    Console.WriteLine(Mensaje);
                    num = Convert.ToInt32(Console.ReadLine());
                }catch(Exception error) {
                    v = 0;
                    Console.WriteLine("No se aceptan letras ", error.Message);
                }
            }while(v == 0);
            return num;
        }



    }


}