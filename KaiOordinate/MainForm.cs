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
    /// reference to the forms
    /// </summary>
    public partial class MainForm : Form
    {
        private DataModule DM;
        private KaiForm frmKai;
        private EventForm frmEvent;
        private WhanauForm frmWhanau;
        private LocationForm frmLocation;
        private EventRegisterForm frmEventRegister;
        private ReportForm frmReport;

        public MainForm()
        {
            InitializeComponent();
        }
        
        private void MainForm_Load(object sender, EventArgs e)
        {
            DM = new DataModule(); // Create the data module and load the dataset
        }

        /// <summary>
        /// open KaiForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnKai_Click(object sender, EventArgs e)
        {
            if (frmKai == null)
            {
                frmKai = new KaiForm(DM, this);
            }
            frmKai.ShowDialog();
        }

        private void btnEvent_Click(object sender, EventArgs e)
        {
            if (frmEvent == null)
            {
                frmEvent = new EventForm(DM, this);
            }
            frmEvent.ShowDialog();

        }

        private void btnWhanau_Click(object sender, EventArgs e)
        {
            if (frmWhanau == null)
            {
                frmWhanau = new WhanauForm(DM, this);
            }
            frmWhanau.ShowDialog();
        }

        private void btnLocation_Click(object sender, EventArgs e)
        {
            if (frmLocation == null)
            {
                frmLocation = new LocationForm(DM, this);
            }
            frmLocation.ShowDialog();

        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            if (frmEventRegister == null)
            {
                frmEventRegister = new EventRegisterForm(DM, this);
            }
            frmEventRegister.ShowDialog();

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (frmReport == null)
            {
                frmReport = new ReportForm(DM, this);
            }
            frmReport.ShowDialog();

        }

        /// <summary>
        /// close the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
