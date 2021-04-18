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

    public partial class EventRegisterForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager cmEvent;
        private CurrencyManager cmWhanau;
        private CurrencyManager cmRegistration;

        /// <summary>
        /// change constructor to accept DataModule and MainForm reference
        /// </summary>
        /// <param name="dm"></param>
        /// <param name="mnu"></param>

        public EventRegisterForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            cmEvent = (CurrencyManager)this.BindingContext[DM.dsKaiOordinate, "Event"];
            cmWhanau = (CurrencyManager)this.BindingContext[DM.dsKaiOordinate, "Whanau"];
            cmRegistration = (CurrencyManager)this.BindingContext[DM.dsKaiOordinate, "EVENT.FK_EVENT_EVENTREGISTER"];
            BindControls();
        }

        /// <summary>
        /// bind the data in the table to data grid views
        /// </summary>

        public void BindControls()
        {
            dgvEvent.DataSource = DM.dsKaiOordinate;
            dgvEvent.DataMember = "Event";

            dgvWhanau.DataSource = DM.dsKaiOordinate;
            dgvWhanau.DataMember = "Whanau";

            dgvRegistration.DataSource = DM.dsKaiOordinate;
            dgvRegistration.DataMember = "EVENT.FK_EVENT_EVENTREGISTER";
        }

        /// <summary>
        /// add a record
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataRow eventRow = DM.dtEvent.Rows[cmEvent.Position];
            DataRow whanauRow = DM.dtWhanau.Rows[cmWhanau.Position];

            DataRow[] newEventRegistration = DM.dtEventRegister.Select($"EventID = {eventRow["EventID"]} and WhanauID = {whanauRow["WhanauID"]}");

            if (newEventRegistration.Length != 0)
            {
                MessageBox.Show("Whanau can only be registered to an event once.", "Error");
            }

            else
            {
                DataRow newEventRegisterRow = DM.dtEventRegister.NewRow();
                newEventRegisterRow["EventID"] = eventRow["EventID"];
                newEventRegisterRow["WhanauID"] = whanauRow["WhanauID"];
                newEventRegisterRow["KaiPreparation"] = cbxKaiPreparationAssistant.Checked;

                DM.dsKaiOordinate.Tables["EventRegister"].Rows.Add(newEventRegisterRow);
                DM.UpdateEventRegister();
                MessageBox.Show("Entry added successfully", "Success");
            }
        }

        /// <summary>
        /// delete a record
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataRow deleteEventRegisterRow = DM.dtEventRegister.Rows[cmRegistration.Position];
            
            if (MessageBox.Show("Would you like to delete this record?", "Warning",
                MessageBoxButtons.OKCancel) == DialogResult.OK)

            {
                deleteEventRegisterRow.Delete();
                DM.UpdateEventRegister();
                MessageBox.Show("Entry removed successfully", "Success");
            }
        }

        /// <summary>
        /// close the EventRegisterForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
