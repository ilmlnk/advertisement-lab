using AdIntegration.Data.Entities;

namespace AdIntegration.Repository.Interfaces
{
    public interface IChannelRepository<T, V> where T : User where V : Channel<T>
    {
        /* Create */
        public V CreateChannel<V>(V channel) where V : Channel<T>;
        /* Update */
        public object UpdateChannelById<V>(int id, V channel) where V : Channel<T>;
        /* Get */
        public V GetChannelById<V>(int id) where V : Channel<T>;
        public V GetChannelByLink<V>(string link) where V : Channel<T>;
        public IEnumerable<V> GetChannelsByCategory<V>(string category) where V : Channel<T>;
        public V GetChannelByEmail<V>(string email) where V : Channel<T>;
        public IEnumerable<V> GetChannels<V>() where V : Channel<T>;
        /* Delete */
        public V DeleteChannelById<V>(int id) where V : Channel<T>;

    }
}
