using FireCommandModels.Models.ViewModels;

namespace FireCommandModels.Services.Interfaces
{
    public interface IDashboardService
    {
        Task<DashboardViewModel> GetDashboardInfoAsync();
    }
}
