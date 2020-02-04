using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp5
{
    public interface IPlayerRepository
    {
        Players RegisterPlayers(int Id, string Name, string Team, int Phone, string Address);
        Players UpdatePlayers(Players players);
        Players DeletePlayers(Players players);
        Players GetPlayersById(int Id);
        IEnumerable<Players> getAllPlayers { get; }
    }
}