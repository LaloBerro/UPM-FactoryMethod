namespace FactoryMethod
{
    public interface IFactory<IdType, ProductType>
    {
        ProductType Create(IdType id);
    }
}