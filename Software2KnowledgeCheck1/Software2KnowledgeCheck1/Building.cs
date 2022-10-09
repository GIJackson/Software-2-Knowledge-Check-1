using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software2KnowledgeCheck1
{
    internal class Building
    {
        public string Street { get; set; }

        public int StreetNumber { get; set; }

        public static void Add(Building building)
        {
            List<Building> buildings = new();
            buildings.Add(building);
        }
    }
}
