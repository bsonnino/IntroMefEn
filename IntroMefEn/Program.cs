using System;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Reflection;

namespace IntroMefEn
{
    class Program
    {
        static void Main(string[] args)
        {
            var catalog = new AggregateCatalog(
                new AssemblyCatalog(Assembly.GetExecutingAssembly()),
                new DirectoryCatalog("."));
            var container = new CompositionContainer(catalog);
            var menu = new Menu();
            container.ComposeParts(menu);
            menu.OptionList();
            Console.ReadLine();
        }
    }
}
