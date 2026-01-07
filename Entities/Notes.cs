namespace SchoolGradesManager;

public class Note
{
    public double Value { get; private set; }
    public Discipline Discipline { get; private set; }


    public Note(double value, Discipline discipline)
    {
        if (value < 0 || value > 10)

            throw new ArgumentException("Invalid Note!");

        Value = value;
        Discipline = discipline ?? throw new ArgumentException(nameof(discipline));
        
    }
}
