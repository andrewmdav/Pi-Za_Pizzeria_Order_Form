using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase_4_Pizza_Project
{
    /*
     * class creates a simple customer object that holds contact data from the form when the 
     * Accept button is clicked.
    */
    class Customer
    {
        //class-level variables
        private string custPhone;
        private string custName;
        private string custAddr1;
        private string custAddr2;
        private string custCity;
        private string custState;
        private string custZip;

        //constructors
        public Customer(){ }
    
        public Customer(string custPhone, string custName, string custAddr1, string custAddr2, string custCity, string custState, string custZip)
        {
            this.CustPhone = custPhone;
            this.CustName = custName;
            this.CustAddr1 = custAddr1;
            this.CustAddr2 = custAddr2;
            this.CustCity = custCity;
            this.CustState = custState;
            this.CustZip = custZip;
        }
        
        public Customer(string custPhone, string custName)
        {
            this.CustPhone = custPhone;
            this.CustName = custName;
        }

        //property getters/setters
        public string CustPhone
        {
            get{return custPhone;}
            set{custPhone = value;}
        }
        public string CustName
        {
            get{return custName;}
            set{custName = value;}
        }
        public string CustAddr1
        {
            get{return custAddr1;}
            set{custAddr1 = value;}
        }
        public string CustAddr2
        {
            get{return custAddr2;}
            set{custAddr2 = value;}
        }
        public string CustCity
        {
            get{return custCity;}
            set{custCity = value;}
        }
        public string CustState
        {
            get{return custState;}
            set{custState = value;}
        }
        public string CustZip
        {
            get{return custZip;}
            set{custZip = value;}
        }
    }
}
