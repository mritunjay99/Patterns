using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Iterator_Design_Pattern
{
    public class ChannelCollectionImpl : ChannelCollection
    {
        private List<Channel> channelList;

        public ChannelCollectionImpl()
        {
            channelList = new List<Channel>();
        }
        public void addChannel(Channel c)
        {
            channelList.Add(c);
        }

        public ChannelIterator iterator(ChannelTypeEnum type)
        {
            return new ChannelIteratorImpl(type,channelList);
        }

        public void removeChannel(Channel c)
        {
            channelList.Remove(c);
        }
    }
}
