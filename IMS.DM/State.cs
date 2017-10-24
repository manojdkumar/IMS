using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.DM
{
    public class State
    {
        private int stateId;
        private bool isActive;
        private string name;

        public int ID
        {
            get { return stateId; }
            set { stateId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }

        } 
        public bool IsActive
        {
            get { return isActive; }
            set { isActive = value; }

        }

        
    }
}
