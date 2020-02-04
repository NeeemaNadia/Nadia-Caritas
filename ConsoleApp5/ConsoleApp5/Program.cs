using System;
using System.Linq;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new PlayerContext();
            context.Database.EnsureCreated();
            var repository = new PlayerRepository(context);
            Console.WriteLine("enter player Id:");
            var Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter player name:");
            var Name = Console.ReadLine();
            Console.WriteLine("enter player team");
            var Team = Console.ReadLine();
            Console.WriteLine("enter phone number");
            var Phone = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("address");
            var Address = Console.ReadLine();
            //create
            Console.WriteLine(repository.RegisterPlayers(Id, Name, Team, Phone, Address));
            // get all Player
            var Players = repository.getAllPlayers.ToList();
            Console.WriteLine("ID      | Name     |Team     |Phone        |Address ");
            foreach (var p in Players)
            {
                Console.WriteLine(p.Id + " | " + p.Name + " | " + p.Team + " | " + p.Phone + " | " + p.Address);
                //update
                Console.WriteLine($"enter id to update");
                var IdToUpdate = Convert.ToInt32(Console.ReadLine());
                var playersUpdate = repository.GetPlayersById(IdToUpdate);
                if (IdToUpdate != null)
                {
                    playersUpdate.Name = "Devo";
                    playersUpdate.Address = "kigali";
                }

                //delete
                Console.WriteLine($"enter Id to delete");
                var IdToDelete = Convert.ToInt32(Console.ReadLine());
                var PlayersDelete = repository.GetPlayersById(IdToDelete);
                {

                }
            }
        }
    }
}
