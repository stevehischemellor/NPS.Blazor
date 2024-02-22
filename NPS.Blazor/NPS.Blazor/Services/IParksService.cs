namespace NPS.Blazor.Services
{
    public interface IParksService
    {
        Task GetAllParksAsync();
        Task GetParkAsync(int id);
    }
}
