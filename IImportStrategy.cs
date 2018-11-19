using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonExample
{
    interface IImportStrategy
    {
        void Import(ILeadType lead);
    }
}
