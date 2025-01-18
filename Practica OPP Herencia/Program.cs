class Program
{
    static void Main(string[] args)
    {
        
        Clase clase = new Clase("Software");

        
        Estudiante estudiante1 = new Estudiante("Reynaldo", 1);
        Estudiante estudiante2 = new Estudiante("Emilio", 2);
        clase.AgregarEstudiante(estudiante1);
        clase.AgregarEstudiante(estudiante2);

        
        Profesor profesor = new Profesor("Francis Ramirez");
        clase.AgregarProfesor(profesor);


        Curso curso = new Curso("Programacion II", 20, 10);
        profesor.AgregarCurso(curso);

      
        Console.WriteLine($"Clase: {clase.Identificador}");
        Console.WriteLine("Estudiantes:");
        foreach (var est in clase.Estudiantes)
        {
            Console.WriteLine($"- {est.Nombre} (ID: {est.NumeroUnico})");
        }

        Console.WriteLine("Profesores:");
        foreach (var prof in clase.Profesores)
        {
            Console.WriteLine($"- {prof.Nombre}");
            Console.WriteLine("  Cursos:");
            foreach (var cur in prof.Cursos)
            {
                Console.WriteLine($"    - {cur.Nombre} (Clases: {cur.RecuentoClases}, Ejercicios: {cur.RecuentoEjercicios})");
            }
        }
    }
}
