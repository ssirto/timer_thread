using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es1thread
{
    internal class Timer
    {
        public int RemainingTime { get; private set; }
        private Timer timer;

        public event Action<int> TimeUpdated; // Evento per aggiornare il tempo
        public event Action TimeExpired;     // Evento per notificare la scadenza

        public Timer()
        {
            timer = new Timer();
            timer.RemainingTime = 1000; // Aggiorna ogni secondo
            Timer Timer_Tick;
        }

        public void Start(int secondi, int tempoRimanente)
        {
            tempoRimanente = secondi;
            timer.Start();
        }

        public void Pause()
        {
            timer.Pause();
        }

        public void Resume()
        {
            timer.Resume();
        }
    }
}
