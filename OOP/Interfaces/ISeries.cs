using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Interfaces
{
    internal interface ISeries
    {
        int Current { get; set; }

        void GetNext();

        //void Reset();
        void Reset()
        {
            Current = 0;
        }
    }


    class SeriesByTwo : ISeries
    {
        public int Current { get; set; }
        public void GetNext()
        {
            Current += 2;
        }
    }
    class SeriesByThree : ISeries
    {
        public int Current { get; set; }
        public void GetNext()
        {
            Current += 3;
        }
    }

    class SeriesByFive : ISeries
    {
        public int Current { get; set; }

        public void GetNext()
        {
            Current += 5;
        }
    }


    class SeriesBySeven : ISeries
    {
        public int Current { get; set; }
        public void GetNext()
        {
            Current += 7;
        }
    }
}
