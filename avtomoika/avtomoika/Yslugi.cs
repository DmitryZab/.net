using System;
using System.Collections.Generic;
using System.Text;

namespace avtomoika
{
    class Yslugi
    {
        public Yslugi(string name, int price)
        {
            Name = name;
            Price = price;
        }
        public string Name { get; set; }
        public int Price { get; set; }

        public override string ToString()
        {
            return ($"Услуга  '{Name}'  цена '{Price}' ");
        }
    }
}
