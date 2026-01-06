namespace SchoolGradesManager;

public class Notes
{
    public double Value { get; private set; }
    public Discipline Discipline { get; private set; }


    public Notes(double value, Discipline discipline)
    {
        if (value < 0 || value > 10)

            throw new ArgumentException("Invalid Note!");

        Value = value;
        Discipline = discipline ?? throw new ArgumentException(nameof(discipline));
        
    }
}
