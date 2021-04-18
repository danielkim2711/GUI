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

    public partial class ReportForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private int amountOfReportsPrinted, pagesAmountExpected;
        private DataRow[] reportForPrint;

        public ReportForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
        }

        /// <summary>
        /// close the ReportForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// show the print preview to print the ReportForm when GENERATE REPORT button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            amountOfReportsPrinted = 0;
            reportForPrint = DM.dtEvent.Select();
            pagesAmountExpected = reportForPrint.Length;
            prvReport.Show();
        }

        /// <summary>
        /// set up print document and match the format correctly
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void printReport_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            int linesSoFarHeading = 0;
            Font textFont = new Font("Arial", 10, FontStyle.Regular);
            Font textFontCenter = new Font("Arial", 10, FontStyle.Regular);
            Font totalSubtotal = new Font("Arial", 10, FontStyle.Bold);
            Font headingFont = new Font("Arial", 10, FontStyle.Bold);
            DataRow drEventRegister = reportForPrint[amountOfReportsPrinted];
            CurrencyManager cmEvent;
            CurrencyManager cmWhanau;
            CurrencyManager cmLocation;

            cmEvent = (CurrencyManager)this.BindingContext[DM.dsKaiOordinate, "EVENT"];
            cmWhanau = (CurrencyManager)this.BindingContext[DM.dsKaiOordinate, "WHANAU"];
            cmLocation = (CurrencyManager)this.BindingContext[DM.dsKaiOordinate, "LOCATION"];

            Brush brush = new SolidBrush(Color.Black);

            int leftMargin = e.MarginBounds.Left;
            int topMargin = e.MarginBounds.Top;
            int headingLeftMargin = 50;
            int topMarginDetails = topMargin + 70;
            int rightMargin = e.MarginBounds.Right;

            cmEvent.Position = DM.dvEvent.Find(drEventRegister["EventID"]);
            DataRow drEvent = DM.dtEvent.Rows[cmEvent.Position];

            cmLocation.Position = DM.dvLocation.Find(drEvent["LocationID"]);
            DataRow drLocation = DM.dtLocation.Rows[cmLocation.Position];
            
            g.DrawString("Event ID: " + drEvent["EventID"], headingFont, brush, leftMargin + headingLeftMargin,
                topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            linesSoFarHeading++;
            linesSoFarHeading++;

            g.DrawString("Event Name: ", headingFont, brush, leftMargin + headingLeftMargin,
                topMargin + (linesSoFarHeading * textFont.Height));

            g.DrawString("\t\t" + drEvent["EventName"], textFont, brush, leftMargin + headingLeftMargin,
                topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;

            g.DrawString("Date: ", headingFont, brush, leftMargin + headingLeftMargin,
                topMargin + (linesSoFarHeading * textFont.Height));

            g.DrawString("\t\t" + drEvent["EventDate"], textFont, brush, leftMargin + headingLeftMargin,
                topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;

            g.DrawString("Location: ", headingFont, brush, leftMargin + headingLeftMargin,
                topMargin + (linesSoFarHeading * textFont.Height));

            g.DrawString("\t\t" + drLocation["LocationName"], textFont, brush, leftMargin + headingLeftMargin,
                topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;

            g.DrawString("Address: ", headingFont, brush, leftMargin + headingLeftMargin,
                topMargin + (linesSoFarHeading * textFont.Height));

            g.DrawString("\t\t" + drLocation["Address"], textFont, brush, leftMargin + headingLeftMargin,
                topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            linesSoFarHeading++;
            linesSoFarHeading++;

            g.DrawString("Attendees: ", headingFont, brush, leftMargin + headingLeftMargin,
                topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            linesSoFarHeading++;
            linesSoFarHeading++;

            g.DrawString("First Name",
                headingFont, brush, leftMargin +
                headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));

            g.DrawString("\t\t\t Last Name",
                headingFont, brush, leftMargin +
                headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));

            g.DrawString("\t\t\t\t\t\t Phone No.",
                headingFont, brush, leftMargin +
                headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));

            g.DrawString("\t\t\t\t\t\t\t\t\t Helper",
                headingFont, brush, leftMargin +
                headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            linesSoFarHeading++;

            DataRow[] drRegistration = drEvent.GetChildRows(DM.dtEvent.ChildRelations["FK_EVENT_EVENTREGISTER"]);
            foreach (DataRow drReg in drRegistration)
            {
                DataRow drWhanau = drReg.GetParentRow(DM.dtEventRegister.ParentRelations["FK_WHANAU_EVENTREGISTER"]);
                
                g.DrawString(drWhanau["FirstName"] + "",
                    textFont, brush, leftMargin +
                    headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));

                g.DrawString("\t\t\t" + drWhanau["LastName"],
                    textFont, brush, leftMargin +
                    headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));

                g.DrawString("\t\t\t\t\t\t" + drWhanau["Phone"],
                    textFont, brush, leftMargin +
                    headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));

                g.DrawString("\t\t\t\t\t\t\t\t\t" + drReg["KaiPreparation"],
                    textFont, brush, leftMargin +
                    headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
                linesSoFarHeading++;
                linesSoFarHeading++;
            }

            amountOfReportsPrinted++;
            e.HasMorePages = !(pagesAmountExpected == amountOfReportsPrinted);
        }
    }
}