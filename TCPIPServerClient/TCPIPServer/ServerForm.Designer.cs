namespace TCPIPServer
{
    partial class ServerForm
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
            this.labelMyIP = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ClientIP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Computer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Version = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ConnectionID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClientName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PingTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CommunicationsDisplay = new System.Windows.Forms.WebBrowser();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMyIP
            // 
            this.labelMyIP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMyIP.AutoSize = true;
            this.labelMyIP.ForeColor = System.Drawing.Color.LightYellow;
            this.labelMyIP.Location = new System.Drawing.Point(12, 137);
            this.labelMyIP.Name = "labelMyIP";
            this.labelMyIP.Size = new System.Drawing.Size(34, 13);
            this.labelMyIP.TabIndex = 68;
            this.labelMyIP.Text = "My IP";
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ClientIP,
            this.Computer,
            this.Version,
            this.ConnectionID,
            this.ClientName,
            this.PingTime});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.ShowItemToolTips = true;
            this.listView1.Size = new System.Drawing.Size(924, 122);
            this.listView1.TabIndex = 67;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ClientIP
            // 
            this.ClientIP.Text = "Client IP";
            this.ClientIP.Width = 136;
            // 
            // Computer
            // 
            this.Computer.Text = "Computer";
            this.Computer.Width = 120;
            // 
            // Version
            // 
            this.Version.Text = "Version";
            this.Version.Width = 179;
            // 
            // ConnectionID
            // 
            this.ConnectionID.Text = "ClientID";
            this.ConnectionID.Width = 70;
            // 
            // ClientName
            // 
            this.ClientName.Text = "Name";
            this.ClientName.Width = 127;
            // 
            // PingTime
            // 
            this.PingTime.Text = "Ping Time";
            this.PingTime.Width = 164;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.CommunicationsDisplay);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.LightYellow;
            this.groupBox2.Location = new System.Drawing.Point(9, 153);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(927, 285);
            this.groupBox2.TabIndex = 66;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Communication Events";
            // 
            // CommunicationsDisplay
            // 
            this.CommunicationsDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CommunicationsDisplay.Location = new System.Drawing.Point(3, 17);
            this.CommunicationsDisplay.MinimumSize = new System.Drawing.Size(20, 20);
            this.CommunicationsDisplay.Name = "CommunicationsDisplay";
            this.CommunicationsDisplay.Size = new System.Drawing.Size(921, 265);
            this.CommunicationsDisplay.TabIndex = 39;
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(951, 450);
            this.Controls.Add(this.labelMyIP);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox2);
            this.Name = "ServerForm";
            this.Text = "TCPiP Server App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmServer_FormClosing);
            this.Load += new System.EventHandler(this.frmServer_Load);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMyIP;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ClientIP;
        private System.Windows.Forms.ColumnHeader Computer;
        private System.Windows.Forms.ColumnHeader Version;
        private System.Windows.Forms.ColumnHeader ConnectionID;
        private System.Windows.Forms.ColumnHeader ClientName;
        private System.Windows.Forms.ColumnHeader PingTime;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.WebBrowser CommunicationsDisplay;
    }
}

