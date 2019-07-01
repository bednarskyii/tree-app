using System;
using System.Collections.Generic;
using System.Text;
using Tree.DAL.Entities.ConcreteEntities;

namespace Tree.DAL.Entities.Layers
{
    public class CountryLayer
    {
        public int Id { get; set; }
        public Country Country { get; set; }
        public int IdCountry { get; set; }
        public OrganizationsLayer Parent { get; set; }
        public int IdParent { get; set; }

    }
}
