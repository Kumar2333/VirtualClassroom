public class Student
{
    public string Name { get; set; }
    public string StudentId { get; set; }

    public void AttendClass()
    {
        System.Console.WriteLine(Name + " attended class.");
    }
}