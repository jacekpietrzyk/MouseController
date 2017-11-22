using System;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace MouseController
{
    class WorkAgent : IDisposable
    {
        WorkProfile profile;

        AnalyzeImages analyze = new AnalyzeImages();
        int resultCounter = 0;
        public string WorkLog { get; set; } = "";
        public string LastAction { get; set; } = "";

        private StringBuilder builder = new StringBuilder();

        private System.Timers.Timer _timer;
        private int _secondsInterval = Properties.Settings.Default.SecondsInterval;
        public bool _isNotRunning = true;

        public WorkAgent(WorkProfile profile)
        {
            try
            {
                _timer = new System.Timers.Timer();
                _timer.Interval = _secondsInterval * 1000;
                _timer.Elapsed += _timer_Elapsed;
                _timer.Start();
            }
            catch (Exception ex)
            {
                throw new Exception("An exception occurred while initializing the Timer: " + ex.Message);
            }

            try
            {
                if (profile != null)
                {
                    this.profile = profile;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Starting work with your profile failed: " + ex.Message);
            }
            UpdateLogs("Work started");
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
            
            foreach (Area area in profile.Areas.Where(t => t.ActivityName != null || t.ActivityName != String.Empty))
            {
                if (analyze.CompareAreaWithScreen(area) && profile.Activities.Where(t => t.Name == area.ActivityName).Any())
                {
                    resultCounter += 1;
                    UpdateLogs("Area " + area.Name + " matched (Total matches: " + resultCounter + ").");

                    Activity currentActivity = (Activity)profile.Activities.Where(t => t.Name == area.ActivityName).First();

                    foreach (IAction action in currentActivity.GetActions().Where(t => t.Active == true))
                    {
                        action.Execute();
                        UpdateLogs("  Action \"" + action.Name + "\" executed.");
                    }
                }
            }
        }
        

        public void UpdateLogs(string message)
        {
            LastAction = DateTime.Now.TimeOfDay.ToString("hh\\:mm\\:ss") + ": " + message;
            builder.AppendLine(LastAction);
            WorkLog = builder.ToString();
            
        }
        
        void backgroungWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            _isNotRunning = true;
            try
            {
                if (e.Error != null)
                {
                    MessageBox.Show("An Error occurred while running background worker");
                }
                System.ComponentModel.BackgroundWorker backgroundWorker = (System.ComponentModel.BackgroundWorker)sender;
                backgroundWorker.DoWork -= backgroungWorker_DoWork;
                backgroundWorker.RunWorkerCompleted -= backgroungWorker_RunWorkerCompleted;
                backgroundWorker.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error in the function backgroungWorker_RunWorkerCompleted: " + ex.Message);
            }
        }
        private bool disposed = false;

        public void Dispose()
        {
            UpdateLogs("Work stopped: " + resultCounter + " areas matched.");
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
