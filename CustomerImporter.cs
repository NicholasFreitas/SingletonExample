using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonExample
{
    class CustomerImporter : IImporter
    {
        IImportStrategy CurrentStrategy;

        public void Import(ILeadType lead)
        {
            CurrentStrategy.Import(lead);
        }

        public void UseStrategy(IImportStrategy strategy)
        {
            CurrentStrategy = strategy;
        }
    }
}
