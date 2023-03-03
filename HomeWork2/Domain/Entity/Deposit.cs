using HomeWork2.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2.Domain.Entity
{
    internal class Deposit : BaseEntity
    {
     
        public Guid ClientId { get; set; }
        public Client? Client { get; set; }

        public Guid ManagerId { get; set; }
        public Manager? Manager { get; set; }
        public DateTime OpenningDate { get; set; }

      
        

       
       
    }
}
