namespace Design_Patterns.Iterator_Design_Pattern
{
    public interface ChannelCollection
    {
        public void addChannel(Channel c);

        public void removeChannel(Channel c);

        public ChannelIterator iterator(ChannelTypeEnum type);
    }
}
