using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MeltingState : IGlassState
    {
        public void HandleOperation(GlassCreator glassCreatorContext)
        {
            StringBuilder message = new StringBuilder();
            message.Append("3)\n Now the mix is being melted");
            message.Append("\n (The melted mix will result in a mellow mass that becomes glass)");
            Console.WriteLine(message);
            glassCreatorContext.GlassState = new MoldingState();
            glassCreatorContext.GlassState.HandleOperation(glassCreatorContext);
        }
    }
}
