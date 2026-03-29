using FireCommandModels.Models;
using FireCommandModels.Models.ViewModels;

namespace FireCommandModels.Services.Interfaces
{
    public interface IEquipmentService
    {
        Task<EquipmentViewModel> GetEquipmentAsync();
        Task AddEquipmentAsync(Equipment equipment);
        Task UpdateEquipmentAsync(Equipment equipment);
        Task DeleteEquipmentAsync(int id);
    }
}