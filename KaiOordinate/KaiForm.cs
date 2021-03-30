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
        /// make button UP go up
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
        /// make button DOWN go down
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
        /// hide the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lstKai.Enabled = false;
            lstKai.Visible = false;
            btnUp.Enabled = false;
            btnDown.Enabled = false;
            btnAdd.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnReturn.Enabled = false;
            pnlKaiForm.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lstKai_SelectedIndexChanged(object sender, EventArgs e)
        {
            var eventID = DM.dtKai.Rows[cmKai.Position]["EventID"];
            cmEvent.Position = DM.dvEvent.Find(eventID);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// show the panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlKaiForm.Hide();
            lstKai.Enabled = true;
            lstKai.Visible = true;
            btnUp.Enabled = true;
            btnDown.Enabled = true;
            btnAdd.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnReturn.Enabled = true;
        }

        private void ChangePanelVis(Panel pnlKaiForm, bool makeVisible)
        {
            pnlKaiForm.Visible = makeVisible;

            foreach (Control control in pnlKaiForm.Controls)
            {
                control.Visible = makeVisible;
            }
        }
    }
}
