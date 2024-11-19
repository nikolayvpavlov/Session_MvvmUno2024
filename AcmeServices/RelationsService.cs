using AcmeServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcmeServices
{
    public class RelationsService
    {
        AcmeContext context;

        public RelationsService() 
        {
            context = new AcmeContext();
        }

        public async Task<List<Relation>> GetRelationsAsync(string search)
        {
            await Task.Delay(4000);
            if (string.IsNullOrWhiteSpace(search))
            {
                return context.Relations.ToList();
            }
            else
            {
                return context.Relations.Where(r => r.Name.Contains(search, StringComparison.CurrentCultureIgnoreCase)).ToList();
            }
        }

        public async Task<Relation> AddRelationAsync (Relation r)
        {
            await Task.Delay(2000);
            context.Relations.Add (r);
            return r;
        }

        public async Task<bool> DeleteRelationAsync(int relationId)
        {
            await Task.Delay(2000);
            var toDelete = context.Relations.Find (r => r.Id == relationId);
            context.Relations.Remove(toDelete);
            return toDelete != null;
        }
    }
}
