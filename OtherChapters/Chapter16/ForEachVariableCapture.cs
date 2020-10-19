using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Chapter16
{
    [Description("Listing 16.1")]
    class ForEachVariableCapture
    {
        static void Main()
        {
            string[] values = { "x", "y", "z" };
            var actions = new List<Action>();

            foreach (string value in values)
            {
                actions.Add(() => Console.WriteLine(value));
            }

            foreach (Action action in actions)
            {
                action();
            }
        }
    }
}
