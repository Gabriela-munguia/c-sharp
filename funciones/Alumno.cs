public class Alumno
{   
    public int Id { get; set; }
    public string PrimerNombre { get; set; }
    public string SegundoNombre { get; set; }

    public bool Activo { get; set; }

    public Alumno (){ 
     Id = 1;

     } 
     public Alumno (int id){ 
       Id = id; 
      }   
    public Alumno (string primernombre, string segundonombre)
    { 
     Id = di;
     PrimerNombre = primernombre;
     SegundoNombre = segundonombre;
     Activo =  true;

      }   
      public string nombreCompleto() { 
          if (Activo == true){ 
          return PrimerNombre + " " + SegundoNombre;
          }
          return "Alumno inactivo";
       }
       public void InactivarAlumno() { 
           Activo = false;
        }
}
