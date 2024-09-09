using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator.Services
{

    public class GreetingService(): IGreetingService
    {
        private readonly ILogger<GreetingService> _log;

        public GreetingService(ILogger<GreetingService> log): this()
        {
            this._log = log;
        }

        public void Greeting()
        {
            Console.WriteLine("Please enter your name for a personalized greeting.");
            string username = Console.ReadLine();
            _log.LogInformation(username);
            string message = ($"Hello, {username}\nAnd Goodbye");
            Console.WriteLine(message);
            _log.LogInformation(message);
        }
    }

}
