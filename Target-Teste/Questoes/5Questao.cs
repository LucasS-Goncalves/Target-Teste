namespace Target_Teste.Questoes
{
    public class QuintaQuestao
    {
        public string InverterString()
        {
            Console.WriteLine("Digite a string:");
            //Por questão de agilidade não irei validar o input, então estarei considerando que o input é válido;
            string input = Console.ReadLine();

            string newString = "";

            for(int i = input.Length - 1; i > -1 ; i--)
            {
                newString += input[i];
            }

            return newString;
        }
    }
}
