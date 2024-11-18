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
                new Relation() { Id = 1, Name = "Bright Roads Company Ltd.", Country = "USA", Phone="+1 555 123456", ContactPerson="John Doe", },                
                new Relation() { Id = 2, Name = "Slinky Services Co.", Country = "USA", Phone="+1 555 3636999", ContactPerson="Jane Doe", },
                new Relation() { Id = 3, Name = "Naughty Nutgoblins Inc.", Country = "UK", Phone="+44 999 123456", ContactPerson="Ford Prefekt", },
                new Relation() { Id = 4, Name = "Derriér Inc.", Country = "France", Phone="+33 000 123456", ContactPerson="Loui De Fennêtre", },
                new Relation() { Id = 5, Name = "Bright Future Railroads", Country = "Bulgaria", Phone="+359 999 123456", ContactPerson="Ivan Poluivanov",  },
            };
        }

        public List<Relation> Relations => inMemoryRelations;
    }
}
