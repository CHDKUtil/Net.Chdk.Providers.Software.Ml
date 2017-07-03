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

        public override string ProductName => "ML";

        protected override string CategoryName => "EOS";
    }
}
