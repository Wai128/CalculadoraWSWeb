using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

 
namespace WS_consola
{
    class Program
    {

       

        
        static void Main(string[] args)
        {

            int salir;

            do
            {

                WS_Consola1.CalculatorSoapClient WS_Consola = new WS_Consola1.CalculatorSoapClient();
                double numero1, numero2, resultado;
                int opcion;

                menu_pantalla();


                while (!Int32.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Error, seleccione la opcion correcta");
                }
                salto_linea();

                Console.WriteLine("Digite el Numero 1: ");

                //validadcion de digitos ingresados por el usaurio
                while (!double.TryParse(Console.ReadLine(), out numero1))
                {
                    Console.WriteLine("Error, no se permiten letras, por favor digite un numero entero");
                }

                salto_linea();

                Console.WriteLine("Digite el Numero 2: ");
                //validadcion de digitos ingresados por el usaurio
                while (!double.TryParse(Console.ReadLine(), out numero2))
                {
                    Console.WriteLine("Error, no se permiten letras, por favor digite un numero entero");
                }

                switch (opcion)
                {
                    case 1:
                        {
                            Console.Clear();
                            resultado = WS_Consola.Add(Convert.ToInt32(numero1), Convert.ToInt32(numero2));
                            Console.WriteLine("El resultado de " + numero1 + " + " + numero2 + " es:\t " + resultado + "\n");
                            Console.ReadKey();

                        }
                        break;

                    case 2:
                        {
                            Console.Clear();
                            resultado = WS_Consola.Subtract(Convert.ToInt32(numero1), Convert.ToInt32(numero2));
                            Console.WriteLine("El resultado de " + numero1 + " - " + numero2 + " es:\t " + resultado + "\n");
                            Console.ReadKey();

                        }
                        break;

                    case 3:
                        {
                            Console.Clear();
                            resultado = WS_Consola.Multiply(Convert.ToInt32(numero1), Convert.ToInt32(numero2));
                            Console.WriteLine("El resultado de " + numero1 + " * " + numero2 + " es:\t " + resultado + "\n");
                            Console.ReadKey();

                        }
                        break;

                    case 4:
                        {
                            Console.Clear();
                            resultado = WS_Consola.Divide(Convert.ToInt32(numero1), Convert.ToInt32(numero2));
                            Console.WriteLine("El resultado de " + numero1 + " / " + numero2 + " es:\t " + resultado + "\n");
                            Console.ReadKey();

                        }
                        break;


                    default:

                        Console.WriteLine("Digito un valor Erroneo");
                        break;

                }


                Console.WriteLine("Desea realizar otra operacion? 1. si / 2. no");

                while (!Int32.TryParse(Console.ReadLine(), out salir))
                {
                    Console.WriteLine("Error, seleccione la opcion correcta");
                }

                Console.Clear();
              
            } while (salir != 2);



               

        }

        public static void salto_linea()
        {
            Console.WriteLine("\n");
        
        }
        public static void menu_pantalla()
        {
            Console.WriteLine("*********** Menu ***********");
            salto_linea();
            Console.WriteLine("Seleccione una opcion:");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.WriteLine("0. Salir");
          
            salto_linea();
            Console.WriteLine("****************************");
            salto_linea();
            Console.WriteLine("Seleccione una opcion");

        
        }
    }
}
