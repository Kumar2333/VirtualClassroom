using System.Collections.Generic;

public class ListTV
{
    public List<TV> TVs = new List<TV>();

    public void AddTV(TV tv)
    {
        TVs.Add(tv);
    }
}