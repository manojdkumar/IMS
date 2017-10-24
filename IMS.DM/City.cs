using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.DM
{
    public class City
    {
        private int cityId;
        private string name;
        private State cityState;
        private bool isActive;


        public int ID
        {
            get { return cityId; }
            set { cityId = value; }
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

        public State State
        {
            get { return cityState; }
            set { cityState = value; }
        }
    }
}
