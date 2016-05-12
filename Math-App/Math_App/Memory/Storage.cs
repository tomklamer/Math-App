using System;
using System.Collections.Generic;
using System.Text;

namespace Math_App.Memory
{
    public class Storage
    {
        private string[] storage = new string[5];

        // add string to array - remove string - reorder array
        public void AddEquation(string value)
        {
            Remove();
            storage[0] = value;
        }

        // remove and reorder array
        public void Remove()
        {           
            for(int i = 4; i > 0; i--)
            {
                if(storage[i-1] != null)
                {
                    storage[i] = storage[i - 1];
                }
            }

            storage[0] = null;
        }

        // return string of array position
        public string ReturnEquation(int value)
        {
            return storage[value];
        }

        // check if array position is not null
        public bool CheckIfEmpty(int value)
        {
            if (storage[value] != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
