namespace TechSupport.View
{
    partial class MainFormTabbed
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
            this.incidentTab = new System.Windows.Forms.TabPage();
            this.incidentControl1 = new TechSupport.UserControls.IncidentControl();
            this.searchTab = new System.Windows.Forms.TabPage();
            this.searchControl1 = new TechSupport.UserControls.SearchControl();
            this.addTab = new System.Windows.Forms.TabPage();
            this.addIncidentControl1 = new TechSupport.UserControls.AddIncidentControl();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.logoutLink = new System.Windows.Forms.LinkLabel();
            this.mainTabControl.SuspendLayout();
            this.displayOpenIncidentsPage.SuspendLayout();
            this.incidentTab.SuspendLayout();
            this.searchTab.SuspendLayout();
            this.addTab.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTabControl.Controls.Add(this.displayOpenIncidentsPage);
            this.mainTabControl.Controls.Add(this.incidentTab);
            this.mainTabControl.Controls.Add(this.searchTab);
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
            // incidentTab
            // 
            this.incidentTab.Controls.Add(this.incidentControl1);
            this.incidentTab.Location = new System.Drawing.Point(4, 22);
            this.incidentTab.Name = "incidentTab";
            this.incidentTab.Padding = new System.Windows.Forms.Padding(3);
            this.incidentTab.Size = new System.Drawing.Size(788, 474);
            this.incidentTab.TabIndex = 0;
            this.incidentTab.Text = "Incidents";
            this.incidentTab.UseVisualStyleBackColor = true;
            // 
            // incidentControl1
            // 
            this.incidentControl1.AutoSize = true;
            this.incidentControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.incidentControl1.Location = new System.Drawing.Point(3, 3);
            this.incidentControl1.Name = "incidentControl1";
            this.incidentControl1.Size = new System.Drawing.Size(782, 468);
            this.incidentControl1.TabIndex = 0;
            // 
            // searchTab
            // 
            this.searchTab.Controls.Add(this.searchControl1);
            this.searchTab.Location = new System.Drawing.Point(4, 22);
            this.searchTab.Name = "searchTab";
            this.searchTab.Padding = new System.Windows.Forms.Padding(3);
            this.searchTab.Size = new System.Drawing.Size(788, 474);
            this.searchTab.TabIndex = 1;
            this.searchTab.Text = "Search Incidents";
            this.searchTab.UseVisualStyleBackColor = true;
            // 
            // searchControl1
            // 
            this.searchControl1.AutoSize = true;
            this.searchControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.searchControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchControl1.Location = new System.Drawing.Point(3, 3);
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Size = new System.Drawing.Size(782, 468);
            this.searchControl1.TabIndex = 0;
            // 
            // addTab
            // 
            this.addTab.Controls.Add(this.addIncidentControl1);
            this.addTab.Location = new System.Drawing.Point(4, 22);
            this.addTab.Name = "addTab";
            this.addTab.Padding = new System.Windows.Forms.Padding(3);
            this.addTab.Size = new System.Drawing.Size(788, 474);
            this.addTab.TabIndex = 2;
            this.addTab.Text = "Add Incident";
            this.addTab.UseVisualStyleBackColor = true;
            // 
            // addIncidentControl1
            // 
            this.addIncidentControl1.AutoSize = true;
            this.addIncidentControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addIncidentControl1.Location = new System.Drawing.Point(3, 3);
            this.addIncidentControl1.Name = "addIncidentControl1";
            this.addIncidentControl1.Size = new System.Drawing.Size(782, 468);
            this.addIncidentControl1.TabIndex = 0;
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
            // MainFormTabbed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 556);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.mainTabControl);
            this.Name = "MainFormTabbed";
            this.Text = "Main Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFormTabbed_FormClosed);
            this.mainTabControl.ResumeLayout(false);
            this.displayOpenIncidentsPage.ResumeLayout(false);
            this.displayOpenIncidentsPage.PerformLayout();
            this.incidentTab.ResumeLayout(false);
            this.incidentTab.PerformLayout();
            this.searchTab.ResumeLayout(false);
            this.searchTab.PerformLayout();
            this.addTab.ResumeLayout(false);
            this.addTab.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage incidentTab;
        private System.Windows.Forms.TabPage searchTab;
        private System.Windows.Forms.TabPage addTab;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.LinkLabel logoutLink;
        private UserControls.IncidentControl incidentControl1;
        private UserControls.SearchControl searchControl1;
        private UserControls.AddIncidentControl addIncidentControl1;
        private System.Windows.Forms.TabPage displayOpenIncidentsPage;
        private UserControls.DisplayOpenIncidents displayOpenIncidents1;
    }
}