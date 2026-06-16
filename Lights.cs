using System.Collections.Generic;

public class Lights
{
    public List<Light> LightList = new List<Light>();

    public void AddLight(Light light)
    {
        LightList.Add(light);
    }
}