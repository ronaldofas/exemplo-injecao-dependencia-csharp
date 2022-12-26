using exemplo_injecao_dependencia_csharp.Infraestrutura_com_di.Interfaces;

namespace exemplo_injecao_dependencia_csharp.Infraestrutura_com_di
{
    public class app_com_di
    {
        private readonly ILancadorDeDadosAleatoriosService_com_di Lancador;
        private readonly IGeradorDeTelaService_com_di Tela;

        public app_com_di(ILancadorDeDadosAleatoriosService_com_di lancador, IGeradorDeTelaService_com_di tela)
        {
            Lancador = lancador;
            Tela = tela;
        }

        public void Start()
        {
            string descisao = "0";

            while (descisao != "99")
            {
                Console.Clear();
                Console.WriteLine(Tela.TelaPrincipal());
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
                        LancarDados();
                        break;
                    case "2":
                        Console.WriteLine("Função ainda não implementada, escolha outra opção");
                        PedirComandoEAguardar();
                        break;
                    case "99":
                        Console.Clear();
                        Console.WriteLine(Tela.TelaDeDespedida());
                        PedirComandoEAguardar();
                        break;
                    default:
                        break;
                }
            }
        }

        private void LancarDados()
        {
            // Efetua lançamento dos dados
            List<int> lancamentos = Lancador.LancaDadosAleatoriosNVezes(1000);
            Dictionary<int, int> resultados = Lancador.ResultadoDosDados(lancamentos);
            Console.Clear();
            Console.WriteLine(Tela.TelaDeResultadoDosLancamentos(lancamentos.Count, resultados));
            PedirComandoEAguardar();
        }

        private static void PedirComandoEAguardar()
        {
            Console.Write("Digite enter para continuar...");
            Console.ReadLine();
        }
    }
}
