using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStoreProject
{
    interface ICampaignService
    {
        void Save(Campaign campaign);
        void Update(Campaign campaign);
        void Delete(Campaign campaign);
    }
}
