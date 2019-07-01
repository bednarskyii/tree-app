using System;
using System.Collections.Generic;
using System.Text;
using Tree.DAL.Entities.ConcreteEntities;

namespace Tree.DAL.Entities.Layers
{
    public class DepartmentLayer
    {
        public int Id { get; set; }
        public Department Department { get; set; }
        public int IdDepartment { get; set; }
        public OfferingLayer Parent {get; set; }
        public int IdParent { get; set; }

    }
}
