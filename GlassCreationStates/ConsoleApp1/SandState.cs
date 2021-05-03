using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class SandState : IGlassState
    {
        public void HandleOperation(GlassCreator glassCreatorContext)
        {
            StringBuilder message = new StringBuilder();
            message.Append("1)\nFirst of all, enough sand is poured in the machine");
            message.Append("\n(Sand is the first state of glass and the main ingredient for making glass)");
            Console.WriteLine(message);
            glassCreatorContext.GlassState = new MixingState();
            glassCreatorContext.GlassState.HandleOperation(glassCreatorContext);
        }
    }
}
