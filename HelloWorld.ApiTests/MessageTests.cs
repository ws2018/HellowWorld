using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorld.Api;
using System;
using System.Collections.Generic;
using System.Text;
using HelloWorld.Core;

namespace HelloWorld.Api.Tests
{
    [TestClass()]
    public class MessageTests
    {
        IMessage _messageService = null;
       
        IMessage MessageService
        {
            get
            {
                if(_messageService == null)
                {
                    _messageService = new Message();
                }
                return _messageService;
            }
            
        }
           
        [TestMethod()]
        public void GetMessageTest_FromResourceSetting()
        {
            var message = MessageService.GetMessage(MessageSourceProvider.ResourceSetting, "OutputMessage");
            Assert.AreEqual("Hello World", message);
        }

        [TestMethod()]
        public void WriteMessageTest_ByUseConsole()
        {
            bool successful = MessageService.WriteMessage(MessageOutputProvider.Console, "Hello World");
            Assert.IsTrue(successful);
        }
        [TestMethod()]
        public void GetMessageTest_NotImplemented()
        {
            Assert.ThrowsException<NotImplementedException>(()=>MessageService.GetMessage(MessageSourceProvider.Database, "OutputMessage"));
        }

        [TestMethod()]
        public void WriteMessageTest_NotImplemented()
        {
            Assert.ThrowsException<NotImplementedException>(() => MessageService.WriteMessage(MessageOutputProvider.Database, "Hello World"));
        }
    }
}