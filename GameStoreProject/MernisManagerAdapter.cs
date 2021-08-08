using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStoreProject
{
    class MernisManagerAdapter:IPlayerCheckService
    {
        public bool CheckRealPerson(Player player)
        {
            if (player.Id == 1 && player.FirstName == "Mervenur" && player.LastName == "Karakayaa" && player.NationalityId == 12345 && player.DateOfBirth == 2000)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
