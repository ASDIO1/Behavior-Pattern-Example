using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class GlassCreator
    {
        private IGlassState _glassState;

        public GlassCreator()
        {
            _glassState = new FinishedGlassState();
        }

        public IGlassState GlassState
        {
            get
            {
                return _glassState;
            }
            set
            {
                _glassState = value;
            }
        }
        public void CreateGlass()
        {
            Console.WriteLine("Glass creation starting...");
            _glassState = new SandState();
            _glassState.HandleOperation(this);
        }
    }
}
