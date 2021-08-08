using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStoreProject
{
    class CampaignManager : ICampaignService
    {
        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " alı kampanya sistemden kaldırılmıstır.");
        }

        public void Save(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " adlı kampanya %" + campaign.DiscountRate + " indirim oranıyla sisteme eklenmistir.");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " adlı kampanyanın indirim oranı güncellenmistir.");
        }
    }
}
