using System;
using System.Threading;

namespace MyProgram
{
    class Program
    {
        static void Main()
        {
           {
            int duration = 200; // Duration of notes and rests in milliseconds

            // Frequencies for the notes (in hertz)
            int e = 330;
            int eLow = 165;
            int c = 261;
            int d = 294;
            int g = 392;
            int G = 196;
            int a = 440;
            int A = 220;
            int b = 494;
            int f = 349;
            int F = 175;
            int E = 659;



            int[] melody = {e, e, 0, e, 0, c, e, 0,
                        g, 0, 0, 0, G, 0, 0, 0,
                        c, 0, 0, g, 0, 0, e, 0,
                        0, a, 0, b, 0, A, A, 0,
                        a, a, b, 0, a, g, e, g,
                        a, 0, f, g, 0, e, 0, c,
                        d, b, 0, 0, G, F, E, 0, 0, eLow, 0, 0};

            // Play the melody
            foreach (int note in melody)
            {
                if (note != 0)
                {
                    Console.Beep(note, duration);
                }
                else
                {
                    Thread.Sleep(duration);
                }
            }
            }
        }
    }
}