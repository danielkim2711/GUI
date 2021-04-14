
namespace Kaioordinate
{
    partial class LocationForm
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
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtLocationName = new System.Windows.Forms.TextBox();
            this.lblLocationName = new System.Windows.Forms.Label();
            this.btnReturn = new FontAwesome.Sharp.IconButton();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnUpdate = new FontAwesome.Sharp.IconButton();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.btnDown = new FontAwesome.Sharp.IconButton();
            this.btnUp = new FontAwesome.Sharp.IconButton();
            this.txtLocationNo = new System.Windows.Forms.TextBox();
            this.lblLocationNo = new System.Windows.Forms.Label();
            this.lstLocation = new System.Windows.Forms.ListBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblAddAddress = new System.Windows.Forms.Label();
            this.txtAddAddress = new System.Windows.Forms.TextBox();
            this.txtAddLocationName = new System.Windows.Forms.TextBox();
            this.lblAddLocationName = new System.Windows.Forms.Label();
            this.pnlAddLocation = new System.Windows.Forms.Panel();
            this.btnAddSave = new FontAwesome.Sharp.IconButton();
            this.btnAddCancel = new FontAwesome.Sharp.IconButton();
            this.btnUpdateSave = new FontAwesome.Sharp.IconButton();
            this.btnUpdateCancel = new FontAwesome.Sharp.IconButton();
            this.txtUpdateLocationName = new System.Windows.Forms.TextBox();
            this.lblUpdateAddress = new System.Windows.Forms.Label();
            this.lblUpdateLocationName = new System.Windows.Forms.Label();
            this.txtUpdateAddress = new System.Windows.Forms.TextBox();
            this.pnlUpdateLocation = new System.Windows.Forms.Panel();
            this.pnlAddLocation.SuspendLayout();
            this.pnlUpdateLocation.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtAddress.Location = new System.Drawing.Point(525, 134);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(247, 159);
            this.txtAddress.TabIndex = 9;
            // 
            // txtLocationName
            // 
            this.txtLocationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtLocationName.Location = new System.Drawing.Point(525, 86);
            this.txtLocationName.Multiline = true;
            this.txtLocationName.Name = "txtLocationName";
            this.txtLocationName.Size = new System.Drawing.Size(247, 30);
            this.txtLocationName.TabIndex = 8;
            // 
            // lblLocationName
            // 
            this.lblLocationName.AutoSize = true;
            this.lblLocationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblLocationName.ForeColor = System.Drawing.Color.White;
            this.lblLocationName.Location = new System.Drawing.Point(379, 94);
            this.lblLocationName.Name = "lblLocationName";
            this.lblLocationName.Size = new System.Drawing.Size(137, 24);
            this.lblLocationName.TabIndex = 2;
            this.lblLocationName.Text = "Location Name";
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnReturn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnReturn.IconColor = System.Drawing.Color.Black;
            this.btnReturn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReturn.IconSize = 60;
            this.btnReturn.Location = new System.Drawing.Point(682, 345);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(90, 85);
            this.btnReturn.TabIndex = 38;
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
            this.btnDelete.Location = new System.Drawing.Point(512, 345);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 85);
            this.btnDelete.TabIndex = 37;
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
            this.btnUpdate.Location = new System.Drawing.Point(403, 345);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 85);
            this.btnUpdate.TabIndex = 36;
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
            this.btnAdd.Location = new System.Drawing.Point(293, 345);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 85);
            this.btnAdd.TabIndex = 35;
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
            this.btnDown.Location = new System.Drawing.Point(141, 345);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(90, 85);
            this.btnDown.TabIndex = 34;
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
            this.btnUp.Location = new System.Drawing.Point(35, 345);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(90, 85);
            this.btnUp.TabIndex = 33;
            this.btnUp.Text = "UP";
            this.btnUp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // txtLocationNo
            // 
            this.txtLocationNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtLocationNo.Location = new System.Drawing.Point(525, 34);
            this.txtLocationNo.Multiline = true;
            this.txtLocationNo.Name = "txtLocationNo";
            this.txtLocationNo.Size = new System.Drawing.Size(111, 30);
            this.txtLocationNo.TabIndex = 32;
            // 
            // lblLocationNo
            // 
            this.lblLocationNo.AutoSize = true;
            this.lblLocationNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblLocationNo.ForeColor = System.Drawing.Color.White;
            this.lblLocationNo.Location = new System.Drawing.Point(413, 39);
            this.lblLocationNo.Name = "lblLocationNo";
            this.lblLocationNo.Size = new System.Drawing.Size(103, 24);
            this.lblLocationNo.TabIndex = 31;
            this.lblLocationNo.Text = "Location ID";
            // 
            // lstLocation
            // 
            this.lstLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lstLocation.FormattingEnabled = true;
            this.lstLocation.ItemHeight = 24;
            this.lstLocation.Location = new System.Drawing.Point(12, 12);
            this.lstLocation.Name = "lstLocation";
            this.lstLocation.Size = new System.Drawing.Size(257, 268);
            this.lstLocation.TabIndex = 30;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblAddress.ForeColor = System.Drawing.Color.White;
            this.lblAddress.Location = new System.Drawing.Point(436, 152);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(80, 24);
            this.lblAddress.TabIndex = 39;
            this.lblAddress.Text = "Address";
            // 
            // lblAddAddress
            // 
            this.lblAddAddress.AutoSize = true;
            this.lblAddAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblAddAddress.ForeColor = System.Drawing.Color.White;
            this.lblAddAddress.Location = new System.Drawing.Point(117, 93);
            this.lblAddAddress.Name = "lblAddAddress";
            this.lblAddAddress.Size = new System.Drawing.Size(80, 24);
            this.lblAddAddress.TabIndex = 45;
            this.lblAddAddress.Text = "Address";
            // 
            // txtAddAddress
            // 
            this.txtAddAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtAddAddress.Location = new System.Drawing.Point(206, 75);
            this.txtAddAddress.Multiline = true;
            this.txtAddAddress.Name = "txtAddAddress";
            this.txtAddAddress.Size = new System.Drawing.Size(247, 159);
            this.txtAddAddress.TabIndex = 42;
            // 
            // txtAddLocationName
            // 
            this.txtAddLocationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtAddLocationName.Location = new System.Drawing.Point(206, 27);
            this.txtAddLocationName.Multiline = true;
            this.txtAddLocationName.Name = "txtAddLocationName";
            this.txtAddLocationName.Size = new System.Drawing.Size(247, 30);
            this.txtAddLocationName.TabIndex = 41;
            // 
            // lblAddLocationName
            // 
            this.lblAddLocationName.AutoSize = true;
            this.lblAddLocationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblAddLocationName.ForeColor = System.Drawing.Color.White;
            this.lblAddLocationName.Location = new System.Drawing.Point(60, 35);
            this.lblAddLocationName.Name = "lblAddLocationName";
            this.lblAddLocationName.Size = new System.Drawing.Size(137, 24);
            this.lblAddLocationName.TabIndex = 40;
            this.lblAddLocationName.Text = "Location Name";
            // 
            // pnlAddLocation
            // 
            this.pnlAddLocation.Controls.Add(this.btnAddSave);
            this.pnlAddLocation.Controls.Add(this.btnAddCancel);
            this.pnlAddLocation.Controls.Add(this.txtAddLocationName);
            this.pnlAddLocation.Controls.Add(this.lblAddAddress);
            this.pnlAddLocation.Controls.Add(this.lblAddLocationName);
            this.pnlAddLocation.Controls.Add(this.txtAddAddress);
            this.pnlAddLocation.Location = new System.Drawing.Point(275, 12);
            this.pnlAddLocation.Name = "pnlAddLocation";
            this.pnlAddLocation.Size = new System.Drawing.Size(497, 327);
            this.pnlAddLocation.TabIndex = 46;
            this.pnlAddLocation.Visible = false;
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
            this.btnAddSave.Location = new System.Drawing.Point(165, 250);
            this.btnAddSave.Name = "btnAddSave";
            this.btnAddSave.Size = new System.Drawing.Size(119, 57);
            this.btnAddSave.TabIndex = 90;
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
            this.btnAddCancel.Location = new System.Drawing.Point(312, 250);
            this.btnAddCancel.Name = "btnAddCancel";
            this.btnAddCancel.Size = new System.Drawing.Size(135, 57);
            this.btnAddCancel.TabIndex = 91;
            this.btnAddCancel.Text = "CANCEL";
            this.btnAddCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddCancel.UseVisualStyleBackColor = false;
            this.btnAddCancel.Click += new System.EventHandler(this.btnAddCancel_Click);
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
            this.btnUpdateSave.Location = new System.Drawing.Point(165, 250);
            this.btnUpdateSave.Name = "btnUpdateSave";
            this.btnUpdateSave.Size = new System.Drawing.Size(119, 57);
            this.btnUpdateSave.TabIndex = 96;
            this.btnUpdateSave.Text = "SAVE";
            this.btnUpdateSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateSave.UseVisualStyleBackColor = false;
            this.btnUpdateSave.Click += new System.EventHandler(this.btnUpdateSave_Click);
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
            this.btnUpdateCancel.Location = new System.Drawing.Point(312, 250);
            this.btnUpdateCancel.Name = "btnUpdateCancel";
            this.btnUpdateCancel.Size = new System.Drawing.Size(135, 57);
            this.btnUpdateCancel.TabIndex = 97;
            this.btnUpdateCancel.Text = "CANCEL";
            this.btnUpdateCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateCancel.UseVisualStyleBackColor = false;
            this.btnUpdateCancel.Click += new System.EventHandler(this.btnUpdateCancel_Click);
            // 
            // txtUpdateLocationName
            // 
            this.txtUpdateLocationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtUpdateLocationName.Location = new System.Drawing.Point(206, 27);
            this.txtUpdateLocationName.Multiline = true;
            this.txtUpdateLocationName.Name = "txtUpdateLocationName";
            this.txtUpdateLocationName.Size = new System.Drawing.Size(247, 30);
            this.txtUpdateLocationName.TabIndex = 93;
            // 
            // lblUpdateAddress
            // 
            this.lblUpdateAddress.AutoSize = true;
            this.lblUpdateAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblUpdateAddress.ForeColor = System.Drawing.Color.White;
            this.lblUpdateAddress.Location = new System.Drawing.Point(117, 93);
            this.lblUpdateAddress.Name = "lblUpdateAddress";
            this.lblUpdateAddress.Size = new System.Drawing.Size(80, 24);
            this.lblUpdateAddress.TabIndex = 95;
            this.lblUpdateAddress.Text = "Address";
            // 
            // lblUpdateLocationName
            // 
            this.lblUpdateLocationName.AutoSize = true;
            this.lblUpdateLocationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblUpdateLocationName.ForeColor = System.Drawing.Color.White;
            this.lblUpdateLocationName.Location = new System.Drawing.Point(60, 35);
            this.lblUpdateLocationName.Name = "lblUpdateLocationName";
            this.lblUpdateLocationName.Size = new System.Drawing.Size(137, 24);
            this.lblUpdateLocationName.TabIndex = 92;
            this.lblUpdateLocationName.Text = "Location Name";
            // 
            // txtUpdateAddress
            // 
            this.txtUpdateAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtUpdateAddress.Location = new System.Drawing.Point(206, 75);
            this.txtUpdateAddress.Multiline = true;
            this.txtUpdateAddress.Name = "txtUpdateAddress";
            this.txtUpdateAddress.Size = new System.Drawing.Size(247, 159);
            this.txtUpdateAddress.TabIndex = 94;
            // 
            // pnlUpdateLocation
            // 
            this.pnlUpdateLocation.Controls.Add(this.txtUpdateAddress);
            this.pnlUpdateLocation.Controls.Add(this.btnUpdateSave);
            this.pnlUpdateLocation.Controls.Add(this.lblUpdateLocationName);
            this.pnlUpdateLocation.Controls.Add(this.lblUpdateAddress);
            this.pnlUpdateLocation.Controls.Add(this.btnUpdateCancel);
            this.pnlUpdateLocation.Controls.Add(this.txtUpdateLocationName);
            this.pnlUpdateLocation.Location = new System.Drawing.Point(275, 12);
            this.pnlUpdateLocation.Name = "pnlUpdateLocation";
            this.pnlUpdateLocation.Size = new System.Drawing.Size(497, 327);
            this.pnlUpdateLocation.TabIndex = 98;
            this.pnlUpdateLocation.Visible = false;
            // 
            // LocationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(73)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlUpdateLocation);
            this.Controls.Add(this.pnlAddLocation);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.txtLocationName);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.txtLocationNo);
            this.Controls.Add(this.lblLocationNo);
            this.Controls.Add(this.lstLocation);
            this.Controls.Add(this.lblLocationName);
            this.Name = "LocationForm";
            this.Text = "Location Management";
            this.pnlAddLocation.ResumeLayout(false);
            this.pnlAddLocation.PerformLayout();
            this.pnlUpdateLocation.ResumeLayout(false);
            this.pnlUpdateLocation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtLocationName;
        private System.Windows.Forms.Label lblLocationName;
        private FontAwesome.Sharp.IconButton btnReturn;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnUpdate;
        private FontAwesome.Sharp.IconButton btnAdd;
        private FontAwesome.Sharp.IconButton btnDown;
        private FontAwesome.Sharp.IconButton btnUp;
        private System.Windows.Forms.TextBox txtLocationNo;
        private System.Windows.Forms.Label lblLocationNo;
        private System.Windows.Forms.ListBox lstLocation;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblAddAddress;
        private System.Windows.Forms.TextBox txtAddAddress;
        private System.Windows.Forms.TextBox txtAddLocationName;
        private System.Windows.Forms.Label lblAddLocationName;
        private System.Windows.Forms.Panel pnlAddLocation;
        private FontAwesome.Sharp.IconButton btnAddSave;
        private FontAwesome.Sharp.IconButton btnAddCancel;
        private FontAwesome.Sharp.IconButton btnUpdateSave;
        private FontAwesome.Sharp.IconButton btnUpdateCancel;
        private System.Windows.Forms.TextBox txtUpdateLocationName;
        private System.Windows.Forms.Label lblUpdateAddress;
        private System.Windows.Forms.Label lblUpdateLocationName;
        private System.Windows.Forms.TextBox txtUpdateAddress;
        private System.Windows.Forms.Panel pnlUpdateLocation;
    }
}