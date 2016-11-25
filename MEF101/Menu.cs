using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEF101
{
    public class Menu
    {
        [Import]
        private Module _module;

        public void OptionList()
        {
            Console.WriteLine(_module.Title);
        }
    }

    [Export]
    public class Module
    {
        public Module()
        {
            Title = "Customers";
        }
        public string Title { get; set; }
    }
}
