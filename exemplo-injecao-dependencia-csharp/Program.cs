using exemplo_injecao_dependencia_csharp.Infraestrutura_com_di;
using exemplo_injecao_dependencia_csharp.Infraestrutura_com_di.Interfaces;
using SimpleInjector;

namespace exemplo_injecao_dependencia
{
    public class exemplo_injecao_dependencia
    {
        static readonly Container container;
        static exemplo_injecao_dependencia()
        {
            // 1. Create a new Simple Injector container
            container = new Container();

            // 2. Configure the container (register)
            container.Register<ILancadorDeDadosAleatoriosService_com_di, LancadorDeDadosAleatoriosServiceComDi>(Lifestyle.Singleton);
            container.Register<IGeradorDeTelaService_com_di, GeradorDeTelaService_com_di>(Lifestyle.Singleton);
            container.Register<app_com_di>();

            // 3. Verify your configuration
            container.Verify();
        }

        public static void Main(String[] args)
        {
            // Método sem injeção de dependencia
            //var app = new app_sem_di();
            //app.Start();

            //Método com injeção de dependência
            //var lancador = new LancadorDeDadosAleatoriosServiceComDi();
            //var tela = new GeradorDeTelaService_com_di();
            //var app = new app_com_di(lancador, tela);
            //app.Start();

            //Método com injeção de dependência e uso do simpleinjector
            var app = container.GetInstance<app_com_di>();
            app.Start();
        }
    }
}

