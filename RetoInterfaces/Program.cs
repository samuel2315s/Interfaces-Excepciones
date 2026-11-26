using System;

class Program
{
    static void Main(string[] args)
    {
        MusicPlayer reproductor = new MusicPlayer();

        Console.WriteLine("=== REPRODUCTOR DE MUSICA ===");

        reproductor.LoadTrack("Mi primera cancion");
        reproductor.Play();
        reproductor.Pause();
        reproductor.Play();
        reproductor.Stop();

        Console.WriteLine("Cancion actual: " +
            reproductor.GetCurrentTrack());

        Console.WriteLine("\n=== SEGUNDA CANCION ===");

        reproductor.LoadTrack("Mi segunda cancion");
        reproductor.Play();
        reproductor.Pause();
        reproductor.Stop();

        Console.WriteLine("Cancion actual: " +
            reproductor.GetCurrentTrack());
    }
}