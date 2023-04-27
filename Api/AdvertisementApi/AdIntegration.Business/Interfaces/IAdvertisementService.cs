using AdIntegration.Data.Dto;
using AdIntegration.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdIntegration.Business.Interfaces
{
    public interface IAdvertisementService<T, V> where T : User where V : Channel<T>
    {
        public Advertisement<T, V> CreateAdvertisement<T, V>(Advertisement<T, V> advertisement) where T : User where V : Channel<T>;
        public Advertisement<T, V> UpdateAdvertisementById<T, V>(int id, Advertisement<T, V> advertisement) where T : User where V : Channel<T>;
        public Advertisement<T, V> DeleteAdvertisement<T, V>(int id) where T : User where V : Channel<T>;
        public IEnumerable<Advertisement<T, V>> GetAllAdvertisements<T, V>() where T : User where V : Channel<T>;
        public Advertisement<T, V> GetAdvertisementById<T, V>(int id) where T : User where V : Channel<T>;
    }
}
