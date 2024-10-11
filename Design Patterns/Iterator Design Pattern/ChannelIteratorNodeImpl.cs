using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Iterator_Design_Pattern
{
    public class ChannelIteratorNodeImpl : ChannelIterator
    {
        private ListNode head;
        private ChannelTypeEnum channelType;
        private ListNode temp = null;
        public ChannelIteratorNodeImpl(ChannelTypeEnum type,ListNode channels)
        {
            head = channels;
            channelType = type;
            temp = head;
        }
        public bool hasNext()
        {
            while (temp != null)
            {
                Channel ch = temp.ch;
                if(ch.getTYPE() == channelType || channelType.Equals(ChannelTypeEnum.ALL))
                {
                    return true;
                }
                temp = temp.next;
            }
            return false;
        }

        public Channel next()
        {
            Channel ch = temp.ch;
            temp = temp.next;
            return ch;
        }
    }
}
