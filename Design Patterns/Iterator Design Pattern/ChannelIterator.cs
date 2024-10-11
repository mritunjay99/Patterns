using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Iterator_Design_Pattern
{
    public interface ChannelIterator
    {
        public Boolean hasNext();

        public Channel next();
    }
}
