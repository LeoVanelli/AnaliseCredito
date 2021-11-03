using System;

namespace AnaliseCredito
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------- Analise de Crédito ----------");

            Console.Write("Digite o valor do empréstimo desejado(R$): ");
            double.TryParse(Console
            .ReadLine()
            .ToString(), out double _emprestimo);
            Console.Write("Digite a quantidade de parcelas..........: ");
            double.TryParse(Console
            .ReadLine()
            .ToString(), out double _parcelas);
            Console.Write("Digite sua renda mensal(R$)..............: ");
            double.TryParse(Console
            .ReadLine()
            .ToString(), out double _rendaMensal);

            Console.Write("\nCalculando crédito");
            System.Threading.Thread.Sleep(1000);
            for (int i = 0; i < 3; i++)
            {
                Console.Write(". ");
                System.Threading.Thread.Sleep(1000);
            }

            string _resultado = (_emprestimo/_parcelas) < ((_rendaMensal*30)/100) ? $"Crédito Aprovado.\nValor da parcela: {_parcelas}x de {_emprestimo/_parcelas}" : "Credito Reprovado, o valor da parcela solicitada ultrapassou 30% da sua renda.";

            Console.Write($"\n\nResultado: {_resultado}");
        }
    }
}
