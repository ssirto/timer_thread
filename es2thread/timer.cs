using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es2thread
{
    internal class Timer
    {

        public int RemainingTime { get; private set; }
        private Timer timer;

        public event Action<int> TimeUpdated;
        public event Action TimeExpired;

        public Timer(int intervalInMilliseconds = 1000)
        {
            timer = new Timer();
            timer.Interval = intervalInMilliseconds;
        }

        public void SetInterval(int intervalInMilliseconds)
        {
            timer.SetInterval = intervalInMilliseconds;
        }

        public void Start(int timeInSeconds)
        {
            RemainingTime = timeInSeconds;
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
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (RemainingTime > 0)
            {
                RemainingTime--;
                TimeUpdated?.Invoke(RemainingTime);
            }
            else
            {
                timer.Stop();
                TimeExpired?.Invoke();
            }
        }
    }

    }
}
