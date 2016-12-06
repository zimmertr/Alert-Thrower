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

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!EventLog.SourceExists("logger"))
                EventLog.CreateEventSource("logger", "Application");
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("How Many?", "How many errors would you like to throw?", "1"));
            int count = 1;

            while (count <= number)
            {
                EventLog.WriteEntry("logger", "This is an Information Alert.", EventLogEntryType.Information);
                count += 1;
            }
        }

        private void btnWarning_Click(object sender, EventArgs e)
        {
            EventLog.WriteEntry("logger", "This is a Warning Alert.", EventLogEntryType.Warning);
        }

        private void btnError_Click(object sender, EventArgs e)
        {
            EventLog.WriteEntry("logger", "This is an Error Alert.", EventLogEntryType.Error);
        }

        private void btnSuccessAudit_Click(object sender, EventArgs e)
        {
            EventLog.WriteEntry("logger", "This is a Success Audit Alert.", EventLogEntryType.SuccessAudit);
        }

        private void btnFailureAudit_Click(object sender, EventArgs e)
        {
            EventLog.WriteEntry("logger", "This is a Failure Audit Alert.", EventLogEntryType.FailureAudit);
        }
    }
}
