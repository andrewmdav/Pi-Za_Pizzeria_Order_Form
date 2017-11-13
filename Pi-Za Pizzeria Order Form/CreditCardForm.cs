using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Form intakes credit card information from the customer, which is accepted
 * only after a complete card number and valid expiration date have been 
 * entered.  
*/

namespace Phase_4_Pizza_Project
{
    public partial class frmCreditCard : Form
    {
        public frmCreditCard()
        {
            InitializeComponent();
            
            //boolean confirming user completion of credit card form
            this.Tag = false;
            
            //disable "ok" button until valid credit card data is entered
            btnOk.Enabled = false;
        }

        //return a true tag with an "ok" button selection (only available after input validation)
        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Tag = true;
            this.Close();  
        }

        //validate card number length with a font color change (user can cancel but otherwise cannot proceed until complete)
        private void mtbCardNum_Validating(object sender, CancelEventArgs e)
        {
            if (ActiveControl.Name == "btnCancel")
            {
                this.Close();
                this.Tag = false;            
            }

            else if (mtbCardNum.Text.Length < 16)
            {
                e.Cancel = true;
                mtbCardNum.ForeColor = Color.Red;
            }
            else
            {
                mtbCardNum.ForeColor = Color.Black;
            }
                
        }

        //at year selection, validate credit card expiration date entry (should not be earlier than present date)
        private void cboYear_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                //convert string data into DateTime for comparison with current date
                string strCCExpDate = cboMonth.SelectedItem.ToString() + "/" + DateTime.Now.Day + "/" + cboYear.SelectedItem.ToString();
                DateTime ccDate = DateTime.Parse(strCCExpDate);

                if (ccDate < DateTime.Now)
                {
                    MessageBox.Show("Card date has expired.  Please check your entry or use a different card.");
                    mtbCardNum.Focus();
                }
                else
                {
                    btnOk.Enabled = true;
                    btnOk.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Please enter a valid expiration date.");
            }
        }

        //at month selection, validate credit card expiration date entry (should not be earlier than present date)
        private void cboMonth_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                //convert string data into DateTime for comparison with current date
                string strCCExpDate = cboMonth.SelectedItem.ToString() + "/" + DateTime.Now.Day + "/" + cboYear.SelectedItem.ToString();
                DateTime ccDate = DateTime.Parse(strCCExpDate);

                if (ccDate < DateTime.Now)
                {
                    btnOk.Enabled = false;
                }
                else
                {
                    btnOk.Enabled = true;
                }
            }
            catch
            {                               
                btnOk.Enabled = false;
            }
        }

        //return a false tag with a cancel button selection
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Tag = false;
            this.Close();
        }

        private void frmCreditCard_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }
    }
}
