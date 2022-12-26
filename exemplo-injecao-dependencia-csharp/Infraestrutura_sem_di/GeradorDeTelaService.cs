namespace exemplo_injecao_dependencia_csharp.Infraestrutura_sem_di
{
    public class GeradorDeTelaService
    {
        public string TelaPrincipal()
        {
            string tela = "";
            tela += linhaAsteriscos();
            tela += AdicionaSaltosDeLinha(3);
            tela += GerarOpcoesDeMenu();
            tela += AdicionaSaltosDeLinha(3);
            tela += linhaAsteriscos();
            tela += AdicionarLinhaDeDescisao();

            return tela;
        }

        private static string GerarOpcoesDeMenu()
        {
            string opcoesDeMenu = "     1 - Lançar dados\n" +
                            "     2 - Criar jogo da Mega Sena (em construção)\n" +
                            "     99 - Sair\n";

            return opcoesDeMenu;
        }

        private static string AdicionarLinhaDeDescisao() => "Digite a opção desejada: ";

        private static string AdicionaSaltosDeLinha(int quantidadeAAdcionar)
        {
            int quantidadeAdicionada = 0;
            string saltosDeLinha = "";

            while (quantidadeAdicionada < quantidadeAAdcionar)
            {
                saltosDeLinha += "\n";
                quantidadeAdicionada++;
            }

            return saltosDeLinha;
        }

        private static string linhaAsteriscos()
        {
            string linhaDeAsteriscos = "";

            while (linhaDeAsteriscos.Length < 59)
            {
                linhaDeAsteriscos += '*';
            }

            return linhaDeAsteriscos + "\n";
        }
    }
}
