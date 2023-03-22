using Fashion_Fuction.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fashion_Fuction.Services
{
    public interface IContactService
    {
        public List<ContactModel> GetAllContact();
        public List<EmailModel> GetAllEmail();
        public Task<bool> CreateContact(ContactModel contactModel);
    }
}
