using System;
using System.Drawing;
using System.Windows.Forms;

namespace MouseController
{
    public partial class MainForm : Form
    {
        InitializeConstans initializeConstans = new InitializeConstans();
        private bool _existsApplicationStartError = false;

        AnalyzeImages analyze = new AnalyzeImages();
        WorkProfile profile = new WorkProfile();

        Area area = new Area();
        Area compareArea = new Area();

        WorkAgent _agent;

        System.Timers.Timer _resultLabelTimer;
        public MainForm()
        {
            InitializeComponent();
            InitializeConstans();
            WriteSampleData();
        }

        private void InitializeConstans()
        {
            try
            {
                InitializeConstans initializeConstans = new InitializeConstans();
            }
            catch (Exception ex)
            {
                _existsApplicationStartError = true;
            }
        }
        public void WriteSampleData()
        {
            Area area = new Area
            {
                Bitmap = analyze.AddScreenShotToArea(new Area
                {
                    StartPositionX = 10,
                    StartPositionY = 10,
                    Height = 100,
                    Width = 300
                }),
                StartPositionX = 10,
                StartPositionY = 10,
                Height = 100,
                Width = 300,
                Name = "Obszar przykladowy",
                ActivityName = "Aktywnosc 1"
            };
            profile.Areas.Add(area);

            Area area2 = new Area
            {
                Bitmap = analyze.AddScreenShotToArea(new Area
                {
                    StartPositionX = 300,
                    StartPositionY = 300,
                    Height = 200,
                    Width = 200
                }),
                StartPositionX = 300,
                StartPositionY = 300,
                Height = 200,
                Width = 200,
                Name = "Inny obszar"
            };
            profile.Areas.Add(area2);


            Activity act1 = new Activity { Name = "Aktywnosc 1" };
            Activity act2 = new Activity { Name = "Aktywnosc 2" };

            ClickAction action1 = new ClickAction { Name = "Kliknij", DelayTime = 1000, Active = true };
            ClickAction action2 = new ClickAction { Name = "Kliknij", DelayTime = 1000, Active = true };
            MoveAction action3 = new MoveAction(area) { Name = "Przesun mysz", DelayTime = 2000, Active = true };

            act1.AddAction(action1);
            act1.AddAction(action3);
            act2.AddAction(action2);

            profile.Activities.Add(act1);
            profile.Activities.Add(act2);

        }

        #region Make Form Movable

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void toolStrip1_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void mainFormPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        #endregion

        private void openButton_Click(object sender, EventArgs e)
        {
            JsonWorkProfileSerialization serializer = new JsonWorkProfileSerialization();
            WorkProfile deserializedProfile = serializer.DeserializeProfile();

            if (deserializedProfile != null)
            {
                profile = deserializedProfile;
            }
        }
        private void resetButton_Click(object sender, EventArgs e)
        {
            profile = new WorkProfile();
        }
        private void areasManagerButton_Click(object sender, EventArgs e)
        {
            profile.BeginEdit();

            using (AreasManagerForm form = new AreasManagerForm(profile))
            {
                form.ShowDialog();
                if (form.DialogResult == DialogResult.OK)
                {
                    profile.EndEdit();
                }
                else if (form.DialogResult == DialogResult.Cancel)
                {
                    profile.CancelEdit();
                }
            }
        }
        private void activitiesManagerButton_Click(object sender, EventArgs e)
        {
            profile.BeginEdit();

            using (ActivitiesManagerForm form = new ActivitiesManagerForm(profile))
            {
                form.ShowDialog();
                if (form.DialogResult == DialogResult.OK)
                {
                    profile.EndEdit();
                }
                else if (form.DialogResult == DialogResult.Cancel)
                {
                    profile.CancelEdit();
                }
            }
        }
        private void actionSettingsButton_Click(object sender, EventArgs e)
        {
            profile.BeginEdit();

            using (ConditionsManagerForm form = new ConditionsManagerForm(profile))
            {
                form.ShowDialog();
                if (form.DialogResult == DialogResult.OK)
                {
                    profile.EndEdit();
                }
                else if (form.DialogResult == DialogResult.Cancel)
                {
                    profile.CancelEdit();
                }
            }
        }
        private void runButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (_agent == null)
                {
                    _agent = new WorkAgent(profile);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while starting the VatStatusChecker service: " + ex.Message);
            }

            try
            {
                _resultLabelTimer = new System.Timers.Timer();
                _resultLabelTimer.Interval = 500;
                _resultLabelTimer.Elapsed += _timer_Elapsed;
                _resultLabelTimer.Start();
            }
            catch (Exception ex)
            {
                throw new Exception("An exception occurred while initializing the LabelTimer: " + ex.Message);
            }

            ChangeButtonsStatsus(false);
        }

        void _timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            resultLabel.Text = _agent.LastAction;
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            if (_resultLabelTimer != null)
            {
                _resultLabelTimer.Elapsed -= _timer_Elapsed;
                _resultLabelTimer.Stop();
                _resultLabelTimer.Dispose();
            }
            if (_agent != null)
            {
                _agent.Dispose();
                _agent = null;
            }
            ChangeButtonsStatsus(true);
        }
        public void ChangeButtonsStatsus(bool state)
        {
            openButton.Enabled = state;
            resetButton.Enabled = state;
            areasManagerButton.Enabled = state;
            activitiesManagerButton.Enabled = state;
            conditionsManagerButton.Enabled = state;
            runButton.Enabled = state;
            closeButton.Enabled = state;

            if (state == true)
            {
                openButton.BackColor = Color.RoyalBlue;
                resetButton.BackColor = Color.FromArgb(255, 192, 0, 0);
                areasManagerButton.BackColor = Color.ForestGreen;
                activitiesManagerButton.BackColor = Color.Orange;
                conditionsManagerButton.BackColor = Color.RoyalBlue;
                runButton.BackColor = Color.FromArgb(255, 192, 0, 0);
                closeButton.BackColor = Color.Black;
            }
            else
            {
                openButton.BackColor = Color.Gray;
                resetButton.BackColor = Color.Gray;
                areasManagerButton.BackColor = Color.Gray;
                activitiesManagerButton.BackColor = Color.Gray;
                conditionsManagerButton.BackColor = Color.Gray;
                runButton.BackColor = Color.Gray;
                closeButton.BackColor = Color.Gray;
            }

        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            using (MessageBoxForm form = new MessageBoxForm())
            {
                DialogResult result = form.ShowDialog();

                if (result == DialogResult.No)
                {
                    this.Dispose();
                }
                else if (result == DialogResult.Yes)
                {
                    JsonWorkProfileSerialization serializer = new JsonWorkProfileSerialization();
                    serializer.SaveJson(serializer.SerializeProfile(profile));
                    this.Dispose();
                }
            }
        }

        #region Mouse Hover Events

        private void openButton_MouseHover(object sender, EventArgs e)
        {
            toolTipLabel.Text = "Open existing Mouse Controller work profile";
        }

        private void openButton_MouseLeave(object sender, EventArgs e)
        {
            toolTipLabel.Text = "";
        }

        private void resetButton_MouseHover(object sender, EventArgs e)
        {
            toolTipLabel.Text = "Clean work profile";
        }

        private void resetButton_MouseLeave(object sender, EventArgs e)
        {
            toolTipLabel.Text = "";
        }

        private void actionSettingsButton_MouseHover(object sender, EventArgs e)
        {
            toolTipLabel.Text = "Open Conditions Manager";
        }

        private void actionSettingsButton_MouseLeave(object sender, EventArgs e)
        {
            toolTipLabel.Text = "";
        }

        private void runButton_MouseHover(object sender, EventArgs e)
        {
            toolTipLabel.Text = "Run";
        }

        private void runButton_MouseLeave(object sender, EventArgs e)
        {
            toolTipLabel.Text = "";
        }

        private void stopButton_MouseHover(object sender, EventArgs e)
        {
            toolTipLabel.Text = "Stop current work process";
        }

        private void stopButton_MouseLeave(object sender, EventArgs e)
        {
            toolTipLabel.Text = "";
        }

        private void closeButton_MouseHover(object sender, EventArgs e)
        {
            toolTipLabel.Text = "Close the application";
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            toolTipLabel.Text = "";
        }
        private void activitiesManagerButton_MouseLeave(object sender, EventArgs e)
        {
            toolTipLabel.Text = "";
        }

        private void activitiesManagerButton_MouseHover(object sender, EventArgs e)
        {
            toolTipLabel.Text = "Open Activities Manager";
        }

        private void areasManagerButton_MouseHover(object sender, EventArgs e)
        {
            toolTipLabel.Text = "Open Areas Manager";
        }

        private void areasManagerButton_MouseLeave(object sender, EventArgs e)
        {
            toolTipLabel.Text = "";
        }





        #endregion

        private void MainForm_Shown(object sender, EventArgs e)
        {
            if (_existsApplicationStartError)
            {
                MessageBox.Show("Some error occurred during the application start process. Some elements can not work correctly", "StartProblem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            AllocateFont();
        }
        private void AllocateFont()
        {
            FontLoader fontLoader = new FontLoader();

            fontLoader.AllocateFont(Constans.myFontFamily, this.toolTipLabel, 9);
            fontLoader.AllocateFont(Constans.myFontFamily, this.resultLabel, 9);
        }
    }


}
