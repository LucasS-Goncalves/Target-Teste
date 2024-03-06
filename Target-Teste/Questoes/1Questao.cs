namespace Target_Teste.Questoes
{
    public class PrimeiraQuestao
    {
        public void PrintSoma(int index, int soma, int k)
        {
            while(k < index)
            {
                k++;
                soma += k;
            }

            Console.WriteLine(soma);
        }
    }
}
