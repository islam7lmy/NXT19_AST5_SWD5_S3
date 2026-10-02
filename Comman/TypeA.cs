using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comman
{
    /// What You Can Write Inside The Namesapce?
    /// enum
    /// class
    /// struct
    /// interface
    /// delegate
    /// record

    /// What You Can Write Inside The Enum?
    /// only labels => refer to number

    /// What You Can Write Inside The Class Or Struct?
    /// 1. variables => fields [attributes]
    /// 2. functions => methods
    /// 3. constructors => special method
    /// 4. properties
    /// 5. events
    /// 6. indexers

    /// What You Can Write Inside The Interface?
    /// 1.methods signature
    /// 2.properties signature
    /// 3.events signature
    /// 4.indexers signature
    /// 5.Default Implementations => C# 8.0


    /// Allowed Access Modifiers Inside The Namespace 
    /// 1. internal [Default access modifier]
    /// 2. public

    enum rank
    {
        junior,
        senior,
        teamlead
    }

    public class TypeA
    {
        /// Allowed Access Modifiers Inside The class
        ///1. private [default] 
        ///2. private protected => inhertance
        ///3. protected => inhertance
        ///4. internal
        ///5. protected internal => inhertance
        ///6. public

        int x; //private => allow to access by class memeber only
        internal int y; //internal => allow to access by class memeber and same assembly only
        public int z; //public => allow to access by class memeber and same assembly and other assembly

        void test()
        {
            rank myrank = rank.junior;
            x = 10; // valid because x is private and we are inside the class
            y = 20; // valid because y is internal and we are inside the class
            z = 30; // valid because z is public and we are inside the class

            TypeC c = new TypeC();
            //c.x = 10; // not valid because x is private and we are outside the struct
            c.y = 20; // valid because y is internal and we are inside the same assembly
            c.z = 30; // valid because z is public and we are inside the same assembly
        }
    }
}
