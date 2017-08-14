using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaFacu
{
    class Facultad
    {
        private int opcion;
        private List<Estudiante> listaEstudiantes;
        private List<Docente> listaDocente;
        public void desplegar()
        {
            listaEstudiantes = new List<Estudiante>();
            listaDocente = new List<Docente>();
            do
            {
                do
                {
                    menu();
                    Console.Clear();
                    if (opcion < 1 || opcion > 7)
                    {
                        Console.WriteLine("Ingrese una opcion valida entre [1-7]");
                    }
                } while (opcion < 1 || opcion > 7);
                switch (opcion)
                {
                    case 1:
                        Estudiante regEst = new Estudiante();
                        Console.Write("     Nombre : ");
                        regEst.Name = Console.ReadLine();
                        Console.Write("   Apellido : ");
                        regEst.LastName = Console.ReadLine();
                        Console.Write("   Telefono : ");
                        regEst.Phone = Convert.ToInt32(Console.ReadLine());
                        Console.Write("       Edad : ");
                        regEst.Old = Convert.ToInt32(Console.ReadLine());
                        Console.Write("  Direccion : ");
                        regEst.Adres = Console.ReadLine();
                        Console.Write("         Ci : ");
                        regEst.Ci = Console.ReadLine();
                        Console.Write("     Genero : ");
                        regEst.Sex = Convert.ToBoolean(Console.ReadLine());
                        Console.Write("    Carrera : ");
                        regEst.Carrera = Console.ReadLine();
                        Console.Write("Año Ingreso : ");
                        regEst.YearIngreso = Convert.ToInt32(Console.ReadLine());

                        listaEstudiantes.Add(regEst);
                        Console.Clear();
                        break;
                    case 2:
                        Docente regDoc = new Docente();
                        Console.Write("     Nombre : ");
                        regDoc.Name = Console.ReadLine();
                        Console.Write("   Apellido : ");
                        regDoc.LastName = Console.ReadLine();
                        Console.Write("   Telefono : ");
                        regDoc.Phone = Convert.ToInt32(Console.ReadLine());
                        Console.Write("       Edad : ");
                        regDoc.Old = Convert.ToInt32(Console.ReadLine());
                        Console.Write("  Direccion : ");
                        regDoc.Adress = Console.ReadLine();
                        Console.Write("         Ci : ");
                        regDoc.Ci = Console.ReadLine();
                        Console.Write("     Genero : ");
                        regDoc.Sex = Convert.ToBoolean(Console.ReadLine());
                        Console.Write("    Carrera : ");
                        regDoc.Materia = Console.ReadLine();

                        listaDocente.Add(regDoc);
                        Console.Clear();
                        break;
                    case 3:
                        foreach (Estudiante item in listaEstudiantes)
                        {
                            Console.WriteLine("_______________________________________");
                            Console.WriteLine("");
                            Console.WriteLine("     Nombre : "+item.Name);
                            Console.WriteLine("   Apellido : "+item.LastName);
                            Console.WriteLine("   Telefono : "+item.Phone);
                            Console.WriteLine("       Edad : "+item.Old);
                            Console.WriteLine("  Direccion : "+item.Adres);
                            Console.WriteLine("         Ci : "+item.Ci);
                            Console.WriteLine("     Genero : "+item.Sex);
                            Console.WriteLine("    Carrera : "+item.Carrera);
                            Console.WriteLine("Año Ingreso : "+item.YearIngreso);
                            Console.WriteLine("________________________________________");
                            Console.WriteLine("");
                        }
                        break;
                    case 4:
                        foreach (Docente item in listaDocente)
                        {
                            Console.WriteLine("_______________________________________");
                            Console.WriteLine("");
                            Console.WriteLine("     Nombre : " + item.Name);
                            Console.WriteLine("   Apellido : " + item.LastName);
                            Console.WriteLine("   Telefono : " + item.Phone);
                            Console.WriteLine("       Edad : " + item.Old);
                            Console.WriteLine("  Direccion : " + item.Adress);
                            Console.WriteLine("         Ci : " + item.Ci);
                            Console.WriteLine("     Genero : " + item.Sex);
                            Console.WriteLine("    Carrera : " + item.Materia);
                            Console.WriteLine("________________________________________");
                            Console.WriteLine("");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Nombre a Buscar : ");
                        string NameBuscar = Console.ReadLine();
                        foreach (Estudiante item in listaEstudiantes)
                        {
                            if (item.Name == NameBuscar)
                            {
                                Console.WriteLine("     Nombre : " + item.Name);
                                Console.WriteLine("   Apellido : " + item.LastName);
                                Console.WriteLine("   Telefono : " + item.Phone);
                                Console.WriteLine("       Edad : " + item.Old);
                                Console.WriteLine("  Direccion : " + item.Adres);
                                Console.WriteLine("         Ci : " + item.Ci);
                                Console.WriteLine("     Genero : " + item.Sex);
                                Console.WriteLine("    Carrera : " + item.Carrera);
                                Console.WriteLine("Año Ingreso : " + item.YearIngreso);
                            }
                        }
                        break;
                    case 6:
                        Console.WriteLine("Nombre a Buscar : ");
                        string NameBusca = Console.ReadLine();
                        foreach (Docente item in listaDocente)
                        {
                            if (item.Name == NameBusca)
                            {
                                Console.WriteLine("     Nombre : " + item.Name);
                                Console.WriteLine("   Apellido : " + item.LastName);
                                Console.WriteLine("   Telefono : " + item.Phone);
                                Console.WriteLine("       Edad : " + item.Old);
                                Console.WriteLine("  Direccion : " + item.Adress);
                                Console.WriteLine("         Ci : " + item.Ci);
                                Console.WriteLine("     Genero : " + item.Sex);
                                Console.WriteLine("    Carrera : " + item.Materia);
                            }
                        }
                        break;
                    case 7:
                        Console.WriteLine("Gracias por Utilizar el sistema de la FAcultad..");
                        Console.ReadKey();
                        break;
                }
            } while (opcion != 7);
        }
        public void menu()
        {
            Console.WriteLine(" ____________________________________________");
            Console.WriteLine("|                                            |");
            Console.WriteLine("|            FACULTAD DE INGENIERIA          |");
            Console.WriteLine("|____________________________________________|");
            Console.WriteLine("|                                            |");
            Console.WriteLine("|     1.- Registro de Estudiantes            |");
            Console.WriteLine("|     2.- Registro de Docente                |");
            Console.WriteLine("|     3.- Ver Lista de Estudiantes           |");
            Console.WriteLine("|     4.- Ver lista de Docentes              |");
            Console.WriteLine("|     5.- Buscar a un Estudiante             |");
            Console.WriteLine("|     6.- Buscar a un Docente                |");
            Console.WriteLine("|     7.- Salir                              |");
            Console.WriteLine("|____________________________________________|");
            opcion = Convert.ToInt32(Console.ReadLine());
        }
       
    }
}
