using System.Collections.Generic;
using linked_list;

namespace TestLinkedList
{
    public class UnitTest1
    {
        [Fact]
        public void TestEmptyList()
        {
            LinkedList list = new();
            Assert.Equal("Nothing in the List", list.ToString());
        }

        [Fact]
        public void TestInsert()
        {
            LinkedList list = new();
            list.Insert("newhead");
            Assert.Equal("{newhead} -> NULL", list.ToString());
        }

        [Fact]
        public void TestHead()
        {
            LinkedList list = new();
            list.Insert("first");
            list.Insert("secound");
            Assert.Equal("secound", list.Head.Data);
        }

        [Fact]
        public void TestInsertMultiple()
        {
            LinkedList list = new();
            list.Insert("1");
            list.Insert("2");
            list.Insert("3");
            Assert.Equal("{3} -> {2} -> {1} -> NULL", list.ToString());
        }

        [Fact]
        public void TestIncludeTrue()
        {
            LinkedList list = new();
            list.Insert("1");
            list.Insert("2");
            list.Insert("3");
            Assert.True(list.Includes("2"));
        }

        [Fact]
        public void TestIncludeFalse()
        {
            LinkedList list = new();
            list.Insert("1");
            list.Insert("2");
            list.Insert("3");
            Assert.False(list.Includes("4"));
        }
    }
}