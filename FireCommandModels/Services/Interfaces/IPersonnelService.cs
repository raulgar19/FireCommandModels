using FireCommandModels.Models;

namespace FireCommandModels.Services.Interfaces
{
    public interface IPersonnelService
    {
        Task<List<Personnel>> GetPersonnelAsync();

        Task AddPersonnelAsync(Personnel personnel);
        Task UpdatePersonnelAsync(Personnel personnel);
        Task DeletePersonnelAsync(int id);
    }
}
