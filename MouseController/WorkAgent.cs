using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseController
{
    class WorkAgent : IDisposable
    {
        WorkProfile profile;

        AnalyzeImages analyze = new AnalyzeImages();
        int resultCounter = 0;
        
        private System.Timers.Timer _timer;
        private int _secondsInterval = Properties.Settings.Default.SecondsInterval;
        public bool _isNotRunning = true;


        public WorkAgent(WorkProfile profile)
        {
            try
            {
                _timer = new System.Timers.Timer();
                _timer.Interval = _secondsInterval;
                _timer.Elapsed += _timer_Elapsed;
                _timer.Start();
            }
            catch (Exception ex)
            {
                throw new Exception("An exception occurred while initializing the Timer: " + ex.Message);
            }

            try
            {
                if(profile != null)
                {
                    this.profile = profile;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Starting work with your profile failed: " + ex.Message);
            }
        }

        void _timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Run();
        }
        public void Run()
        {
            if (_isNotRunning)
            {
                System.ComponentModel.BackgroundWorker backgroungWorker = new BackgroundWorker();
                backgroungWorker.DoWork += backgroungWorker_DoWork;
                backgroungWorker.RunWorkerCompleted += backgroungWorker_RunWorkerCompleted;
                backgroungWorker.RunWorkerAsync();

                _isNotRunning = false;

            }
        }
        void backgroungWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            foreach(Area area in profile.Areas.Where(t=>t.ActivityName != null || t.ActivityName != String.Empty))
            {
                if(analyze.CompareAreaWithScreen(area))
                {
                    Activity currentActivity = (Activity)profile.Activities.Where(t => t.Name == area.ActivityName).First();
                    //ToDO
                }
            }
        }

        
        void backgroungWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //resultLabel.Text = String.Format("Result: {0} task completed", resultCounter + 1);
        }

        private bool disposed = false;

        public void Dispose()
        {


            Dispose(true);
        }
        public void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    if (_timer != null)
                    {
                        _timer.Elapsed -= _timer_Elapsed;
                        _timer.Stop();
                        _timer.Dispose();
                    }
                }
                disposed = true;
            }
        }
    }
}
