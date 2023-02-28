using dotnetmysl.Entities.Entities;


namespace dotnetmysl.Data.Interfaces
{
    public interface IEntityRepository : IGetById<Entity>, IGetAll<Entity>, ISave<Entity>, IUpdate<Entity>, IDelete<int>
    {
    }
}
