public class Profesor : Persona
{
    public List<Curso> Cursos { get; private set; }

    public Profesor(string nombre) : base(nombre)
    {
        Cursos = new List<Curso>();
    }

    public void AgregarCurso(Curso curso)
    {
        Cursos.Add(curso);
    }
}