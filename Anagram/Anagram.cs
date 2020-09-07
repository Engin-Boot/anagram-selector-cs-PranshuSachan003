using System;
using System.Collections.Generic;

namespace Anagram
{
    public class AnagramSelector
    {
        public bool WordPairIsAnagram(string word1, string word2) 
        {
            int[] count1 = new int[256];
            int[] count2 = new int[256];
            for(int i=0;i<word1.Length;i++)
                count1[word1[i]-'a']++;
            for(int j=0;j<word2.Length;j++)
                count2[word2[j]-'a']++;
            if(word1.Length!=word2.Length)
                return false;
            else
            {
                for(int k=0;k<256;k++)
                {
                    if(count1[k]!=count2[k])
                        return false;
                }
            }
            //Insert the correct implementation here
            return true;
        }
        public List<string> SelectAnagrams(string word, List<string> candidates) 
        {
            List<string> listOfAnagramOfWord = new List<string>();
            for(int i=0;i<candidates.Count;i++)
            {
                if(WordPairIsAnagram(word,candidates[i])==true)
                    listOfAnagramOfWord.Add(candidates[i]);
            }
            return listOfAnagramOfWord;
        }
    }
}
