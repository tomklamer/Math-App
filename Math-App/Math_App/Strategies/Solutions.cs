using System;
using System.Collections.Generic;
using System.Text;

namespace Math_App.Strategies
{
    public abstract class Solutions
    {
        private string type;
        private string value;

        public Solutions(string type, string value)
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

    public class Oplossing1 : Solutions
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

