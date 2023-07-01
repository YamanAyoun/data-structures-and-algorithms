using linked_list_insertions;

namespace Test_linked_list_insertion
{
    public class UnitTest1
    {
        [Fact]
        public void TestInsertBeforeMiddle()
        {
            insertions_linked_list list = new();
            list.Append("3");
            list.Append("2");
            list.Append("1");
            list.InsertBefore("2", "4");
            Assert.Equal("{3} -> {4} -> {2} -> {1} -> NULL", list.ToString());
        }

        [Fact]
        public void TestInserBeforeFirst()
        {
            insertions_linked_list list = new();
            list.Append("1");
            list.InsertBefore("1", "4");
            Assert.Equal("{4} -> {1} -> NULL", list.ToString());
        }

        [Fact]
        public void TestInsertAfterMiddle()
        {
            insertions_linked_list list = new();
            list.Append("3");
            list.Append("2");
            list.Append("1");
            list.InsertAfter("2", "4");
            Assert.Equal("{3} -> {2} -> {4} -> {1} -> NULL", list.ToString());
        }

        [Fact]
        public void TestInsertAfterLast()
        {
            insertions_linked_list list = new();
            list.Append("3");
            list.Append("2");
            list.Append("1");
            list.InsertAfter("3", "4");
            Assert.Equal("{3} -> {4} -> {2} -> {1} -> NULL", list.ToString());
        }

    }
}