
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
             Manager [] managers= new Manager[] { new Manager("Ivan", "Ivanov", "Ivanovich", "ivan@mail.ru", Position.SalesManager, "5623"),
                                                        new Manager("Aleksand", "Apolonov", "Vladimirovich", "Aktrc@mail.ru", Position.SalesManager, "5725"),
                                                        new Manager("Vitalii", "Semenov", "Vadimovich", "vital@mail.ru", Position.SalesManager, "1775"),
                                                        new Manager("Sergei", "Samarin", "Anatolevich", "Serg@mail.ru", Position.Chief, "7777"),
                                                        new Manager("Vladimir", "Matveev", "Vladimirovich", "vladimir@mail.ru", Position.BranchManager, "7247")};

            Account[] accounts = new Account[] { new Account(200), new Account(700), new Account(500), new Account(400), new Account(300) };

            Client[] clients = new Client[] { new Client("Peter", "Petrov", "Petrovich", "petrov@mail.ru", "4001255511", "89501234578", accounts[0].Id),
                                                     new Client("Aleksandr", "Pushkin", "Sergeevich", "pushkin@mail.ru", "4001255511", "89501234578", accounts[1].Id),
                                                     new Client("Dmitrii", "Agafonov", "Alekseevich", "aga@mail.ru", "4105255561", "89521238598", accounts[2].Id),
                                                     new Client("Pavel", "Smirnov", "Sergeevich", "petrov@mail.ru", "4001255511", "89501234578", accounts[3].Id),
                                                     new Client("Mikhail", "Popov", "Dmitrievich", "popv@mail.ru", "4501285511", "89501235589", accounts[4].Id)};

            Deposit[] deposits = new Deposit[] { new Deposit(clients[0].Id, managers[0].Id), new Deposit(clients[1].Id, managers[1].Id),
                                                         new Deposit(clients[2].Id, managers[2].Id),new Deposit(clients[3].Id, managers[3].Id),
                                                        new Deposit(clients[4].Id, managers[4].Id),};
          
            
            AddElementToDb(managers);
            AddElementToDb(accounts);
            AddElementToDb(clients);
            AddElementToDb(deposits);

        }
    }
}
