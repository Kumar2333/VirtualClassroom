using System.Collections.Generic;

public class ListChair
{
    public List<Chair> Chairs = new List<Chair>();

    public void AddChair(Chair chair)
    {
        Chairs.Add(chair);
    }
}