namespace Phase_4_Pizza_Project
{
    partial class frmCreditCard
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
            this.mtbCardNum = new System.Windows.Forms.MaskedTextBox();
            this.lblCardNun = new System.Windows.Forms.Label();
            this.cboMonth = new System.Windows.Forms.ComboBox();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.grpCardInfo = new System.Windows.Forms.GroupBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpExpiration = new System.Windows.Forms.GroupBox();
            this.grpCardInfo.SuspendLayout();
            this.grpExpiration.SuspendLayout();
            this.SuspendLayout();
            // 
            // mtbCardNum
            // 
            this.mtbCardNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbCardNum.Location = new System.Drawing.Point(19, 72);
            this.mtbCardNum.Mask = "0000-0000-0000-0000";
            this.mtbCardNum.Name = "mtbCardNum";
            this.mtbCardNum.Size = new System.Drawing.Size(183, 24);
            this.mtbCardNum.TabIndex = 1;
            this.mtbCardNum.Validating += new System.ComponentModel.CancelEventHandler(this.mtbCardNum_Validating);
            // 
            // lblCardNun
            // 
            this.lblCardNun.AutoSize = true;
            this.lblCardNun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardNun.Location = new System.Drawing.Point(16, 42);
            this.lblCardNun.Name = "lblCardNun";
            this.lblCardNun.Size = new System.Drawing.Size(158, 18);
            this.lblCardNun.TabIndex = 0;
            this.lblCardNun.Text = "Credit Card Number";
            // 
            // cboMonth
            // 
            this.cboMonth.DisplayMember = "01,02,03";
            this.cboMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMonth.FormattingEnabled = true;
            this.cboMonth.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cboMonth.Location = new System.Drawing.Point(6, 37);
            this.cboMonth.MaxLength = 2;
            this.cboMonth.Name = "cboMonth";
            this.cboMonth.Size = new System.Drawing.Size(71, 26);
            this.cboMonth.TabIndex = 2;
            this.cboMonth.Text = "Month";
            this.cboMonth.SelectedValueChanged += new System.EventHandler(this.cboMonth_SelectedValueChanged);
            //this.cboMonth.Validating += new System.ComponentModel.CancelEventHandler(this.cboMonth_Validating);
            // 
            // cboYear
            // 
            this.cboYear.DisplayMember = "01,02,03";
            this.cboYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Items.AddRange(new object[] {
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026"});
            this.cboYear.Location = new System.Drawing.Point(112, 37);
            this.cboYear.MaxLength = 4;
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(71, 26);
            this.cboYear.TabIndex = 4;
            this.cboYear.Text = "Year";
            this.cboYear.SelectedValueChanged += new System.EventHandler(this.cboYear_SelectedValueChanged);
            //this.cboYear.Validating += new System.ComponentModel.CancelEventHandler(this.cboYear_Validating);
            // 
            // grpCardInfo
            // 
            this.grpCardInfo.Controls.Add(this.grpExpiration);
            this.grpCardInfo.Controls.Add(this.btnCancel);
            this.grpCardInfo.Controls.Add(this.btnOk);
            this.grpCardInfo.Controls.Add(this.lblCardNun);
            this.grpCardInfo.Controls.Add(this.mtbCardNum);
            this.grpCardInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCardInfo.Location = new System.Drawing.Point(45, 57);
            this.grpCardInfo.Name = "grpCardInfo";
            this.grpCardInfo.Size = new System.Drawing.Size(324, 289);
            this.grpCardInfo.TabIndex = 0;
            this.grpCardInfo.TabStop = false;
            this.grpCardInfo.Text = "Credit Card Information";
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(19, 241);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(95, 42);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(131, 241);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 42);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grpExpiration
            // 
            this.grpExpiration.Controls.Add(this.cboMonth);
            this.grpExpiration.Controls.Add(this.cboYear);
            this.grpExpiration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpExpiration.Location = new System.Drawing.Point(19, 118);
            this.grpExpiration.Name = "grpExpiration";
            this.grpExpiration.Size = new System.Drawing.Size(200, 100);
            this.grpExpiration.TabIndex = 3;
            this.grpExpiration.TabStop = false;
            this.grpExpiration.Text = "Card Expiration";
            //this.grpExpiration.Leave += new System.EventHandler(this.grpExpiration_Leave);
            // 
            // frmCreditCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 493);
            this.Controls.Add(this.grpCardInfo);
            this.Name = "frmCreditCard";
            this.Text = "frmCreditCard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCreditCard_FormClosing);
            this.grpCardInfo.ResumeLayout(false);
            this.grpCardInfo.PerformLayout();
            this.grpExpiration.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtbCardNum;
        private System.Windows.Forms.Label lblCardNun;
        private System.Windows.Forms.ComboBox cboMonth;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.GroupBox grpCardInfo;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.GroupBox grpExpiration;
    }
}