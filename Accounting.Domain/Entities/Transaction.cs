using Accounting.Domain.Entities.Common;
using System;

namespace Accounting.Domain.Entities
{
    public class Transaction : BaseEntity<Guid>
    {
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public DateTime TransactionDate { get; set; }

        public int TypeId { get; set; }
        public TransactionType Type { get; set; }

        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }
    }







}
