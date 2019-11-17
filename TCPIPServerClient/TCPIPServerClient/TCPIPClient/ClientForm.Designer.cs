﻿namespace TCPIPClient
{
    partial class ClientForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
            this.buttonConnectToServer = new System.Windows.Forms.Button();
            this.textBoxServer = new System.Windows.Forms.TextBox();
            this.labelStatusInfo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxClientName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxServerListeningPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.imageListStatusLights = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.labelConnectionStuff = new System.Windows.Forms.Label();
            this.buttonSendDataToServer = new System.Windows.Forms.Button();
            this.textBoxText = new System.Windows.Forms.TextBox();
            this.gbServerHost = new System.Windows.Forms.GroupBox();
            this.gbClientName = new System.Windows.Forms.GroupBox();
            this.gbConnectionStatus = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbServerHost.SuspendLayout();
            this.gbClientName.SuspendLayout();
            this.gbConnectionStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonConnectToServer
            // 
            this.buttonConnectToServer.Location = new System.Drawing.Point(12, 77);
            this.buttonConnectToServer.Name = "buttonConnectToServer";
            this.buttonConnectToServer.Size = new System.Drawing.Size(327, 23);
            this.buttonConnectToServer.TabIndex = 0;
            this.buttonConnectToServer.Text = "Connect To Server";
            this.buttonConnectToServer.UseVisualStyleBackColor = true;
            this.buttonConnectToServer.Click += new System.EventHandler(this.buttonConnectToServer_Click);
            // 
            // textBoxServer
            // 
            this.textBoxServer.Location = new System.Drawing.Point(44, 18);
            this.textBoxServer.Name = "textBoxServer";
            this.textBoxServer.Size = new System.Drawing.Size(173, 20);
            this.textBoxServer.TabIndex = 1;
            this.textBoxServer.Text = "localhost";
            // 
            // labelStatusInfo
            // 
            this.labelStatusInfo.AutoSize = true;
            this.labelStatusInfo.Location = new System.Drawing.Point(42, 9);
            this.labelStatusInfo.Name = "labelStatusInfo";
            this.labelStatusInfo.Size = new System.Drawing.Size(159, 13);
            this.labelStatusInfo.TabIndex = 2;
            this.labelStatusInfo.Text = "Click \'Connect to Server\'  button";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Address to the Server(name or IP)";
            // 
            // textBoxClientName
            // 
            this.textBoxClientName.Location = new System.Drawing.Point(21, 24);
            this.textBoxClientName.Name = "textBoxClientName";
            this.textBoxClientName.Size = new System.Drawing.Size(100, 20);
            this.textBoxClientName.TabIndex = 4;
            this.textBoxClientName.Text = "John Smith";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Client Name";
            // 
            // textBoxServerListeningPort
            // 
            this.textBoxServerListeningPort.Location = new System.Drawing.Point(158, 41);
            this.textBoxServerListeningPort.Name = "textBoxServerListeningPort";
            this.textBoxServerListeningPort.Size = new System.Drawing.Size(50, 20);
            this.textBoxServerListeningPort.TabIndex = 6;
            this.textBoxServerListeningPort.Text = "9999";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Server\'s Listening Port:";
            // 
            // imageListStatusLights
            // 
            this.imageListStatusLights.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListStatusLights.ImageStream")));
            this.imageListStatusLights.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListStatusLights.Images.SetKeyName(0, "RED");
            this.imageListStatusLights.Images.SetKeyName(1, "GREEN");
            this.imageListStatusLights.Images.SetKeyName(2, "BLUE");
            this.imageListStatusLights.Images.SetKeyName(3, "PURPLE");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(15, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Enabled = false;
            this.buttonDisconnect.Location = new System.Drawing.Point(364, 77);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(75, 23);
            this.buttonDisconnect.TabIndex = 9;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // labelConnectionStuff
            // 
            this.labelConnectionStuff.AutoSize = true;
            this.labelConnectionStuff.Location = new System.Drawing.Point(12, 245);
            this.labelConnectionStuff.Name = "labelConnectionStuff";
            this.labelConnectionStuff.Size = new System.Drawing.Size(16, 13);
            this.labelConnectionStuff.TabIndex = 10;
            this.labelConnectionStuff.Text = "...";
            // 
            // buttonSendDataToServer
            // 
            this.buttonSendDataToServer.Enabled = false;
            this.buttonSendDataToServer.Location = new System.Drawing.Point(609, 228);
            this.buttonSendDataToServer.Name = "buttonSendDataToServer";
            this.buttonSendDataToServer.Size = new System.Drawing.Size(185, 23);
            this.buttonSendDataToServer.TabIndex = 11;
            this.buttonSendDataToServer.Text = "Send Data To Server";
            this.buttonSendDataToServer.UseVisualStyleBackColor = true;
            this.buttonSendDataToServer.Click += new System.EventHandler(this.buttonSendDataToServer_Click);
            // 
            // textBoxText
            // 
            this.textBoxText.Location = new System.Drawing.Point(12, 106);
            this.textBoxText.Multiline = true;
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxText.Size = new System.Drawing.Size(782, 116);
            this.textBoxText.TabIndex = 12;
            // 
            // gbServerHost
            // 
            this.gbServerHost.Controls.Add(this.label3);
            this.gbServerHost.Controls.Add(this.textBoxServerListeningPort);
            this.gbServerHost.Controls.Add(this.label2);
            this.gbServerHost.Controls.Add(this.textBoxServer);
            this.gbServerHost.Location = new System.Drawing.Point(12, -1);
            this.gbServerHost.Name = "gbServerHost";
            this.gbServerHost.Size = new System.Drawing.Size(227, 72);
            this.gbServerHost.TabIndex = 18;
            this.gbServerHost.TabStop = false;
            // 
            // gbClientName
            // 
            this.gbClientName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbClientName.Controls.Add(this.label1);
            this.gbClientName.Controls.Add(this.textBoxClientName);
            this.gbClientName.Location = new System.Drawing.Point(636, 1);
            this.gbClientName.Name = "gbClientName";
            this.gbClientName.Size = new System.Drawing.Size(158, 59);
            this.gbClientName.TabIndex = 19;
            this.gbClientName.TabStop = false;
            // 
            // gbConnectionStatus
            // 
            this.gbConnectionStatus.Controls.Add(this.pictureBox1);
            this.gbConnectionStatus.Controls.Add(this.labelStatusInfo);
            this.gbConnectionStatus.Location = new System.Drawing.Point(238, 8);
            this.gbConnectionStatus.Name = "gbConnectionStatus";
            this.gbConnectionStatus.Size = new System.Drawing.Size(226, 47);
            this.gbConnectionStatus.TabIndex = 20;
            this.gbConnectionStatus.TabStop = false;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 262);
            this.Controls.Add(this.gbConnectionStatus);
            this.Controls.Add(this.gbClientName);
            this.Controls.Add(this.gbServerHost);
            this.Controls.Add(this.textBoxText);
            this.Controls.Add(this.buttonSendDataToServer);
            this.Controls.Add(this.labelConnectionStuff);
            this.Controls.Add(this.buttonDisconnect);
            this.Controls.Add(this.buttonConnectToServer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ClientForm";
            this.Text =string.Format("{0} | {1} | {2}",Text,Properties.Settings.Default.ClientUserName, Properties.Settings.Default.ClientIP);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmClient_FormClosing);
            this.Load += new System.EventHandler(this.frmClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbServerHost.ResumeLayout(false);
            this.gbServerHost.PerformLayout();
            this.gbClientName.ResumeLayout(false);
            this.gbClientName.PerformLayout();
            this.gbConnectionStatus.ResumeLayout(false);
            this.gbConnectionStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConnectToServer;
        private System.Windows.Forms.TextBox textBoxServer;
        private System.Windows.Forms.Label labelStatusInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxServerListeningPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ImageList imageListStatusLights;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Label labelConnectionStuff;
        private System.Windows.Forms.Button buttonSendDataToServer;
        private System.Windows.Forms.TextBox textBoxText;
        private System.Windows.Forms.GroupBox gbServerHost;
        private System.Windows.Forms.GroupBox gbConnectionStatus;
        public System.Windows.Forms.GroupBox gbClientName;
        public System.Windows.Forms.TextBox textBoxClientName;
    }
}

