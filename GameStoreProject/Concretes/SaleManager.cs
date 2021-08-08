using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStoreProject
{
    class SaleManager : ISaleService
    {
        public void order(Campaign campaign, Game game, Player player)
        {
            double afterPrice = game.GamePrice - (game.GamePrice * campaign.DiscountRate / 100);

            Console.WriteLine(player.FirstName + " adlı oyuncu " + game.GameName + " adlı oyunu " + game.GamePrice + " Tl yerine %" + campaign.DiscountRate + " indirimle " + afterPrice + "Tl ye aldi");
        }
    }
}
