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
            dvKai = new DataView(dtKai);
            dvKai.Sort = "KaiID";
            dvEvent = new DataView(dtEvent);
            dvEvent.Sort = "EventID";
            dvWhanau = new DataView(dtWhanau);
            dvWhanau.Sort = "WhanauID";
            dvLocation = new DataView(dtLocation);
            dvLocation.Sort = "LocationID";
            dvEventRegister = new DataView(dtEventRegister);
            dvEventRegister.Sort = "RegistrationID";
            dsKaiOordinate.EnforceConstraints = true;
        }

        public void UpdateKai()
        {
            daKai.Update(dtKai);
        }

        public void UpdateEvent()
        {
            daEvent.Update(dtEvent);
        }

        public void UpdateWhanau()
        {
            daWhanau.Update(dtWhanau);
        }

        public void UpdateLocation()
        {
            daLocation.Update(dtLocation);
        }

        private void daEvent_InfoMessage(object sender, OleDbInfoMessageEventArgs e)
        {

        }

        /// <summary>
        /// solve the -1 problem for each form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void daKai_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            int newID = 0;

            OleDbCommand idCMD = new OleDbCommand("SELECT  @@IDENTITY", ctnKai);

            if (e.StatementType == StatementType.Insert)
            {
                newID = (int)idCMD.ExecuteScalar();
                e.Row["KaiID"] = newID;
            }
        }

        private void daEvent_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            int newID = 0;

            OleDbCommand idCMD = new OleDbCommand("SELECT  @@IDENTITY", ctnKai);

            if (e.StatementType == StatementType.Insert)
            {
                newID = (int)idCMD.ExecuteScalar();
                e.Row["EventID"] = newID;
            }
        }

        private void daWhanau_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            int newID = 0;

            OleDbCommand idCMD = new OleDbCommand("SELECT  @@IDENTITY", ctnKai);

            if (e.StatementType == StatementType.Insert)
            {
                newID = (int)idCMD.ExecuteScalar();
                e.Row["WhanauID"] = newID;
            }
        }

        private void daLocation_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            int newID = 0;

            OleDbCommand idCMD = new OleDbCommand("SELECT  @@IDENTITY", ctnKai);

            if (e.StatementType == StatementType.Insert)
            {
                newID = (int)idCMD.ExecuteScalar();
                e.Row["LocationID"] = newID;
            }
        }

        private void daEventRegister_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            int newID = 0;

            OleDbCommand idCMD = new OleDbCommand("SELECT  @@IDENTITY", ctnKai);

            if (e.StatementType == StatementType.Insert)
            {
                newID = (int)idCMD.ExecuteScalar();
                e.Row["RegistrationID"] = newID;
            }
        }
    }
}
