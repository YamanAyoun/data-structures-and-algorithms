using insertion_sort;

namespace TestSorting
{
    public class UnitTest1
    {
        [Fact]
        public void TestInsertionSort()
        {
            
            int[] arr = { 8, 4, 23, 42, 16, 15 };
            int[] sorted = { 4, 8, 15, 16, 23, 42};

            insertionSort.InsertionSort(arr);
            
            Assert.Equal(sorted, arr);
        }

        [Fact]
        public void TestInsertionSortWithAlreadySortedArray()
        {
            
            int[] arr = { 1, 2, 3};
            int[] sorted = { 1, 2, 3};

            insertionSort.InsertionSort(arr);

            Assert.Equal(sorted, arr);
        }

        [Fact]
        public void TestMergeSort()
        {
            int[] arr = { 8, 4, 23, 42, 16, 15 };
            int[] merged = { 4, 8, 15, 16, 23, 42 };

            arr = mergeSort.MergeSort(arr);

            Assert.Equal(merged, arr);
        }

        [Fact]
        public void TestMergeSortIfEmpty()
        {
            int[] arr = { 8, 4, 23, 42, 16, 15 };
            int[] merged = { 4, 8, 15, 16, 23, 42 };

            arr = mergeSort.MergeSort(arr);

            Assert.Equal(merged, arr);
        }


        [Fact]
        public void TestMergeSortWithSingleElement()
        {
            int[] arr = { 1 };
            int[] merged = { 1 };

            arr = mergeSort.MergeSort(arr);

            Assert.Equal(merged, arr);
        }

        [Fact]
        public void TestMergeSortIfDuplicateElements()
        {
            int[] arr = { 3, 2, 1, 3, 2, 1 };
            int[] merged = { 1, 1, 2, 2, 3, 3 };

            arr = mergeSort.MergeSort(arr);

            Assert.Equal(merged, arr);
        }
    }
}