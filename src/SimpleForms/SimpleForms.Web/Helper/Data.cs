using System.Collections.Generic;
using SimpleForms.Web.Models;

namespace SimpleForms.Web.Helper
{
    public static class Data
    {
        private static List<ContactFormModel> contacts = new List<ContactFormModel>();

        public static List<ContactFormModel> Contacts
        {
            get { return contacts; }
        }

        public static void Add(ContactFormModel contact)
        {
            contacts.Add(contact);
        }
    }
}