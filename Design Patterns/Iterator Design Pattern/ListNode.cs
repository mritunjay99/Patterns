namespace Design_Patterns.Iterator_Design_Pattern
{
    public class ListNode
    {
        public Channel ch;
        public ListNode next;

        public ListNode(Channel ch)
        {
            this.ch = ch;
            next = null;
        }
    }
}
