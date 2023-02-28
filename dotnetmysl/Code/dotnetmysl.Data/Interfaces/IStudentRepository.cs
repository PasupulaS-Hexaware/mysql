using dotnetmysl.Entities.Entities;


namespace dotnetmysl.Data.Interfaces
{
    public interface IStudentRepository : IGetById<Student>, IGetAll<Student>, ISave<Student>, IUpdate<Student>, IDelete<int>
    {
    }
}
