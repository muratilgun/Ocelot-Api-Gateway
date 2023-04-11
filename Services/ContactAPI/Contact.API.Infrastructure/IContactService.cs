using System;
using System.Linq;
using System.Text;
using Contact.API.Models;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Contact.API.Infrastructure
{
    public interface IContactService
    {
        public ContactDTO GetContactById(int id);
    }
}
