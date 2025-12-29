using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp
{
    public static class GeneralUses
    {
        public static int Rno;
        static GeneralUses()
        {
            Rno = 1;
            
        }

        public static int GetRno()
        {
            return Rno;
        }
    }
}
