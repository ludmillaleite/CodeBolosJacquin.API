using CodeBolosJacquin.API.ViewModels;

namespace CodeBolosJacquin.API.Interfaces
{
    public interface IBoloRepository
    {
        Task<IEnumerable<BoloResponseViewModel>> ListarTodosAsync();
        Task<BoloResponseViewModel?> BuscarPorIdAsync(int id); //? = quando pode ser nulo //Response = Resposta
        Task<BoloResponseViewModel> CadastrarAsync(BoloRequestViewModel bolo); //Request = requisição
        Task<bool> AtualizarAsync(int id, BoloRequestViewModel bolo);
        Task<bool> RemoverAsync(int id);
    }
}
