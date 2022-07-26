using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ContactManager.Models;

namespace ContactManager.Services
{
    public class ContactRepository
    {
        static Contact[] Contacts { get; }
        static ContactRepository()
        {
            Contacts = new Contact[]
            {
                new Contact { Id =1, Name = "Glenn Block" },
                new Contact { Id = 2, Name = "Dan Roth" }
            };
        }
        public Contact[] GetAllContacts() 
        {
            return Contacts;
        }
        public Contact GetContactById(long id)
        {
            return Contacts.FirstOrDefault(p => p.Id == id);
        }

    }
}