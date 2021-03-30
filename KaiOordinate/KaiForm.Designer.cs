
namespace Kaioordinate
{
    partial class KaiForm
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
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.txtServingQuantity = new System.Windows.Forms.TextBox();
            this.txtPreparationTime = new System.Windows.Forms.TextBox();
            this.txtPreparation = new System.Windows.Forms.TextBox();
            this.txtKaiName = new System.Windows.Forms.TextBox();
            this.txtEvent = new System.Windows.Forms.TextBox();
            this.lblServingQuantity = new System.Windows.Forms.Label();
            this.lblPreparationTime = new System.Windows.Forms.Label();
            this.lblPreparation = new System.Windows.Forms.Label();
            this.lblKaiName = new System.Windows.Forms.Label();
            this.lblEvent = new System.Windows.Forms.Label();
            this.btnReturn = new FontAwesome.Sharp.IconButton();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnUpdate = new FontAwesome.Sharp.IconButton();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.btnDown = new FontAwesome.Sharp.IconButton();
            this.btnUp = new FontAwesome.Sharp.IconButton();
            this.txtKaiNo = new System.Windows.Forms.TextBox();
            this.lblKaiNo = new System.Windows.Forms.Label();
            this.lstKai = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnCancel.IconColor = System.Drawing.Color.Black;
            this.btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancel.IconSize = 60;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(293, 95);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(135, 62);
            this.btnCancel.TabIndex = 31;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnSave.IconColor = System.Drawing.Color.Black;
            this.btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSave.IconSize = 60;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(293, 21);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(119, 62);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "SAVE";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtServingQuantity
            // 
            this.txtServingQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtServingQuantity.Location = new System.Drawing.Point(513, 273);
            this.txtServingQuantity.Multiline = true;
            this.txtServingQuantity.Name = "txtServingQuantity";
            this.txtServingQuantity.Size = new System.Drawing.Size(111, 30);
            this.txtServingQuantity.TabIndex = 12;
            // 
            // txtPreparationTime
            // 
            this.txtPreparationTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtPreparationTime.Location = new System.Drawing.Point(513, 225);
            this.txtPreparationTime.Multiline = true;
            this.txtPreparationTime.Name = "txtPreparationTime";
            this.txtPreparationTime.Size = new System.Drawing.Size(111, 30);
            this.txtPreparationTime.TabIndex = 11;
            // 
            // txtPreparation
            // 
            this.txtPreparation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtPreparation.Location = new System.Drawing.Point(513, 175);
            this.txtPreparation.Multiline = true;
            this.txtPreparation.Name = "txtPreparation";
            this.txtPreparation.Size = new System.Drawing.Size(66, 30);
            this.txtPreparation.TabIndex = 10;
            // 
            // txtKaiName
            // 
            this.txtKaiName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtKaiName.Location = new System.Drawing.Point(513, 127);
            this.txtKaiName.Multiline = true;
            this.txtKaiName.Name = "txtKaiName";
            this.txtKaiName.Size = new System.Drawing.Size(247, 30);
            this.txtKaiName.TabIndex = 9;
            // 
            // txtEvent
            // 
            this.txtEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtEvent.Location = new System.Drawing.Point(513, 76);
            this.txtEvent.Multiline = true;
            this.txtEvent.Name = "txtEvent";
            this.txtEvent.Size = new System.Drawing.Size(247, 30);
            this.txtEvent.TabIndex = 8;
            // 
            // lblServingQuantity
            // 
            this.lblServingQuantity.AutoSize = true;
            this.lblServingQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblServingQuantity.ForeColor = System.Drawing.Color.White;
            this.lblServingQuantity.Location = new System.Drawing.Point(357, 279);
            this.lblServingQuantity.Name = "lblServingQuantity";
            this.lblServingQuantity.Size = new System.Drawing.Size(147, 24);
            this.lblServingQuantity.TabIndex = 6;
            this.lblServingQuantity.Text = "Serving Quantity";
            // 
            // lblPreparationTime
            // 
            this.lblPreparationTime.AutoSize = true;
            this.lblPreparationTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblPreparationTime.ForeColor = System.Drawing.Color.White;
            this.lblPreparationTime.Location = new System.Drawing.Point(350, 231);
            this.lblPreparationTime.Name = "lblPreparationTime";
            this.lblPreparationTime.Size = new System.Drawing.Size(154, 24);
            this.lblPreparationTime.TabIndex = 5;
            this.lblPreparationTime.Text = "Preparation Time";
            // 
            // lblPreparation
            // 
            this.lblPreparation.AutoSize = true;
            this.lblPreparation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblPreparation.ForeColor = System.Drawing.Color.White;
            this.lblPreparation.Location = new System.Drawing.Point(388, 181);
            this.lblPreparation.Name = "lblPreparation";
            this.lblPreparation.Size = new System.Drawing.Size(116, 24);
            this.lblPreparation.TabIndex = 4;
            this.lblPreparation.Text = "Preparation?";
            // 
            // lblKaiName
            // 
            this.lblKaiName.AutoSize = true;
            this.lblKaiName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblKaiName.ForeColor = System.Drawing.Color.White;
            this.lblKaiName.Location = new System.Drawing.Point(412, 133);
            this.lblKaiName.Name = "lblKaiName";
            this.lblKaiName.Size = new System.Drawing.Size(92, 24);
            this.lblKaiName.TabIndex = 3;
            this.lblKaiName.Text = "Kai Name";
            // 
            // lblEvent
            // 
            this.lblEvent.AutoSize = true;
            this.lblEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblEvent.ForeColor = System.Drawing.Color.White;
            this.lblEvent.Location = new System.Drawing.Point(443, 82);
            this.lblEvent.Name = "lblEvent";
            this.lblEvent.Size = new System.Drawing.Size(58, 24);
            this.lblEvent.TabIndex = 2;
            this.lblEvent.Text = "Event";
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
            this.btnReturn.TabIndex = 28;
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
            this.btnDelete.TabIndex = 27;
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
            this.btnUpdate.TabIndex = 26;
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
            this.btnAdd.TabIndex = 25;
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
            this.btnDown.TabIndex = 24;
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
            this.btnUp.TabIndex = 23;
            this.btnUp.Text = "UP";
            this.btnUp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // txtKaiNo
            // 
            this.txtKaiNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtKaiNo.Location = new System.Drawing.Point(512, 31);
            this.txtKaiNo.Multiline = true;
            this.txtKaiNo.Name = "txtKaiNo";
            this.txtKaiNo.Size = new System.Drawing.Size(111, 30);
            this.txtKaiNo.TabIndex = 22;
            // 
            // lblKaiNo
            // 
            this.lblKaiNo.AutoSize = true;
            this.lblKaiNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblKaiNo.ForeColor = System.Drawing.Color.White;
            this.lblKaiNo.Location = new System.Drawing.Point(445, 37);
            this.lblKaiNo.Name = "lblKaiNo";
            this.lblKaiNo.Size = new System.Drawing.Size(58, 24);
            this.lblKaiNo.TabIndex = 21;
            this.lblKaiNo.Text = "Kai ID";
            // 
            // lstKai
            // 
            this.lstKai.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lstKai.FormattingEnabled = true;
            this.lstKai.ItemHeight = 24;
            this.lstKai.Location = new System.Drawing.Point(22, 21);
            this.lstKai.Name = "lstKai";
            this.lstKai.Size = new System.Drawing.Size(257, 268);
            this.lstKai.TabIndex = 20;
            // 
            // KaiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(73)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.txtServingQuantity);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtPreparationTime);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtPreparation);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtKaiName);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.txtEvent);
            this.Controls.Add(this.lblServingQuantity);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.lblPreparationTime);
            this.Controls.Add(this.txtKaiNo);
            this.Controls.Add(this.lblPreparation);
            this.Controls.Add(this.lblKaiNo);
            this.Controls.Add(this.lblKaiName);
            this.Controls.Add(this.lstKai);
            this.Controls.Add(this.lblEvent);
            this.Name = "KaiForm";
            this.Text = "Kai Management";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtServingQuantity;
        private System.Windows.Forms.TextBox txtPreparationTime;
        private System.Windows.Forms.TextBox txtPreparation;
        private System.Windows.Forms.TextBox txtKaiName;
        private System.Windows.Forms.TextBox txtEvent;
        private System.Windows.Forms.Label lblServingQuantity;
        private System.Windows.Forms.Label lblPreparationTime;
        private System.Windows.Forms.Label lblPreparation;
        private System.Windows.Forms.Label lblKaiName;
        private System.Windows.Forms.Label lblEvent;
        private FontAwesome.Sharp.IconButton btnReturn;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnUpdate;
        private FontAwesome.Sharp.IconButton btnAdd;
        private FontAwesome.Sharp.IconButton btnDown;
        private FontAwesome.Sharp.IconButton btnUp;
        private System.Windows.Forms.TextBox txtKaiNo;
        private System.Windows.Forms.Label lblKaiNo;
        private System.Windows.Forms.ListBox lstKai;
        private FontAwesome.Sharp.IconButton btnSave;
        private FontAwesome.Sharp.IconButton btnCancel;
    }
}