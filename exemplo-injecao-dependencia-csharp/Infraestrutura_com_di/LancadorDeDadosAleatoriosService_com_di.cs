using exemplo_injecao_dependencia_csharp.Infraestrutura_com_di.Interfaces;

namespace exemplo_injecao_dependencia_csharp.Infraestrutura_com_di
{
    public class LancadorDeDadosAleatoriosServiceComDi : ILancadorDeDadosAleatoriosService_com_di
    {
        public List<int> LancaDadosAleatoriosNVezes(int quantidade)
        {
            List<int> resultado = new List<int>();
            Random random = new Random();

            while (resultado.Count < quantidade)
            {
                int valorObtido = random.Next(1, 7);
                resultado.Add(valorObtido);
            }

            return resultado;
        }

        public Dictionary<int, int> ResultadoDosDados(List<int> list)
        {
            var result = list.GroupBy(x => x)
                .Where(g => g.Count() > 1)
                .ToDictionary(x => x.Key, x => x.Count());

            return result;
        }
    }
}
