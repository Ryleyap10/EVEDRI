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
        //This is the delegation key 
        public delegate void announcementHandler(string message, string recipient);
        //This is the Event key
        public event announcementHandler TodaysAnnouncement;
        public Form1()
        {
            InitializeComponent();
            //adding some Values in combobox
            cmbChoice.Items.Add("STUDENT");
            cmbChoice.Items.Add("TEACHER");
            cmbChoice.Items.Add("STAFF");
            cmbChoice.SelectedIndex = 0;
            //using the event variable to creat methods 
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
        //this is for showing the message in label show message; This one should display The recipient name and your message. 
        {
            lblShowMessage.Text = $"{recipient} {message}";
        }
        public void UpdateMessage(string message, string recipient)
        {
        //This is for showing the message in the label UpdateMessage; This one should update you that your message is sent to the recipient with the updated time.
            lblUpdateMessage.Text = $"YOUR MESSAGE HAS BEEN SENT TO {recipient} AT {DateTime.Now:t}";
        }
        public void Result(string message, string recipient)
        {
        //this is where the printing happen. every details that you entered will be paste in the listbox.
            lstResult.Items.Add($"{DateTime.Now:t} {recipient}: {message}");
        }
    }
}

