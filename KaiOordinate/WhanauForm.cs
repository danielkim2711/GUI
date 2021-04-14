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
    public partial class WhanauForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager cmWhanau;

        /// <summary>
        /// change constructor to accept DataModule and MainForm reference
        /// </summary>
        /// <param name="dm"></param>
        /// <param name="mnu"></param>

        public WhanauForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
        }

        /// <summary>
        /// bind the data in the Whanau table
        /// </summary>

        public void BindControls()
        {
            txtWhanauNo.DataBindings.Add("Text", DM.dsKaiOordinate, "Whanau.WhanauID");
            txtFirstName.DataBindings.Add("Text", DM.dsKaiOordinate, "Whanau.FirstName");
            txtLastName.DataBindings.Add("Text", DM.dsKaiOordinate, "Whanau.LastName");
            txtEmail.DataBindings.Add("Text", DM.dsKaiOordinate, "Whanau.Email");
            txtPhone.DataBindings.Add("Text", DM.dsKaiOordinate, "Whanau.Phone");
            txtAddress.DataBindings.Add("Text", DM.dsKaiOordinate, "Whanau.Address");
            txtUpdateFirstName.DataBindings.Add("Text", DM.dsKaiOordinate, "Whanau.FirstName");
            txtUpdateLastName.DataBindings.Add("Text", DM.dsKaiOordinate, "Whanau.LastName");
            txtUpdateEmail.DataBindings.Add("Text", DM.dsKaiOordinate, "Whanau.Email");
            txtUpdatePhone.DataBindings.Add("Text", DM.dsKaiOordinate, "Whanau.Phone");
            txtUpdateAddress.DataBindings.Add("Text", DM.dsKaiOordinate, "Whanau.Address");

            lstWhanau.DataSource = DM.dsKaiOordinate;
            lstWhanau.DisplayMember = "Whanau.FirstName";
            lstWhanau.ValueMember = "Whanau.FirstName";
            cmWhanau = (CurrencyManager)this.BindingContext[DM.dsKaiOordinate, "Whanau"];
        }

        /// <summary>
        /// make button "UP" to go up
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (cmWhanau.Position > 0)
            {
                --cmWhanau.Position;
            }
        }

        /// <summary>
        /// make button "DOWN" to go down
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (cmWhanau.Position < cmWhanau.Count - 1)
            {
                ++cmWhanau.Position;
            }
        }

        /// <summary>
        /// once Add button is clicked, show the Add panel and make buttons invisible
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ChangeAddPanelVis(pnlAddWhanau, true);
            ChangeButtonVis(false);
        }

        /// <summary>
        /// once Update button is clicked, show the Update panel and make buttons invisible
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ChangeUpdatePanelVis(pnlUpdateWhanau, true);
            ChangeButtonVis(false);
        }

        /// <summary>
        /// delete a record
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataRow deleteWhanauRow = DM.dtWhanau.Rows[cmWhanau.Position];
            DataRow[] EventRegistrationRow = DM.dtEventRegister.Select("RegistrationID = " + txtWhanauNo.Text);

            if (EventRegistrationRow.Length != 0)
            {
                MessageBox.Show("You may only delete records that have no registrations", "Error");
            }

            else
            {
                if (MessageBox.Show("Would you like to delete this record?", "Warning",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteWhanauRow.Delete();
                    MessageBox.Show("Record deleted successfully", "Success");
                    DM.UpdateWhanau();
                }
            }
        }

        /// <summary>
        /// close the WhanauForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// update an existing record
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnUpdateSave_Click(object sender, EventArgs e)
        {
            DataRow updateWhanauRow = DM.dtWhanau.Rows[cmWhanau.Position];

            if ((txtUpdateFirstName.Text == "") || (txtUpdateLastName.Text == ""))
            {
                MessageBox.Show("Please type in a First Name and Last Name", "Error");
            }

            else
            {
                updateWhanauRow["FirstName"] = txtUpdateFirstName.Text;
                updateWhanauRow["LastName"] = txtUpdateLastName.Text;
                updateWhanauRow["Email"] = txtUpdateEmail.Text;
                updateWhanauRow["Phone"] = txtUpdatePhone.Text;
                updateWhanauRow["Address"] = txtUpdateAddress.Text;

                cmWhanau.EndCurrentEdit();
                DM.UpdateWhanau();

                MessageBox.Show("Whānau updated successfully", "Success");
            }
        }

        /// <summary>
        /// close the Update panel and make buttons visible
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnUpdateCancel_Click(object sender, EventArgs e)
        {
            ChangeUpdatePanelVis(pnlUpdateWhanau, false);
            ChangeButtonVis(true);
        }

        /// <summary>
        /// Add a record
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnAddSave_Click(object sender, EventArgs e)
        {
            DataRow newWhanauRow = DM.dtWhanau.NewRow();

            if ((txtAddFirstName.Text == "") || (txtAddLastName.Text == ""))
            {
                MessageBox.Show("Please type in a First Name and Last Name", "Error");
            }

            else
            {
                newWhanauRow["FirstName"] = txtAddFirstName.Text;
                newWhanauRow["LastName"] = txtAddLastName.Text;
                newWhanauRow["Email"] = txtAddEmail.Text;
                newWhanauRow["Phone"] = txtAddPhone.Text;
                newWhanauRow["Address"] = txtAddAddress.Text;


                DM.dtWhanau.Rows.Add(newWhanauRow);
                MessageBox.Show("Whānau added successfully", "Success");
                DM.UpdateWhanau();
            }
        }

        /// <summary>
        /// close the Add panel and make buttons visible
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnAddCancel_Click(object sender, EventArgs e)
        {
            ChangeAddPanelVis(pnlAddWhanau, false);
            ChangeButtonVis(true);
        }

        /// <summary>
        /// set Add panel visible or invisible
        /// </summary>
        /// <param name="pnlAddWhanau"></param>
        /// <param name="makeVisible"></param>

        private void ChangeAddPanelVis(Panel pnlAddWhanau, bool makeVisible)
        {
            pnlAddWhanau.Visible = makeVisible;

            foreach (Control control in pnlAddWhanau.Controls)
            {
                control.Visible = makeVisible;
            }
        }

        /// <summary>
        /// set Update panel visible or invisible
        /// </summary>
        /// <param name="pnlUpdateWhanau"></param>
        /// <param name="makeVisible"></param>

        private void ChangeUpdatePanelVis(Panel pnlUpdateWhanau, bool makeVisible)
        {
            pnlUpdateWhanau.Visible = makeVisible;

            foreach (Control control in pnlUpdateWhanau.Controls)
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
            lstWhanau.Visible = makeVisible;
            btnUp.Enabled = makeVisible;
            btnDown.Enabled = makeVisible;
            btnAdd.Enabled = makeVisible;
            btnUpdate.Enabled = makeVisible;
            btnDelete.Enabled = makeVisible;
            btnReturn.Enabled = makeVisible;
        }

        /// <summary>
        /// display multiple values as a single row in a listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void lstWhanau_Format(object sender, ListControlConvertEventArgs e)
        {
            DataRow dr = ((DataRowView)e.ListItem).Row;
            string fName = dr["FirstName"].ToString();
            string lName = dr["LastName"].ToString();

            e.Value = fName + " " + lName;
        }
    }
}
