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

        
    }
}