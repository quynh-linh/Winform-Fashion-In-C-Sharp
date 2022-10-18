using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CustomerDTO
    {
        private string idCustomer;
        private string nameCustomer;
        private string addressCustomer;
        private int phoneCustomer;
        private string sexCustomer;
        public CustomerDTO()
        {

        }
        public CustomerDTO(string idCustomer, string nameCustomer, string addressCustomer, int phoneCustomer
            ,string sexCustomer)
        {
            this.idCustomer = idCustomer;
            this.nameCustomer = nameCustomer;
            this.addressCustomer = addressCustomer;
            this.phoneCustomer = phoneCustomer;
            this.sexCustomer = sexCustomer;
        }

        public string IdCustomer { get => idCustomer; set => idCustomer = value; }
        public string NameCustomer { get => nameCustomer; set => nameCustomer = value; }
        public string AddressCustomer { get => addressCustomer; set => addressCustomer = value; }
        public int PhoneCustomer { get => phoneCustomer; set => phoneCustomer = value; }
        public string SexCustomer { get => sexCustomer; set => sexCustomer = value; }
    }
}
