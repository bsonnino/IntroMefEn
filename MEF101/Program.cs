using System;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Reflection;

namespace MEF101
{
    class Program
    {
        static void Main(string[] args)
        {
            var catalog = new AssemblyCatalog(Assembly.GetExecutingAssembly());
            var container = new CompositionContainer(catalog);
            var menu = new Menu();
            container.ComposeParts(menu);
            menu.OptionList();
            Console.ReadLine();
        }
    }
}
