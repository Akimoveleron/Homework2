
using HomeWork2.Domain;
using HomeWork2.Abstractions;
using HomeWork2.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using ConsoleTables;

namespace HomeWork2.Controllers
{
    internal class DbManagement
    {
       
        public  static void GetAllData()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
        
                Console.WriteLine("CLIENTS");
                ConsoleTable.From<Client>(db.Clients).Write();
              
                Console.WriteLine("DEPOSITS");
                ConsoleTable.From<Deposit>(db.Deposits).Write();
                
                Console.WriteLine("MANAGERS");
                ConsoleTable.From<Manager>(db.Managers).Write();
                
                Console.WriteLine("ACCOUNTS");
                ConsoleTable.From<Account>(db.Accounts).Write();
               
            }
            
        }
        public static void AddElementToDb<TEntity>( params TEntity [] entities)  where TEntity :BaseEntity 
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                foreach (var entity in entities)
                {
                    db.Set<TEntity>().Add(entity);

                }
                    
                 db.SaveChanges();
            }
        }
        public static void AddFiveElemtnts() 
        {
             Manager [] managers= new Manager[] { new Manager{FirstName= "Ivan", LastName = "Ivanov", Patronymic="Ivanovich", Email = "ivan@mail.ru",ManagerPosition =  Position.SalesManager, PhoneNumber =  "5623" },
                                                        new Manager{ FirstName = "Aleksand", LastName = "Apolonov", Patronymic = "Vladimirovich", Email = "Aktrc@mail.ru", ManagerPosition = Position.SalesManager, PhoneNumber = "5725" },
                                                        new Manager{ FirstName = "Vitalii", LastName = "Semenov", Patronymic = "Vadimovich", Email = "vital@mail.ru", ManagerPosition = Position.SalesManager, PhoneNumber = "1775" },
                                                        new Manager{FirstName="Sergei", LastName="Samarin", Patronymic="Anatolevich", Email="Serg@mail.ru", ManagerPosition= Position.Chief, PhoneNumber="7777" },
                                                        new Manager{ FirstName = "Vladimir", LastName = "Matveev", Patronymic = "Vladimirovich", Email = "vladimir@mail.ru", ManagerPosition = Position.BranchManager, PhoneNumber = "7247" }};


            Client[] clients = new Client[] { new Client{FirstName="Peter", LastName="Petrov", Patronymic="Petrovich", Email="petrov@mail.ru", PassportNumber="4001255511",PhoneNumber= "89501234578" },
                                                     new Client{FirstName = "Aleksandr", LastName = "Pushkin", Patronymic = "Sergeevich", Email = "pushkin@mail.ru", PassportNumber= "4001255511", PhoneNumber="89501234578" },
                                                     new Client{FirstName="Dmitrii", LastName="Agafonov", Patronymic ="Alekseevich", Email="aga@mail.ru",PassportNumber= "4105255561", PhoneNumber="89521238598" },
                                                     new Client{FirstName="Pavel", LastName = "Smirnov", Patronymic="Sergeevich", Email="petrov@mail.ru",PassportNumber= "4001255511", PhoneNumber="89501234578" },
                                                     new Client{FirstName="Mikhail",LastName= "Popov",Patronymic= "Dmitrievich", Email="popv@mail.ru",PassportNumber= "4501285511", PhoneNumber="89501235589" } };

          


            Account[] accounts = new Account[] { new Account{Amount= 200,Client= clients[0] }, new Account{Amount= 700,Client= clients[1] }, new Account{Amount= 500,Client= clients[2] },
                                                new Account{Amount= 400, Client= clients[3] }, new Account{Amount= 300,Client= clients[4] } };

          

            Deposit[] deposits = new Deposit[] { new Deposit { OpenningDate = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc), Client=clients[0], Manager=managers[0] },
                                 new Deposit { OpenningDate = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc), Client=clients[1], Manager=managers[1] }, 
                                new Deposit { OpenningDate = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc),  Client=clients[2], Manager=managers[2] },
                                  new Deposit { OpenningDate = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc), Client=clients[3], Manager=managers[3] },
                                new Deposit { OpenningDate = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc), Client=clients[4], Manager=managers[4] }};


            using (ApplicationContext db = new ApplicationContext())
            {
            

                db.Set<Client>().AddRange(clients);
                db.Set<Manager>().AddRange(managers);
                db.Set<Deposit>().AddRange(deposits);
                db.Set<Account>().AddRange(accounts);
                db.SaveChanges();

            }
        }
    }
}
