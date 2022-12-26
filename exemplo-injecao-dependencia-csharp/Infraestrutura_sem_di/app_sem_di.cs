namespace exemplo_injecao_dependencia_csharp.Infraestrutura_sem_di
{
    public class app_sem_di
    {
        GeradorDeTelaService_sem_di _tela = new GeradorDeTelaService_sem_di();
        LancadorDeDadosAleatoriosService_sem_di _lancador = new LancadorDeDadosAleatoriosService_sem_di();

        public void Start()
        {
            string descisao = "0";
            while (descisao != "99")
            {
                Console.Clear();
                Console.WriteLine(_tela.TelaPrincipal());
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
            Console.WriteLine(_tela.TelaDeDespedida());
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
            var lancamentos = _lancador.LancaDadosAleatoriosNVezes(1000);
            var resultados = _lancador.ResultadoDosDados(lancamentos);
            Console.Clear();
            Console.WriteLine(_tela.TelaDeResultadoDosLancamentos(lancamentos.Count, resultados));
            PedirComandoEAguardar();
        }

        private static void PedirComandoEAguardar()
        {
            Console.Write("Digite enter para continuar...");
            Console.ReadLine();
        }
    }
}
