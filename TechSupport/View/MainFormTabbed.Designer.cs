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
            this.incidentTab = new System.Windows.Forms.TabPage();
            this.searchTab = new System.Windows.Forms.TabPage();
            this.addTab = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.logoutLink = new System.Windows.Forms.LinkLabel();
            this.incidentControl1 = new TechSupport.UserControls.IncidentControl();
            this.mainTabControl.SuspendLayout();
            this.incidentTab.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTabControl.Controls.Add(this.incidentTab);
            this.mainTabControl.Controls.Add(this.searchTab);
            this.mainTabControl.Controls.Add(this.addTab);
            this.mainTabControl.Location = new System.Drawing.Point(12, 44);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(772, 490);
            this.mainTabControl.TabIndex = 0;
            // 
            // incidentTab
            // 
            this.incidentTab.Controls.Add(this.incidentControl1);
            this.incidentTab.Location = new System.Drawing.Point(4, 22);
            this.incidentTab.Name = "incidentTab";
            this.incidentTab.Padding = new System.Windows.Forms.Padding(3);
            this.incidentTab.Size = new System.Drawing.Size(764, 464);
            this.incidentTab.TabIndex = 0;
            this.incidentTab.Text = "Incidents";
            this.incidentTab.UseVisualStyleBackColor = true;
            // 
            // searchTab
            // 
            this.searchTab.Location = new System.Drawing.Point(4, 22);
            this.searchTab.Name = "searchTab";
            this.searchTab.Padding = new System.Windows.Forms.Padding(3);
            this.searchTab.Size = new System.Drawing.Size(764, 464);
            this.searchTab.TabIndex = 1;
            this.searchTab.Text = "Search Incidents";
            this.searchTab.UseVisualStyleBackColor = true;
            // 
            // addTab
            // 
            this.addTab.Location = new System.Drawing.Point(4, 22);
            this.addTab.Name = "addTab";
            this.addTab.Padding = new System.Windows.Forms.Padding(3);
            this.addTab.Size = new System.Drawing.Size(764, 464);
            this.addTab.TabIndex = 2;
            this.addTab.Text = "Add Incident";
            this.addTab.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.usernameLabel);
            this.flowLayoutPanel1.Controls.Add(this.logoutLink);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(601, 12);
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
            this.logoutLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logoutLink_LinkClicked);
            // 
            // incidentControl1
            // 
            this.incidentControl1.AutoSize = true;
            this.incidentControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.incidentControl1.Location = new System.Drawing.Point(3, 3);
            this.incidentControl1.Name = "incidentControl1";
            this.incidentControl1.Size = new System.Drawing.Size(758, 458);
            this.incidentControl1.TabIndex = 0;
            // 
            // MainFormTabbed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 546);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.mainTabControl);
            this.Name = "MainFormTabbed";
            this.Text = "Main Form";
            this.mainTabControl.ResumeLayout(false);
            this.incidentTab.ResumeLayout(false);
            this.incidentTab.PerformLayout();
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
    }
}