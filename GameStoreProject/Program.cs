using System;

namespace GameStoreProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player()
            {
                Id = 1,
                FirstName = "Mervenur",
                LastName = "Karakaya",
                DateOfBirth = 2000,
                NationalityId = 12345
            };
            PlayerManager playerManager = new PlayerManager(new MernisManagerAdapter());
            playerManager.Save(player);


            Game game = new Game()
            {
                Id = 1,
                GameName = "PUBG",
                GamePrice = 12
            };

            GameManager GameManager = new GameManager();

            Campaign Campaign = new Campaign()
            {
                Id = 1,
                CampaignName = "Yaz kampanyası",
                DiscountRate = 20
            };
            CampaignManager campaignManager = new CampaignManager();

            SaleManager saleManager = new SaleManager();
            saleManager.order(Campaign, game, player);

        }
    }
}
