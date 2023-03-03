﻿using HomeWork2.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2.Domain.Entity
{
    internal class Account : BaseEntity
    {      
        public decimal Amount { get; set; }
        public Client? Client { get; set; }
        public Guid ClientId { get; set; }

     

              
    }
}
