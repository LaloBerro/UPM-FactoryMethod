using System.Collections.Generic;

namespace FactoryMethod
{
    public class DictionaryFactory<IdType, ProductType> : IFactory<IdType, ProductType> where ProductType : IIdentifiable<IdType>
    {
        private readonly Dictionary<IdType, ProductType> _products;

        public DictionaryFactory(ProductType[] products)
        {
            _products = new Dictionary<IdType, ProductType>();

            foreach (var product in products)
            {
                _products.Add(product.Id, product);
            }
        }

        public ProductType Create(IdType id)
        {
            if (!_products.ContainsKey(id))
                throw new System.Exception("Error on DictionaryFactory: There isn't a product with id: " + id);

            return _products[id];
        }
    }
}