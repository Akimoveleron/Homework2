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

        DbManagement.AddElementToDb(new Manager("Ivan2", "Ivanov2", "Ivanovich2", "ivan2@mail.ru", Position.SalesManager, "5223"));
        DbManagement.GetAllData();


    }
}