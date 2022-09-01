using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Core.Entities.Concrete
{
    public class User:ActionsBase,IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] Password { get; set; }
        public bool Status { get; set; }
        public string Phone { get; set; }
        public string TaxNo { get; set; }
        public string Location { get; set; }
        public string IpAddress { get; set; }
        public string City { get; set; }

    }
}
