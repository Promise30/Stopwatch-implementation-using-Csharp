using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch_Project
{
    internal class StopwatchClass
    {
        private DateTime _startWatch;
        private DateTime _endWatch;
        private bool _isRunning;

        public void Start()
        {
            
            if (_isRunning)
                throw new InvalidOperationException("StopWatch is already running.");
            _isRunning = true;
            _startWatch = DateTime.Now;
        }
        public void Stop()
        {
            if (!_isRunning)
                throw new InvalidOperationException("StopWatch is not running.");
            _isRunning= false;
            _endWatch = DateTime.Now;
        }
        public TimeSpan GetDuration()
        { 
            return _endWatch - _startWatch;
        }
    }
}
