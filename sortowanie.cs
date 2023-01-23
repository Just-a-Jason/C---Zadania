class Sortowanie {
    public void Sortowanie_Wstawianie(ref List<int> lista) {
        for (int i = 0; i < lista.Count; i++) {
            int tmp = lista[i];
            int j = i - 1;

            while (j>=0 && lista[j] > tmp) {
                lista[j + 1] = lista[j];
                j--;
            }

            lista[j+1] = tmp;
        }
    } 
}