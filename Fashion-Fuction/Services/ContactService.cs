using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fashion_Fuction.Models;
using Fashion_Fuction.Services.Interface;
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
                    model.Subject = itemContact.a.contact_Subject;
                    model.Message = itemContact.a.contact_Message;
                    model.IsCheck = itemContact.a.contact_IsCheck;

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

        public async Task<bool> CreateContact(ContactModel contactModel)
        {
            try
            {
                
                EmailCustomerTable customerTable = new EmailCustomerTable();
                string emailId = Guid.NewGuid().ToString();

                customerTable.emailC_Id = emailId;
                customerTable.emailC_Email = contactModel.Email;
                customerTable.emailC_IsDelete = false;
                await _context.emailCustomerTable.AddAsync(customerTable);


                ContactTable contactTable = new ContactTable();
                contactTable.contact_Id = Guid.NewGuid().ToString();
                contactTable.contact_Name = contactModel.Name;
                contactTable.contact_EmailId = emailId;
                contactTable.contact_Subject = contactModel.Subject;
                contactTable.contact_Message = contactModel.Message;
                contactTable.contact_IsCheck = false;
                contactTable.CreateOn = DateTime.Now;
                await _context.contactTable.AddAsync(contactTable);
                await _context.SaveChangesAsync();

                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public ContactModel GetContactById(string contactId)
        {
            try
            {
                var queryContact = from a in _context.contactTable
                                   join b in _context.emailCustomerTable on a.contact_EmailId equals b.emailC_Id
                                   where a.IsDelete == false && a.contact_Id == contactId
                                   select new { a, b };


                foreach (var itemContact in queryContact)
                {
                    ContactModel model = new ContactModel();

                    model.Id = itemContact.a.contact_Id;
                    model.Name = itemContact.a.contact_Name;
                    model.Email = itemContact.b.emailC_Email;
                    model.Subject = itemContact.a.contact_Subject;
                    model.Message = itemContact.a.contact_Message;
                    model.IsCheck = itemContact.a.contact_IsCheck;
                    model.CreateOn = itemContact.a.CreateOn;

                    return model;
                }


                return new ContactModel();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> Checked(string contactId)
        {
            try
            {
                var contactQuery = _context.contactTable.FirstOrDefault(x => x.contact_Id == contactId);

                if (contactQuery != null)
                {
                    contactQuery.contact_IsCheck = true;

                    await _context.SaveChangesAsync();

                    return true;
                }
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
