﻿
namespace Kaioordinate
{
    partial class ReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            this.btnGenerateReport = new FontAwesome.Sharp.IconButton();
            this.btnReturn = new FontAwesome.Sharp.IconButton();
            this.printReport = new System.Drawing.Printing.PrintDocument();
            this.prvReport = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnGenerateReport.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateReport.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btnGenerateReport.IconColor = System.Drawing.Color.Black;
            this.btnGenerateReport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGenerateReport.IconSize = 60;
            this.btnGenerateReport.Location = new System.Drawing.Point(21, 21);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(119, 122);
            this.btnGenerateReport.TabIndex = 60;
            this.btnGenerateReport.Text = "GENERATE REPORT";
            this.btnGenerateReport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGenerateReport.UseVisualStyleBackColor = false;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnReturn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnReturn.IconColor = System.Drawing.Color.Black;
            this.btnReturn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReturn.IconSize = 80;
            this.btnReturn.Location = new System.Drawing.Point(170, 21);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(119, 122);
            this.btnReturn.TabIndex = 61;
            this.btnReturn.Text = "RETURN";
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // printReport
            // 
            this.printReport.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printReport_PrintPage);
            // 
            // prvReport
            // 
            this.prvReport.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.prvReport.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.prvReport.ClientSize = new System.Drawing.Size(400, 300);
            this.prvReport.Document = this.printReport;
            this.prvReport.Enabled = true;
            this.prvReport.Icon = ((System.Drawing.Icon)(resources.GetObject("prvReport.Icon")));
            this.prvReport.Name = "prvReport";
            this.prvReport.Visible = false;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(73)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(304, 161);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnGenerateReport);
            this.Name = "ReportForm";
            this.Text = "Report";
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnGenerateReport;
        private FontAwesome.Sharp.IconButton btnReturn;
        private System.Drawing.Printing.PrintDocument printReport;
        private System.Windows.Forms.PrintPreviewDialog prvReport;
    }
}