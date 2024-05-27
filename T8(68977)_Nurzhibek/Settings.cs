using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T8_68977__Nurzhibek
{
    static class Settings
    {
        static private double second = 100;
        static public double seconds = second;

        public static int score = 0;

        public static List<string> Words = new List<string>();
        public static List<string> Sentences = new List<string>();
        public static List<string> Both = new List<string>();

        public enum GameMode
        {
            Words, Sentences, Both 
        }

        static public GameMode mode;

        static public void AddToTheLists()
        {
            Words.Clear();
            Sentences.Clear();
            Both.Clear();
            AddToLists();
        }

        static private void AddToLists()
        {
            FileStream fs = new FileStream("AllWordsAndSentences.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            while(!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string[] splitted = line.Split(' ');

                Both.Add(line.Trim());
                if (splitted.Length == 1)
                {
                    Words.Add(line.Trim());
                }
                else
                {
                    Sentences.Add(line.Trim());
                }
            }
        }

        static public void ResetSeconds()
        {
            seconds = second;
        }
    }
}
