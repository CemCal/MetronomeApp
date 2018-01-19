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


            metronome.FireTickEvent();
        }
    }
}
