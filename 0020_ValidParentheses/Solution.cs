using System;

namespace LeetCodeChallenges._0020_ValidParentheses;

public class Solution
{
    public bool IsValid(string s) {
        // inicializa a pilha
        Stack<char> stack = new();
        // par chave e valor parenteses
        Dictionary<char,char> parentheses = new(){{'(', ')'}, {'[',']'},{'{','}'}};

        // iterar sobre a string recebida
        for(int i = 0; i< s.Length; i++){
            // se o caractere da vez conter nas keys do dicionario -> manda pra pilha
            if(parentheses.Keys.Contains(s[i])){
                stack.Push(s[i]);
            }
            // caso não verifica se é fechamento de parenteses, pegando em stack.Peek o ultimo adicionado na pilha e usando como chave para verificar o fechamento
            else if(stack.Count > 0 && s[i] == parentheses[stack.Peek()]){
                // se for par válido limpa a pilha
                stack.Pop();
            }
            else {
                return false;
            }   
        }
        // se a pilha tiver vazia é true
        return stack.Count == 0;
    }

}
