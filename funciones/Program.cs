using System;

namespace propiedades
{   
    class Program
    { 
        static void Main (string [] args)
         {  
             Alumno a = new Alumno();
             a.PrimerNombre ="Juan";
             a.SegundoNombre ="Perez";

             Alumno b = new Alumno();
             b.Id = 2;
             b.PrimerNombre ="Maria";
             b.SegundoNombre ="Matinez";

             Alumno c = new Alumno (3);
             b.PrimerNombre ="Pedro";

             Alumno a = new Alumno (1,"Juan","Perez");
             Alumno b = new Alumno (2,"Maria","Martinez");

             Console.WriteLine(a.Id);
             Console.WriteLine(b.Id);
             Console.WriteLine(c.Id);
             Console.WriteLine(d.PrimerNombre + " " + d.SegundoNombre );
             Console.WriteLine(a.nombreCompleto());
            Console.WriteLine(b.nombreCompleto());
         }
    }
