using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Timers;

namespace JG.RecycleBinRobot.Core
{
    internal class Helper
    {
        [DllImport("Shell32.dll")]
        static extern int SHEmptyRecycleBin(IntPtr hwnd, string pszRootPath, Constants.RecycleFlag dwFlags);

        System.Timers.Timer _timer;
        public Helper()
        {
            _timer = new System.Timers.Timer(Constants.MINUTES) { AutoReset = false };
            _timer.Elapsed += TimerElapsed;
        }
        /// <summary>
        /// Start the robot timer to run as a Windows Service for each X minutes
        /// </summary>
        public void Start() => _timer.Start();
        /// <summary>
        /// Stop the robot timer
        /// </summary>
        public void Stop() => _timer.Stop();
        #region Private Methods
        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            int minutes = Constants.MINUTES;
            var timeToStart = Constants.TIME_TO_START;
            var timeToEnd = Constants.TIME_TO_END;

            while (true)
            {
                if (CheckIfRobotCanRun(timeToStart.TimeOfDay, timeToEnd.TimeOfDay))
                {
                    RecycleBin();
                    Thread.Sleep(60000 * minutes);
                }
                else
                    Thread.Sleep(60000 * minutes);
            }
        }
        private void RecycleBin()
        {
            SHEmptyRecycleBin(IntPtr.Zero, null, Constants.RecycleFlag.SHERB_NOSOUND | Constants.RecycleFlag.SHERB_NOCONFIRMATION);
        }

        private static bool CheckIfRobotCanRun(TimeSpan timeToStart, TimeSpan timeToEnd)
        {
            // convert datetime to a TimeSpan
            TimeSpan now = DateTime.Now.TimeOfDay;
            // see if start comes before end
            if (timeToStart < timeToEnd)
                return timeToStart <= now && now <= timeToEnd;
            // start is after end, so do the inverse comparison
            return !(timeToEnd < now && now < timeToStart);
        }
        #endregion
    }
}
