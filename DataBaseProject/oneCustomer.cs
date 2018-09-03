using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseProject
{
    class oneCustomer
    {
        public int CustomerId;
        public string FirstName;
        public string Surname;
        public string Address;
        public int PhoneNum;
        public int CellPhone;
        public oneCustomer(int CustomerId, string FirstName, string Surname, string Address, int PhoneNum, int CellPhone)
        {
            this.CustomerId = CustomerId;
            this.FirstName = FirstName;
            this.Surname = Surname;
            this.Address = Address;
            this.PhoneNum = PhoneNum;
            this.CellPhone = CellPhone;
        }

    }
}
