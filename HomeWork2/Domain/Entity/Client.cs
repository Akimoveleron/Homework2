using HomeWork2.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2.Domain.Entity
{
    internal class Client : BaseEntity
    {
        
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Patronymic { get; set; }
        public string? Email { get; set; }
        public string PassportNumber { get; set; }
        public string? PhoneNumber { get; set; }
        public Guid AccountId { get; set; }
        public Client(string firstName, string lastName, string patronymic, string email,
           string passportNumber, string phoneNumber, Guid accountId)
        {
            Id = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            Patronymic = patronymic;
            Email = email;
            PassportNumber = passportNumber;
            PhoneNumber = phoneNumber;
            AccountId = accountId;



        }


    }
}
