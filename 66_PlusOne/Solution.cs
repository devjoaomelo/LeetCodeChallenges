public class Solution{
    public int[] PlusOne(int[] digits) {
        // percorrer de trás pra frente
        for(int i = digits.Length-1; i >= 0; i--){
            // se o digito for 9 vira 0 para simular incrementar
            if(digits[i] == 9){
                digits[i] = 0;
                // se chegar no primeiro elemento
                if(i == 0){
                    // cria uma lista para dar insert na posição 0
                    List<int> list = new List<int>(digits);
                    list.Insert(0, 1);
                    // transforma em array e retorna
                    int[] newArray = list.ToArray();
                    return newArray;
                }
            }
            // caso não apenas incrementa na posição e retorna
            else {
                digits[i]++;
                return digits;
            }
        }
        return digits;
    }
}