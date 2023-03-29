//#define MYCUSTOM_2
using System;

namespace Tutorial.CompilerDirectives
{
    internal class StaticRoutines
    {
        public static void ConditionalDirective_CustomDefinition()
        {
#if MYCUSTOM_1
            Console.WriteLine("Using MYCUSTOM_1 definition from StaticRoutines");
#endif

#if MYCUSTOM_2
            Console.WriteLine("Using MYCUSTOM_2 definition from StaticRoutines");
#endif
        }
    }
}
