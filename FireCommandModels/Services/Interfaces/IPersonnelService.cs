using FireCommandModels.Models;
using FireCommandModels.Models.ViewModels;

namespace FireCommandApi.Services.Interfaces
{
    public interface IPersonnelService
    {
        Task<PersonnelViewModel> GetPersonnelInfoAsync();
        Task AddPersonnelAsync(Personnel personnel);
        Task UpdatePersonnelAsync(Personnel personnel);
        Task DeletePersonnelAsync(int id);
    }
}
