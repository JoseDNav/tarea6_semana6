using System;
using System.Collections.Generic;
using System.Text;

namespace prueba2.models
{
    internal class calculadora
    {
        public int numero { get; set; }
        public int numero2 { get; set; }

       


        public int sumar()
        {
            int numero3;

            numero3 = numero + numero2;

            return numero3;
        }

        public int restar() {
            int numero3;

            numero3 = numero - numero2;
            
            
            return numero3;
        }

        public int multiplicar()
        {
            int numero3;

            numero3 = numero * numero2;


            return numero3;
        }

        public int dividir()
        {
            int numero3;

            numero3 = numero / numero2;


            return numero3;
        }


    }
}
