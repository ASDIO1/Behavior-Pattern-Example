using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MixingState : IGlassState
    {
        public void HandleOperation(GlassCreator glassCreatorContext)
        {
            StringBuilder message = new StringBuilder();
            message.Append("2)\n Sand is mixed with other ingredients");
            message.Append("\n (This other ingredients are: 'sosa' and 'Cal')");
            Console.WriteLine(message);
            glassCreatorContext.GlassState = new MeltingState();
            glassCreatorContext.GlassState.HandleOperation(glassCreatorContext);
        }
    }
}
