using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public class TATACAR
    {
        Iengine _engine =null;
        public TATACAR(Iengine engine)
        {
            this._engine = engine;
        }


        public void Drive()
        {

            _engine.start();
        }
        public void Halt()
        {

            _engine.stop();
        }
    }
    public interface Iengine
    {
        void start();
        void stop();
    }
    public class DiCorEngine : Iengine
    {

        public void start() { }
        public void Stop() { }
    }

    public class VeriCorEngine : Iengine
    {
        public void start() { }
        public void Stop() { }

    }

    public class MultiJetEngine : Iengine
    {
        public void start() { }
        public void Stop() { }
    }


}
