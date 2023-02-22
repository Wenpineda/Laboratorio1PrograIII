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
                    Console.WriteLine(person.GetPerson());
                    Console.WriteLine(resi.GetResidencia());
                    Console.ReadLine();
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
                WriteLine("Ingrese su edad porfavor: ");
                Edad = int.Parse(Console.ReadLine());
            }

            public String GetPerson()
            {

                return "\nNombre Completo: " + Nombrecompleto + "\nEdad: " + Edad ;

            }
        }

        class residencia : Persona
        {
            private string departamento;
            private string municipio;

            public string Departamento { get => departamento; set => departamento = value; }
            public string Municipio { get => municipio; set => municipio = value; }


            //string[] Chalatenango = new string[8] { "La Palma", "San Ignacio", "Citala", "La Laguna", "Comalapa", "Potonico", "La Reina", "Tejutla" };
            //string[] Sonsonate = new string[8] { "Acajutla", "Caluco", "Izalco", "Nahulingo", "Armenia", "Sonzacate", "Nahuizalco", "San Julián" };
            //string[] Morazan = new string[8] { "Arambala", "Cacaopera", "Chilanga", "Corinto", "El Divisadero", "Joateca", "Jocoro", "Meanguera" };
            //string[] Usulutan = new string[8] { "Alegría", "Berlín", "California", "Concepción Batres", "El Triunfo", "Ereguayquín", "Estanzuelas", "Jiquilisco" };
            //string[] SantaAna = new string[8] { "Candelaria de la Frontera", "Coatepeque", "El Congo", "El Porvenir", "Masahuat", "Metapán", "Texistepeques", "San Antonio Pajonal" };
            //string[] SanMiguel = new string[8] { "Chirilagua", "Ciudad Barrios", "Comacarán", "Quelepa", "Uluazapa", "Sesori", "Moncagua", "Chapeltique" };


            public void localidad(string _departamento, string _municipio, int _edad)
            {
                Persona per = new Persona();
                this.Departamento = _departamento;
                this.Municipio = _municipio;
                this.Edad = _edad;
                Clear();
                WriteLine("-------------------------------");
                WriteLine("INGRESE LOS DATOS DONDE VIVE \n");
                string[] opcion = { "Chalatenango", "Sonsonate", "Morazan", "Usulutan", "Santa Ana", "San Miguel" };
                for (int f = 0; f < opcion.Length; f++)
                {
                    Console.WriteLine($"{f + 1} - {opcion[f]}");
                }
                int Depopcion = int.Parse(ReadLine());
                while (Depopcion > opcion.Length || Depopcion <= 0)
                {
                    WriteLine($" La opcion: {Depopcion} que ud ingreso no se encuantra intentrelo de nuevo");
                    WriteLine("Ingrese el municipio al que pertenece ");
                    for (int f = 0; f < opcion.Length; f++)
                    {
                        Console.WriteLine($"{f + 1} - {opcion[f]}");
                    }
                    Depopcion = int.Parse(ReadLine());
                }

                Departamento = opcion[Depopcion - 1];
                Console.WriteLine($"Ingrese el municipio al que pertenece de {Departamento}\n");
                int Muniopcion = 0;
                switch (Departamento)
                {
                    case "Chalatenango":
                        string[] Chalatenango = { "La Palma", "San Ignacio", "Citala", "La Laguna", "Comalapa", "Potonico", "La Reina", "Tejutla" };

                        for (int f = 0; f < Chalatenango.Length; f++)
                        {
                            Console.WriteLine($"{f + 1} - {Chalatenango[f]}");
                        }
                        Muniopcion = int.Parse(ReadLine());
                        Municipio = Chalatenango[Muniopcion - 1];
                        break;
                    case "Sonsonate":
                        string[] Sonsonate = { "Acajutla", "Caluco", "Izalco", "Nahulingo", "Armenia", "Sonzacate", "Nahuizalco", "San Julián" };

                        for (int f = 0; f < Sonsonate.Length; f++)
                        {
                            Console.WriteLine($"{f + 1} - {Sonsonate[f]}");
                        }
                        Muniopcion = int.Parse(ReadLine());
                        Municipio = Sonsonate[Muniopcion - 1];
                        break;
                    case "Morazan":
                        string[] Morazan = { "Arambala", "Cacaopera", "Chilanga", "Corinto", "El Divisadero", "Joateca", "Jocoro", "Meanguera" };

                        for (int f = 0; f < Morazan.Length; f++)
                        {
                            Console.WriteLine($"{f + 1} - {Morazan[f]}");
                        }
                        Muniopcion = int.Parse(ReadLine());
                        Municipio = Morazan[Muniopcion - 1];
                        break;
                    case "Usulutan":
                        string[] Usulutan = { "Alegría", "Berlín", "California", "Concepción Batres", "El Triunfo", "Ereguayquín", "Estanzuelas", "Jiquilisco" };

                        for (int f = 0; f < Usulutan.Length; f++)
                        {
                            Console.WriteLine($"{f + 1} - {Usulutan[f]}");
                        }
                        Muniopcion = int.Parse(ReadLine());
                        Municipio = Usulutan[Muniopcion - 1];
                        break;
                    case "Santa Ana":
                        string[] SantaAna = { "Candelaria de la Frontera", "Coatepeque", "El Congo", "El Porvenir", "Masahuat", "Metapán", "Texistepeques", "San Antonio Pajonal" };

                        for (int f = 0; f < SantaAna.Length; f++)
                        {
                            Console.WriteLine($"{f + 1} - {SantaAna[f]}");
                        }
                        Muniopcion = int.Parse(ReadLine());
                        Municipio = SantaAna[Muniopcion - 1];
                        break;
                    case "San Miguel":
                        string[] SanMiguel = { "Chirilagua", "Ciudad Barrios", "Comacarán", "Quelepa", "Uluazapa", "Sesori", "Moncagua", "Chapeltique" };

                        for (int f = 0; f < SanMiguel.Length; f++)
                        {
                            Console.WriteLine($"{f + 1} - {SanMiguel[f]}");
                        }
                        Muniopcion = int.Parse(ReadLine());
                        Municipio = SanMiguel[Muniopcion - 1];
                        break;
                    default:
                        Console.WriteLine("");
                        break;
                }

            }

            public String GetResidencia()
            {


                return "Departamento: " + Departamento + "\nMunicipio: " + Municipio;

            }

        }
        
    }
}
