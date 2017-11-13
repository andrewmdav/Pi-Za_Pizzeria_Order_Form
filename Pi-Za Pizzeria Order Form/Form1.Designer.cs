namespace Phase_4_Pizza_Project
{
    partial class frmOrderForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrderForm));
            this.grpCustInfo = new System.Windows.Forms.GroupBox();
            this.mtbZip = new System.Windows.Forms.MaskedTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsCut = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.clearClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cboState = new System.Windows.Forms.ComboBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.mtbPhone = new System.Windows.Forms.MaskedTextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblZip = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAddress1 = new System.Windows.Forms.Label();
            this.lblAddress2 = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.grpBillCalc = new System.Windows.Forms.GroupBox();
            this.lblFinalAmt = new System.Windows.Forms.Label();
            this.lblTaxAmt = new System.Windows.Forms.Label();
            this.lblPriceAmt = new System.Windows.Forms.Label();
            this.lblAmtDue = new System.Windows.Forms.Label();
            this.lblTaxTotal = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblBizName = new System.Windows.Forms.Label();
            this.lblCalTime = new System.Windows.Forms.Label();
            this.grpToppings = new System.Windows.Forms.GroupBox();
            this.chkMush = new System.Windows.Forms.CheckBox();
            this.chkGrPepp = new System.Windows.Forms.CheckBox();
            this.chkRedPepp = new System.Windows.Forms.CheckBox();
            this.chkArtichoke = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkCaBac = new System.Windows.Forms.CheckBox();
            this.chkCkn = new System.Windows.Forms.CheckBox();
            this.chkSsg = new System.Windows.Forms.CheckBox();
            this.chkPep = new System.Windows.Forms.CheckBox();
            this.chkXtraCheese = new System.Windows.Forms.CheckBox();
            this.grpSize = new System.Windows.Forms.GroupBox();
            this.radLar = new System.Windows.Forms.RadioButton();
            this.radMed = new System.Windows.Forms.RadioButton();
            this.radSmall = new System.Windows.Forms.RadioButton();
            this.nudOrderQty = new System.Windows.Forms.NumericUpDown();
            this.btnPrice = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.grpSelectButtons = new System.Windows.Forms.GroupBox();
            this.btnCredit = new System.Windows.Forms.Button();
            this.lblOrderNum = new System.Windows.Forms.Label();
            this.grpQty = new System.Windows.Forms.GroupBox();
            this.tmrDateTime = new System.Windows.Forms.Timer(this.components);
            this.menuFile = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSize = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSmall = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMedium = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLarge = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMute = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReset = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPay = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDiscover = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMasterCard = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVisa = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboCard = new System.Windows.Forms.ComboBox();
            this.wmpControl = new AxWMPLib.AxWindowsMediaPlayer();
            this.chkMute = new System.Windows.Forms.CheckBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.grpCustInfo.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.grpBillCalc.SuspendLayout();
            this.grpToppings.SuspendLayout();
            this.grpSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOrderQty)).BeginInit();
            this.grpSelectButtons.SuspendLayout();
            this.grpQty.SuspendLayout();
            this.menuFile.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmpControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // grpCustInfo
            // 
            this.grpCustInfo.Controls.Add(this.mtbZip);
            this.grpCustInfo.Controls.Add(this.cboState);
            this.grpCustInfo.Controls.Add(this.txtCity);
            this.grpCustInfo.Controls.Add(this.txtAddress1);
            this.grpCustInfo.Controls.Add(this.txtAddress2);
            this.grpCustInfo.Controls.Add(this.txtName);
            this.grpCustInfo.Controls.Add(this.mtbPhone);
            this.grpCustInfo.Controls.Add(this.lblCity);
            this.grpCustInfo.Controls.Add(this.lblState);
            this.grpCustInfo.Controls.Add(this.lblZip);
            this.grpCustInfo.Controls.Add(this.lblName);
            this.grpCustInfo.Controls.Add(this.lblAddress1);
            this.grpCustInfo.Controls.Add(this.lblAddress2);
            this.grpCustInfo.Controls.Add(this.lblPhone);
            this.grpCustInfo.Font = new System.Drawing.Font("Lucida Handwriting", 10F);
            this.grpCustInfo.Location = new System.Drawing.Point(14, 334);
            this.grpCustInfo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.grpCustInfo.Name = "grpCustInfo";
            this.grpCustInfo.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.grpCustInfo.Size = new System.Drawing.Size(590, 378);
            this.grpCustInfo.TabIndex = 3;
            this.grpCustInfo.TabStop = false;
            this.grpCustInfo.Text = "Your &Information";
            // 
            // mtbZip
            // 
            this.mtbZip.ContextMenuStrip = this.contextMenuStrip1;
            this.mtbZip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbZip.Location = new System.Drawing.Point(191, 332);
            this.mtbZip.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.mtbZip.Mask = "00000-9999";
            this.mtbZip.Name = "mtbZip";
            this.mtbZip.Size = new System.Drawing.Size(114, 26);
            this.mtbZip.TabIndex = 13;
            this.mtbZip.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtbZip.Validating += new System.ComponentModel.CancelEventHandler(this.mtbZip_Validating);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsCut,
            this.cmsPaste,
            this.clearClipboardToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(234, 76);
            // 
            // cmsCut
            // 
            this.cmsCut.Name = "cmsCut";
            this.cmsCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cmsCut.Size = new System.Drawing.Size(233, 24);
            this.cmsCut.Text = "&Cut";
            this.cmsCut.Click += new System.EventHandler(this.cmsCut_Click);
            // 
            // cmsPaste
            // 
            this.cmsPaste.Name = "cmsPaste";
            this.cmsPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.cmsPaste.Size = new System.Drawing.Size(233, 24);
            this.cmsPaste.Text = "&Paste";
            this.cmsPaste.Click += new System.EventHandler(this.cmsPaste_Click);
            // 
            // clearClipboardToolStripMenuItem
            // 
            this.clearClipboardToolStripMenuItem.Name = "clearClipboardToolStripMenuItem";
            this.clearClipboardToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.clearClipboardToolStripMenuItem.Size = new System.Drawing.Size(233, 24);
            this.clearClipboardToolStripMenuItem.Text = "Clea&r Clipboard";
            this.clearClipboardToolStripMenuItem.Click += new System.EventHandler(this.clearClipboardToolStripMenuItem_Click);
            // 
            // cboState
            // 
            this.cboState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboState.FormattingEnabled = true;
            this.cboState.ItemHeight = 20;
            this.cboState.Location = new System.Drawing.Point(191, 282);
            this.cboState.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cboState.MaxLength = 2;
            this.cboState.Name = "cboState";
            this.cboState.Size = new System.Drawing.Size(65, 28);
            this.cboState.TabIndex = 11;
            // 
            // txtCity
            // 
            this.txtCity.ContextMenuStrip = this.contextMenuStrip1;
            this.txtCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(191, 234);
            this.txtCity.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtCity.MaxLength = 25;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(348, 26);
            this.txtCity.TabIndex = 9;
            this.txtCity.Validating += new System.ComponentModel.CancelEventHandler(this.txtCity_Validating);
            // 
            // txtAddress1
            // 
            this.txtAddress1.ContextMenuStrip = this.contextMenuStrip1;
            this.txtAddress1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress1.Location = new System.Drawing.Point(191, 126);
            this.txtAddress1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtAddress1.MaxLength = 25;
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(348, 26);
            this.txtAddress1.TabIndex = 5;
            this.txtAddress1.Validating += new System.ComponentModel.CancelEventHandler(this.txtAddress1_Validating);
            // 
            // txtAddress2
            // 
            this.txtAddress2.ContextMenuStrip = this.contextMenuStrip1;
            this.txtAddress2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress2.Location = new System.Drawing.Point(191, 180);
            this.txtAddress2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtAddress2.MaxLength = 25;
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(348, 26);
            this.txtAddress2.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.ContextMenuStrip = this.contextMenuStrip1;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(191, 78);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtName.MaxLength = 25;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(348, 26);
            this.txtName.TabIndex = 3;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.txtName_Validating);
            // 
            // mtbPhone
            // 
            this.mtbPhone.ContextMenuStrip = this.contextMenuStrip1;
            this.mtbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbPhone.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.mtbPhone.Location = new System.Drawing.Point(191, 30);
            this.mtbPhone.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.mtbPhone.Mask = "(999) 000-0000";
            this.mtbPhone.Name = "mtbPhone";
            this.mtbPhone.Size = new System.Drawing.Size(139, 26);
            this.mtbPhone.TabIndex = 1;
            this.mtbPhone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtbPhone.Enter += new System.EventHandler(this.mtbPhone_Enter);
            this.mtbPhone.Validating += new System.ComponentModel.CancelEventHandler(this.mtbPhone_Validating);
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(52, 234);
            this.lblCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(47, 23);
            this.lblCity.TabIndex = 8;
            this.lblCity.Text = "City";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(52, 282);
            this.lblState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(57, 23);
            this.lblState.TabIndex = 10;
            this.lblState.Text = "State";
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Location = new System.Drawing.Point(52, 336);
            this.lblZip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(91, 23);
            this.lblZip.TabIndex = 12;
            this.lblZip.Text = "Zip Code";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(52, 78);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(65, 23);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "&Name";
            // 
            // lblAddress1
            // 
            this.lblAddress1.AutoSize = true;
            this.lblAddress1.Location = new System.Drawing.Point(52, 126);
            this.lblAddress1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress1.Name = "lblAddress1";
            this.lblAddress1.Size = new System.Drawing.Size(99, 23);
            this.lblAddress1.TabIndex = 4;
            this.lblAddress1.Text = "Address 1";
            // 
            // lblAddress2
            // 
            this.lblAddress2.AutoSize = true;
            this.lblAddress2.Location = new System.Drawing.Point(52, 180);
            this.lblAddress2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress2.Name = "lblAddress2";
            this.lblAddress2.Size = new System.Drawing.Size(99, 23);
            this.lblAddress2.TabIndex = 6;
            this.lblAddress2.Text = "Address 2";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(52, 30);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(70, 23);
            this.lblPhone.TabIndex = 0;
            this.lblPhone.Text = "Phone";
            // 
            // grpBillCalc
            // 
            this.grpBillCalc.Controls.Add(this.lblFinalAmt);
            this.grpBillCalc.Controls.Add(this.lblTaxAmt);
            this.grpBillCalc.Controls.Add(this.lblPriceAmt);
            this.grpBillCalc.Controls.Add(this.lblAmtDue);
            this.grpBillCalc.Controls.Add(this.lblTaxTotal);
            this.grpBillCalc.Controls.Add(this.lblSubTotal);
            this.grpBillCalc.Font = new System.Drawing.Font("Lucida Handwriting", 10F);
            this.grpBillCalc.Location = new System.Drawing.Point(882, 350);
            this.grpBillCalc.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.grpBillCalc.Name = "grpBillCalc";
            this.grpBillCalc.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.grpBillCalc.Size = new System.Drawing.Size(324, 160);
            this.grpBillCalc.TabIndex = 6;
            this.grpBillCalc.TabStop = false;
            this.grpBillCalc.Text = "Pricing";
            // 
            // lblFinalAmt
            // 
            this.lblFinalAmt.AutoSize = true;
            this.lblFinalAmt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblFinalAmt.Location = new System.Drawing.Point(184, 128);
            this.lblFinalAmt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFinalAmt.MinimumSize = new System.Drawing.Size(81, 0);
            this.lblFinalAmt.Name = "lblFinalAmt";
            this.lblFinalAmt.Size = new System.Drawing.Size(81, 23);
            this.lblFinalAmt.TabIndex = 18;
            this.lblFinalAmt.Text = "$8.56";
            this.lblFinalAmt.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTaxAmt
            // 
            this.lblTaxAmt.AutoSize = true;
            this.lblTaxAmt.Font = new System.Drawing.Font("Lucida Handwriting", 10F, System.Drawing.FontStyle.Underline);
            this.lblTaxAmt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTaxAmt.Location = new System.Drawing.Point(184, 82);
            this.lblTaxAmt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTaxAmt.MinimumSize = new System.Drawing.Size(81, 0);
            this.lblTaxAmt.Name = "lblTaxAmt";
            this.lblTaxAmt.Size = new System.Drawing.Size(81, 23);
            this.lblTaxAmt.TabIndex = 17;
            this.lblTaxAmt.Text = "   .56";
            this.lblTaxAmt.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblPriceAmt
            // 
            this.lblPriceAmt.AutoSize = true;
            this.lblPriceAmt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPriceAmt.Location = new System.Drawing.Point(184, 42);
            this.lblPriceAmt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPriceAmt.MinimumSize = new System.Drawing.Size(81, 0);
            this.lblPriceAmt.Name = "lblPriceAmt";
            this.lblPriceAmt.Size = new System.Drawing.Size(81, 23);
            this.lblPriceAmt.TabIndex = 16;
            this.lblPriceAmt.Text = "$8.00";
            this.lblPriceAmt.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblAmtDue
            // 
            this.lblAmtDue.AutoSize = true;
            this.lblAmtDue.Location = new System.Drawing.Point(20, 128);
            this.lblAmtDue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAmtDue.Name = "lblAmtDue";
            this.lblAmtDue.Size = new System.Drawing.Size(136, 23);
            this.lblAmtDue.TabIndex = 15;
            this.lblAmtDue.Text = "Amount Due:";
            // 
            // lblTaxTotal
            // 
            this.lblTaxTotal.AutoSize = true;
            this.lblTaxTotal.Font = new System.Drawing.Font("Lucida Handwriting", 10F);
            this.lblTaxTotal.Location = new System.Drawing.Point(20, 82);
            this.lblTaxTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTaxTotal.Name = "lblTaxTotal";
            this.lblTaxTotal.Size = new System.Drawing.Size(51, 23);
            this.lblTaxTotal.TabIndex = 14;
            this.lblTaxTotal.Text = "Tax:";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Location = new System.Drawing.Point(20, 42);
            this.lblSubTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(95, 23);
            this.lblSubTotal.TabIndex = 13;
            this.lblSubTotal.Text = "Subtotal:";
            // 
            // lblBizName
            // 
            this.lblBizName.AutoSize = true;
            this.lblBizName.Font = new System.Drawing.Font("Matura MT Script Capitals", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBizName.ForeColor = System.Drawing.Color.Firebrick;
            this.lblBizName.Location = new System.Drawing.Point(11, 38);
            this.lblBizName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBizName.Name = "lblBizName";
            this.lblBizName.Size = new System.Drawing.Size(319, 51);
            this.lblBizName.TabIndex = 7;
            this.lblBizName.Text = "Pi-Za Pizzeria";
            // 
            // lblCalTime
            // 
            this.lblCalTime.Location = new System.Drawing.Point(940, 694);
            this.lblCalTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCalTime.Name = "lblCalTime";
            this.lblCalTime.Size = new System.Drawing.Size(346, 18);
            this.lblCalTime.TabIndex = 3;
            this.lblCalTime.Text = "Tuesday, January, 24 2017  8:52PM ";
            // 
            // grpToppings
            // 
            this.grpToppings.Controls.Add(this.chkMush);
            this.grpToppings.Controls.Add(this.chkGrPepp);
            this.grpToppings.Controls.Add(this.chkRedPepp);
            this.grpToppings.Controls.Add(this.chkArtichoke);
            this.grpToppings.Controls.Add(this.chkOnion);
            this.grpToppings.Controls.Add(this.chkCaBac);
            this.grpToppings.Controls.Add(this.chkCkn);
            this.grpToppings.Controls.Add(this.chkSsg);
            this.grpToppings.Controls.Add(this.chkPep);
            this.grpToppings.Controls.Add(this.chkXtraCheese);
            this.grpToppings.Font = new System.Drawing.Font("Matura MT Script Capitals", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpToppings.Location = new System.Drawing.Point(439, 12);
            this.grpToppings.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.grpToppings.Name = "grpToppings";
            this.grpToppings.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.grpToppings.Size = new System.Drawing.Size(394, 298);
            this.grpToppings.TabIndex = 0;
            this.grpToppings.TabStop = false;
            this.grpToppings.Text = "&Toppers";
            // 
            // chkMush
            // 
            this.chkMush.AutoSize = true;
            this.chkMush.Location = new System.Drawing.Point(7, 192);
            this.chkMush.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.chkMush.Name = "chkMush";
            this.chkMush.Size = new System.Drawing.Size(128, 27);
            this.chkMush.TabIndex = 3;
            this.chkMush.Text = "&Mushroom";
            this.chkMush.UseVisualStyleBackColor = true;
            // 
            // chkGrPepp
            // 
            this.chkGrPepp.AutoSize = true;
            this.chkGrPepp.Location = new System.Drawing.Point(196, 244);
            this.chkGrPepp.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.chkGrPepp.Name = "chkGrPepp";
            this.chkGrPepp.Size = new System.Drawing.Size(144, 27);
            this.chkGrPepp.TabIndex = 9;
            this.chkGrPepp.Text = "Green Pepper";
            this.chkGrPepp.UseVisualStyleBackColor = true;
            // 
            // chkRedPepp
            // 
            this.chkRedPepp.AutoSize = true;
            this.chkRedPepp.Location = new System.Drawing.Point(194, 192);
            this.chkRedPepp.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.chkRedPepp.Name = "chkRedPepp";
            this.chkRedPepp.Size = new System.Drawing.Size(131, 27);
            this.chkRedPepp.TabIndex = 8;
            this.chkRedPepp.Text = "Red Pepper";
            this.chkRedPepp.UseVisualStyleBackColor = true;
            // 
            // chkArtichoke
            // 
            this.chkArtichoke.AutoSize = true;
            this.chkArtichoke.Location = new System.Drawing.Point(7, 242);
            this.chkArtichoke.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.chkArtichoke.Name = "chkArtichoke";
            this.chkArtichoke.Size = new System.Drawing.Size(122, 27);
            this.chkArtichoke.TabIndex = 4;
            this.chkArtichoke.Text = "Artichoke";
            this.chkArtichoke.UseVisualStyleBackColor = true;
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chkOnion.Location = new System.Drawing.Point(194, 138);
            this.chkOnion.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(87, 27);
            this.chkOnion.TabIndex = 7;
            this.chkOnion.Text = "&Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            // 
            // chkCaBac
            // 
            this.chkCaBac.AutoSize = true;
            this.chkCaBac.Font = new System.Drawing.Font("Matura MT Script Capitals", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCaBac.Location = new System.Drawing.Point(194, 92);
            this.chkCaBac.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.chkCaBac.Name = "chkCaBac";
            this.chkCaBac.Size = new System.Drawing.Size(154, 24);
            this.chkCaBac.TabIndex = 6;
            this.chkCaBac.Text = "Canadian Bacon";
            this.chkCaBac.UseVisualStyleBackColor = true;
            // 
            // chkCkn
            // 
            this.chkCkn.AutoSize = true;
            this.chkCkn.Location = new System.Drawing.Point(194, 46);
            this.chkCkn.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.chkCkn.Name = "chkCkn";
            this.chkCkn.Size = new System.Drawing.Size(98, 27);
            this.chkCkn.TabIndex = 5;
            this.chkCkn.Text = "Chicken";
            this.chkCkn.UseVisualStyleBackColor = true;
            // 
            // chkSsg
            // 
            this.chkSsg.AutoSize = true;
            this.chkSsg.Location = new System.Drawing.Point(7, 138);
            this.chkSsg.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.chkSsg.Name = "chkSsg";
            this.chkSsg.Size = new System.Drawing.Size(103, 27);
            this.chkSsg.TabIndex = 2;
            this.chkSsg.Text = "Sausage";
            this.chkSsg.UseVisualStyleBackColor = true;
            // 
            // chkPep
            // 
            this.chkPep.AutoSize = true;
            this.chkPep.Location = new System.Drawing.Point(7, 90);
            this.chkPep.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.chkPep.Name = "chkPep";
            this.chkPep.Size = new System.Drawing.Size(115, 27);
            this.chkPep.TabIndex = 1;
            this.chkPep.Text = "Pepperoni";
            this.chkPep.UseVisualStyleBackColor = true;
            // 
            // chkXtraCheese
            // 
            this.chkXtraCheese.AutoSize = true;
            this.chkXtraCheese.Location = new System.Drawing.Point(7, 46);
            this.chkXtraCheese.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.chkXtraCheese.Name = "chkXtraCheese";
            this.chkXtraCheese.Size = new System.Drawing.Size(146, 27);
            this.chkXtraCheese.TabIndex = 0;
            this.chkXtraCheese.Text = "Xtra Cheese";
            this.chkXtraCheese.UseVisualStyleBackColor = true;
            // 
            // grpSize
            // 
            this.grpSize.Controls.Add(this.radLar);
            this.grpSize.Controls.Add(this.radMed);
            this.grpSize.Controls.Add(this.radSmall);
            this.grpSize.Font = new System.Drawing.Font("Matura MT Script Capitals", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSize.Location = new System.Drawing.Point(839, 12);
            this.grpSize.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.grpSize.Name = "grpSize";
            this.grpSize.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.grpSize.Size = new System.Drawing.Size(158, 182);
            this.grpSize.TabIndex = 1;
            this.grpSize.TabStop = false;
            this.grpSize.Text = "&Size";
            // 
            // radLar
            // 
            this.radLar.AutoSize = true;
            this.radLar.Font = new System.Drawing.Font("Matura MT Script Capitals", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLar.Location = new System.Drawing.Point(7, 100);
            this.radLar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.radLar.Name = "radLar";
            this.radLar.Size = new System.Drawing.Size(81, 27);
            this.radLar.TabIndex = 2;
            this.radLar.TabStop = true;
            this.radLar.Text = "Large";
            this.radLar.UseVisualStyleBackColor = true;
            // 
            // radMed
            // 
            this.radMed.AutoSize = true;
            this.radMed.Font = new System.Drawing.Font("Matura MT Script Capitals", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMed.Location = new System.Drawing.Point(9, 70);
            this.radMed.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.radMed.Name = "radMed";
            this.radMed.Size = new System.Drawing.Size(97, 27);
            this.radMed.TabIndex = 1;
            this.radMed.TabStop = true;
            this.radMed.Text = "Medium";
            this.radMed.UseVisualStyleBackColor = true;
            // 
            // radSmall
            // 
            this.radSmall.AutoSize = true;
            this.radSmall.Font = new System.Drawing.Font("Matura MT Script Capitals", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSmall.Location = new System.Drawing.Point(9, 36);
            this.radSmall.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.radSmall.Name = "radSmall";
            this.radSmall.Size = new System.Drawing.Size(76, 27);
            this.radSmall.TabIndex = 0;
            this.radSmall.TabStop = true;
            this.radSmall.Text = "Small";
            this.radSmall.UseVisualStyleBackColor = true;
            this.radSmall.CheckedChanged += new System.EventHandler(this.radSmall_CheckedChanged);
            // 
            // nudOrderQty
            // 
            this.nudOrderQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudOrderQty.Location = new System.Drawing.Point(14, 42);
            this.nudOrderQty.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.nudOrderQty.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudOrderQty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudOrderQty.Name = "nudOrderQty";
            this.nudOrderQty.Size = new System.Drawing.Size(68, 26);
            this.nudOrderQty.TabIndex = 6;
            this.nudOrderQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnPrice
            // 
            this.btnPrice.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnPrice.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold);
            this.btnPrice.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnPrice.Location = new System.Drawing.Point(20, 36);
            this.btnPrice.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnPrice.Name = "btnPrice";
            this.btnPrice.Size = new System.Drawing.Size(117, 38);
            this.btnPrice.TabIndex = 0;
            this.btnPrice.Text = "Price";
            this.btnPrice.UseVisualStyleBackColor = false;
            this.btnPrice.Visible = false;
            this.btnPrice.Click += new System.EventHandler(this.btnPrice_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnClose.Font = new System.Drawing.Font("Lucida Handwriting", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnClose.Location = new System.Drawing.Point(20, 134);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(117, 38);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnReset.Font = new System.Drawing.Font("Lucida Handwriting", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnReset.Location = new System.Drawing.Point(20, 86);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(117, 38);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAccept.Font = new System.Drawing.Font("Lucida Handwriting", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnAccept.Location = new System.Drawing.Point(20, 36);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(117, 38);
            this.btnAccept.TabIndex = 1;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // grpSelectButtons
            // 
            this.grpSelectButtons.Controls.Add(this.btnAccept);
            this.grpSelectButtons.Controls.Add(this.btnReset);
            this.grpSelectButtons.Controls.Add(this.btnClose);
            this.grpSelectButtons.Controls.Add(this.btnPrice);
            this.grpSelectButtons.Font = new System.Drawing.Font("Lucida Handwriting", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSelectButtons.Location = new System.Drawing.Point(635, 460);
            this.grpSelectButtons.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.grpSelectButtons.Name = "grpSelectButtons";
            this.grpSelectButtons.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.grpSelectButtons.Size = new System.Drawing.Size(189, 184);
            this.grpSelectButtons.TabIndex = 5;
            this.grpSelectButtons.TabStop = false;
            this.grpSelectButtons.Text = "&Actions";
            // 
            // btnCredit
            // 
            this.btnCredit.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCredit.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold);
            this.btnCredit.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnCredit.Location = new System.Drawing.Point(20, 73);
            this.btnCredit.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnCredit.Name = "btnCredit";
            this.btnCredit.Size = new System.Drawing.Size(117, 38);
            this.btnCredit.TabIndex = 20;
            this.btnCredit.Text = "Card Info";
            this.btnCredit.UseVisualStyleBackColor = false;
            this.btnCredit.Click += new System.EventHandler(this.btnCredit_Click);
            // 
            // lblOrderNum
            // 
            this.lblOrderNum.AutoSize = true;
            this.lblOrderNum.Font = new System.Drawing.Font("Pristina", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderNum.Location = new System.Drawing.Point(1089, 170);
            this.lblOrderNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrderNum.Name = "lblOrderNum";
            this.lblOrderNum.Size = new System.Drawing.Size(102, 22);
            this.lblOrderNum.TabIndex = 8;
            this.lblOrderNum.Text = "Order Number:  ";
            // 
            // grpQty
            // 
            this.grpQty.Controls.Add(this.nudOrderQty);
            this.grpQty.Font = new System.Drawing.Font("Matura MT Script Capitals", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpQty.Location = new System.Drawing.Point(1008, 12);
            this.grpQty.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.grpQty.Name = "grpQty";
            this.grpQty.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.grpQty.Size = new System.Drawing.Size(218, 78);
            this.grpQty.TabIndex = 2;
            this.grpQty.TabStop = false;
            this.grpQty.Text = "&Quantity (Max 10)";
            // 
            // tmrDateTime
            // 
            this.tmrDateTime.Enabled = true;
            this.tmrDateTime.Interval = 1000;
            this.tmrDateTime.Tick += new System.EventHandler(this.tmrDateTime_Tick);
            // 
            // menuFile
            // 
            this.menuFile.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuPay});
            this.menuFile.Location = new System.Drawing.Point(0, 0);
            this.menuFile.Name = "menuFile";
            this.menuFile.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuFile.Size = new System.Drawing.Size(1237, 31);
            this.menuFile.TabIndex = 18;
            this.menuFile.Text = "File Menu";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSize,
            this.mnuMute,
            this.mnuReset,
            this.mnuClose});
            this.mnuFile.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(64, 27);
            this.mnuFile.Text = "&Form";
            // 
            // mnuSize
            // 
            this.mnuSize.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSmall,
            this.mnuMedium,
            this.mnuLarge});
            this.mnuSize.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.mnuSize.Name = "mnuSize";
            this.mnuSize.Size = new System.Drawing.Size(180, 28);
            this.mnuSize.Text = "Size";
            // 
            // mnuSmall
            // 
            this.mnuSmall.Name = "mnuSmall";
            this.mnuSmall.Size = new System.Drawing.Size(149, 28);
            this.mnuSmall.Text = "Small";
            this.mnuSmall.Click += new System.EventHandler(this.mnuSmall_Click);
            // 
            // mnuMedium
            // 
            this.mnuMedium.Name = "mnuMedium";
            this.mnuMedium.Size = new System.Drawing.Size(149, 28);
            this.mnuMedium.Text = "Medium";
            this.mnuMedium.Click += new System.EventHandler(this.mnuMedium_Click);
            // 
            // mnuLarge
            // 
            this.mnuLarge.Name = "mnuLarge";
            this.mnuLarge.Size = new System.Drawing.Size(149, 28);
            this.mnuLarge.Text = "Large";
            this.mnuLarge.Click += new System.EventHandler(this.mnuLarge_Click);
            // 
            // mnuMute
            // 
            this.mnuMute.CheckOnClick = true;
            this.mnuMute.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.mnuMute.Name = "mnuMute";
            this.mnuMute.Size = new System.Drawing.Size(180, 28);
            this.mnuMute.Text = "Mute Sound";
            this.mnuMute.Click += new System.EventHandler(this.mnuMute_Click);
            // 
            // mnuReset
            // 
            this.mnuReset.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.mnuReset.Name = "mnuReset";
            this.mnuReset.Size = new System.Drawing.Size(180, 28);
            this.mnuReset.Text = "Reset";
            this.mnuReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // mnuClose
            // 
            this.mnuClose.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.mnuClose.Name = "mnuClose";
            this.mnuClose.Size = new System.Drawing.Size(180, 28);
            this.mnuClose.Text = "Close";
            this.mnuClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // mnuPay
            // 
            this.mnuPay.Checked = true;
            this.mnuPay.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuPay.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDiscover,
            this.mnuMasterCard,
            this.mnuVisa});
            this.mnuPay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.mnuPay.Name = "mnuPay";
            this.mnuPay.Size = new System.Drawing.Size(83, 27);
            this.mnuPay.Text = "&Payment";
            // 
            // mnuDiscover
            // 
            this.mnuDiscover.CheckOnClick = true;
            this.mnuDiscover.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnuDiscover.Name = "mnuDiscover";
            this.mnuDiscover.Size = new System.Drawing.Size(160, 26);
            this.mnuDiscover.Text = "&Discover";
            this.mnuDiscover.Click += new System.EventHandler(this.mnuDiscover_Click);
            // 
            // mnuMasterCard
            // 
            this.mnuMasterCard.CheckOnClick = true;
            this.mnuMasterCard.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnuMasterCard.Name = "mnuMasterCard";
            this.mnuMasterCard.Size = new System.Drawing.Size(160, 26);
            this.mnuMasterCard.Text = "&MasterCard";
            this.mnuMasterCard.Click += new System.EventHandler(this.mnuMasterCard_Click);
            // 
            // mnuVisa
            // 
            this.mnuVisa.CheckOnClick = true;
            this.mnuVisa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnuVisa.Name = "mnuVisa";
            this.mnuVisa.Size = new System.Drawing.Size(160, 26);
            this.mnuVisa.Text = "&Visa";
            this.mnuVisa.Click += new System.EventHandler(this.mnuVisa_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboCard);
            this.groupBox1.Controls.Add(this.btnCredit);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Handwriting", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(635, 334);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(142, 121);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "&Payment";
            // 
            // cboCard
            // 
            this.cboCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCard.FormattingEnabled = true;
            this.cboCard.Items.AddRange(new object[] {
            "Discover",
            "MasterCard",
            "Visa"});
            this.cboCard.Location = new System.Drawing.Point(20, 30);
            this.cboCard.MaxDropDownItems = 4;
            this.cboCard.Name = "cboCard";
            this.cboCard.Size = new System.Drawing.Size(121, 26);
            this.cboCard.TabIndex = 21;
            this.cboCard.Text = "Card Type";
            this.cboCard.SelectedIndexChanged += new System.EventHandler(this.cboCard_SelectedIndexChanged);
            // 
            // wmpControl
            // 
            this.wmpControl.Enabled = true;
            this.wmpControl.Location = new System.Drawing.Point(906, 223);
            this.wmpControl.Name = "wmpControl";
            this.wmpControl.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpControl.OcxState")));
            this.wmpControl.Size = new System.Drawing.Size(197, 87);
            this.wmpControl.TabIndex = 22;
            this.wmpControl.TabStop = false;
            this.wmpControl.Visible = false;
            // 
            // chkMute
            // 
            this.chkMute.AutoSize = true;
            this.chkMute.Location = new System.Drawing.Point(1008, 104);
            this.chkMute.Name = "chkMute";
            this.chkMute.Size = new System.Drawing.Size(110, 22);
            this.chkMute.TabIndex = 23;
            this.chkMute.Text = "Mute Sound";
            this.chkMute.UseVisualStyleBackColor = true;
            this.chkMute.CheckedChanged += new System.EventHandler(this.chkMute_CheckedChanged);
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(20, 112);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(333, 198);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 24;
            this.picLogo.TabStop = false;
            // 
            // frmOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 727);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.chkMute);
            this.Controls.Add(this.wmpControl);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpQty);
            this.Controls.Add(this.lblOrderNum);
            this.Controls.Add(this.grpBillCalc);
            this.Controls.Add(this.grpSize);
            this.Controls.Add(this.grpToppings);
            this.Controls.Add(this.grpSelectButtons);
            this.Controls.Add(this.lblCalTime);
            this.Controls.Add(this.lblBizName);
            this.Controls.Add(this.grpCustInfo);
            this.Controls.Add(this.menuFile);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuFile;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "frmOrderForm";
            this.Text = "Pi-Za Pizzeria Tonight";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmOrderForm_FormClosing);
            this.Load += new System.EventHandler(this.frmOrderForm_Load);
            this.grpCustInfo.ResumeLayout(false);
            this.grpCustInfo.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.grpBillCalc.ResumeLayout(false);
            this.grpBillCalc.PerformLayout();
            this.grpToppings.ResumeLayout(false);
            this.grpToppings.PerformLayout();
            this.grpSize.ResumeLayout(false);
            this.grpSize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOrderQty)).EndInit();
            this.grpSelectButtons.ResumeLayout(false);
            this.grpQty.ResumeLayout(false);
            this.menuFile.ResumeLayout(false);
            this.menuFile.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wmpControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCustInfo;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAddress1;
        private System.Windows.Forms.Label lblAddress2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.MaskedTextBox mtbPhone;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtAddress1;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.MaskedTextBox mtbZip;
        private System.Windows.Forms.ComboBox cboState;
        private System.Windows.Forms.Label lblBizName;
        private System.Windows.Forms.Label lblCalTime;
        private System.Windows.Forms.GroupBox grpToppings;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkCaBac;
        private System.Windows.Forms.CheckBox chkCkn;
        private System.Windows.Forms.CheckBox chkSsg;
        private System.Windows.Forms.CheckBox chkPep;
        private System.Windows.Forms.CheckBox chkXtraCheese;
        private System.Windows.Forms.GroupBox grpSize;
        private System.Windows.Forms.RadioButton radLar;
        private System.Windows.Forms.RadioButton radMed;
        private System.Windows.Forms.RadioButton radSmall;
        private System.Windows.Forms.NumericUpDown nudOrderQty;
        private System.Windows.Forms.Button btnPrice;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.GroupBox grpSelectButtons;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.GroupBox grpBillCalc;
        private System.Windows.Forms.Label lblAmtDue;
        private System.Windows.Forms.Label lblTaxTotal;
        private System.Windows.Forms.Label lblOrderNum;
        private System.Windows.Forms.GroupBox grpQty;
        private System.Windows.Forms.CheckBox chkMush;
        private System.Windows.Forms.CheckBox chkGrPepp;
        private System.Windows.Forms.CheckBox chkRedPepp;
        private System.Windows.Forms.CheckBox chkArtichoke;
        private System.Windows.Forms.Timer tmrDateTime;
        private System.Windows.Forms.Label lblFinalAmt;
        private System.Windows.Forms.Label lblTaxAmt;
        private System.Windows.Forms.Label lblPriceAmt;
        private System.Windows.Forms.MenuStrip menuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.Button btnCredit;
        private System.Windows.Forms.ToolStripMenuItem mnuSize;
        private System.Windows.Forms.ToolStripMenuItem mnuSmall;
        private System.Windows.Forms.ToolStripMenuItem mnuMedium;
        private System.Windows.Forms.ToolStripMenuItem mnuLarge;
        private System.Windows.Forms.ToolStripMenuItem mnuReset;
        private System.Windows.Forms.ToolStripMenuItem mnuClose;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cmsCut;
        private System.Windows.Forms.ToolStripMenuItem cmsPaste;
        private System.Windows.Forms.ToolStripMenuItem clearClipboardToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboCard;
        private System.Windows.Forms.ToolStripMenuItem mnuPay;
        private System.Windows.Forms.ToolStripMenuItem mnuDiscover;
        private System.Windows.Forms.ToolStripMenuItem mnuMasterCard;
        private System.Windows.Forms.ToolStripMenuItem mnuVisa;
        private AxWMPLib.AxWindowsMediaPlayer wmpControl;
        private System.Windows.Forms.ToolStripMenuItem mnuMute;
        private System.Windows.Forms.CheckBox chkMute;
        private System.Windows.Forms.PictureBox picLogo;
    }
}

