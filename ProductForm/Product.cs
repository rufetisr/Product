using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductForm
{
    public class Product
    {
        public string? Name { get; set; }
        public string? OriginCountry { get; set; }
        public string? Cost { get; set; }
        public override string ToString() => $"{Name}\n{OriginCountry}\n{Cost}";
    }
}
