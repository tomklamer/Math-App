using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CToets
{
    public abstract class Solution
    {
        private string type;
        private string value;

        public Solution(string type, string value)
        {
            this.type = type;
            this.value = value;
        }

        public string getType()
        {
            return this.type;
        }

        public string getValue()
        {
            return this.value;
        }
    }

    public class Oplossing1 : Solution
    {
        private string type;
        private string value;

        public Oplossing1(string type, string value) : base(type, value)
        {
            this.type = type;
            this.value = value;
        }
    }
}
