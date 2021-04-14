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
    public partial class KaiForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager cmKai;
        private CurrencyManager cmEvent;

        /// <summary>
        /// change constructor to accept DataModule and MainForm reference
        /// </summary>
        /// <param name="dm"></param>
        /// <param name="mnu"></param>

        public KaiForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
        }

        /// <summary>
        /// bind the data in the Kai table
        /// </summary>

        public void BindControls()
        {
            txtKaiNo.DataBindings.Add("Text", DM.dsKaiOordinate, "Kai.KaiID");
            txtEvent.DataBindings.Add("Text", DM.dsKaiOordinate, "Event.EventName");
            txtKaiName.DataBindings.Add("Text", DM.dsKaiOordinate, "Kai.KaiName");
            txtPreparation.DataBindings.Add("Text", DM.dsKaiOordinate, "Kai.PreparationRequired");
            txtPreparationTime.DataBindings.Add("Text", DM.dsKaiOordinate, "Kai.PreparationMinutes");
            txtServingQuantity.DataBindings.Add("Text", DM.dsKaiOordinate, "Kai.ServeQuantity");
            cboAddEvent.DataBindings.Add("Text", DM.dsKaiOordinate, "Event.EventName");
            cboUpdateEvent.DataBindings.Add("Text", DM.dsKaiOordinate, "Event.EventName");
            lstKai.DataSource = DM.dsKaiOordinate;
            lstKai.DisplayMember = "Kai.KaiName";
            lstKai.ValueMember = "Kai.KaiName";
            cmKai = (CurrencyManager)this.BindingContext[DM.dsKaiOordinate, "Kai"];
            cmEvent = (CurrencyManager)this.BindingContext[DM.dsKaiOordinate, "Event"];
        }

        /// <summary>
        /// make button "UP" to go up
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (cmKai.Position > 0)
            {
                --cmKai.Position;
            }
        }

        /// <summary>
        /// make button "DOWN" to go down
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (cmKai.Position < cmKai.Count - 1)
            {
                ++cmKai.Position;
            }
        }

        /// <summary>
        /// once Add button is clicked, show the Add panel and make buttons invisible
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ChangeAddPanelVis(pnlAddKai, true);
            ChangeButtonVis(false);
        }

        /// <summary>
        /// once Update button is clicked, show the Update panel and make buttons invisible
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ChangeUpdatePanelVis(pnlUpdateKai, true);
            ChangeButtonVis(false);
        }

        /// <summary>
        /// delete a record
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataRow deleteKaiRow = DM.dtKai.Rows[cmKai.Position];
            DataRow[] EventRow = DM.dtEvent.Select("EventID = " + txtKaiNo.Text);

            if (EventRow.Length != 0)
            {
                MessageBox.Show("You may only delete Kai that have no event relation", "Error");
            }

            else
            {
                if (MessageBox.Show("Would you like to delete this record?", "Warning",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteKaiRow.Delete();
                    MessageBox.Show("Kai deleted successfully", "Success");
                    DM.UpdateKai();
                }
            }
        }

        /// <summary>
        /// close the KaiForm
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
            DataRow newKaiRow = DM.dtKai.NewRow();

            if ((txtAddKaiName.Text == "") || (numAddServingQuantity.Value == 0))
            {
                MessageBox.Show("Please type in a Kai Name and Serving Quantity", "Error");
            }

            else
            {
                newKaiRow["KaiName"] = txtAddKaiName.Text;
                newKaiRow["PreparationRequired"] = cbxAddPreparation.Checked;
                newKaiRow["PreparationMinutes"] = numAddPreparationTime.Value;
                newKaiRow["ServeQuantity"] = numAddServingQuantity.Value;

                DM.dtKai.Rows.Add(newKaiRow);
                MessageBox.Show("Kai added successfully", "Success");
                DM.UpdateKai();
            }
        }

        /// <summary>
        /// close the Add panel and make buttons visible
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnAddCancel_Click(object sender, EventArgs e)
        {
            ChangeAddPanelVis(pnlAddKai, false);
            ChangeButtonVis(true);
        }

        /// <summary>
        /// update an existing record
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnUpdateSave_Click(object sender, EventArgs e)
        {
            DataRow updateKaiRow = DM.dtKai.Rows[cmKai.Position];
            DataRow updateEventRow = DM.dtEvent.Rows[cmEvent.Position];

            if ((txtUpdateKaiName.Text == "") || (numUpdateServingQuantity.Value == 0))
            {
                MessageBox.Show("Please type in a Kai Name and Serving Quantity", "Error");
            }

            else
            {
                updateKaiRow["KaiName"] = txtUpdateKaiName.Text;
                updateEventRow["EventName"] = cboUpdateEvent.Text;
                updateKaiRow["PreparationRequired"] = cbxUpdatePreparation.Checked;
                updateKaiRow["PreparationMinutes"] = numUpdatePreparationTime.Value;
                updateKaiRow["ServeQuantity"] = numUpdateServingQuantity.Value;

                cmKai.EndCurrentEdit();
                DM.UpdateKai();

                MessageBox.Show("Kai updated successfully", "Success");
            }
        }

        /// <summary>
        /// close the Update panel and make buttons visible
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnUpdateCancel_Click(object sender, EventArgs e)
        {
            ChangeUpdatePanelVis(pnlUpdateKai, false);
            ChangeButtonVis(true);
        }

        /// <summary>
        /// set Add panel visible or invisible
        /// </summary>
        /// <param name="pnlAddKai"></param>
        /// <param name="makeVisible"></param>

        private void ChangeAddPanelVis(Panel pnlAddKai, bool makeVisible)
        {
            pnlAddKai.Visible = makeVisible;

            foreach (Control control in pnlAddKai.Controls)
            {
                control.Visible = makeVisible;
            }
        }

        /// <summary>
        /// set Update panel visible or invisible
        /// </summary>
        /// <param name="pnlUpdateKai"></param>
        /// <param name="makeVisible"></param>

        private void ChangeUpdatePanelVis(Panel pnlUpdateKai, bool makeVisible)
        {
            pnlUpdateKai.Visible = makeVisible;

            foreach (Control control in pnlUpdateKai.Controls)
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
            lstKai.Visible = makeVisible;
            btnUp.Enabled = makeVisible;
            btnDown.Enabled = makeVisible;
            btnAdd.Enabled = makeVisible;
            btnUpdate.Enabled = makeVisible;
            btnDelete.Enabled = makeVisible;
            btnReturn.Enabled = makeVisible;
        }

        /// <summary>
        /// If checkbox is ticked, enable PreparationTime and reset the value if disabled
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void cbxAddPreparation_CheckedChanged(object sender, EventArgs e)
        {
            numAddPreparationTime.Enabled = cbxAddPreparation.Checked;

            if (numAddPreparationTime.Enabled != true)
                numAddPreparationTime.Value = 0;
        }

        /// <summary>
        /// If checkbox is ticked, enable PreparationTime and reset the value if disabled
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void cbxUpdatePreparation_CheckedChanged(object sender, EventArgs e)
        {
            numUpdatePreparationTime.Enabled = cbxUpdatePreparation.Checked;

            if (numUpdatePreparationTime.Enabled != true)
                numUpdatePreparationTime.Value = 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void lstKai_SelectedIndexChanged(object sender, EventArgs e)
        {
            var eventID = DM.dtKai.Rows[cmKai.Position]["EventID"];
            cmEvent.Position = DM.dvEvent.Find(eventID);
        }
    }
}
