﻿using Accounting.Domain.Entities.Common;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Domain.Entities
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string ImageTitle { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
