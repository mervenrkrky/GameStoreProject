using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStoreProject
{
    class GameManager : IGameService
    {
        public void Delete(Game game, Player player)
        {
            Console.WriteLine(player.FirstName + " adlı oyuncu " + game.GameName + " adlı oyunu oyun listesinden sildi.");
        }

        public void Save(Game game, Player player)
        {
            Console.WriteLine(player.FirstName + "adlı oyuncu " + game.GameName + " adlı oyunu " + game.GamePrice + " Tl ye satın aldı");
        }

        public void Update(Game game, Player player)
        {
            Console.WriteLine(player.FirstName + " adlı oyuncu " + game.GameName + " adlı oyundaki üyeligini güncelledi");
        }
    }
}
