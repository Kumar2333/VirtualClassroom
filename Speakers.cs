public class Speakers
{
    public string Brand { get; set; }
    public int Volume { get; set; }

    public void IncreaseVolume()
    {
        Volume++;
    }
}