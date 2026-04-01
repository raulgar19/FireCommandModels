using FireCommandModels.Models;
using FireCommandModels.Models.ViewModels;

namespace FireCommandApi.Services.Interfaces
{
    public interface ICommunicationService
    {
        Task<CommunicationViewModel> GetCommunicationsInfoAsync();
        Task AddMessageAsync(Message message);
    }
}
