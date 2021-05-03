using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class FinishedGlassState : IGlassState
    {
        public void HandleOperation(GlassCreator glassCreatorContext)
        {
            StringBuilder message = new StringBuilder();
            message.Append("5)\n The molded mellow mass dries and we obtain glass");
            message.Append("\n The glass creation process is finished.");
            Console.WriteLine(message);
        }
    }
}
