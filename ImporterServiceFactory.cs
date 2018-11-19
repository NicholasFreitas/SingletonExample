using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonExample
{
    class ImporterServiceFactory
    {
        static ImporterServiceFactory ImporterService;

        private ImporterServiceFactory()
        {
        }

        public static ImporterServiceFactory GetInstance()
        {
            if (ImporterService == null)
                ImporterService = new ImporterServiceFactory();

            return ImporterService;
        }

        public IImporterFactory GetImporterFactory()
        {
            return new ImporterFactory();
        }

    }
}
