using System;

namespace NotasEscolares
{
    class Program
    {
       static void Main(string[] arg)
       {
        Seguridad datos2 = new Seguridad();  
        string nombre;
        string contraseña;

        Console.Clear();
        Console.WriteLine("Ingreso al Sistema");
        Console.WriteLine("******************");
        Console.WriteLine("");

        Console.WriteLine("Ingrese el nombre de usuario: ");
        nombre = Console.ReadLine();
        Console.WriteLine("Ingrese la contraseña: ");
        contraseña = Console.ReadLine();

        bool resultado = datos2.Autenticar(nombre,contraseña);

        if (resultado == true)
        {
          Console.Clear();
          Console.WriteLine("****************************");
          Console.WriteLine("Bienvido al Sistema de notas");
          Console.WriteLine("****************************");
          Console.WriteLine("");
          Console.WriteLine("Ingeniero " + nombre);
        }else
        {
          Console.WriteLine("Usuario o contraseña invalido");
          return;
        }
        Console.ReadKey();

        Notas datos = new Notas();
        string opcion = "";


        while (true)
        {
            Console.Clear();
            Console.WriteLine("*****************************");
            Console.WriteLine("Escuela Carlos Hernan Banegas Lazo");
            Console.WriteLine("*****************************");
            Console.WriteLine("");
            Console.WriteLine("Sistema de Notas Escolares");
            Console.WriteLine("**************************");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Bienvenido Ingeniero " + nombre);
            Console.WriteLine("------------------------------");
            Console.WriteLine("");
            Console.WriteLine("1. -- Lista de Docentes");
            Console.WriteLine("2. -- Mostrar Estudiantes");
            Console.WriteLine("3. -- Mostrar Asignaturas");
            Console.WriteLine("");
            Console.WriteLine("Calificaciones");
            Console.WriteLine("**************");
            Console.WriteLine("4. -- Ingreso de Notas");
            Console.WriteLine("5. -- Notas Finales");
            Console.WriteLine("0. -- Salir");
            Console.WriteLine("");
            Console.WriteLine("Ingrese una de la opciones: ");
            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                     datos2.ListarUsuario();
                     break;
                case "2":
                     datos.ListarEstudiantes();
                     break;
                case "3":
                     datos.ListarAsignatura();
                     break;
                case "4":
                     datos.ingresarNotas();
                     break;
                case "5":
                     datos.Notafinales();
                     break;    
                default:
                break;
            }
            if(opcion == "0")
            {
                break;
            }
         }
       }
    }
}
