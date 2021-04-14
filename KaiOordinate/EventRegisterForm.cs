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
    public partial class EventRegisterForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager cmEvent;
        private CurrencyManager cmWhanau;
        private CurrencyManager cmRegistration;
        private DataTable dt = new DataTable();
        private CurrencyManager cmDt;

        /// <summary>
        /// 
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
            cmRegistration = (CurrencyManager)this.BindingContext[DM.dsKaiOordinate, "EventRegister"];

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
            dgvRegistration.DataMember = "EventRegister";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

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
