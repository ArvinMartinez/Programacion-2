using System;
using System.Collections.Generic;
public class Notas
{
    public List<Estudiantes> ListaEstudiantes { get; set; }

    public List<Asignatura> ListaAsignatura { get; set; }

    public int NotaFinal { get; set; }

    public Notas()
    {

        ListaEstudiantes = new List<Estudiantes>();
        CargarEstudiantes();

        ListaAsignatura = new List<Asignatura>();
        CargarAsignaturas();


    }
    private void CargarEstudiantes()
    {
      Estudiantes e1 = new Estudiantes(001,"Julia","Martinez");
      ListaEstudiantes.Add(e1);

      Estudiantes e2 = new Estudiantes(002,"Carmen","sofia");
      ListaEstudiantes.Add(e2);

      Estudiantes e3 = new Estudiantes(003,"Edgar","Lopez");
      ListaEstudiantes.Add(e3);

      Estudiantes e4 = new Estudiantes(004,"Jeferson","flores");
      ListaEstudiantes.Add(e4);
    }

    private void CargarAsignaturas()
    {
      Asignatura a1 = new Asignatura("Al005","Español");
      ListaAsignatura.Add(a1);
      
      Asignatura a2 = new Asignatura("Tl001","Matematicas");
      ListaAsignatura.Add(a2);

      Asignatura a3 = new Asignatura("Af009","Deportes");
      ListaAsignatura.Add(a3);

      Asignatura a4 = new Asignatura("Ac005","Computacion");
      ListaAsignatura.Add(a4);
    }
     public void ListarEstudiantes()
    {
        Console.Clear();
        Console.WriteLine("Lista de Alumnos");
        Console.WriteLine("****************");
        
        foreach (var estudiantes in ListaEstudiantes)
        {
          Console.WriteLine(estudiantes.CodigoEstudiante + " | " + estudiantes.Nombre + " | " + estudiantes.Apellido);
        }
        Console.ReadLine();
    }
    public void ListarAsignatura()
    {
        Console.Clear();
        Console.WriteLine("Lista de Asignaturas");
        Console.WriteLine("********************");
        
        foreach (var asignatura in ListaAsignatura)
        {
          Console.WriteLine(asignatura.Codigo + " | " + asignatura.NombreAsignatura);
        }
        Console.ReadLine();
    }
     public void ingresarNotas()
    {
      Console.Clear();
      Console.WriteLine("Ingreso de las Notas");
      Console.WriteLine("********************");
      Console.WriteLine("");
      Console.WriteLine("Ingrese el Nombre del Estudiante: ");
      string nombre = Console.ReadLine();

      Estudiantes estudiante = ListaEstudiantes.Find(e => e.Nombre.ToLower() == nombre);
      if (estudiante == null)
      {
        Console.WriteLine("Estudiante no encontrado");
        Console.ReadLine();
        return;
      }
      else
      {
        Console.WriteLine("");
        Console.WriteLine("Estudiante: " + estudiante.Nombre + " | " + estudiante.Apellido);
        Console.WriteLine("");
      }
      Console.ReadLine();

      foreach (var asignatura in ListaAsignatura)
      {
        Console.WriteLine("Asignatura: " + asignatura.NombreAsignatura);
        Console.WriteLine("*****************************");
        Console.WriteLine("");
        Console.WriteLine("Ingrese las 4 notas obtenidas");
        Console.WriteLine("");
        Console.WriteLine("Nota 1: ");
        asignatura.NotaA = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Nota 2: ");
        asignatura.NotaB = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Nota 3: ");
        asignatura.NotaC = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Nota 4: ");
        asignatura.NotaD = Int32.Parse(Console.ReadLine());

        asignatura.Notapromedio = (asignatura.NotaA + asignatura.NotaB + asignatura.NotaC + asignatura.NotaD)/4;
      }
      foreach (var nota in ListaAsignatura)
      {
        Console.WriteLine("El promedio es de: " + nota.Notapromedio + " en la clase de " + nota.NombreAsignatura);
      }
      Console.ReadLine();
    }

    public void Notafinales()
    {
      double suma = 0;
      Console.Clear();
      Console.WriteLine("****************");
      Console.WriteLine("Calicacion Final");
      Console.WriteLine("****************");
      Console.WriteLine("Ingrese el Nombre del Estudiante: ");
      string nombre = Console.ReadLine();

      Estudiantes estudiante = ListaEstudiantes.Find(e => e.Nombre.ToLower() == nombre);
      if (estudiante == null)
      {
        Console.WriteLine("Estudiante no encontrado");
        Console.ReadLine();
        return;
      }
      else
      {
        Console.WriteLine("");
        Console.WriteLine("Estudiante: " + estudiante.Nombre + " | " + estudiante.Apellido);
        Console.WriteLine("");
      }
      foreach (var nota in ListaAsignatura)
      {
        Console.WriteLine("EL Promedio final es de: " + nota.Notapromedio + " en la clase de " + nota.NombreAsignatura);
        suma += nota.Notapromedio / 6;
      }
      Console.WriteLine(""); 
      Console.WriteLine("EL Promedio final de " + estudiante.Nombre + " es de: " + suma.ToString("N2") + " %" );
      Console.ReadLine();
     }       
}