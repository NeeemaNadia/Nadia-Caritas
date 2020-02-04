using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace ConsoleApp5
{
    public class PlayerRepository : IPlayerRepository
    {
        private readonly PlayerContext _playerContext;

        public PlayerRepository(PlayerContext playerContext)
        {
            _playerContext = playerContext;
        }

        public Players RegisterPlayers(int id, string name, string team, int phone, string address)
        {
            var result = _playerContext.Add(new Players
            {
                Id = id,
                Name = name,
                Team = team,
                Phone = phone,
                Address = address
            });
            _playerContext.SaveChanges();
            return result.Entity;
        }

        public Players UpdatePlayers(Players players)
        {
            return _playerContext.Update(players).Entity;
        }

        public Players DeletePlayers(Players players)
        {
            return _playerContext.Remove(players).Entity;
        }

        public Players GetPlayersById(int id)
        {
            return _playerContext.Players.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Players> getAllPlayers
        {
            get { return _playerContext.Players; }
        }
    }
}