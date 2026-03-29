using FireCommandModels.Models;

namespace FireCommandModels.Services.Interfaces
{
    public interface IRiskZoneService
    {
        Task<List<RiskZone>> GetRiskZonesAsync();

        Task AddRiskZoneAsync(RiskZone riskZone);
        Task DeleteRiskZoneAsync(int id);
    }
}
