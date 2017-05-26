using Net.Chdk.Providers.Software.Product;

namespace Net.Chdk.Providers.Software.Ml
{
    sealed class MlSourceProvider : ProductSourceProvider
    {
        protected override string ProductName => "ML";
    }
}
