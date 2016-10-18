using System.ComponentModel.Composition;
using IntroMef.Interfaces;

namespace IntroMefEn
{
    [Export(typeof(IModule))]
    public class Supplier : IModule
    {
        public Supplier()
        {
            Title = "Suppliers";
        }
        public string Title { get; set; }
    }
}