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
        int number;

        public frmAlertThrower()
        {
            InitializeComponent();
        }

        private int specifyAmount()
        {
            number = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("How Many?", "How many alerts would you like to throw?", "1"));
            return number;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!EventLog.SourceExists("logger"))
                EventLog.CreateEventSource("logger", "Application");
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            int count = 1;
            int amount = specifyAmount();
            while (count <= amount)
            {
                EventLog.WriteEntry("logger", "This is an Information Alert.", EventLogEntryType.Information);
                count += 1;
            }
        }

        private void btnWarning_Click(object sender, EventArgs e)
        {
            int count = 1;
            int amount = specifyAmount();
            while (count <= amount)
            {
                EventLog.WriteEntry("logger", "This is a Warning Alert.", EventLogEntryType.Warning);
                count += 1;
            }
        }

        private void btnError_Click(object sender, EventArgs e)
        {
            int count = 1;
            int amount = specifyAmount();
            while (count <= amount)
            {
                EventLog.WriteEntry("logger", "This is an Error Alert.", EventLogEntryType.Error);
                count += 1;
            }
        }

        private void btnSuccessAudit_Click(object sender, EventArgs e)
        {
            int count = 1;
            int amount = specifyAmount();
            while (count <= amount)
            {
                EventLog.WriteEntry("logger", "This is a Success Audit Alert.", EventLogEntryType.SuccessAudit);
                count += 1;
            }
        }

        private void btnFailureAudit_Click(object sender, EventArgs e)
        {
            int count = 1;
            int amount = specifyAmount();
            while (count <= amount)
            {
                EventLog.WriteEntry("logger", "This is a Failure Audit Alert.", EventLogEntryType.FailureAudit);
                count += 1;
            }
        }
    }
}
