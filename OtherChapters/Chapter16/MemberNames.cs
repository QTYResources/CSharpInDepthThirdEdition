using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Chapter16
{
    [AttributeUsage(AttributeTargets.All)]
    public class MemberDescriptionAttribute : Attribute
    {
        public MemberDescriptionAttribute([CallerMemberName] string member = null)
        {
            Member = member;
        }

        public string Member { get; set; }
    }

    [Description("Listing 16.3")]
    [MemberDescription]
    class MemberNames
    {
        static MemberNames()
        {
            Log("Static constructor");
        }

        public event EventHandler DummyEvent
        { 
            add { Log("Event add"); }
            remove { Log("Event remove"); }
        }

        static string foo = Log("Static variable initializer (foo)");

        string bar = Log("Instance variable initializer (bar)");

        private string this[int x] { get { return Log("Indexer"); } }

        private string Property
        { 
            get { return Log("Property get"); } 
            set { Log("Property set"); }
        }
    
        private void Method() { Log("Method"); }

        MemberNames()
        {
            Log("Constructor");
        }
        
        ~MemberNames()
        {
            Log("Finalizer");
        }

        static void Main()
        {
            var instance = new MemberNames();
            instance.Property = instance[10] + instance.Property;
            EventHandler lambda = (sender, args) => Log("Lambda expression");
            lambda(null, EventArgs.Empty);
            instance.DummyEvent += lambda;
            instance.DummyEvent -= lambda;
            var attribute = (MemberDescriptionAttribute) typeof(MemberNames).GetCustomAttributes(typeof(MemberDescriptionAttribute), false)[0];
            Console.WriteLine("Attribute on type: {0}", attribute.Member);

            instance = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        static string Log(string message, [CallerMemberName] string member = null)
        {
            Console.WriteLine("{0}: {1}", message, member);
            return null; // Just for the variable initializers
        }
    }
}
