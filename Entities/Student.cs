using Notas_Escolares;

namespace SchoolGradesManager;

public class Student
{
    private static int _contadorId = 1;
    public string Name { get; set; }
    public int Id { get; private set; }
    private List<Note> notes;

    public Student(string name)
    {   
        Name = name;
        Id = ++_contadorId;
        notes = new List<Note>();
        
    }

    public void AddNote(Note note)
    {
        if(note == null)
        {
            throw new ArgumentException(nameof(note));
        }
        notes.Add(note);
    }
    public IReadOnlyList<Note> GetNotas()
    {
        return notes.AsReadOnly();
    }

    public double AverageNotes(Discipline discipline)
    {
        var notesForDiscipline = notes.Where(n => n.Discipline.Id == discipline.Id).ToList();

        if(!notesForDiscipline.Any())
        {
            throw new InvalidOperationException("This Student has no grade!");
        }
        return notesForDiscipline.Average(n => n.Value);
    }

    public Situation GetSituation(Discipline discipline)
    {
        double average = AverageNotes(discipline);
        if(average >= 7.0)
        {
            return Situation.Aprovado;
        }
        else if(average >= 5.0 && average < 7.0)
        {
            return Situation.Recuperacao;
        }
        else
        {
            return Situation.Reprovado;
        }
    }

    internal object AvaregeNotes(Discipline matematica)
    {
        throw new NotImplementedException();
    }
}
