namespace Target_Teste.Questoes
{
    public class SegundaQuestao
    {
        public void AcharNumeroNaSequencia()
        {
            Console.WriteLine("Digite um número:");
            //Por questão de agilidade não irei validar o input, então estarei considerando que o input é válido;
            int number = int.Parse(Console.ReadLine());
            bool inputEstaPresenteNaSequencia = CalcularSequenciaFibonacciAteAcharNumero(number);
            if(inputEstaPresenteNaSequencia) Console.WriteLine("Número informado está presente na sequência!");
            else Console.WriteLine("Número informado não está presente na sequência!");
        }

        public bool CalcularSequenciaFibonacciAteAcharNumero(int number)
        {
            var fibonacciList = new List<int> { 0, 1, 1 };
            int fibonacciListLastNumber = fibonacciList.Last();

            while (number > fibonacciListLastNumber)
            {
                fibonacciList.Add(fibonacciList[fibonacciList.Count() - 1] + fibonacciList[fibonacciList.Count() - 2]);
                fibonacciListLastNumber = fibonacciList.Last();
                if (fibonacciList.Contains(number)) return true;
            }
            return false;
        }
    }
}
