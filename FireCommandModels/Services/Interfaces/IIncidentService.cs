using FireCommandModels.Models;
using FireCommandModels.Models.ViewModels;

namespace FireCommandModels.Services.Interfaces
{
    public interface IIncidentService
    {
        Task<IncidentViewModel> GetIncidentsInfoAsync();
        Task<AnalysisViewModel> GetAnalysisAsync();
        Task AddIncidentAsync(Incident incident);
        Task UpdateIncidentAsync(Incident incident);
        Task DeleteIncidentAsync(int id);
    }
}