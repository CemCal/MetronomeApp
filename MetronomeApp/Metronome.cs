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
                Tick();
      
        }

        
    }
}
