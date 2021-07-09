using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;
using System.Threading;

namespace consolenotes
{
   public class Main
    {
        public static List<string> options = new List<string> { "notes","chords","ear" };

        public static List<string> notes = new List<string> {
            "C",
            "G",
            "D",
            "A",
            "E",
            "B",
            "Gb/F#",
            "Db",
            "Ab",
            "Eb",
            "Bb",
            "F"
        };

        public static List<string> mods = new List<string> {
            "Major",
            "Minor",
            "7",
            "5",
            "maj7",
            "m7",
/*            "dim",
            "dim7",
            "aug",
            "sus2",
            "sus4",
            "7sus4"*/
        };

        public static int iterations = 20;

        public string prev;

        public void timer(int seconds)
        {
            Thread.Sleep(seconds * 1000);
        }

        public string generateChord(List<string> note, List<string> mod)
        {
            var random = new Random();
            string result = notes[random.Next(note.Count)].ToString() + mod[random.Next(mod.Count)].ToString();
            return result;
        }

        public string generateNote(List<string> note)
        {
            var random = new Random();
            string result = (random.Next(6)+1).ToString() + notes[random.Next(note.Count)].ToString();
            return result;
        }

        public void Run()
        {
            Console.WriteLine("Choose setting:");
            Console.WriteLine("[1] notes   [2] chords   [3] ear");
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    for (int i = 0; i < iterations; i++)
                    {
                        timer(6);
                        Console.WriteLine(generateNote(notes));
                    }
                    break;
                case 2:
                    for (int i = 0; i < iterations; i++)
                    {
                        timer(9);
                        Console.WriteLine(generateChord(notes, mods));
                    }
                    break;
                default:
                    break;
            };
            Console.WriteLine("Finished");
        }
    }
}
