using Facade;
using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            UserFacade userFacade = new UserFacade();

            userFacade.RegisterUser("Alice", "alice@example.com");
            userFacade.RegisterUser("Bob", "@@");
        }
    }
}