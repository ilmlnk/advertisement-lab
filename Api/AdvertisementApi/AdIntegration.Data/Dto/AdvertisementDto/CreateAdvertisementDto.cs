using AdIntegration.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Data.Dto.AdvertisementDto
{
    public record CreateAdvertisementDto
    {
        public string Name;
        public string Topic;
        public string? Description;
        public decimal Price;
        public User UserEntity;
        public Channel ChannelType;
    }
}
