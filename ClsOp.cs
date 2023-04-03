using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    //creamos una clase llada operacion y le damos las variables necesarias para que funcione
    internal class ClsOp
    {
        private double Numero1;
        private double Numero2;
        private double Respuesta;
        private string Operador;

        public ClsOp()
        {
            Numero1= 0;
            Numero2= 0;
            Respuesta= 0;
        }
        

        public double Num1 { get => Numero1; set => Numero1 = value; }
        public double Num2 { get => Numero2; set => Numero2 = value; }
        public double RES { get => Respuesta; set => Respuesta = value; }

        //creamos una funcion la cual permita realizar las diferentes operaciones
        public void AccionOperar(string Operador)
        {
            this.Operador = Operador;
            if (Operador == "*")
            {
                RES = Num1 * Num2;
            }
            else if (Operador == "+")
            {
                RES = Num1 + Num2;
            }
            else if (Operador == "-")
            {
                RES = Num1 - Num2;
            }
            else if (Operador == "/")
            {
                RES = Num1 / Num2;
            }
            else if (Operador == "%")
            {
                RES = (Num1 * Num2) / 100;
            }
        }

       
    }
}
