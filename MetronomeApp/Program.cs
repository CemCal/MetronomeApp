using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetronomeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Metronome metronome = new Metronome();
            Listener listener = new Listener();

            metronome.Tick += listener.Notificate;

            for(int i = 0; i < 5; i++)
            {
                System.Threading.Thread.Sleep(3000);
                metronome.FireTickEvent();
            }
        }
    }
}
