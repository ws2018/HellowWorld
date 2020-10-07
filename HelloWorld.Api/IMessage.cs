using System;
using HelloWorld.Core;

namespace HelloWorld.Api
{
    public interface IMessage
    {
        string GetMessage(MessageSourceProvider messageProvider, string messageKey);
        bool WriteMessage(MessageOutputProvider outputProvider, string message);
    }
}
