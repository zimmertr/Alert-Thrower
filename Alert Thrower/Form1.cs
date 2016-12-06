using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Alert_Thrower
{
    public partial class frmAlertThrower : Form
    {
        public frmAlertThrower()
        {
            InitializeComponent();
        }

        //helper method to prompt the user to specify the number of desired alerts to be created. 
        //basic error handling to ensure that only valid integers are provided.
        private int specifyAmount()
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("How many alerts would you like to throw?", "Alert Thrower", "1");
            int number;

            if (int.TryParse(input, out number))
            {
                if (number < 1)
                {
                    MessageBox.Show("It doesn't make sense to send " + number + " alerts. Sending 1 alert instead.");
                    return 1;
                }
                else if (number > 1000)
                {
                    MessageBox.Show("There really isn't any reason to send " + number + " alerts. Sending too many alerts will take a long time. Sending 1000 alerts instead.");
                    return 1000;
                }
                else
                {
                    return number;
                }
            }
            else if (input == "")
            {
                return 0;
            }
            else
            {
                MessageBox.Show("Your input was not recognized as a valid integer. Sending a single alert.");
                return 1;
            }

        }

        //Create an event log object
        private void Form1_Load(object sender, EventArgs e)
        {
            if (!EventLog.SourceExists(".NET Runtime"))
                EventLog.CreateEventSource(".NET Runtime", "Application");
        }

        //Throws an information alert. Indicates a significant successful operation.
        private void btnInformation_Click(object sender, EventArgs e)
        {
            int count = 1;
            int amount = specifyAmount();
            while (count <= amount)
            {
                EventLog.WriteEntry(".NET Runtime", "This is an Information Alert.", EventLogEntryType.Information);
                count += 1;
            }
        }

        //Throws a warning alert. Indicates a problem that is not immediatly significant, but that may signify conditions
        //that could cause future problems 
        private void btnWarning_Click(object sender, EventArgs e)
        {
            int count = 1;
            int amount = specifyAmount();
            while (count <= amount)
            {
                EventLog.WriteEntry(".NET Runtime", "This is a Warning Alert.", EventLogEntryType.Warning);
                count += 1;
            }
        }

        //Throws an error alert. Indicates a significant problem that the user should know about; usually a loss 
        //of functionality or data.
        private void btnError_Click(object sender, EventArgs e)
        {
            int count = 1;
            int amount = specifyAmount();
            while (count <= amount)
            {
                EventLog.WriteEntry(".NET Runtime", "This is an Error Alert.", EventLogEntryType.Error);
                count += 1;
            }
        }

        //Throws a SuccessfulAudit alert. Indicates a security event that occurs when an audited access attempt
        //is successful. 
        private void btnSuccessAudit_Click(object sender, EventArgs e)
        {
            int count = 1;
            int amount = specifyAmount();
            while (count <= amount)
            {
                EventLog.WriteEntry(".NET Runtime", "This is a Success Audit Alert.", EventLogEntryType.SuccessAudit);
                count += 1;
            }
        }

        //Throws a FailureAuidt alert. Indicates a security event that occurs when an audited access attempt fails.
        private void btnFailureAudit_Click(object sender, EventArgs e)
        {
            int count = 1;
            int amount = specifyAmount();
            while (count <= amount)
            {
                EventLog.WriteEntry(".NET Runtime", "This is a Failure Audit Alert.", EventLogEntryType.FailureAudit);
                count += 1;
            }
        }
    }
}
