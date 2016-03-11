using System;
using System.Collections.Generic;
using System.Text;

namespace Math_App.Models
{
    public class Equation
    {
        public String name;
        public String image;

        public Equation(String name, String im)
        {
            this.name = name;
            this.image = im;
        }

        public override string ToString()
        {
            return this.name + this.image + "  sss";
        }

        public String getName()
        {
            return this.name;
        }

        public String getImage()
        {
            return this.image;
        }
    }
}
