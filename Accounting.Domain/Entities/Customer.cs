using Accounting.Domain.Entities.Common;
using System;
using System.Collections.Generic;

namespace Accounting.Domain.Entities
{
    public class Customer : BaseEntity<Guid>
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public byte Age { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public ICollection<Transaction> Transactions { get; set; }
    }







}
