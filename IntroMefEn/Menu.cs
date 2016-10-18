using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using IntroMef.Interfaces;

namespace IntroMefEn
{
    public class Menu
    {
        [ImportMany]
        private IEnumerable<IModule> _modules;

        public void OptionList()
        {
            foreach (var module in _modules)
            {
                Console.WriteLine(module.Title);
            }
        }
    }
}