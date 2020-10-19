using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Chapter16
{
    [Description("Listing 16.2")]
    class CallerInfoDemo
    {
        static void ShowInfo([CallerFilePath] string file = null,
                             [CallerLineNumber] int line = 0,
                             [CallerMemberName] string member = null)
        {
            Console.WriteLine("{0}:{1} - {2}", file, line, member);
        }

        static void Main()
        {
            ShowInfo(); // Ask the compiler to fill in everything
            ShowInfo("LiesAndDamnedLies.java", -10); // Only the member name will be filled in
        }
    }
}
