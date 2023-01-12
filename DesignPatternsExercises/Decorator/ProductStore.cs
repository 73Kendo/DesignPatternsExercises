using Common;
using DesignPatternsExercises.FactoryMethod.Model;
using Newtonsoft.Json;
using System.Security.Cryptography;
using System.Text;

namespace DesignPatternsExercises.Decorator
{
    internal interface IProductStore
    {
        string Serialize(IEnumerable<Product> products);
        IEnumerable<Product> Deserialize(string content);
    }

    internal class ProductStore : IProductStore
    {
        public IEnumerable<Product> Deserialize(string content)
        {
            return JsonConvert.DeserializeObject<IEnumerable<Product>>(content) ?? Enumerable.Empty<Product>();
        }

        public string Serialize(IEnumerable<Product> products)
        {
            return JsonConvert.SerializeObject(products);
        }
    }

    internal abstract class ProductStoreDecorator : IProductStore
    {
        private readonly IProductStore _productStore;

        public ProductStoreDecorator(IProductStore productStore)
        {
            _productStore = productStore;
        }

        public abstract IEnumerable<Product> Deserialize(string content);
        public abstract string Serialize(IEnumerable<Product> products);
    }

    internal class EcryptedProductStoreDecorator : IProductStore
    {
        private readonly IProductStore _productStore;

        public EcryptedProductStoreDecorator(IProductStore productStore)
        {
            this._productStore = productStore;
        }

        public IEnumerable<Product> Deserialize(string content)
        {
            return _productStore.Deserialize(content.DesDecrypt());
        }

        public string Serialize(IEnumerable<Product> products)
        {
            return _productStore.Serialize(products).DesCrypt();
        }
    }

}
