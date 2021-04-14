
namespace Kaioordinate
{
    partial class EventForm
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
            this.txtEventDate = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtEventName = new System.Windows.Forms.TextBox();
            this.txtEventNo = new System.Windows.Forms.TextBox();
            this.lblEventNo = new System.Windows.Forms.Label();
            this.lblEventDate = new System.Windows.Forms.Label();
            this.lstEvent = new System.Windows.Forms.ListBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblEventName = new System.Windows.Forms.Label();
            this.btnReturn = new FontAwesome.Sharp.IconButton();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnUpdate = new FontAwesome.Sharp.IconButton();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.btnDown = new FontAwesome.Sharp.IconButton();
            this.btnUp = new FontAwesome.Sharp.IconButton();
            this.pnlAddEvent = new System.Windows.Forms.Panel();
            this.btnAddSave = new FontAwesome.Sharp.IconButton();
            this.btnAddCancel = new FontAwesome.Sharp.IconButton();
            this.cboAddLocation = new System.Windows.Forms.ComboBox();
            this.dtpAddEventDate = new System.Windows.Forms.DateTimePicker();
            this.lblAddEventName = new System.Windows.Forms.Label();
            this.txtAddEventName = new System.Windows.Forms.TextBox();
            this.lblAddLocation = new System.Windows.Forms.Label();
            this.lblAddEventDate = new System.Windows.Forms.Label();
            this.pnlUpdateEvent = new System.Windows.Forms.Panel();
            this.btnUpdateSave = new FontAwesome.Sharp.IconButton();
            this.dtpUpdateEventDate = new System.Windows.Forms.DateTimePicker();
            this.lblUpdateEventDate = new System.Windows.Forms.Label();
            this.btnUpdateCancel = new FontAwesome.Sharp.IconButton();
            this.lblUpdateLocation = new System.Windows.Forms.Label();
            this.txtUpdateEventName = new System.Windows.Forms.TextBox();
            this.cboUpdateLocation = new System.Windows.Forms.ComboBox();
            this.lblUpdateEventName = new System.Windows.Forms.Label();
            this.pnlAddEvent.SuspendLayout();
            this.pnlUpdateEvent.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEventDate
            // 
            this.txtEventDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtEventDate.Location = new System.Drawing.Point(520, 221);
            this.txtEventDate.Multiline = true;
            this.txtEventDate.Name = "txtEventDate";
            this.txtEventDate.Size = new System.Drawing.Size(209, 30);
            this.txtEventDate.TabIndex = 46;
            // 
            // txtLocation
            // 
            this.txtLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtLocation.Location = new System.Drawing.Point(520, 158);
            this.txtLocation.Multiline = true;
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(247, 30);
            this.txtLocation.TabIndex = 45;
            // 
            // txtEventName
            // 
            this.txtEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtEventName.Location = new System.Drawing.Point(520, 94);
            this.txtEventName.Multiline = true;
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.Size = new System.Drawing.Size(247, 30);
            this.txtEventName.TabIndex = 44;
            // 
            // txtEventNo
            // 
            this.txtEventNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtEventNo.Location = new System.Drawing.Point(520, 38);
            this.txtEventNo.Multiline = true;
            this.txtEventNo.Name = "txtEventNo";
            this.txtEventNo.Size = new System.Drawing.Size(111, 30);
            this.txtEventNo.TabIndex = 51;
            // 
            // lblEventNo
            // 
            this.lblEventNo.AutoSize = true;
            this.lblEventNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblEventNo.ForeColor = System.Drawing.Color.White;
            this.lblEventNo.Location = new System.Drawing.Point(432, 41);
            this.lblEventNo.Name = "lblEventNo";
            this.lblEventNo.Size = new System.Drawing.Size(80, 24);
            this.lblEventNo.TabIndex = 50;
            this.lblEventNo.Text = "Event ID";
            // 
            // lblEventDate
            // 
            this.lblEventDate.AutoSize = true;
            this.lblEventDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblEventDate.ForeColor = System.Drawing.Color.White;
            this.lblEventDate.Location = new System.Drawing.Point(412, 227);
            this.lblEventDate.Name = "lblEventDate";
            this.lblEventDate.Size = new System.Drawing.Size(101, 24);
            this.lblEventDate.TabIndex = 41;
            this.lblEventDate.Text = "Event Date";
            // 
            // lstEvent
            // 
            this.lstEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lstEvent.FormattingEnabled = true;
            this.lstEvent.ItemHeight = 24;
            this.lstEvent.Location = new System.Drawing.Point(20, 16);
            this.lstEvent.Name = "lstEvent";
            this.lstEvent.Size = new System.Drawing.Size(257, 268);
            this.lstEvent.TabIndex = 49;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblLocation.ForeColor = System.Drawing.Color.White;
            this.lblLocation.Location = new System.Drawing.Point(432, 164);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(81, 24);
            this.lblLocation.TabIndex = 40;
            this.lblLocation.Text = "Location";
            // 
            // lblEventName
            // 
            this.lblEventName.AutoSize = true;
            this.lblEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblEventName.ForeColor = System.Drawing.Color.White;
            this.lblEventName.Location = new System.Drawing.Point(399, 100);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(114, 24);
            this.lblEventName.TabIndex = 39;
            this.lblEventName.Text = "Event Name";
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnReturn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnReturn.IconColor = System.Drawing.Color.Black;
            this.btnReturn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReturn.IconSize = 60;
            this.btnReturn.Location = new System.Drawing.Point(685, 343);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(90, 85);
            this.btnReturn.TabIndex = 57;
            this.btnReturn.Text = "RETURN";
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDelete.IconColor = System.Drawing.Color.Black;
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelete.IconSize = 60;
            this.btnDelete.Location = new System.Drawing.Point(515, 343);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 85);
            this.btnDelete.TabIndex = 56;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnUpdate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnUpdate.IconColor = System.Drawing.Color.Black;
            this.btnUpdate.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnUpdate.IconSize = 60;
            this.btnUpdate.Location = new System.Drawing.Point(406, 343);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 85);
            this.btnUpdate.TabIndex = 55;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAdd.IconColor = System.Drawing.Color.Black;
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdd.IconSize = 60;
            this.btnAdd.Location = new System.Drawing.Point(296, 343);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 85);
            this.btnAdd.TabIndex = 54;
            this.btnAdd.Text = "ADD";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDown
            // 
            this.btnDown.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnDown.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDown.IconChar = FontAwesome.Sharp.IconChar.CaretSquareDown;
            this.btnDown.IconColor = System.Drawing.Color.Black;
            this.btnDown.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDown.IconSize = 60;
            this.btnDown.Location = new System.Drawing.Point(144, 343);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(90, 85);
            this.btnDown.TabIndex = 53;
            this.btnDown.Text = "DOWN";
            this.btnDown.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDown.UseVisualStyleBackColor = false;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnUp.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUp.IconChar = FontAwesome.Sharp.IconChar.CaretSquareUp;
            this.btnUp.IconColor = System.Drawing.Color.Black;
            this.btnUp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUp.IconSize = 60;
            this.btnUp.Location = new System.Drawing.Point(38, 343);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(90, 85);
            this.btnUp.TabIndex = 52;
            this.btnUp.Text = "UP";
            this.btnUp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // pnlAddEvent
            // 
            this.pnlAddEvent.Controls.Add(this.btnAddSave);
            this.pnlAddEvent.Controls.Add(this.btnAddCancel);
            this.pnlAddEvent.Controls.Add(this.cboAddLocation);
            this.pnlAddEvent.Controls.Add(this.dtpAddEventDate);
            this.pnlAddEvent.Controls.Add(this.lblAddEventName);
            this.pnlAddEvent.Controls.Add(this.txtAddEventName);
            this.pnlAddEvent.Controls.Add(this.lblAddLocation);
            this.pnlAddEvent.Controls.Add(this.lblAddEventDate);
            this.pnlAddEvent.Location = new System.Drawing.Point(296, 16);
            this.pnlAddEvent.Name = "pnlAddEvent";
            this.pnlAddEvent.Size = new System.Drawing.Size(479, 321);
            this.pnlAddEvent.TabIndex = 58;
            this.pnlAddEvent.Visible = false;
            // 
            // btnAddSave
            // 
            this.btnAddSave.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAddSave.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSave.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnAddSave.IconColor = System.Drawing.Color.Black;
            this.btnAddSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddSave.IconSize = 60;
            this.btnAddSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddSave.Location = new System.Drawing.Point(175, 241);
            this.btnAddSave.Name = "btnAddSave";
            this.btnAddSave.Size = new System.Drawing.Size(119, 57);
            this.btnAddSave.TabIndex = 66;
            this.btnAddSave.Text = "SAVE";
            this.btnAddSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddSave.UseVisualStyleBackColor = false;
            this.btnAddSave.Click += new System.EventHandler(this.btnAddSave_Click);
            // 
            // btnAddCancel
            // 
            this.btnAddCancel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAddCancel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCancel.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnAddCancel.IconColor = System.Drawing.Color.Black;
            this.btnAddCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddCancel.IconSize = 60;
            this.btnAddCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCancel.Location = new System.Drawing.Point(322, 241);
            this.btnAddCancel.Name = "btnAddCancel";
            this.btnAddCancel.Size = new System.Drawing.Size(135, 57);
            this.btnAddCancel.TabIndex = 67;
            this.btnAddCancel.Text = "CANCEL";
            this.btnAddCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddCancel.UseVisualStyleBackColor = false;
            this.btnAddCancel.Click += new System.EventHandler(this.btnAddCancel_Click);
            // 
            // cboAddLocation
            // 
            this.cboAddLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cboAddLocation.FormattingEnabled = true;
            this.cboAddLocation.Location = new System.Drawing.Point(207, 114);
            this.cboAddLocation.Name = "cboAddLocation";
            this.cboAddLocation.Size = new System.Drawing.Size(247, 32);
            this.cboAddLocation.TabIndex = 65;
            // 
            // dtpAddEventDate
            // 
            this.dtpAddEventDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dtpAddEventDate.Location = new System.Drawing.Point(207, 190);
            this.dtpAddEventDate.Name = "dtpAddEventDate";
            this.dtpAddEventDate.Size = new System.Drawing.Size(247, 20);
            this.dtpAddEventDate.TabIndex = 64;
            this.dtpAddEventDate.ValueChanged += new System.EventHandler(this.dtpAddEventDate_ValueChanged);
            // 
            // lblAddEventName
            // 
            this.lblAddEventName.AutoSize = true;
            this.lblAddEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblAddEventName.ForeColor = System.Drawing.Color.White;
            this.lblAddEventName.Location = new System.Drawing.Point(86, 60);
            this.lblAddEventName.Name = "lblAddEventName";
            this.lblAddEventName.Size = new System.Drawing.Size(114, 24);
            this.lblAddEventName.TabIndex = 59;
            this.lblAddEventName.Text = "Event Name";
            // 
            // txtAddEventName
            // 
            this.txtAddEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtAddEventName.Location = new System.Drawing.Point(207, 51);
            this.txtAddEventName.Multiline = true;
            this.txtAddEventName.Name = "txtAddEventName";
            this.txtAddEventName.Size = new System.Drawing.Size(247, 30);
            this.txtAddEventName.TabIndex = 62;
            // 
            // lblAddLocation
            // 
            this.lblAddLocation.AutoSize = true;
            this.lblAddLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblAddLocation.ForeColor = System.Drawing.Color.White;
            this.lblAddLocation.Location = new System.Drawing.Point(119, 124);
            this.lblAddLocation.Name = "lblAddLocation";
            this.lblAddLocation.Size = new System.Drawing.Size(81, 24);
            this.lblAddLocation.TabIndex = 60;
            this.lblAddLocation.Text = "Location";
            // 
            // lblAddEventDate
            // 
            this.lblAddEventDate.AutoSize = true;
            this.lblAddEventDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblAddEventDate.ForeColor = System.Drawing.Color.White;
            this.lblAddEventDate.Location = new System.Drawing.Point(99, 187);
            this.lblAddEventDate.Name = "lblAddEventDate";
            this.lblAddEventDate.Size = new System.Drawing.Size(101, 24);
            this.lblAddEventDate.TabIndex = 61;
            this.lblAddEventDate.Text = "Event Date";
            // 
            // pnlUpdateEvent
            // 
            this.pnlUpdateEvent.Controls.Add(this.btnUpdateSave);
            this.pnlUpdateEvent.Controls.Add(this.dtpUpdateEventDate);
            this.pnlUpdateEvent.Controls.Add(this.lblUpdateEventDate);
            this.pnlUpdateEvent.Controls.Add(this.btnUpdateCancel);
            this.pnlUpdateEvent.Controls.Add(this.lblUpdateLocation);
            this.pnlUpdateEvent.Controls.Add(this.txtUpdateEventName);
            this.pnlUpdateEvent.Controls.Add(this.cboUpdateLocation);
            this.pnlUpdateEvent.Controls.Add(this.lblUpdateEventName);
            this.pnlUpdateEvent.Location = new System.Drawing.Point(295, 16);
            this.pnlUpdateEvent.Name = "pnlUpdateEvent";
            this.pnlUpdateEvent.Size = new System.Drawing.Size(479, 321);
            this.pnlUpdateEvent.TabIndex = 59;
            this.pnlUpdateEvent.Visible = false;
            // 
            // btnUpdateSave
            // 
            this.btnUpdateSave.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnUpdateSave.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateSave.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnUpdateSave.IconColor = System.Drawing.Color.Black;
            this.btnUpdateSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdateSave.IconSize = 60;
            this.btnUpdateSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateSave.Location = new System.Drawing.Point(176, 238);
            this.btnUpdateSave.Name = "btnUpdateSave";
            this.btnUpdateSave.Size = new System.Drawing.Size(119, 57);
            this.btnUpdateSave.TabIndex = 74;
            this.btnUpdateSave.Text = "SAVE";
            this.btnUpdateSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateSave.UseVisualStyleBackColor = false;
            this.btnUpdateSave.Click += new System.EventHandler(this.btnUpdateSave_Click);
            // 
            // dtpUpdateEventDate
            // 
            this.dtpUpdateEventDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dtpUpdateEventDate.Checked = false;
            this.dtpUpdateEventDate.Location = new System.Drawing.Point(208, 187);
            this.dtpUpdateEventDate.Name = "dtpUpdateEventDate";
            this.dtpUpdateEventDate.Size = new System.Drawing.Size(247, 20);
            this.dtpUpdateEventDate.TabIndex = 72;
            this.dtpUpdateEventDate.ValueChanged += new System.EventHandler(this.dtpUpdateEventDate_ValueChanged);
            // 
            // lblUpdateEventDate
            // 
            this.lblUpdateEventDate.AutoSize = true;
            this.lblUpdateEventDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblUpdateEventDate.ForeColor = System.Drawing.Color.White;
            this.lblUpdateEventDate.Location = new System.Drawing.Point(100, 184);
            this.lblUpdateEventDate.Name = "lblUpdateEventDate";
            this.lblUpdateEventDate.Size = new System.Drawing.Size(101, 24);
            this.lblUpdateEventDate.TabIndex = 70;
            this.lblUpdateEventDate.Text = "Event Date";
            // 
            // btnUpdateCancel
            // 
            this.btnUpdateCancel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnUpdateCancel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCancel.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnUpdateCancel.IconColor = System.Drawing.Color.Black;
            this.btnUpdateCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdateCancel.IconSize = 60;
            this.btnUpdateCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateCancel.Location = new System.Drawing.Point(323, 238);
            this.btnUpdateCancel.Name = "btnUpdateCancel";
            this.btnUpdateCancel.Size = new System.Drawing.Size(135, 57);
            this.btnUpdateCancel.TabIndex = 75;
            this.btnUpdateCancel.Text = "CANCEL";
            this.btnUpdateCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateCancel.UseVisualStyleBackColor = false;
            this.btnUpdateCancel.Click += new System.EventHandler(this.btnUpdateCancel_Click);
            // 
            // lblUpdateLocation
            // 
            this.lblUpdateLocation.AutoSize = true;
            this.lblUpdateLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblUpdateLocation.ForeColor = System.Drawing.Color.White;
            this.lblUpdateLocation.Location = new System.Drawing.Point(120, 121);
            this.lblUpdateLocation.Name = "lblUpdateLocation";
            this.lblUpdateLocation.Size = new System.Drawing.Size(81, 24);
            this.lblUpdateLocation.TabIndex = 69;
            this.lblUpdateLocation.Text = "Location";
            // 
            // txtUpdateEventName
            // 
            this.txtUpdateEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtUpdateEventName.Location = new System.Drawing.Point(208, 48);
            this.txtUpdateEventName.Multiline = true;
            this.txtUpdateEventName.Name = "txtUpdateEventName";
            this.txtUpdateEventName.Size = new System.Drawing.Size(247, 30);
            this.txtUpdateEventName.TabIndex = 71;
            // 
            // cboUpdateLocation
            // 
            this.cboUpdateLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cboUpdateLocation.FormattingEnabled = true;
            this.cboUpdateLocation.Location = new System.Drawing.Point(208, 111);
            this.cboUpdateLocation.Name = "cboUpdateLocation";
            this.cboUpdateLocation.Size = new System.Drawing.Size(247, 32);
            this.cboUpdateLocation.TabIndex = 73;
            // 
            // lblUpdateEventName
            // 
            this.lblUpdateEventName.AutoSize = true;
            this.lblUpdateEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblUpdateEventName.ForeColor = System.Drawing.Color.White;
            this.lblUpdateEventName.Location = new System.Drawing.Point(87, 57);
            this.lblUpdateEventName.Name = "lblUpdateEventName";
            this.lblUpdateEventName.Size = new System.Drawing.Size(114, 24);
            this.lblUpdateEventName.TabIndex = 68;
            this.lblUpdateEventName.Text = "Event Name";
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(73)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlUpdateEvent);
            this.Controls.Add(this.pnlAddEvent);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtEventDate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.txtEventName);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.txtEventNo);
            this.Controls.Add(this.lblEventNo);
            this.Controls.Add(this.lblEventDate);
            this.Controls.Add(this.lstEvent);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblEventName);
            this.Name = "EventForm";
            this.Text = "Event Management";
            this.pnlAddEvent.ResumeLayout(false);
            this.pnlAddEvent.PerformLayout();
            this.pnlUpdateEvent.ResumeLayout(false);
            this.pnlUpdateEvent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtEventDate;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtEventName;
        private System.Windows.Forms.TextBox txtEventNo;
        private System.Windows.Forms.Label lblEventNo;
        private System.Windows.Forms.Label lblEventDate;
        private System.Windows.Forms.ListBox lstEvent;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblEventName;
        private FontAwesome.Sharp.IconButton btnReturn;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnUpdate;
        private FontAwesome.Sharp.IconButton btnAdd;
        private FontAwesome.Sharp.IconButton btnDown;
        private FontAwesome.Sharp.IconButton btnUp;
        private System.Windows.Forms.Panel pnlAddEvent;
        private System.Windows.Forms.TextBox txtAddEventName;
        private System.Windows.Forms.Label lblAddEventDate;
        private System.Windows.Forms.Label lblAddLocation;
        private System.Windows.Forms.Label lblAddEventName;
        private System.Windows.Forms.ComboBox cboAddLocation;
        private System.Windows.Forms.DateTimePicker dtpAddEventDate;
        private FontAwesome.Sharp.IconButton btnAddSave;
        private FontAwesome.Sharp.IconButton btnAddCancel;
        private System.Windows.Forms.Panel pnlUpdateEvent;
        private FontAwesome.Sharp.IconButton btnUpdateSave;
        private System.Windows.Forms.DateTimePicker dtpUpdateEventDate;
        private System.Windows.Forms.Label lblUpdateEventDate;
        private FontAwesome.Sharp.IconButton btnUpdateCancel;
        private System.Windows.Forms.Label lblUpdateLocation;
        private System.Windows.Forms.TextBox txtUpdateEventName;
        private System.Windows.Forms.ComboBox cboUpdateLocation;
        private System.Windows.Forms.Label lblUpdateEventName;
    }
}