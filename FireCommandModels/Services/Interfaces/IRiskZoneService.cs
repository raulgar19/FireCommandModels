using FireCommandModels.Models;
using FireCommandModels.Models.ViewModels;

namespace FireCommandApi.Services.Interfaces
{
    public interface IRiskZoneService
    {
        Task<RiskZoneViewModel> GetRiskZonesInfoAsync();
        Task AddRiskZoneAsync(RiskZone riskZone);
        Task DeleteRiskZoneAsync(int id);
    }
}
