using System;

public class MusicPlayer : IMediaPlayer
{
    private string current_track = "";

    public void LoadTrack(string track_name)
    {
        current_track = track_name;
        Console.WriteLine("Cancion cargada: " + current_track);
    }

    public void Play()
    {
        if (current_track == "")
        {
            Console.WriteLine("No hay una cancion cargada.");
            return;
        }

        Console.WriteLine("Reproduciendo: " + current_track);
    }

    public void Pause()
    {
        Console.WriteLine("Cancion pausada: " + current_track);
    }

    public void Stop()
    {
        Console.WriteLine("Cancion detenida: " + current_track);
    }

    public string GetCurrentTrack()
    {
        return current_track;
    }
}