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
        /// bind the data in the Kai table to the text boxes and the listbox
        /// </summary>
        public void BindControls()
        {
            txtKaiNo.DataBindings.Add("Text", DM.dsKaiOordinate, "Kai.KaiID");
            txtEvent.DataBindings.Add("Text", DM.dsKaiOordinate, "Event.EventName");
            txtKaiName.DataBindings.Add("Text", DM.dsKaiOordinate, "Kai.KaiName");
            txtPreparation.DataBindings.Add("Text", DM.dsKaiOordinate, "Kai.PreparationRequired");
            txtPreparationTime.DataBindings.Add("Text", DM.dsKaiOordinate, "Kai.PreparationMinutes");
            txtServingQuantity.DataBindings.Add("Text", DM.dsKaiOordinate, "Kai.ServeQuantity");
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
        /// once Add button is clicked, show the panel and make buttons invisible
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ChangePanelVis(pnlAddKai, true);
            ChangeButtonVis(false);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// delete a record
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataRow deleteKaiRow = DM.dtKai.Rows[cmKai.Position];
            DataRow[] eventKaiRow = DM.dtEvent.Select("KaiID = " + txtKaiNo.Text);
            if (eventKaiRow.Length != 0)
            {
                MessageBox.Show("You may only delete Kai that have no event relation", "Error");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
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

        private void lstKai_SelectedIndexChanged(object sender, EventArgs e)
        {
            var eventID = DM.dtKai.Rows[cmKai.Position]["EventID"];
            cmEvent.Position = DM.dvEvent.Find(eventID);
        }

        private void btnAddSave_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// show the panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnAddCancel_Click(object sender, EventArgs e)
        {
            ChangePanelVis(pnlAddKai, false);
            ChangeButtonVis(true);
        }

        /// <summary>
        /// set a panel visible or invisible
        /// </summary>
        /// <param name="pnlAddKai"></param>
        /// <param name="makeVisible"></param>

        private void ChangePanelVis(Panel pnlAddKai, bool makeVisible)
        {
            pnlAddKai.Visible = makeVisible;

            foreach (Control control in pnlAddKai.Controls)
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

    }
}
