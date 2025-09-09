using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class UserFacade
    {
        private DBService _dbService;
        private EmailValidator _validator;
        private EmailSender _emailSender;

        public UserFacade()
        {
            _dbService = new DBService();
            _validator = new EmailValidator();
            _emailSender = new EmailSender();
        }

        public void RegisterUser(string name, string email)
        {
            Console.WriteLine("Starting user registration...");

            if (!_validator.IsValid(email))
            {
                Console.WriteLine("Registration failed due to invalid email.");
                return;
            }

            _dbService.SaveUser(name, email);
            _emailSender.SendWelcome(email);

            Console.WriteLine("User registration completed successfully.");
        }
    }
}
