using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStoreProject
{
    interface IGameService
    {
        void Save(Game game, Player player);
        void Update(Game game, Player player);
        void Delete(Game game, Player player);
    }
}
