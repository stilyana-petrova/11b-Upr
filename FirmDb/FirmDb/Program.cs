using FirmDb.Data;
using FirmDb.Presentation;
using System;

namespace FirmDb
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeContext context = new EmployeeContext();
            context.Database.EnsureCreated();
            Display display = new Display();
        }
    }
}
