﻿namespace exemplo_injecao_dependencia_csharp.Infraestrutura_sem_di
{
    public class app_sem_di
    {
        public void Start()
        {
            var tela = new GeradorDeTelaService_sem_di();
            

            string descisao = "0";

            while (descisao != "99")
            {
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
                        LancarDados(tela);
                        break;
                    case "2":
                        Console.WriteLine("Função ainda não implementada, escolha outra opção");
                        PedirComandoEAguardar();
                        break;
                    case "99":
                        Console.Clear();
                        Console.WriteLine(tela.TelaDeDespedida());
                        PedirComandoEAguardar();
                        break;
                    default:
                        break;
                }
            }
        }

        private static void LancarDados(GeradorDeTelaService_sem_di tela)
        {
            var lancador = new LancadorDeDadosAleatoriosService_sem_di();
            // Efetua lançamento dos dados
            var lancamentos = lancador.LancaDadosAleatoriosNVezes(1000);
            var resultados = lancador.ResultadoDosDados(lancamentos);
            Console.Clear();
            Console.WriteLine(tela.TelaDeResultadoDosLancamentos(lancamentos.Count, resultados));
            PedirComandoEAguardar();
        }

        private static void PedirComandoEAguardar()
        {
            Console.Write("Digite enter para continuar...");
            Console.ReadLine();
        }
    }
}
