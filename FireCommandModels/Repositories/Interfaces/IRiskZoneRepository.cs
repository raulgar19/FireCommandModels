using FireCommandModels.Models;

namespace FireCommandModels.Repositories.Interfaces
{
    public interface IRiskZoneRepository
    {
        Task<List<RiskZone>> GetRiskZonesAsync();
        Task<List<RiskType>> GetRiskTypesAsync();
        Task<List<Station>> GetStationsAsync();
        Task<RiskZone> FindRiskZoneAsync(int id);
        Task AddRiskZoneAsync(RiskZone riskZone);
        Task DeleteRiskZoneAsync(int id);
    }
}