using linked_list_kth;

namespace TestLinkedList_kth
{
    public class UnitTest1
    {
        [Fact]
        public void TestLinkedListkth()
        {
            Linked_List_kth list = new Linked_List_kth();

            list.Append("4");
            list.Append("3");
            list.Append("2");
            list.Append("1");
            list.Append("0");

            
            Assert.Equal("3", list.KthFromEnd(3));
        }

        [Fact]
        public void TestLinkedListkth2()
        {
            Linked_List_kth list = new Linked_List_kth();

            list.Append("1");
            list.Append("2");
            list.Append("5");
            list.Append("4");
            list.Append("0");


            Assert.Equal("5", list.KthFromEnd(2));
        }

        [Fact]
        public void TestLinkedListkth3()
        {
            Linked_List_kth list = new Linked_List_kth();

            list.Append("1");
            list.Append("3");
           


            Assert.Equal("Exception", list.KthFromEnd(2));
        }

        [Fact]
        public void TestLinkedListkth4()
        {
            Linked_List_kth list = new Linked_List_kth();

            list.Append("1");

            Assert.Equal("1", list.KthFromEnd(0));
        }
    }
}