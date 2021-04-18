using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kaioordinate
{
    /// <summary>
    /// add reference to objects
    /// </summary>

    public partial class EventForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager cmEvent;
        private CurrencyManager cmLocation;

        /// <summary>
        /// change constructor to accept DataModule and MainForm reference
        /// </summary>
        /// <param name="dm"></param>
        /// <param name="mnu"></param>

        public EventForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
        }

        /// <summary>
        /// bind the data in the Event table
        /// </summary>

        public void BindControls()
        {
            cmEvent = (CurrencyManager)this.BindingContext[DM.dsKaiOordinate, "Event"];
            cmLocation = (CurrencyManager)this.BindingContext[DM.dsKaiOordinate, "Location"];

            txtEventNo.DataBindings.Add("Text", DM.dsKaiOordinate, "Event.EventID");
            txtEventName.DataBindings.Add("Text", DM.dsKaiOordinate, "Event.EventName");
            txtLocation.DataBindings.Add("Text", DM.dsKaiOordinate, "Event.LocationID");
            txtEventDate.DataBindings.Add("Text", DM.dsKaiOordinate, "Event.EventDate");

            cboAddLocation.DataSource = DM.dsKaiOordinate;
            cboAddLocation.DisplayMember = "Location.LocationName";
            cboAddLocation.ValueMember = "Location.LocationID";

            cboUpdateLocation.DataSource = DM.dsKaiOordinate;
            cboUpdateLocation.DisplayMember = "Location.LocationName";
            cboUpdateLocation.ValueMember = "Location.LocationID";

            lstEvent.DataSource = DM.dsKaiOordinate;
            lstEvent.DisplayMember = "Event.EventName";
            lstEvent.ValueMember = "Event.EventName";

        }

        /// <summary>
        /// make button "UP" to go up
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (cmEvent.Position > 0)
            {
                --cmEvent.Position;
            }
        }

        /// <summary>
        /// make button "DOWN" to go down
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (cmEvent.Position < cmEvent.Count - 1)
            {
                ++cmEvent.Position;
            }
        }

        /// <summary>
        /// once Add button is clicked, show the Add panel and make buttons invisible
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ChangeAddPanelVis(pnlAddEvent, true);
            ChangeButtonVis(false);
        }

        /// <summary>
        /// once Update button is clicked, show the Update panel and make buttons invisible
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ChangeUpdatePanelVis(pnlUpdateEvent, true);
            ChangeButtonVis(false);
        }

        /// <summary>
        /// delete a record
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataRow deleteEventRow = DM.dtEvent.Rows[cmEvent.Position];
            DataRow[] deleteKaiRow = DM.dtKai.Select("KaiID = " + txtEventNo.Text);

            if (deleteKaiRow.Length != 0)
            {
                MessageBox.Show("You may only delete an event that has no kai", "Error");
            }

            else
            {
                if (MessageBox.Show("Would you like to delete this record?", "Warning",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteEventRow.Delete();
                    MessageBox.Show("Event deleted successfully", "Success");
                    DM.UpdateEvent();
                }
            }
        }

        /// <summary>
        /// close the EventForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Add a record
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnAddSave_Click(object sender, EventArgs e)
        {
            DataRow newEventRow = DM.dtEvent.NewRow();

            if (txtAddEventName.Text == "")
            {
                MessageBox.Show("Please type in an Event Name", "Error");
            }

            else
            {
                newEventRow["LocationID"] = DM.dtLocation.Rows[cboAddLocation.SelectedIndex]["LocationID"];
                newEventRow["EventName"] = txtAddEventName.Text;
                newEventRow["EventDate"] = dtpAddEventDate.Value.ToString();

                DM.dtEvent.Rows.Add(newEventRow);
                DM.UpdateEvent();
                MessageBox.Show("Event added successfully", "Success");
            }
        }

        /// <summary>
        /// close the Add panel and make buttons visible
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnAddCancel_Click(object sender, EventArgs e)
        {
            ChangeAddPanelVis(pnlAddEvent, false);
            ChangeButtonVis(true);
        }

        /// <summary>
        /// update an existing record
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnUpdateSave_Click(object sender, EventArgs e)
        {
            DataRow updateEventRow = DM.dtEvent.Rows[cmEvent.Position];

            if (txtUpdateEventName.Text == "")
            {
                MessageBox.Show("Please type in an Event Name", "Error");
            }

            else
            {
                updateEventRow["LocationID"] = DM.dtLocation.Rows[cboUpdateLocation.SelectedIndex]["LocationID"];
                updateEventRow["EventName"] = txtUpdateEventName.Text;
                updateEventRow["EventDate"] = dtpUpdateEventDate.Value.ToString();

                cmEvent.EndCurrentEdit();
                MessageBox.Show("Event updated successfully", "Success");
                DM.UpdateEvent();
            }
        }

        /// <summary>
        /// close the Update panel and make buttons visible
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnUpdateCancel_Click(object sender, EventArgs e)
        {
            ChangeUpdatePanelVis(pnlUpdateEvent, false);
            ChangeButtonVis(true);
        }

        /// <summary>
        /// set Add panel visible or invisible
        /// </summary>
        /// <param name="pnlAddEvent"></param>
        /// <param name="makeVisible"></param>

        private void ChangeAddPanelVis(Panel pnlAddEvent, bool makeVisible)
        {
            pnlAddEvent.Visible = makeVisible;

            foreach (Control control in pnlAddEvent.Controls)
            {
                control.Visible = makeVisible;
            }
        }

        /// <summary>
        /// set Update panel visible or invisible
        /// </summary>
        /// <param name="pnlUpdateEvent"></param>
        /// <param name="makeVisible"></param>

        private void ChangeUpdatePanelVis(Panel pnlUpdateEvent, bool makeVisible)
        {
            pnlUpdateEvent.Visible = makeVisible;

            foreach (Control control in pnlUpdateEvent.Controls)
            {
                control.Visible = makeVisible;
            }
        }

        /// <summary>
        /// set buttons visible or invisible
        /// </summary>
        /// <param name="makeVisible"></param>

        private void ChangeButtonVis(bool makeVisible)
        {
            lstEvent.Visible = makeVisible;
            btnUp.Enabled = makeVisible;
            btnDown.Enabled = makeVisible;
            btnAdd.Enabled = makeVisible;
            btnUpdate.Enabled = makeVisible;
            btnDelete.Enabled = makeVisible;
            btnReturn.Enabled = makeVisible;
        }

        /// <summary>
        /// set dateTimePicker to show the date only
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void dtpAddEventDate_ValueChanged(object sender, EventArgs e)
        {
            dtpAddEventDate.Format = DateTimePickerFormat.Short;
            dtpAddEventDate.Value = DateTime.Today;
        }

        /// <summary>
        /// set dateTimePicker to show the date only
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void dtpUpdateEventDate_ValueChanged(object sender, EventArgs e)
        {
            dtpUpdateEventDate.Format = DateTimePickerFormat.Short;
        }

        /// <summary>
        /// simplify updating the selection of the related record
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void lstEvent_SelectedIndexChanged(object sender, EventArgs e)
        {
            var locationID = DM.dtEvent.Rows[cmEvent.Position]["LocationID"];
            cmLocation.Position = DM.dvLocation.Find(locationID);
        }
    }
}
