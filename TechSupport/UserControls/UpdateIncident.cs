using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.UserControls
{

    // TODO ensure record has not changed before the update

    /// <summary>
    /// User control to update incidents
    /// </summary>
    public partial class UpdateIncident : UserControl
    {
        private Incident oldIncident;
        private IncidentController controller;
        public UpdateIncident()
        {
            InitializeComponent();
            this.controller = new IncidentController();
            try
            {
                List<Technician> technicians = this.controller.GetTechnicians();
                technicians.Insert(0, new Technician
                {
                    TechID = -1,
                    Name = "-- Unassigned --"
                });
                cbTechnician.DataSource = technicians;
                cbTechnician.DisplayMember = "Name";
                cbTechnician.ValueMember = "TechID";
                cbTechnician.SelectedIndex = -1;
            } catch (Exception ex)
            {
                MessageBox.Show("Something is wrong with the DB.\n" + ex.Message, "Exception thrown");
            }
        }

        private void BtGetIncident_Click(object sender, EventArgs e)
        {
            if(!Validator.IsInteger(tbIncidentID))
            {
                MessageBox.Show("You must enter an integer incident id.", "Incident ID Error");
                return;
            }
            Incident incident = controller.GetIncident(int.Parse(tbIncidentID.Text));
            if (incident == null)
            {
                this.Clear();
                MessageBox.Show("Record not found.", "No Record");
            }
            else
            {
                this.Clear();
                tbIncidentID.Text = incident.IncidentID.ToString();
                tbCustomer.Text = incident.CustomerName;
                tbDateOpened.Text = incident.DateOpened.ToShortDateString();
                tbDescription.Text = incident.Description;
                tbProduct.Text = incident.ProductCode;
                tbTitle.Text = incident.Title;
                if (incident.TechnicianID < 0)
                {
                    cbTechnician.SelectedIndex = 0;
                }
                else
                {
                    cbTechnician.SelectedValue = incident.TechnicianID;
                }

                this.oldIncident = incident;
                if (incident.DateClosed == DateTime.MinValue)
                {
                    this.UnlockControls();
                }
                
            }
        }

        private void Clear()
        {
            tbCustomer.Clear();
            tbDateOpened.Clear();
            cbTechnician.SelectedIndex = -1;
            tbDescription.Clear();
            tbProduct.Clear();
            tbTitle.Clear();
            tbTextToAdd.Clear();

            this.LockControls();
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            if ((int)cbTechnician.SelectedValue < 0)
            {
                MessageBox.Show("You must have a technician to close a ticket.", "Cannot Close Ticket");
            } else
            {
                if (tbTextToAdd.Text == "")
                {
                    tbTextToAdd.Text = "Ticked Closed.";
                }
                if (Validator.IsPresent(tbTextToAdd))
                {
                    Incident newIncident = new Incident
                    {
                        IncidentID = this.oldIncident.IncidentID,
                        CustomerID = this.oldIncident.CustomerID,
                        CustomerName = this.oldIncident.CustomerName,
                        DateOpened = this.oldIncident.DateOpened,
                        DateClosed = DateTime.Now,
                        Title = this.oldIncident.Title,
                        ProductCode = this.oldIncident.ProductCode,
                        Description = this.UpdateDescription(),
                        TechnicianID = (int)cbTechnician.SelectedValue
                    };
                    try
                    {
                        var result = MessageBox.Show("Are you sure you want to close this ticket?\nYou cannot edit it once closed",
                            "Are you sure?", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            if (controller.UpdateIncident(newIncident, this.oldIncident))
                            {
                                MessageBox.Show("Record Updated", "Incident Updated");
                                tbDescription.Text = newIncident.Description;
                                tbTextToAdd.Clear();
                            }
                            else
                            {
                                MessageBox.Show("Record Update Failed.", "Incident not updated");
                            }
                            this.LockControls();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Something is wrong with the DB.\n" + ex.Message, "Exception thrown");
                    }

                }
            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (oldIncident.TechnicianID != (int)cbTechnician.SelectedValue && tbTextToAdd.Text == "")
            {
                tbTextToAdd.Text = "Assigned Technician.";
            }
            if (Validator.IsPresent(tbTextToAdd))
            {
                Incident newIncident = new Incident
                {
                    IncidentID = this.oldIncident.IncidentID,
                    CustomerID = this.oldIncident.CustomerID,
                    CustomerName = this.oldIncident.CustomerName,
                    DateOpened = this.oldIncident.DateOpened,
                    DateClosed = this.oldIncident.DateClosed,
                    Title = this.oldIncident.Title,
                    ProductCode = this.oldIncident.ProductCode,
                    Description = this.UpdateDescription(),
                };
                
                if (!(cbTechnician.SelectedIndex < 0))
                {
                    newIncident.TechnicianID = (int)cbTechnician.SelectedValue;
                }

                try
                {
                    if (controller.UpdateIncident(newIncident, this.oldIncident))
                    {
                        MessageBox.Show("Record Updated", "Incident Updated");
                        tbDescription.Text = newIncident.Description;
                        tbTextToAdd.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Record Update Failed.", "Incident not updated");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something is wrong with the DB.\n" + ex.Message, "Exception thrown");
                }
            }
        }

        private string UpdateDescription()
        {
            string description = tbDescription.Text;
            if (tbTextToAdd.Text.Equals(""))
            {
                description = CheckDescriptionFor200Chars(description);
            } else
            {
                description += "\n<" + DateTime.Now.ToShortDateString() + "> " + tbTextToAdd.Text;
                description = CheckDescriptionFor200Chars(description);
            }
            return description;
        }

        private string CheckDescriptionFor200Chars(string description)
        {
            if (description.Length > 200)
            {
                var result = MessageBox.Show("The description and additional text is over 200 characters.\nTruncate the description?",
                    "Description is too long", 
                    MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    return description.Substring(description.Length - 199);
                }
            }
            return description;
        }

        private void UnlockControls()
        {
            btUpdate.Enabled = true;
            btClose.Enabled = true;
            tbTextToAdd.Enabled = true;
            cbTechnician.Enabled = true;
        }

        private void LockControls()
        {
            btUpdate.Enabled = false;
            btClose.Enabled = false;
            tbTextToAdd.Enabled = false;
            cbTechnician.Enabled = false;
        }
    }
}
