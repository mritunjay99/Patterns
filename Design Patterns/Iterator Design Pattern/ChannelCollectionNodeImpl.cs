using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Iterator_Design_Pattern
{
    public class ChannelCollectionNodeImpl:ChannelCollection
    {
        private ListNode head,tail;
        public ChannelCollectionNodeImpl()
        {
            head = null;
            tail = null;
        }

        public void addChannel(Channel c)
        {
            ListNode newChannel=new ListNode(c);
            if (head == null)
            {
                head = newChannel;
                tail = newChannel;
            }
            else
            {
                tail.next = newChannel;
                tail=newChannel;
            }
        }

        public ChannelIterator iterator(ChannelTypeEnum type)
        {
            return new ChannelIteratorNodeImpl(type,head);    
        }

        public void removeChannel(Channel c)
        {
            throw new NotImplementedException();
        }   
    }
}
