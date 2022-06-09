using Installers.Core;

namespace FactoryMethod
{
    public abstract class FactoryInstaller<IdType, ProductType> : MonoInstaller<IFactory<IdType, ProductType>> where ProductType : IIdentifiable<IdType>
    {
        protected abstract override IFactory<IdType, ProductType> GetData();
    }
}