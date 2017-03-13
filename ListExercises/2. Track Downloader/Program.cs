using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.Track_Downloader
{
    class Program
    {
        static void Main()
        {
            var blacklist = Console.ReadLine().Split();         
            var downloadedTrack = new List<string>();

            var music = Console.ReadLine();

            
            while (music != "end")
            {
                var isBlackListedWord = false;
                foreach (var blackListedWord in blacklist)
                {
                    if (music.Contains(blackListedWord))
                    {
                        isBlackListedWord = true;
                        break;
                    }
                }

                if (!isBlackListedWord)
                {
                    downloadedTrack.Add(music);
                }
                music = Console.ReadLine();
            }

            downloadedTrack.Sort();

            foreach (var track in downloadedTrack)
            {
                Console.WriteLine(track);
            }
        }
    }
}
