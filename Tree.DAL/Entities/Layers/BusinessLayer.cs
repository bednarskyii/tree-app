using System;
using System.Collections.Generic;
using System.Text;
using Tree.DAL.Entities.ConcreteEntities;

namespace Tree.DAL.Entities.Layers
{
    public class BusinessLayer
    {
        public int Id { get; set; }
        public Business Business { get; set; }
        public int IdBusiness { get; set; }
        public CountryLayer Parent { get; set; }
        public int IdParent { get; set; }

    }
}
