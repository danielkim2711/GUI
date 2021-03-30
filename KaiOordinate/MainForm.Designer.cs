
namespace Kaioordinate
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnKai = new FontAwesome.Sharp.IconButton();
            this.btnEvent = new FontAwesome.Sharp.IconButton();
            this.btnLocation = new FontAwesome.Sharp.IconButton();
            this.btnWhanau = new FontAwesome.Sharp.IconButton();
            this.btnReport = new FontAwesome.Sharp.IconButton();
            this.btnRegistration = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // btnKai
            // 
            this.btnKai.BackColor = System.Drawing.SystemColors.Control;
            this.btnKai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnKai.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKai.IconChar = FontAwesome.Sharp.IconChar.DrumstickBite;
            this.btnKai.IconColor = System.Drawing.Color.Black;
            this.btnKai.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnKai.IconSize = 80;
            this.btnKai.Location = new System.Drawing.Point(40, 261);
            this.btnKai.Name = "btnKai";
            this.btnKai.Size = new System.Drawing.Size(153, 130);
            this.btnKai.TabIndex = 0;
            this.btnKai.Text = "KAI";
            this.btnKai.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKai.UseVisualStyleBackColor = false;
            this.btnKai.Click += new System.EventHandler(this.btnKai_Click);
            // 
            // btnEvent
            // 
            this.btnEvent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEvent.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvent.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.btnEvent.IconColor = System.Drawing.Color.Black;
            this.btnEvent.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEvent.IconSize = 80;
            this.btnEvent.Location = new System.Drawing.Point(217, 261);
            this.btnEvent.Name = "btnEvent";
            this.btnEvent.Size = new System.Drawing.Size(153, 130);
            this.btnEvent.TabIndex = 1;
            this.btnEvent.Text = "EVENTS";
            this.btnEvent.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEvent.UseVisualStyleBackColor = true;
            this.btnEvent.Click += new System.EventHandler(this.btnEvent_Click);
            // 
            // btnLocation
            // 
            this.btnLocation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLocation.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocation.IconChar = FontAwesome.Sharp.IconChar.MapMarkedAlt;
            this.btnLocation.IconColor = System.Drawing.Color.Black;
            this.btnLocation.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLocation.IconSize = 80;
            this.btnLocation.Location = new System.Drawing.Point(558, 261);
            this.btnLocation.Name = "btnLocation";
            this.btnLocation.Size = new System.Drawing.Size(153, 130);
            this.btnLocation.TabIndex = 3;
            this.btnLocation.Text = "LOCATIONS";
            this.btnLocation.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLocation.UseVisualStyleBackColor = true;
            this.btnLocation.Click += new System.EventHandler(this.btnLocation_Click);
            // 
            // btnWhanau
            // 
            this.btnWhanau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnWhanau.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWhanau.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnWhanau.IconColor = System.Drawing.Color.Black;
            this.btnWhanau.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnWhanau.IconSize = 80;
            this.btnWhanau.Location = new System.Drawing.Point(386, 261);
            this.btnWhanau.Name = "btnWhanau";
            this.btnWhanau.Size = new System.Drawing.Size(153, 130);
            this.btnWhanau.TabIndex = 2;
            this.btnWhanau.Text = "WHĀNAU";
            this.btnWhanau.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnWhanau.UseVisualStyleBackColor = true;
            this.btnWhanau.Click += new System.EventHandler(this.btnWhanau_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnReport.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btnReport.IconColor = System.Drawing.Color.Black;
            this.btnReport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReport.IconSize = 80;
            this.btnReport.Location = new System.Drawing.Point(217, 407);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(153, 130);
            this.btnReport.TabIndex = 5;
            this.btnReport.Text = "REPORT";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnRegistration
            // 
            this.btnRegistration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRegistration.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistration.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.btnRegistration.IconColor = System.Drawing.Color.Black;
            this.btnRegistration.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegistration.IconSize = 80;
            this.btnRegistration.Location = new System.Drawing.Point(40, 407);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(153, 130);
            this.btnRegistration.TabIndex = 4;
            this.btnRegistration.Text = "REGISTRATION";
            this.btnRegistration.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRegistration.UseVisualStyleBackColor = true;
            this.btnRegistration.Click += new System.EventHandler(this.btnRegistration_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnExit.IconColor = System.Drawing.Color.Black;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 80;
            this.btnExit.Location = new System.Drawing.Point(558, 407);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(153, 130);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "EXIT";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(73)))), ((int)(((byte)(41)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(746, 581);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnRegistration);
            this.Controls.Add(this.btnLocation);
            this.Controls.Add(this.btnWhanau);
            this.Controls.Add(this.btnEvent);
            this.Controls.Add(this.btnKai);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Kaioordinate - Community event management software";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnKai;
        private FontAwesome.Sharp.IconButton btnEvent;
        private FontAwesome.Sharp.IconButton btnLocation;
        private FontAwesome.Sharp.IconButton btnWhanau;
        private FontAwesome.Sharp.IconButton btnReport;
        private FontAwesome.Sharp.IconButton btnRegistration;
        private FontAwesome.Sharp.IconButton btnExit;
    }
}

