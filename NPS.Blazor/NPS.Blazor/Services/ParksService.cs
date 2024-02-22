namespace NPS.Blazor.Services
{
    public class ParksService : IParksService
    {
        private readonly ILogger<IParksService> _logger;
        public ParksService(ILogger<IParksService> logger) 
        {
            _logger = logger;
        }

        public Task GetAllParksAsync()
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception e)
            {
                _logger.LogError(e, e.Message);
                throw;
            }

        }

        public Task GetParkAsync(int id)
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception e)
            {
                _logger.LogError(e, e.Message);
                throw;
            }

        }
    }
}
