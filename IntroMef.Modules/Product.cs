using System.ComponentModel.Composition;
using IntroMef.Interfaces;

namespace IntroMefEn
{
    [Export(typeof(IModule))]
    public class Product : IModule
    {
        public Product()
        {
            Title = "Products";
        }
        public string Title { get; set; }
    }
}