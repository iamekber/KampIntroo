using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());
            gamerManager.Add(new Gamer { Id = 1, BirthYear = 1985, FirstName = "Engin", LastName = "Demiroğ", IdentityNumber=12345 });
            Console.WriteLine("Hello World!");
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(new Gamer { Id=2, BirthYear=1998, FirstName="Ali", LastName="Afşar", IdentityNumber=23456 });
        }
    }
}
