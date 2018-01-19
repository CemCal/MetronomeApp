using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetronomeApp
{

    public delegate void DG_Metronome();

    public class Metronome
    {
        public event DG_Metronome Tick;

        public void FireTickEvent()
        {
            for(int i = 0; i < 5; i++)
            {
                Tick();
                System.Threading.Thread.Sleep(3000);
            }
            
            
        }

        
    }
}
