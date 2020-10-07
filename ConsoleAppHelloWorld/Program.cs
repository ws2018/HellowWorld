using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using HelloWorld.Api;
using HelloWorld.Core;
using HelloWorld.Core.Models;

namespace HelloWorld.ConsoleApp
{
    /// <summary>
    /// Console app to get and write message retrieved from specific data resources.
    /// </summary>
    class Program
    {
        private static readonly string _messageKey = "OutputMessage";
        static void Main(string[] args)
        {
            //setup DI
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IMessage, Message>()
                .BuildServiceProvider();
         
            var messageService = serviceProvider.GetService<IMessage>();
            var message = messageService.GetMessage(MessageSourceProvider.ResourceSetting, _messageKey);

            messageService.WriteMessage(MessageOutputProvider.Console,message);
            Console.ReadKey();
        }
    }
}
