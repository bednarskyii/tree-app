using System;
using System.Collections.Generic;
using System.Text;
using Tree.DAL.Entities.ConcreteEntities;

namespace Tree.DAL.Entities.Layers
{
    public class OfferingLayer
    {
        public int Id { get; set; }
        public Offering Offering { get; set; }
        public int IdOffering { get; set; }
        public FamilyLayer Parent { get; set; }
        public int IdParent { get; set; }

    }
}
