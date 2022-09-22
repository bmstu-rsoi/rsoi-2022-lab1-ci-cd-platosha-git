using System.Collections.Generic;

namespace People.Repositories
{
    public enum ExitCode
    {
        Success,
        Constraint,
        Error
    }
    
    public interface CrudRepository<T, ID>
    {
        List<T> FindAll();
        T FindById(ID id);
        ExitCode Add(T obj);
        ExitCode Update(T obj);
        ExitCode DeleteById(ID id);
    }
}