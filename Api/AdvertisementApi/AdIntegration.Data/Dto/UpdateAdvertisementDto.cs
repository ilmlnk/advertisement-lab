using AdIntegration.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Data.Dto
{
    public class UpdateAdvertisementDto
    {
        public string Name { get; set; }
        public string Topic { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public User UserEntity { get; set; }
    }
}
