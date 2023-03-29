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

            ConditionalDirective_SpecificDotNet();

            ConditionalDirective_CustomDefinition();
            StaticRoutines.ConditionalDirective_CustomDefinition();


            // No conditional compiler directive, therefore gets executed all the time
            ContinueAfterKeyPress();
        }

        #region Private Static Methods

        private static void ContinueAfterKeyPress()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }



        private static void ConditionalDirective_DebugVsRelease()
        {
            Console.WriteLine();

#if DEBUG
            Console.WriteLine("Debug Mode");
#else
            Console.WriteLine("Release Mode");
#endif
        }

        private static void ConditionalDirective_SpecificDotNet()
        {
            Console.WriteLine();

#if NETCOREAPP
            Console.WriteLine("Running a .Net Core application");
#endif

#if NET5_0
            Console.WriteLine("Running a .Net Core 5 application");
#endif

#if NET6_0_OR_GREATER
            Console.WriteLine("Running a .Net Core 6 or higher application");
#endif

#if NETFRAMEWORK
            Console.WriteLine("Running a .Net Full Framework application");
#endif
        }


        private static void ConditionalDirective_CustomDefinition()
        {
            Console.WriteLine();

// Manually added via VS
#if MYCUSTOM_1
            Console.WriteLine("Using MYCUSTOM_1 definition from Program");
#endif

// Manually added at top of file
#if (MYCUSTOM_2) || (MYCUSTOM_2 == true)
            Console.WriteLine("Using MYCUSTOM_2 definition from Program");
#endif

        }


        #endregion
    }
}
