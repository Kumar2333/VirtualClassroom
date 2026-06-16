public class Chair
{
    public int ChairId { get; set; }
    public bool IsOccupied { get; set; }

    public void DisplayInfo()
    {
        System.Console.WriteLine("Chair ID: " + ChairId);
    }
}