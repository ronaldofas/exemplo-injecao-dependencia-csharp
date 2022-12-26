using exemplo_injecao_dependencia_csharp.Infraestrutura_com_di.Interfaces;

namespace exemplo_injecao_dependencia_csharp.Infraestrutura_com_di
{
    public class GeradorDeTelaService_com_di : IGeradorDeTelaService_com_di
    {
        private string _delimitador = "=";

        public string TelaPrincipal()
        {
            string tela = "";
            tela += linhaDelimitadora();
            tela += AdicionaSaltosDeLinha(3);
            tela += GerarOpcoesDeMenu();
            tela += AdicionaSaltosDeLinha(3);
            tela += linhaDelimitadora();
            tela += AdicionarLinhaDeDescisao();

            return tela;
        }

        public string TelaDeResultadoDosLancamentos(int quantidadeLancamentos, Dictionary<int, int> resultados)
        {
            string tela = "";
            tela += linhaDelimitadora();
            tela += AdicionaSaltosDeLinha(3);
            tela += $"    Quantidade de lançamentos efetuados: {quantidadeLancamentos}\n";
            tela += AdicionaSaltosDeLinha(1);
            for (int i = 1; i <= 6; i++)
                if (resultados.ContainsKey(i)) tela += GeraLinhaDeResultado(i, resultados[i]);
            tela += AdicionaSaltosDeLinha(3);
            tela += linhaDelimitadora();

            return tela;
        }

        public string TelaDeDespedida()
        {
            string tela = "";

            tela += linhaDelimitadora();
            tela += AdicionaSaltosDeLinha(5);
            tela += "     Obrigado por usar o sistema!";
            tela += AdicionaSaltosDeLinha(5);
            tela += linhaDelimitadora();

            return tela;
        }

        private string GeraLinhaDeResultado(int numeroDoDado, int quantidade)
        {
            return $"     Número {numeroDoDado} foi lançado {quantidade} vez(es).\n";
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

        private string linhaDelimitadora()
        {
            string linhaDeAsteriscos = "";

            while (linhaDeAsteriscos.Length < 59)
            {
                linhaDeAsteriscos += _delimitador;
            }

            return linhaDeAsteriscos + "\n";
        }
    }
}
