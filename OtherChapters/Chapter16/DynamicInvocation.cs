using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Chapter16
{
    [Description("Listing 16.4")]
    class DynamicInvocation
    {
        class TypeUsedDynamically
        {
            internal void ShowCaller([CallerMemberName] string caller = "Unknown")
            {
                Console.WriteLine("Called by: {0}", caller);
            }
        }

        static void Main()
        {
            dynamic x = new TypeUsedDynamically();
            x.ShowCaller();
        }
    }
}
