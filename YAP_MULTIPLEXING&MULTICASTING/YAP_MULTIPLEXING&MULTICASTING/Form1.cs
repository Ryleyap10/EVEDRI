using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YAP_MULTIPLEXING_MULTICASTING
{
    public partial class Form1 : Form
    {
        public delegate void announcementHandler(string message, string recipient);
        public event announcementHandler TodaysAnnouncement;
        public Form1()
        {
            InitializeComponent();
            cmbChoice.Items.Add("STUDENT");
            cmbChoice.Items.Add("TEACHER");
            cmbChoice.Items.Add("STAFF");
            cmbChoice.SelectedIndex = 0;

            TodaysAnnouncement += ShowMessage;
            TodaysAnnouncement += UpdateMessage;
            TodaysAnnouncement += Result;

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string mes = txtYourMessage.Text;
            string rec = cmbChoice.SelectedItem.ToString();

            if (TodaysAnnouncement != null)
            {
                TodaysAnnouncement(mes, rec);
            }
        }
        public void ShowMessage(string message, string recipient)
        {
            lblShowMessage.Text = $"{recipient} {message}";
        }
        public void UpdateMessage(string message, string recipient)
        {
            lblUpdateMessage.Text = $"YOUR MESSAGE HAS BEEN SENT TO {recipient} AT {DateTime.Now:t}";
        }
        public void Result(string message, string recipient)
        {
            lstResult.Items.Add($"{DateTime.Now:t} {recipient}: {message}");
        }
    }
}
