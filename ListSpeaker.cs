using System.Collections.Generic;

public class ListSpeaker
{
    public List<Speakers> SpeakersList = new List<Speakers>();

    public void AddSpeaker(Speakers speaker)
    {
        SpeakersList.Add(speaker);
    }
}