namespace exemplo_injecao_dependencia_csharp.Infraestrutura_com_di.Interfaces
{
    public interface IGeradorDeTelaService_com_di
    {
        public string TelaPrincipal();
        public string TelaDeResultadoDosLancamentos(int quantidadeLancamentos, Dictionary<int, int> resultados);
        public string TelaDeDespedida();
    }
}
