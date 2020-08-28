using System;
using System.Collections.Generic;
using System.Text;

namespace Exsamen2._0
{
    public abstract class Entity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
    }
}
