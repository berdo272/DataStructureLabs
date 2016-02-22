using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataStructure
{
    class Contestant
    {
        string Name;
        string PhoneNumber;

        public Contestant(string name ,string phoneNumber)
        {
            this.Name = name;
            this.PhoneNumber = phoneNumber;
        }

        public string _name
        {
            get
            {
                return Name;
            }
        }
        public string _phoneNumber
        {
            get
            {
                return PhoneNumber;
            }
        }

    }
}
