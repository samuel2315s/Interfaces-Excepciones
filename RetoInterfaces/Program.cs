using System;

class Program
{
    static void Main(string[] args)
    {
        MusicPlayer reproductor = new MusicPlayer();

        Console.WriteLine("=== REPRODUCTOR DE MUSICA ===");

        Console.WriteLine("Pista actual: " + reproductor.GetCurrentTrack());

        reproductor.LoadTrack("Cancion 1");
        reproductor.Play();
        reproductor.Pause();
        reproductor.Play();
        reproductor.Stop();

        Console.WriteLine("Pista actual: " + reproductor.GetCurrentTrack());

        Console.WriteLine("\n=== SEGUNDA PISTA ===");

        reproductor.LoadTrack("Cancion 2");
        reproductor.Play();
        reproductor.Pause();
        reproductor.Stop();

        Console.WriteLine("Pista actual: " + reproductor.GetCurrentTrack());
    }
}