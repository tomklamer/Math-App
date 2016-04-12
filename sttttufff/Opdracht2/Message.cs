using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht2
{
    class Message
    {
        private string Msg;

        public Message()
        {
        }

        public Message(string msg)
        {
            this.Msg = msg;
        }

        public Message(MessageQueue mq)
        {
            string text= "";
            for (int i = 0; i < mq.ReturnList().Count; i++)
            {
                if(mq.ReturnList()[i] == null)
                {
                    text = text + "," + mq.ReturnList()[i];
                }
            }
            this.Msg = text;
        }

        public override string ToString()
        {
            return this.Msg;        
        }

    }
}
