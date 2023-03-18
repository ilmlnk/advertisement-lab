using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Business.Models
{
    internal class AdvertisementViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public AdvertisementsViewModel[] Advertisements { get; set; }
    }

    public class AdvertisementsViewModel
    {

    }
}
