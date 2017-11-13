using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

/*
 * Form intakes a customer's contact and order information.  It utilizes the Customer class for contact data organization
 * and calls the frmCreditCard form to collect payment information.  A returning customer's contact information is proactively   
 * retrieved from a database after successfull phone number input validation.  The form writes customer/order information to 
 * a database after successful completion of contact and credit card information.  FileStreams are used to read in the
 * state abbreviations for the combo box and write out certain order information to a text file.  Other features include
 * background music, with the option to mute, order number and date displays, and a reset option.
*/

namespace Phase_4_Pizza_Project
{
    public partial class frmOrderForm : Form
    {
        //declare global variales

        //pricing variables
        const decimal ToppingPrice = 2.00m;
        const decimal SmallPrice = 8.00m;
        const decimal MediumPrice = 12.00m;
        const decimal LargePrice = 16.00m;
        const decimal SalesTaxRate = .07m;

        //variable receives tag (T/F) from credit card form T=Valid
        private bool isCardValid = false;  

        //order number to display (based on count in database)
        private int orderCount = 0;

        //database-related objects (ado.net)
        SqlConnection cnCust;
        SqlDataAdapter daCust;
        DataTable dtCust;
        SqlCommandBuilder cbCust;

        SqlConnection cnOrder;
        SqlDataAdapter daOrder;
        DataTable dtOrder;
        SqlCommandBuilder cbOrder;

        //project contains the data base in the relative path \bin\debug folder
        string strDataSrc = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Pizza.mdf;";
        string strSQLparms = "Integrated Security=true; Connect Timeout=10";

        public bool isNewCust = false;
        
        //open database connections, wire-up repeatedly used events, and display initial pricing
        public frmOrderForm()
        {
            InitializeComponent();

            this.AutoScroll = true;

            //open Cust db cx at form load
            string strConn = strDataSrc + strSQLparms;
            cnCust = new SqlConnection(strConn);
            cnCust.Open();

            //open Order db cx
            string strOrdConn = strDataSrc + strSQLparms;
            cnOrder = new SqlConnection(strOrdConn);
            cnOrder.Open();

            mtbPhone.Select();
            radSmall.Checked = true;

            //shared event handling

            //button resets after accept
            this.btnAccept.Click += btnReset_Click;
            
            //test whether customer data has been entered before accept button is enabled (calls the emptyChecker() function)
            this.txtAddress1.Leave += txtName_Leave;
            this.txtCity.Leave += txtName_Leave;
            this.cboState.Leave += txtName_Leave;
            this.mtbPhone.Leave += txtName_Leave;
            this.mtbZip.Leave += txtName_Leave;
            this.nudOrderQty.Leave+= txtName_Leave;
            this.btnAccept.Leave += txtName_Leave;

            //reprice when toppings, size, or quantity is change (calls the pricer() function)
            this.chkXtraCheese.CheckedChanged += radSmall_CheckedChanged;
            this.chkPep.CheckedChanged += radSmall_CheckedChanged;
            this.chkSsg.CheckedChanged += radSmall_CheckedChanged;
            this.chkMush.CheckedChanged += radSmall_CheckedChanged;
            this.chkArtichoke.CheckedChanged += radSmall_CheckedChanged;
            this.chkCkn.CheckedChanged += radSmall_CheckedChanged;
            this.chkCaBac.CheckedChanged += radSmall_CheckedChanged;
            this.chkOnion.CheckedChanged += radSmall_CheckedChanged;
            this.chkRedPepp.CheckedChanged += radSmall_CheckedChanged;
            this.chkGrPepp.CheckedChanged += radSmall_CheckedChanged;

            this.radMed.CheckedChanged += radSmall_CheckedChanged;
            this.radLar.CheckedChanged += radSmall_CheckedChanged;
        
            this.nudOrderQty.ValueChanged += radSmall_CheckedChanged;

            //for name and city keypress validation (alpha characters upper/lower, space, or backspace)
            this.txtCity.KeyPress += txtName_KeyPress;

            chkXtraCheese.Focus();

            //add initial pricing based on default selections
            pricer();

            //disable accept button
            btnAccept.Enabled = false;

        }

        //on load, read in order table from database for order count and read state abbreviations from text file
        //default displayed state is MN
        private void frmOrderForm_Load(object sender, EventArgs e)
        {
            string sqlnextorder = "select max(ordernumber) from orders;";
            SqlDataAdapter daOrder = new SqlDataAdapter(sqlnextorder, cnOrder);

            DataTable dtOrdNum = new DataTable();
            daOrder.Fill(dtOrdNum);
            
            //establish order number with last number from database or 1
            if (dtOrdNum.Rows.Count == 0)
            {
                orderCount = 1;
            }
            else
            {
                orderCount = Convert.ToInt16(dtOrdNum.Rows[0][0]); 
                orderCount++;
                lblOrderNum.Text = "Order Number: " + orderCount.ToString();

            }


            //try to open state abbreviations from a text file, loading to combo box, otherwise open a file dialog
            string strStateAdditions;
            string strStatesFile;
            try
            {
                strStatesFile = Application.StartupPath + @"\StateAbbrev.txt";
                FileStream fsStateStream = new FileStream(strStatesFile, FileMode.Open, FileAccess.Read);
                StreamReader srStatesOut = new StreamReader(fsStateStream);

                while (!srStatesOut.EndOfStream)
                {
                    strStateAdditions = srStatesOut.ReadLine();

                    cboState.Items.Add(strStateAdditions);
                }
                srStatesOut.Close();
            }
            catch
            {
                MessageBox.Show("Error accessing States files.");

                OpenFileDialog ofdStates = new OpenFileDialog();

                if (ofdStates.ShowDialog() == DialogResult.OK)
                {
                    strStatesFile = ofdStates.FileName;

                    FileStream fsStateStream = new FileStream(strStatesFile, FileMode.Open, FileAccess.Read);
                    StreamReader srStatesOut = new StreamReader(fsStateStream);

                    while (!srStatesOut.EndOfStream)
                    {
                        strStateAdditions = srStatesOut.ReadLine();
                        cboState.Items.Add(strStateAdditions);
                    }
                    srStatesOut.Close();
                }
                else
                {
                    MessageBox.Show("You selected no file.  Please reload application.", "File Open Error");
                }
                    

            }
            cboState.SelectedItem = "MN";
        }

        //calls resetter(), which clears the form
        private void btnReset_Click(object sender, EventArgs e)
        {
            resetter();   
        }
        
        //display date and time
        private void tmrDateTime_Tick(object sender, EventArgs e)
        {
            lblCalTime.Text = DateTime.Now.ToLongDateString() + "  " + DateTime.Now.ToLongTimeString();
        }

        private void mtbPhone_Enter(object sender, EventArgs e)
        {
            mtbPhone.Select(0, 0);
        }

        private void btnPrice_Click(object sender, EventArgs e)
        {
            pricer();            
        }

        private void radSmall_CheckedChanged(object sender, EventArgs e)
        {
            pricer();

        }

        //validate phone input and fill in the customer information if they are a previous customer
        //validate based on length with a change in font color
        private void mtbPhone_Validating(object sender, CancelEventArgs e)
        {
            //allow user to exit validation and close program with the close button and set
            //phone number text color (red if incomplete)
            if (ActiveControl.Name == "btnClose")
            {
                this.Close();
            }            
            else if (mtbPhone.Text.Length < 10)
            {
                e.Cancel = true;
                mtbPhone.ForeColor = Color.Red;
                mtbPhone.Select(mtbPhone.Text.Length,1);                
            }
            else
            {
                mtbPhone.ForeColor = Color.Black;
            }

            //fill table with customers data from database (if already in database) after a complete phone entry by user
            if (mtbPhone.Text.Length == 10)
            {
                //Customer table work
                string strPhone = mtbPhone.Text;
                string sqlSelect;                
                sqlSelect = "SELECT * FROM Customers WHERE CustPhone = '" + strPhone + "';";
                daCust = new SqlDataAdapter(sqlSelect, cnCust);
                dtCust = new DataTable();
                daCust.Fill(dtCust);  
                 

                //check for presence of Customer table rows for that phone number and return values to form
                if (dtCust.Rows.Count > 0)
                {
                    txtName.Text = dtCust.Rows[0]["CustName"].ToString();
                    txtAddress1.Text = dtCust.Rows[0]["CustAddress1"].ToString();
                    txtAddress2.Text = dtCust.Rows[0]["CustAddress2"].ToString();
                    txtCity.Text = dtCust.Rows[0]["CustCity"].ToString();
                    cboState.Text = dtCust.Rows[0]["CustState"].ToString();
                    mtbZip.Text = dtCust.Rows[0]["CustZip"].ToString();                 

                    nudOrderQty.Focus();
                }
                else
                {
                    MessageBox.Show("Your number was not found.  Continue to enter new customer information:");
                    isNewCust = true;
                    txtName.Focus();                    
                }

                //fill onscreen order selection with selections made at last order (if returning customer with prior order)               
                string strSQLOrder = "SELECT * FROM Orders WHERE CustPhone = '" + strPhone + "';";
                daOrder = new SqlDataAdapter(strSQLOrder,cnOrder);

                dtOrder = new DataTable();
                daOrder.Fill(dtOrder);                

                if (dtOrder.Rows.Count > 0)
                {
                    int lastRow = dtOrder.Rows.Count-1;  
                    //place values of last row in db into the form controls
                    chkXtraCheese.Checked = Convert.ToBoolean(dtOrder.Rows[lastRow]["Top1"]);
                    chkPep.Checked = Convert.ToBoolean(dtOrder.Rows[lastRow]["Top2"]);
                    chkSsg.Checked = Convert.ToBoolean(dtOrder.Rows[lastRow]["Top3"]);
                    chkMush.Checked = Convert.ToBoolean(dtOrder.Rows[lastRow]["Top4"]);
                    chkArtichoke.Checked = Convert.ToBoolean(dtOrder.Rows[lastRow]["Top5"]);
                    chkCkn.Checked = Convert.ToBoolean(dtOrder.Rows[lastRow]["Top6"]);
                    chkCaBac.Checked = Convert.ToBoolean(dtOrder.Rows[lastRow]["Top7"]);
                    chkOnion.Checked = Convert.ToBoolean(dtOrder.Rows[lastRow]["Top8"]);
                    chkRedPepp.Checked = Convert.ToBoolean(dtOrder.Rows[lastRow]["Top9"]);
                    chkGrPepp.Checked = Convert.ToBoolean(dtOrder.Rows[lastRow]["Top10"]);

                    nudOrderQty.Value = Convert.ToInt16(dtOrder.Rows[lastRow]["Qty"]);

                    string strSize = dtOrder.Rows[lastRow]["OrderSize"].ToString();
                    if (strSize == "S")
                        radSmall.Checked = true;
                    else if (strSize == "M")
                        radMed.Checked = true;
                    else
                        radLar.Checked = true; 
                }

                emptyChecker();
            }
        }

        //validate zip field for length, adjusting font color, and allowing user to exit form in validation
        private void mtbZip_Validating(object sender, CancelEventArgs e)
        {
            if (ActiveControl.Name == "btnClose")
            {
                this.Close();

            }
            else if (mtbZip.Text.Length != 9 && mtbZip.Text.Length != 5)
            {
                e.Cancel = true;                
                mtbZip.ForeColor = Color.Red;
            }
            else
            {
                mtbZip.ForeColor = Color.Black;
            }
        }

        //validate name field for length, adjusting font color, and allowing user to exit form in validation
        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (ActiveControl.Name == "btnClose")
            {
                this.Close();
            }       
            else if (txtName.Text.Length < 5 || txtName.Text.Length > 25)
            {                          
                e.Cancel = true;
                txtName.ForeColor = Color.Red;
            }
            else
            {
                txtName.ForeColor = Color.Black;
            }
                
        }

        //validate name field for length, adjusting font color, and allowing user to exit form in validation
        private void txtAddress1_Validating(object sender, CancelEventArgs e)
        {
            if (ActiveControl.Name == "btnClose")
            {
                this.Close();                
            }         
            else if (txtAddress1.Text.Length < 5 || txtAddress1.Text.Length > 25)
            {
                e.Cancel = true;
                txtAddress1.ForeColor = Color.Red;
            }
            else
            {
                txtAddress1.ForeColor = Color.Black;
            }
        }

        //validate city field for length, adjusting font color, and allowing user to exit form in validation
        private void txtCity_Validating(object sender, CancelEventArgs e)
        {
            if (ActiveControl.Name == "btnClose")
            {
                e.Cancel=false;                
            }            
            else if (txtCity.Text.Length < 2 || txtCity.Text.Length > 25)
            {
                e.Cancel = true;
                txtCity.ForeColor = Color.Red;
            }
            else
            {
                txtCity.ForeColor = Color.Black;
            }
        }

        //exit form with verification at form closing event
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();            
        }

        //write data new customer to Customer tables, order data to Orders table, and certain order data to text file
        private void btnAccept_Click(object sender, EventArgs e)
        {
            string strCustomerOut;                                                     
            string strCustFile = Application.StartupPath + @"\Customer Data File.txt"; 
            StreamWriter swCustomerOut = null;                                         

            //create customer class for stream writer            
            Customer CustomerLog = new Customer(mtbPhone.Text,txtName.Text,txtAddress1.Text,txtAddress2.Text,txtCity.Text,cboState.Text,mtbZip.Text);

            //increment order number and update form
            orderCount++;
            lblOrderNum.Text = "Order Number: " + orderCount.ToString();

            //input new customer data into database
            if (isNewCust == true)
                    {
                        //create table
                        dtCust = new DataTable();
                        //create adapter with sql string and fill table
                        string sqlSelect = "SELECT * FROM Customers";
                        daCust = new SqlDataAdapter(sqlSelect, cnCust);
                        daCust.Fill(dtCust);

                        //create row with the proper schema, add form data, and then update the table/database
                        DataRow drCust;
                        drCust = dtCust.NewRow();//fill row with Customer table schema

                        drCust["CustPhone"] = mtbPhone.Text.ToString();
                        drCust["CustName"] = txtName.Text.ToString();
                        drCust["CustAddress1"] = txtAddress1.Text.ToString();
                        drCust["CustAddress2"] = txtAddress2.Text.ToString();
                        drCust["CustCity"] = txtCity.Text.ToString();
                        drCust["CustState"] = cboState.Text.ToString();
                        drCust["CustZip"] = mtbZip.Text.ToString();
                        
                        //update data table
                        dtCust.Rows.Add(drCust);

                        //Update database
                        //create command builder to get updater then update the adapter w/the table
                        cbCust = new SqlCommandBuilder(daCust);
                        cbCust.GetUpdateCommand();
                        daCust.Update(dtCust);
                        MessageBox.Show("Customer Added!");                

                        isNewCust = false;
                
                    }

                    //After updating Customers table, now update Orders table in database in the same fashion
                    
                    //Establish order size
                    string strSize;
                    if (radLar.Checked)
                        strSize = "L";
                    else if (radMed.Checked)
                        strSize = "M";
                    else
                        strSize = "S";

                    //Write Orders to order table
                    dtOrder.Clear();
                    daOrder.FillSchema(dtOrder, SchemaType.Source); 
                    DataRow Order = dtOrder.NewRow();                                   
            
                    //Assign Order values to floating row
                    Order["CustPhone"] = mtbPhone.Text.ToString();
                    Order["OrderDate"] = DateTime.Now.ToShortDateString();
                    Order["OrderSize"] = strSize;
                    Order["Qty"] = nudOrderQty.Value;
                    Order["Top1"] = chkXtraCheese.Checked;
                    Order["Top2"] = chkPep.Checked;
                    Order["Top3"] = chkSsg.Checked;
                    Order["Top4"] = chkMush.Checked;
                    Order["Top5"] = chkArtichoke.Checked;
                    Order["Top6"] = chkCkn.Checked;
                    Order["Top7"] = chkCaBac.Checked;
                    Order["Top8"] = chkOnion.Checked;
                    Order["Top9"] = chkRedPepp.Checked;
                    Order["Top10"] = chkGrPepp.Checked;

                    //Add floating row to order table
                    dtOrder.Rows.Add(Order);

                    //Update database with command builder
                    cbOrder = new SqlCommandBuilder(daOrder);
                    cbOrder.GetUpdateCommand();
                    daOrder.Update(dtOrder);

            //Create and validate filestream/writer that writes out order data to a text file "Customer Data File.txt"
            //utilize separate catches for various types of errors
            FileStream fsCustomerOut = null;

            try
            {
                fsCustomerOut = new FileStream(strCustFile, FileMode.Append, FileAccess.Write);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("File Not Found", "File open error");
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("Directory not found.", "File open error");
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "IOException");
            }
            finally
            {
                if (fsCustomerOut != null)
                    fsCustomerOut.Close();
            }

            //Run streamwriter and catch errors; write count, phone, name, and amount to file
            try
            {
                fsCustomerOut = new FileStream(strCustFile, FileMode.Append, FileAccess.Write);
                swCustomerOut = new StreamWriter(fsCustomerOut);

                strCustomerOut = orderCount.ToString() + "|" + CustomerLog.CustPhone + "|";
                strCustomerOut += CustomerLog.CustName + "|" + lblFinalAmt.Text;

                swCustomerOut.WriteLine(strCustomerOut);

                swCustomerOut.Close();
            }
            catch
            {
                MessageBox.Show("File open error.  Please reload form.");

            }
            finally
            {
                if (swCustomerOut != null)
                {
                    swCustomerOut.Close();
                }
            }
    
        }

        //check for empty input when user leaves input box
        private void txtName_Leave(object sender, EventArgs e)
        {
            emptyChecker();
        }

        //use keypress validation on text name (allowing alpha, space, and backspace ASCII codes); also, allows user to close form
        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ActiveControl.Name == "btnClose") { }
            else if (e.KeyChar >= 65 && e.KeyChar <= 90) { }
            else if (e.KeyChar>=97 && e.KeyChar <= 122) { }
            else if (e.KeyChar == 32 || e.KeyChar==8) { }
            
            else 
            {
                e.Handled = true;
                MessageBox.Show("Input must be characters only.","Input Guidance");             
            }     
        }

        //double check decision to close form
        private void frmOrderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //must cancel the e.Cancel result that is being passed in from the validating events
            e.Cancel = false;

            DialogResult isOkToClose;

            isOkToClose = MessageBox.Show("Do you really want to close the program?", "Exit Warning", MessageBoxButtons.YesNo);

            if (isOkToClose == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        //instantiate a new credit card form, show the dialog, and pass back tag result
        private void btnCredit_Click(object sender, EventArgs e)
        {
            frmCreditCard FormCredit = new frmCreditCard();
            FormCredit.ShowDialog();
            isCardValid = Convert.ToBoolean(FormCredit.Tag);
            emptyChecker();
        }

        //radio button click events (3)
        private void mnuSmall_Click(object sender, EventArgs e)
        {
            radSmall.Checked = true;
        }

        private void mnuMedium_Click(object sender, EventArgs e)
        {
            radMed.Checked = true;
        }

        private void mnuLarge_Click(object sender, EventArgs e)
        {
            radLar.Checked = true;
        }

        //code context menustrup (right click options cut/paste/clear clipboard)
        private void cmsCut_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(ActiveControl.Text);
                this.ActiveControl.Text = "";
                grpCustInfo.Focus();
            }
            catch
            {
                MessageBox.Show("No data to copy to clipboard");
            }
            
        }

        private void cmsPaste_Click(object sender, EventArgs e)
        {
                this.ActiveControl.Text = Clipboard.GetText();
                this.Focus();
        }

        private void clearClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
        }

        //mark the proper credit card selection and "press" the card info button
        private void cboCard_SelectedIndexChanged(object sender, EventArgs e)
        {
                if (cboCard.SelectedItem.Equals("Discover"))
                {
                    mnuDiscover.Checked = true;
                    mnuMasterCard.Checked = false;
                    mnuVisa.Checked = false;
                }
                else if (cboCard.SelectedIndex == 1)
                {
                    mnuDiscover.Checked = false;
                    mnuMasterCard.Checked = true;
                    mnuVisa.Checked = false;
                }
                else
                {
                    mnuDiscover.Checked = false;
                    mnuMasterCard.Checked = false;
                    mnuVisa.Checked = true;
                }

                btnCredit.PerformClick();                         
        }

        //coding for credit card selections in payment menu (call combo box selection change)
        private void mnuDiscover_Click(object sender, EventArgs e)
        {
            mnuMasterCard.Checked = false;
            mnuVisa.Checked = false;
            cboCard.SelectedIndex = 0;                 
        }

        private void mnuMasterCard_Click(object sender, EventArgs e)
        {
            mnuDiscover.Checked = false;
            mnuVisa.Checked = false;
            cboCard.SelectedItem = "MasterCard";
        }

        private void mnuVisa_Click(object sender, EventArgs e)
        {
            mnuDiscover.Checked = false;
            mnuMasterCard.Checked = false;
            cboCard.SelectedItem = "Visa";
        }

        //coding of background music mute in file menu
        private void mnuMute_Click(object sender, EventArgs e)
        {
            if (mnuMute.Checked)
            {
                chkMute.Checked = true;
                wmpControl.settings.mute = true;
            }
            else
            {
                chkMute.Checked = false;
                wmpControl.settings.mute = false;
            }
        }
        
        //coding of background music mute in check box
        private void chkMute_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMute.Checked == true)
            {
                mnuMute.Checked = true;
                wmpControl.settings.mute = true;
            }
            else
            {
                mnuMute.Checked = false;
                wmpControl.settings.mute = false;
            }
        }

        //Check for non-zero and valid customer input using booleans.  Enable the accept button after passing validation.
        private void emptyChecker()
        {
            //declare validation flag to enable accept button
            bool isComplete = true;

            //validate customer input information
            if (mtbPhone.Text.Length == 0 || txtName.Text.Length == 0 || txtAddress1.Text.Length == 0 || txtCity.Text.Length == 0 ||
                cboState.Text.Length == 0 || mtbZip.Text.Length == 0)
            {
                isComplete = false;
            }

            //validate order input information 
            if ((radSmall.Checked == false && radMed.Checked == false && radLar.Checked == false) || nudOrderQty.Value == 0 || isCardValid != true)
            {
                isComplete = false;
            }

            //Check to see if all customer info is entered and enable accept btn
            if (isComplete == true)
            {
                btnAccept.Enabled = true;
            }
            else
            {
                btnAccept.Enabled = false;
            }
        }

        //calculate price based on user selections
        private void pricer()
        {
            //Variable to contain all of the pricing calculations
            decimal grossCost = 0.00m;
            decimal salesTaxCost = 0m;
            decimal afterTaxCost = 0.00m;
            decimal sizeCost = 0.00m;
            decimal toppingCost = 0.00m;
            long toppingCounter = 0;

            //Tally toppings
            if (chkArtichoke.Checked)
            {
                toppingCounter++;
            }
            if (chkCaBac.Checked)
            {
                toppingCounter++;
            }
            if (chkCkn.Checked)
            {
                toppingCounter++;
            }
            if (chkGrPepp.Checked)
            {
                toppingCounter++;
            }
            if (chkMush.Checked)
            {
                toppingCounter++;
            }
            if (chkOnion.Checked)
            {
                toppingCounter++;
            }
            if (chkPep.Checked)
            {
                toppingCounter++;
            }
            if (chkRedPepp.Checked)
            {
                toppingCounter++;
            }
            if (chkSsg.Checked)
            {
                toppingCounter++;
            }
            if (chkXtraCheese.Checked)
            {
                toppingCounter++;
            }
            //Calculate cost of toppings
            toppingCost = toppingCounter * ToppingPrice;


            //Retrieve price on sizing choice
            if (radSmall.Checked)
            {
                sizeCost += SmallPrice;
            }
            else if (radMed.Checked)
            {
                sizeCost += MediumPrice;
            }
            else if (radLar.Checked)
            {
                sizeCost += LargePrice;
            }
            else
            {
                sizeCost = 0;
            }

            //Calculate total gross cost and output string
            grossCost = (sizeCost + toppingCost) * nudOrderQty.Value;
            lblPriceAmt.Text = "$" + Math.Round(grossCost, 2).ToString();

            //Calculate sales tax cost and output string
            salesTaxCost = grossCost * SalesTaxRate;
            lblTaxAmt.Text = Math.Round(salesTaxCost, 2).ToString();

            //Calculate after-tax cost and output string
            afterTaxCost = grossCost + salesTaxCost;
            lblFinalAmt.Text = "$" + Math.Round(afterTaxCost, 2).ToString();

        }

        //reset inputs and selections, as well as reset pricing
        private void resetter()
        {
            //Topping Check Boxes
            chkArtichoke.Checked = false;
            chkCaBac.Checked = false;
            chkCkn.Checked = false;
            chkGrPepp.Checked = false;
            chkMush.Checked = false;
            chkOnion.Checked = false;
            chkPep.Checked = false;
            chkRedPepp.Checked = false;
            chkSsg.Checked = false;
            chkXtraCheese.Checked = false;

            //Customer Information
            mtbPhone.Text = string.Empty;
            txtName.Text = null;
            txtAddress1.Text = null;
            txtAddress2.Text = null;
            txtCity.Text = null;
            cboState.Text = "MN";
            mtbZip.Text = null;

            //Size radio buttons
            radSmall.Checked = true;

            //NUD Quantity Box
            nudOrderQty.Value = 1;

            //Pay method
            cboCard.Text = "Card Type";

            //Clear calculations
            lblPriceAmt.Text = null;
            lblTaxAmt.Text = null;
            lblFinalAmt.Text = null;

            //Disable the accept order button
            btnAccept.Enabled = false;

            //add pricing
            pricer();
        }
    }
}
