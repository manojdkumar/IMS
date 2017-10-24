using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.DM
{
    public class CompanyVM
    {
        private int id;
        private string name;
        private string gstinnum;
        private string email;
        private string city;
        private string zip;
        private string panNumber;
        private string contactPerson;
        private string state;
        private string type;
        private string cinNum;
        private string bankName;
        private string accountNumber;
        private string ifscCode;
        private string phone;
        private string address;
        private bool isActive;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }

        }

        public string GSTINNUM
        {
            get { return gstinnum; }
            set { gstinnum = value; }

        }
        public string Email
        {
            get { return email; }
            set { email = value; }

        }


        public string City
        {
            get { return city; }
            set { city = value; }

        }

        public string State
        {
            get { return state; }
            set { state = value; }
        }
        public string Zip
        {
            get { return zip; }
            set { zip = value; }

        }

        public string PANNumber
        {
            get { return panNumber; }
            set { panNumber = value; }

        }

        public string ContactPerson
        {
            get { return contactPerson; }
            set { contactPerson = value; }

        }

        public string CINNum
        {
            get { return cinNum; }
            set { cinNum = value; }

        }

        public string BankName
        {
            get { return bankName; }
            set { bankName = value; }

        }

        public string AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }

        }

        public string IFSCCode
        {
            get { return ifscCode; }
            set { ifscCode = value; }

        }

        public string Type
        {
            get { return type; }
            set { type = value; }

        }

        public bool IsActive
        {
            get { return isActive; }
            set { isActive = value; }

        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }

        }

        public string Address
        {
            get { return address; }
            set { address = value; }

        }
    }
}
