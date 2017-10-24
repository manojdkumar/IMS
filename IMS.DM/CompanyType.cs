using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.DM
{
    public class CompanyType
    {
        private int companyTypeId;
        private string type;
        private bool isActive;

        public int ID
        {
            get { return companyTypeId; }
            set { companyTypeId = value; }
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
    }
}
