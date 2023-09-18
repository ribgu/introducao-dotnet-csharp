using WebAPI.API.Entities;

namespace WebAPI.API.Persistence
{
    public class GamesDbContext
    {
        public List<Game> Games { get; set; }
        public GamesDbContext() 
        {
            Games = new List<Game>();
        }
    }
}
