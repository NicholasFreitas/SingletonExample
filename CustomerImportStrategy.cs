using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonExample
{
    class CustomerImportStrategy : IImportStrategy
    {
        public void Import(ILeadType lead)
        {
            Console.WriteLine("Customer Import Strategy");
        }
    }
}
