using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Data.Entities
{
    public abstract class Channel<T> where T : User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public byte[] Photo { get; set; }
        public bool IsPrivate { get; set; }
        public int ActiveUsers { get; set; }
        public int Posts { get; set; }
        public List<T> UserAdmins { get; set; }
    }
}
