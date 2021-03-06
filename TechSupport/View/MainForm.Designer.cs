﻿namespace TechSupport.View
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.displayOpenIncidentsPage = new System.Windows.Forms.TabPage();
            this.addTab = new System.Windows.Forms.TabPage();
            this.updateTab = new System.Windows.Forms.TabPage();
            this.IncidentsByTechnician = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.logoutLink = new System.Windows.Forms.LinkLabel();
            this.tabPageReport = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.techSupportOpenIncidentsByTechnician = new TechSupport.TechSupportOpenIncidentsByTechnician();
            this.techSupportOpenIncidentsByTechnicianBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.incidentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.incidentsTableAdapter = new TechSupport.TechSupportOpenIncidentsByTechnicianTableAdapters.IncidentsTableAdapter();
            this.displayOpenIncidents1 = new TechSupport.UserControls.DisplayOpenIncidents();
            this.addIncident1 = new TechSupport.UserControls.AddIncident();
            this.updateIncident1 = new TechSupport.UserControls.UpdateIncident();
            this.viewIncidentsByTechnician1 = new TechSupport.UserControls.ViewIncidentsByTechnician();
            this.mainTabControl.SuspendLayout();
            this.displayOpenIncidentsPage.SuspendLayout();
            this.addTab.SuspendLayout();
            this.updateTab.SuspendLayout();
            this.IncidentsByTechnician.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabPageReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.techSupportOpenIncidentsByTechnician)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techSupportOpenIncidentsByTechnicianBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTabControl.Controls.Add(this.displayOpenIncidentsPage);
            this.mainTabControl.Controls.Add(this.addTab);
            this.mainTabControl.Controls.Add(this.updateTab);
            this.mainTabControl.Controls.Add(this.IncidentsByTechnician);
            this.mainTabControl.Controls.Add(this.tabPageReport);
            this.mainTabControl.Location = new System.Drawing.Point(12, 44);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(796, 527);
            this.mainTabControl.TabIndex = 0;
            // 
            // displayOpenIncidentsPage
            // 
            this.displayOpenIncidentsPage.Controls.Add(this.displayOpenIncidents1);
            this.displayOpenIncidentsPage.Location = new System.Drawing.Point(4, 22);
            this.displayOpenIncidentsPage.Name = "displayOpenIncidentsPage";
            this.displayOpenIncidentsPage.Padding = new System.Windows.Forms.Padding(3);
            this.displayOpenIncidentsPage.Size = new System.Drawing.Size(788, 501);
            this.displayOpenIncidentsPage.TabIndex = 3;
            this.displayOpenIncidentsPage.Text = "Display Open Incidents";
            this.displayOpenIncidentsPage.UseVisualStyleBackColor = true;
            // 
            // addTab
            // 
            this.addTab.Controls.Add(this.addIncident1);
            this.addTab.Location = new System.Drawing.Point(4, 22);
            this.addTab.Name = "addTab";
            this.addTab.Padding = new System.Windows.Forms.Padding(3);
            this.addTab.Size = new System.Drawing.Size(788, 501);
            this.addTab.TabIndex = 2;
            this.addTab.Text = "Add Incident";
            this.addTab.UseVisualStyleBackColor = true;
            // 
            // updateTab
            // 
            this.updateTab.Controls.Add(this.updateIncident1);
            this.updateTab.Location = new System.Drawing.Point(4, 22);
            this.updateTab.Name = "updateTab";
            this.updateTab.Padding = new System.Windows.Forms.Padding(3);
            this.updateTab.Size = new System.Drawing.Size(788, 501);
            this.updateTab.TabIndex = 4;
            this.updateTab.Text = "Update Incident";
            this.updateTab.UseVisualStyleBackColor = true;
            // 
            // IncidentsByTechnician
            // 
            this.IncidentsByTechnician.Controls.Add(this.viewIncidentsByTechnician1);
            this.IncidentsByTechnician.Location = new System.Drawing.Point(4, 22);
            this.IncidentsByTechnician.Name = "IncidentsByTechnician";
            this.IncidentsByTechnician.Padding = new System.Windows.Forms.Padding(3);
            this.IncidentsByTechnician.Size = new System.Drawing.Size(788, 501);
            this.IncidentsByTechnician.TabIndex = 5;
            this.IncidentsByTechnician.Text = "View Incidents By Technician";
            this.IncidentsByTechnician.UseVisualStyleBackColor = true;
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
            // tabPageReport
            // 
            this.tabPageReport.Controls.Add(this.reportViewer1);
            this.tabPageReport.Location = new System.Drawing.Point(4, 22);
            this.tabPageReport.Name = "tabPageReport";
            this.tabPageReport.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReport.Size = new System.Drawing.Size(788, 501);
            this.tabPageReport.TabIndex = 6;
            this.tabPageReport.Text = "Report";
            this.tabPageReport.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "OpenIncidentByTechnician";
            reportDataSource1.Value = this.incidentsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TechSupport.Reports.OpenIncidentsByTechnician.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(782, 495);
            this.reportViewer1.TabIndex = 0;
            // 
            // techSupportOpenIncidentsByTechnician
            // 
            this.techSupportOpenIncidentsByTechnician.DataSetName = "TechSupportOpenIncidentsByTechnician";
            this.techSupportOpenIncidentsByTechnician.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // techSupportOpenIncidentsByTechnicianBindingSource
            // 
            this.techSupportOpenIncidentsByTechnicianBindingSource.DataSource = this.techSupportOpenIncidentsByTechnician;
            this.techSupportOpenIncidentsByTechnicianBindingSource.Position = 0;
            // 
            // incidentsBindingSource
            // 
            this.incidentsBindingSource.DataMember = "Incidents";
            this.incidentsBindingSource.DataSource = this.techSupportOpenIncidentsByTechnicianBindingSource;
            // 
            // incidentsTableAdapter
            // 
            this.incidentsTableAdapter.ClearBeforeFill = true;
            // 
            // displayOpenIncidents1
            // 
            this.displayOpenIncidents1.AutoSize = true;
            this.displayOpenIncidents1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.displayOpenIncidents1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.displayOpenIncidents1.Location = new System.Drawing.Point(3, 3);
            this.displayOpenIncidents1.Name = "displayOpenIncidents1";
            this.displayOpenIncidents1.Size = new System.Drawing.Size(782, 495);
            this.displayOpenIncidents1.TabIndex = 0;
            this.displayOpenIncidents1.Load += new System.EventHandler(this.DisplayOpenIncidents);
            // 
            // addIncident1
            // 
            this.addIncident1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addIncident1.Location = new System.Drawing.Point(3, 3);
            this.addIncident1.Name = "addIncident1";
            this.addIncident1.Size = new System.Drawing.Size(782, 495);
            this.addIncident1.TabIndex = 0;
            // 
            // updateIncident1
            // 
            this.updateIncident1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updateIncident1.Location = new System.Drawing.Point(3, 3);
            this.updateIncident1.Name = "updateIncident1";
            this.updateIncident1.Size = new System.Drawing.Size(782, 495);
            this.updateIncident1.TabIndex = 0;
            // 
            // viewIncidentsByTechnician1
            // 
            this.viewIncidentsByTechnician1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewIncidentsByTechnician1.Location = new System.Drawing.Point(3, 3);
            this.viewIncidentsByTechnician1.Name = "viewIncidentsByTechnician1";
            this.viewIncidentsByTechnician1.Size = new System.Drawing.Size(782, 495);
            this.viewIncidentsByTechnician1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 583);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.mainTabControl);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFormTabbed_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainTabControl.ResumeLayout(false);
            this.displayOpenIncidentsPage.ResumeLayout(false);
            this.displayOpenIncidentsPage.PerformLayout();
            this.addTab.ResumeLayout(false);
            this.updateTab.ResumeLayout(false);
            this.IncidentsByTechnician.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tabPageReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.techSupportOpenIncidentsByTechnician)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techSupportOpenIncidentsByTechnicianBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidentsBindingSource)).EndInit();
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
        private UserControls.AddIncident addIncident1;
        private System.Windows.Forms.TabPage updateTab;
        private UserControls.UpdateIncident updateIncident1;
        private System.Windows.Forms.TabPage IncidentsByTechnician;
        private UserControls.ViewIncidentsByTechnician viewIncidentsByTechnician1;
        private System.Windows.Forms.TabPage tabPageReport;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource techSupportOpenIncidentsByTechnicianBindingSource;
        private TechSupportOpenIncidentsByTechnician techSupportOpenIncidentsByTechnician;
        private System.Windows.Forms.BindingSource incidentsBindingSource;
        private TechSupportOpenIncidentsByTechnicianTableAdapters.IncidentsTableAdapter incidentsTableAdapter;
    }
}