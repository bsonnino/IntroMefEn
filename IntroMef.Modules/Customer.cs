using System.ComponentModel.Composition;
using IntroMef.Interfaces;

namespace IntroMefEn
{
    [Export(typeof(IModule))]
    public class Customer : IModule
    {
        public Customer()
        {
            Title = "Customers";
        }
        public string Title { get; set; }
    }
}