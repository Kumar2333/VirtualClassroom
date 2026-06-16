public class TV
{
    public string Brand { get; set; }
    public bool IsOn { get; set; }

    public void TurnOn()
    {
        IsOn = true;
    }
}