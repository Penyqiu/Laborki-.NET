using System;
using System.Diagnostics;
using System.Media;
using System.Windows.Forms;

namespace Zad1
{
    public partial class Form1 : Form
    {
        private DateTime _alarmTime;
        
        public Form1()
        {
            InitializeComponent();
            
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM/dd/yyyy hh:mm:ss";  
            
            this.StartUpdateTimer();
        }

        private void StartUpdateTimer()
        {
            var updateTimer = new Timer { Interval = 1 * 1000 };
            updateTimer.Tick += UpdateDateAndTime_Tick;
            updateTimer.Start();
        }

        private void UpdateDateAndTime_Tick(object sender, EventArgs e)
        {
            var dt = DateTime.Now;
            var dtString = dt.ToString("MM/dd/yyyy HH:mm:ss");
            
            this.dateTime.Text = dtString;
            
            if (DateTime.Now >= this._alarmTime)
            {
                SystemSounds.Beep.Play();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this._alarmTime = dateTimePicker1.Value;
        }
    }
}