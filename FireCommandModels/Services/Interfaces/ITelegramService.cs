namespace FireCommandApi.Services.Interfaces
{
    public interface ITelegramService
    {
        Task SendTelegramMessageAsync(string message);
    }
}
