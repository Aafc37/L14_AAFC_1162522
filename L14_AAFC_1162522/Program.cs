using System;

namespace LAB_SEMANA_12_EJEMPLO
{
    class Program
    {
       


        static void Main(string[] args)
        {
            string opcion;
            int[] anio;
            int numero1, numero2;

            Console.WriteLine("Bienvenido al siguiente menú, por favor seleccione una opción: ");
            Console.WriteLine("Presione 1: ------>  años ");
            Console.WriteLine("Presione 2: ------>  Salario");
            Console.WriteLine("Presione 3: ------>  Salir");

            opcion = Console.ReadLine();

            string[] nom = new string[5];
            anio = new int[5];



            switch (opcion)
            {

            
                case "1":
                    

                    for (int f = 0; f < 5; f++)
                    {
                        Console.WriteLine("Nombre de la persona : ");
                        nom[f] = Console.ReadLine();


                        Console.WriteLine("Ingrese el año de nacimiento:  ");
                        string fe;

                        fe = Console.ReadLine();
                        anio[f] = int.Parse(fe);
                        }
                        for (int f = 0; f < 5; f++)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("la edad de " + nom[f]  + " es : ");
                            Console.WriteLine(2022 - anio[f]);
                        Console.WriteLine(" ");
                    }
                    break;

                   


                case "2":

                   


                    for (int f = 0; f < 5; f++)
                    {
                        Console.WriteLine("Nombre de la persona : ");
                        nom[f] = Console.ReadLine();


                        Console.WriteLine("Ingrese salario:  ");
                        string fe;

                        fe = Console.ReadLine();
                        anio[f] = int.Parse(fe);
                    }
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");

                    for (int f = 0; f < 5; f++)
                    {
                        ;
                        Console.WriteLine("El salario de " + nom[f] + " es : ");
                        Console.WriteLine(anio[f]);
                        Console.WriteLine(" ");
                    }


                    break;



                case "3":
                    Console.WriteLine("Gracias por ingresar");
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("No seleccionó ninguna de las opciones disponibles ");
                    break;

            }



        }
    }
}