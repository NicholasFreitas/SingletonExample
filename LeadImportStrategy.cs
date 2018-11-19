using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonExample
{
    class LeadImportStrategy : IImportStrategy
    {
        public void Import(ILeadType lead)
        {
            Console.WriteLine("Importing with Lead Import Strategy");
        }
    }
}
