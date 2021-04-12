using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Kaioordinate
{
    public partial class DataModule : Form
    {
        public DataTable dtKai;
        public DataTable dtEvent;
        public DataTable dtWhanau;
        public DataTable dtLocation;
        public DataTable dtEventRegister;
        public DataView dvKai;
        public DataView dvEvent;
        public DataView dvWhanau;
        public DataView dvLocation;
        public DataView dvEventRegister;

        public DataModule()
        {
            InitializeComponent();
            dsKaiOordinate.EnforceConstraints = false;
            daKai.Fill(dsKaiOordinate);
            daEvent.Fill(dsKaiOordinate);
            daWhanau.Fill(dsKaiOordinate);
            daLocation.Fill(dsKaiOordinate);
            daEventRegister.Fill(dsKaiOordinate);
            dtKai = dsKaiOordinate.Tables["Kai"];
            dtEvent = dsKaiOordinate.Tables["Event"];
            dtWhanau = dsKaiOordinate.Tables["Whanau"];
            dtLocation = dsKaiOordinate.Tables["Location"];
            dtEventRegister = dsKaiOordinate.Tables["EventRegister"];
            dsKaiOordinate.EnforceConstraints = true;
        }
        public void UpdateKai()
        {
            daKai.Update(dtKai);
        }
        private void daEvent_InfoMessage(object sender, OleDbInfoMessageEventArgs e)
        {

        }
    }
}
