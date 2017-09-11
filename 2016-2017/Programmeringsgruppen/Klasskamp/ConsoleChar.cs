using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasskamp
{
    class ConsoleChar
    {
        public char chr;
        public ConsoleColor foreground, background;
        
        public ConsoleChar(char chr, ConsoleColor foreground, ConsoleColor background)
        {
            this.chr = chr;
            this.foreground = foreground;
            this.background = background;
        }
    }
}
