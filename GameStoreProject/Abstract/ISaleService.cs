using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStoreProject
{
    interface ISaleService
    {

        void order(Campaign campaign, Game game, Player player);
    }
}
