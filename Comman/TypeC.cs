using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comman
{
    public struct TypeC
    {
        /// Allowed Access Modifiers Inside The struct
        /// 1. private [default]
        /// 2. internal
        /// 3. public
        
        int x; //private => allow to access by struct memeber only
        internal int y; //internal => allow to access by struct memeber and same assembly only
        public int z; //public => allow to access by struct memeber and same assembly and other assembly

        void test()
        {
            x = 10; // valid because x is private and we are inside the struct
            y = 20; // valid because y is internal and we are inside the struct
            z = 30; // valid because z is public and we are inside the struct
        }
    }
}
