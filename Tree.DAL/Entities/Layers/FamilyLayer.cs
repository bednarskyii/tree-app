using System;
using System.Collections.Generic;
using System.Text;
using Tree.DAL.Entities.ConcreteEntities;

namespace Tree.DAL.Entities.Layers
{
    public class FamilyLayer
    {
        public int Id { get; set; }
        public Family Family { get; set; }
        public int IdFamily { get; set; }
        public BusinessLayer Parent { get; set; }
        public int IdParent { get; set; }

    }
}
