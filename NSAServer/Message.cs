using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NSAServer
{

    public enum MessageLevel
        {
            Information,
            Warning,
            Question,
            Error
        } 

    [Serializable()]
    public class Message
    {
        public readonly string Text;
        public readonly MessageLevel Level;

       public Message(string MessageText, MessageLevel level)
        {
            this.Text = MessageText;
            this.Level = level;
        }

        public Message()
        {
            throw new NotImplementedException("Not Implemented!");
        }

    }
}
