using HomeWork2.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2.Domain.Entity
{
    internal class Manager:BaseEntity
    {
        
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Patronymic { get; set; }
        public string? Email { get; set; }
        public Position ManagerPosition { get; set; }
        public string? PhoneNumber { get; set; }

        public List<Deposit> Deposits { get; set; } = new();



    }
}
