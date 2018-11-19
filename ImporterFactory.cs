using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonExample
{
    class ImporterFactory : IImporterFactory
    {
        public IImporter GetCustomerImporter()
        {
            return new CustomerImporter();
        }

        public IImportStrategy GetCustomerStrategy()
        {
            return new CustomerImportStrategy();
        }

        public IImporter GetLeadImporter()
        {
            return new LeadImporter();
        }

        public IImportStrategy GetLeadStrategy()
        {
            return new LeadImportStrategy();
        }

        public ILeadType GetNewCustomer()
        {
            return new Customer();
        }

        public ILeadType GetNewLead()
        {
            return new Lead();
        }

        public ILeadType GetNewProspect()
        {
            return new Prospect();
        }

        public IImporter GetProspectImporter()
        {
            return new ProspectImporter();
        }

        public IImportStrategy GetProspectStrategy()
        {
            return new ProspectImportStrategy();
        }
    }
}
