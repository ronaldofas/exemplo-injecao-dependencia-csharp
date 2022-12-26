using exemplo_injecao_dependencia_csharp.Infraestrutura_sem_di;

namespace exemplo_injecao_dependencia
{
    public class exemplo_injecao_dependencia
    {
        public static void Main(String[] args)
        {
            // Método sem injeção de dependencia
            var app = new app();
            app.Start();
        }
    }
}

