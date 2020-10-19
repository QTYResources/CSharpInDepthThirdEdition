using System;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Reflection;

namespace QueryableDemo
{
    class Logger
    {
        static internal void Log(object instance,
                                 Expression expression)
        {
            StackFrame frame = new StackTrace().GetFrame(1);
            MethodBase method = frame.GetMethod();
            Type type = instance.GetType();
            string typeName = type.Name;

            if (type.IsGenericType)
            {
                Type[] genericArgs = type.GetGenericArguments();
                typeName = typeName.Replace("`1", "<"+genericArgs[0].Name+">");
            }
            Console.WriteLine("{0}.{1}", typeName, method.Name);

            Console.WriteLine("Expression={0}", expression);
            Console.WriteLine();
        }
    }
}
