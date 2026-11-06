using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Delegates
{
    internal class StringFunction
    {
        public static int GetCountOfUpperCaseChar(string Name)
        {
            int count = 0;
            foreach (char c in Name)
            { 
                if(char.IsUpper(c))
                    count++;
            }
            return count;
        }

        public static int GetCountOfLowerCaseChar(string Name)
        {
            int count = 0;
            foreach (char c in Name)
            {
                if (char.IsLower(c))
                    count++;
            }
            return count;
        }
    }
}
