using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Hash_Table
{
    public class HashTable
    {
        Node[] hashTable = new Node[1024];
        
        public void Set(string key, string value)
        {
            int index = Hash(key);
            Node bucket = new Node(key, value);

            if (hashTable[index] == null)
            {
                hashTable[index] = bucket;
            }
            else
            {
                Node current = hashTable[index];
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = bucket;
            }
        }
        public string Get(string key)
        {
            int index = Hash(key);
            Node current = hashTable[index];
            while (current != null)
            {
                if (current.key == key)
                {
                    return current.value;
                }
                current = current.Next;
            }
            return null;
        }
        public bool Has(string key)
        {
            int index = Hash(key);
            Node current = hashTable[index];
            while (current != null)
            {
                if (current.key == key)
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }
        public List<string> Keys()
        {
            List<string> keys = new List<string>();
            for (int i = 0; i < hashTable.Length; i++)
            {
                Node current = hashTable[i];
                while (current != null)
                {
                    keys.Add(current.key);
                    current = current.Next;
                }
            }
            return keys;
        }
        public int Hash(string key)
        {
            int hashValue = 0;

            char[] letters = key.ToCharArray();

            for (int i = 0; i < letters.Length; i++)
            {
                hashValue += letters[i]; /// Integer representation
            }

            //0 - 9
            hashValue = (hashValue * 599) % key.Length;

            return hashValue;
        }
        public static string RepeatedWord(string input)
        {
            HashTable hash = new HashTable();
            input = input.Replace(",", string.Empty);
            string[] words = input.ToLower().Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (hash.Has(words[i]))
                {
                    return hash.Get(words[i]);
                }
                hash.Set(words[i], words[i]);
            }

            return "nothing repeated";
        }

    }
}
