using myfinance_web_dotnet_domain.Entities;;

namespace myfinance_web_dotnet_service.interfaces
{
    public interface IPlanoContaService
    {
        void Cadastrar(PlanoConta Entidade);
        void Excluir(int id);
        List<PlanoConta> ListarRegistros();
        PlanoConta RetornarRegistro(int id);
    }
}