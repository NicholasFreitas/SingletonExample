using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var importerService = ImporterServiceFactory.GetInstance();

            var importerFactory = importerService.GetImporterFactory();

            var prospect = importerFactory.GetNewProspect();

            var prospectStrat = importerFactory.GetProspectStrategy();

            var prospectImporter = importerFactory.GetProspectImporter();


            prospectImporter.UseStrategy(prospectStrat);
            prospectImporter.Import(prospect);

        }
    }
}
