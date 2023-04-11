using Contact.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact.API.Infrastructure
{
    public class ContactService : IContactService
    {
        public ContactDTO GetContactById(int id)
        {
            return new ContactDTO
            {
                Id = id,
                FirstName = "Murat",
                LastName = "İlgün"
            };
        }
    }
}
