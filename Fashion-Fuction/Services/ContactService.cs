using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fashion_Fuction.Models;
using Fashion_Infrastructure.Data;
using Fashion_Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace Fashion_Fuction.Services
{
    public class ContactService : IContactService
    {
        private ApplicationDbContext _context;
        public ContactService(ApplicationDbContext context) 
        {
            _context = context;
        }
        public List<ContactModel> GetAllContact()
        {
            try
            {
                var queryContact = from a in _context.contactTable
                                   join b in _context.emailCustomerTable on a.contact_EmailId equals b.emailC_Id
                                   where a.IsDelete == false
                                   select new { a, b };


                List<ContactModel> contactList = new List<ContactModel>();
                foreach (var itemContact in queryContact)
                {
                    ContactModel model = new ContactModel();

                    model.Id = itemContact.a.contact_Id;
                    model.Name = itemContact.a.contact_Name;
                    model.Email = itemContact.b.emailC_Email;
                    model.Subject = itemContact.a.emailC_Subject;
                    model.Message = itemContact.a.emailC_Message;

                    contactList.Add(model);
                }


                return contactList;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<EmailModel> GetAllEmail() 
        {
            try
            {
                var queryContact = _context.emailCustomerTable.Where(x => x.emailC_IsDelete == false);
                List <EmailModel> emailList = new List<EmailModel>();

                foreach (var item in queryContact)
                {
                    EmailModel email = new EmailModel();
                    email.Email = item.emailC_Email;
                    emailList.Add(email);   
                }

                return emailList;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
