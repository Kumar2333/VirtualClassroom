using System;

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student();
        student.Name = "KUMAR";

        Lecturer lecturer = new Lecturer();
        lecturer.Name = "Mr Nordin";

        student.AttendClass();
        lecturer.Teach();
        
        Chair chair = new Chair();
        chair.ChairId = 1;

        Table table = new Table();
        table.TableId = 101;

       Console.WriteLine("Chair ID: " + chair.ChairId);
       Console.WriteLine("Table ID: " + table.TableId);
    }
}