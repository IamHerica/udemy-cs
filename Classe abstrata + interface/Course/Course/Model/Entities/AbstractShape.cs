using System;
using System.Collections.Generic;
using System.Text;
using Course.Model.Enum;

namespace Course.Model.Entities
{
    abstract class AbstractShape : IShape //subtipo da interface IShape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
