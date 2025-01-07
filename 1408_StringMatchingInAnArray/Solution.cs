public class Solution {
    public IList<string> StringMatching(string[] words) {
        List<string> substring = new List<string>();
        for(int i = 0; i < words.Length; i++){
            for(int j = 0; j < words.Length; j++){
                if(i != j){
                    if(words[j].Contains(words[i])){
                        substring.Add(words[i]);
                        break;
                    }
                }
            }
        }
        return substring;        
    }
}