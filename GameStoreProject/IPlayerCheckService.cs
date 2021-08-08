using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStoreProject
{
    interface IPlayerCheckService
    {
        bool CheckRealPerson(Player player);
    }
}
