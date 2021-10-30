using Accounting.Domain.Entities.Common;
using System.Collections.Generic;

namespace Accounting.Domain.Entities
{
    public class TransactionType : BaseEntity
    {
        public string Title { get; set; }
        public ICollection<Transaction> Transactions { get; set; }
    }







}
