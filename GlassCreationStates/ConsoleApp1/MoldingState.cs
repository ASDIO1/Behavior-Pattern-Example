using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MoldingState : IGlassState
    {
        public void HandleOperation(GlassCreator glassCreatorContext)
        {
            StringBuilder message = new StringBuilder();
            message.Append("4)\n The mellow mass is molded by molds and human artists");
            Console.WriteLine(message);
            glassCreatorContext.GlassState = new FinishedGlassState();
            glassCreatorContext.GlassState.HandleOperation(glassCreatorContext);
        }
    }
}
