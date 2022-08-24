using Installers.Core;
using UnityEngine;

namespace FactoryMethod
{
    public class DictionaryFactoryInstaller<IdType, ProductType> : FactoryInstaller<IdType, ProductType> where ProductType : IIdentifiable<IdType>
    {
        [Header("References")]
        [SerializeField] private MonoInstaller<ProductType>[] _productInstallers;

        protected override IFactory<IdType, ProductType> GetData()
        {
            int totalProducts = _productInstallers.Length;
            ProductType[] products = new ProductType[totalProducts];

            for (int i = 0; i < totalProducts; i++)
            {
                products[i] = _productInstallers[i].Data;
            }

            return new DictionaryFactory<IdType, ProductType>(products);
        }
    }
}