using System;
using System.Reflection;
using System.Globalization;
using HelloWorld.Core;

namespace HelloWorld.Api
{
    /// <summary>
    /// .Net Core library API which can support mobile, web, or Console applications, or Windows services.
    /// </summary>
    public class Message : IMessage
    {
        public string GetMessage(MessageSourceProvider messageProvider, string messageKey)
        {
            if (messageProvider == MessageSourceProvider.ResourceSetting)
            {
                var msg = Resources.ResourceManager.GetString(messageKey, CultureInfo.CurrentCulture);
                return msg;
            }
            else
            {
                throw new NotImplementedException();
            }
            
        }

        public bool WriteMessage(MessageOutputProvider outputProvider, string message)
        {
            if (outputProvider == MessageOutputProvider.Console)
            {
                Console.WriteLine(message);
                return true;
            }
            else
            {
                throw new NotImplementedException();
            }
            
        }
    }
}
