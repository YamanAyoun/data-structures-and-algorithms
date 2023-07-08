using linkedListZip;

namespace TestLinkedListZip
{
    public class UnitTest1
    {
        [Fact]
        public void TestZipList()
        {
            linked_list_zip list1 = new();
            list1.Append("1");
            list1.Append("3");
            list1.Append("2");
            

            linked_list_zip list2 = new();
            list2.Append("5");
            list2.Append("9");
            list2.Append("4");
            

            linked_list_zip zipList = linked_list_zip.ZipList(list1, list2);
            
            Assert.Equal("{1} -> {5} -> {3} -> {9} -> {2} -> {4} -> NULL", zipList.ToString());
        }

        [Fact]
        public void TestZipList2()
        {
            linked_list_zip list1 = new();
            list1.Append("1");
            list1.Append("3");
            

            linked_list_zip list2 = new();
            list2.Append("5");
            list2.Append("9");
            list2.Append("4");

            linked_list_zip zipList = linked_list_zip.ZipList(list1, list2);

            Assert.Equal("{1} -> {5} -> {3} -> {9} -> {4} -> NULL", zipList.ToString());
        }
    }
}