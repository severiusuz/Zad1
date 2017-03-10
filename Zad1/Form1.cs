using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zad1
{
    public partial class Form1 : Form
    {
        private DateTime _alarm;

        public Form1()
        {
            InitializeComponent();
        }

        private void OnCloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void timer1_TickAsync(object sender, EventArgs e)
        {
            var dateNow = DateTime.Now;
            DisplayBox.Text = dateNow.ToString();
            if (dateNow.TrimMilliseconds() == _alarm.TrimMilliseconds())
            {
                await AlarmOccurred();
            }
        }

        private async void setAlarm_MouseClick(object sender, MouseEventArgs e)
        {
            await SetAlarmConfirmed();
        }

        private async Task AlarmOccurred()
        {
            alarmBox.Text = "ALARM";
            alarmBox.BackColor = Color.LawnGreen;
            await Task.Delay(2000);
            alarmBox.Text = "";
            alarmBox.BackColor = Color.White;
        }

        private async Task SetAlarmConfirmed()
        {
            _alarm = dateTimePicker1.Value;
            setAlarm.Text = "Alarm Set";
            await Task.Delay(2000);
            setAlarm.Text = "Set Alarm";
        }
    }
}
