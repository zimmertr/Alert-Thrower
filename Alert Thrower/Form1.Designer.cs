namespace Alert_Thrower
{
    partial class frmAlertThrower
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnInformation = new System.Windows.Forms.Button();
            this.btnWarning = new System.Windows.Forms.Button();
            this.btnError = new System.Windows.Forms.Button();
            this.btnFailureAudit = new System.Windows.Forms.Button();
            this.btnSuccessAudit = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRuntime = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInformation
            // 
            this.btnInformation.Location = new System.Drawing.Point(24, 169);
            this.btnInformation.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnInformation.Name = "btnInformation";
            this.btnInformation.Size = new System.Drawing.Size(150, 44);
            this.btnInformation.TabIndex = 0;
            this.btnInformation.Text = "Information";
            this.btnInformation.UseVisualStyleBackColor = true;
            this.btnInformation.Click += new System.EventHandler(this.btnInformation_Click);
            // 
            // btnWarning
            // 
            this.btnWarning.Location = new System.Drawing.Point(240, 169);
            this.btnWarning.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnWarning.Name = "btnWarning";
            this.btnWarning.Size = new System.Drawing.Size(150, 44);
            this.btnWarning.TabIndex = 1;
            this.btnWarning.Text = "Warning";
            this.btnWarning.UseVisualStyleBackColor = true;
            this.btnWarning.Click += new System.EventHandler(this.btnWarning_Click);
            // 
            // btnError
            // 
            this.btnError.Location = new System.Drawing.Point(464, 169);
            this.btnError.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnError.Name = "btnError";
            this.btnError.Size = new System.Drawing.Size(150, 44);
            this.btnError.TabIndex = 2;
            this.btnError.Text = "Error";
            this.btnError.UseVisualStyleBackColor = true;
            this.btnError.Click += new System.EventHandler(this.btnError_Click);
            // 
            // btnFailureAudit
            // 
            this.btnFailureAudit.Location = new System.Drawing.Point(240, 263);
            this.btnFailureAudit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnFailureAudit.Name = "btnFailureAudit";
            this.btnFailureAudit.Size = new System.Drawing.Size(150, 44);
            this.btnFailureAudit.TabIndex = 3;
            this.btnFailureAudit.Text = "Failure Audit";
            this.btnFailureAudit.UseVisualStyleBackColor = true;
            this.btnFailureAudit.Click += new System.EventHandler(this.btnFailureAudit_Click);
            // 
            // btnSuccessAudit
            // 
            this.btnSuccessAudit.Location = new System.Drawing.Point(24, 263);
            this.btnSuccessAudit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSuccessAudit.Name = "btnSuccessAudit";
            this.btnSuccessAudit.Size = new System.Drawing.Size(180, 44);
            this.btnSuccessAudit.TabIndex = 4;
            this.btnSuccessAudit.Text = "Success Audit";
            this.btnSuccessAudit.UseVisualStyleBackColor = true;
            this.btnSuccessAudit.Click += new System.EventHandler(this.btnSuccessAudit_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(150, 17);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(309, 25);
            this.lblInfo.TabIndex = 5;
            this.lblInfo.Text = "Click a button to throw an alert.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(614, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Alerts will be placed in the Application Log of the Event Viewer.";
            // 
            // btnRuntime
            // 
            this.btnRuntime.Location = new System.Drawing.Point(464, 263);
            this.btnRuntime.Name = "btnRuntime";
            this.btnRuntime.Size = new System.Drawing.Size(150, 44);
            this.btnRuntime.TabIndex = 7;
            this.btnRuntime.Text = "Unhandled";
            this.btnRuntime.UseVisualStyleBackColor = true;
            this.btnRuntime.Click += new System.EventHandler(this.btnRuntime_Click);
            // 
            // frmAlertThrower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 435);
            this.Controls.Add(this.btnRuntime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnSuccessAudit);
            this.Controls.Add(this.btnFailureAudit);
            this.Controls.Add(this.btnError);
            this.Controls.Add(this.btnWarning);
            this.Controls.Add(this.btnInformation);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmAlertThrower";
            this.Text = "Alert Thrower";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInformation;
        private System.Windows.Forms.Button btnWarning;
        private System.Windows.Forms.Button btnError;
        private System.Windows.Forms.Button btnFailureAudit;
        private System.Windows.Forms.Button btnSuccessAudit;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRuntime;
    }
}

