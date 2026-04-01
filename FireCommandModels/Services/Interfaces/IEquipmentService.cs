using FireCommandModels.Models;
using FireCommandModels.Models.ViewModels;

namespace FireCommandApi.Services.Interfaces
{
    public interface IEquipmentService
    {
        Task<EquipmentViewModel> GetEquipmentInfoAsync();
        Task AddEquipmentAsync(Equipment equipment);
        Task UpdateEquipmentAsync(Equipment equipment);
        Task DeleteEquipmentAsync(int id);
    }
}