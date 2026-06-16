public class Class
{
    public string ClassName { get; set; }
    public string Schedule { get; set; }

    public void StartClass()
    {
        System.Console.WriteLine(ClassName + " started.");
    }
}