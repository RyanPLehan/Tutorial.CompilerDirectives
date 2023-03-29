#define MYCUSTOM_2

using System;


namespace Tutorial.CompilerDirectives
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Examples of using Compiler Directives
            ConditionalDirective_DebugVsRelease();
            ConditionalDirective_CustomDefinition();
            StaticRoutines.ConditionalDirective_CustomDefinition();

            ContinueAfterKeyPress();
        }

        private static void ContinueAfterKeyPress()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }



        private static void ConditionalDirective_DebugVsRelease()
        {
#if DEBUG
            Console.WriteLine("Debug Mode");
#else
            Console.WriteLine("Release Mode");
#endif
        }


        private static void ConditionalDirective_CustomDefinition()
        {
#if MYCUSTOM_1
            Console.WriteLine("Using MYCUSTOM_1 definition from Program");
#endif

#if MYCUSTOM_2
            Console.WriteLine("Using MYCUSTOM_2 definition from Program");
#endif

        }


    }
}
