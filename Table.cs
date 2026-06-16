public class Table
{
    public int TableId { get; set; }
    public string Material { get; set; }

    public void DisplayInfo()
    {
        System.Console.WriteLine("Table ID: " + TableId);
    }
}