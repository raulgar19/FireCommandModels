using FireCommandModels.Models;
using FireCommandModels.Models.ViewModels;

namespace FireCommandModels.Services.Interfaces
{
    public interface ICommunicationService
    {
        Task<CommunicationViewModel> GetCommunicationsAsync();
        Task AddMessageAsync(Message message);
    }
}
