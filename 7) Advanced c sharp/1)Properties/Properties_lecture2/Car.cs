using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties_lecture2
{
    internal class Car
    {
        private string _color;
        private string _brand;

        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }
        public string Brand
        {
            get { return _brand; }
            set
            {
                if(isBrandValid(value))
                {
                    _brand = value;
                }
                else
                {
                    Console.WriteLine("Invalid brand");
                }
            }
        }

        private bool isBrandValid(string brand)
        {
            List<string> brandNames = new List<string> { "Honda", "Toyota", "Ford" };
            if (brandNames.Contains(brand))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
