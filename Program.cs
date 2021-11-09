using System;
using System.IO;

namespace Integrador_Punto_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //menu
            Console.WriteLine("========== Bienvenidx ==========");
            Console.WriteLine("1.- Registrar libro \n2.- Ver registros \n3.- Finalizar programa");
            Console.WriteLine("================================");
            int opcion = int.Parse(Console.ReadLine());
            if (opcion == 1 || opcion == 2 || opcion == 3)
            {
                    switch (opcion)
                    {
                        case 1:
                            registrarLibro();
                            Console.WriteLine("========== Bienvenidx ==========");
                            Console.WriteLine("1.- Registrar libro \n2.- Ver registros \n3.- Finalizar programa");
                            Console.WriteLine("================================");
                            opcion = int.Parse(Console.ReadLine());
                            break;
                        case 2:
                            leerRegistros();
                            break;
                    }
                if (opcion == 3 && opcion < 4)
                {
                    Console.WriteLine("Hasta luego! oprima una tecla para finalizar el programa");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Opcion no valida.");
            }
        }

        //leer registro
        static void leerRegistros()
        {
            string linea;
            string ruta = @"D:\biblioteca.txt";
            StreamReader reader = new StreamReader(ruta);

            while ((linea = reader.ReadLine()) != null)
            {
                Console.WriteLine(linea);
            }
        }

        //registrar libro
        static void registrarLibro()
        {
            string ruta = @"D:\biblioteca.txt";
            string tituloLibro = "";
            string autor = "";
            string cantidadPaginas = "";

            Console.WriteLine("Titulo del libro:");
            tituloLibro = Console.ReadLine();

            Console.WriteLine("Autor: ");
            autor = Console.ReadLine();

            Console.WriteLine("Cantidad de paginas: ");
            cantidadPaginas = Console.ReadLine();

            StreamWriter writer = File.AppendText(ruta);
            writer.WriteLine("Titulo del libro: {0}", tituloLibro);
            writer.WriteLine("Autor: {0}", autor);
            writer.WriteLine("Cantidad de paginas: {0}", cantidadPaginas);

            Console.WriteLine("Registrar temas: \n 1.- Ficcion \n 2.- Economia \n 3.- Historia y Literatura");
            int temas = int.Parse(Console.ReadLine());
            if (temas < 4)
            {
                switch (temas)
                {
                    case 1:
                        writer.WriteLine("Tema: Ficcion");
                        break;
                    case 2:
                        writer.WriteLine("Tema: Economia");
                        break;
                    case 3:
                        writer.WriteLine("Tema: Historia y Literatura");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Tema no valido, reintente: ");
                Console.WriteLine("Registrar temas: \n 1.- Ficcion \n 2.- Economia \n 3.- Historia y Literatura");
                int temaSegundaChance = int.Parse(Console.ReadLine());

                switch (temaSegundaChance)
                {
                    case 1:
                        writer.WriteLine("Tema: Ficcion");
                        break;
                    case 2:
                        writer.WriteLine("Tema: Economia");
                        break;
                    case 3:
                        writer.WriteLine("Tema: Historia y Literatura");
                        break;
                }

            }
            writer.WriteLine("========================");
            writer.Close();
        }
    }
}
