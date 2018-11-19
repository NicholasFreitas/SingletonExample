using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonExample
{
    interface IImporter
    {
        void Import(ILeadType lead);
        void UseStrategy(IImportStrategy strategy);
    }
}
