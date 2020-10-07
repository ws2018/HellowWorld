using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Core.Models
{
    /// <summary>
    /// Contract for message data models
    /// </summary>
    public interface IMessageData
    {
        public string MessageKey { get; set; }
        public string MessageValue { get; set; }
    }
}
