using Microsoft.Extensions.Logging;
using Net.Chdk.Providers.Software.Product;

namespace Net.Chdk.Providers.Software.Ml
{
    sealed class MlSourceProvider : ProductSourceProvider
    {
        public MlSourceProvider(ILoggerFactory loggerFactory)
            : base(loggerFactory.CreateLogger<MlSourceProvider>())
        {
        }

        protected override string CategoryName => "EOS";
        protected override string ProductName => "ML";
    }
}
