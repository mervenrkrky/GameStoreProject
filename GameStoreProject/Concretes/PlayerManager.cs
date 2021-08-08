using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStoreProject
{
    class PlayerManager : IPlayerService
    {
        IPlayerCheckService _playerCheckService;

        public PlayerManager()
        {
        }

        public PlayerManager(IPlayerCheckService playerCheckService)
        {
            _playerCheckService = playerCheckService;
        }

        public void Delete(Player player)
        {
            Console.WriteLine(player.FirstName + " adlı oyuncu sistemden silindi.");
        }

         public void Save(Player player)
          {
              if(_playerCheckService.CheckRealPerson(player))
              {
                  Console.WriteLine(player.FirstName + " adlı  oyuncu sisteme kaydoldu.");
              }
              else
              {
                  Console.WriteLine("Girilen kullanıcı bilgileri yanlıstır kontrol edip tekrar deneyiniz.");
              }
          }
        
        public void Update(Player player)
        {
            Console.WriteLine(player.FirstName + " adlı  oyuncu bilgileri güncellendi.");
        }
    }
}
