using ConsoleTables;
using HomeWork2;
using HomeWork2.Controllers;
using HomeWork2.Domain;
using HomeWork2.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

internal class Program
{
    private static void Main(string[] args)
    {

        DbManagement.AddFiveElemtnts();

        DbManagement.AddElementToDb(new Manager { FirstName = "Ivan2", LastName = "Ivanov2", Patronymic = "Ivanovich2", Email = "ivan2@mail.ru", ManagerPosition = Position.SalesManager, PhoneNumber = "5523" });
        DbManagement.GetAllData();


    }
}