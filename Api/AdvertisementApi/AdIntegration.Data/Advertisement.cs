using AdIntegration.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Data
{
    public class Advertisement
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Topic { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime DatePosted { get; set; }
        
        // Reference on user that created an advertisement

        public int UserId { get; set; }
        public User User { get; set; }

    }
}
