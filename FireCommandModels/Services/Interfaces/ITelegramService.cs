namespace FireCommandModels.Services.Interfaces
{
    public interface ITelegramService
    {
        Task SendTelegramMessageAsync(string message);
    }
}
