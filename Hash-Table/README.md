
# Code Challenge Class 33: Hashmap LEFT JOIN

Write a method that LEFT JOINs two hashmaps into a single data structure.
This means that a left join returns all the values from the left table, plus matched values from the right table or NULL in case of no matching join predicate.

## Approach & Efficiency
The time complexity: O(n), because the algorithm iterates through each key in firstHashTable.

Space Complexity: O(n) because The primary space usage comes from the result hash table.

## Solution
![Whiteboard](Asserts/cc33.png)

## Code

```
public static HashTable LeftJoin(HashTable firstHashTable, HashTable secondHashTable)
{
    HashTable result = new HashTable();

    foreach (string key in firstHashTable.Keys())
    {
        string synonym = firstHashTable.Get(key);
        string antonym = secondHashTable.Get(key);

        if (antonym != null)
        {
            result.Set(key, $"{synonym} (antonym: {antonym})");
        }
        else
        {
            result.Set(key, $"{synonym} (antonym: NULL)");
        }
    }

    return result;
}
```
=======
# Code Challenge: Class 30: Hash Table Implementation

Hashtables are a data structure that utilize key value pairs every Node has both a key, and a value.

write thie following methods using Hash Table:

* Set 
* Get
* has
* Keys
* Hash

## Approach & Efficiency
- Time complexity for ``Set, Get, has`` methods are O(n).
- Time complexity for `Keys` method is O(n) becouse linked list nodes in specific index (collision).
- Time complexity for `Hash` method is O(n) becouse (n) = key length.

## Testing
```
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
```

![Test Hash Table](Asserts/hashtabletest.png)
