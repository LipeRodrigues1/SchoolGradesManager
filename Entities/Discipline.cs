namespace SchoolGradesManager;

public class Discipline
{
    private static int _contadorId = 1;
    public string Name { get; set; }
    public int Id { get; private set; }


    public Discipline(string name)
    {
        Name = name;
        Id = _contadorId++;
    }
}
