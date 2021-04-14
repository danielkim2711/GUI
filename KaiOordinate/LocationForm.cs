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
    public partial class LocationForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager cmLocation;

        /// <summary>
        /// change constructor to accept DataModule and MainForm reference
        /// </summary>
        /// <param name="dm"></param>
        /// <param name="mnu"></param>

        public LocationForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
        }

        /// <summary>
        /// bind the data in the Location table
        /// </summary>

        public void BindControls()
        {
            txtLocationNo.DataBindings.Add("Text", DM.dsKaiOordinate, "Location.LocationID");
            txtLocationName.DataBindings.Add("Text", DM.dsKaiOordinate, "Location.LocationName");
            txtAddress.DataBindings.Add("Text", DM.dsKaiOordinate, "Location.Address");
            txtUpdateLocationName.DataBindings.Add("Text", DM.dsKaiOordinate, "Location.LocationName");
            txtUpdateAddress.DataBindings.Add("Text", DM.dsKaiOordinate, "Location.Address");

            lstLocation.DataSource = DM.dsKaiOordinate;
            lstLocation.DisplayMember = "Location.LocationName";
            lstLocation.ValueMember = "Location.LocationName";
            cmLocation = (CurrencyManager)this.BindingContext[DM.dsKaiOordinate, "Location"];
        }

        /// <summary>
        /// make button "UP" to go up
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (cmLocation.Position > 0)
            {
                --cmLocation.Position;
            }
        }

        /// <summary>
        /// make button "DOWN" to go down
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (cmLocation.Position < cmLocation.Count - 1)
            {
                ++cmLocation.Position;
            }
        }

        /// <summary>
        /// once Add button is clicked, show the Add panel and make buttons invisible
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ChangeAddPanelVis(pnlAddLocation, true);
            ChangeButtonVis(false);
        }

        /// <summary>
        /// once Update button is clicked, show the Update panel and make buttons invisible
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ChangeUpdatePanelVis(pnlUpdateLocation, true);
            ChangeButtonVis(false);
        }

        /// <summary>
        /// delete a record
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataRow deleteLocationRow = DM.dtLocation.Rows[cmLocation.Position];
            DataRow[] EventRow = DM.dtEvent.Select("EventID = " + txtLocationNo.Text);

            if (EventRow.Length != 0)
            {
                MessageBox.Show("You may only delete locations that have no events", "Error");
            }

            else
            {
                if (MessageBox.Show("Would you like to delete this record?", "Warning",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteLocationRow.Delete();
                    MessageBox.Show("Location deleted successfully", "Success");
                    DM.UpdateLocation();
                }
            }
        }

        /// <summary>
        /// close the LocationForm
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
            DataRow newLocationRow = DM.dtLocation.NewRow();

            if (txtAddLocationName.Text == "")
            {
                MessageBox.Show("Please type in a Location Name", "Error");
            }

            else
            {
                newLocationRow["LocationName"] = txtAddLocationName.Text;
                newLocationRow["Address"] = txtAddAddress.Text;

                DM.dtLocation.Rows.Add(newLocationRow);
                MessageBox.Show("Location added successfully", "Success");
                DM.UpdateLocation();
            }
        }

        /// <summary>
        /// close the Add panel and make buttons visible
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnAddCancel_Click(object sender, EventArgs e)
        {
            ChangeAddPanelVis(pnlAddLocation, false);
            ChangeButtonVis(true);
        }

        /// <summary>
        /// update an existing record
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnUpdateSave_Click(object sender, EventArgs e)
        {
            DataRow updateLocationRow = DM.dtLocation.Rows[cmLocation.Position];

            if (txtUpdateLocationName.Text == "")
            {
                MessageBox.Show("Please type in a Location Name", "Error");
            }

            else
            {
                updateLocationRow["LocationName"] = txtUpdateLocationName.Text;
                updateLocationRow["Address"] = txtUpdateAddress.Text;

                cmLocation.EndCurrentEdit();
                DM.UpdateLocation();

                MessageBox.Show("Location updated successfully", "Success");
            }
        }

        /// <summary>
        /// close the Update panel and make buttons visible
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnUpdateCancel_Click(object sender, EventArgs e)
        {
            ChangeUpdatePanelVis(pnlUpdateLocation, false);
            ChangeButtonVis(true);
        }

        /// <summary>
        /// set Add panel visible or invisible
        /// </summary>
        /// <param name="pnlAddLocation"></param>
        /// <param name="makeVisible"></param>

        private void ChangeAddPanelVis(Panel pnlAddLocation, bool makeVisible)
        {
            pnlAddLocation.Visible = makeVisible;

            foreach (Control control in pnlAddLocation.Controls)
            {
                control.Visible = makeVisible;
            }
        }

        /// <summary>
        /// set Update panel visible or invisible
        /// </summary>
        /// <param name="pnlUpdateLocation"></param>
        /// <param name="makeVisible"></param>
       
        private void ChangeUpdatePanelVis(Panel pnlUpdateLocation, bool makeVisible)
        {
            pnlUpdateLocation.Visible = makeVisible;

            foreach (Control control in pnlUpdateLocation.Controls)
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
            lstLocation.Visible = makeVisible;
            btnUp.Enabled = makeVisible;
            btnDown.Enabled = makeVisible;
            btnAdd.Enabled = makeVisible;
            btnUpdate.Enabled = makeVisible;
            btnDelete.Enabled = makeVisible;
            btnReturn.Enabled = makeVisible;
        }
    }
}
