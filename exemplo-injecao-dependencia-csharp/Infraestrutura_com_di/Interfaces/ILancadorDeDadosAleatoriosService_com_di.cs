namespace exemplo_injecao_dependencia_csharp.Infraestrutura_com_di.Interfaces
{
    public interface ILancadorDeDadosAleatoriosService_com_di
    {
        List<int> LancaDadosAleatoriosNVezes(int quantidade);
        Dictionary<int, int> ResultadoDosDados(List<int> list);
    }
}
