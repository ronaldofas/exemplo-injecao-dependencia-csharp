using exemplo_injecao_dependencia_csharp.Infraestrutura_com_di;
using exemplo_injecao_dependencia_csharp.Infraestrutura_sem_di;

namespace exemplo_injecao_dependencia
{
    public class exemplo_injecao_dependencia
    {
        public static void Main(String[] args)
        {
            // Método sem injeção de dependencia
            //var app = new app_sem_di();
            //app.Start();

            //Método com injeção de dependência
            var lancador = new LancadorDeDadosAleatoriosServiceComDi();
            var tela = new GeradorDeTelaService_com_di();
            var app = new app_com_di(lancador, tela);
            app.Start();
        }
    }
}

