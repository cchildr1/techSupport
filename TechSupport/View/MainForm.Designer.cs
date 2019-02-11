namespace TechSupport.View
{
    partial class MainForm
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
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.displayOpenIncidentsPage = new System.Windows.Forms.TabPage();
            this.displayOpenIncidents1 = new TechSupport.UserControls.DisplayOpenIncidents();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.logoutLink = new System.Windows.Forms.LinkLabel();
            this.addIncidentDBControl1 = new TechSupport.UserControls.AddIncidentControl();
            this.addTab = new System.Windows.Forms.TabPage();
            this.addIncidentDBControl2 = new TechSupport.UserControls.AddIncidentControl();
            this.mainTabControl.SuspendLayout();
            this.displayOpenIncidentsPage.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.addTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTabControl.Controls.Add(this.displayOpenIncidentsPage);
            this.mainTabControl.Controls.Add(this.addTab);
            this.mainTabControl.Location = new System.Drawing.Point(12, 44);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(796, 500);
            this.mainTabControl.TabIndex = 0;
            this.mainTabControl.SelectedIndexChanged += new System.EventHandler(this.mainTabControl_SelectedIndexChanged);
            // 
            // displayOpenIncidentsPage
            // 
            this.displayOpenIncidentsPage.Controls.Add(this.displayOpenIncidents1);
            this.displayOpenIncidentsPage.Location = new System.Drawing.Point(4, 22);
            this.displayOpenIncidentsPage.Name = "displayOpenIncidentsPage";
            this.displayOpenIncidentsPage.Padding = new System.Windows.Forms.Padding(3);
            this.displayOpenIncidentsPage.Size = new System.Drawing.Size(788, 474);
            this.displayOpenIncidentsPage.TabIndex = 3;
            this.displayOpenIncidentsPage.Text = "Display Open Incidents";
            this.displayOpenIncidentsPage.UseVisualStyleBackColor = true;
            this.displayOpenIncidentsPage.Click += new System.EventHandler(this.DisplayOpenIncidents);
            // 
            // displayOpenIncidents1
            // 
            this.displayOpenIncidents1.AutoSize = true;
            this.displayOpenIncidents1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.displayOpenIncidents1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.displayOpenIncidents1.Location = new System.Drawing.Point(3, 3);
            this.displayOpenIncidents1.Name = "displayOpenIncidents1";
            this.displayOpenIncidents1.Size = new System.Drawing.Size(782, 468);
            this.displayOpenIncidents1.TabIndex = 0;
            this.displayOpenIncidents1.Load += new System.EventHandler(this.DisplayOpenIncidents);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.usernameLabel);
            this.flowLayoutPanel1.Controls.Add(this.logoutLink);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(625, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(183, 26);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.usernameLabel.Location = new System.Drawing.Point(3, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(93, 20);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "User Name:";
            // 
            // logoutLink
            // 
            this.logoutLink.AutoSize = true;
            this.logoutLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.logoutLink.Location = new System.Drawing.Point(102, 0);
            this.logoutLink.Name = "logoutLink";
            this.logoutLink.Size = new System.Drawing.Size(66, 20);
            this.logoutLink.TabIndex = 1;
            this.logoutLink.TabStop = true;
            this.logoutLink.Text = "Log Out";
            this.logoutLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogoutLink_LinkClicked);
            // 
            // addIncidentDBControl1
            // 
            this.addIncidentDBControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.addIncidentDBControl1.Location = new System.Drawing.Point(0, 0);
            this.addIncidentDBControl1.Name = "addIncidentDBControl1";
            this.addIncidentDBControl1.Size = new System.Drawing.Size(788, 0);
            this.addIncidentDBControl1.TabIndex = 0;
            this.addIncidentDBControl1.Load += new System.EventHandler(this.addIncidentDBControl1_Load);
            // 
            // addTab
            // 
            this.addTab.Controls.Add(this.addIncidentDBControl2);
            this.addTab.Controls.Add(this.addIncidentDBControl1);
            this.addTab.Location = new System.Drawing.Point(4, 22);
            this.addTab.Name = "addTab";
            this.addTab.Padding = new System.Windows.Forms.Padding(3);
            this.addTab.Size = new System.Drawing.Size(788, 474);
            this.addTab.TabIndex = 2;
            this.addTab.Text = "Add Incident";
            this.addTab.UseVisualStyleBackColor = true;
            // 
            // addIncidentDBControl2
            // 
            this.addIncidentDBControl2.Location = new System.Drawing.Point(-4, 0);
            this.addIncidentDBControl2.Name = "addIncidentDBControl2";
            this.addIncidentDBControl2.Size = new System.Drawing.Size(792, 474);
            this.addIncidentDBControl2.TabIndex = 1;
            // 
            // MainFormTabbed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 556);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.mainTabControl);
            this.Name = "MainFormTabbed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFormTabbed_FormClosed);
            this.mainTabControl.ResumeLayout(false);
            this.displayOpenIncidentsPage.ResumeLayout(false);
            this.displayOpenIncidentsPage.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.addTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.LinkLabel logoutLink;
        private System.Windows.Forms.TabPage displayOpenIncidentsPage;
        private UserControls.DisplayOpenIncidents displayOpenIncidents1;
        private System.Windows.Forms.TabPage addTab;
        private UserControls.AddIncidentControl addIncidentDBControl2;
        private UserControls.AddIncidentControl addIncidentDBControl1;
    }
}