using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using Microsoft.Office.Interop.Excel;
using System.ComponentModel;
using System;

namespace Chapter01.CSharp4
{
    [Description("Listing 1.20")]
    class PythonProducts
    {
        static void Main()
        {
            ScriptEngine engine = Python.CreateEngine();
            ScriptScope scope = engine.ExecuteFile(@"CSharp4\FindProducts.py");
            dynamic products = scope.GetVariable("products");
            foreach (dynamic product in products)
            {
                Console.WriteLine("{0}: {1}", product.ProductName, product.Price);
            }
        }
    }
}
