using System;

public class MusicPlayer : IMediaPlayer
{
    private string current_track = "Sin pista";

    public void Play()
    {
        Console.WriteLine("Reproduciendo: " + current_track);
    }

    public void Pause()
    {
        Console.WriteLine("Pista en pausa");
    }

    public void Stop()
    {
        Console.WriteLine("Reproducción detenida");
        current_track = "Sin pista";
    }

    public string GetCurrentTrack()
    {
        return current_track;
    }

    public void LoadTrack(string track_name)
    {
        current_track = track_name;
        Console.WriteLine("Pista cargada: " + current_track);
    }
}