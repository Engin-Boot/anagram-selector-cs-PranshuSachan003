using System;
using System.Collections.Generic;

namespace Anagram
{
    public class AnagramSelector
    {
        public int[] calculatingFrequencyOfLiteral(string word)
        {
            int[] count = new int[256];
            for(int i=0;i<word.Length;i++)
                count[word[i]-'a']++;
            return count;
        }
        public bool lengthOfWordPairIsEqual(string word1, string word2)
        {
            if(word1.Length!=word2.Length)
                return false;
            else
                return true;
        }
        public bool equalLengthWordPairIsAnagram(int[] count1, int[] count2)
        {
            for(int k=0;k<256;k++)
                {
                    if(count1[k]!=count2[k])
                        return false;
                }
            return true;
        }
        public bool WordPairIsAnagram(string word1, string word2) 
        {
            int[] count1 = new int[256];
            int[] count2 = new int[256];
            count1 = calculatingFrequencyOfLiteral(word1);
            count2 = calculatingFrequencyOfLiteral(word2);
            if(lengthOfWordPairIsEqual(word1,word2)==false)
                return false;
            else
            {
                if(equalLengthWordPairIsAnagram(count1,count2)==true)
                    return true;
                else
                    return false;
            }
            //Insert the correct implementation here
        }
        public List<string> SelectAnagrams(string word, List<string> candidates) 
        {
            List<string> listOfAnagramOfWord = new List<string>();
            string temp;
            for(int i=0;i<candidates.Count;i++)
            {
                temp = candidates[i];
                if(WordPairIsAnagram(word,temp)==true)
                    listOfAnagramOfWord.Add(temp);
            }
            return listOfAnagramOfWord;
        }
    }
}
