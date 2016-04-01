using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht2
{
    class Program
    {
        static void Main(string[] args)
        {
            Message m = new Message("hallo");

            List<Message> lijst = new List<Message>();
            lijst.Add(m);

            MessageQueue q = new MessageQueue(lijst);
        }
    }
}
