using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace XAY_DUNG_LOP_STOPWATCH
{
    class StopWatch
    {
        private DateTime _startTime;
        private DateTime _endTime;

        public DateTime StartTime { get => _startTime; set => _startTime = value; }
        public DateTime EndTime { get => _endTime; set => _endTime = value; }

        public StopWatch()
        {
            StartTime = DateTime.Now;
        }

        public void Start()
        {
            StartTime = DateTime.Now;
        }

        public void Stop()
        {
            EndTime = DateTime.Now;
        }

        public int GetElapsedTime()
        {
            return (int)(EndTime - StartTime).TotalMilliseconds;
        }
    }
}
