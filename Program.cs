using SchoolGradesManager;

try
{
    var portugues = new Discipline("portugues");
    var matematica = new Discipline("Matematica");
    Student joão = new("João");
    joão.AddNote(new Note(8.5,matematica));
    joão.AddNote(new Note(9.0,matematica));
    joão.AddNote(new Note(5.5,portugues));
    
    Console.WriteLine($"Media em Matemática: {joão.AverageNotes(matematica)}");
    



}
catch (Exception )
{
    System.Console.WriteLine("Error!");
}