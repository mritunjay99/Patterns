using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Iterator_Design_Pattern
{
    public class ChannelIteratorImpl : ChannelIterator
    {
        private ChannelTypeEnum type;
        private List<Channel> channelList;
        private int position;
        public ChannelIteratorImpl(ChannelTypeEnum type, List<Channel> channelList)
        {
            this.type = type;
            this.channelList = channelList;
            position = 0;
        }
        public bool hasNext()
        {
            while(position < channelList.Count)
            {
                Channel channel = channelList[position];
                if(channel.getTYPE() == type || type.Equals(ChannelTypeEnum.ALL))
                {
                    return true;
                }
                position++;
            }
            return false;
        }

        public Channel next()
        {
            Channel channel = channelList[position];
            position++;
            return channel;
        }
    }
}
