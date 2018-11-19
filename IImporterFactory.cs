using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonExample
{
    interface IImporterFactory
    {
        IImporter GetProspectImporter();
        IImporter GetLeadImporter();
        IImporter GetCustomerImporter();

        IImportStrategy GetLeadStrategy();
        IImportStrategy GetProspectStrategy();
        IImportStrategy GetCustomerStrategy();

        ILeadType GetNewCustomer();
        ILeadType GetNewLead();
        ILeadType GetNewProspect();
    }
}
