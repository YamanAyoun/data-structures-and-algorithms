using Hash_Table;

namespace TestHashTable
{
    public class UnitTest1
    {
        [Fact]
        public void SetAndGet()
        {
            // Arrange
            var hashtable = new HashTable();
            hashtable.Set("Yaman", "Software Engineering");

            // Act
            var result = hashtable.Get("Yaman");

            // Assert
            Assert.Equal("Software Engineering", result);
        }

        [Fact]
        public void KeyReturnsNull()
        {
            // Arrange
            var hashtable = new HashTable();

            // Act
            var result = hashtable.Get("nonexistent_key");

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public void TestHashTableCollisionValue()
        {
            HashTable hashTable = new HashTable();
            hashTable.Set("yaman", "Software Engineering\"");
            hashTable.Set("Ali", "D.r");

            Assert.Equal("D.r", hashTable.Get("Ali"));
        }

        [Fact]
        public void HashingInRange()
        {
            // Arrange
            var hashtable = new HashTable();

            // Act
            int hashValue = hashtable.Hash("key1");

            // Assert
            Assert.InRange(hashValue, 0, 1023);
        }

        [Fact]
        public void TestRepeatedWordSimple()
        {
            Assert.Equal("a", HashTable.RepeatedWord("Once upon a time, there was a brave princess who..."));
        }

        [Fact]
        public void TestRepeatedWordSmallLetters()
        {
            Assert.Equal("it", HashTable.RepeatedWord("It was the best of times, it was the worst of times, it was the age of wisdom, it was the age of foolishness, it was the epoch of belief, it was the epoch of incredulity, it was the season of Light, it was the season of Darkness, it was the spring of hope, it was the winter of despair, we had everything before us, we had nothing before us, we were all going direct to Heaven, we were all going direct the other way ? in short, the period was so far like the present period, that some of its noisiest authorities insisted on its being received, for good or for evil, in the superlative degree of comparison only..."));
        }

        [Fact]
        public void TestRepeatedWordComa()
        {
            Assert.Equal("summer", HashTable.RepeatedWord("It was a queer, sultry summer, the summer they electrocuted the Rosenbergs, and I didn?t know what I was doing in New York..."));
        }
    }
}