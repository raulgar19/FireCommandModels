using FireCommandModels.Models;

namespace FireCommandModels.Models.ViewModels
{
    public class AnalysisViewModel
    {
        public List<Incident> Incidents { get; set; }
        public List<IncidentType> IncidentTypes { get; set; }
    }
}