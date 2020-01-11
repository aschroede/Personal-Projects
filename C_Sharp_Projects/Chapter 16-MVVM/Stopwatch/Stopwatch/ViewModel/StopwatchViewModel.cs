using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;
using Stopwatch.Model;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Stopwatch.ViewModel
{
    class StopwatchViewModel : INotifyPropertyChanged
    {
        private bool running;
        public bool Running 
        {
            get 
            { 
                return stopWatch.Running; 
            }
            set
            {
                running = value;
                NotifyPropertyChanged();
            }
        }
        private int seconds;
        public int Seconds 
        {
            get
            {
                return this.seconds;
            }
            set
            {
                this.seconds = value;
                NotifyPropertyChanged();
            }
        }

        private int minutes;
        public int Minutes
        {
            get
            {
                return this.minutes;
            }
            set
            {
                this.minutes = value;
                NotifyPropertyChanged();
            }
        }

        private int hours;
        public int Hours
        {
            get
            {
                return this.hours;
            }
            set
            {
                this.hours = value;
                NotifyPropertyChanged();
            }
        }
        private int lapSeconds;
        public int LapSeconds
        {
            get
            {
                return this.lapSeconds;
            }
            set
            {
                this.lapSeconds = value;
                NotifyPropertyChanged();
            }
        }
        private int lapMinutes;
        public int LapMinutes
        {
            get
            {
                return this.lapMinutes;
            }
            set
            {
                this.lapMinutes = value;
                NotifyPropertyChanged();
            }
        }
        private int lapHours;
        public int LapHours
        {
            get
            {
                return this.lapHours;
            }
            set
            {
                this.lapHours = value;
                NotifyPropertyChanged();
            }
        }

        private StopwatchModel stopWatch;
        private DispatcherTimer dispatcherTimer;

        public event PropertyChangedEventHandler PropertyChanged;

        public StopwatchViewModel()
        {
            stopWatch = new StopwatchModel();
            dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += DispatcherTimer_Tick;
            dispatcherTimer.Interval = new TimeSpan(100000);
            stopWatch.LapTimeUpdated += StopWatch_LapTimeUpdated;
        }

        private void StopWatch_LapTimeUpdated(object sender, LapEventArgs e)
        {
            TimeSpan? dateTime = e.LapTime;
            if (dateTime.HasValue)
            {
                LapSeconds = (int)dateTime.Value.Seconds;
                LapMinutes = (int)dateTime.Value.Minutes;
                LapHours = (int)dateTime.Value.Hours;
            }
        }

        bool _lastRunning;
        private void DispatcherTimer_Tick(object sender, EventArgs e)
        {
            if(_lastRunning != Running)
            {
                _lastRunning = Running;
                NotifyPropertyChanged("Running");
            }
            TimeSpan? dateTime = stopWatch.Elapsed;
            if (dateTime.HasValue)
            {
                Seconds = (int)dateTime.Value.Seconds;
                Minutes = (int)dateTime.Value.Minutes;
                Hours = (int)dateTime.Value.Hours;
            }
        }

        internal void StartTimer()
        {
            stopWatch.Start();
            dispatcherTimer.Start();
            Running = true;
        }

        internal void StopTimer()
        {
            stopWatch.Stop();
            dispatcherTimer.Stop();
            Running = false;
        }

        internal void ResetTimer()
        {
            if(stopWatch.Running)
            {
                stopWatch.Reset();
                stopWatch.Start();
                dispatcherTimer.Start();
                LapSeconds = 0;
                LapMinutes = 0;
                LapHours = 0;
            }
            else
            {
                stopWatch.Reset();
                Seconds = 0;
                Minutes = 0;
                Hours = 0;
                LapSeconds = 0;
                LapMinutes = 0;
                LapHours = 0;
            }
                
        }

        internal void Lap()
        {
            stopWatch.Lap();
        }

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
