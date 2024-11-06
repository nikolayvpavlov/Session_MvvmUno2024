using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AcmeServices.Models
{
    public class AcmeContext
    {
        private static List<Relation> inMemoryRelations { get; set; }

        static AcmeContext()
        {
            inMemoryRelations = new List<Relation>()
            {
                new Relation() { Id = 1, Name = "Bright Roads Company Ltd.", Country = "USA" },                
                new Relation() { Id = 2, Name = "Slinky Services Co.", Country = "USA"},
                new Relation() { Id = 3, Name = "Naughty Nutgoblins Inc.", Country = "UK"},
                new Relation() { Id = 4, Name = "Derriér Inc.", Country = "France"},
                new Relation() { Id = 5, Name = "Bright Future Railroads", Country = "Bulgaria" },
            };
        }

        public List<Relation> Relations => inMemoryRelations;
    }
}
