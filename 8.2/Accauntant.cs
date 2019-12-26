using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _8._2.Program;

namespace _8._2
{
    class Accauntant
    {
        public bool AskForBonus(Post worker, int hour)
        {
            if ((int)worker <= hour)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
