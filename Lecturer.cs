public class Lecturer
{
    public string Name { get; set; }
    public string Subject { get; set; }

    public void Teach()
    {
        System.Console.WriteLine(Name + " is teaching.");
    }
}