using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comman
{
    ///prop Current => must be without public set
    ///Reset method must be default implment

    public interface ISeries
    {
        int Current { get; }
        void GetNext();
        void Reset();
    }

    public abstract class SeriesBase : ISeries
    {
        ///private protected => me and my sub classes => must be in same assembly 
        ///protected => me and my sub classes => in any assembly 
        ///internal => in same assembly 
        ///protected internal => available in my assembly for all using but in other assemblies only inhert class can access me 



        //fully implmented
        //public int Current { get; private protected set; }
        //public int Current { get; protected set; }
        //public int Current { get; internal set; }
        public int Current { get; protected internal set; }
        //abstract method not fully implmented
        public abstract void GetNext();
        //fully implmented
        public void Reset()
        {
            Current = 0;
        }
    }

    public class SeriesByTwo : SeriesBase
    {
        public override void GetNext()
        {
            Current += 2;
        }
    }

    class test
    {
        void test01()
        {
            SeriesByTwo s = new SeriesByTwo();
            s.Current = 20;
        }
    }
}
