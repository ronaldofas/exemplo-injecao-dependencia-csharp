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
                descisao = SolicitarEValidarDescisao();

                switch (descisao)
                {
                    case "1":
                        LancarDados();
                        break;
                    case "2":
                        GeradorMegaSena();
                        break;
                    case "99":
                        MostrarDespedida();
                        break;
                    default:
                        break;
                }
            }
        }

        private static string SolicitarEValidarDescisao()
        {
            string descisao;
            var inputDescisao = Console.ReadLine();
            if (inputDescisao != null)
            {
                descisao = inputDescisao;
            }
            else
            {
                descisao = "0";
            }

            return descisao;
        }

        private void MostrarDespedida()
        {
            Console.Clear();
            Console.WriteLine(Tela.TelaDeDespedida());
            PedirComandoEAguardar();
        }

        private static void GeradorMegaSena()
        {
            Console.WriteLine("Função ainda não implementada, escolha outra opção");
            PedirComandoEAguardar();
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
