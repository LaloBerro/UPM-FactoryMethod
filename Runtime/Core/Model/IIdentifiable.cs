namespace FactoryMethod
{
    public interface IIdentifiable<IdType>
    {
        IdType Id { get; }
    }
}