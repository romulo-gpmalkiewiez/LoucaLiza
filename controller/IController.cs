namespace LoucaLiza.controller
{
    public interface IController<T>
    {
        T Save(T entity);

        bool Delete(T entity);
    }
}
