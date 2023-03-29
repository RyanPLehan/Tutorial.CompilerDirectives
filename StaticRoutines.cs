//#define MYCUSTOM_2
//#undef MYCUSTOM_1
using System;

namespace Tutorial.CompilerDirectives
{
    internal class StaticRoutines
    {
        public static void ConditionalDirective_CustomDefinition()
        {
            Console.WriteLine();

// Manually added via VS
#if MYCUSTOM_1
            Console.WriteLine("Using MYCUSTOM_1 definition from StaticRoutines");
#endif

 // Manually added at top of file
#if (MYCUSTOM_2) || (MYCUSTOM_2 == true)
            Console.WriteLine("Using MYCUSTOM_2 definition from StaticRoutines");
#endif
        }
    }
}
