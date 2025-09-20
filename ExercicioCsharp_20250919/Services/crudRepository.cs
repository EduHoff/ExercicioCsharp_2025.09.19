namespace ExercicioCsharp_20250919.Services;

public interface crudRepository<T, ID>
{
    public T save(T obj);
    public void delete(T obj);
    public T findById(ID id);
    public List<T> findAll();
}