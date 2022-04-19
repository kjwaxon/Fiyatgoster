using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiyat
{
    public abstract class Price
    {
        public abstract void ProductPrice();
    }
        public class elma : Price
    {
        public override void ProductPrice()
        {
            int elmaprice = 15;
            Console.WriteLine("Elmanın kilosu : "+elmaprice);
        }
    }
        public class kola : Price
    {
        public override void ProductPrice()
        {
            int kolaprice = 18;
            Console.WriteLine("Kolanın fiyatı : "+kolaprice);
        }
    }
}
