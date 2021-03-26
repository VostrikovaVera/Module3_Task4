using System;
using System.Collections.Generic;
using System.Linq;

namespace Module3_Task4
{
    public class LINQTask
    {
        private List<Contact> _contacts = new List<Contact>();

        public void Run()
        {
            _contacts.AddRange(new Contact[]
            {
                new Contact() { FirstName = "Rachel", LastName = "Green", PhoneNumber = "33333333333" },
                new Contact() { FirstName = "Joey", LastName = "Tribbiani", PhoneNumber = "123123123" },
                new Contact() { FirstName = "Ross", LastName = "Geller", PhoneNumber = "11111111111" },
                new Contact() { FirstName = "Monica", LastName = "Geller", PhoneNumber = "22222222222" },
                new Contact() { FirstName = "Phoebe", LastName = "Buffay", PhoneNumber = "4444444444444" },
                new Contact() { FirstName = "Chandler", LastName = "Bing", PhoneNumber = "55555555555" },
                new Contact() { FirstName = "apartment", LastName = "15", PhoneNumber = "777777777" },
                new Contact() { FirstName = "Pizza", LastName = "*", PhoneNumber = "123456789" },
            });

            var names = _contacts.Select(c => c.FullName);

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("----------Where------------");

            var gellersFamily = _contacts.Where(c => c.LastName == "Geller");

            foreach (var contact in gellersFamily)
            {
                Console.WriteLine($"{contact.FullName} {contact.PhoneNumber}");
            }

            Console.WriteLine("----------FirstOrDefault------------");

            var gellerContact = _contacts.FirstOrDefault(c => c.LastName == "Gellers");

            Console.WriteLine(gellerContact == null ? "There are no such contacts" : gellerContact.FullName);

            Console.WriteLine("-----------OrderByDescending&ThenByDescending-----------");

            var contactsSortedDesc = _contacts.OrderByDescending(c => c.LastName).ThenByDescending(c => c.FirstName);

            foreach (var contact in contactsSortedDesc)
            {
                Console.WriteLine($"{contact.FullName} {contact.PhoneNumber}");
            }

            Console.WriteLine("----------Reverse------------");

            var contactsSortedAsc = contactsSortedDesc.Reverse();

            foreach (var contact in contactsSortedAsc)
            {
                Console.WriteLine($"{contact.FullName} {contact.PhoneNumber}");
            }

            Console.WriteLine("----------All------------");

            var isLongNames = _contacts.All(c => c.LastName.Length > 5 && c.FirstName.Length > 5);

            Console.WriteLine(isLongNames);
        }
    }
}