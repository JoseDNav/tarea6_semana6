using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;
using prueba2.models;

namespace prueba2.viewmodels
{
    internal class vienmodelCalculadora : INotifyPropertyChanged
    {
        public vienmodelCalculadora()
        {

            sumar = new Command(() =>
            {

                calculadora c = new calculadora() { 
                    numero = this.numero1,
                    numero2 = this.numero2

                    
                };

                int numero3 = c.sumar();
                Resultado = numero3.ToString();


               

            });

            restar = new Command(() =>
            {
                calculadora c = new calculadora()
                {
                    numero = this.numero1,
                    numero2 = this.numero2
                };

                int numero3 = c.restar();
                Resultado = numero3.ToString();
            });

            multiplicar = new Command(() =>
            {
                calculadora c = new calculadora()
                {
                    numero = this.numero1,
                    numero2 = this.numero2
                };

                int numero3 = c.multiplicar();
                Resultado = numero3.ToString();
            });

            dividir = new Command(() =>
            {
                calculadora c = new calculadora()
                {
                    numero = this.numero1,
                    numero2 = this.numero2
                };

                int numero3 = c.dividir();
                Resultado = numero3.ToString();
            });


        }

        string resultado;
        public string Resultado {

            get => resultado;
            set
            {
                resultado = value;
                var args = new PropertyChangedEventArgs(nameof(Resultado));
                PropertyChanged?.Invoke(this, args);

            }

        }


        int numero1;

        public int Numero1
        {
            get => numero1;
            set
            {
                numero1 = value;
                var args = new PropertyChangedEventArgs(nameof(Numero1));
                PropertyChanged?.Invoke(this, args);
               
            }
        }

        int numero2;

        public int Numero2
        {
            get => numero2;
            set
            {
                numero2 = value;
                var args = new PropertyChangedEventArgs(nameof(Numero2));
                PropertyChanged?.Invoke(this, args);

            }
        }
        
        public Command sumar { get; }

        public Command restar { get; }

        public Command multiplicar { get; }

        public Command dividir { get; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
