using System.Text;

namespace LeetCodeChallenges._0014_LongestCommonPrefix;

public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        Array.Sort(strs);
        StringBuilder prefix = new StringBuilder();

        // primeira e ultima palavra
        string first = strs[0];
        string last = strs[strs.Length-1];

        // iterar até o tamanho da menor palavra
        for(int i = 0; i < Math.Min(first.Length, last.Length); i++){
            // se for diferente retorna o prefix
            if(first[i] != last[i]){
                return prefix.ToString();
            }
            // caso seja igual append no stringbuilder para pegar a maior
            prefix.Append(first[i]);
        }
        return prefix.ToString();

    }
}