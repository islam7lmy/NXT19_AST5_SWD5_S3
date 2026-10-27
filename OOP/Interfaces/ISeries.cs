using Comman;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Interfaces
{
    class SeriesByThree : SeriesBase
    {
        public override void GetNext()
        {
            Current += 3;
        }
    }

    class SeriesByFive : SeriesBase
    {

        public override void GetNext()
        {
            Current += 5;
        }
    }


    class SeriesBySeven : SeriesBase
    {
        public override void GetNext()
        {
            Current += 7;
        }
    }
}
