using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Domain.Entities.Common
{
    public class BaseEntity<T>
    {
        public T Id { get; set; }
        public bool IsRemove { get; set; }
        public DateTime? RemoveTime { get; set; }
        public DateTime InsertTime { get; set; }
        public DateTime? UpdateTime { get; set; }

    }

    public class BaseEntity : BaseEntity<int>
    {

    }
}
