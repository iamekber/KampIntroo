using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampaignManager : ICampaignService
    {
        public void Add(Gamer gamer)
        {
            Console.WriteLine("Kampanya Eklenmiştir");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kampanya Silinmiştir");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kampanya Güncellenmiştir");
        }
    }
}
