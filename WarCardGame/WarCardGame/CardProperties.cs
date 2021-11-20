using System;
using System.Collections.Generic;
using System.Text;
namespace WarCardGame
{
    public class CardProperties
    {
        public ShapeEnum shape;
        public NumberEnum number;

        public CardProperties(ShapeEnum s, NumberEnum n)
        {
            this.shape = s;
            this.number = n;
        }
    }
}
