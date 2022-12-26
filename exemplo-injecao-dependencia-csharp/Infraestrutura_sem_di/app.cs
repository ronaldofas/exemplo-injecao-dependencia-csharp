namespace exemplo_injecao_dependencia_csharp.Infraestrutura_sem_di
{
    public class app
    {
        public void Start()
        {
            var tela = new GeradorDeTelaService();

            string descisao = "0";


            while (descisao != "99")
            {

                /*
                 * Um dado é lançado 1000 vezes e o valor correspondente (valores válidos: 1 a 6) é anotado. Faça um
                 * programa que gere um vetor com os lançamentos (usando um gerador de números aleatórios como
                 * mostrado abaixo), e calcule e mostre quantas vezes cada um dos 6 números foi sorteado.
                 * - Fazer um service para cálculos (gerar array com resultados - ok, fazer contagem de resultados - ok)
                 * - Fazer um service para apresentação da tela (tela inicial - ok, tela de resultado, tela de despedida)
                 * 
                 */
                Console.Clear();
                Console.WriteLine(tela.TelaPrincipal());
                var inputDescisao = Console.ReadLine();
                if (inputDescisao != null)
                {
                    descisao = inputDescisao;
                } else {
                    descisao = "0";
                }

                switch (descisao)
                {
                    case "1":
                        // Efetua lançamento dos dados
                        Console.WriteLine("A implementar");
                        PedirComandoEAguardar();
                        break;
                    case "2":
                        Console.WriteLine("Função ainda não implementada, escolha outra opção");
                        PedirComandoEAguardar();
                        break;
                    case "99":
                        break;
                    default:
                        break;
                }
            }
        }

        private static void PedirComandoEAguardar()
        {
            Console.WriteLine("Digite enter para continuar...");
            Console.ReadLine();
        }
    }
}
