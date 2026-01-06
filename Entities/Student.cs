namespace SchoolGradesManager;

public class Student
{
    private static int _contadorId = 1;
    public string Name { get; set; }
    public int Id { get; private set; }
    private List<Notes> notes;

    public Student(string name)
    {   
        Name = name;
        Id = ++_contadorId;
        notes = new List<Notes>();
        
    }

    public void AddNote(Notes note)
    {
        if(note == null)
        {
            throw new ArgumentException(nameof(note));
        }
        notes.Add(note);
    }
    public IReadOnlyList<Notes> GetNotas()
    {
        return notes.AsReadOnly();
    }

    public double AvaregeNotes(Discipline discipline)
    {
        var notesForDiscipline = notes.Where(n => n.Discipline.Id == discipline.Id).ToList();

        if(!notesForDiscipline.Any())
        {
            throw new InvalidOperationException("This Student has no grade!");
        }
        return notesForDiscipline.Average(n => n.Value);
    }
}
