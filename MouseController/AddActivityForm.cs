﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseController
{
    public partial class AddActivityForm : Form
    {
        private string defaultName = "Type a name here";
        public Activity NewActivity { get; set; }
        private ObservableCollection<IActivity> activities = new ObservableCollection<IActivity>();

        public AddActivityForm(ObservableCollection<IActivity> activities)
        {
            InitializeComponent();
            this.activities = activities;
            nameTextBox.Text = defaultName;
        }


        #region Make Form Movable

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        
        private void addActivityPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        #endregion


        private void closeButtonPictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.Cancel;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.Cancel;
        }

        private void addButton_Click(object sender, EventArgs e)
        {

            if (IsValidName(nameTextBox.Text))
            {
                NewActivity = new Activity { Name = nameTextBox.Text };
                activities.Add(NewActivity);

                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("New activity name is invalid");
            }

        }

        public bool IsValidName(string newName)
        {
            if(activities.Where(t => t.Name == newName).Any())
            {
                MessageBox.Show("New activity name already exists on the list");
                return false;
            }
            if(newName == "" || newName == defaultName)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (IsValidName(nameTextBox.Text))
            {
                addButton.Enabled = true;
            }
            else
            {
                addButton.Enabled = false;
            }
        }

        
    }
}