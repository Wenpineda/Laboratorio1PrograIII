using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lab1progra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------Bienvenido/a------");

            Console.WriteLine("\nELIGE LA OPCION:\n 1- Registrarse " +
                "\n 2- Salir del programa");
            int opcion = int.Parse(Console.ReadLine());
            while (opcion <= 0 || opcion >= 3)
            {
                Clear();
                ResetColor();
                Console.WriteLine("\nELIGE LA OPCIÓN:" +
                    "\n 1- Registrarse " +
                    "\n 2- Salir del programa");
                opcion = int.Parse(Console.ReadLine());
            }

            switch (opcion)
            {

                case 1:
                    Clear();
                    Persona person = new Persona();
                    person.Datos(person.Nombrecompleto, person.Edad);
                    residencia resi = new residencia();
                    resi.localidad(resi.Departamento, resi.Municipio, resi.Edad);
                    break;
                case 2:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opcion no valida, vuelve a intentarlo");
                    Console.ReadLine();

                    break;
            }
        }
        class Persona
        {
            private string nombrecompleto;
            private int edad;

            public string Nombrecompleto { get => nombrecompleto; set => nombrecompleto = value; }
            public int Edad { get => edad; set => edad = value; }

            public void Datos(string _nombrecompleto, int _edad)
            {
                this.Nombrecompleto = _nombrecompleto;
                this.Edad = _edad;

                WriteLine("-------------------------------");
                WriteLine("INGRESE SUS DATOS POR FAVOR \n");
                WriteLine("Ingrese su nombre completo: ");
                Nombrecompleto = ReadLine();
                WriteLine("Ingrese su edad completo: ");
                Edad = int.Parse(Console.ReadLine());
            }
        }

        class residencia : Persona
        {
            private string departamento;
            private string municipio;

            public string Departamento { get => departamento; set => departamento = value; }
            public string Municipio { get => municipio; set => municipio = value; }

            //private float[] departaments;// 6 departamentos
           //private float[] municip; // 8 municipios 


            public void localidad(string _departamento , string _municipio, int _edad)
            {
                Persona per = new Persona();
                string[] almacen = new string[6];


                this.Departamento = _departamento;
                this.Municipio = _municipio;
                this.Edad = _edad;
                Clear();
                try
                {
                    WriteLine("-------------------------------");
                    WriteLine("INGRESE LOS DATOS DONDE VIVE \n");
                    WriteLine("Ingrese el Departamento al qu epertenece: ");
                    departamento = ReadLine();
                    WriteLine("Ingrese el municipio al que pertenece ");
                    municipio = ReadLine();
                    WriteLine($"La Persona {per.Nombrecompleto} originario/a del municipio de {municipio} \nen el departamento de {departamento} \ncuenta con {per.Edad} años de edad.");
                    ReadLine();

                }
                catch (Exception)
                {


                }



                //string linea;
                //departaments = new float[6];
                //municip = new float[48];

                //Console.WriteLine("");
                //for (int f = 0; f < 4; f++)
                //{
                //    Console.Write("Ingrese el Departamento " + (f + 1) + ": ");
                //    linea = Console.ReadLine();
                //    departaments[f] = float.Parse(linea); //Asignamos valores 
                //}
                //Console.WriteLine("");
                //for (int f = 0; f < 4; f++)
                //{
                //    Console.Write("Ingrese el municipio: " + (f + 1) + ": ");
                //    linea = Console.ReadLine();
                //    municip[f] = float.Parse(linea); //Asignamos 
                //}
                //for (int f = 0; f < 4; f++)
                //{
                //    Console.WriteLine("Desea agregar otro dato");
                //}
            }


        }
        
    }
}
