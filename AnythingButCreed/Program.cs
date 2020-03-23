using System;
using System.Collections.Generic;
using System.Linq;

namespace AnythingButCreed
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Song> goodSongs = new List<Song>();
            List<Song> allSongs = new List<Song>(12);

            Song mrBlueSky = new Song("ELO", "Mr. Blue Sky");
            Song bohemianRhapsody = new Song("Queen", "Bohemian Rhapsody");
            Song balls = new Song("AC/DC", "She's Got Balls");
            Song battery = new Song("Metallica", "Battery");
            Song hammerSmashed = new Song("Cannibal Corpse", "Hammer Smashed Face");
            Song hotForTeacher = new Song("Van Halen", "Hot For Teacher");
            Song myMichelle = new Song("Guns N' Roses", "My Michelle");
            Song wideOpen = new Song("Creed", "With Arms Wide Open");
            Song technicalDifficulties = new Song("Racer X", "Technical Difficulties");
            Song higher = new Song("Creed", "Higher");
            Song funkOut = new Song("Extreme", "Get The Funk Out");
            Song toxicity = new Song("System of A Down", "Toxicity");

            allSongs.Add(mrBlueSky);
            allSongs.Add(bohemianRhapsody);
            allSongs.Add(balls);
            allSongs.Add(battery);
            allSongs.Add(hammerSmashed);
            allSongs.Add(hotForTeacher);
            allSongs.Add(myMichelle);
            allSongs.Add(wideOpen);
            allSongs.Add(technicalDifficulties);
            allSongs.Add(higher);
            allSongs.Add(funkOut);
            allSongs.Add(toxicity);

            var filteredSongs = allSongs.Where(x => x.Artist != "Creed");

            goodSongs.AddRange(filteredSongs);

            foreach (var song in goodSongs)
            {
                Console.WriteLine($"{song.Artist}: {song.Name}");
            }
        }
    }
}
